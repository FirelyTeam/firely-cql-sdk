using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal class LibraryBuilder
    {
        private static readonly VersionedIdentifier schemaIdentifier = new() { id = "urn:hl7-org:elm", version = "r1" };

        public LibraryBuilder(SystemLibrary systemLibrary)
        {
            CurrentScope = SymbolTable;
            Identifier = new VersionedIdentifier() { id = "unset", version = "0.0.0" };
            SystemScope = systemLibrary.Symbols;
        }

        public VersionedIdentifier Identifier { get; set; }


        /// <summary>
        /// Builds a library from the current state of the builder.
        /// </summary>
        public Library Build()
        {
            var symbols = SymbolTable.Symbols;

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
                statements = symbols.OfType<ExpressionDef>().ToArray(),
                annotation = errors.ToArray()
            };
        }

        private readonly List<CqlToElmError> errors = new();

        public SymbolTable SymbolTable { get; } = new(null);  // we're a top-level scope

        public ISymbolScope CurrentScope { get; private set; }
        public ISymbolScope SystemScope { get; }

        public void AddError(string message, ErrorType errorType) =>
            errors.Add(new CqlToElmError()
            {
                message = message,
                errorSeverity = ErrorSeverity.error,
                errorType = errorType
            });

        public void EnterScope()
        {
            var newScope = new SymbolTable(CurrentScope);
            CurrentScope = newScope;
        }

        public void EnterScope(ISymbolScope newScope)
        {
            CurrentScope = newScope;
        }

        public void ExitScope()
        {
            if (CurrentScope.Parent is null)
                throw new InvalidOperationException("Tried to pop a scope while already at the root scope.");

            CurrentScope = CurrentScope.Parent;
        }
    }
}