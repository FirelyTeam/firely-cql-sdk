using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Compiler;

internal class ExpressionBuilderContext<TElement> : ExpressionBuilderContext
    where TElement : Elm.Element
{
    internal ExpressionBuilderContext(
        ExpressionBuilder builder,
        ParameterExpression contextParameter,
        DefinitionDictionary<LambdaExpression> definitions,
        IDictionary<string, string> localLibraryIdentifiers,
        TElement element)
        : base(builder, contextParameter, definitions, localLibraryIdentifiers)
    {
        Element = element ?? throw new ArgumentNullException(nameof(element));
    }

    protected ExpressionBuilderContext(
        ExpressionBuilderContext source,
        TElement element)
        : base(source)
    {
        Element = element;
    }

    protected ExpressionBuilderContext(
        ExpressionBuilderContext<TElement> source,
        IDictionary<string, (Expression, Elm.Element)>? overrideScopes = null)
        : base(source, overrideScopes: overrideScopes)
    {
        Element = source.Element;
    }

    protected override ExpressionBuilderContext WithScopes(IDictionary<string, (Expression, Elm.Element)> scopes) =>
        new ExpressionBuilderContext<TElement>(this, scopes);

    internal override ExpressionBuilderContext<TInnerElement> Deeper<TInnerElement>(TInnerElement element) =>
        new(this, element);


    public new TElement Element { get; }

    protected override Elm.Element GetElement() => Element;
}