/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class FlattenLetExpressionVisitor : ExpressionVisitor
    {
        private readonly List<BinaryExpression> _assignments = new();
        public IReadOnlyCollection<BinaryExpression> Assignments => _assignments;

        //protected override Expression VisitBlock(BlockExpression node)
        //{
        //    var judgedVariables = node.Variables.GroupBy(_encounteredVariables.Contains);
        //    var newVariables = judgedVariables.Single(j => j.Key == false);
        //    var reintroducedVariables = judgedVariables.Single(j => j.Key == true);

        //    _encounteredVariables.AddRange(newVariables);

        //    // Beginning of scope, add replacements for this scope
        //    var replacements = reintroducedVariables.Select(v => (v, Expression.Parameter(v.Type)));
        //    foreach (var replacement in replacements) _replacements.Add(replacement.Item1, replacement.Item2);
        //    _encounteredVariables.AddRange(replacements.Select(r => r.Item2));

        //    var replacedChildren = node.Expressions.Select(n => base.Visit(n));

        //    // End of scope, remove replacements for this scope.
        //    foreach (var replacement in replacements) _replacements.Remove(replacement.Item1);

        //    return Expression.Block(replacedChildren);
        //}

        // Todo: we could support the other assignments too (but we don't need them ourselves).
        // private static bool isAssignment(Expression e) => e is BinaryExpression { NodeType: ExpressionType.Assign };

        protected override Expression VisitExtension(Expression node)
        {
            if (node is LetExpression le)
            {
                var visitedLets = le.LetStatements.Select(ls => ls.Update(ls.Left, ls.Conversion, Visit(ls.Right)));
                _assignments.AddRange(visitedLets);

                return le.Update(visitedLets, Visit(le.Expression));
            }
            else
            {
                return VisitExtension(node);
            }
        }
    }


    internal class ParameterReplacer : ExpressionVisitor
    {
        public ParameterReplacer(IDictionary<string, ParameterExpression> replacements)
        {
            Replacements = replacements;
        }

        public IDictionary<string, ParameterExpression> Replacements { get; }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            if (node.Name != null && Replacements.TryGetValue(node.Name, out var replacement))
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
                    && Replacements.Keys.Contains(parameter.Name))
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
