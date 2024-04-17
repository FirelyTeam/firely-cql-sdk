using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm.Visitors;

internal class DelayedSymbolTable : ISymbolScope
{
    public DelayedSymbolTable(ISymbolScope parent)
    {
        Parent = parent;
    }

    public ISymbolScope? Parent { get; }

    private readonly Dictionary<string, Lazy<IDefinitionElement>> _factories = new();
    private readonly Lazy<IDefinitionElement> _inProgress = new(
        () => throw new InvalidOperationException("Circular reference detected."));

    public bool TryAddDelayed(string name, string? contextName, Func<ExpressionDef> factory)
    {
        return _factories.TryAdd(name, new Lazy<IDefinitionElement>(create));

        ExpressionDef create()
        {
            var expressionDef = factory();
            expressionDef.context = contextName;
            return expressionDef;
        }
    }

    public bool TryAdd(IDefinitionElement symbol) =>
        _factories.TryAdd(symbol.Name, new Lazy<IDefinitionElement>(symbol));

    public IReadOnlyCollection<IDefinitionElement> Symbols =>
        _factories.Select(kvp => getValue(kvp.Value, kvp.Key)).ToArray();

    public bool TryResolveSymbol(string identifier, out IDefinitionElement? symbol)
    {
        if(_factories.TryGetValue(identifier, out var entry))
        {
            symbol = getValue(entry, identifier);
            return true;
        }

        symbol = null;
        return Parent is not null && Parent.TryResolveSymbol(identifier, out symbol);
    }

    private IDefinitionElement getValue(Lazy<IDefinitionElement> lazy, string symbol)
    {
        try
        {
            return lazy.Value;
        }
        catch (InvalidOperationException e) when
            (e.Message == "ValueFactory attempted to access the Value property of this instance.")
        {
            throw new InvalidOperationException($"Expression {symbol} references itself cyclically.");
        }
    }
    public ISymbolScope EnterScope() => new DelayedSymbolTable(this);
}