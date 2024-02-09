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
using Hl7.Cql.Compiler.Infrastructure;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        private Expression Coalesce(elm.Coalesce ce, ExpressionBuilderContext ctx)
        {
            var operands = ce.operand!
                .Select(op => TranslateExpression(op, ctx))
                .ToArray();
            if (operands.Length == 1 && IsOrImplementsIEnumerableOfT(operands[0].Type))
            {
                var call = OperatorBinding.Bind(CqlOperator.Coalesce, ctx.RuntimeContextParameter, operands[0]);
                return call;
            }
            var distinctOperandTypes = operands
                .Select(op => op.Type)
                .Distinct()
                .ToArray();
            if (distinctOperandTypes.Length != 1)
                throw new InvalidOperationException("All operand types should match when using Coalesce");
            var type = operands[0].Type;
            if (type.IsValueType && !ReflectionUtility.IsNullable(type))
                throw new NotSupportedException("Coalesce on value types is not defined.");
            else
            {
                if (operands.Length == 1)
                    return operands[0];
                else
                {

                    var coalesce = Expression.Coalesce(operands[0], operands[1]);
                    for (int i = 2; i < operands.Length; i++)
                    {
                        coalesce = Expression.Coalesce(coalesce, operands[i]);
                    }
                    return coalesce;
                }
            }
        }

        private Expression IsNull(elm.IsNull isn, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(isn.operand!, ctx);
            if (operand.Type.IsValueType && ReflectionUtility.IsNullable(operand.Type) == false)
                return Expression.Constant(false, typeof(bool?));
            else
            {
                var compare = Expression.Equal(operand, Expression.Constant(null));
                var asNullableBool = Expression.Convert(compare, typeof(bool?));
                return asNullableBool;
            }
        }

        private Expression? IsFalse(elm.IsFalse e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.IsFalse, e, ctx);


        private Expression? IsTrue(elm.IsTrue e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.IsTrue, e, ctx);


    }
}
