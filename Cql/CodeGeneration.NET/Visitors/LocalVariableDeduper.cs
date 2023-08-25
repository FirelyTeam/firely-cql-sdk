/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
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
                .GroupBy(ass => $"{ass.Right.GetDebugView()}::{ass.Right.Type.Name}")
                .Where(g => g.Count() > 1) // && !g.Key.Contains("Deeper")
                .ToList();

            var assignmentsToRemove = duplicateAssignments.SelectMany(ga => ga.Skip(1));
            var strippedNode = node.Update(node.Variables, node.Expressions.Except(assignmentsToRemove));

            var replacements =
                    from likeVariables in from g in duplicateAssignments
                                          select g.Select(g => (ParameterExpression)g.Left)
                    let first = likeVariables.First()
                    from variable in likeVariables.Skip(1)
                    select KeyValuePair.Create(variable, first);

            var replacementDictionary = new Dictionary<ParameterExpression, ParameterExpression>(replacements);

            _replacementStack.Push(replacementDictionary);
            var visitedLocals = node.Variables.Select(v => (ParameterExpression)Visit(v)).Distinct();
            var visitedExpression = node.Update(visitedLocals, Visit(strippedNode.Expressions));
            _replacementStack.Pop();

            return visitedExpression;
        }

        protected override Expression VisitParameter(ParameterExpression node) =>
            _replacementStack
                .Select(s => s.GetValueOrDefault(node))
                .FirstOrDefault(n => n is not null) ?? node;


        //protected Expression VisitBlock2(BlockExpression node)
        //{
        //    var replacementsFound = true;
        //    var replacements = new Dictionary<ParameterExpression, ParameterExpression>();

        //    //var variableExpressions = node.Expressions
        //    //    .OfType<BinaryExpression>()
        //    //    .Where(be => be.Left is ParameterExpression)
        //    //    .ToArray();
        //    var newExpressions = new Expression[node.Expressions.Count];
        //    var variableExpressions = new List<BinaryExpression>();
        //    for (int i = 0; i < node.Expressions.Count; i++)
        //    {
        //        var expression = node.Expressions[i];
        //        if (expression is BinaryExpression be && be.Left is ParameterExpression)
        //        {
        //            var right = Visit(be.Right) ??
        //                throw new InvalidOperationException("Visit returned a null expression");
        //            var newExpression = Expression.Assign(be.Left, right);
        //            variableExpressions.Add(newExpression);
        //            newExpressions[i] = newExpression;
        //        }
        //        else
        //        {
        //            newExpressions[i] = expression;
        //        }
        //    }

        //    Expression newBody = Expression.Block(node.Variables, newExpressions);

        //    while (replacementsFound)
        //    {


        //        foreach (var likeVariables in variableExpressions.GroupBy(expr => expr.Right.GetDebugView()))
        //        {
        //            if (likeVariables.Count() > 1)
        //            {
        //                var keep = (ParameterExpression)likeVariables.First().Left;
        //                foreach (var toReplace in likeVariables.Skip(1))
        //                {
        //                    // if they are not the same type, don't try replacing them.
        //                    if (toReplace.Left is ParameterExpression replaceParameter)
        //                    {
        //                        if (ScopeReservedVariables.Contains(replaceParameter.Name) == false)
        //                        {
        //                            var typesSame = replaceParameter.Type == keep.Type;
        //                            if (typesSame)
        //                            {
        //                                var replace = replaceParameter.Name!;
        //                                if (replacements.TryGetValue(replaceParameter, out var existingReplacement))
        //                                {
        //                                    if (existingReplacement.Name != keep.Name)
        //                                        continue; // don't attempt to replace this variable
        //                                }
        //                                else
        //                                {
        //                                    replacements.Add(replaceParameter, keep);
        //                                }
        //                            }
        //                        }
        //                        else
        //                        {
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        if (replacements.Count > 0)
        //        {
        //            newBody = new ParameterReplacer(replacements).Visit(newBody);
        //            replacements.Clear();
        //            variableExpressions.Clear();
        //            if (newBody is BlockExpression be)
        //            {
        //                variableExpressions.AddRange(be.Expressions
        //                    .OfType<BinaryExpression>()
        //                    .Where(be => be.Left is ParameterExpression));
        //            }

        //        }
        //        else
        //        {
        //            replacementsFound = false;

        //        }
        //    }
        //    return newBody;
        //}
    }
}
