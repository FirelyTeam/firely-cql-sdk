/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;

namespace CoreTests
{
    /// <summary>
    /// Regression tests for issue #1359: the union of two intervals returned null for
    /// intervals that meet without overlapping (the CQL specification only returns null
    /// when the intervals neither overlap nor meet), and the branch taken when the right
    /// operand starts first compared a boundary with itself, silently discarding the left
    /// interval's tail.
    /// </summary>
    [TestClass]
    public class IntervalUnionTests
    {
        private static ICqlOperators Sut() => FhirCqlContext.WithDataSource().Operators;

        private static CqlInterval<int?> Ints(int? low, int? high) => new(low, high, true, true);
        private static CqlInterval<decimal?> Decimals(decimal? low, decimal? high) => new(low, high, true, true);
        private static CqlInterval<CqlQuantity?> Quantities(decimal? low, decimal? high, string unit = "mg") =>
            new(new CqlQuantity(low, unit), new CqlQuantity(high, unit), true, true);

        private static CqlDate Date(int y, int m, int d) => new(y, m, d);

        [TestMethod]
        public void Union_MeetingIntegerIntervals_Merges()
        {
            // [2, 2] and [3, 3] meet: successor(2) == 3, so the union is [2, 3].
            var result = Sut().Union(Ints(2, 2), Ints(3, 3));

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.low);
            Assert.AreEqual(3, result.high);
        }

        [TestMethod]
        public void Union_MeetingIntegerIntervals_RightFirst_Merges()
        {
            var result = Sut().Union(Ints(3, 3), Ints(2, 2));

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.low);
            Assert.AreEqual(3, result.high);
        }

        [TestMethod]
        public void Union_MeetingDateIntervals_Merges()
        {
            var earlier = new CqlInterval<CqlDate>(Date(2026, 1, 1), Date(2026, 1, 1), true, true);
            var next = new CqlInterval<CqlDate>(Date(2026, 1, 2), Date(2026, 1, 2), true, true);

            var result = Sut().Union(earlier, next);

            Assert.IsNotNull(result);
            Assert.AreEqual(Date(2026, 1, 1), result.low);
            Assert.AreEqual(Date(2026, 1, 2), result.high);
        }

        [TestMethod]
        public void Union_MeetingDecimalIntervals_Merges()
        {
            var result = Sut().Union(Decimals(2m, 2m), Decimals(2.00000001m, 3m));

            Assert.IsNotNull(result);
            Assert.AreEqual(2m, result.low);
            Assert.AreEqual(3m, result.high);
        }

        [TestMethod]
        public void Union_MeetingQuantityIntervals_Merges()
        {
            var result = Sut().Union(Quantities(2m, 2m), Quantities(2.00000001m, 3m));

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.low);
            Assert.IsNotNull(result.high);
            Assert.AreEqual(2m, result.low.value);
            Assert.AreEqual(3m, result.high.value);
            Assert.AreEqual("mg", result.low.unit);
            Assert.AreEqual("mg", result.high.unit);
        }

        [TestMethod]
        public void Union_DecimalIntervals_WithGap_ReturnsNull()
        {
            Assert.IsNull(Sut().Union(Decimals(2m, 2m), Decimals(2.00000002m, 3m)));
        }

        [TestMethod]
        public void Union_SeparatedIntervals_ReturnsNull()
        {
            // [2, 2] and [4, 4] neither overlap nor meet: 3 lies between them.
            Assert.IsNull(Sut().Union(Ints(2, 2), Ints(4, 4)));
            Assert.IsNull(Sut().Union(Ints(4, 4), Ints(2, 2)));
        }

        [TestMethod]
        public void Union_RightStartsFirst_KeepsLeftTail()
        {
            // The right operand starts first and the left ends later: the result must
            // cover both, not silently return the right operand.
            var result = Sut().Union(Ints(3, 10), Ints(1, 5));

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.low);
            Assert.AreEqual(10, result.high);
        }

        [TestMethod]
        public void Union_OverlappingIntervals_Unchanged()
        {
            var result = Sut().Union(Ints(1, 5), Ints(3, 10));

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.low);
            Assert.AreEqual(10, result.high);
        }

        [TestMethod]
        public void Union_ContainedInterval_ReturnsOuter()
        {
            var outerFirst = Sut().Union(Ints(1, 10), Ints(3, 5));
            var outerSecond = Sut().Union(Ints(3, 5), Ints(1, 10));

            Assert.IsNotNull(outerFirst);
            Assert.AreEqual(1, outerFirst.low);
            Assert.AreEqual(10, outerFirst.high);
            Assert.IsNotNull(outerSecond);
            Assert.AreEqual(1, outerSecond.low);
            Assert.AreEqual(10, outerSecond.high);
        }

        [TestMethod]
        public void Union_OpenBoundaryMeeting_MergesAfterNormalization()
        {
            // [2, 4) normalizes to [2, 3], which meets [4, 5].
            var halfOpen = new CqlInterval<int?>(2, 4, true, false);

            var result = Sut().Union(halfOpen, Ints(4, 5));

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.low);
            Assert.AreEqual(5, result.high);
        }

        [TestMethod]
        public void Union_NullHighBoundary_IsMaximum()
        {
            // [5, null] extends to the end of time and overlaps everything from 5 on.
            var unbounded = new CqlInterval<int?>(5, null, true, true);

            var result = Sut().Union(Ints(1, 6), unbounded);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.low);
            Assert.IsNull(result.high);
        }

        [TestMethod]
        public void Union_NullArgument_ReturnsNull()
        {
            Assert.IsNull(Sut().Union(null, Ints(1, 2)));
            Assert.IsNull(Sut().Union(Ints(1, 2), null));
        }
    }
}
