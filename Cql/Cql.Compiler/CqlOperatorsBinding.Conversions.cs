using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Operators;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler;

partial class CqlOperatorsBinder
{
    private bool TryConvert(
        Expression fromExpr,
        Type to,
        [NotNullWhen(true)] out Expression? toExpr)
    {
        Type from = fromExpr.Type;

        if (from == to)
        {
            toExpr = fromExpr;
            return true;
        }

        if (fromExpr is ConstantExpression fromConstant)
        {
            if (fromConstant.Value is null && to.AllowNullValues())
            {
                // Null
                toExpr = NullConstantExpression.ForType(to);
                return true;
            }

            if (fromConstant.Value is Enum enumValue && to == typeof(string) )
            {
                // Enum to lowercase string
                var name = Enum.GetName(enumValue.GetType(), enumValue);
                if (name is null)
                    throw new InvalidOperationException($"Enum value {enumValue} is not defined in enum type {enumValue.GetType()}");
                toExpr = Expression.Constant(name.ToLowerInvariant());
                return true;
            }

            if (fromConstant.Type.IsValueType && to.IsNullable(out var toUnderlyingType) && fromConstant.Type == toUnderlyingType)
            {
                // e.g. int -> int?
                toExpr = Expression.Convert(fromExpr, to);
                return true;
            }
        }

        if (to.IsAssignableFrom(from))
        {
            toExpr = Expression.Convert(fromExpr, to); // Direct cast
            return true;
        }

        if (_typeConverter?.CanConvert(from, to) == true)
        {
            toExpr = BindToGenericMethod(
                nameof(ICqlOperators.Convert),
                [to],
                fromExpr.ExprConvert<object>());
            return true;
        }

        toExpr = null;
        return false;
    }

    private MethodCallExpression BindToMethodConvertArgs(
        string methodName,
        params Expression[] arguments)
    {
        var (methodInfo, convertedArgs) = ResolveMethodInfoWithPotentialArgumentConversions(methodName, arguments);
        var call = Expression.Call(CqlExpressions.Operators_PropertyExpression, methodInfo!, convertedArgs);
        return call;
    }

    internal static MethodCallExpression CallCreateValueSetFacade(Expression operand)
    {
        var createFacadeMethod = typeof(ICqlOperators).GetMethod(nameof(ICqlOperators.CreateValueSetFacade))!;
        var call = Expression.Call(CqlExpressions.Operators_PropertyExpression, createFacadeMethod, operand);
        return call;
    }
}
