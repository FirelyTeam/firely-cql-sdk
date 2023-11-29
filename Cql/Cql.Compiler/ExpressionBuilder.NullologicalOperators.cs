#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System;
using System.Linq;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression Coalesce(elm.Coalesce ce, ExpressionBuilderContext ctx)
        {
            var operands = ce.operand!
                .Select(op => TranslateExpression(op, ctx))
                .ToArray();
            if (operands.Length == 1 && IsOrImplementsIEnumerableOfT(operands[0].Type))
            {
                var call = OperatorBinding.Bind(CqlOperator.Coalesce, ctx.CqlContextParameter, operands[0]);
                return call;
            }
            var type = TypeManager.TypeFor(ce, ctx, false);
            if (type == null)
            {
                var distinctTypes = operands
                    .Select(op => op.Type)
                    .Distinct()
                    .ToArray();
                if (distinctTypes.Length != 1)
                    throw new InvalidOperationException($"Coalesce can only be performed on same-typed operands");
                else
                    type = distinctTypes[0];
            }
            if (type.IsValueType && !IsNullable(type))
                throw new NotSupportedException("Coalesce on value types is not defined.");
            else
            {
                if (operands.Length == 1)
                    return operands[0];
                else
                {
                    var op1 = ChangeType(operands[0], type, ctx);
                    var op2 = ChangeType(operands[1], type, ctx);
                    var coalesce = Expression.Coalesce(op1, op2);
                    for (int i = 2; i < operands.Length; i++)
                    {
                        var opi = ChangeType(operands[i], type, ctx);
                        coalesce = Expression.Coalesce(coalesce, opi);
                    }
                    return coalesce;
                }
            }
        }

        protected Expression IsNull(elm.IsNull isn, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(isn.operand!, ctx);
            if (operand.Type.IsValueType && IsNullable(operand.Type) == false)
                return Expression.Constant(false, typeof(bool?));
            else
            {
                var compare = Expression.Equal(operand, Expression.Constant(null));
                var asNullableBool = Expression.Convert(compare, typeof(bool?));
                return asNullableBool;
            }
        }

        protected Expression? IsFalse(elm.IsFalse e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.IsFalse, e, ctx);


        protected Expression? IsTrue(elm.IsTrue e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.IsTrue, e, ctx);


    }
}
