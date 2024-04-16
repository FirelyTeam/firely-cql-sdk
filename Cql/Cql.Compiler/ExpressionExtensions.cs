using System;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler;

internal static class ExpressionExtensions
{
    public static UnaryExpression ExprConvert(this Expression expression, Type type)
    {
        var cast = Expression.Convert(expression, type);
        return cast;
    }

    public static UnaryExpression ExprConvert<TType>(this Expression expression) => ExprConvert(expression, typeof(TType));


    public static UnaryExpression ExprTypeAs(this Expression expression, Type type)
    {
        var typeAs = Expression.TypeAs(expression, type);
        return typeAs;
    }

    public static UnaryExpression ExprTypeAs<TType>(this Expression expression) => ExprTypeAs(expression, typeof(TType));

    public static TypeBinaryExpression ExprTypeIs(this Expression expression, Type type)
    {
        var typeAs = Expression.TypeIs(expression, type);
        return typeAs;
    }
}