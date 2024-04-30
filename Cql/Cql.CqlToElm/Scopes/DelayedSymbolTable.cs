using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm;

internal class DelayedSymbolTable : ISymbolScope
{
    public DelayedSymbolTable(ISymbolScope parent, MessageProvider messaging)
    {
        Parent = parent;
        Messaging = messaging;
    }

    public ISymbolScope? Parent { get; }
    public MessageProvider Messaging { get; }

    private readonly Dictionary<string, Factory> _factories = new();
    private readonly Lazy<IDefinitionElement> _inProgress = new(
        () => throw new InvalidOperationException("Circular reference detected."));

    public bool TryAddDelayed(string name, 
        string? contextName,
        string locator,
        Func<ExpressionDef> factory)
    {
        return _factories.TryAdd(name, new(name, new Lazy<IDefinitionElement>(create), errorDef));

        ExpressionDef create()
        {
            var expressionDef = factory();
            expressionDef.context = contextName;
            expressionDef.locator = locator;
            return expressionDef;
        }
        ExpressionDef errorDef()
        {
            var expressionDef = new ExpressionDef();
            expressionDef.context = contextName;
            expressionDef.locator = locator;
            return expressionDef
                .WithResultType(SystemTypes.AnyType);
        }
    }

    public bool TryAdd(IDefinitionElement symbol) =>
        _factories.TryAdd(symbol.Name,
            new(symbol.Name, new Lazy<IDefinitionElement>(symbol), ()=>symbol));

    public IReadOnlyCollection<IDefinitionElement> Symbols =>
        _factories.Select(kvp => getValue(kvp.Value)).ToArray();

    public bool TryResolveSymbol(string identifier, out IDefinitionElement? symbol)
    {
        if(_factories.TryGetValue(identifier, out var entry))
        {
            symbol = getValue(entry);
            return true;
        }

        symbol = null;
        return Parent is not null && Parent.TryResolveSymbol(identifier, out symbol);
    }

    private IDefinitionElement getValue(Factory factory)
    {
        try
        {
            return factory.Lazy.Value;
        }
        catch (InvalidOperationException e) when
            (e.Message == "ValueFactory attempted to access the Value property of this instance.")
        {
            var def = factory.ErrorDef()
                .AddError(new CircularReferenceError
                {
                    message = Messaging.CannotResolveCircularReference(),
                    errorType = ErrorType.semantic,
                    errorSeverity = ErrorSeverity.error,
                    errorSeveritySpecified = true,
                });
            return def;
        }
    }
    public ISymbolScope EnterScope() => new DelayedSymbolTable(this, Messaging);

    private record Factory(string Name, Lazy<IDefinitionElement> Lazy, Func<IDefinitionElement> ErrorDef);


}