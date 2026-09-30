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
    /// Two DateTime boundaries of different precision that agree at the coarser one compare as uncertain
    /// (<c>null</c>). The interval relationship operators built from boundary comparisons leave the result
    /// unknown when it depends on such a comparison, and decide it when the other comparisons settle it.
    /// CQL 1.5.3 Errata 2, Appendix B - CQL Reference, section "Overlaps": the operator "returns true if
    /// the first interval overlaps the second. More precisely, if the starting or ending point of either
    /// interval is in the other, or if the ending point of the first interval is greater than or equal to
    /// the starting point of the second interval, and the starting point of the first interval is less
    /// than or equal to the ending point of the second interval." The HL7 CQL conformance suite
    /// (CqlIntervalOperatorsTest, group Overlaps) expects the <c>DateTimeOverlapsPrecision…</c> cases
    /// below.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    public class IntervalOperatorsUncertainBoundaryTests
    {
        private static readonly CqlContext Context = FhirCqlContext.WithDataSource();

        private static CqlDateTime Dt(string value) =>
            CqlDateTime.TryParse(value, out var dateTime) ? dateTime! : throw new ArgumentException(value);

        private static CqlInterval<CqlDateTime?> Closed(string low, string high) =>
            new(Dt(low), Dt(high), true, true);

        [TestMethod]
        public void Overlaps_LeftPossiblyStartsDuringRight_IsNull() =>
            // Conformance case DateTimeOverlapsPrecisionLeftPossiblyStartsDuringRight.
            Assert.IsNull(Context.Operators.Overlaps(Closed("2012-02-25", "2012-03-26"), Closed("2012-01-10", "2012-02"), null));

        [TestMethod]
        public void Overlaps_LeftPossiblyEndsDuringRight_IsNull() =>
            // Conformance case DateTimeOverlapsPrecisioLeftPossiblyEndsDuringRight.
            Assert.IsNull(Context.Operators.Overlaps(Closed("2012-01-25", "2012-02-26"), Closed("2012-02", "2012-03-28"), null));

        [TestMethod]
        public void Overlaps_LeftPossiblyStartsAndEndsDuringRight_IsNull() =>
            // Conformance case DateTimeOverlapsPrecisionLeftPossiblyStartsAndEndsDuringRight.
            Assert.IsNull(Context.Operators.Overlaps(Closed("2012-02", "2012-03"), Closed("2011-01-10", "2012"), null));

        [TestMethod]
        public void Overlaps_UncertainOnOneSide_DecidedByTheOther_IsTrue()
        {
            // Conformance cases DateTimeOverlapsPrecisionRightPossiblyStartsDuringLeftButEndsDuringLeft and
            // DateTimeOverlapsPrecisionRightStartsDuringLeftAndPossiblyEndsDuringLeft: one boundary comparison
            // is uncertain, but the other interval is definitely inside, so the intervals overlap.
            Assert.AreEqual(true, Context.Operators.Overlaps(Closed("2012", "2013-03"), Closed("2012-02", "2013-02"), null));
            Assert.AreEqual(true, Context.Operators.Overlaps(Closed("2012-02", "2013"), Closed("2012-03", "2013-02"), null));
        }

        [TestMethod]
        public void Overlaps_UncertainOnOneSide_DefinitelyApartOnTheOther_IsFalse() =>
            // The high of the first is uncertain against the low of the second, but the first starts
            // after the second ends, so they cannot overlap.
            Assert.AreEqual(false, Context.Operators.Overlaps(Closed("2012-04-01", "2012-05"), Closed("2012-02", "2012-03-15"), null));

        [TestMethod]
        public void Overlaps_AtAnExplicitPrecision_ComparesMixedPrecisionBoundariesAtThatPrecision()
        {
            // The same boundaries that are uncertain without a precision compare as equal months at
            // month precision, so the comparison is certain.
            Assert.AreEqual(true, Context.Operators.Overlaps(Closed("2012-01-25", "2012-02-26"), Closed("2012-02", "2012-03-28"), "month"));
            Assert.AreEqual(true, Context.Operators.Overlaps(Closed("2012-01-25", "2012-02-26T10"), Closed("2012-02-26T12", "2012-03-28"), "day"));
        }

        [TestMethod]
        public void OverlapsBefore_EndUncertainAgainstTheOtherStart_IsNull() =>
            Assert.IsNull(Context.Operators.OverlapsBefore(Closed("2012-01-25", "2012-02-26"), Closed("2012-02", "2012-03-28"), null));

        [TestMethod]
        public void OverlapsBefore_Decided_KeepsItsAnswer()
        {
            // Both comparisons certain: starts before and ends inside the other (true); starts after it (false).
            Assert.AreEqual(true, Context.Operators.OverlapsBefore(Closed("2012-01-25", "2012-02-26"), Closed("2012-02-10", "2012-03-28"), null));
            Assert.AreEqual(false, Context.Operators.OverlapsBefore(Closed("2012-03-01", "2012-04"), Closed("2012-02-10", "2012-03-28"), null));
            // The uncertain comparison becomes certain at month precision.
            Assert.AreEqual(true, Context.Operators.OverlapsBefore(Closed("2012-01-25", "2012-02-26"), Closed("2012-02", "2012-03-28"), "month"));
        }

        [TestMethod]
        public void OverlapsAfter_StartUncertainAgainstTheOtherEnd_IsNull() =>
            Assert.IsNull(Context.Operators.OverlapsAfter(Closed("2012-02", "2012-03-28"), Closed("2012-01-25", "2012-02-26"), null));

        [TestMethod]
        public void OverlapsAfter_Decided_KeepsItsAnswer()
        {
            Assert.AreEqual(true, Context.Operators.OverlapsAfter(Closed("2012-02-10", "2012-03-28"), Closed("2012-01-25", "2012-02-26"), null));
            Assert.AreEqual(false, Context.Operators.OverlapsAfter(Closed("2012-01", "2012-02-10"), Closed("2012-01-25", "2012-02-26"), null));
            Assert.AreEqual(true, Context.Operators.OverlapsAfter(Closed("2012-02", "2012-03-28"), Closed("2012-01-25", "2012-02-26"), "month"));
        }

        [TestMethod]
        public void Overlaps_ClosedBoundaryWithoutAValue_IsTheExtreme_EvenAgainstAnImprecisePointThere()
        {
            // A closed null high is the maximum DateTime and a closed null low the minimum. Year 9999 and year 1
            // match those extremes at year precision; the extreme still decides the comparison.
            var untilTheEndOfTime = new CqlInterval<CqlDateTime?>(Dt("9998"), null, true, true);
            var fromTheStartOfTime = new CqlInterval<CqlDateTime?>(null, Dt("0002"), true, true);

            Assert.AreEqual(true, Context.Operators.Overlaps(untilTheEndOfTime, Closed("9999", "9999"), null));
            Assert.AreEqual(true, Context.Operators.Overlaps(Closed("9999", "9999"), untilTheEndOfTime, null));
            Assert.AreEqual(true, Context.Operators.Overlaps(fromTheStartOfTime, Closed("0001", "0001"), null));
            Assert.AreEqual(true, Context.Operators.Overlaps(Closed("0001", "0001"), fromTheStartOfTime, null));
        }

        [TestMethod]
        public void OverlapsAfter_ClosedBoundaryWithoutAValue_IsTheExtreme()
        {
            var untilTheEndOfTime = new CqlInterval<CqlDateTime?>(Dt("2012-06"), null, true, true);

            // Ends at the maximum, so it ends after any bounded interval it overlaps.
            Assert.AreEqual(true, Context.Operators.OverlapsAfter(untilTheEndOfTime, Closed("2012", "2012-09"), null));
            // Nothing ends after the maximum, even a year that matches it at year precision.
            Assert.AreEqual(false, Context.Operators.OverlapsAfter(Closed("2012-06", "9999"), new CqlInterval<CqlDateTime?>(Dt("2012"), null, true, true), null));
        }

        [TestMethod]
        public void OverlapsBefore_ClosedBoundaryWithoutAValue_IsTheExtreme()
        {
            var fromTheStartOfTime = new CqlInterval<CqlDateTime?>(null, Dt("2012-06"), true, true);

            // Starts at the minimum, so it starts before any bounded interval it overlaps.
            Assert.AreEqual(true, Context.Operators.OverlapsBefore(fromTheStartOfTime, Closed("2012-03", "2012-09"), null));
            // Nothing starts before the minimum, even a year that matches it at year precision.
            Assert.AreEqual(false, Context.Operators.OverlapsBefore(Closed("0001", "0001-06"), new CqlInterval<CqlDateTime?>(null, Dt("0002"), true, true), null));
        }

        [TestMethod]
        public void Meets_EndUncertainAgainstTheOtherStart_IsNull()
        {
            // 2012-01-14 against 2012-01 is uncertain; the other pairings are definitely not adjacent.
            Assert.IsNull(Context.Operators.Meets(Closed("2012-01-07", "2012-01-14"), Closed("2012-01", "2012-01-25"), null));
            Assert.IsNull(Context.Operators.MeetsBefore(Closed("2012-01-07", "2012-01-14"), Closed("2012-01", "2012-01-25"), null));
            Assert.IsNull(Context.Operators.MeetsAfter(Closed("2012-01", "2012-01-25"), Closed("2012-01-07", "2012-01-14"), null));
        }

        [TestMethod]
        public void Meets_DefiniteAdjacency_WinsOverAnUncertainCandidate() =>
            // The first interval's low (2012-01) against the second's high (2012-01-25) is uncertain, but its
            // high (2012-01-14) is definitely the predecessor of the second's low (2012-01-15).
            Assert.AreEqual(true, Context.Operators.Meets(Closed("2012-01", "2012-01-14"), Closed("2012-01-15", "2012-01-25"), null));

        [TestMethod]
        public void Meets_AtAnExplicitPrecision_ComparesMixedPrecisionBoundariesAtThatPrecision()
        {
            // At month precision 2012-01-14 and 2012-01 are the same month, so the intervals meet.
            Assert.AreEqual(true, Context.Operators.Meets(Closed("2012-01-07", "2012-01-14"), Closed("2012-01", "2012-01-25"), "month"));
            Assert.AreEqual(true, Context.Operators.MeetsBefore(Closed("2012-01-07", "2012-01-14"), Closed("2012-01", "2012-01-25"), "month"));
            Assert.AreEqual(true, Context.Operators.MeetsAfter(Closed("2012-01", "2012-01-25"), Closed("2012-01-07", "2012-01-14"), "month"));
        }

        [TestMethod]
        public void Meets_DefinitelyAdjacent_IsTrue()
        {
            Assert.AreEqual(true, Context.Operators.Meets(Closed("2012-01-07", "2012-01-14"), Closed("2012-01-15", "2012-01-25"), null));
            Assert.AreEqual(true, Context.Operators.MeetsBefore(Closed("2012-01-07", "2012-01-14"), Closed("2012-01-15", "2012-01-25"), null));
            Assert.AreEqual(true, Context.Operators.MeetsAfter(Closed("2012-01-15", "2012-01-25"), Closed("2012-01-07", "2012-01-14"), null));
        }

        [TestMethod]
        public void Meets_DefinitelyApart_IsFalse()
        {
            Assert.AreEqual(false, Context.Operators.Meets(Closed("2012-01-07", "2012-01-14"), Closed("2012-03", "2012-03-25"), null));
            Assert.AreEqual(false, Context.Operators.MeetsBefore(Closed("2012-01-07", "2012-01-14"), Closed("2012-03", "2012-03-25"), null));
            Assert.AreEqual(false, Context.Operators.MeetsAfter(Closed("2012-03", "2012-03-25"), Closed("2012-01-07", "2012-01-14"), null));
        }
    }
}
