/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class SimplifyExpressionsVisitor : ExpressionVisitor
    {
        private bool _atRoot = true;
        private readonly List<BinaryExpression> _assignments = new();

        [return: NotNullIfNotNull("node")]
        public override Expression? Visit(Expression? node)
        {
            if (node is null) return null;

            // We needs a different action at the "root" of the tree than at the nodes of the tree,
            // see toBlock().
            if (_atRoot)
            {
                _atRoot = false;
                var visited = doVisit(node);
                return toBlock(visited);
            }
            else
                return doVisit(node);
        }

        private Expression doVisit(Expression node)
        {
            return node switch
            {
                ConstantExpression newConstant => VisitConstant(newConstant),
                ParameterExpression parameter => VisitParameter(parameter),
                ConditionalExpression cond => VisitConditional(cond),
                _ => simplify(base.Visit(node))
            };
        }

        private Expression simplify(Expression node)
        {
            // transform complex into assignment to variable + variable
            var newLetVariable = Expression.Parameter(node.Type);
            var newAssign = Expression.Assign(newLetVariable, node);
            _assignments.Add(newAssign);

            return newLetVariable;
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            // Skip this for now: extracting lets here is possible, but would also
            // leading to loss of performance, i.e. this would turn:
            //      if(something, expensiveA(x), expensiveB(x));
            // into:
            //      let p = expensiveA(x),
            //          q = expensiveB(x),
            //      in if(something, p, q)
            // causing expensiveA and expensiveB to be run both regardless of the test.
            return node;
        }


        protected override Expression VisitConstant(ConstantExpression node)
        {
            return node;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            return node;
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            var newArguments = new List<Expression>();

            // I am keeping this a foreach, to signal that
            // the loop (specifically Visit()) has a side-effect
            // of updating the _assignments field.
            foreach (var argument in node.Arguments)
            {
                var visitedArgument = Visit(argument);
                newArguments.Add(visitedArgument);
            }

            var visitedObject = Visit(node.Object);
            return node.Update(visitedObject, newArguments);
        }

        // This visitor builds up an expression (like any other), but also has a
        // set of Assignments, that cannot be seen in isolation from the expression. Therefore,
        // if there are any assignments, we need to, here at the root, create a
        // block to include those assignments.
        private Expression toBlock(Expression node)
        {
            // If there are no assignments (unlikely, we have introduced them to split large calls
            // into simpler ones + assignments, then we can return
            // the expression immediately.
            if (!_assignments.Any()) return node;

            // Otherwise introduce a block with the assignments translated to block variables +
            // assignments.
            var blockParameters = _assignments.Select(a => a.Left).Cast<ParameterExpression>().ToArray();
            var newBody = Expression.Block(blockParameters, _assignments.Append(node));

            return newBody;
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            // Create a new visitor, since we're the new root that can hold
            // a block of assignments.
            var nestedVisitor = new SimplifyExpressionsVisitor();
            var body = nestedVisitor.Visit(node.Body);
            return node.Update(body, node.Parameters);
        }

        /// <summary>
        /// MemberInit is a special case: it's child `newExpression` cannot be
        /// rewritten to any other type than NewExpression (to put it otherwise:
        /// Expression.MemberInit only takes a NewExpression as a parameter,
        /// not an Expression). We need to prevent this from happening.
        /// </summary>
        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            return node.Update(visitNewExpression(node.NewExpression), Visit(node.Bindings, VisitMemberBinding));

            // Continue visiting the children of NewExpression, but don't rewrite it to a parameter.
            NewExpression visitNewExpression(NewExpression node) => node.Update(Visit(node.Arguments));
        }
    }
}

