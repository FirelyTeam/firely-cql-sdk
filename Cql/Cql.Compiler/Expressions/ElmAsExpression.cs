using System;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler.Expressions
{
    internal class ElmAsExpression : Expression
    {
        public ElmAsExpression(Expression expression, Type asType, bool strict)
        {
            Expression = expression;
            AsType = asType;
            Strict = strict;
        }

        public override bool CanReduce => true;
        public override ExpressionType NodeType => ExpressionType.Extension;
        public Expression Expression { get; }
        public Type AsType { get; }
        public bool Strict { get; }

        public override Type Type => AsType;
        public override Expression Reduce()
        {
            if (Expression is ConstantExpression ce && ce.Value == null)
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
