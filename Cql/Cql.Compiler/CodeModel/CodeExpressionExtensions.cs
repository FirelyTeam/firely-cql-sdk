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

namespace Hl7.Cql.Compiler.CodeModel;

/// <summary>
/// The assign-to-type / type-as / type-is / coalesce helpers the expression builder and
/// <see cref="CqlOperatorsBinder"/> use on subexpressions; see the remarks on
/// <see cref="CodeBuilderContext"/>.
/// </summary>
internal static class CodeExpressionExtensions
{
    public static CodeExpression NewAssignToTypeExpression(
        this CodeExpression expression,
        Type type) =>
        TryNewAssignToTypeExpression(
            expression,
            type).expression!;

    public static (CodeExpression? expression, TypeConversion typeConversion) TryNewAssignToTypeExpression(
        this CodeExpression expression,
        Type type,
        bool throwError = true,
        bool safeUpcastAllowed = false)
    {
        if (expression.Type == type)
            return (expression, TypeConversion.ExactType);

        if (expression is CodeConstant { Value: var constantValue })
        {
            switch (constantValue)
            {
                case null when type.IsNullable(out _):
                    return (new CodeConstant(null, type), TypeConversion.ExactType);

                case { } value and not string when
                    value.GetType().IsAssignableTo(type): // <-- Don't remove this, otherwise string constant will not have double-quotes in the generated code. 🤷
                    return (new CodeConstant(value, type), TypeConversion.ExactType);

                case Enum enumValue
                    when type == typeof(string)
                         && enumValue.GetType() is { } enumType
                         && FhirTypeConverter.IsFhirEnum(enumType):

                    var enumLiteral = enumValue.GetLiteral();
                    return (new CodeConstant(enumLiteral, typeof(string)), TypeConversion.ExactType);


                case Hl7.Cql.Elm.DateTimePrecision dateTimePrecision
                    when type == typeof(string):
                    var dateTimeString = Enum.GetName(dateTimePrecision.GetType(), dateTimePrecision);
                    if (dateTimeString is null)
                    {
                        // Still throw an error here, ignoring the `throwError` parameter, because this indicates a bug in the cql.
                        throw new InvalidOperationException($"Enum value {dateTimeString} is not defined in enum type {typeof(DateTimePrecision)}");
                    }

                    return (new CodeConstant(dateTimeString.ToLowerInvariant(), typeof(string)), TypeConversion.ExactType);
            }
        }

        if (safeUpcastAllowed)
        {
            var isAssignableFrom =
                expression.Type == typeof(object) // Choice?
                || expression.Type.IsAssignableFrom(type);
            if (isAssignableFrom || throwError)
            {
                CodeExpression cast = new CodeCast(expression, type, CodeCastKind.As);
                return (cast, TypeConversion.ExpressionTypeAs);
            }
        }

        var isAssignableTo =
            expression.Type == typeof(object) // Choice?
            || expression.Type.IsAssignableTo(type);
        if (isAssignableTo || throwError)
        {
            CodeExpression cast = new CodeCast(expression, type, CodeCastKind.Cast);
            return (cast, TypeConversion.ExpressionCast);
        }

        return (null, TypeConversion.NoMatch);
    }

    public static CodeExpression NewAssignToTypeExpression<TType>(
        this CodeExpression expression) =>
        expression.NewAssignToTypeExpression(typeof(TType));


    public static CodeExpression NewTypeAsExpression(this CodeExpression expression, Type type)
    {
        if (expression.Type == type)
            return expression;

        var typeAs = new CodeCast(expression, type, CodeCastKind.As);
        return typeAs;
    }

    public static CodeExpression NewTypeAsExpression<TType>(this CodeExpression expression) =>
        expression.NewTypeAsExpression(typeof(TType));

    public static CodeTypeIs NewTypeIsExpression(this CodeExpression expression, Type type)
    {
        var typeAs = new CodeTypeIs(expression, type);
        return typeAs;
    }

    public static CodeExpression Coalesce(
        this CodeExpression expression)
    {
        if (expression.Type.IsValueType)
        {
            if (expression.Type.IsNullableValueType(out var underlyingType)
                && underlyingType.IsValueType)
            {
                var defaultValue = Activator.CreateInstance(underlyingType)!;
                var result = new CodeBinary(CodeBinaryOp.Coalesce, expression, new CodeConstant(defaultValue, underlyingType));
                return result;
            }

            return expression;
        }

        throw new InvalidOperationException(
            $"Cannot coalesce reference '{expression.Type}'.");
    }

    public static bool IsNullConstant(this CodeExpression expression) =>
        expression is CodeConstant { Value: null };
}
