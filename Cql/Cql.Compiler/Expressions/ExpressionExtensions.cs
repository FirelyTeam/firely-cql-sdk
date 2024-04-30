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
    public static Expression NewAssignToTypeExpression(
        this Expression expression,
        Type type) =>
        TryNewAssignToTypeExpression(
            expression,
            type).expression!;

    public static (Expression? expression, TypeConversion typeConversion) TryNewAssignToTypeExpression(
        this Expression expression,
        Type type,
        bool throwError = true)
    {
        if (expression.Type == type)
            return (expression, TypeConversion.ExactType);

        if (expression is ConstantExpression constant)
        {
            switch (constant.Value)
            {
                case null when type.IsNullable(out _):
                    return (NullExpression.ForType(type), TypeConversion.ExactType);

                case { } value and not string when
                    value.GetType().IsAssignableTo(type): // <-- Don't remove this, otherwise string constant will not have double-quotes in the generated code. 🤷
                    return (Expression.Constant(value, type), TypeConversion.SimpleConvert);

                case Enum enumValue when type == typeof(string):
                    var name = Enum.GetName(enumValue.GetType(), enumValue);
                    if (name is null)
                        throw new InvalidOperationException($"Enum value {enumValue} is not defined in enum type {enumValue.GetType()}");

                    return (Expression.Constant(name.ToLowerInvariant()), TypeConversion.SimpleConvert);
            }
        }

        var isAssignableTo = expression.Type == typeof(object) // Choice?
                             || expression.Type.IsAssignableTo(type);
        if (isAssignableTo || throwError)
        {
            Expression cast = Expression.Convert(expression, type);
            return (cast, TypeConversion.SimpleConvert);
        }

        return (null, TypeConversion.NoMatch);
    }

    public static Expression NewAssignToTypeExpression<TType>(
        this Expression expression,
        bool throwError = true) =>
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