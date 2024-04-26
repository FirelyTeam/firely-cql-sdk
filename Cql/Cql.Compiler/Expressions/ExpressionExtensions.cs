using System;
using System.Linq.Expressions;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Compiler.Expressions;

internal static class ExpressionExtensions
{
    public static Expression ConvertExpression(this Expression expression, Type type)
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
            }
        }

        Expression cast = Expression.Convert(expression, type);
        return cast;
    }

    public static Expression ConvertExpression<TType>(this Expression expression) =>
        expression.ConvertExpression(typeof(TType));


    public static Expression TypeAsExpression(this Expression expression, Type type)
    {
        if (expression.Type == type)
            return expression;

        var typeAs = Expression.TypeAs(expression, type);
        return typeAs;
    }

    public static Expression TypeAsExpression<TType>(this Expression expression) =>
        expression.TypeAsExpression(typeof(TType));

    public static TypeBinaryExpression TypeIsExpression(this Expression expression, Type type)
    {
        var typeAs = Expression.TypeIs(expression, type);
        return typeAs;
    }
}