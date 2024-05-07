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
using Hl7.Cql.Fhir;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Utility;

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

        if (expression is ConstantExpression { Value: var constantValue })
        {
            switch (constantValue)
            {
                case null when type.IsNullable(out _):
                    return (NullExpression.ForType(type), TypeConversion.ExactType);

                case { } value and not string when
                    value.GetType().IsAssignableTo(type): // <-- Don't remove this, otherwise string constant will not have double-quotes in the generated code. 🤷
                    return (Expression.Constant(value, type), TypeConversion.ExactType);

                case Enum enumValue
                    when type == typeof(string)
                         && enumValue.GetType() is {} enumType
                         && FhirTypeConverter.IsFhirEnum(enumType):

                    var enumLiteral = enumValue.GetLiteral();
                    return (Expression.Constant(enumLiteral), TypeConversion.ExactType);

                case DateTimePrecision dateTimePrecision
                    when type == typeof(string):
                    var dateTimeString = dateTimePrecision.ToString().ToLowerInvariant();
                    return (Expression.Constant(dateTimeString), TypeConversion.ExactType);
            }
        }

        var isAssignableTo =
            expression.Type == typeof(object) // Choice?
            || expression.Type.IsAssignableTo(type);
        if (isAssignableTo || throwError)
        {
            Expression cast = Expression.Convert(expression, type);
            return (cast, TypeConversion.ExpressionCast);
        }

        return (null, TypeConversion.NoMatch);
    }

    public static Expression NewAssignToTypeExpression<TType>(
        this Expression expression) =>
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

    public static Expression Coalesce(
        this Expression expression)
    {
        if (expression.Type.IsValueType)
        {
            if (expression.Type.IsNullableValueType(out var underlyingType)
                && underlyingType.IsValueType)
            {
                var defaultValue = Activator.CreateInstance(underlyingType)!;
                var result = Expression.Coalesce(expression, Expression.Constant(defaultValue));
                return result;
            }

            return expression;
        }

        throw new InvalidOperationException(
            $"Cannot coalesce reference '{expression.Type}'.");
    }
}