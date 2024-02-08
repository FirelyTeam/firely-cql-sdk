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

        private Expression Abs(elm.Abs e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Abs, e, ctx);

        private Expression Add(elm.Add e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Add, e, ctx);

        private Expression? Ceiling(elm.Ceiling e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Ceiling, e, ctx);

        private Expression Divide(elm.Divide e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Divide, e, ctx);

        private Expression? Floor(elm.Floor e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Floor, e, ctx);

        private Expression? Exp(elm.Exp e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Exp, e, ctx);

        private Expression? HighBoundary(elm.HighBoundary e, ExpressionBuilderContext ctx) =>
             BinaryOperator(CqlOperator.HighBoundary, e, ctx);

        private Expression? Log(elm.Log e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Log, e, ctx);

        private Expression? LowBoundary(elm.LowBoundary e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.LowBoundary, e, ctx);

        private Expression? Ln(elm.Ln e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Ln, e, ctx);

        private Expression MaxValue(elm.MaxValue max, ExpressionBuilderContext ctx)
        {

            var type = TypeResolver.ResolveType(max.valueType!.Name);
            var call = OperatorBinding.Bind(CqlOperator.MaximumValue,
                ctx.RuntimeContextParameter,
                Expression.Constant(type, typeof(Type)));
            return call;
        }
        private Expression MinValue(elm.MinValue min, ExpressionBuilderContext ctx)
        {
            var type = TypeResolver.ResolveType(min.valueType!.Name);
            var call = OperatorBinding.Bind(CqlOperator.MinimumValue,
                ctx.RuntimeContextParameter,
                Expression.Constant(type, typeof(Type)));
            return call;
        }
        private Expression? Modulo(elm.Modulo e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Modulo, e, ctx);

        private Expression? Multiply(elm.Multiply e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Multiply, e, ctx);

        private Expression Negate(elm.Negate e, ExpressionBuilderContext ctx)
        {
            // handle things like -2147483648 which gets translated to Negate(2147483648)
            // since int.MaxValue is 2147483647, we have to handle this specially
            if (e.operand is elm.Literal literal)
            {
                var literalType = TypeManager.TypeFor(literal, ctx);
                if (literalType == typeof(int?) && literal.value == "2147483648")
                {
                    return Expression.Constant(int.MinValue);
                }
                else if (literalType == typeof(long?) && literal.value == long.MinValue.ToString(CultureInfo.InvariantCulture))
                {
                    return Expression.Constant(long.MinValue);
                }
            }
            return UnaryOperator(CqlOperator.Negate, e, ctx);
        }

        private Expression? Precision(elm.Precision e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Precision, e, ctx);

        private Expression? Predecessor(elm.Predecessor e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Predecessor, e, ctx);

        private Expression? Power(elm.Power e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Pow, e, ctx);

        private Expression? Round(elm.Round e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            Expression? precision;
            if (e.precision != null)
                precision = TranslateExpression(e.precision!, ctx);
            else precision = Expression.Constant(null, typeof(int?));
            var call = OperatorBinding.Bind(CqlOperator.Round, ctx.RuntimeContextParameter, operand, precision);
            return call;
        }

        private Expression Subtract(elm.Subtract e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Subtract, e, ctx);
        private Expression? Successor(elm.Successor e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Successor, e, ctx);

        private Expression? Truncate(elm.Truncate e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Truncate, e, ctx);

        private Expression? TruncatedDivide(elm.TruncatedDivide e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.TruncatedDivide, e, ctx);
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member