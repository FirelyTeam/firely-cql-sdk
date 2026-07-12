/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace CoreTests
{
    /// <summary>
    /// Regression tests for issue #1352: a null open interval boundary is unknown, while a
    /// null closed boundary keeps the minimum/maximum interpretation. An unknown boundary
    /// still ranges over the values permitted by its own interval (an unknown high lies
    /// between the low boundary and the maximum), so comparisons involving it are true when
    /// every possible value satisfies them, false when none does, and null only when the
    /// outcome genuinely depends on the unknown value.
    /// </summary>
    [TestClass]
    public class OpenNullIntervalBoundaryTests
    {
        private static readonly CqlContext Context = FhirCqlContext.WithDataSource();

        private static CqlDateTime Dt(int y, int m, int d) => new(y, m, d, 0, 0, 0, 0, 0, 0);

        private static readonly CqlInterval<CqlDateTime> MeasurementPeriod =
            new(Dt(2026, 1, 1), Dt(2026, 12, 31), true, true);

        [TestMethod]
        public void Overlaps_OpenNullHighBoundary_IsUnknown()
        {
            // e.g. QICoreCommon.prevalenceInterval() for an inactive condition without
            // abatement: Interval[onset, null) - the high boundary is unknown.
            var prevalence = new CqlInterval<CqlDateTime>(Dt(2025, 12, 31), null, true, false);

            Assert.IsNull(Context.Operators.Overlaps(prevalence, MeasurementPeriod, null));
            Assert.IsNull(Context.Operators.Overlaps(MeasurementPeriod, prevalence, null));
        }

        [TestMethod]
        public void Overlaps_ClosedNullHighBoundary_IsMaximum()
        {
            // An active condition without abatement: Interval[onset, null] - the closed
            // null high boundary is the maximum DateTime and overlaps everything later.
            var prevalence = new CqlInterval<CqlDateTime>(Dt(2025, 12, 31), null, true, true);

            Assert.AreEqual(true, Context.Operators.Overlaps(prevalence, MeasurementPeriod, null));
        }

        [TestMethod]
        public void Overlaps_OpenNullHigh_StillTrueWhenStartInsideOther()
        {
            // The unknown high boundary is still constrained to be >= the low boundary,
            // so an interval starting inside the other one decidably overlaps it:
            // [2025-12-31, ?) overlaps a look back period [2024-01-01, 2026-01-01).
            var lookBack = new CqlInterval<CqlDateTime>(Dt(2024, 1, 1), Dt(2026, 1, 1), true, false);
            var prevalence = new CqlInterval<CqlDateTime>(Dt(2025, 12, 31), null, true, false);

            Assert.AreEqual(true, Context.Operators.Overlaps(prevalence, lookBack, null));
            Assert.AreEqual(true, Context.Operators.Overlaps(lookBack, prevalence, null));
        }

        [TestMethod]
        public void Overlaps_OpenNullHigh_StillFalseWhenDecidable()
        {
            // The unknown high boundary does not matter when the interval already starts
            // after the other one ends: [2027-06-01, ?) cannot overlap 2026.
            var later = new CqlInterval<CqlDateTime>(Dt(2027, 6, 1), null, true, false);

            Assert.AreEqual(false, Context.Operators.Overlaps(later, MeasurementPeriod, null));
        }

        [TestMethod]
        public void OverlapsBefore_OpenNullLowBoundary_IsUnknown()
        {
            var unknownStart = new CqlInterval<CqlDateTime>(null, Dt(2026, 6, 1), false, true);

            Assert.IsNull(Context.Operators.OverlapsBefore(unknownStart, MeasurementPeriod, null));
        }

        [TestMethod]
        public void OverlapsAfter_OpenNullHighBoundary_IsUnknown()
        {
            var unknownEnd = new CqlInterval<CqlDateTime>(Dt(2026, 6, 1), null, true, false);

            Assert.IsNull(Context.Operators.OverlapsAfter(unknownEnd, MeasurementPeriod, null));
        }

        [TestMethod]
        public void IntervalIncludesInterval_OpenNullBoundary_IsUnknown()
        {
            var unknownEnd = new CqlInterval<CqlDateTime>(Dt(2026, 6, 1), null, true, false);

            Assert.IsNull(Context.Operators.IntervalIncludesInterval(MeasurementPeriod, unknownEnd, null));
        }

        [TestMethod]
        public void IntervalIncludesInterval_ClosedNullBoundary_IsMaximum()
        {
            var closedNullEnd = new CqlInterval<CqlDateTime>(Dt(2025, 1, 1), null, true, true);

            Assert.AreEqual(false, Context.Operators.IntervalIncludesInterval(MeasurementPeriod, closedNullEnd, null));
            Assert.AreEqual(true, Context.Operators.IntervalIncludesInterval(closedNullEnd, MeasurementPeriod, null));
        }
    }
}
