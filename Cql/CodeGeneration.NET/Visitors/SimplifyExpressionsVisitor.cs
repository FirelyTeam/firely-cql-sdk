/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
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

        public IReadOnlyCollection<BinaryExpression> Assignments => _assignments;

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
                MemberExpression member => VisitMember(member),

                // Simplify all others.
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

        protected override Expression VisitMember(MemberExpression node)
        {
            if (node.Expression is not null && node.Expression is ConstantExpression or ParameterExpression)
                return node;
            else
                return base.VisitMember(node);
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            // Turn every nested conditional except the most simple ones into a Case/when/then
            if (isSimpleConditional(node))
                return node;

            var cwt = toCWT(node);
            return Visit(cwt);

            // simple a ? b : c, with simple b and c
            bool isSimpleConditional(ConditionalExpression node)
            {
                if (node.IfFalse is ConditionalExpression) return false;

                var testVisitor = new SimplifyExpressionsVisitor();
                _ = testVisitor.Visit(node.IfTrue);
                _ = testVisitor.Visit(node.IfFalse);
                return !testVisitor.Assignments.Any();
            }
        }

        private CaseWhenThenExpression toCWT(ConditionalExpression ce)
        {
            var exprs = unwind(ce).ToList();
            var cases = exprs
                .SkipLast(1)
                .Cast<ConditionalExpression>()
                .Select(expr => new CaseWhenThenExpression.WhenThenCase(expr.Test, expr.IfTrue));
            return new CaseWhenThenExpression(cases.ToList().AsReadOnly(), exprs.Last());

            static IEnumerable<Expression> unwind(ConditionalExpression ce)
            {
                if (ce.IfFalse is ConditionalExpression nestedCe)
                    return unwind(nestedCe).Prepend(ce);
                else
                    return new[] { ce, ce.IfFalse };
            }
        }


        protected override Expression VisitUnary(UnaryExpression node)
        {
            // Don't simplify simple converts.
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

                // A null coalesce of two inspectable things is still inspectable.
                { NodeType: ExpressionType.Coalesce } => base.VisitBinary(node),

                // The interim value of an assignment is clear, we don't need to simplify
                { NodeType: ExpressionType.Assign } => base.VisitBinary(node),

                _ => simplify(base.VisitBinary(node))
            };
        }

        protected override Expression VisitNew(NewExpression node)
        {
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

        /// <summary>
        /// CaseWhenThen expressions cannot be represented in C# as an expression
        /// (well, as a switch expression, but that has its own limitations), so we need
        /// to make sure they get translated to a lambda containing the if/then/else block
        /// and then simplified to just a call to that lambda.
        /// </summary>
        protected Expression VisitCaseWhenThenExpression(CaseWhenThenExpression node)
        {
            // Each of the cases will be translated to blocks, which can hold their own
            // local variables and lexical return, just like the body of a Lambda. So,
            // we use a nested vistor here to create a nested block.
            CaseWhenThenExpression.WhenThenCase visitCase(CaseWhenThenExpression.WhenThenCase c)
            {
                var thenVisitor = new SimplifyExpressionsVisitor();
                return c.Update(c.When, thenVisitor.Visit(c.Then));
            }

            var cases = node.WhenThenCases.Select(visitCase);

            // The final else case is treated just like the when/then
            var elseVisitor = new SimplifyExpressionsVisitor();
            var visitedElse = elseVisitor.Visit(node.ElseCase);

            var newCTW = node.Update(cases.ToList().AsReadOnly(), visitedElse);

            // To make sure the if block in C# (which is NOT an expression) can
            // be used everywhere, we place the block inside its own lambda.
            // This also ensures the lexical exits work correctly.
            var func = Expression.Lambda(Expression.Block(newCTW));
            var assign = simplify(func);

            // Finally, replace the whole statement with just an invocation
            // of the lambda we just created (which *is* an expression and can be
            // used everywhere).
            return Expression.Invoke(assign);
        }
    }
}

