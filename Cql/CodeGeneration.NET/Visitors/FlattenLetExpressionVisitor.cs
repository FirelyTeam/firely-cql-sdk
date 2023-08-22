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
        private FlattenLetExpressionVisitor() { }

        private readonly List<BinaryExpression> _assignments = new();
        public IReadOnlyCollection<BinaryExpression> Assignments => _assignments;

        protected override Expression VisitExtension(Expression node)
        {
            if (node is LetExpression le)
            {
                foreach (var letStatement in le.LetStatements)
                {
                    var flattenedStatement = Flatten(letStatement.Right);

                    if (flattenedStatement is LetExpression nested)
                    {
                        _assignments.AddRange(nested.LetStatements);
                        _assignments.Add(letStatement.Update(letStatement.Left, letStatement.Conversion, nested.Expression));
                    }
                    else
                    {
                        _assignments.Add(letStatement.Update(letStatement.Left, letStatement.Conversion, flattenedStatement));
                    }
                }

                var visitedExpression = Visit(le.Expression);

                var expressionVariable = Expression.Parameter(visitedExpression.Type);
                _assignments.Add(Expression.Assign(expressionVariable, visitedExpression));

                return expressionVariable;
            }
            else
            {
                return VisitExtension(node);
            }
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            var flattenedBody = FlattenAndRename(node.Body, node.Parameters);
            return node.Update(flattenedBody, node.Parameters);
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            var visitedTest = Visit(node.Test);
            var flattenedIfTrue = Flatten(node.IfTrue);
            var flattenedIfFalse = Flatten(node.IfFalse);

            return node.Update(visitedTest, flattenedIfTrue, flattenedIfFalse);
        }

        public static Expression Flatten(Expression node)
        {
            var visitor = new FlattenLetExpressionVisitor();
            var lastExpression = visitor.Visit(node);

            if (!visitor.Assignments.Any()) return lastExpression;

            // if the last expression is just a Parameter, we can
            // as well use the rvalue of the parameter as the
            // primary expression in the let expression, i.e.
            // (let x = a, y = expr(x); y;)  => { let x = a; expr(x) }
            if (lastExpression is ParameterExpression parameter)
            {
                var assignment = visitor.Assignments.Single(a => a.Left == parameter);
                var assignmentWithout = visitor.Assignments.ToList();
                assignmentWithout.Remove(assignment);
                return new LetExpression(assignmentWithout, assignment.Right);
            }
            else
            {
                return new LetExpression(visitor.Assignments, lastExpression);
            }
        }

        public static Expression FlattenAndRename(Expression expression, IEnumerable<ParameterExpression>? scopeParameters = null)
        {
            var flatExpression = Flatten(expression);

            if (flatExpression is not LetExpression le) return expression;

            var reservedNames = (scopeParameters ?? Enumerable.Empty<ParameterExpression>()).Where(p => p.Name is not null).Select(p => p.Name!);
            var nameGenerator = new VariableNameGenerator(reservedNames, "_");
            var replacements = new Dictionary<ParameterExpression, ParameterExpression>();

            foreach (var letStatement in le.LetStatements)
            {
                var newName = nameGenerator.Next();
                var oldParameter = (ParameterExpression)letStatement.Left;
                var newParameter = Expression.Parameter(oldParameter.Type, newName);

                replacements.Add(oldParameter, newParameter);
            }

            var replacementVisitor = new ParameterReplacer(replacements);
            return replacementVisitor.Visit(le);
        }
    }
}
