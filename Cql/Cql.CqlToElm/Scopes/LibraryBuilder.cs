using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Scopes;
using Hl7.Cql.Elm;
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
        public IDisposableScope EnterStatementScope(string statement) =>
            new DisposableScope(this, SymbolTable.EnterScope(statement));

     
        public IDisposableScope EnterScope(string reason) => 
            new DisposableScope(this, CurrentScope.EnterScope(reason));

        [DebuggerDisplay("{Name,nq}")]
        private class DisposableScope : IDisposableScope, ISymbolScope
        {
            public DisposableScope(LibraryBuilder builder, ISymbolScope newScope)
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
                Debug.WriteLine($"Exiting scope {CurrentScope.Name}");
                Builder.CurrentScope = ReturnScope;
            }

            public ISymbolScope EnterScope(string name) =>
                new DisposableScope(Builder, CurrentScope.EnterScope(name));

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