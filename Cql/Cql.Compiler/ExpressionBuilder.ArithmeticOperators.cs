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
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {

        protected Expression Abs(elm.Abs e) =>
            UnaryOperator(CqlOperator.Abs, e);

        protected Expression Add(elm.Add e) =>
            BinaryOperator(CqlOperator.Add, e);

        protected Expression? Ceiling(elm.Ceiling e) =>
            UnaryOperator(CqlOperator.Ceiling, e);

        protected Expression Divide(elm.Divide e) =>
            BinaryOperator(CqlOperator.Divide, e);

        protected Expression? Floor(elm.Floor e) =>
            UnaryOperator(CqlOperator.Floor, e);

        protected Expression? Exp(elm.Exp e) =>
            UnaryOperator(CqlOperator.Exp, e);

        protected Expression? HighBoundary(elm.HighBoundary e) =>
             BinaryOperator(CqlOperator.HighBoundary, e);

        protected Expression? Log(elm.Log e) =>
            BinaryOperator(CqlOperator.Log, e);

        protected Expression? LowBoundary(elm.LowBoundary e) =>
            BinaryOperator(CqlOperator.LowBoundary, e);

        protected Expression? Ln(elm.Ln e) =>
            UnaryOperator(CqlOperator.Ln, e);

        protected Expression MaxValue(elm.MaxValue max)
        {
            var type = _typeManager.Resolver.ResolveType(max.valueType!.Name);
            var call = _operatorBinding.Bind(CqlOperator.MaximumValue,
                LibraryDefinitionsBuilder.ContextParameter,
                Expression.Constant(type, typeof(Type)));
            return call;
        }
        protected Expression MinValue(elm.MinValue min)
        {
            var type = _typeManager.Resolver.ResolveType(min.valueType!.Name);
            var call = _operatorBinding.Bind(CqlOperator.MinimumValue,
                LibraryDefinitionsBuilder.ContextParameter,
                Expression.Constant(type, typeof(Type)));
            return call;
        }
        protected Expression? Modulo(elm.Modulo e) =>
            BinaryOperator(CqlOperator.Modulo, e);

        protected Expression? Multiply(elm.Multiply e) =>
            BinaryOperator(CqlOperator.Multiply, e);

        protected Expression Negate(elm.Negate e)
        {
            // handle things like -2147483648 which gets translated to Negate(2147483648)
            // since int.MaxValue is 2147483647, we have to handle this specially
            if (e.operand is elm.Literal literal)
            {
                var literalType = TypeFor(literal);
                if (literalType == typeof(int?) && literal.value == "2147483648")
                {
                    return Expression.Constant(int.MinValue);
                }
                else if (literalType == typeof(long?) && literal.value == long.MinValue.ToString(CultureInfo.InvariantCulture))
                {
                    return Expression.Constant(long.MinValue);
                }
            }
            return UnaryOperator(CqlOperator.Negate, e);
        }

        protected Expression? Precision(elm.Precision e) =>
            UnaryOperator(CqlOperator.Precision, e);

        protected Expression? Predecessor(elm.Predecessor e) =>
            UnaryOperator(CqlOperator.Predecessor, e);

        protected Expression? Power(elm.Power e) =>
            BinaryOperator(CqlOperator.Pow, e);

        protected Expression? Round(elm.Round e)
        {
            var operand = TranslateExpression(e.operand!);
            Expression? precision;
            if (e.precision != null)
                precision = TranslateExpression(e.precision!);
            else precision = Expression.Constant(null, typeof(int?));
            var call = _operatorBinding.Bind(CqlOperator.Round, LibraryDefinitionsBuilder.ContextParameter, operand, precision);
            return call;
        }

        protected Expression Subtract(elm.Subtract e) =>
            BinaryOperator(CqlOperator.Subtract, e);
        protected Expression? Successor(elm.Successor e) =>
            UnaryOperator(CqlOperator.Successor, e);

        protected Expression? Truncate(elm.Truncate e) =>
            UnaryOperator(CqlOperator.Truncate, e);

        protected Expression? TruncatedDivide(elm.TruncatedDivide e) =>
            BinaryOperator(CqlOperator.TruncatedDivide, e);
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member