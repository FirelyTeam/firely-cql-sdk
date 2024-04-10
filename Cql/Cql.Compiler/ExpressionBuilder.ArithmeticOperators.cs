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
using System.Globalization;
using Hl7.Cql.Elm;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        protected Expression MaxValue(Elm.MaxValue max)
        {
            var type = _typeManager.Resolver.ResolveType(max.valueType!.Name);
            Expression[] parameters = new[] { Expression.Constant(type, typeof(Type)) };
            var call = _operatorBinding.Bind(CqlOperator.MaximumValue, parameters);
            return call;
        }
        protected Expression MinValue(Elm.MinValue min)
        {
            var type = _typeManager.Resolver.ResolveType(min.valueType!.Name);
            Expression[] parameters = new[] { Expression.Constant(type, typeof(Type)) };
            var call = _operatorBinding.Bind(CqlOperator.MinimumValue, parameters);
            return call;
        }

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

        protected Expression? Round(Elm.Round e)
        {
            var operand = TranslateExpression(e.operand!);
            Expression? precision;
            if (e.precision != null)
                precision = TranslateExpression(e.precision!);
            else precision = Expression.Constant(null, typeof(int?));
            Expression[] parameters = new[] { operand, precision };
            var call = _operatorBinding.Bind(CqlOperator.Round, parameters);
            return call;
        }
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member