using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

internal class ExpressionBuilderContext<TElement> : ExpressionBuilderContext
    where TElement : Elm.Element
{
    internal ExpressionBuilderContext(
        ExpressionBuilder builder,
        OperatorBinding operatorBinding,
        ParameterExpression contextParameter,
        DefinitionDictionary<LambdaExpression> definitions,
        IDictionary<string, string> localLibraryIdentifiers,
        TElement element)
        : base(builder, operatorBinding, contextParameter, definitions, localLibraryIdentifiers)
    {
        Element = element ?? throw new ArgumentNullException(nameof(element));
    }

    private ExpressionBuilderContext(
        ExpressionBuilderContext source) 
        : base(source)
    {
        Element = (source.Element as TElement)!;
    }

    protected override ExpressionBuilderContext WithScopes(IDictionary<string, (Expression, Elm.Element)> scopes) =>
        new ExpressionBuilderContext<TElement>(this) { Scopes = scopes };

    internal override ExpressionBuilderContext<TInnerElement> Deeper<TInnerElement>(TInnerElement element)
    {
        if (element == Element)
        {
            Debug.WriteLine("Unnecessary call to Deeper, since the current context already points to the element.");

            if (typeof(TElement) == typeof(TInnerElement))
                return (ExpressionBuilderContext< TInnerElement>)(object)this;

            if (OuterContext is null)
                return new ExpressionBuilderContext<TInnerElement>(
                    Builder, 
                    OperatorBinding, 
                    RuntimeContextParameter,
                    Definitions, 
                    LocalLibraryIdentifiers, 
                    element)
                {
                    Scopes = Scopes,
                    OuterContext = this,
                };
            
            return new ExpressionBuilderContext<TInnerElement>(OuterContext)
            {
                Scopes = Scopes,
                Element = element,
            };
        }

        return new(this)
        {
            Element = element,
            OuterContext = this,
        };
    }


    public new TElement Element { get; private init; }

    protected override Elm.Element GetElement() => Element;
}