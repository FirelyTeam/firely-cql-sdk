/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Expressions
{
    public abstract class AggregateExpression : Expression
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
