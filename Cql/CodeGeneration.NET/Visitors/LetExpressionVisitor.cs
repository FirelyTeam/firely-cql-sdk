/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    /// <summary>
    /// Linq.Expressions allow blocks-as-expressions everywhere, whereas C# only allows them in certain places,
    /// like function bodies and if statement blocks. (i.e. you cannot do `var x = { return 4+5; }`.
    /// 
    /// Our code generator does not generate Block expressions, but the custom LetExpression requires the
    /// generated C# to assign variables, which means we need a block (scope) to declare and assign them in the
    /// generated C#, where these blocks will be split from a single "expression" into a list of assignments +
    /// the central expression of the LetExpression. 
    /// 
    /// This visitor travels a tree and pulls these LetExpressions "up", combining all child LetExpressions into
    /// a newer, bigger let let expression that contains all assignments from the children. We keep on pulling
    /// the expressions up, until we have reached the root of the tree, where we generate a BlockExpression with
    /// variable assignments, normally in the Lambda body and the body of a conditional.
    /// </summary>
    internal class LetExpressionVisitor : ExpressionVisitor
    {
        public LetExpressionVisitor(VariableNameGenerator nameGenerator)
        {
            this.nameGenerator = nameGenerator;
        }

        private bool _atRoot = true;
        private readonly List<BinaryExpression> _assignments = new();
        private readonly VariableNameGenerator nameGenerator;

        public IReadOnlyCollection<BinaryExpression> Assignments => _assignments;

        [return: NotNullIfNotNull("node")]
        public override Expression? Visit(Expression? node)
        {
            if (node is null) return null;

            // We needs a different action at the "root" of the tree than at the nodes of the tree
            if (_atRoot)
            {
                _atRoot = false;
                return ToBlock(node);
            }
            else
                return base.Visit(node);

            Expression ToBlock(Expression node)
            {
                // This visitor will return an expression (like any other), but also has a
                // set of Assignments, that cannot be seen in isolation from the expression. Therefore,
                // if there are any assignments, we need to, at some point (= at the root) create a
                // block to include those assignments.
                var lastExpression = Visit(node, toParameter: false);

                // If there are no assignments (unlikely, as we have introduced the LetExpressions
                // to split large calls into simpler ones + let statements, then we can return
                // the expression immediately.
                if (!Assignments.Any()) return lastExpression;

                // Otherwise introduce a block with the lets translated to block variables +
                // assignments.
                var blockParameters = Assignments.Select(a => a.Left).Cast<ParameterExpression>().ToArray();
                var newBody = Expression.Block(blockParameters, Assignments.Append(lastExpression));

                var replacements = new Dictionary<ParameterExpression, ParameterExpression>();

                foreach (var oldParameter in newBody.Variables)
                {
                    var newName = nameGenerator.Next();
                    var newParameter = Expression.Parameter(oldParameter.Type, newName);

                    replacements.Add(oldParameter, newParameter);
                }

                var replacementVisitor = new ParameterReplacer(replacements);
                var newerBody = replacementVisitor.Visit(newBody);

                return newerBody;
            }

        }

        public Expression Visit(Expression node, bool toParameter) => node switch
        {
            LetExpression le => VisitLetExpression(le, toParameter),
            _ => base.Visit(node)
        };


        /// <summary>
        /// Replaces a LetExpression with a ParameterExpression representing the expression in the LetExpression, adding 
        /// the assignments to an outer scope.
        /// </summary>
        protected override Expression VisitExtension(Expression node) => node switch
        {
            LetExpression le => VisitLetExpression(le),
            _ => VisitExtension(node)
        };

        protected override Expression VisitBinary(BinaryExpression node) => node.NodeType switch
        {
            ExpressionType.Assign => node.Update(node.Left, node.Conversion, Visit(node.Right, toParameter: false)),
            _ => base.VisitBinary(node)
        };

        private Expression VisitLetExpression(LetExpression le, bool toParameter = true)
        {
            // Go over the lets in the LetExpression, and pull them into this visitor (the _assignments),
            // so a block higher up can emit them at the right place in the source code.
            foreach (var letStatement in le.LetStatements)
            {
                // Note, that since Visit has side-effects, we use a foreach here, not
                // an Enumerable.Select().
                var x = Visit(letStatement);
                _assignments.Add((BinaryExpression)x);
            }

            var visitedExpression = Visit(le.Expression);

            if (visitedExpression is ParameterExpression || !toParameter)
                return visitedExpression;
            else
            {
                var expressionVariable = Expression.Parameter(visitedExpression.Type);
                _assignments.Add(Expression.Assign(expressionVariable, visitedExpression));
                return expressionVariable;
            }
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            var newGenerator = nameGenerator.ForNewScope(node.Parameters);
            var nestedVisitor = new LetExpressionVisitor(newGenerator);
            var body = nestedVisitor.Visit(node.Body);
            return node.Update(body, node.Parameters);
        }

        //protected override Expression VisitConditional(ConditionalExpression node)
        //{
        //    var visitedTest = Visit(node.Test);
        //    var flattenedIfTrue = Flatten(node.IfTrue);
        //    var flattenedIfFalse = Flatten(node.IfFalse);

        //    return node.Update(visitedTest, flattenedIfTrue, flattenedIfFalse);
        //}

    }
}
