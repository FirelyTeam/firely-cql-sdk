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
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression Coalesce(Elm.Coalesce ce)
        {
            var operands = ce.operand!
                .SelectToArray(op => TranslateExpression(op));
            if (operands.Length == 1 && _typeResolver.IsListType(operands[0].Type))
                return _operatorsBinder.BindToMethod(CqlOperator.Coalesce, operands[0]);

            var distinctOperandTypes = operands
                .Select(op => op.Type)
                .Distinct()
                .ToArray();
            if (distinctOperandTypes.Length != 1)
                throw this.NewExpressionBuildingException("All operand types should match when using Coalesce");

            var type = operands[0].Type;
            if (type.IsValueType && !type.IsNullable(out _))
                throw new NotSupportedException("Coalesce on value types is not defined.");

            if (operands.Length == 1)
                return operands[0];

            var coalesce = Expression.Coalesce(operands[0], operands[1]);
            for (int i = 2; i < operands.Length; i++)
            {
                coalesce = Expression.Coalesce(coalesce, operands[i]);
            }
            return coalesce;
        }

        protected Expression IsNull(Elm.IsNull isn)
        {
            var operand = TranslateExpression(isn.operand!);
            if (operand.Type.IsValueType && operand.Type.IsNullable(out _) == false)
                return Expression.Constant(false, typeof(bool?));

            var compare = Expression.Equal(operand, Expression.Constant(null));
            var asNullableBool = compare.ExprConvert<bool?>();
            return asNullableBool;
        }
    }
}
