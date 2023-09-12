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
            var reducedNode = node.Update(condition, node.IfTrue, node.IfFalse);

            // if(true,A,B) => A /  if(false,A,B) => B
            return condition switch
            {
                ConstantExpression { Value: true } => reducedNode.IfTrue,
                ConstantExpression { Value: false } => reducedNode.IfFalse,
                _ => reducedNode
            };
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            // ((T?)T_A) ?? T_B => T_A
            if (node is
                {
                    NodeType: ExpressionType.Coalesce,
                    Left: UnaryExpression { NodeType: ExpressionType.Convert } ue
                } coal && coal.Type == Nullable.GetUnderlyingType(ue.Type))
            {
                return Visit(ue.Operand);
            }

            return base.VisitBinary(node);
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            //unwrap useless chained casts, e.g.:
            //    ((bool)((bool?)((bool?)(ClaimofInterest == null))))
            if (node.NodeType == ExpressionType.Convert)
            {
                var finalType = node.Type;
                var operand = node.Operand;
                while (operand.NodeType == ExpressionType.Convert && operand is UnaryExpression unaryOperand)
                {
                    operand = unaryOperand.Operand;
                }
                if (finalType == operand.Type)
                    //if (finalType.IsAssignableFrom(operand.Type))
                    return Visit(operand);
                else
                {
                    var visited = Visit(operand);
                    var finalConvert = Expression.Convert(visited, finalType);
                    return finalConvert;
                }
            }
            return base.VisitUnary(node);
        }
    }
}
