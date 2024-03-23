#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
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
    internal partial class ExpressionBuilderContext
    {
        protected Expression Equal(elm.Equal eq)
        {
            var lhsExpression = this.TranslateExpression(eq.operand![0]);
            var rhsExpression = this.TranslateExpression(eq.operand![1]);
            return Equal(lhsExpression, rhsExpression);
        }

        protected Expression NotEqual(elm.NotEqual eq)
        {
            var lhsExpression = this.TranslateExpression(eq.operand![0]);
            var rhsExpression = this.TranslateExpression(eq.operand![1]);
            var equal = this.Equal(lhsExpression, rhsExpression);
            var not = this.OperatorBinding.Bind(CqlOperator.Not, this.RuntimeContextParameter, equal);
            return not;
        }

        protected Expression Equal(Expression left, Expression right)
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
                    var call = this.OperatorBinding.Bind(CqlOperator.EnumEqualsString,
                        this.RuntimeContextParameter,
                        Expression.Convert(left, typeof(object)),
                        right);
                    return call;
                }
                else throw new NotImplementedException().WithContext(this);
            }
            else if (IsEnum(right.Type))
            {
                if (left.Type == typeof(string))
                {
                    var call = this.OperatorBinding.Bind(CqlOperator.EnumEqualsString,
                        this.RuntimeContextParameter,
                        Expression.Convert(right, typeof(object)),
                        left);
                    return call;

                }
                else throw new NotImplementedException().WithContext(this);
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type, true)!;
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type, true)!;
                    if (rightElementType != leftElementType)
                        throw this.NewExpressionBuildingException($"Cannot compare a list of {TypeManager.PrettyTypeName(leftElementType)} with {TypeManager.PrettyTypeName(rightElementType)}");
                    var call = this.OperatorBinding.Bind(CqlOperator.ListEqual, this.RuntimeContextParameter, left, right);
                    return call;
                }
                throw new NotImplementedException().WithContext(this);
            }
            else
            {
                var call = this.OperatorBinding.Bind(CqlOperator.Equal, this.RuntimeContextParameter, left, right);
                return call;
            }
        }

        protected Expression Equivalent(elm.Equivalent eqv)
        {
            var left = this.TranslateExpression(eqv.operand![0]);
            var right = this.TranslateExpression(eqv.operand![1]);
            if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                var leftElementType = _typeManager.Resolver.GetListElementType(left.Type);
                if (IsOrImplementsIEnumerableOfT(right.Type))
                {
                    var rightElementType = _typeManager.Resolver.GetListElementType(right.Type);
                    if (leftElementType != rightElementType)
                    {
                        // This appears in the CQL tests:
                        //  { 'a', 'b', 'c' } ~ { 1, 2, 3 } = false
                        return Expression.Constant(false, typeof(bool?));
                    }
                    var call = this.OperatorBinding.Bind(CqlOperator.ListEquivalent, this.RuntimeContextParameter, left, right);
                    return call;
                }
                else
                {
                    throw new NotImplementedException().WithContext(this);
                }
            }
            else
            {
                var call = this.OperatorBinding.Bind(CqlOperator.Equivalent, this.RuntimeContextParameter, left, right);
                return call;
            }
        }

        protected Expression Greater(elm.Greater e) =>
            BinaryOperator(CqlOperator.Greater, e);

        protected Expression GreaterOrEqual(elm.GreaterOrEqual e) =>
            BinaryOperator(CqlOperator.GreaterOrEqual, e);

        protected Expression Less(elm.Less e) =>
            BinaryOperator(CqlOperator.Less, e);
        protected Expression LessOrEqual(elm.LessOrEqual e) =>
            BinaryOperator(CqlOperator.LessOrEqual, e);




    }
}
