/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    /// <summary>
    /// <para>This Visitor will (in most cases) create a new variable for a nested expression, 
    /// and assign the visited node's expression to that variable, thus unwinding the deeply nested
    /// structure of Linq.Expression to make it easier to debug and inspect the intermediate values.</para>
    /// <para>E.g. exprA(exprB(4)) will be turned into:</para>
    /// <code>
    ///     var b = exprB(4)
    ///     var a = exprA(b)
    ///     return a;
    /// </code>
    /// </summary>
    internal class SimplifyExpressionsVisitor : ExpressionVisitor
    {
        private readonly List<BinaryExpression> _assignments = [];
        private bool _atRoot = true;

        public IReadOnlyCollection<BinaryExpression> Assignments => _assignments;

        [return: NotNullIfNotNull("node")]
        public override Expression? Visit(Expression? node)
        {
            if (node is null) return null;

            // We needs a different action at the "root" of the tree than at the nodes of the tree,
            // see <see cref="ToBlock(Expression)"/> for more information.
            if (_atRoot)
            {
                _atRoot = false;
                var visited = DoVisit(node);
                return ToBlock(visited);
            }
            else
                return DoVisit(node);
        }

        [return: NotNullIfNotNull("node")]
        internal Expression? CollectVisit(Expression? node)
        {
            if (node is null) return null;

            return DoVisit(node);
        }

        private Expression DoVisit(Expression node)
        {
            // This visit will, by default, call `simplify()` on every
            // type of node, which unwinds the nesting. Note that, even if you
            // override a specific visitor, simplify() will still be called on it.
            // If you do want to avoid a node to be simplified at all, you need
            // to include a special case in the switch below.
            return node switch
            {
                // Pass these expressions straight through
                ConstantExpression or
                ParameterExpression or
                NewExpression or
                MemberExpression or
                ElmAsExpression or
                NullConditionalMemberExpression => base.Visit(node),

                // These expressions require special handling
                ConditionalExpression cond => VisitConditional(cond),
                UnaryExpression unary => VisitUnary(unary),
                BinaryExpression binary => VisitBinary(binary),
                CaseWhenThenExpression cwt => VisitCaseWhenThenExpression(cwt),

                // Simplify all others.
                _ => MakeLet(base.Visit(node))
            };
        }

        private ParameterExpression MakeLet(Expression node)
        {
            // transform complex expression into a variable +
            // variable assignment with the expression in the RHS.
            var newLetVariable = Expression.Parameter(node.Type);
            var newAssign = Expression.Assign(newLetVariable, node);
            _assignments.Add(newAssign);

            return newLetVariable;
        }


        protected override Expression VisitConditional(ConditionalExpression node)
        {
            // Turn every nested conditional except the most simple ones into a Case/when/then
            if (isSimpleConditional(node))
                return node;

            var cwt = ToCwt(node);
            return Visit(cwt);

            // simple a ? b : c, with simple b and c
            bool isSimpleConditional(ConditionalExpression simpleNode)
            {
                if (simpleNode.IfFalse is ConditionalExpression) return false;

                var testVisitor = new SimplifyExpressionsVisitor();
                _ = testVisitor.Visit(simpleNode.IfTrue);
                _ = testVisitor.Visit(simpleNode.IfFalse);
                return !testVisitor.Assignments.Any();
            }
        }

        private static CaseWhenThenExpression ToCwt(ConditionalExpression ce)
        {
            var exprs = flatten(ce).ToList();
            var cases = exprs
                .SkipLast(1)
                .Cast<ConditionalExpression>()
                .Select(expr => new CaseWhenThenExpression.WhenThenCase(expr.Test, expr.IfTrue));
            return new CaseWhenThenExpression(cases.ToList().AsReadOnly(), exprs.Last());

            static IEnumerable<Expression> flatten(ConditionalExpression ce)
            {
                if (ce.IfFalse is ConditionalExpression nestedCe)
                    return [ce, ..flatten(nestedCe)];
                else
                    return [ce, ce.IfFalse];
            }
        }


        protected override Expression VisitUnary(UnaryExpression node)
        {
            return node.NodeType switch
            {
                // Don't simplify simple converts.
                ExpressionType.Convert or ExpressionType.TypeAs => base.VisitUnary(node),
                
                // Don't simplify throw expressions
                ExpressionType.Throw => base.VisitUnary(node),
                _ => MakeLet(base.VisitUnary(node))
            };
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
                
                _ => MakeLet(base.VisitBinary(node))
            };
        }

        // While visiting an expression the visitor keeps track of new assignments necessary
        // to simplify the expression. When done, the last expression (the return value) and
        // the collected assignments can be combined into a block with this function. 
        internal Expression ToBlock(Expression node)
        {
            // If there are no assignments (unlikely, we have introduced them to split large calls
            // into simpler ones + assignments, then we can return
            // the expression immediately, unless it is a CaseWhenThenExpression, which really
            // needs to be wrapped in a block.
            if (!_assignments.Any())
            {
                if(node is not CaseWhenThenExpression)
                    return node;
            }

            // Otherwise introduce a block with the assignments translated to block variables +
            // assignments.
            var blockParameters = _assignments.Select(a => a.Left).Cast<ParameterExpression>().ToArray();
            var newBody = Expression.Block(blockParameters, [.._assignments, node]);

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
            NewExpression visitNewExpression(NewExpression newExpression) => newExpression.Update(Visit(newExpression.Arguments));
        }

        /// <summary>
        /// CaseWhenThen expressions cannot be represented in C# as an expression
        /// (well, as a switch expression, but that has its own limitations), so we need
        /// to make sure they get translated to a lambda containing the if/then/else block
        /// and then simplified to just a call to that lambda.
        /// </summary>
        protected Expression VisitCaseWhenThenExpression(CaseWhenThenExpression node)
        {
            // The final else case is treated just like the when/then
            var elseVisitor = new SimplifyExpressionsVisitor();
            var visitedElse = elseVisitor.Visit(node.ElseCase);

            var caseStatementBlockVisitor = new SimplifyExpressionsVisitor();
            
            var cases = node.WhenThenCases.Select(c => visitCase(c,caseStatementBlockVisitor))
                .ToList();
            var newCaseWhenThen = node.Update(cases.AsReadOnly(), visitedElse);

            // To make sure the if block in C# (which is NOT an expression) can
            // be used everywhere, we place the block inside its own lambda.
            // This also ensures the lexical exits work correctly.
            var caseStatementLambda = Expression.Lambda(caseStatementBlockVisitor.ToBlock(newCaseWhenThen)); 
            var lambdaVar = MakeLet(caseStatementLambda);
            return Expression.Invoke(lambdaVar);
            
            // Each of the cases will be translated to blocks, which can hold their own
            // local variables and lexical return, just like the body of a Lambda. So,
            // we use a nested vistor here to create a nested block.
            CaseWhenThenExpression.WhenThenCase visitCase(CaseWhenThenExpression.WhenThenCase c,
                SimplifyExpressionsVisitor whenVisitor)
            {
                // Unless the condition is simple, we need to wrap it in a lambda, so
                // we can simplify its body, and then can call the lambda to make sure
                // we evaluate the condition as late as possible (we don't want to evaluate
                // a cases before we've checked the cases before it).
                var newWhen = isSimpleWhen(c.When) ? 
                    c.When 
                    : Expression.Invoke(whenVisitor.CollectVisit(Expression.Lambda(c.When)));

                var thenVisitor = new SimplifyExpressionsVisitor();
                return c.Update(newWhen, thenVisitor.Visit(c.Then));
                
                // simple a ? b : c, with simple b and c
                bool isSimpleWhen(Expression when)
                {
                    var testVisitor = new SimplifyExpressionsVisitor();
                    _ = testVisitor.Visit(when);
                    return testVisitor.Assignments.Count <= 1;
                }
            }
        }
    }
}

