using Hl7.Cql.Elm;
using System.Collections.Generic;

namespace Hl7.Cql.CqlToElm
{
    /// A symbol table that tracks symbols that are local to a function, let clause, aliased query source or aggregate.
    /// For future purposes, it can hold nested codes, value sets, etc as well, although the CQL language itself does not
    /// yet support that.
    /// </summary>
    internal class LocalScope : ISymbolScope
    {
        public LocalScope(ISymbolScope parent)
        {
            Parent = parent;
        }
        public ISymbolScope? Parent { get; }

        private readonly Dictionary<string, ISymbol> symbols = new();

        public bool TryResolveSymbol(string identifier, AccessModifier access, out ISymbol? symbol) =>
             symbols.TryGetValue(identifier, out symbol) && access >= symbol.Access;

        public bool TryAdd(ISymbol symbol) => symbols.TryAdd(symbol.Name, symbol);
    }
}
