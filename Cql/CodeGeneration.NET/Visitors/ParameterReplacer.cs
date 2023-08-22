/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{


    internal class ParameterReplacer : ExpressionVisitor
    {
        public ParameterReplacer(IDictionary<ParameterExpression, ParameterExpression> replacements)
        {
            Replacements = replacements;
        }

        public IDictionary<ParameterExpression, ParameterExpression> Replacements { get; }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            if (Replacements.TryGetValue(node, out var replacement))
                return replacement;
            else
                return base.VisitParameter(node);
        }

        protected override Expression VisitBlock(BlockExpression node)
        {
            var newExpressions = new List<Expression>();
            foreach (var expression in node.Expressions)
            {
                if (expression is BinaryExpression be
                    && be.Left is ParameterExpression parameter
                    && parameter.Name != null
                    && Replacements.Keys.Contains(parameter))
                {
                    continue;
                }
                else
                {
                    newExpressions.Add(Visit(expression));
                }
            }
            var newBlock = Expression.Block(node.Variables, newExpressions.ToArray());
            return newBlock;
        }
    }
}
