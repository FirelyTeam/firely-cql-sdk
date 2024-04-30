/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Compiler.Expressions;

internal static class ExpressionExtensions
{
    public static Expression NewAssignToTypeExpression(this Expression expression, Type type)
    {
        if (expression.Type == type)
            return expression;

        if (expression is ConstantExpression constant)
        {
            if (constant.Value is null)
            {
                if (type.IsNullable(out _))
                    return NullExpression.ForType(type);
            }
            else if (
                constant.Value is not string // <-- Don't remove this, otherwise string constant will not have double-quotes in the generated code. 🤷
                && constant.Value.GetType().IsAssignableTo(type))
            {
                return Expression.Constant(constant.Value, type);
            } else if (
                constant.Value is Enum enumValue)
            {
                ;
            }
        }

        Expression cast = Expression.Convert(expression, type);
        return cast;
    }

    public static Expression NewAssignToTypeExpression<TType>(this Expression expression) =>
        expression.NewAssignToTypeExpression(typeof(TType));


    public static Expression NewTypeAsExpression(this Expression expression, Type type)
    {
        if (expression.Type == type)
            return expression;

        var typeAs = Expression.TypeAs(expression, type);
        return typeAs;
    }

    public static Expression NewTypeAsExpression<TType>(this Expression expression) =>
        expression.NewTypeAsExpression(typeof(TType));

    public static TypeBinaryExpression NewTypeIsExpression(this Expression expression, Type type)
    {
        var typeAs = Expression.TypeIs(expression, type);
        return typeAs;
    }
}