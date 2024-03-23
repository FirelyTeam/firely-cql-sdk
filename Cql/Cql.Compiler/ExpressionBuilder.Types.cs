using Hl7.Cql.Abstractions;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilderContext
    {
        private Expression IntervalExpression(elm.Interval ie)
        {
            ExpressionBuilderContext ctx = this;
            var lowClosed = ie.lowClosedExpression != null
                ? ctx.TranslateExpression(ie.lowClosedExpression)
                : Expression.Constant(ie.lowClosed, typeof(bool?));
            var highClosed = ie.highClosedExpression != null
                ? ctx.TranslateExpression(ie.highClosedExpression)
                : Expression.Constant(ie.highClosed, typeof(bool?));
            lowClosed = ChangeType(lowClosed, typeof(bool?));
            highClosed = ChangeType(highClosed, typeof(bool?));
            var low = ctx.TranslateExpression(ie.low!);
            var high = ctx.TranslateExpression(ie.high!);
            var call = ctx.OperatorBinding.Bind(CqlOperator.Interval, ctx.RuntimeContextParameter, low, high, lowClosed, highClosed);
            return call;
        }


        private Expression Ratio(elm.Ratio re)
        {
            ExpressionBuilderContext ctx = this;
            var numExpr = new elm.Quantity();
            numExpr.value = re.numerator!.value;
            numExpr.unit = re.numerator!.unit;

            var denomExpr = new elm.Quantity();
            denomExpr.value = re.denominator!.value;
            denomExpr.unit = re.denominator!.unit;

            var numExprTranslated = ctx.TranslateExpression(numExpr);
            var denomExprTranslated = ctx.TranslateExpression(numExpr);

            return ctx.OperatorBinding.Bind(CqlOperator.Ratio, ctx.RuntimeContextParameter, numExprTranslated, denomExprTranslated);
        }

        private Expression Quantity(elm.Quantity quantityExpression) =>
            OperatorBinding.Bind(CqlOperator.Quantity, RuntimeContextParameter,
                Expression.Constant(quantityExpression.value, typeof(decimal?)),
                Expression.Constant(quantityExpression.unit, typeof(string)),
                Expression.Constant("http://unitsofmeasure.org", typeof(string)));
    }
}
