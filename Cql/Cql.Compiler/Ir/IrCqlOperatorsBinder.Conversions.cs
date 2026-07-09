/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Utility;

namespace Hl7.Cql.Compiler.Ir;

/// <summary>
/// IR counterpart of <see cref="CqlOperatorsBinder.Conversions"/>: <see cref="TryConvert"/> and
/// the <see cref="TypeConversion"/> ranking. This is a mechanical port; see the remarks on
/// <see cref="IrCqlOperatorsBinder"/>.
/// </summary>
partial class IrCqlOperatorsBinder
{
    /// <summary>
    /// The <c>context.Operators</c> property access used as the receiver of every
    /// <see cref="ICqlOperators"/> call. Corresponds to <c>CqlExpressions.Operators_PropertyExpression</c>
    /// in the old binder.
    /// </summary>
    private static IrExpression OperatorsReceiver { get; } =
        new IrProperty(IrContextParameter.Instance, typeof(CqlContext).GetProperty(nameof(CqlContext.Operators))!);

    /// <summary>
    /// Tries to convert the given <paramref name="expression"/> to the specified type <paramref name="to"/>.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public virtual bool TryConvert(
        IrExpression expression,
        Type to,
        out (IrExpression arg, TypeConversion conversion) result)
    {
        Type from = expression.Type;
        result = TryAssignToType(expression, to, throwError: false)!;
        if (result.conversion != TypeConversion.NoMatch)
            return true;

        if (CqlOperators.ConversionFunctionName(from, to) is { } functionName)
        {
            var convertMethod = BindToBestMethodOverload(functionName, [expression], [], throwError: false);
            if (convertMethod != null)
            {
                result = (convertMethod, TypeConversion.OperatorConvert);
                return true;
            }
        }

        if (_typeConverter.CanConvert(from, to))
        {
            var bindToGenericMethod = BindToBestMethodOverload(nameof(ICqlOperators.Convert), [AssignToType(expression, typeof(object))], [to], false);
            if (bindToGenericMethod != null)
            {
                result = (bindToGenericMethod, TypeConversion.OperatorConvert);
                return true;
            }
        }

        return false;
    }

    private IrInvoke? BindToBestMethodOverload(
        string methodName,
        IrExpression[] methodArguments,
        Type[] genericTypeArguments,
        bool throwError = true)
    {
        var (methodInfo, convertedArgs) = ResolveMethodInfoWithPotentialArgumentConversions(methodName, methodArguments, genericTypeArguments, throwError);
        if ((methodInfo, throwError) is (null, false))
            return null;

        try
        {
            var call = new IrInvoke(OperatorsReceiver, methodInfo!, convertedArgs);
            return call;
        }
        catch (Exception e)
        {
            if (throwError)
            {
                // FIXME(phase6): unify with CannotBindToCqlOperatorError, which requires
                // Expression[] and cannot be constructed from IrExpression[] without modifying
                // the shared (Expression-based) error type. Build the same message shape by
                // hand until the old binder is deleted and the error type can be generalized.
                throw new InvalidOperationException(FormatCannotBindMessage(methodName, methodArguments, genericTypeArguments), e);
            }
            return null;
        }
    }

    /// <summary>
    /// Casts the given <paramref name="expression"/> to the specified type <paramref name="type"/>.
    /// </summary>
    /// <param name="expression">The expression to cast.</param>
    /// <param name="type">The type to cast the expression to.</param>
    /// <returns>The expression that was cast.</returns>
    public virtual IrExpression CastToType(IrExpression expression, Type type)
    {
        if (expression.Type != typeof(object))
            throw new ArgumentException("Cast only allowed on Object typed expressions.", nameof(expression));

        return AssignToType(expression, type);
    }

    /// <summary>
    /// Converts the given <paramref name="expression"/> to the specified type <paramref name="type"/>.
    /// </summary>
    /// <param name="expression">The expression to convert.</param>
    /// <param name="type">The type to convert the expression to.</param>
    /// <returns>The converted expression.</returns>
    public virtual IrExpression ConvertToType(IrExpression expression, Type type) =>
        TryConvert(expression, type, out var t)
            ? t.arg!
            : throw new InvalidOperationException($"Cannot convert '{expression.Type.FullName}' to '{type.FullName}'");

    // --- Ported from the old Expressions/ExpressionExtensions.cs (NewAssignToTypeExpression /
    // TryNewAssignToTypeExpression / NewTypeAsExpression / IsNullConstant): those helpers are
    // dependencies of TryConvert and the Specific.cs bindings, but aren't listed as one of the
    // partial files in the phase-3 brief, so they're consolidated here alongside the other
    // conversion machinery rather than given their own file.

    private static IrExpression AssignToType(IrExpression expression, Type type) =>
        TryAssignToType(expression, type).expression!;

    private static (IrExpression? expression, TypeConversion typeConversion) TryAssignToType(
        IrExpression expression,
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
                    return (NullOfType(type), TypeConversion.ExactType);

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
                        throw new InvalidOperationException($"Enum value {dateTimeString} is not defined in enum type {typeof(Hl7.Cql.Iso8601.DateTimePrecision)}");
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

    private static IrExpression TypeAsExpression(IrExpression expression, Type type)
    {
        if (expression.Type == type)
            return expression;

        return new IrCast(expression, type, IrCastKind.As);
    }

    private static bool IsNullConstant(IrExpression expression) =>
        expression is IrConstant { Value: null };

    /// <summary>A typed null constant, mirroring the old <c>NullExpression.ForType(Type)</c>.</summary>
    private static IrConstant NullOfType(Type type) => new(null, type);

    /// <summary>A typed null constant, mirroring the old <c>NullExpression.ForType&lt;TType&gt;()</c>.</summary>
    private static IrConstant NullOfType<TType>() => NullOfType(typeof(TType));
}
