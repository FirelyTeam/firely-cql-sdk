/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Compiler.Expressions;
using Hl7.Cql.Operators;
using Hl7.Cql.Runtime;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler;

partial class CqlOperatorsBinder
{

    /// <summary>
    /// Tries to convert the given <paramref name="expression"/> to the specified type <paramref name="to"/>.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public virtual bool TryConvert(
        Expression expression,
        Type to,
        out (Expression arg, TypeConversion conversion) result)
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

    private MethodCallExpression? BindToBestMethodOverload(
        string methodName,
        Expression[] methodArguments,
        Type[] genericTypeArguments,
        bool throwError=true)
    {
        var (methodInfo, convertedArgs) = ResolveMethodInfoWithPotentialArgumentConversions(methodName, methodArguments, genericTypeArguments, throwError);
        if ((methodInfo, throwError) is (null, false))
            return null;

        try
        {
            var call = Expression.Call(CqlExpressions.Operators_PropertyExpression, methodInfo!, convertedArgs);
            return call;
        }
        catch (Exception e)
        {
            if (throwError)
                throw new CannotBindToCqlOperatorError(methodName, methodArguments, genericTypeArguments, ICqlOperatorsMethods.GetMethodsByName(methodName)).ToException(e);
            return null;
        }
    }

    /// <summary>
    /// Casts the given <paramref name="expression"/> to the specified type <paramref name="type"/>.
    /// </summary>
    /// <param name="expression">The expression to cast.</param>
    /// <param name="type">The type to cast the expression to.</param>
    /// <returns>The expression that was cast.</returns>
    public virtual Expression CastToType(Expression expression, Type type)
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
    public virtual Expression ConvertToType(Expression expression, Type type) =>
        TryConvert(expression, type, out var t)
            ? t.arg!
            : throw new InvalidOperationException($"Cannot convert '{expression.Type.FullName}' to '{type.FullName}'");
}