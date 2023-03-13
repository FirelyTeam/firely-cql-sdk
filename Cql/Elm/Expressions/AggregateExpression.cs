using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public abstract class AggregateExpression: Expression
    {
        public Expression? source { get; set; }
    }

    public class AllTrueExpression : AggregateExpression { }
    public class AnyTrueExpression : AggregateExpression { }
    public class AvgExpression : AggregateExpression { }
    public class CountExpression : AggregateExpression { }
    public class GeometricMeanExpression : AggregateExpression { }
    // These are technically categorized as List expressions in the CQL source, but they match the
    // aggregate exception JSON pattern (e.g., uses 'source' instead of 'operand')
    public class FirstExpression : AggregateExpression { }
    public class LastExpression : AggregateExpression { }

    public class MaxExpression : AggregateExpression { }
    public class MedianExpression : AggregateExpression { }
    public class MinExpression : AggregateExpression { }
    public class ModeExpression : AggregateExpression { }
    public class PopulationStdDevExpression : AggregateExpression { }
    public class PopulationVarianceExpression : AggregateExpression { }
    public class ProductExpression : AggregateExpression { }
    public class StdDevExpression : AggregateExpression { }
    public class SumExpression : AggregateExpression { }
    public class TailExpression : AggregateExpression { }

    public class VarianceExpression : AggregateExpression { }



}
