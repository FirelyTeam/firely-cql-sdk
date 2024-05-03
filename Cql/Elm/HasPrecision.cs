using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Elm
{
    internal interface IHasPrecision
    {
        DateTimePrecision precision { get; set; }
        bool precisionSpecified { get; set; }
    }
    partial class After : IHasPrecision { }
    partial class Before : IHasPrecision { }
    partial class CalculateAge : IHasPrecision { }
    partial class CalculateAgeAt : IHasPrecision { }
    partial class Contains : IHasPrecision { }
    partial class DateTimeComponentFrom : IHasPrecision { }
    partial class DifferenceBetween : IHasPrecision { }
    partial class DurationBetween : IHasPrecision { }
    partial class Ends : IHasPrecision { }
    partial class In : IHasPrecision { }
    partial class IncludedIn: IHasPrecision { }
    partial class Includes : IHasPrecision { }
    partial class Meets : IHasPrecision { }
    partial class MeetsAfter : IHasPrecision { }
    partial class MeetsBefore : IHasPrecision { }
    partial class Overlaps : IHasPrecision { }
    partial class OverlapsAfter : IHasPrecision { }
    partial class OverlapsBefore : IHasPrecision { }
    partial class ProperContains : IHasPrecision { }
    partial class ProperIn : IHasPrecision { }
    partial class ProperIncludedIn : IHasPrecision { }
    partial class ProperIncludes : IHasPrecision { }
    partial class SameAs : IHasPrecision { }
    partial class SameOrBefore : IHasPrecision { }
    partial class SameOrAfter : IHasPrecision { }
    partial class Starts : IHasPrecision { }

    internal interface IHasPrecisionExpression
    {
        Expression precision { get; set; }
    }

    partial class  Round: IHasPrecisionExpression {}



}
