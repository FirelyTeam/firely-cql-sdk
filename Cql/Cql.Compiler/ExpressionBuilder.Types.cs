using Hl7.Cql.Abstractions;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        private Expression IntervalExpression(Elm.Interval ie)
        {
            var lowClosed = ie.lowClosedExpression != null
                ? TranslateExpression(ie.lowClosedExpression)
                : Expression.Constant(((bool?)ie.lowClosed), typeof(bool?));
            lowClosed = ChangeType(lowClosed, typeof(bool?));
            var low = TranslateExpression(ie.low!);

            var highClosed = ie.highClosedExpression != null
                ? TranslateExpression(ie.highClosedExpression)
                : Expression.Constant(((bool?)ie.highClosed), typeof(bool?));
            highClosed = ChangeType(highClosed, typeof(bool?));
            var high = TranslateExpression(ie.high!);

            return BindCqlOperatorsMethod(CqlOperator.Interval, low, high, lowClosed, highClosed);
        }


        private Expression Ratio(Elm.Ratio re)
        {
            var numExpr = new Elm.Quantity();
            numExpr.value = re.numerator!.value;
            numExpr.unit = re.numerator!.unit;

            var denomExpr = new Elm.Quantity();
            denomExpr.value = re.denominator!.value;
            denomExpr.unit = re.denominator!.unit;

            var numExprTranslated = TranslateExpression(numExpr);
            var denomExprTranslated = TranslateExpression(numExpr);
            return BindCqlOperatorsMethod(CqlOperator.Ratio, numExprTranslated, denomExprTranslated);
        }
    }
}
