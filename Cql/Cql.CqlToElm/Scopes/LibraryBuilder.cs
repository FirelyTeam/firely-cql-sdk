using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.CqlToElm.Scopes;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
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
        // TODO: this is a really leaky abstraction.  Identifier shouldn't be unset.
        public LibraryBuilder(SystemLibrary systemLibrary, LocalIdentifierProvider localIdentifierProvider)
        {
            Identifier = new VersionedIdentifier() { id = "unset", version = "0.0.0" };
            SymbolTable = new LibrarySymbolTable(Identifier, systemLibrary);
            CurrentScope = SymbolTable;
            LocalIdentifierProvider = localIdentifierProvider;
        }

        public LibraryBuilder(VersionedIdentifier identifier, SystemLibrary systemLibrary, LocalIdentifierProvider localIdentifierProvider)
        {
            Identifier = identifier;
            SymbolTable = new LibrarySymbolTable(Identifier, systemLibrary);
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

        public LibrarySymbolTable SymbolTable { get; }

        public ISymbolScope CurrentScope { get; private set; }

        public void AddError(string message, ErrorType errorType) =>
            errors.Add(new CqlToElmError()
            {
                message = message,
                errorSeverity = ErrorSeverity.error,
                errorType = errorType
            });

        /// <summary>
        /// Enters a scope which is exited when the return value of this method is disposed.
        /// </summary>
        /// <param name="newScope">The new scope to enter, or <see langword="null"/>.  If null, this builder's current scope will be entered via <see cref="ISymbolScope.EnterScope"/>.</param>
        /// <returns>An <see cref="IDisposable"/> which upon disposable exits the new scope.</returns>
        public IDisposable EnterScope(ISymbolScope? newScope = null) => 
            new DisposableScope(this, newScope ?? CurrentScope.EnterScope());

        private void ExitScope()
        {
            if (CurrentScope.Parent is null)
                throw new InvalidOperationException("Tried to pop a scope while already at the root scope.");

            CurrentScope = CurrentScope.Parent;
        }
        private class DisposableScope : IDisposable
        {
            public DisposableScope(LibraryBuilder builder, ISymbolScope newScope)
            {
                builder.CurrentScope = newScope;
                Builder = builder;
            }

            public LibraryBuilder Builder { get; }

            public void Dispose() => Builder.ExitScope();
        }
    }
}