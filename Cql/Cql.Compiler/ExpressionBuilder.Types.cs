using Hl7.Cql.Abstractions;
using Expression = System.Linq.Expressions.Expression;

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
    }
}
