using System;
using System.Globalization;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm.Expressions;

namespace Hl7.Cql.Compiler
{
    public partial class ExpressionBuilder
    {

        protected Expression Abs(elm.AbsExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Abs, e, ctx);

        protected Expression Add(elm.AddExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Add, e, ctx);

        protected Expression? Ceiling(elm.CeilingExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Ceiling, e, ctx);

        protected Expression Divide(elm.DivideExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Divide, e, ctx);

        protected Expression? Floor(elm.FloorExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Floor, e, ctx);

        protected Expression? Exp(elm.ExpExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Exp, e, ctx);

        protected Expression? HighBoundary(elm.HighBoundaryExpression e, ExpressionBuilderContext ctx) =>
             BinaryOperator(CqlOperator.HighBoundary, e, ctx);

        protected Expression? Log(elm.LogExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Log, e, ctx);

        protected Expression? LowBoundary(elm.LowBoundaryExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.LowBoundary, e, ctx);

        protected Expression? Ln(elm.LnExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Ln, e, ctx);

        protected Expression Maximum(elm.MaximumExpression max, ExpressionBuilderContext ctx)
        {
            var type = TypeResolver.ResolveType(max.valueType!);
            var call = Operators.Bind(CqlOperator.MaximumValue,
                ctx.RuntimeContextParameter,
                Expression.Constant(type, typeof(Type)));
            return call;
        }
        protected Expression Minimum(elm.MinimumExpression min, ExpressionBuilderContext ctx)
        {
            var type = TypeResolver.ResolveType(min.valueType!);
            var call = Operators.Bind(CqlOperator.MinimumValue,
                ctx.RuntimeContextParameter,
                Expression.Constant(type, typeof(Type)));
            return call;
        }
        protected Expression? Modulo(elm.ModuloExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Modulo, e, ctx);

        protected Expression? Multiply(elm.MultiplyExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Multiply, e, ctx);

        protected Expression Negate(elm.NegateExpression e, ExpressionBuilderContext ctx)
        {
            // handle things like -2147483648 which gets translated to Negate(2147483648)
            // since int.MaxValue is 2147483647, we have to handle this specially
            if (e.operand is elm.LiteralExpression literal)
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

        protected Expression? Precision(elm.PrecisionExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Precision, e, ctx);

        protected Expression? Predecessor(elm.PredecessorExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Predecessor, e, ctx);

        protected Expression? Power(elm.PowerExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Pow, e, ctx);

        protected Expression? Round(elm.RoundExpression e, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(e.operand!, ctx);
            Expression? precision;
            if (e.precision != null)
                precision = TranslateExpression(e.precision!, ctx);
            else precision = Expression.Constant(null, typeof(int?));
            var call = Operators.Bind(CqlOperator.Round, ctx.RuntimeContextParameter, operand, precision);
            return call;
        }

        protected Expression Subtract(elm.SubtractExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.Subtract, e, ctx);
        protected Expression? Successor(elm.SuccessorExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Successor, e, ctx);

        protected Expression? Truncate(elm.TruncateExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.Truncate, e, ctx);

        protected Expression? TruncatedDivide(elm.TruncatedDivideExpression e, ExpressionBuilderContext ctx) =>
            BinaryOperator(CqlOperator.TruncatedDivide, e, ctx);
    }
}
