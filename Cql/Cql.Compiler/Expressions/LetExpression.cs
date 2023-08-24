/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// Represents an ML-style "let" expression, i.e. a expression with a set of variables.
    /// An example would be:
    ///     let x = 4,
    ///         y = 5,
    ///     in x + y*2;
    /// 
    /// This expression is used in our system to represent the rewrite from a deeply nested single 
    /// expression into a simpler one, e.g. where a function call `(x+6).SomeFunc(y+6, "long string", subfunc(x))`
    /// would be converted to:
    ///     let a = x+6,
    ///         b = y+6,
    ///         c = "long string",
    ///         d = subfunc(x)
    ///     in a.SomeFunc(b,c,d)
    ///     
    /// Note that the result of this expression is still an expression (which is the single expression
    /// after the 'in'), and the variables are "fresh" and not supposed to be mutated, they should be
    /// considered read-only "definitions" rather than variables.
    /// 
    /// The LetExpression reduces to a block that scopes the variables in the lets, turns the lets
    /// into assignments and then returns the "in" expression as a result (=last expression in block).
    /// </summary>
    public class LetExpression : Expression
    {
        public LetExpression(IEnumerable<BinaryExpression> letStatements, Expression expression)
        {
            if (!letStatements.All(ls => ls.Left is ParameterExpression && ls.NodeType == ExpressionType.Assign))
                throw new ArgumentException("All let statements should be simple assignments with a ParameterExpression as lvalue.", nameof(letStatements));

            LetStatements = letStatements.ToList();
            Expression = expression;
        }

        public IReadOnlyCollection<BinaryExpression> LetStatements { get; }
        public Expression Expression { get; }

        public override bool CanReduce => true;
        public override ExpressionType NodeType => ExpressionType.Extension;

        public override Expression Reduce() =>
            LetStatements.Any()
                ? Block(
                    variables: LetStatements.Select(ls => (ParameterExpression)ls.Left),
                    expressions: LetStatements.Append(Expression))
                : Expression;

        protected override Expression VisitChildren(ExpressionVisitor visitor)
        {
            // Visit only the expression value of the assignment, and update the assignment if necessary.
            var letStatements = LetStatements.Select(visitor.Visit).Cast<BinaryExpression>().ToList();

            var expression = visitor.Visit(Expression);

            return Update(letStatements, expression);
        }

        public override Type Type => Expression.Type;

        public LetExpression Update(IEnumerable<BinaryExpression> letStatements, Expression expression)
        {
            if (Enumerable.SequenceEqual(letStatements, LetStatements) && expression == Expression)
                return this;
            else
                return new LetExpression(letStatements, expression);
        }

    }
}
