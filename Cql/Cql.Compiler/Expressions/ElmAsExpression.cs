using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Compiler.Expressions
{
    internal class ElmAsExpression: Expression
    {
        public ElmAsExpression(Expression expression, Type result)
        {
            Expression = expression;
            AsType = result;
        }

        public override bool CanReduce => true;
        public override ExpressionType NodeType => ExpressionType.Extension;
        public Expression Expression { get; }
        public Type AsType { get; }
        public override Type Type => AsType;
        public override Expression Reduce()
        {
            if (AsType!.IsValueType)
                return Convert(Expression, AsType);
            else if (Expression is ConstantExpression ce && ce.Value == null)
                return Constant(null, AsType);
            else
                return TypeAs(Expression, AsType);
        }
        protected override Expression VisitChildren(ExpressionVisitor visitor) =>
            new ElmAsExpression(visitor.Visit(Expression), Type);
     
    }
}
