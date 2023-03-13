using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public abstract class BinaryExpressionWithStringPrecision : BinaryExpression
    {
        public string? precision { get; set; }
    }

    public class AfterExpression : BinaryExpressionWithStringPrecision { }
    public class BeforeExpression : BinaryExpressionWithStringPrecision { }

    public class CalculateAgeAtExpression : BinaryExpressionWithStringPrecision { }
    public class ContainsExpression : BinaryExpressionWithStringPrecision { }
    public class DifferenceBetweenExpression : BinaryExpressionWithStringPrecision { }
    public class DurationBetweenExpression : BinaryExpressionWithStringPrecision { }
    /// <summary>
    /// In CQL, this is used for the "during" operator, e.g. "P.onset during E.period"
    /// </summary>
    public class InExpression : BinaryExpressionWithStringPrecision { }
    public class IncludesExpression : BinaryExpressionWithStringPrecision { }
    public class IncludedInExpression : BinaryExpressionWithStringPrecision { }

    public class MeetsExpression: BinaryExpressionWithStringPrecision { }
    public class MeetsBeforeExpression : BinaryExpressionWithStringPrecision { }
    public class MeetsAfterExpression : BinaryExpressionWithStringPrecision { }
    public class OverlapsExpression : BinaryExpressionWithStringPrecision { }
    public class OverlapsBeforeExpression : BinaryExpressionWithStringPrecision { }
    public class OverlapsAfterExpression : BinaryExpressionWithStringPrecision { }

    /// <summary>
    /// Properly includes
    /// </summary>
    /// <remarks>
    /// Misnamed.  For example:
    ///   { @T15:59:59, @T20:59:59.999, @T20:59:49.999 } properly includes @T15:59:59 = true
    /// </remarks>
    public class ProperContainsExpression : BinaryExpressionWithStringPrecision { }
    /// <summary>
    /// Properly included in (interval in interval)
    /// </summary>
    public class ProperIncludedInExpression : BinaryExpressionWithStringPrecision { }

    /// <summary>
    /// Interval properly includes interval
    /// </summary>
    /// <remarks>
    ///  Interval[null as Integer, null as Integer]properly includes Interval[1, 10]= false
    /// </remarks>
    public class ProperIncludesExpression : BinaryExpressionWithStringPrecision { }

    /// <summary>
    /// Properly included in (element in interval)
    /// </summary>
    public class ProperInExpression : BinaryExpressionWithStringPrecision { }


    public class SameAsExpression : BinaryExpressionWithStringPrecision { }

    public class SameOrBeforeExpression : BinaryExpressionWithStringPrecision { }
    public class SameOrAfterExpression : BinaryExpressionWithStringPrecision { }


    public class StartsExpression : BinaryExpressionWithStringPrecision { }
    public class EndsExpression : BinaryExpressionWithStringPrecision { }

}
