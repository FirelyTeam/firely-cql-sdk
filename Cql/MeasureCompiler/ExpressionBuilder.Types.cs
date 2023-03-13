using Ncqa.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using elm = Ncqa.Elm.Expressions;

namespace Ncqa.Cql.MeasureCompiler
{
    public partial class ExpressionBuilder
    {
        private Expression IntervalExpression(elm.IntervalExpression ie, ExpressionBuilderContext ctx)
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
            var call = Operators.Bind(CqlOperator.Interval, ctx.RuntimeContextParameter, low, high, lowClosed, highClosed);
            return call;
        }


        protected Expression Ratio(elm.RatioExpression re, ExpressionBuilderContext ctx)
        {
            var numExpr = new elm.QuantityExpression();
            numExpr.value = re.numerator!.value;
            numExpr.unit = re.numerator!.unit;

            var denomExpr = new elm.QuantityExpression();
            denomExpr.value = re.denominator!.value;
            denomExpr.unit = re.denominator!.unit;

            var numExprTranslated = TranslateExpression(numExpr, ctx);
            var denomExprTranslated = TranslateExpression(numExpr, ctx);

            return Operators.Bind(CqlOperator.Ratio, ctx.RuntimeContextParameter, numExprTranslated, denomExprTranslated);
        }

        private Expression Quantity(elm.QuantityExpression quantityExpression, ExpressionBuilderContext ctx) =>
            Operators.Bind(CqlOperator.Quantity, ctx.RuntimeContextParameter,
                Expression.Constant(quantityExpression.value, typeof(decimal?)),
                Expression.Constant(quantityExpression.unit, typeof(string)),
                Expression.Constant("http://unitsofmeasure.org", typeof(string)));
    }
}
