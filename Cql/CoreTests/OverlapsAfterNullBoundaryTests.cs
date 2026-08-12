/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable disable

using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests
{
    /// <summary>
    /// Regression tests for issue #1356: OverlapsAfter substituted null interval boundaries
    /// with the wrong extremes (a null low boundary was treated as the maximum value and a
    /// null high boundary as the minimum), so an interval with an unbounded end never
    /// overlapped after anything. A null low boundary is the minimum value and a null high
    /// boundary the maximum.
    /// </summary>
    [TestClass]
    public class OverlapsAfterNullBoundaryTests
    {
        private static ICqlOperators Sut() => FhirCqlContext.WithDataSource().Operators;

        private static CqlDateTime Dt(int y, int m = 1, int d = 1) => new(y, m, d, 0, 0, 0, 0, 0, 0);

        [TestMethod]
        public void OverlapsAfter_NullHighBoundary_EndsAfterEverything()
        {
            // e.g. AHAOverall: Interval[start of allergy.onset.toInterval(), allergy.lastOccurrence]
            // where lastOccurrence is absent - the interval extends to the end of time.
            var unboundedEnd = new CqlInterval<CqlDateTime>(Dt(2005), null, true, true);
            var encounter = new CqlInterval<CqlDateTime>(Dt(2026, 3, 31), Dt(2026, 3, 31), true, true);

            Assert.AreEqual(true, Sut().OverlapsAfter(unboundedEnd, encounter, "day"));
        }

        [TestMethod]
        public void OverlapsAfter_NullLowBoundary_StartsBeforeEverything()
        {
            var unboundedStart = new CqlInterval<CqlDateTime>(null, Dt(2026, 6, 1), true, true);
            var earlier = new CqlInterval<CqlDateTime>(Dt(2026, 1, 1), Dt(2026, 3, 31), true, true);

            Assert.AreEqual(true, Sut().OverlapsAfter(unboundedStart, earlier, "day"));
        }

        [TestMethod]
        public void OverlapsAfter_RightNullHighBoundary_NothingEndsAfterIt()
        {
            var left = new CqlInterval<CqlDateTime>(Dt(2026, 6, 1), Dt(2026, 12, 31), true, true);
            var unboundedRight = new CqlInterval<CqlDateTime>(Dt(2026, 1, 1), null, true, true);

            Assert.AreEqual(false, Sut().OverlapsAfter(left, unboundedRight, "day"));
        }

        [TestMethod]
        public void OverlapsAfter_LeftEntirelyBefore_ReturnsFalse()
        {
            var earlier = new CqlInterval<CqlDateTime>(Dt(2005), Dt(2006), true, true);
            var encounter = new CqlInterval<CqlDateTime>(Dt(2026, 3, 31), Dt(2026, 3, 31), true, true);

            Assert.AreEqual(false, Sut().OverlapsAfter(earlier, encounter, "day"));
        }

        [TestMethod]
        public void OverlapsAfter_LeftEntirelyAfter_ReturnsFalse()
        {
            // Starts after the right interval ends: does not overlap, only follows it.
            var later = new CqlInterval<CqlDateTime>(Dt(2027), null, true, true);
            var encounter = new CqlInterval<CqlDateTime>(Dt(2026, 3, 31), Dt(2026, 3, 31), true, true);

            Assert.AreEqual(false, Sut().OverlapsAfter(later, encounter, "day"));
        }

        [TestMethod]
        public void OverlapsAfter_BoundedOverlappingIntervals_Unchanged()
        {
            var left = new CqlInterval<CqlDateTime>(Dt(2026, 2, 1), Dt(2026, 6, 1), true, true);
            var right = new CqlInterval<CqlDateTime>(Dt(2026, 1, 1), Dt(2026, 3, 31), true, true);

            Assert.AreEqual(true, Sut().OverlapsAfter(left, right, "day"));
            Assert.AreEqual(false, Sut().OverlapsAfter(right, left, "day"));
        }
    }
}
