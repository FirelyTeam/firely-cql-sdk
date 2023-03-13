using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public abstract class UnaryExpression: Expression
    {
        public Expression? operand { get; set; }
    }

    public class AbsExpression : UnaryExpression { }
    
    public class CalculateAgeExpression: UnaryExpression 
    { 
        public string? precision { get; set; }
    }
    public class CeilingExpression : UnaryExpression { }

    public class DateFromExpression : UnaryExpression { }
    public class DescendentsExpression : UnaryExpression { }

    public class DistinctExpression : UnaryExpression { }
    public class EndExpression : UnaryExpression { }
    public class ExistsExpression : UnaryExpression { }
    public class ExpandValueSetExpression: UnaryExpression { }
    public class ExpExpression : UnaryExpression { }

    public class FlattenExpression : UnaryExpression { }
    public class FloorExpression : UnaryExpression { }

    public class IsFalseExpression : UnaryExpression { }
    public class IsTrueExpression : UnaryExpression { }


    public class LengthExpression : UnaryExpression { }
    public class LnExpression : UnaryExpression { }
    public class LowerExpression : UnaryExpression { }

    public class IsNullExpression : UnaryExpression { }

    public class NegateExpression : UnaryExpression { }
    public class NotExpression : UnaryExpression { }
    public class PointFromExpression : UnaryExpression { }

    public class PrecisionExpression : UnaryExpression { }
    public class PredecessorExpression : UnaryExpression { }
    public class StartExpression : UnaryExpression { }
    public class SingletonFromExpression : UnaryExpression { }
    public class SuccessorExpression : UnaryExpression { }
    public class ToBooleanExpression : UnaryExpression { }

    public class ToConceptExpression : UnaryExpression { }
    public class ToDecimalExpression : UnaryExpression { }
    public class ToDateExpression : UnaryExpression { }
    public class ToDateTimeExpression : UnaryExpression { }
    public class ToIntegerExpression : UnaryExpression { }
    public class ToLongExpression : UnaryExpression { }
    public class ToListExpression : UnaryExpression { }
    public class ToQuantityExpression : UnaryExpression { }
    public class ToStringExpression : UnaryExpression { }
    public class ToTimeExpression : UnaryExpression { }
    public class TruncateExpression : UnaryExpression { }
    public class UpperExpression : UnaryExpression { }

    public class WidthExpression : UnaryExpression { }


}
