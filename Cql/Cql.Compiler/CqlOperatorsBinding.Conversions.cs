using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Hl7.Cql.Operators;

namespace Hl7.Cql.Compiler;

partial class CqlOperatorsBinding
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
                Expression.Convert(fromExpr, typeof(object)));
            return true;
        }

        if (fromExpr is ConstantExpression { Value: null }
            && Nullable.GetUnderlyingType(to) is not null)
        {
            toExpr = CqlExpressions.Null_ConstantExpression(to);
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
}
