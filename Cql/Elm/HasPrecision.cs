/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm
{

    internal interface IHasPrecision
    {
        DateTimePrecision precision { get; set; }
        bool precisionSpecified { get; set; }
    }
    internal interface IHasPrecisionExpression
    {
        Expression precision { get; set; }
    }
    internal interface UnaryWithPrecision : IHasPrecision, IGetPrecision
    {
        Expression operand { get; }
    }
    internal interface NaryWithPrecision: IHasPrecision, IGetPrecision
    {
        Expression[] operand { get; }
    }
    partial class After : NaryWithPrecision { }
    partial class Before : NaryWithPrecision { }
    partial class CalculateAge : UnaryWithPrecision { }
    partial class CalculateAgeAt : NaryWithPrecision { }
    partial class Contains : NaryWithPrecision { }
    partial class DateTimeComponentFrom : UnaryWithPrecision { }
    partial class DifferenceBetween : NaryWithPrecision { }
    partial class DurationBetween : NaryWithPrecision { }
    partial class Ends : NaryWithPrecision { }
    partial class In : NaryWithPrecision { }
    partial class IncludedIn: NaryWithPrecision { }
    partial class Includes : NaryWithPrecision { }
    partial class Meets : NaryWithPrecision { }
    partial class MeetsAfter : NaryWithPrecision { }
    partial class MeetsBefore : NaryWithPrecision { }
    partial class Overlaps : NaryWithPrecision { }
    partial class OverlapsAfter : NaryWithPrecision { }
    partial class OverlapsBefore : NaryWithPrecision { }
    partial class ProperContains : NaryWithPrecision { }
    partial class ProperIn : NaryWithPrecision { }
    partial class ProperIncludedIn : NaryWithPrecision { }
    partial class ProperIncludes : NaryWithPrecision { }
    partial class SameAs : NaryWithPrecision { }
    partial class SameOrBefore : NaryWithPrecision { }
    partial class SameOrAfter : NaryWithPrecision { }
    partial class Starts : NaryWithPrecision { }
    partial class  Round: IHasPrecisionExpression {}



}
