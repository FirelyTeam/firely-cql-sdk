using Hl7.Cql.Elm;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// A symbol table that tracks symbols that are local to a function, let clause, aliased query source or aggregate.
    /// For future purposes, it can hold nested codes, value sets, etc as well, although the CQL language itself does not
    /// yet support that.
    /// </summary>
    internal class SymbolTable : ISymbolScope
    {
        public SymbolTable(ISymbolScope? parent)
        {
            Parent = parent;
        }

        public SymbolTable(ISymbolScope? parent, params IDefinitionElement[] defs)
        {
            Parent = parent;
            foreach (var def in defs)
                symbols.TryAdd(def.Name, def);
        }

        public ISymbolScope? Parent { get; }

        private readonly Dictionary<string, IDefinitionElement> symbols = new();

        public IReadOnlyCollection<IDefinitionElement> Symbols => symbols.Values;

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
            if (symbol is FunctionDef functionDef 
                && symbols.TryGetValue(symbol.Name, out var existingSymbol))
            {
                switch(existingSymbol)
                {
                    case FunctionDef existingFunction:
                        {
                            var overload = OverloadedFunctionDef.Create(existingFunction, functionDef);
                            symbols[overload.Name] = overload;
                            return true;
                        }
                    case OverloadedFunctionDef overload:
                        {
                            var newOverload = OverloadedFunctionDef.Create(overload.Functions.Append(functionDef).ToArray());
                            symbols[overload.Name] = overload;
                            return true;
                        }
                    default: break;
                }
            }
            return symbols.TryAdd(symbol.Name, symbol);
        }
    }
}
