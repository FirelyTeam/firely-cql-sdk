/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression Equal(elm.Equal eq, ExpressionBuilderContext ctx)
        {
            var lhsExpression = TranslateExpression(eq.operand![0], ctx);
            var rhsExpression = TranslateExpression(eq.operand![1], ctx);
            return Equal(lhsExpression, rhsExpression, ctx);
        }

        protected Expression NotEqual(elm.NotEqual eq, ExpressionBuilderContext ctx)
        {
            var lhsExpression = TranslateExpression(eq.operand![0], ctx);
            var rhsExpression = TranslateExpression(eq.operand![1], ctx);
            var equal = Equal(lhsExpression, rhsExpression, ctx);
            var not = OperatorBinding.Bind(CqlOperator.Not, ctx.RuntimeContextParameter, equal);
            return not;
        }

        protected Expression Equal(Expression left, Expression right, ExpressionBuilderContext ctx)
        {
            if (IsEnum(left.Type))
            {
                if (IsEnum(right.Type))
                {
                    var equal = Expression.Equal(left, right);
                    var asNullable = Expression.Convert(equal, typeof(bool?));
                    return asNullable;
                }
                else if (right.Type == typeof(string))
                {
                    var call = OperatorBinding.Bind(CqlOperator.EnumEqualsString,
                        ctx.RuntimeContextParameter,
                        Expression.Convert(left, typeof(object)),
                        right);
                    return call;
                }
                else throw new NotImplementedException();
            }
            else if (IsEnum(right.Type))
            {
                if (left.Type == typeof(string))
                {
                    var call = OperatorBinding.Bind(CqlOperator.EnumEqualsString,
                        ctx.RuntimeContextParameter,
                        Expression.Convert(right, typeof(object)),
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
                    var call = OperatorBinding.Bind(CqlOperator.ListEqual, ctx.RuntimeContextParameter, left, right);
                    return call;
                }
                throw new NotImplementedException();
            }
            else
            {
                var call = OperatorBinding.Bind(CqlOperator.Equal, ctx.RuntimeContextParameter, left, right);
                return call;
            }
        }

        protected Expression Equivalent(elm.Equivalent eqv, ExpressionBuilderContext ctx)
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
                    var call = OperatorBinding.Bind(CqlOperator.ListEquivalent, ctx.RuntimeContextParameter, left, right);
                    return call;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else
            {
                var call = OperatorBinding.Bind(CqlOperator.Equivalent, ctx.RuntimeContextParameter, left, right);
                return call;
            }
        }

        protected Expression Greater(elm.Greater e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Greater, e, ctx);

        protected Expression GreaterOrEqual(elm.GreaterOrEqual e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.GreaterOrEqual, e, ctx);

        protected Expression Less(elm.Less e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Less, e, ctx);
        protected Expression LessOrEqual(elm.LessOrEqual e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.LessOrEqual, e, ctx);




    }
}
