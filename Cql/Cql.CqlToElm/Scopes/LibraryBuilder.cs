using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Scopes;
using Hl7.Cql.Elm;
using Hl7.Cql.Model.Xml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal class LibraryBuilder
    {
        private static readonly VersionedIdentifier schemaIdentifier = new() { id = "urn:hl7-org:elm", version = "r1" };

        /// <summary>
        /// Creates a new instance from an existing library.  Its symbol table will be populated with its existing definitions.
        /// </summary>
        public static LibraryBuilder CreateFromExisting(Library library) => throw new NotImplementedException();

        public LibraryBuilder(VersionedIdentifier identifier, LocalIdentifierProvider localIdentifierProvider)
        {
            Identifier = identifier;
            SymbolTable = new SymbolTable(Identifier.ToString()!, null);
            CurrentScope = SymbolTable;
            LocalIdentifierProvider = localIdentifierProvider;
        }

        public VersionedIdentifier Identifier { get; set; }
        public LocalIdentifierProvider LocalIdentifierProvider { get; }
        internal string NextId() => LocalIdentifierProvider.Next();
        /// <summary>
        /// Builds a library from the current state of the builder.
        /// </summary>
        public Library Build()
        {
            var symbols = SymbolTable;
            var expressionDefs = symbols.OfType<ExpressionDef>()
                .Concat(symbols.OfType<DeferredExpressionDef>().Select(dd => dd.Resolve()));
            var functionDefs = symbols.OfType<FunctionDef>()
                .Concat(symbols.OfType<OverloadedFunctionDef>()
                    .SelectMany(od => od.Functions.Select(f => f switch
                    {
                        FunctionDef fd => fd,
                        DeferredFunctionDef dfd => dfd.Resolve(),
                        _ => throw new NotSupportedException("Unknown function element type")
                    })))
                .Concat(symbols.OfType<DeferredFunctionDef>().Select(dfd => dfd.Resolve()));
            var statements = expressionDefs
                .Concat(functionDefs)
                .ToArray();
            return new Library
            {
                identifier = Identifier,
                schemaIdentifier = schemaIdentifier,
                usings = symbols.OfType<UsingDef>().ToArray(),
                includes = symbols.OfType<IncludeDef>().ToArray(),
                parameters = symbols.OfType<ParameterDef>().ToArray(),
                codeSystems = symbols.OfType<CodeSystemDef>().ToArray(),
                valueSets = symbols.OfType<ValueSetDef>().ToArray(),
                codes = symbols.OfType<CodeDef>().ToArray(),
                concepts = symbols.OfType<ConceptDef>().ToArray(),
                contexts = symbols.OfType<ContextDef>().ToArray(),
                statements = statements,
                annotation = errors.ToArray()
            };
        }

        private readonly List<CqlToElmError> errors = new();

        public SymbolTable SymbolTable { get; }

        public ISymbolScope CurrentScope { get; private set; }

        internal LibraryBuilder UseModel(Model.ModelDefinition model)
        {
            var @using = new UsingDefSymbol(model.Name, model.Version, model);
            var _ = CurrentScope.TryAdd(@using); // ignore if already added
            return this;
        }
        public void AddError(string message, ErrorType errorType) =>
            errors.Add(new CqlToElmError()
            {
                message = message,
                errorSeverity = ErrorSeverity.error,
                errorType = errorType
            });

        /// <summary>
        /// Enters a scope that is directly descended from this Library's root scope.
        /// This can be used, e.g. while evaluating function definitions to ensure that
        /// building a FunctionDef while in the midst of building another one does not allow
        /// the new FunctionDef to inherit scope values it shouldn't.
        /// </summary>
        /// <returns></returns>
        public ISymbolScope EnterStatementScope(string statement) =>
            new LibraryBuilderSubscope(this, SymbolTable.EnterScope(statement));

        public ISymbolScope EnterScope(string reason) =>
            new LibraryBuilderSubscope(this, CurrentScope.EnterScope(reason));

        public Model.ModelDefinition GetSystemModel()
        {
            var systemModels = CurrentScope.ReferencedModels
                .Where(m => m.Model.Name == "System")
                .ToArray();
            if (systemModels.Length == 0)
                throw new InvalidOperationException($"System model is not in scope for this library.");
            else if (systemModels.Length > 1)
                throw new InvalidOperationException($"More than one system model is in scope for this library.");
            else return systemModels[0].Model;

        }

        public Expression ToRef(IDefinitionElement element, string? libraryName)
        {
            return element switch
            {
                AliasedQuerySource aqs => aliasQuerySourceRef(aqs),
                CodeDef cod => new CodeRef
                {
                    libraryName = libraryName,
                    name = cod.name,
                }.WithId().WithResultType(systemType("System..Code")),
                CodeSystemDef csd => new CodeSystemRef
                {
                    libraryName = libraryName,
                    name = csd.name,
                }.WithId().WithResultType(systemType("System..CodeSystem")),
                ConceptDef cd => new ConceptRef
                {
                    libraryName = libraryName,
                    name = cd.name,
                }.WithId().WithResultType(systemType("System..Concept")),

                FunctionDef fd => new FunctionRef
                {
                    libraryName = libraryName,
                    name = fd.name,
                }.WithId().WithResultType(fd.resultTypeSpecifier ?? throw new InvalidOperationException("Missing result type specifier for function ref")),
                DeferredFunctionDef dfd => ToRef(dfd.Resolve(), libraryName),
                ExpressionDef ed => new ExpressionRef
                {
                    libraryName = libraryName,
                    name = ed.name,
                }.WithId().WithResultType(ed.resultTypeSpecifier),
                DeferredExpressionDef ded => ToRef(ded.Resolve(), libraryName),
                IdentifierRef ir => ir,
                LetClause lc => new QueryLetRef
                {
                    name = lc.identifier,
                }.WithId().WithResultType(lc.resultTypeSpecifier),
                OperandDef od => new OperandRef
                {
                    name = od.name,
                }.WithId().WithResultType(od.operandTypeSpecifier),
                ParameterDef pd => new ParameterRef
                {
                    libraryName = libraryName,
                    name = pd.name,
                }.WithId().WithResultType(pd.parameterTypeSpecifier),
                ValueSetDef vd => new ValueSetRef
                {
                    libraryName = libraryName,
                    name = vd.name,
                }.WithId().WithResultType(systemType("System.ValueSet")),

                _ => throw new NotSupportedException($"Cannot create a reference to a {element.GetType().Name}")
            };

            Expression aliasQuerySourceRef(AliasedQuerySource aqs)
            {
                Elm.TypeSpecifier aliasType;
                if (aqs.resultTypeSpecifier is Elm.GenericTypeSpecifier gts && gts.type == systemType("System.List"))
                    aliasType = gts.typeArgument![0];
                else
                    aliasType = aqs.resultTypeSpecifier;
                if (aliasType is null)
                    throw new InvalidOperationException($"Alias type is null");
                var aliasRef = new AliasRef { name = aqs.alias }.WithResultType(aliasType);
                return aliasRef;
            }


            Elm.TypeSpecifier systemType(string typeName)
            {
                var systemModel = GetSystemModel();
                if (!systemModel.TypeDefinitions.TryGetValue(typeName, out var typeDef))
                    throw new ArgumentException($"Type {typeName} not found in system model", nameof(typeName));
                var typeSpecifier = TypeHelpers.ToElmSpecifier(typeDef.ToTypeSpecifier());
                return typeSpecifier;
            }
        }

        [DebuggerDisplay("{Name,nq}")]
        private class LibraryBuilderSubscope : ISymbolScope
        {
            public LibraryBuilderSubscope(LibraryBuilder builder, ISymbolScope newScope)
            {
                ReturnScope = builder.CurrentScope;
                builder.CurrentScope = newScope;
                Builder = builder;
            }

            public LibraryBuilder Builder { get; }

            public ISymbolScope ReturnScope { get; init; }

            public ISymbolScope? Parent => CurrentScope.Parent;

            public IEnumerable<ReferencedLibrary> ReferencedLibraries => CurrentScope.ReferencedLibraries;

            public IEnumerable<UsingDefSymbol> ReferencedModels => CurrentScope.ReferencedModels;

            public string Name => CurrentScope.Name;

            private ISymbolScope CurrentScope => Builder.CurrentScope;

            public void Dispose()
            {
                //Debug.WriteLine($"Exiting scope {CurrentScope.Name}");
                Builder.CurrentScope = ReturnScope;
            }

            public ISymbolScope EnterScope(string name) =>
                new LibraryBuilderSubscope(Builder, CurrentScope.EnterScope(name));

            public IEnumerator<IDefinitionElement> GetEnumerator()
            {
                return CurrentScope.GetEnumerator();
            }

            public bool TryAdd(IDefinitionElement symbol)
            {
                return CurrentScope.TryAdd(symbol);
            }

            public bool TryResolveContextDefinition(string identifier, [NotNullWhen(true)] out ContextDefinitionSymbol? context) =>
                CurrentScope.TryResolveContextDefinition(identifier, out context);

            public bool TryResolveFluentFunction(string identifier, [NotNullWhen(true)] out IFunctionElement? symbol) =>
                CurrentScope.TryResolveFluentFunction(identifier, out symbol);

            public bool TryResolveFunction(string identifier, [NotNullWhen(true)] out IFunctionElement? symbol)
            {
                return CurrentScope.TryResolveFunction(identifier, out symbol);
            }

            public bool TryResolveSymbol(string identifier, [NotNullWhen(true)] out IDefinitionElement? symbol)
            {
                return CurrentScope.TryResolveSymbol(identifier, out symbol);
            }

            public bool TryResolveType(string identifier, [NotNullWhen(true)] out TypeDef? type)
            {
                if (!CurrentScope.TryResolveType(identifier, out type))
                    return Parent?.TryResolveType(identifier, out type) ?? false;
                return true;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)CurrentScope).GetEnumerator();
            }
        }
    }
}