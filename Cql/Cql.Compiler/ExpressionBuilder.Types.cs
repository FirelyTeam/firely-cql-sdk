using Hl7.Cql.Abstractions;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
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
            var call = _operatorBinding.Bind(CqlOperator.Interval, LibraryDefinitionsBuilder.ContextParameter, low, high, lowClosed, highClosed);
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

            return _operatorBinding.Bind(CqlOperator.Ratio, LibraryDefinitionsBuilder.ContextParameter, numExprTranslated, denomExprTranslated);
        }

        private Expression Quantity(elm.Quantity quantityExpression) =>
            _operatorBinding.Bind(CqlOperator.Quantity, LibraryDefinitionsBuilder.ContextParameter,
                Expression.Constant(quantityExpression.value, typeof(decimal?)),
                Expression.Constant(quantityExpression.unit, typeof(string)),
                Expression.Constant("http://unitsofmeasure.org", typeof(string)));
    }
}
