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

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression Equal(Elm.Equal eq)
        {
            var lhsExpression = TranslateExpression(eq.operand![0]);
            var rhsExpression = TranslateExpression(eq.operand![1]);
            return Equal(lhsExpression, rhsExpression);
        }

        protected Expression NotEqual(Elm.NotEqual eq)
        {
            var lhsExpression = TranslateExpression(eq.operand![0]);
            var rhsExpression = TranslateExpression(eq.operand![1]);
            var equal = Equal(lhsExpression, rhsExpression);
            var not = BindCqlOperator(CqlOperator.Not, equal);
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
                    var call = BindCqlOperator(CqlOperator.EnumEqualsString,
                        LibraryDefinitionsBuilder.ContextParameter,
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
                    var call = BindCqlOperator(CqlOperator.EnumEqualsString,
                        LibraryDefinitionsBuilder.ContextParameter,
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
                    var call = BindCqlOperator(CqlOperator.ListEqual, left, right);
                    return call;
                }
                throw new NotImplementedException().WithContext(this);
            }
            else
            {
                var call = BindCqlOperator(CqlOperator.Equal, left, right);
                return call;
            }
        }

        protected Expression Equivalent(Elm.Equivalent eqv)
        {
            var left = TranslateExpression(eqv.operand![0]);
            var right = TranslateExpression(eqv.operand![1]);
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
                    var call = BindCqlOperator(CqlOperator.ListEquivalent, left, right);
                    return call;
                }
                else
                {
                    throw new NotImplementedException().WithContext(this);
                }
            }
            else
            {
                var call = BindCqlOperator(CqlOperator.Equivalent, left, right);
                return call;
            }
        }
    }
}
