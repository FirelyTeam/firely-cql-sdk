using Ncqa.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using elm = Ncqa.Elm.Expressions;

namespace Ncqa.Cql.MeasureCompiler
{
    public partial class ExpressionBuilder
    {
        protected Expression Equal(elm.EqualExpression eq, ExpressionBuilderContext ctx)
        {
            var lhsExpression = TranslateExpression(eq.operand![0], ctx);
            var rhsExpression = TranslateExpression(eq.operand![1], ctx);
            return Equal(lhsExpression, rhsExpression, ctx);
        }

        protected Expression Equal(Expression left, Expression right, ExpressionBuilderContext ctx)
        {
            var leftNv = CoalesceNullableValueType(left);
            var rightNv = CoalesceNullableValueType(right);

            if (leftNv.Type.IsEnum)
            {
                if (rightNv.Type.IsEnum)
                {
                    var equal = Expression.Equal(leftNv, rightNv);
                    var asNullable = Expression.Convert(equal, typeof(bool?));
                    return asNullable;
                }
                else if (rightNv.Type == typeof(string))
                {
                    var call = Operators.Bind(CqlOperator.EnumEqualsString,
                        ctx.RuntimeContextParameter,
                        Expression.Convert(leftNv, typeof(object)),
                        right);
                    return call;
                }
                else throw new NotImplementedException();
            }
            else if (rightNv.Type.IsEnum)
            {
                if (leftNv.Type == typeof(string))
                {
                    var call = Operators.Bind(CqlOperator.EnumEqualsString, 
                        ctx.RuntimeContextParameter,
                        Expression.Convert(rightNv, typeof(object)),
                        left);
                    return call;

                }
                else throw new NotImplementedException();
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = TypeResolver.GetListElementType(left.Type, true)!;
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = TypeResolver.GetListElementType(right.Type, true)!;
                    if (rightElementType != leftElementType)
                        throw new InvalidOperationException($"Cannot compare a list of {TypeManager.PrettyTypeName(leftElementType)} with {TypeManager.PrettyTypeName(rightElementType)}");
                    var call = Operators.Bind(CqlOperator.ListEqual, ctx.RuntimeContextParameter, left, right);
                    return call;
                }
                throw new NotImplementedException();
            }
            else 
            {
                var call = Operators.Bind(CqlOperator.Equal, ctx.RuntimeContextParameter, left, right);
                return call;
            }
        }

        protected Expression Equivalent(elm.EquivalentExpression eqv, ExpressionBuilderContext ctx)
        {
            var left = TranslateExpression(eqv.operand![0], ctx);
            var right = TranslateExpression(eqv.operand![1], ctx);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = TypeResolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = TypeResolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                    {
                        // This appears in the CQL tests:
                        //  { 'a', 'b', 'c' } ~ { 1, 2, 3 } = false
                        return Expression.Constant(false, typeof(bool?));
                    }
                    var call = Operators.Bind(CqlOperator.ListEquivalent, ctx.RuntimeContextParameter, left, right);
                    return call;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else
            {
                var call = Operators.Bind(CqlOperator.Equivalent, ctx.RuntimeContextParameter, left, right);
                return call;
            }
        }

        protected Expression Greater(elm.GreaterExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Greater, e, ctx);

        protected Expression GreaterOrEqual(elm.GreaterOrEqualExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.GreaterOrEqual, e, ctx);

        protected Expression Less(elm.LessExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Less, e, ctx);
        protected Expression LessOrEqual(elm.LessOrEqualExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.LessOrEqual, e, ctx);




    }
}
