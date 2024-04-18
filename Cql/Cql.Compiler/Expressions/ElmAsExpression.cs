using System;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler.Expressions
{
    internal class ElmAsExpression : Expression
    {
        public ElmAsExpression(Expression expression, Type asType)
        {
            Expression = expression;
            AsType = asType;
        }

        public override bool CanReduce => true;
        public override ExpressionType NodeType => ExpressionType.Extension;
        public Expression Expression { get; }
        public Type AsType { get; }
        public override Type Type => AsType;
        public override Expression Reduce()
        {
            if (AsType!.IsValueType)
                return Expression.ConvertExpression(AsType);
            if (Expression is ConstantExpression { Value: null })
                return Constant(null, AsType);
            return Expression.TypeAsExpression(AsType);
        }
        protected override Expression VisitChildren(ExpressionVisitor visitor) =>
            Update(visitor.Visit(Expression));

        public Expression Update(Expression expression) =>
            expression != Expression
                ? new ElmAsExpression(expression, AsType)
                : this;
    }
}
