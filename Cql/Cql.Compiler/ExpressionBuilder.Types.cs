using Hl7.Cql.Abstractions;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ContextualExpressionBuilder
    {
        private Expression IntervalExpression(elm.Interval ie)
        {
            var lowClosed = ie.lowClosedExpression != null
                ? TranslateExpression(ie.lowClosedExpression)
                : Expression.Constant(ie.lowClosed, typeof(bool?));
            var highClosed = ie.highClosedExpression != null
                ? TranslateExpression(ie.highClosedExpression)
                : Expression.Constant(ie.highClosed, typeof(bool?));
            lowClosed = ChangeType(lowClosed, typeof(bool?));
            highClosed = ChangeType(highClosed, typeof(bool?));
            var low = TranslateExpression(ie.low!);
            var high = TranslateExpression(ie.high!);
            var call = OperatorBinding.Bind(CqlOperator.Interval, RuntimeContextParameter, low, high, lowClosed, highClosed);
            return call;
        }


        private Expression Ratio(elm.Ratio re)
        {
            var numExpr = new elm.Quantity();
            numExpr.value = re.numerator!.value;
            numExpr.unit = re.numerator!.unit;

            var denomExpr = new elm.Quantity();
            denomExpr.value = re.denominator!.value;
            denomExpr.unit = re.denominator!.unit;

            var numExprTranslated = TranslateExpression(numExpr);
            var denomExprTranslated = TranslateExpression(numExpr);

            return OperatorBinding.Bind(CqlOperator.Ratio, RuntimeContextParameter, numExprTranslated, denomExprTranslated);
        }

        private Expression Quantity(elm.Quantity quantityExpression) =>
            OperatorBinding.Bind(CqlOperator.Quantity, RuntimeContextParameter,
                Expression.Constant(quantityExpression.value, typeof(decimal?)),
                Expression.Constant(quantityExpression.unit, typeof(string)),
                Expression.Constant("http://unitsofmeasure.org", typeof(string)));
    }
}
