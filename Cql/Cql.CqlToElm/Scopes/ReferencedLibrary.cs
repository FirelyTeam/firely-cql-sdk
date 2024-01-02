using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Allows resolution of definition from a pre-existing ("already compiled") ELM Library.
    /// </summary>
    internal class ReferencedLibrary : ISymbolScope
    {
        public ReferencedLibrary(Library source)
        {
            Source = source;

            symbols = new(loadLibrary);
        }

        public Library Source { get; }

        public ISymbolScope? Parent => symbols.Value.Parent;

        private readonly Lazy<SymbolTable> symbols;

        private SymbolTable loadLibrary()
        {
            // A library is a top-level construct, so no parent scope.
            var result = new SymbolTable(null);

            add(Source.parameters);
            add(Source.codeSystems);
            add(Source.valueSets);
            add(Source.codes);
            add(Source.concepts);
            add(Source.contexts);
            add(Source.statements);

            return result;

            void add(IEnumerable<IDefinitionElement> symbols)
            {
                if (symbols is null) return;

                foreach (var symbol in symbols.Where(s => s.IsVisible(AccessModifier.Public)))
                {
                    if (!result.TryAdd(symbol))
                        throw new InvalidOperationException($"Duplicate symbol {symbol.Name} in library {Source.NameAndVersion}.");
                }
            }

        }

        public bool TryAdd(IDefinitionElement symbol) => throw new NotSupportedException("A referenced library is read-only, it cannot be added to.");

        public bool TryResolveSymbol(string identifier, out IDefinitionElement? symbol) =>
            symbols.Value.TryResolveSymbol(identifier, out symbol);
    }

}
