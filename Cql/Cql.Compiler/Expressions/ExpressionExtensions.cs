using System;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler.Expressions;

internal static class ExpressionExtensions
{
    public static UnaryExpression ConvertExpression(this Expression expression, Type type)
    {
        var cast = Expression.Convert(expression, type);
        return cast;
    }

    public static UnaryExpression ConvertExpression<TType>(this Expression expression) => ConvertExpression(expression, typeof(TType));


    public static UnaryExpression TypeAsExpression(this Expression expression, Type type)
    {
        var typeAs = Expression.TypeAs(expression, type);
        return typeAs;
    }

    public static UnaryExpression TypeAsExpression<TType>(this Expression expression) => TypeAsExpression(expression, typeof(TType));

    public static TypeBinaryExpression TypeIsExpression(this Expression expression, Type type)
    {
        var typeAs = Expression.TypeIs(expression, type);
        return typeAs;
    }
}