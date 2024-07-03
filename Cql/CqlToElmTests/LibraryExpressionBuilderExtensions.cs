/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Linq.Expressions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;
using Library = Hl7.Cql.Elm.Library;

namespace Hl7.Cql.CqlToElm.Test;

public static class LibraryExpressionBuilderExtensions
{
    private static readonly Library EmptyLibrary = new Elm.Library();

    internal static LambdaExpression Lambda(
        this LibraryExpressionBuilder libraryExpressionBuilder,
        Elm.Expression expression)
    {
        DefinitionDictionary<LambdaExpression> lambdas = new DefinitionDictionary<LambdaExpression>();

        var library = EmptyLibrary;
        var libctx = new LibraryExpressionBuilderContext(libraryExpressionBuilder, library, lambdas);
        Dictionary<string, ParameterExpression>? parameterExpressions = null;
        var ctx = new ExpressionBuilderContext(libraryExpressionBuilder._expressionBuilder, libctx, parameterExpressions);
        Expression translated = ctx.TranslateArg(expression);
        var contextParameter = CqlExpressions.ParameterExpression;
        LambdaExpression lambda = Expression.Lambda(translated, contextParameter);
        return lambda;
    }
}