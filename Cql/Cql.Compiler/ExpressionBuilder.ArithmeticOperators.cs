#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System.Globalization;
using Hl7.Cql.Elm;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        private Expression NegateLiteral(Negate e, Literal literal)
        {
            // handle things like -2147483648 which gets translated to Negate(2147483648)
            // since int.MaxValue is 2147483647, we have to handle this specially
            var literalType = TypeFor(literal);
            if (literalType == typeof(int?) && literal.value == "2147483648")
            {
                return Expression.Constant(int.MinValue);
            }

            if (literalType == typeof(long?) && literal.value == long.MinValue.ToString(CultureInfo.InvariantCulture))
            {
                return Expression.Constant(long.MinValue);
            }

            return UnaryOperator(CqlOperator.Negate, e);
        }

        protected Expression? Round(Round e)
        {
            var operand = TranslateExpression(e.operand!);
            Expression? precision;
            if (e.precision != null)
                precision = TranslateExpression(e.precision!);
            else precision = CqlExpressions.Null_ConstantExpression<int?>();
            return _operatorsBinder.BindToMethod(CqlOperator.Round, operand, precision);
        }
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member