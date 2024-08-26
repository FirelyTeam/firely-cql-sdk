/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler.Expressions
{
    internal class ElmAsExpression(Expression expression, Type asType, bool strict) : Expression
    {
        public override bool CanReduce => true;
        public override ExpressionType NodeType => ExpressionType.Extension;
        public Expression Expression { get; } = expression;
        public Type AsType { get; } = asType;
        public bool Strict { get; } = strict;

        public override Type Type => AsType;
        public override Expression Reduce()
        {
            if (Expression is ConstantExpression { Value: null })
                return Constant(null, AsType);
            else
                return Strict ?
                           Convert(Expression, AsType)
                           : TypeAs(Expression, AsType);
        }
        protected override Expression VisitChildren(ExpressionVisitor visitor) =>
            Update(visitor.Visit(Expression));

        public Expression Update(Expression expression) =>
            expression != Expression
                ? new ElmAsExpression(expression, AsType, Strict)
                : this;
    }
}
