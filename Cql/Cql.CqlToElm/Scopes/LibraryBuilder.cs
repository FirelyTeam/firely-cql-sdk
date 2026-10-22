/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Scopes;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm
{
    internal class LibraryBuilder
    {
        private static readonly VersionedIdentifier schemaIdentifier = new() { id = "urn:hl7-org:elm", version = "r1" };

        /// <summary>
        /// Creates a new instance from an existing library.  Its symbol table will be populated with its existing definitions.
        /// </summary>
        public static LibraryBuilder CreateFromExisting(Library library) => throw new NotImplementedException();

        /// <summary>
        /// Creates a new instance that resolves references into an existing library.
        /// </summary>
        /// <remarks>
        /// The builder only resolves references into <paramref name="library"/> and is never built: its symbol table holds
        /// the signatures of the definitions, without their expressions. A statement whose ELM declares no result type, or a
        /// function with an operand whose ELM declares no type, cannot be referenced with a type, so it is left out, and a
        /// reference to it does not resolve. The names of definitions that clash with a definition added before them, which
        /// a reference could not tell apart, are returned in <paramref name="conflictingNames"/>.
        /// </remarks>
        public static LibraryBuilder CreateReference(
            Library library,
            SystemLibrary systemLibrary,
            LocalIdentifierProvider localIdentifierProvider,
            out IReadOnlyList<string> conflictingNames)
        {
            var conflicts = new List<string>();
            conflictingNames = conflicts;
            var builder = new LibraryBuilder(library.identifier, systemLibrary, localIdentifierProvider);
            var symbols = builder.SymbolTable;

            // The symbol table combines the overloads of a function, so the overloads added so far are kept to tell
            // whether a function can join them.
            var overloadsByName = new Dictionary<string, List<IFunctionElement>>();

            void AddReferenceDefinition(IDefinitionElement definition)
            {
                // Nothing can reference a definition without a name.
                if (string.IsNullOrEmpty(definition.Name))
                    return;

                if (definition is IFunctionElement function)
                {
                    if (!overloadsByName.TryGetValue(function.Name, out var overloads))
                        overloadsByName[function.Name] = overloads = [];

                    if (!OverloadedFunctionDef.CanCombine([.. overloads, function]))
                    {
                        conflicts.Add(definition.Name);
                        return;
                    }

                    overloads.Add(function);
                }

                if (!symbols.TryAdd(definition))
                    conflicts.Add(definition.Name);
            }

            foreach (var parameter in library.parameters ?? [])
            {
                if ((parameter.parameterTypeSpecifier ?? parameter.parameterType?.ToNamedType() ?? parameter.GetTypeSpecifier()) is { } parameterType)
                    AddReferenceDefinition(new ParameterDef { name = parameter.name, accessLevel = parameter.accessLevel, parameterTypeSpecifier = parameterType });
            }

            foreach (var codeSystem in library.codeSystems ?? [])
                AddReferenceDefinition(new CodeSystemDef { name = codeSystem.name, accessLevel = codeSystem.accessLevel, id = codeSystem.id, version = codeSystem.version });

            foreach (var valueSet in library.valueSets ?? [])
                AddReferenceDefinition(new ValueSetDef { name = valueSet.name, accessLevel = valueSet.accessLevel, id = valueSet.id, version = valueSet.version });

            foreach (var code in library.codes ?? [])
                AddReferenceDefinition(new CodeDef { name = code.name, accessLevel = code.accessLevel, id = code.id });

            foreach (var concept in library.concepts ?? [])
                AddReferenceDefinition(new ConceptDef { name = concept.name, accessLevel = concept.accessLevel });

            foreach (var statement in library.statements ?? [])
            {
                if (CreateReferenceDefinition(statement) is { } definition)
                    AddReferenceDefinition(definition);
            }

            return builder;
        }

        private static ExpressionDef? CreateReferenceDefinition(ExpressionDef statement)
        {
            if (statement.GetTypeSpecifier() is not { } resultType)
                return null;

            if (statement is not FunctionDef function)
                return new ExpressionDef
                {
                    name = statement.name,
                    accessLevel = statement.accessLevel,
                    context = statement.context,
                    resultTypeSpecifier = resultType,
                };

            var operands = new List<OperandDef>();
            foreach (var operand in function.operand ?? [])
            {
                if (operand.GetTypeSpecifier() is not { } operandType)
                    return null;

                operands.Add(new OperandDef { name = operand.name, operandTypeSpecifier = operandType });
            }

            return new FunctionDef
            {
                name = function.name,
                accessLevel = function.accessLevel,
                context = function.context,
                fluent = function.fluent,
                fluentSpecified = function.fluentSpecified,
                external = function.external,
                externalSpecified = function.externalSpecified,
                operand = [.. operands],
                resultTypeSpecifier = resultType,
            };
        }

        public LibraryBuilder(VersionedIdentifier identifier, SystemLibrary systemLibrary, LocalIdentifierProvider localIdentifierProvider)
        {
            Identifier = identifier;
            SymbolTable = new SymbolTable(Identifier.ToString()!, systemLibrary);
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
            var library = new Library
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

            // An error on a node that never received a locator of its own takes the closest enclosing one.
            library.FillMissingErrorPositions();
            return library;
        }

        private readonly List<CqlToElmError> errors = new();

        public SymbolTable SymbolTable { get; }

        public ISymbolScope CurrentScope { get; private set; }

        /// <summary>
        /// Adds an error that belongs to the library as a whole, positioned at <paramref name="locator"/>.
        /// </summary>
        public void AddError(string message, ErrorType errorType, string? locator)
        {
            var error = new CqlToElmError()
            {
                message = message,
                errorSeverity = ErrorSeverity.error,
                errorType = errorType
            };
            error.TrySetPosition(locator);
            errors.Add(error);
        }

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

            public bool TryResolveFluentFunction(string identifier, [NotNullWhen(true)] out IFunctionElement? symbol)
            {
                return CurrentScope.TryResolveFluentFunction(identifier, out symbol);
            }

            public bool TryResolveFunction(string identifier, [NotNullWhen(true)] out IFunctionElement? symbol)
            {
                return CurrentScope.TryResolveFunction(identifier, out symbol);
            }

            public bool TryResolveSymbol(string identifier, [NotNullWhen(true)] out IDefinitionElement? symbol)
            {
                return CurrentScope.TryResolveSymbol(identifier, out symbol);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)CurrentScope).GetEnumerator();
            }
        }
    }
}
