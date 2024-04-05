/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using Hl7.Cql.Compiler;
using Hl7.Cql.Compiler.Expressions;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    /// <summary>
    /// This Visitor will visit all Block expressions, and moves the assignments into the
    /// nearest parent block that is at a point where that block can be legally expressed in C#,
    /// e.g. a lambda or a case body.
    ///
    /// For example:
    /// SomeLambda(x)
    /// {
    ///     let a = 1;
    ///     { let aa = 6; a + aa };
    /// }
    ///
    /// Will be turned into
    ///
    /// SomeLambda(x)
    /// {
    ///     let a = 1;
    ///     let aa = 6;
    ///     let b = a + aa; 
    ///     b;
    /// }
    ///
    /// Note that we only can do this transform with Blocks that start with a set of assignments and then have
    /// a single expression as the last expression. Also, the parameters must be unique in each block. For all
    /// blocks that we generate, both of these conditions are met. 
    /// </summary>
    internal class CollectBlocksVisitor : ExpressionVisitor
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
                var visited = base.Visit(node);
                return toBlock(visited);
            }
            else
                return base.Visit(node);
        }

        protected override Expression VisitExtension(Expression node)
        {
            return node switch
            {
                CaseWhenThenExpression cwt => VisitCaseWhenThenExpression(cwt),
                _ => base.VisitExtension(node)
            };
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
            var newBody = Expression.Block(blockParameters, [.._assignments,node]);

            return newBody;
        }

        // A body of a lambda can have its own local variables, so we create a new subvisitor
        // to collect the blocks in the lambda body, and have a new block with the assignments
        // plus the visited body.
        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            var nestedVisitor = new CollectBlocksVisitor();
            var body = nestedVisitor.Visit(node.Body);
            return node.Update(body, node.Parameters);
        }


        // Each of the cases may contain blocks, but since these are turned into
        // if/then/else constructs, each case can hold their own local variables
        // that we collect from the nested blocks, just like the body of a Lambda. So,
        // we use a nested vistor here to create a nested block.
        protected Expression VisitCaseWhenThenExpression(CaseWhenThenExpression node)
        {
            var cases = node.WhenThenCases.Select(visitCase);

            // The final else case is treated just like the when/then
            var elseVisitor = new CollectBlocksVisitor();
            var visitedElse = elseVisitor.Visit(node.ElseCase);

            return node.Update(cases.ToList().AsReadOnly(), visitedElse);

            CaseWhenThenExpression.WhenThenCase visitCase(CaseWhenThenExpression.WhenThenCase c)
            {
                var thenVisitor = new CollectBlocksVisitor();
            
                // The assignments for blocks found within the condition go into the
                // current scope. The assignments for the then (which will have its
                // own scope in C#), will be kept in a new nested block.
                return c.Update(Visit(c.When), thenVisitor.Visit(c.Then));
            }
        }
    }
}