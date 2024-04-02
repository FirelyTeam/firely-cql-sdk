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

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {

        protected Expression Abs(Elm.Abs e) =>
            UnaryOperator(CqlOperator.Abs, e);

        protected Expression Add(Elm.Add e) =>
            BinaryOperator(CqlOperator.Add, e);

        protected Expression? Ceiling(Elm.Ceiling e) =>
            UnaryOperator(CqlOperator.Ceiling, e);

        protected Expression Divide(Elm.Divide e) =>
            BinaryOperator(CqlOperator.Divide, e);

        protected Expression? Floor(Elm.Floor e) =>
            UnaryOperator(CqlOperator.Floor, e);

        protected Expression? Exp(Elm.Exp e) =>
            UnaryOperator(CqlOperator.Exp, e);

        protected Expression? HighBoundary(Elm.HighBoundary e) =>
             BinaryOperator(CqlOperator.HighBoundary, e);

        protected Expression? Log(Elm.Log e) =>
            BinaryOperator(CqlOperator.Log, e);

        protected Expression? LowBoundary(Elm.LowBoundary e) =>
            BinaryOperator(CqlOperator.LowBoundary, e);

        protected Expression? Ln(Elm.Ln e) =>
            UnaryOperator(CqlOperator.Ln, e);

        protected Expression MaxValue(Elm.MaxValue max)
        {
            var type = _typeManager.Resolver.ResolveType(max.valueType!.Name);
            var call = _operatorBinding.Bind(CqlOperator.MaximumValue,
                LibraryDefinitionsBuilder.ContextParameter,
                Expression.Constant(type, typeof(Type)));
            return call;
        }
        protected Expression MinValue(Elm.MinValue min)
        {
            var type = _typeManager.Resolver.ResolveType(min.valueType!.Name);
            var call = _operatorBinding.Bind(CqlOperator.MinimumValue,
                LibraryDefinitionsBuilder.ContextParameter,
                Expression.Constant(type, typeof(Type)));
            return call;
        }
        protected Expression? Modulo(Elm.Modulo e) =>
            BinaryOperator(CqlOperator.Modulo, e);

        protected Expression? Multiply(Elm.Multiply e) =>
            BinaryOperator(CqlOperator.Multiply, e);

        protected Expression Negate(Elm.Negate e)
        {
            // handle things like -2147483648 which gets translated to Negate(2147483648)
            // since int.MaxValue is 2147483647, we have to handle this specially
            if (e.operand is Elm.Literal literal)
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

        protected Expression? Precision(Elm.Precision e) =>
            UnaryOperator(CqlOperator.Precision, e);

        protected Expression? Predecessor(Elm.Predecessor e) =>
            UnaryOperator(CqlOperator.Predecessor, e);

        protected Expression? Power(Elm.Power e) =>
            BinaryOperator(CqlOperator.Pow, e);

        protected Expression? Round(Elm.Round e)
        {
            var operand = TranslateExpression(e.operand!);
            Expression? precision;
            if (e.precision != null)
                precision = TranslateExpression(e.precision!);
            else precision = Expression.Constant(null, typeof(int?));
            var call = _operatorBinding.Bind(CqlOperator.Round, LibraryDefinitionsBuilder.ContextParameter, operand, precision);
            return call;
        }

        protected Expression Subtract(Elm.Subtract e) =>
            BinaryOperator(CqlOperator.Subtract, e);
        protected Expression? Successor(Elm.Successor e) =>
            UnaryOperator(CqlOperator.Successor, e);

        protected Expression? Truncate(Elm.Truncate e) =>
            UnaryOperator(CqlOperator.Truncate, e);

        protected Expression? TruncatedDivide(Elm.TruncatedDivide e) =>
            BinaryOperator(CqlOperator.TruncatedDivide, e);
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member