/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class RedundantCastsTransformer : ExpressionVisitor
    {
        protected override Expression VisitConditional(ConditionalExpression node)
        {
            var condition = Visit(node.Test);

            // if(true,A,B) => A /  if(false,A,B) => B
            return condition switch
            {
                ConstantExpression { Value: true } => Visit(node.IfTrue),
                ConstantExpression { Value: false } => Visit(node.IfFalse),
                _ => node.Update(condition, Visit(node.IfTrue), Visit(node.IfFalse))
            };
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            if (node is { NodeType: ExpressionType.Convert or ExpressionType.TypeAs } conversion)
            {
                var reducedOperand = Visit(conversion.Operand);

                // (T)(T?)x::T => x
                if (reducedOperand is UnaryExpression { NodeType: ExpressionType.Convert or ExpressionType.TypeAs } nested &&
                    Nullable.GetUnderlyingType(nested.Type) == conversion.Type)
                {
                    var reducedOperandOfNestedConversion = Visit(nested.Operand);
                    if (reducedOperandOfNestedConversion.Type == node.Type)
                        return reducedOperandOfNestedConversion;
                    else
                        return conversion.Update(nested.Update(reducedOperandOfNestedConversion));
                }

                var removeCast = true;
                if (conversion.Type.IsAssignableFrom(conversion.Operand.Type) == false)
                    removeCast = false;

                if (conversion.Method != null)
                    removeCast = false;
                if (Nullable.GetUnderlyingType(conversion.Type) is not null)
                {
                    removeCast = false;
                    // This causes a RTE if enabled, and I couldn't find out why, so I disabled it.
                    //if (conversion.Operand.NodeType == ExpressionType.Constant
                    //    || conversion.Operand.NodeType == ExpressionType.Default)
                    //    removeCast = false;
                    //if (conversion.Operand is BinaryExpression be && be.NodeType == ExpressionType.Equal
                    //    && (be.Right.NodeType == ExpressionType.Constant
                    //    || be.Right.NodeType == ExpressionType.Default))
                    //{
                    //    removeCast = false;
                    //}
                }
                else
                {
                    if (conversion.Type != typeof(object))
                    {
                        removeCast = false;
                    }
                    else
                    {
                        if (reducedOperand.Type.IsValueType)
                            removeCast = false;
                    }
                }

                if (removeCast)
                {
                    return reducedOperand;
                }

                return conversion.Update(reducedOperand);
            }

            return base.VisitUnary(node);
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            // ((T?)a::T) ?? b::T => a
            if (node is
                {
                    NodeType: ExpressionType.Coalesce,
                    Left: UnaryExpression { NodeType: ExpressionType.Convert or ExpressionType.TypeAs } conversion
                } && Nullable.GetUnderlyingType(conversion.Operand.Type) is null
                 && Nullable.GetUnderlyingType(conversion.Type) == conversion.Operand.Type
                )
            {
                return Visit(conversion.Operand);
            }
            else if (node is { NodeType: ExpressionType.Coalesce } coalesce)
            {
                var left = Visit(coalesce.Left);
                var right = Visit(coalesce.Right);

                // a (not null) ?? x => a
                if (left is ConstantExpression ce && ce.Value is not null)
                    return left;

                var isNullableType = !left.Type.IsValueType || Nullable.GetUnderlyingType(left.Type) is not null;

                if (left is DefaultExpression && isNullableType)
                    return right;

                return coalesce.Update(left, coalesce.Conversion, right);
            }

            return base.VisitBinary(node);
        }
    }
}
