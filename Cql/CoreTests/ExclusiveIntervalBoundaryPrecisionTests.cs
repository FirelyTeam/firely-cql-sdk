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
    /// An exclusive date/time boundary produced by the Interval selector must stay exclusive, so that
    /// operators comparing at a coarser precision apply an exclusive comparison at that precision.
    /// CQL 1.5.3 Errata 2, Appendix B - CQL Reference, section "5.3 in": "For open interval boundaries,
    /// exclusive comparison operators are used. [...] If precision is specified and the point type is a
    /// date/time type, comparisons used in the operation are performed at the specified precision."
    /// Normalizing the boundary to a closed one steps it by one unit of the boundary's own precision
    /// (a millisecond here), which is invisible at millisecond precision but flips the result at day
    /// precision - the shape emitted for the CQL timing phrases "X Q or less before P of Y" and
    /// "X starts Q or less after P of Y".
    /// </summary>
    [TestClass]
    public class ExclusiveIntervalBoundaryPrecisionTests
    {
        private static readonly CqlContext Context = FhirCqlContext.WithDataSource();

        private static CqlDateTime Dt(int y, int m, int d, int h, int min) =>
            new(y, m, d, h, min, 0, 0, 0, 0);

        [TestMethod]
        public void IntervalSelector_ExclusiveDateTimeBoundaries_AreNotNormalizedToClosed()
        {
            var interval = Context.Operators.Interval(Dt(2026, 6, 30, 8, 0), Dt(2026, 12, 30, 8, 0), false, false);

            Assert.IsNotNull(interval);
            Assert.AreEqual(false, interval!.lowClosed);
            Assert.AreEqual(false, interval.highClosed);
            Assert.AreEqual(Dt(2026, 6, 30, 8, 0), interval.low);
            Assert.AreEqual(Dt(2026, 12, 30, 8, 0), interval.high);
        }

        [TestMethod]
        public void In_DayPrecision_ExclusiveHighBoundary_ExcludesTheWholeBoundaryDay()
        {
            // CMS646 "Cystectomy Done": Cystectomy.performed.toInterval() 6 months or less before
            // day of start of staging.performed.toInterval(), which the translator emits as
            // In(End(cystectomy), Interval[stagingStart - 6 months, stagingStart), Day).
            var stagingStart = Dt(2026, 6, 30, 8, 0);
            var low = Context.Operators.Subtract(stagingStart, Context.Operators.Quantity(6m, "months"));
            var window = Context.Operators.Interval(low, stagingStart, true, false);

            // A cystectomy ending later the same day as the excluded high boundary is not "before" it.
            Assert.AreEqual(false, Context.Operators.In(Dt(2026, 6, 30, 8, 15), window, "day"));
            // The day before the boundary is inside the window.
            Assert.AreEqual(true, Context.Operators.In(Dt(2026, 6, 29, 8, 15), window, "day"));
        }

        [TestMethod]
        public void In_DayPrecision_ExclusiveLowBoundary_ExcludesTheWholeBoundaryDay()
        {
            // CMS646 "First BCG Administered": BCG.effective.toInterval() starts 6 months or less
            // after day of start of staging.performed.toInterval(), emitted as
            // In(Start(bcg), Interval(stagingStart, stagingStart + 6 months], Day).
            var stagingStart = Dt(2026, 4, 6, 8, 0);
            var high = Context.Operators.Add(stagingStart, Context.Operators.Quantity(6m, "months"));
            var window = Context.Operators.Interval(stagingStart, high, false, true);

            // A BCG administration starting on the same day as the staging procedure is not "after" it.
            Assert.AreEqual(false, Context.Operators.In(Dt(2026, 4, 6, 8, 0), window, "day"));
            Assert.AreEqual(false, Context.Operators.In(Dt(2026, 4, 6, 23, 59), window, "day"));
            // The next day is inside the window.
            Assert.AreEqual(true, Context.Operators.In(Dt(2026, 4, 7, 0, 0), window, "day"));
        }

        [TestMethod]
        public void In_NoPrecision_ExclusiveBoundaries_StillCompareAtFullPrecision()
        {
            var window = Context.Operators.Interval(Dt(2026, 4, 6, 8, 0), Dt(2026, 4, 6, 9, 0), false, false);

            Assert.AreEqual(false, Context.Operators.In(Dt(2026, 4, 6, 8, 0), window, null));
            Assert.AreEqual(true, Context.Operators.In(Dt(2026, 4, 6, 8, 1), window, null));
            Assert.AreEqual(false, Context.Operators.In(Dt(2026, 4, 6, 9, 0), window, null));
        }

        [TestMethod]
        public void StartAndEnd_OfExclusiveDateTimeInterval_StillStepByOnePointUnit()
        {
            var interval = Context.Operators.Interval(Dt(2026, 4, 6, 8, 0), Dt(2026, 4, 6, 9, 0), false, false);

            Assert.AreEqual(new CqlDateTime(2026, 4, 6, 8, 0, 0, 1, 0, 0), Context.Operators.Start(interval));
            Assert.AreEqual(new CqlDateTime(2026, 4, 6, 8, 59, 59, 999, 0, 0), Context.Operators.End(interval));
        }
    }
}
