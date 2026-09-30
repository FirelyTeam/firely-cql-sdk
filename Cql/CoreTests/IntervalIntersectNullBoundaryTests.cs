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
    /// Interval intersect over null boundaries. CQL 1.5.3 Errata 2, Language Semantics, section "Interval
    /// Operators": "Note that open null boundaries of intervals are treaterd [sic] as uncertainties for the
    /// purposes of interval computation." For <c>Interval[1, 10] intersect Interval[5, null)</c>: "This
    /// results in an interval that begins at 5, and ends at some value between 5 and 10." Appendix B - CQL
    /// Reference, section "Intersect": "the operator returns the interval that defines the overlapping
    /// portion of both arguments. If the arguments do not overlap, this operator returns null." A null closed
    /// boundary is the minimum or maximum value of the point type (sections "Start" and "End": "Otherwise, the
    /// result is the minimum value of the point type of the interval."), so it takes part in the intersection
    /// like any other value. The HL7 CQL conformance suite (CqlIntervalOperatorsTest, group Intersect) expects
    /// the <c>TestIntersectNull</c>, <c>TestIntersectNull1</c> to <c>TestIntersectNull4</c> cases below.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    public class IntervalIntersectNullBoundaryTests
    {
        private static readonly CqlContext Context = FhirCqlContext.WithDataSource();

        private static CqlInterval<int?> Interval(int? low, int? high, bool lowClosed, bool highClosed) =>
            new(low, high, lowClosed, highClosed);

        // Interval[1, 10] intersect Interval[5, null)
        private static CqlInterval<int?>? ConformanceIntersection() =>
            Context.Operators.Intersect(Interval(1, 10, true, true), Interval(5, null, true, false));

        private static void AssertInterval(CqlInterval<int?>? actual, int? low, int? high, bool lowClosed, bool highClosed)
        {
            Assert.IsNotNull(actual);
            Assert.AreEqual(low, actual.low, "low");
            Assert.AreEqual(high, actual.high, "high");
            Assert.AreEqual(lowClosed, actual.lowClosed, "lowClosed");
            Assert.AreEqual(highClosed, actual.highClosed, "highClosed");
        }

        [TestMethod]
        public void Intersect_OpenNullHigh_KeepsKnownStartAndUnknownEnd()
        {
            // TestIntersectNull: Interval[1, 10] intersect Interval[5, null) = Interval[5, null)
            AssertInterval(ConformanceIntersection(), 5, null, lowClosed: true, highClosed: false);
        }

        [TestMethod]
        public void Intersect_OpenNullHigh_StartIsAtMostTen()
        {
            // TestIntersectNull1: start of (Interval[1, 10] intersect Interval[5, null)) <= 10 = true
            Assert.AreEqual(true, Context.Operators.LessOrEqual(Context.Operators.Start(ConformanceIntersection()), 10));
        }

        [TestMethod]
        public void Intersect_OpenNullHigh_StartIsAtLeastFive()
        {
            // TestIntersectNull2: start of (Interval[1, 10] intersect Interval[5, null)) >= 5 = true
            Assert.AreEqual(true, Context.Operators.GreaterOrEqual(Context.Operators.Start(ConformanceIntersection()), 5));
        }

        [TestMethod]
        public void Intersect_OpenNullHigh_StartIsNotAboveTen()
        {
            // TestIntersectNull3: start of (Interval[1, 10] intersect Interval[5, null)) > 10 = false
            Assert.AreEqual(false, Context.Operators.Greater(Context.Operators.Start(ConformanceIntersection()), 10));
        }

        [TestMethod]
        public void Intersect_OpenNullHigh_StartIsNotBelowFive()
        {
            // TestIntersectNull4: start of (Interval[1, 10] intersect Interval[5, null)) < 5 = false
            Assert.AreEqual(false, Context.Operators.Less(Context.Operators.Start(ConformanceIntersection()), 5));
        }

        [TestMethod]
        public void Intersect_OpenNullHigh_SwappedOperands_GivesSameInterval()
        {
            var result = Context.Operators.Intersect(Interval(5, null, true, false), Interval(1, 10, true, true));

            AssertInterval(result, 5, null, lowClosed: true, highClosed: false);
        }

        [TestMethod]
        public void Intersect_UnknownBoundaryRangeCollapsesToKnownBoundary_IsCommutative()
        {
            // The unknown low of Interval(null, int.MinValue] can only be int.MinValue, which is also the known
            // low of Interval[int.MinValue, int.MinValue]: the known boundary is taken whichever argument comes
            // first, and likewise for an unknown high that can only be int.MaxValue.
            var unknownLow = Interval(null, int.MinValue, false, true);
            var knownLow = Interval(int.MinValue, int.MinValue, true, true);
            AssertInterval(Context.Operators.Intersect(unknownLow, knownLow), int.MinValue, int.MinValue, lowClosed: true, highClosed: true);
            AssertInterval(Context.Operators.Intersect(knownLow, unknownLow), int.MinValue, int.MinValue, lowClosed: true, highClosed: true);

            var unknownHigh = Interval(int.MaxValue, null, true, false);
            var knownHigh = Interval(int.MaxValue, int.MaxValue, true, true);
            AssertInterval(Context.Operators.Intersect(unknownHigh, knownHigh), int.MaxValue, int.MaxValue, lowClosed: true, highClosed: true);
            AssertInterval(Context.Operators.Intersect(knownHigh, unknownHigh), int.MaxValue, int.MaxValue, lowClosed: true, highClosed: true);
        }

        [TestMethod]
        public void Intersect_OpenNullLow_KeepsUnknownStartAndKnownEnd()
        {
            // Interval(null, 5] starts at some value up to 5, so the intersection with Interval[1, 10] starts
            // at an unknown point and ends at 5.
            var result = Context.Operators.Intersect(Interval(1, 10, true, true), Interval(null, 5, false, true));

            AssertInterval(result, null, 5, lowClosed: false, highClosed: true);
            Assert.AreEqual(5, Context.Operators.End(result));
            AssertInterval(
                Context.Operators.Intersect(Interval(null, 5, false, true), Interval(1, 10, true, true)),
                null, 5, lowClosed: false, highClosed: true);
        }

        [TestMethod]
        public void Intersect_OpenNullHigh_NotBelowOtherHigh_KeepsKnownHigh()
        {
            // The unknown high of Interval[5, null) is at least 5, so Interval[1, 5] ends first.
            var result = Context.Operators.Intersect(Interval(1, 5, true, true), Interval(5, null, true, false));

            AssertInterval(result, 5, 5, lowClosed: true, highClosed: true);
        }

        [TestMethod]
        public void Intersect_ClosedNullHigh_IsMaximum()
        {
            // Interval[1, 10] intersect Interval[5, null] = Interval[5, 10]
            AssertInterval(
                Context.Operators.Intersect(Interval(1, 10, true, true), Interval(5, null, true, true)),
                5, 10, lowClosed: true, highClosed: true);
            AssertInterval(
                Context.Operators.Intersect(Interval(5, null, true, true), Interval(1, 10, true, true)),
                5, 10, lowClosed: true, highClosed: true);
        }

        [TestMethod]
        public void Intersect_ClosedNullLow_IsMinimum()
        {
            // Interval[null, 10] intersect Interval[5, 20] = Interval[5, 10]
            AssertInterval(
                Context.Operators.Intersect(Interval(null, 10, true, true), Interval(5, 20, true, true)),
                5, 10, lowClosed: true, highClosed: true);

            // Both lows are the minimum, so the result keeps the closed null low boundary.
            var bothUnbounded = Context.Operators.Intersect(Interval(null, 10, true, true), Interval(null, 5, true, true));
            AssertInterval(bothUnbounded, null, 5, lowClosed: true, highClosed: true);
            Assert.AreEqual(int.MinValue, Context.Operators.Start(bothUnbounded));
        }

        [TestMethod]
        public void Intersect_OpenNullHigh_NoOverlap_IsNull()
        {
            // Interval[5, null) starts after Interval[1, 3] ends, whatever its unknown high boundary is.
            Assert.IsNull(Context.Operators.Intersect(Interval(1, 3, true, true), Interval(5, null, true, false)));
            Assert.IsNull(Context.Operators.Intersect(Interval(5, null, true, false), Interval(1, 3, true, true)));
        }

        [TestMethod]
        public void Intersect_OpenNullLow_OverlapDependsOnUnknownBoundary_IsNull()
        {
            // Interval(null, 5] overlaps Interval[1, 3] only when its unknown low is at most 3, so whether
            // there is an overlapping portion at all is unknown.
            Assert.IsNull(Context.Operators.Intersect(Interval(1, 3, true, true), Interval(null, 5, false, true)));
            Assert.IsNull(Context.Operators.Intersect(Interval(null, 5, false, true), Interval(1, 3, true, true)));
        }

        [TestMethod]
        public void Intersect_OpenNullHigh_DateTime_KeepsKnownStart()
        {
            // An ongoing period, Interval[onset, null), intersected with a measurement period.
            static CqlDateTime Dt(int y, int m, int d) => new(y, m, d, 0, 0, 0, 0, 0, 0);
            var measurementPeriod = new CqlInterval<CqlDateTime?>(Dt(2026, 1, 1), Dt(2026, 12, 31), true, true);
            var ongoing = new CqlInterval<CqlDateTime?>(Dt(2026, 3, 1), null, true, false);

            var result = Context.Operators.Intersect(measurementPeriod, ongoing);

            Assert.IsNotNull(result);
            Assert.AreEqual(true, Context.Operators.Equal(Context.Operators.Start(result), Dt(2026, 3, 1)));
            Assert.IsNull(result.high);
            Assert.AreEqual(false, result.highClosed);
        }

        [TestMethod]
        public void Intersect_KnownBoundaries_IsOverlappingPortion()
        {
            // Interval[1, 10] intersect Interval[5, 15] = Interval[5, 10]
            AssertInterval(
                Context.Operators.Intersect(Interval(1, 10, true, true), Interval(5, 15, true, true)),
                5, 10, lowClosed: true, highClosed: true);
            Assert.IsNull(Context.Operators.Intersect(Interval(1, 3, true, true), Interval(5, 15, true, true)));
        }
    }
}
