﻿using Hl7.Cql.Abstractions;
using System.Linq.Expressions;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilder
    {
        private Expression IntervalExpression(Elm.Interval ie)
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
            Expression[] parameters = new[] { low, high, lowClosed, highClosed };
            var call = _operatorBinding.Bind(CqlOperator.Interval, parameters);
            return call;
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

            Expression[] parameters = new[] { numExprTranslated, denomExprTranslated };
            return _operatorBinding.Bind(CqlOperator.Ratio, parameters);
        }

        private Expression Quantity(Elm.Quantity quantityExpression)
        {
            Expression[] parameters = new[] { Expression.Constant(quantityExpression.value, typeof(decimal?)), Expression.Constant(quantityExpression.unit, typeof(string)), Expression.Constant("http://unitsofmeasure.org", typeof(string)) };
            return _operatorBinding.Bind(CqlOperator.Quantity, parameters);
        }
    }
}
