using Hl7.Cql.Abstractions;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        private Expression IntervalExpression(elm.Interval ie, ExpressionBuilderContext ctx)
        {
            var lowClosed = ie.lowClosedExpression != null
                ? TranslateExpression(ie.lowClosedExpression, ctx)
                : Expression.Constant(ie.lowClosed, typeof(bool?));
            var highClosed = ie.highClosedExpression != null
                ? TranslateExpression(ie.highClosedExpression, ctx)
                : Expression.Constant(ie.highClosed, typeof(bool?));
            lowClosed = ChangeType(lowClosed, typeof(bool?), ctx);
            highClosed = ChangeType(highClosed, typeof(bool?), ctx);
            var low = TranslateExpression(ie.low!, ctx);
            var high = TranslateExpression(ie.high!, ctx);
            var call = OperatorBinding.Bind(CqlOperator.Interval, ctx.RuntimeContextParameter, low, high, lowClosed, highClosed);
            return call;
        }


        private Expression Ratio(elm.Ratio re, ExpressionBuilderContext ctx)
        {
            var numExpr = new elm.Quantity();
            numExpr.value = re.numerator!.value;
            numExpr.unit = re.numerator!.unit;

            var denomExpr = new elm.Quantity();
            denomExpr.value = re.denominator!.value;
            denomExpr.unit = re.denominator!.unit;

            var numExprTranslated = TranslateExpression(numExpr, ctx);
            var denomExprTranslated = TranslateExpression(numExpr, ctx);

            return OperatorBinding.Bind(CqlOperator.Ratio, ctx.RuntimeContextParameter, numExprTranslated, denomExprTranslated);
        }

        private Expression Quantity(elm.Quantity quantityExpression, ExpressionBuilderContext ctx) =>
            OperatorBinding.Bind(CqlOperator.Quantity, ctx.RuntimeContextParameter,
                Expression.Constant(quantityExpression.value, typeof(decimal?)),
                Expression.Constant(quantityExpression.unit, typeof(string)),
                Expression.Constant("http://unitsofmeasure.org", typeof(string)));
    }
}
