/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class RedundantCastsTransformer : TransformerBase
    {
        protected override Expression VisitUnary(UnaryExpression node)
        {
            // unwrap useless chained casts, e.g.:
            //  ((bool)((bool?)((bool?)(ClaimofInterest == null))))
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
