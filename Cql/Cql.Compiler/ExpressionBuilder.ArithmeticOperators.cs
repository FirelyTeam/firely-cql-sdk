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
        private const string Int32MaxPlusOneAsString = "2147483648";

        private Expression NegateLiteral(Negate e, Literal literal)
        {
            // handle things like -2147483648 which gets translated to Negate(2147483648)
            // since int.MaxValue is 2147483647, we have to handle this specially
            var literalType = TypeFor(literal);
            if (literalType == typeof(int?) && literal.value == Int32MaxPlusOneAsString)
            {
                return Expression.Constant(int.MinValue);
            }

            if (literalType == typeof(long?) && literal.value == long.MinValue.ToString(CultureInfo.InvariantCulture))
            {
                return Expression.Constant(long.MinValue);
            }

            return UnaryOperator(CqlOperator.Negate, e);
        }
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member