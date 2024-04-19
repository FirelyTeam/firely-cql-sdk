using Hl7.Cql.Abstractions;
using Expression = System.Linq.Expressions.Expression;

namespace Hl7.Cql.Compiler.Builders;

partial class ExpressionBuilderContext
{
    private Expression IntervalExpression(Elm.Interval ie)
    {
        var lowClosed = ie.lowClosedExpression != null
                            ? Translate(ie.lowClosedExpression)
                            : Expression.Constant(((bool?)ie.lowClosed), typeof(bool?));
        lowClosed = ChangeType(lowClosed, typeof(bool?));
        var low = Translate(ie.low!);

        var highClosed = ie.highClosedExpression != null
                             ? Translate(ie.highClosedExpression)
                             : Expression.Constant(((bool?)ie.highClosed), typeof(bool?));
        highClosed = ChangeType(highClosed, typeof(bool?));
        var high = Translate(ie.high!);

        return BindCqlOperator(CqlOperator.Interval, null, low, high, lowClosed, highClosed);
    }
}