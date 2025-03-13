using Hl7.Cql.CqlToElm2.Coercion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm2.Symbols;

[DebuggerDisplay("{Name}")]
internal class SymbolTable: IEnumerable<Symbol>
{
    public SymbolTable? Parent { get; }

    /// <summary>
    /// Gets this symbol table's parent until the global symbol table is reached.
    /// </summary>
    public SymbolTable Global
    {
        get
        {
            var current = this;
            while (current.Parent != null)
            {
                current = current.Parent;
            }
            return current;
        }
    }
    public string Name { get; }
    private Dictionary<string, List<Symbol>> Symbols = new();

    internal CoercionGraph? LocalCoercionGraph { get; set; }

    /// <summary>
    /// If this symbol table has types, this is the coercion graph for those types.
    /// </summary>
    internal CoercionGraph? CoercionGraph => LocalCoercionGraph ?? Parent?.CoercionGraph;

    public SymbolTable(string name)
    {
        Name = name;
    }

    protected SymbolTable(SymbolTable parent, string name)
    {
        Parent = parent;
        Name = name;
    }
    public SymbolTable Enter(string name) => new SymbolTable(this, name);

    public void AddSymbol(Symbol symbol)
    {
        if (symbol is TypeSymbol ts && ts.Name == "CodeSystem")
        {
        }
        if (!Symbols.TryGetValue(symbol.Name, out var symbols))
        {
            symbols = new() { symbol };
            Symbols.Add(symbol.Name, symbols);
        }
        else symbols.Add(symbol);
    }

    public IReadOnlyList<Symbol> GetSymbols(string name) =>
        GetSymbols([name]);

    /// <summary>
    /// Gets symbols that do not contain errors.
    /// </summary>
    public IReadOnlyList<Symbol> GetSymbols(string[] parts)
    {
        // Direct match
        var local = GetLocalSymbols(parts);
        if (local.Count > 0)
            return local;
        else // check parent scope
            return Parent?.GetSymbols(parts) ?? Array.Empty<Symbol>();
    }

    public IReadOnlyList<Symbol> GetLocalSymbols(string name) => GetLocalSymbols([name]);
    public IReadOnlyList<Symbol> GetLocalSymbols(string[] parts)
    {
        if (parts.Length == 1 && Symbols.TryGetValue(parts[0], out var symbols))
            return symbols.AsReadOnly();
        else // Check for dot-qualified names
        {
            for (int i = 0; i < parts.Length; i++)
            {
                string prefix = string.Join(".", parts.Take(i));
                if (Symbols.TryGetValue(prefix, out var librarySymbols))
                {
                    var hasSymbols = librarySymbols.OfType<SymbolContainer>().FirstOrDefault();
                    if (hasSymbols is not null)
                    {
                        string remainder = string.Join(".", parts.Skip(i));
                        return hasSymbols.Symbols.GetSymbols(remainder);
                    }
                }
            }
        }
        return Array.Empty<Symbol>().AsReadOnly();
    }


    /// <summary>
    /// Gets the only non-error symbol with this name, or null if there is no such symbol.
    /// </summary>
    public Symbol? GetUnique(string[] name)
    {
        var symbols = GetSymbols(name);
        var nonErrorSymbols = symbols.Where(s => s.Errors.Count == 0).ToList();
        if (nonErrorSymbols.Count == 1)
            return nonErrorSymbols[0];
        else if (symbols.Count == 1)
            return symbols[0];
        else return null;
    }
    public Symbol? GetUnique(string name) =>GetUnique([name]);

    public T? GetUnique<T>(string name) where T : Symbol => GetUnique<T>([name]);
    public T? GetUnique<T>(string[] name) where T : Symbol =>
        GetUnique(name) switch
        {
            T t => t,
            _ => null
        };

    public Symbol? GetLocalUnique(string name)=>GetLocalUnique([name]);

    public Symbol? GetLocalUnique(string[] name)
    {
        var symbols = GetLocalSymbols(name);
        var nonErrorSymbols = symbols.Where(s => s.Errors.Count == 0).ToList();
        if (nonErrorSymbols.Count == 1)
            return nonErrorSymbols[0];
        else if (symbols.Count == 1)
            return symbols[0];
        else return null;
    }

    public T? GetLocalUnique<T>(string name) where T : Symbol =>
        GetLocalUnique(name) switch
        {
            T t => t,
            _ => null
        };

    public IEnumerable<FluentFunctionSymbol> GetFluentFunctions(string name)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> OfType<T>() where T : Symbol
    {
        var ofType = Symbols.Values.SelectMany(s => s).OfType<T>();
        if (Parent is not null)
            ofType = ofType.Concat(Parent.OfType<T>());
        return ofType;
    }


    public IEnumerator<Symbol> GetEnumerator() => Symbols.Values.SelectMany(s => s).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => Symbols.Values.SelectMany(s => s).GetEnumerator();
}
