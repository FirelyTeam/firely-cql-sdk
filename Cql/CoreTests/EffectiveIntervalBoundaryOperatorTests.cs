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
    /// The counterpart of <see cref="ExclusiveIntervalBoundaryPrecisionTests"/>: once the Interval selector
    /// keeps an exclusive date/time boundary exclusive, every operator the specification defines in terms of
    /// the Start and End operators has to compare the effective boundary - the raw one stepped inward by a
    /// unit of its own precision - rather than the raw endpoint. The selector's own normalization used to
    /// hide the difference from these operators, so each test below is a case that reading the raw endpoint
    /// gets wrong. Each test names the sentence of CQL 1.5.3 Errata 2, Appendix B - CQL Reference, that the
    /// expectation follows from.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    public class EffectiveIntervalBoundaryOperatorTests
    {
        private static readonly CqlContext Context = FhirCqlContext.WithDataSource();

        private static CqlDate D(int y, int m, int d) => new(y, m, d);

        private static CqlDateTime Dt(int y, int m, int d, int h, int min) => new(y, m, d, h, min, 0, 0, 0, 0);

        private static CqlInterval<CqlDate> Ival(CqlDate low, CqlDate high, bool lowClosed, bool highClosed) =>
            new(low, high, lowClosed, highClosed);

        // The Collapse overload is declared over a nullable point type.
        private static CqlInterval<CqlDate?> IvalOfNullable(CqlDate low, CqlDate high, bool lowClosed, bool highClosed) =>
            new(low, high, lowClosed, highClosed);

        // section "Starts": "if the starting point of the first is equal to the starting point of the second
        // interval and the ending point of the first interval is less than or equal to the ending point of
        // the second interval. This operator uses the semantics described in the start and end operators to
        // determine interval boundaries."
        [TestMethod]
        public void Starts_ExclusiveLowBoundary_ComparesTheEffectiveStart()
        {
            // (@2026-01-01, @2026-01-02] effectively starts on @2026-01-02, a day after the other interval.
            var exclusiveLow = Ival(D(2026, 1, 1), D(2026, 1, 2), false, true);
            var other = Ival(D(2026, 1, 1), D(2026, 1, 3), true, true);

            Assert.AreEqual(false, Context.Operators.Starts(exclusiveLow, other, "day"));

            // Stepping the exclusive low inward lands exactly on the other interval's start.
            var startsOther = Ival(D(2025, 12, 31), D(2026, 1, 2), false, true);
            Assert.AreEqual(true, Context.Operators.Starts(startsOther, other, "day"));
        }

        // section "Ends": "if the starting point of the first interval is greater than or equal to the
        // starting point of the second, and the ending point of the first interval is equal to the ending
        // point of the second. This operator uses the semantics described in the start and end operators to
        // determine interval boundaries."
        [TestMethod]
        public void Ends_ExclusiveHighBoundary_ComparesTheEffectiveEnd()
        {
            // [@2026-01-01, @2026-01-03) effectively ends on @2026-01-02, a day before the other interval.
            var exclusiveHigh = Ival(D(2026, 1, 1), D(2026, 1, 3), true, false);
            var other = Ival(D(2026, 1, 1), D(2026, 1, 3), true, true);

            Assert.AreEqual(false, Context.Operators.Ends(exclusiveHigh, other, "day"));

            // An exclusive low does not move the end, so this one still ends the other interval.
            var exclusiveLow = Ival(D(2026, 1, 1), D(2026, 1, 3), false, true);
            Assert.AreEqual(true, Context.Operators.Ends(exclusiveLow, other, "day"));
        }

        // section "Includes": "if the starting point of the first interval is less than or equal to the
        // starting point of the second interval, and the ending point of the first interval is greater than
        // or equal to the ending point of the second interval. [...] This operator uses the semantics
        // described in the Start and End operators to determine interval boundaries."
        [TestMethod]
        public void IntervalIncludesInterval_ExclusiveLowBoundary_ComparesTheEffectiveStart()
        {
            var exclusiveLow = Ival(D(2026, 1, 1), D(2026, 1, 3), false, true);
            var closed = Ival(D(2026, 1, 1), D(2026, 1, 3), true, true);

            // (@2026-01-01, @2026-01-03] starts a day into [@2026-01-01, @2026-01-03], so it cannot include it.
            Assert.AreEqual(false, Context.Operators.IntervalIncludesInterval(exclusiveLow, closed, "day"));
            Assert.AreEqual(false, Context.Operators.IntervalIncludedIn(closed, exclusiveLow, "day"));

            // The other way round it does include it.
            Assert.AreEqual(true, Context.Operators.IntervalIncludesInterval(closed, exclusiveLow, "day"));
            Assert.AreEqual(true, Context.Operators.IntervalIncludedIn(exclusiveLow, closed, "day"));
        }

        // section "Properly Includes": "if the starting point of the first interval is less than or equal to
        // the starting point of the second interval, and the ending point of the first interval is greater
        // than or equal to the ending point of the second interval, and they are not the same interval. [...]
        // This operator uses the semantics described in the Start and End operators to determine interval
        // boundaries."
        [TestMethod]
        public void IntervalProperlyIncludesInterval_SameEffectiveInterval_IsFalseBothWays()
        {
            // (@2026-01-01, @2026-01-05] and [@2026-01-02, @2026-01-05] are the same interval: both run
            // from @2026-01-02 to @2026-01-05. Neither properly includes the other.
            var exclusiveLow = Ival(D(2026, 1, 1), D(2026, 1, 5), false, true);
            var closed = Ival(D(2026, 1, 2), D(2026, 1, 5), true, true);

            Assert.AreEqual(false, Context.Operators.IntervalProperlyIncludesInterval(exclusiveLow, closed, "day"));
            Assert.AreEqual(false, Context.Operators.IntervalProperlyIncludesInterval(closed, exclusiveLow, "day"));
            Assert.AreEqual(false, Context.Operators.IntervalProperlyIncludedInInterval(exclusiveLow, closed, "day"));
            Assert.AreEqual(false, Context.Operators.IntervalProperlyIncludedInInterval(closed, exclusiveLow, "day"));

            // A strictly wider interval still properly includes it.
            var wider = Ival(D(2026, 1, 1), D(2026, 1, 5), true, true);
            Assert.AreEqual(true, Context.Operators.IntervalProperlyIncludesInterval(wider, exclusiveLow, "day"));
        }

        // section "Properly Included In", point-interval overload: "this operator returns true if the point
        // is in (i.e. included in) the interval, and the interval is not a unit interval containing only the
        // point", on the boundaries the Start and End operators determine.
        [TestMethod]
        public void ElementProperlyIncludedInInterval_ExclusiveLowBoundary_ComparesTheEffectiveStart()
        {
            var window = Ival(D(2026, 1, 1), D(2026, 1, 5), false, true);

            // The interval starts on @2026-01-02, so its raw low boundary is not in it at all.
            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(D(2026, 1, 1), window, "day"));
            Assert.AreEqual(false, Context.Operators.IntervalProperlyIncludesElement(window, D(2026, 1, 1), "day"));

            // From its effective start onwards the point is properly included: the interval is wider than
            // the point.
            Assert.AreEqual(true, Context.Operators.ElementProperlyIncludedInInterval(D(2026, 1, 2), window, "day"));
            Assert.AreEqual(true, Context.Operators.IntervalProperlyIncludesElement(window, D(2026, 1, 2), "day"));
        }

        [TestMethod]
        public void ElementProperlyIncludedInInterval_ExclusiveBoundariesAroundOnePoint_IsAUnitInterval()
        {
            // Interval(@2026-01-01, @2026-01-03) effectively runs from @2026-01-02 to @2026-01-02: a unit
            // interval containing only that point, which therefore is not properly included in it.
            var unit = Ival(D(2026, 1, 1), D(2026, 1, 3), false, false);

            Assert.AreEqual(false, Context.Operators.ElementProperlyIncludedInInterval(D(2026, 1, 2), unit, "day"));
            Assert.AreEqual(false, Context.Operators.IntervalProperlyIncludesElement(unit, D(2026, 1, 2), "day"));
        }

        // section "Intersect": "the operator returns the interval that defines the overlapping portion of
        // both arguments. If the arguments do not overlap, this operator returns null."
        [TestMethod]
        public void Intersect_ExclusiveHighMeetingClosedLow_IsNull()
        {
            var left = Ival(D(2026, 1, 1), D(2026, 1, 5), true, false);
            var right = Ival(D(2026, 1, 5), D(2026, 1, 8), true, true);

            // [@2026-01-01, @2026-01-05) ends on @2026-01-04, so it does not reach the other interval.
            Assert.IsNull(Context.Operators.Intersect(left, right));
            Assert.IsNull(Context.Operators.Intersect(right, left));
        }

        [TestMethod]
        public void Intersect_ExclusiveHighBoundary_ClipsOnTheEffectiveEnd()
        {
            var left = Ival(D(2026, 1, 1), D(2026, 1, 5), true, false);
            var right = Ival(D(2026, 1, 3), D(2026, 1, 8), true, true);

            var intersection = Context.Operators.Intersect(left, right);

            Assert.IsNotNull(intersection);
            Assert.AreEqual(D(2026, 1, 3), intersection!.low);
            Assert.AreEqual(D(2026, 1, 4), intersection.high);
            Assert.AreEqual(true, intersection.lowClosed);
            Assert.AreEqual(true, intersection.highClosed);
        }

        // section "Point From": "define \"PointFromExclusive\": point from Interval[4, 5) // 4"
        [TestMethod]
        public void PointFrom_ExclusiveBoundaries_ExtractsTheEffectivePoint()
        {
            Assert.AreEqual(4, Context.Operators.PointFrom(new CqlInterval<int?>(4, 5, true, false)));
            Assert.AreEqual(D(2026, 1, 2), Context.Operators.PointFrom(new CqlInterval<CqlDate?>(D(2026, 1, 1), D(2026, 1, 3), false, false)));
        }

        [TestMethod]
        public void PointFrom_WiderThanOnePoint_StillThrows()
        {
            Assert.ThrowsExactly<InvalidOperationException>(
                () => Context.Operators.PointFrom(new CqlInterval<CqlDate?>(D(2026, 1, 1), D(2026, 1, 4), false, false)));
        }

        // section "Collapse": "adjacent intervals within a sorted list are merged if they either overlap or
        // meet." The sort is on the effective start, so the merge cannot lose the earlier part of the range.
        [TestMethod]
        public void Collapse_ExclusiveLowTyingOnTheRawBoundary_KeepsTheWholeRange()
        {
            var exclusiveLow = IvalOfNullable(D(2026, 1, 1), D(2026, 1, 10), false, true);
            var closed = IvalOfNullable(D(2026, 1, 1), D(2026, 1, 5), true, true);

            var collapsed = Context.Operators.Collapse([exclusiveLow, closed], "day")?.ToList();

            Assert.IsNotNull(collapsed);
            Assert.AreEqual(1, collapsed!.Count);
            // Asserted through Start and End: had the merge taken the exclusive interval as the one that
            // starts first, the result would carry its exclusive low and effectively start on @2026-01-02,
            // dropping the day the closed interval contributed.
            Assert.AreEqual(D(2026, 1, 1), Context.Operators.Start(collapsed[0]));
            Assert.AreEqual(D(2026, 1, 10), Context.Operators.End(collapsed[0]));
        }

        // sections "Contains" and "In" state the same rule in the same words: "returns true if the given
        // point is equal to the starting or ending point of the interval, or greater than the starting point
        // and less than the ending point. For open interval boundaries, exclusive comparison operators are
        // used." Contains must therefore agree with In - and with Includes, whose point-interval overload
        // "is a synonym for the contains operator" - including when the comparison runs at a precision
        // coarser than the boundaries, which is where closing the boundary first turns the exclusive
        // comparison into an inclusive one.
        [TestMethod]
        public void Contains_DayPrecision_ExclusiveHighBoundary_AgreesWithIn()
        {
            var window = new CqlInterval<CqlDateTime?>(Dt(2026, 6, 1, 8, 0), Dt(2026, 6, 30, 8, 0), true, false);

            AssertContainsAgreesWithIn(window, Dt(2026, 6, 29, 8, 15), expected: true);
            AssertContainsAgreesWithIn(window, Dt(2026, 6, 30, 8, 15), expected: false);
        }

        [TestMethod]
        public void Contains_DayPrecision_ExclusiveLowBoundary_AgreesWithIn()
        {
            var window = new CqlInterval<CqlDateTime?>(Dt(2026, 4, 6, 8, 0), Dt(2026, 10, 6, 8, 0), false, true);

            AssertContainsAgreesWithIn(window, Dt(2026, 4, 6, 23, 59), expected: false);
            AssertContainsAgreesWithIn(window, Dt(2026, 4, 7, 0, 0), expected: true);
        }

        private static void AssertContainsAgreesWithIn(CqlInterval<CqlDateTime?> window, CqlDateTime point, bool expected)
        {
            Assert.AreEqual(expected, Context.Operators.Contains(window, point, "day"), $"contains {point}");
            Assert.AreEqual(expected, Context.Operators.In(point, window, "day"), $"in {point}");
            Assert.AreEqual(expected, Context.Operators.IntervalIncludesElement(window, point, "day"), $"includes {point}");
        }
    }
}
