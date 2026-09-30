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
    /// A date/time point that is less precise than an interval boundary, and matches it at the point's own
    /// precision, compares to that boundary as uncertain (<c>null</c>). CQL 1.5.3 Errata 2, Appendix B - CQL
    /// Reference, section "In": the operator "returns true if the given point is equal to the starting or
    /// ending point of the interval, or greater than the starting point and less than the ending point. For
    /// open interval boundaries, exclusive comparison operators are used. For closed interval boundaries, if
    /// the interval boundary is null, the result of the boundary comparison is considered true." The last
    /// sentence is about a boundary whose value is null, not about an uncertain comparison, so an uncertain
    /// boundary comparison leaves <c>in</c> uncertain whether the boundary is open or closed.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    public class IntervalInUncertainBoundaryTests
    {
        private static readonly CqlContext Context = FhirCqlContext.WithDataSource();

        private static CqlDateTime Dt(string value) =>
            CqlDateTime.TryParse(value, out var dateTime) ? dateTime! : throw new ArgumentException(value);

        // Interval(@2026-03-29T00:00:00.000Z, @2026-09-29T00:00:00.000Z]: an open low and a closed high,
        // both at millisecond precision.
        private static CqlInterval<CqlDateTime?> Window() =>
            new(Dt("2026-03-29T00:00:00.000Z"), Dt("2026-09-29T00:00:00.000Z"), false, true);

        [TestMethod]
        [DataRow("2026-09-29", DisplayName = "Day precision on the closed high")]
        [DataRow("2026-09-29T00:00:00Z", DisplayName = "Second precision on the closed high")]
        public void In_PointLessPreciseThanClosedBoundary_MatchingIt_IsNull(string point) =>
            Assert.IsNull(Context.Operators.In(Dt(point), Window(), null));

        [TestMethod]
        [DataRow("2026-03-29", DisplayName = "Day precision on the open low")]
        [DataRow("2026-03-29T00:00:00Z", DisplayName = "Second precision on the open low")]
        public void In_PointLessPreciseThanOpenBoundary_MatchingIt_IsNull(string point) =>
            Assert.IsNull(Context.Operators.In(Dt(point), Window(), null));

        [TestMethod]
        public void In_DateConvertedToDateTimeOnTheOpenBoundary_IsNull() =>
            Assert.IsNull(Context.Operators.In(Context.Operators.ConvertDateToDateTime(new CqlDate(2026, 3, 29)), Window(), null));

        [TestMethod]
        public void In_PointLessPreciseButDefinitelyInside_IsTrue() =>
            Assert.AreEqual(true, Context.Operators.In(Dt("2026-03-30"), Window(), null));

        [TestMethod]
        public void In_PointAsPreciseAsTheOpenBoundary_OnIt_IsFalse() =>
            Assert.AreEqual(false, Context.Operators.In(Dt("2026-03-29T00:00:00.000Z"), Window(), null));

        [TestMethod]
        public void In_UncertainOnOneBoundary_AndOutsideTheOther_IsFalse()
        {
            // The low is only known to the day, so a point during that day compares to it as uncertain, but the
            // point is definitely after the closed high, so it is definitely not in the interval.
            var window = new CqlInterval<CqlDateTime?>(Dt("2026-03-29"), Dt("2026-03-29T06:00:00.000Z"), true, true);

            Assert.IsNull(Context.Operators.Comparer.Compare(Dt("2026-03-29T12:00:00.000Z"), window.low, null));
            Assert.AreEqual(false, Context.Operators.In(Dt("2026-03-29T12:00:00.000Z"), window, null));
        }

        [TestMethod]
        public void In_UncertainOnBothBoundaries_IsNull()
        {
            var window = new CqlInterval<CqlDateTime?>(Dt("2026-03-29T00:00:00.000Z"), Dt("2026-03-29T00:00:00.000Z"), true, true);

            Assert.IsNull(Context.Operators.In(Dt("2026-03-29"), window, null));
        }

        [TestMethod]
        public void In_ClosedBoundaryWithoutAValue_StillCountsAsSatisfied()
        {
            // The rule the specification does state for a closed boundary: a null value compares as true.
            var fromTheStartOfTime = new CqlInterval<CqlDateTime?>(null, Dt("2026-09-29T00:00:00.000Z"), true, true);

            Assert.AreEqual(true, Context.Operators.In(Dt("2026-03-30"), fromTheStartOfTime, null));
        }

        [TestMethod]
        public void In_ClosedBoundaryWithoutAValue_IsSatisfiedByAnImprecisePointAtTheTypesLimit()
        {
            // Year 1 and year 9999 are the first and last years of a DateTime. At year precision they match its
            // minimum and maximum, but a closed boundary without a value is satisfied without comparing to them.
            var fromTheStartOfTime = new CqlInterval<CqlDateTime?>(null, Dt("2026-09-29T00:00:00.000Z"), true, true);
            var untilTheEndOfTime = new CqlInterval<CqlDateTime?>(Dt("2026-09-29T00:00:00.000Z"), null, true, true);

            Assert.AreEqual(true, Context.Operators.In(Dt("0001"), fromTheStartOfTime, null));
            Assert.AreEqual(true, Context.Operators.In(Dt("9999"), untilTheEndOfTime, null));
        }

        [TestMethod]
        public void Includes_PointLessPreciseThanClosedBoundary_MatchingIt_IsNull() =>
            Assert.IsNull(Context.Operators.IntervalIncludesElement(Window(), Dt("2026-09-29"), null));
    }
}
