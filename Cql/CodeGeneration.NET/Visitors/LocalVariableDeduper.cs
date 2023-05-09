using AgileObjects.ReadableExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Ncqa.Cql.CodeGeneration.NET.Visitors
{
    internal class LocalVariableDeduper : ExpressionVisitor
    {
        public LocalVariableDeduper(IEnumerable<string> scopeReservedVariables)
        {
            ScopeReservedVariables = scopeReservedVariables;
        }

        public IEnumerable<string> ScopeReservedVariables { get; }

        public override Expression Visit(Expression node)
        {
            switch (node.NodeType)
            {
                case ExpressionType.Block:
                    return base.Visit(node);
                default:
                    return node;
            }
        }

        protected override Expression VisitBlock(BlockExpression node)
        {
            var replacements = new Dictionary<string, ParameterExpression>();
            var replacementsFound = true;

            //var variableExpressions = node.Expressions
            //    .OfType<BinaryExpression>()
            //    .Where(be => be.Left is ParameterExpression)
            //    .ToArray();
            var newExpressions = new Expression[node.Expressions.Count];
            var variableExpressions = new List<BinaryExpression>();
            for (int i = 0; i < node.Expressions.Count; i++)
            {
                var expression = node.Expressions[i];
                if (expression is BinaryExpression be && be.Left is ParameterExpression)
                {
                    var right = Visit(be.Right);
                    var newExpression = Expression.Assign(be.Left, right);
                    variableExpressions.Add(newExpression);
                    newExpressions[i] = newExpression;
                }
                else
                {
                    newExpressions[i] = expression;
                }
            }

            Expression newBody = Expression.Block(node.Variables, newExpressions);

            while (replacementsFound)
            {
                foreach (var likeVariables in variableExpressions.GroupBy(expr => expr.Right.ToReadableString()))
                {
                    if (likeVariables.Count() > 1)
                    {
                        var keep = (ParameterExpression)likeVariables.First().Left;
                        foreach (var toReplace in likeVariables.Skip(1))
                        {
                            // if they are not the same type, don't try replacing them.
                            if (toReplace.Left is ParameterExpression replaceParameter)
                            {
                                if (ScopeReservedVariables.Contains(replaceParameter.Name) == false)
                                {
                                    var typesSame = replaceParameter.Type == keep.Type;
                                    if (typesSame)
                                    {
                                        var replace = replaceParameter.Name;
                                        if (replacements.TryGetValue(replace, out var existingReplacement))
                                        {
                                            if (existingReplacement.Name != keep.Name)
                                                continue; // don't attempt to replace this variable
                                        }
                                        else
                                        {
                                            if (replace == "p")
                                            {
                                            }
                                            replacements.Add(replace, keep);
                                        }
                                    }
                                }
                                else
                                {
                                }
                            }
                        }
                    }
                }
                if (replacements.Count > 0)
                {
                    newBody = new ParameterReplacer(replacements).Visit(newBody);
                    replacements.Clear();
                    variableExpressions.Clear();
                    if (newBody is BlockExpression be)
                    {
                        variableExpressions.AddRange(be.Expressions
                            .OfType<BinaryExpression>()
                            .Where(be => be.Left is ParameterExpression));
                    }

                }
                else
                {
                    replacementsFound = false;

                }
            }
            return newBody;
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            if (node is LambdaExpression lambda)
            {
                var newLambdaBody = Visit(lambda.Body);
                if (newLambdaBody is BlockExpression block && block.Variables?.Count == 0)
                {
                }
                var newLambda = Expression.Lambda(newLambdaBody, lambda.Parameters);
                return newLambda;
            }
            return base.VisitLambda(node);
        }
    }
}
