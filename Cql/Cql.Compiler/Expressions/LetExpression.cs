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
