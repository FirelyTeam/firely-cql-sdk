﻿using System.Linq.Expressions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;
using Library = Hl7.Cql.Elm.Library;

namespace Hl7.Cql.CqlToElm.Test;

public static class LibraryExpressionBuilderExtensions
{
    private static Library Library { get; } = new()
    {
        identifier = new VersionedIdentifier { id = "Lambdas", version = "1.0.0" }
    };

    internal static LambdaExpression Lambda(
        this LibraryExpressionBuilder libraryExpressionBuilder,
        Elm.Expression expression)
    {
        DefinitionDictionary<LambdaExpression> lambdas = new DefinitionDictionary<LambdaExpression>();
        var ctx = libraryExpressionBuilder.NewExpressionBuilderContext(Library, lambdas);
        Expression translated = ctx.TranslateArg(expression);
        var contextParameter = CqlExpressions.ParameterExpression;
        LambdaExpression lambda = Expression.Lambda(translated, contextParameter);
        return lambda;
    }
}