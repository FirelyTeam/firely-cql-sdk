/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Hl7.Cql.Compiler
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

    /// <summary>
    /// This custom expression represents the null conditional expression in CQL (which looks like a?.b in C#).
    /// </summary>
    internal class NullConditionalMemberExpression : Expression
    {
        public MemberExpression MemberExpression { get; private set; }
        private readonly Type resultType;

        public NullConditionalMemberExpression(MemberExpression expression)
        {
            if (expression.Expression is null)
                throw new ArgumentException("Expression is not applicable to static member access");

            MemberExpression = expression;
            var isNullableType = !MemberExpression.Type.IsValueType || Nullable.GetUnderlyingType(MemberExpression.Type) is not null;
            resultType = isNullableType ? MemberExpression.Type : typeof(Nullable<>).MakeGenericType(MemberExpression.Type);
        }

        public NullConditionalMemberExpression(Expression expression, MemberInfo member) :
            this(MakeMemberAccess(expression, member))
        {
            // Nothing	
        }

        public override bool CanReduce => true;

        public override ExpressionType NodeType => ExpressionType.Extension;

        public override Expression Reduce()
        {
            var objectVariable = Variable(MemberExpression.Expression!.Type);
            Expression notNull(Expression expression) => NotEqual(expression, Constant(null, MemberExpression.Expression.Type));

            Expression nullableMemberExpression = (MemberExpression.Type != resultType) ?
                    Convert(MemberExpression, resultType) : MemberExpression;
            var block = Block(new[] { objectVariable },
                Assign(objectVariable, MemberExpression.Expression!),
                Condition(notNull(objectVariable), nullableMemberExpression, Default(resultType)));

            return block;
        }

        protected override Expression VisitChildren(ExpressionVisitor visitor)
        {
            var visited = visitor.Visit(MemberExpression.Expression);
            return Update(visited);
        }

        public override Type Type => resultType;

        public NullConditionalMemberExpression Update(Expression? expression)
        {
            if (expression is null) return this;

            if (expression != MemberExpression.Expression)
                return new NullConditionalMemberExpression(MemberExpression.Update(expression));
            else
                return this;
        }
    }
}
