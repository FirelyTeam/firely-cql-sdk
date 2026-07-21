/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Fhir;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Utility;

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// The assign-to-type / type-as / type-is / coalesce helpers the expression builder and
/// <see cref="CqlOperatorsBinder"/> use on subexpressions; see the remarks on
/// <see cref="ExpressionBuilderContext"/>.
/// </summary>
internal static class IrExpressionExtensions
{
    public static IrExpression NewAssignToTypeExpression(
        this IrExpression expression,
        Type type) =>
        TryNewAssignToTypeExpression(
            expression,
            type).expression!;

    public static (IrExpression? expression, TypeConversion typeConversion) TryNewAssignToTypeExpression(
        this IrExpression expression,
        Type type,
        bool throwError = true,
        bool safeUpcastAllowed = false)
    {
        if (expression.Type == type)
            return (expression, TypeConversion.ExactType);

        if (expression is IrConstant { Value: var constantValue })
        {
            switch (constantValue)
            {
                case null when type.IsNullable(out _):
                    return (new IrConstant(null, type), TypeConversion.ExactType);

                case { } value and not string when
                    value.GetType().IsAssignableTo(type): // <-- Don't remove this, otherwise string constant will not have double-quotes in the generated code. 🤷
                    return (new IrConstant(value, type), TypeConversion.ExactType);

                case Enum enumValue
                    when type == typeof(string)
                         && enumValue.GetType() is { } enumType
                         && FhirTypeConverter.IsFhirEnum(enumType):

                    var enumLiteral = enumValue.GetLiteral();
                    return (new IrConstant(enumLiteral, typeof(string)), TypeConversion.ExactType);


                case Hl7.Cql.Elm.DateTimePrecision dateTimePrecision
                    when type == typeof(string):
                    var dateTimeString = Enum.GetName(dateTimePrecision.GetType(), dateTimePrecision);
                    if (dateTimeString is null)
                    {
                        // Still throw an error here, ignoring the `throwError` parameter, because this indicates a bug in the cql.
                        throw new InvalidOperationException($"Enum value {dateTimeString} is not defined in enum type {typeof(DateTimePrecision)}");
                    }

                    return (new IrConstant(dateTimeString.ToLowerInvariant(), typeof(string)), TypeConversion.ExactType);
            }
        }

        if (safeUpcastAllowed)
        {
            var isAssignableFrom =
                expression.Type == typeof(object) // Choice?
                || expression.Type.IsAssignableFrom(type);
            if (isAssignableFrom || throwError)
            {
                IrExpression cast = new IrCast(expression, type, IrCastKind.As);
                return (cast, TypeConversion.ExpressionTypeAs);
            }
        }

        var isAssignableTo =
            expression.Type == typeof(object) // Choice?
            || expression.Type.IsAssignableTo(type);
        if (isAssignableTo || throwError)
        {
            IrExpression cast = new IrCast(expression, type, IrCastKind.Cast);
            return (cast, TypeConversion.ExpressionCast);
        }

        return (null, TypeConversion.NoMatch);
    }

    public static IrExpression NewAssignToTypeExpression<TType>(
        this IrExpression expression) =>
        expression.NewAssignToTypeExpression(typeof(TType));


    public static IrExpression NewTypeAsExpression(this IrExpression expression, Type type)
    {
        if (expression.Type == type)
            return expression;

        var typeAs = new IrCast(expression, type, IrCastKind.As);
        return typeAs;
    }

    public static IrExpression NewTypeAsExpression<TType>(this IrExpression expression) =>
        expression.NewTypeAsExpression(typeof(TType));

    public static IrTypeIs NewTypeIsExpression(this IrExpression expression, Type type)
    {
        var typeAs = new IrTypeIs(expression, type);
        return typeAs;
    }

    public static IrExpression Coalesce(
        this IrExpression expression)
    {
        if (expression.Type.IsValueType)
        {
            if (expression.Type.IsNullableValueType(out var underlyingType)
                && underlyingType.IsValueType)
            {
                var defaultValue = Activator.CreateInstance(underlyingType)!;
                var result = new IrBinary(IrBinaryOp.Coalesce, expression, new IrConstant(defaultValue, underlyingType));
                return result;
            }

            return expression;
        }

        throw new InvalidOperationException(
            $"Cannot coalesce reference '{expression.Type}'.");
    }

    public static bool IsNullConstant(this IrExpression expression) =>
        expression is IrConstant { Value: null };
}
