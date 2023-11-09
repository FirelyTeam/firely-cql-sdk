using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// A symbol table that tracks symbols that are local to a function, let clause, aliased query source or aggregate.
    /// For future purposes, it can hold nested codes, value sets, etc as well, although the CQL language itself does not
    /// yet support that.
    /// </summary>
    internal class LocalSymbolTable : ISymbolScope
    {
        //public LocalSymbolTable(ISymbolScope? parent, string? name)
        //{
        //    Parent = parent;
        //    Name = name;
        //}

        public LocalSymbolTable(ISymbolScope? parent)
        {
            Parent = parent;
        }

        public ISymbolScope? Parent { get; }

        private readonly Dictionary<string, IDefinitionElement> symbols = new();

        public IEnumerable<IDefinitionElement> Symbols => symbols.Values;

        //public string? Name { get; }

        //public IEnumerable<(IDefinitionElement, ISymbolScope)> TryResolveSymbol(string identifier, AccessModifier access)
        //{
        //    List<(IDefinitionElement, ISymbolScope)> matches = new();

        //    var result = symbols.TryGetValue(identifier, out var symbol) && isVisible(symbol, access);
        //    if (result)
        //        matches.Add((symbol!, this));

        //    var nested = nestedScopes
        //        .Where(ns => isVisible((IDefinitionElement)ns, access))
        //        .SelectMany(ns => ns.TryResolveSymbol(identifier, access));
        //    matches.AddRange(nested);

        //    if (matches.Any())
        //        return matches;
        //    else
        //    {
        //        if (Parent is not null)
        //            return Parent.TryResolveSymbol(identifier, access);
        //        else
        //            return Enumerable.Empty<(IDefinitionElement, ISymbolScope)>();
        //    }

        //    static bool isVisible(IDefinitionElement symbol, AccessModifier visibility) =>
        //        visibility > symbol.Access;
        //}

        public bool TryResolveSymbol(string identifier, out IDefinitionElement? symbol)
        {
            if (symbols.TryGetValue(identifier, out symbol))
                return true;
            else
            {
                if (Parent is not null)
                    return Parent.TryResolveSymbol(identifier, out symbol);
                else
                    return false;
            }
        }

        public bool TryAdd(IDefinitionElement symbol)
        {
            if (symbol is LetClause or AliasedQuerySource)
                return symbols.TryAdd(symbol.Name, symbol);
            else
                throw new InvalidOperationException("Local symbol tables can only contain let clauses and aliased query sources.");
        }

        //private readonly HashSet<ISymbolScope> nestedScopes = new();

        //public bool TryAddNestedScope(ISymbolScope scope)
        //{
        //    if (scope is not IDefinitionElement symbol) throw new InvalidOperationException("Nested scopes must be symbols.");

        //    if (TryAdd(symbol))
        //    {
        //        nestedScopes.Add(scope);
        //        return true;
        //    }
        //    else
        //        return false;
        //}
    }
}
