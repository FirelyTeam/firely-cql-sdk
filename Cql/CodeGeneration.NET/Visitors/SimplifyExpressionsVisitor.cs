/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using Hl7.Cql.Primitives;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    /// <summary>
    /// This Visitor will (in most cases) create a new variable for a nested expression, 
    /// and assign the visited node's expression to that variable, thus unwinding the deeply nested
    /// structure of Linq.Expression.
    /// e.g. exprA(exprB(4)) will be turned into
    ///     var b = exprB(4)
    ///     var a = exprA(b)
    ///     return a;
    /// </summary>
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
            // This visit will, by default, call `simplyfy()` on every
            // type of node, which unwinds the nesting. Note that, even if you
            // override a specific visitor, simplify() will still be called on it.
            // If you do want to avoid a node to be simplified at all, you need
            // to include a special case in the switch below.
            return node switch
            {
                ConstantExpression newConstant => VisitConstant(newConstant),
                ParameterExpression parameter => VisitParameter(parameter),
                ConditionalExpression cond => VisitConditional(cond),
                UnaryExpression unary => VisitUnary(unary),
                BinaryExpression binary => VisitBinary(binary),
                NewExpression newe => VisitNew(newe),
                CaseWhenThenExpression cwt => VisitCaseWhenThenExpression(cwt),
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
            return node;
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            if (node.NodeType is ExpressionType.Convert or ExpressionType.TypeAs)
            {
                return base.VisitUnary(node);
            }
            else
                return simplify(base.VisitUnary(node));

        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            return node switch
            {
                // Simply comparing two values is something you can do by eye, we don't need to simplify that.
                { NodeType: ExpressionType.Equal or ExpressionType.NotEqual } => base.VisitBinary(node),

                // The interim value of an assignment is clear, we don't need to simplify
                { NodeType: ExpressionType.Assign } => base.VisitBinary(node),

                _ => simplify(base.VisitBinary(node))
            };
        }

        protected override Expression VisitNew(NewExpression node)
        {
            if (node.Type == typeof(CqlValueSet))
                return node;
            else
                return simplify(node);
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

        protected Expression VisitCaseWhenThenExpression(CaseWhenThenExpression node)
        {
            CaseWhenThenExpression.WhenThenCase visitCase(CaseWhenThenExpression.WhenThenCase c)
            {
                var thenVisitor = new SimplifyExpressionsVisitor();
                return c.Update(c.When, thenVisitor.Visit(c.Then));
            }

            var cases = node.WhenThenCases.Select(visitCase);
            var elseVisitor = new SimplifyExpressionsVisitor();
            var visitedElse = elseVisitor.Visit(node.ElseCase);

            var newCTW = node.Update(cases.ToList().AsReadOnly(), visitedElse);

            var func = Expression.Lambda(Expression.Block(newCTW));
            var assign = simplify(func);

            return Expression.Invoke(assign);
        }
    }
}

