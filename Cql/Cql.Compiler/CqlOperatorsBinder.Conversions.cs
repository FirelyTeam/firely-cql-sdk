/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Exceptions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Utility;

namespace Hl7.Cql.Compiler;

/// <summary>
/// Argument conversions: <see cref="TryConvert"/> and the <see cref="TypeConversion"/>
/// ranking. See the remarks on <see cref="CqlOperatorsBinder"/>.
/// </summary>
partial class CqlOperatorsBinder
{
    /// <summary>
    /// The <c>context.Operators</c> property access used as the receiver of every
    /// <see cref="ICqlOperators"/> call. Corresponds to <c>CqlExpressions.Operators_PropertyExpression</c>
    /// in the old binder.
    /// </summary>
    private static CodeExpression OperatorsReceiver { get; } =
        new CodeProperty(CodeContextParameter.Instance, typeof(CqlContext).GetProperty(nameof(CqlContext.Operators))!);

    /// <summary>
    /// Tries to convert the given <paramref name="expression"/> to the specified type <paramref name="to"/>.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public virtual bool TryConvert(
        CodeExpression expression,
        Type to,
        out (CodeExpression arg, TypeConversion conversion) result)
    {
        Type from = expression.Type;
        result = expression.TryNewAssignToTypeExpression(to, throwError: false)!;
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
            var bindToGenericMethod = BindToBestMethodOverload(nameof(ICqlOperators.Convert), [expression.NewAssignToTypeExpression<object>()], [to], false);
            if (bindToGenericMethod != null)
            {
                result = (bindToGenericMethod, TypeConversion.OperatorConvert);
                return true;
            }
        }

        return false;
    }

    private CodeInvoke? BindToBestMethodOverload(
        string methodName,
        CodeExpression[] methodArguments,
        Type[] genericTypeArguments,
        bool throwError = true)
    {
        var (methodInfo, convertedArgs) = ResolveMethodInfoWithPotentialArgumentConversions(methodName, methodArguments, genericTypeArguments, throwError);
        if ((methodInfo, throwError) is (null, false))
            return null;

        try
        {
            var call = new CodeInvoke(OperatorsReceiver, methodInfo!, convertedArgs);
            return call;
        }
        catch (Exception e)
        {
            if (throwError)
            {
                throw new CannotBindToCqlOperatorError(
                        methodName,
                        methodArguments.SelectToArray(a => a.Type),
                        genericTypeArguments,
                        ICqlOperatorsMethods.GetMethodsByName(methodName))
                    .ToException(e);
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
    public virtual CodeExpression CastToType(CodeExpression expression, Type type)
    {
        if (expression.Type != typeof(object))
            throw new ArgumentException("Cast only allowed on Object typed expressions.", nameof(expression));

        return expression.NewAssignToTypeExpression(type);
    }

    /// <summary>
    /// Converts the given <paramref name="expression"/> to the specified type <paramref name="type"/>.
    /// </summary>
    /// <param name="expression">The expression to convert.</param>
    /// <param name="type">The type to convert the expression to.</param>
    /// <returns>The converted expression.</returns>
    public virtual CodeExpression ConvertToType(CodeExpression expression, Type type) =>
        TryConvert(expression, type, out var t)
            ? t.arg!
            : throw new InvalidOperationException($"Cannot convert '{expression.Type.FullName}' to '{type.FullName}'");

    // The assign-to-type / type-as / is-null-constant helpers formerly duplicated here (private
    // phase-3 copies, predating CodeExpressionExtensions) are gone as of phase 6: TryConvert and
    // the Specific.cs bindings now call the shared Hl7.Cql.Compiler.CodeModel.CodeExpressionExtensions
    // versions directly (NewAssignToTypeExpression / TryNewAssignToTypeExpression /
    // NewTypeAsExpression / IsNullConstant). There is no shared "NullOfType" helper there, so
    // those call sites construct `new CodeConstant(null, type)` inline instead.
}
