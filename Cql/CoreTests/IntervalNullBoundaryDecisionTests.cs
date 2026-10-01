/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace CoreTests
{
    /// <summary>
    /// A boundary without a value is decided by what it stands for: a closed one is the minimum or maximum of the
    /// point type, an open one is unknown but ranges over the values its interval permits. A relationship operator
    /// answers definitely when one boundary comparison settles it, and is unknown only when the answer depends on
    /// an unknown boundary. "Note that open null boundaries of intervals are treaterd [sic] as uncertainties for the
    /// purposes of interval computation." (CQL 1.5.3 Errata 2, Language Semantics, section "Interval Operators");
    /// "For closed interval boundaries, if the interval boundary is null, the result of the boundary comparison is
    /// considered true." (Appendix B - CQL Reference, section "In").
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    public class IntervalNullBoundaryDecisionTests
    {
        private static readonly CqlContext Context = FhirCqlContext.WithDataSource();

        private static CqlInterval<int?> Interval(int? low, int? high, bool lowClosed, bool highClosed) =>
            new(low, high, lowClosed, highClosed);

        [TestMethod]
        public void In_OpenNullBoundary_TheOtherBoundaryStillSettlesTheResult()
        {
            // 5 in Interval(null, 3]: above the high, wherever the low is.
            Assert.AreEqual(false, Context.Operators.In(5, Interval(null, 3, false, true), null));
            // 5 in Interval(null, 7]: below the high, and the low is unknown.
            Assert.IsNull(Context.Operators.In(5, Interval(null, 7, false, true), null));
            // 0 in Interval[1, null): below the low, wherever the high is.
            Assert.AreEqual(false, Context.Operators.In(0, Interval(1, null, true, false), null));
            Assert.IsNull(Context.Operators.In(2, Interval(1, null, true, false), null));
        }

        [TestMethod]
        public void In_ClosedNullBoundary_IsSatisfied()
        {
            Assert.AreEqual(true, Context.Operators.In(5, Interval(null, 7, true, true), null));
            Assert.AreEqual(true, Context.Operators.In(int.MinValue, Interval(null, 7, true, true), null));
            Assert.AreEqual(true, Context.Operators.In(int.MaxValue, Interval(1, null, true, true), null));
        }

        [TestMethod]
        public void PointAfterOrBeforeInterval_OpenNullBoundary_TheOtherBoundaryStillSettlesTheResult()
        {
            // 0 after Interval[1, null): the point is below the low, so it is not after the interval's end.
            Assert.AreEqual(false, Context.Operators.After(0, Interval(1, null, true, false), null));
            Assert.IsNull(Context.Operators.After(5, Interval(1, null, true, false), null));
            // 9 before Interval(null, 3]: the point is above the high, so it is not before the interval's start.
            Assert.AreEqual(false, Context.Operators.Before(9, Interval(null, 3, false, true), null));
            Assert.IsNull(Context.Operators.Before(1, Interval(null, 3, false, true), null));
        }

        [TestMethod]
        public void Includes_OpenNullBoundary_TheOtherBoundaryStillSettlesTheResult()
        {
            // Interval[1, 10] includes Interval(null, 20]: the smaller ends after the larger, wherever it starts.
            Assert.AreEqual(false, Context.Operators.IntervalIncludesInterval(Interval(1, 10, true, true), Interval(null, 20, false, true), null));
            Assert.IsNull(Context.Operators.IntervalIncludesInterval(Interval(1, 10, true, true), Interval(null, 5, false, true), null));
            // Interval(null, 5] includes Interval[1, 3]: the larger's unknown low may be above 1.
            Assert.IsNull(Context.Operators.IntervalIncludesInterval(Interval(null, 5, false, true), Interval(1, 3, true, true), null));
            Assert.AreEqual(false, Context.Operators.IntervalIncludesInterval(Interval(null, 5, false, true), Interval(1, 9, true, true), null));
        }

        [TestMethod]
        public void Includes_UncertainOnOneSide_DefinitelyOutsideOnTheOther_IsFalse()
        {
            // The low boundaries agree at second precision (uncertain), but the smaller interval ends months after
            // the larger one, so it is not included.
            var larger = new CqlInterval<CqlDateTime?>(new CqlDateTime(2017, 9, 1, 0, 0, 0, null, null, null), new CqlDateTime(2017, 9, 1, 0, 0, 0, null, null, null), true, true);
            var smaller = new CqlInterval<CqlDateTime?>(new CqlDateTime(2017, 9, 1, 0, 0, 0, 999, null, null), new CqlDateTime(2017, 12, 30, 23, 59, 59, 999, null, null), true, true);

            Assert.AreEqual(false, Context.Operators.IntervalIncludesInterval(larger, smaller, null));
            // The other way round the high comparison is decided and the low one is not.
            Assert.IsNull(Context.Operators.IntervalIncludesInterval(smaller, larger, null));
        }

        [TestMethod]
        public void Includes_ClosedNullBoundary_IsTheExtreme()
        {
            Assert.AreEqual(true, Context.Operators.IntervalIncludesInterval(Interval(null, 10, true, true), Interval(int.MinValue, 3, true, true), null));
            Assert.AreEqual(true, Context.Operators.IntervalIncludesInterval(Interval(1, null, true, true), Interval(3, int.MaxValue, true, true), null));
            Assert.AreEqual(false, Context.Operators.IntervalIncludesInterval(Interval(1, 10, true, true), Interval(3, null, true, true), null));
        }

        [TestMethod]
        public void Meets_BothHighsOrBothLowsWithoutAValue_IsDecidedByWhatTheyStandFor()
        {
            // Two intervals that both run to the maximum overlap; they do not meet.
            Assert.AreEqual(false, Context.Operators.Meets(Interval(1, null, true, true), Interval(5, null, true, true), null));
            Assert.AreEqual(false, Context.Operators.MeetsAfter(Interval(5, null, true, true), Interval(1, null, true, true), null));
            // Two intervals that both start at the minimum overlap; they do not meet.
            Assert.AreEqual(false, Context.Operators.Meets(Interval(null, 3, true, true), Interval(null, 9, true, true), null));
            Assert.AreEqual(false, Context.Operators.MeetsBefore(Interval(null, 3, true, true), Interval(null, 9, true, true), null));
            // Two unknown highs: whether the first ends just before the second starts is unknown.
            Assert.IsNull(Context.Operators.Meets(Interval(1, null, true, false), Interval(5, null, true, false), null));
            Assert.IsNull(Context.Operators.MeetsBefore(Interval(1, null, true, false), Interval(5, null, true, false), null));
        }

        [TestMethod]
        public void Meets_UnknownStartThatCanOnlyBeTheMinimum_HasNothingBeforeIt()
        {
            // Interval(null, int.MinValue] can only start at the minimum, which has no predecessor, so no interval
            // ends just before it: the answer is false, not unknown.
            var startsAtTheMinimum = Interval(null, int.MinValue, false, true);
            Assert.AreEqual(false, Context.Operators.MeetsBefore(Interval(0, 0, true, true), startsAtTheMinimum, null));
            Assert.AreEqual(false, Context.Operators.MeetsAfter(startsAtTheMinimum, Interval(0, 0, true, true), null));
            Assert.AreEqual(false, Context.Operators.Meets(Interval(0, 0, true, true), startsAtTheMinimum, null));
            // An unknown start that can be anything from the minimum up to 5 has predecessors up to 4.
            Assert.IsNull(Context.Operators.MeetsBefore(Interval(0, 2, true, true), Interval(null, 5, false, true), null));
            Assert.AreEqual(false, Context.Operators.MeetsBefore(Interval(0, 7, true, true), Interval(null, 5, false, true), null));
        }

        [TestMethod]
        public void Meets_UnknownEndWhoseEveryValueMeetsTheStart_IsTrue()
        {
            // Interval[int.MaxValue - 1, null) ends at int.MaxValue - 1 or int.MaxValue; either is the start of
            // Interval[int.MaxValue, int.MaxValue] or the value just before it, so the intervals meet whatever the end is.
            var endsNearTheMaximum = Interval(int.MaxValue - 1, null, true, false);
            var atTheMaximum = Interval(int.MaxValue, int.MaxValue, true, true);
            Assert.AreEqual(true, Context.Operators.MeetsBefore(endsNearTheMaximum, atTheMaximum, null));
            Assert.AreEqual(true, Context.Operators.Meets(endsNearTheMaximum, atTheMaximum, null));
            Assert.AreEqual(true, Context.Operators.MeetsAfter(atTheMaximum, endsNearTheMaximum, null));
            // An unknown end that may also fall short of the start, or run past it, leaves the answer unknown.
            Assert.IsNull(Context.Operators.MeetsBefore(Interval(1, null, true, false), Interval(3, 5, true, true), null));
            Assert.IsNull(Context.Operators.MeetsBefore(Interval(int.MaxValue - 2, null, true, false), atTheMaximum, null));
        }

        [TestMethod]
        public void SameAs_IsDecidedFromTheBoundaries()
        {
            // The same range, written with open and closed boundaries.
            Assert.AreEqual(true, Context.Operators.SameAs(Interval(1, 5, true, true), Interval(0, 6, false, false), null));
            // A closed null low is the minimum.
            Assert.AreEqual(true, Context.Operators.SameAs(Interval(null, 5, true, true), Interval(int.MinValue, 5, true, true), null));
            // An unknown high beside a known one: unknown when it may coincide, false when it cannot.
            Assert.IsNull(Context.Operators.SameAs(Interval(1, 5, true, true), Interval(1, null, true, false), null));
            Assert.AreEqual(false, Context.Operators.SameAs(Interval(1, 5, true, true), Interval(7, null, true, false), null));
            Assert.AreEqual(false, Context.Operators.SameAs(Interval(1, 5, true, true), Interval(1, 6, true, true), null));
        }

        [TestMethod]
        public void SameAsAndIncludes_NonNullablePointForm_IsNormalisedLikeTheNullableOne()
        {
            // An open boundary with a value is a step inward, for value-type points as for nullable ones.
            Assert.AreEqual(true, Context.Operators.SameAs(new CqlInterval<int>(1, 5, true, true), new CqlInterval<int>(0, 6, false, false), null));
            Assert.AreEqual(false, Context.Operators.SameAs(new CqlInterval<int>(1, 5, true, true), new CqlInterval<int>(0, 6, true, false), null));
            Assert.AreEqual(true, Context.Operators.SameAs(new CqlInterval<long>(1L, 5L, true, true), new CqlInterval<long>(0L, 6L, false, false), null));
            Assert.AreEqual(true, Context.Operators.SameAs(new CqlInterval<decimal>(1.0m, 5.0m, true, true), new CqlInterval<decimal>(0.99999999m, 5.00000001m, false, false), null));
            Assert.AreEqual(true, Context.Operators.IntervalIncludesInterval(new CqlInterval<int>(1, 5, true, true), new CqlInterval<int>(0, 6, false, false), null));
            Assert.AreEqual(false, Context.Operators.IntervalIncludesInterval(new CqlInterval<int>(1, 5, true, true), new CqlInterval<int>(0, 6, true, false), null));
            Assert.AreEqual(true, Context.Operators.IntervalIncludesInterval(new CqlInterval<long>(1L, 5L, true, true), new CqlInterval<long>(0L, 6L, false, false), null));
            Assert.AreEqual(true, Context.Operators.IntervalIncludesInterval(new CqlInterval<decimal>(1.0m, 5.0m, true, true), new CqlInterval<decimal>(0.99999999m, 5.00000001m, false, false), null));
        }

        [TestMethod]
        public void Meets_ClosedNullBoundaryOnOneSide_IsDecidedAgainstTheOther()
        {
            // Interval[null, 4] meets Interval[5, null]: 4 is the predecessor of 5.
            Assert.AreEqual(true, Context.Operators.Meets(Interval(null, 4, true, true), Interval(5, null, true, true), null));
            Assert.AreEqual(true, Context.Operators.MeetsBefore(Interval(null, 4, true, true), Interval(5, null, true, true), null));
            Assert.AreEqual(true, Context.Operators.MeetsAfter(Interval(5, null, true, true), Interval(null, 4, true, true), null));
            Assert.AreEqual(false, Context.Operators.Meets(Interval(null, 3, true, true), Interval(5, null, true, true), null));
        }

        [TestMethod]
        public void ProperlyIncludesPoint_OpenNullBoundary_TheOtherBoundaryStillSettlesTheResult()
        {
            // Interval(null, 3] properly includes 5: above the high, wherever the low is.
            Assert.AreEqual(false, Context.Operators.IntervalProperlyIncludesElement(Interval(null, 3, false, true), 5));
            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(5, Interval(null, 3, false, true)));
            // 5 properly included in Interval(null, 7]: below the high, and the low is unknown.
            Assert.IsNull(Context.Operators.ElementProperlyIncludedInInterval(5, Interval(null, 7, false, true)));
            // 0 properly included in Interval[1, null): below the low, wherever the high is.
            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(0, Interval(1, null, true, false)));
            Assert.IsNull(Context.Operators.ElementProperlyIncludedInInterval(2, Interval(1, null, true, false)));
            // The known endpoint is never properly included, wherever the other boundary is.
            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(1, Interval(1, null, true, false)));
            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(3, Interval(null, 3, false, true)));
        }

        [TestMethod]
        public void ProperlyIncludesPoint_ClosedNullBoundary_IsTheExtreme()
        {
            Assert.AreEqual(true, Context.Operators.ElementProperlyIncludedInInterval(5, Interval(null, 7, true, true)));
            Assert.AreEqual(true, Context.Operators.ElementProperlyIncludedInInterval(int.MinValue + 1, Interval(null, 7, true, true)));
            Assert.AreEqual(true, Context.Operators.IntervalProperlyIncludesElement(Interval(1, null, true, true), int.MaxValue - 1));
            // The extreme itself is the interval's endpoint.
            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(int.MinValue, Interval(null, 7, true, true)));
            Assert.AreEqual(false, Context.Operators.IntervalProperlyIncludesElement(Interval(1, null, true, true), int.MaxValue));
        }

        [TestMethod]
        public void ProperlyIncludesPoint_NonNullablePointForm_IsNormalisedLikeTheNullableOne()
        {
            // Interval(0, 6) runs from 1 to 5: 1 is its endpoint and 3 is strictly inside.
            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(1, new CqlInterval<int>(0, 6, false, false)));
            Assert.AreEqual(true, Context.Operators.ElementProperlyIncludedInInterval(3, new CqlInterval<int>(0, 6, false, false)));
            Assert.AreEqual(true, Context.Operators.ElementProperlyIncludedInInterval(1, new CqlInterval<int>(0, 6, true, false)));
            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(1L, new CqlInterval<long>(0L, 6L, false, false)));
            Assert.AreEqual(true, Context.Operators.ElementProperlyIncludedInInterval(3L, new CqlInterval<long>(0L, 6L, false, false)));
            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(1.0m, new CqlInterval<decimal>(0.99999999m, 6.0m, false, false)));
            Assert.AreEqual(true, Context.Operators.ElementProperlyIncludedInInterval(3.0m, new CqlInterval<decimal>(0.99999999m, 6.0m, false, false)));
        }

        [TestMethod]
        public void ProperlyIncludesDatePoint_UnknownBoundaryThatMayMakeItAUnitInterval_IsUnknown()
        {
            var day = new CqlDate(2026, 1, 5);
            var later = new CqlDate(2026, 1, 9);

            // Interval(null, @2026-01-05] properly includes @2026-01-05: the interval may contain that day alone.
            Assert.IsNull(Context.Operators.ElementProperlyIncludedInInterval(day, new CqlInterval<CqlDate>(null, day, false, true), "day"));
            Assert.IsNull(Context.Operators.IntervalProperlyIncludesElement(new CqlInterval<CqlDate>(null, day, false, true), day, "day"));
            // Interval[null, @2026-01-05] starts at the minimum date, so it is wider than the point.
            Assert.AreEqual(true, Context.Operators.ElementProperlyIncludedInInterval(day, new CqlInterval<CqlDate>(null, day, true, true), "day"));
            // @2026-01-09 is above the high, wherever the low is.
            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(later, new CqlInterval<CqlDate>(null, day, false, true), "day"));
            // Interval(null, @2026-01-09] properly includes @2026-01-05: unknown whether the day is in it at all.
            Assert.IsNull(Context.Operators.ElementProperlyIncludedInInterval(day, new CqlInterval<CqlDate>(null, later, false, true), "day"));

            var noon = new CqlDateTime(2026, 1, 5, 12, 0, 0, 0, 0, 0);
            Assert.IsNull(Context.Operators.ElementProperlyIncludedInInterval(noon, new CqlInterval<CqlDateTime>(noon, null, true, false), "millisecond"));
            Assert.AreEqual(true, Context.Operators.ElementProperlyIncludedInInterval(noon, new CqlInterval<CqlDateTime>(noon, null, true, true), "millisecond"));
            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(new CqlDateTime(2026, 1, 5, 11, 0, 0, 0, 0, 0), new CqlInterval<CqlDateTime>(noon, null, true, false), "millisecond"));
        }

        [TestMethod]
        public void ProperlyIncludesTimePoint_OpenNullBoundary_TheOtherBoundaryStillSettlesTheResult()
        {
            var noon = new CqlTime(12, 0, 0, 0, null, null);

            // Interval(null, @T12:00:00.000] properly includes @T12:00:00.000: the high endpoint is excluded, wherever the low is.
            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(noon, new CqlInterval<CqlTime>(null, noon, false, true), "millisecond"));
            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(new CqlTime(13, 0, 0, 0, null, null), new CqlInterval<CqlTime>(null, noon, false, true), "millisecond"));
            Assert.IsNull(Context.Operators.ElementProperlyIncludedInInterval(new CqlTime(11, 0, 0, 0, null, null), new CqlInterval<CqlTime>(null, noon, false, true), "millisecond"));
            Assert.AreEqual(true, Context.Operators.ElementProperlyIncludedInInterval(new CqlTime(11, 0, 0, 0, null, null), new CqlInterval<CqlTime>(null, noon, true, true), "millisecond"));
        }
    }
}
