/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    /// <summary>
    /// Finds assignments with duplicate rhs, and then de-duplicates those variables.
    /// </summary>
    /// <remarks>Note that it is not trivial to determine whether expressions are duplicates, so we
    /// turn the expressions into strings using the (internal) DebugView visitor provided by Microsoft.
    /// This requires a full reduction and visit of the tree, so is quite expensive.</remarks>
    internal class LocalVariableDeduper : ExpressionVisitor
    {
        private readonly Stack<Dictionary<ParameterExpression, ParameterExpression>> _replacementStack = new();

        protected override Expression VisitBlock(BlockExpression node)
        {
            var localAssignments = node.Expressions
                            .OfType<BinaryExpression>()
                            .Where(be => be.Left is ParameterExpression pe && node.Variables.Contains(pe));

            // Find assignments where the right side is exactly the same.
            var duplicateAssignments = localAssignments
                .GroupBy(ass => $"{ass.Right.GetDebugView()}::{ExpressionConverter.PrettyTypeName(ass.Right.Type)}")
                .Where(g => g.Count() > 1) // && !g.Key.Contains("Deeper")
                .ToList();

            // Select the first of each group which duplicates to remain, and remove the others
            // from the block's local variables
            var assignmentsToRemove = duplicateAssignments.SelectMany(ga => ga.Skip(1));
            var strippedNode = node.Update(node.Variables, node.Expressions.Except(assignmentsToRemove));

            // Now, replace the "others" by the selected candidate.
            var replacements =
                    from likeVariables in from g in duplicateAssignments
                                          select g.Select(g => (ParameterExpression)g.Left)
                    let first = likeVariables.First()
                    from variable in likeVariables.Skip(1)
                    select KeyValuePair.Create(variable, first);

            var replacementDictionary = new Dictionary<ParameterExpression, ParameterExpression>(replacements);

            // Since the variables can be nested deeply, we'll go deeper using this visitor. In the mean time,
            // when we encounter new Blocks with new duplicates, we'll gather those too, resulting in a 
            // stack of replacements that are only applicable to the current syntactical scope and deeper.
            _replacementStack.Push(replacementDictionary);
            var visitedLocals = node.Variables.Select(v => (ParameterExpression)Visit(v)).Distinct();
            var visitedExpressions = Visit(strippedNode.Expressions);
            var visitedExpression = node.Update(visitedLocals, visitedExpressions);
            _replacementStack.Pop();

            return visitedExpression;
        }

        // Visit the replacements from nearest lexical scope up, and see if we need to replace the
        // parameter we have encountered.
        protected override Expression VisitParameter(ParameterExpression node) =>
            _replacementStack
                .Select(s => s.GetValueOrDefault(node))
                .FirstOrDefault(n => n is not null) ?? node;
    }
}
