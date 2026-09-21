/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Fhir.Metrics;
using Hl7.Cql.Comparers;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

namespace CoreTests
{
    /// <summary>
    /// Comparing two quantities whose units differ requires converting one of them, and the unit that
    /// conversion targets decides how much of each value survives. A CQL Decimal has "a <i>scale</i>
    /// (meaning number of possible digits to the right of the decimal) of 8 [...] with a step size of
    /// 10^-8" (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, section "1.1 Decimal"), and the Decimal
    /// comparer quantizes to that step. Converting to the canonical base unit rescales a clinical
    /// quantity below that step - 0.25 'mg/d' becomes 0.0000000028935185 'g.s-1' - so every pair of
    /// clinical quantities quantizes to zero and compares equal. Comparing in the finer of the two
    /// operand units keeps the values at the scale they were authored at, where the quantization is
    /// meaningful.
    ///
    /// The spec requires the conversion, not the base unit: "For comparisons involving quantities, the
    /// dimensions of each quantity must be the same, but not necessarily the unit" (ibid., stated
    /// identically for Equal, Less, Greater, LessOrEqual and GreaterOrEqual).
    /// </summary>
    [TestClass]
    public class QuantityComparisonUnitAlignmentTests
    {
        private static readonly CqlContext Context = FhirCqlContext.WithDataSource();

        private static CqlQuantity Q(decimal value, string unit) => new(value, unit);

        /// <summary>
        /// 0.25 'mg/d' against the 0.125 'mg/d' threshold of CMS156's "High Risk Medications with
        /// Average Daily Dose Criteria", with the left side in the canonical form that quantity division
        /// produces. Both canonical values are below 1e-8, so quantizing them answers 0 either way.
        /// </summary>
        [TestMethod]
        public void Greater_CanonicalOperandBelowDecimalStepSize_ComparesInTheOperandUnit()
        {
            var averageDailyDose = Q(0.0000000028935185185185185185m, "g.s-1"); // == 0.25 'mg/d'

            Assert.AreEqual(true, Context.Operators.Greater(averageDailyDose, Q(0.125m, "mg/d")));
            Assert.AreEqual(false, Context.Operators.Greater(averageDailyDose, Q(6m, "mg/d")));
            Assert.AreEqual(true, Context.Operators.Less(averageDailyDose, Q(6m, "mg/d")));
        }

        /// <summary>
        /// 'mg/d' and 'mg.d-1' are two spellings of one unit, so no conversion changes any value - but
        /// the unit strings differ, which is what sends the comparison down the conversion path.
        /// </summary>
        [TestMethod]
        public void Greater_SameUnitDifferentUcumSpelling_ComparesTheValues()
        {
            Assert.AreEqual(true, Context.Operators.Greater(Q(0.25m, "mg/d"), Q(0.125m, "mg.d-1")));
            Assert.AreEqual(false, Context.Operators.Greater(Q(0.125m, "mg.d-1"), Q(0.25m, "mg/d")));
            Assert.AreEqual(true, Context.Operators.Equal(Q(0.25m, "mg/d"), Q(0.25m, "mg.d-1")));
            Assert.AreEqual(true, Context.Operators.Greater(Q(25.1m, "kg/m2"), Q(25m, "kg.m-2")));
        }

        /// <summary>
        /// Equivalence rounds to "the precision of the least precise operand" (ibid., section
        /// "5.2 Equivalent"), so neither operand may inherit the other's precision from the alignment.
        /// Two spellings of one unit carry the same factor and are therefore compared as authored,
        /// which is what makes the answer independent of the operand order; a genuine conversion has
        /// the padding the metric service adds stripped back off.
        /// </summary>
        [TestMethod]
        public void Equivalent_CanonicalOperandBelowDecimalStepSize_RoundsToTheAuthoredPrecision()
        {
            Assert.IsTrue(Context.Operators.Equivalent(Q(0.0000000028935185185185185185m, "g.s-1"), Q(0.25m, "mg/d")));
            Assert.IsTrue(Context.Operators.Equivalent(Q(0.25m, "mg/d"), Q(0.25m, "mg.d-1")));

            // 0.2501 rounded to the two decimal places of the least precise operand is 0.25.
            Assert.IsTrue(Context.Operators.Equivalent(Q(0.25m, "mg/d"), Q(0.2501m, "mg.d-1")));
            Assert.IsTrue(Context.Operators.Equivalent(Q(0.2501m, "mg.d-1"), Q(0.25m, "mg/d")));

            // Across a genuine conversion, in both operand orders: 1000.4 'mg' is 1.0004 'g', which
            // rounds to the single decimal place of 1.0 'g'.
            Assert.IsTrue(Context.Operators.Equivalent(Q(1.0m, "g"), Q(1000.4m, "mg")));
            Assert.IsTrue(Context.Operators.Equivalent(Q(1000.4m, "mg"), Q(1.0m, "g")));
        }

        [TestMethod]
        public void Compare_CommensurableUnits_StillConvertsBeforeComparing()
        {
            Assert.AreEqual(true, Context.Operators.Equal(Q(1m, "mg"), Q(0.001m, "g")));
            Assert.AreEqual(true, Context.Operators.Equal(Q(1000m, "mg"), Q(1m, "g")));
            Assert.AreEqual(true, Context.Operators.Greater(Q(1m, "g"), Q(1m, "mg")));
            Assert.AreEqual(true, Context.Operators.Less(Q(1m, "cm"), Q(1m, "m")));
            Assert.AreEqual(true, Context.Operators.Equal(Q(1m, "[in_i]"), Q(2.54m, "cm")));
            Assert.AreEqual(true, Context.Operators.Equal(Q(1m, "mg/dL"), Q(10m, "mg/L")));
            Assert.IsTrue(Context.Operators.Equivalent(Q(1m, "mg"), Q(0.001m, "g")));
        }

        /// <summary>
        /// CQL calendar duration units keep their 1-to-1 mapping onto the UCUM equivalents.
        /// </summary>
        [TestMethod]
        public void Compare_CalendarDurationUnits_AreUnaffected()
        {
            Assert.AreEqual(true, Context.Operators.Equal(Q(1m, "wk"), Q(7m, "d")));
            Assert.AreEqual(true, Context.Operators.Equal(Q(1m, "day"), Q(24m, "h")));
            Assert.IsTrue(Context.Operators.Equivalent(Q(1m, "wk"), Q(7m, "d")));

            // Equivalence between a calendar duration above days and its definite-time UCUM counterpart
            // is explicit in the spec: "1 year ~ 1 'a'" (ibid., section "5.2 Equivalent").
            Assert.IsTrue(Context.Operators.Equivalent(Q(1m, "a"), Q(1m, "year")));

            // Equality of the same pair should be null - "UCUM definite-time duration quantities above
            // days (and weeks) are not comparable to calendar duration quantities above days (and
            // weeks)" (ibid., section "5.1 Equal") - but this comparer maps 'year' onto 'a' for equality
            // too and answers true. That deviation predates the unit alignment this class covers and
            // still needs a tracking issue; it is deliberately left unasserted either way, so that
            // fixing it does not have to fight this test.
        }

        /// <summary>
        /// "Attempting to operate on quantities with invalid units will result in a null" (ibid.,
        /// section "5.4 Greater"). Equivalence "will always return true or false" (ibid., section
        /// "5.2 Equivalent"), so it answers false rather than null - spec example: 3.5 'cm2' ~ 3.5 'cm'.
        /// </summary>
        [TestMethod]
        public void Compare_IncommensurableOrInvalidUnits_IsUnchanged()
        {
            Assert.IsNull(Context.Operators.Greater(Q(1m, "cm"), Q(1m, "g")));
            Assert.IsNull(Context.Operators.Equal(Q(1m, "cm"), Q(1m, "g")));
            Assert.IsNull(Context.Operators.Equal(Q(5m, "mg"), Q(5m, "no-such-ucum-unit")));
            Assert.IsFalse(Context.Operators.Equivalent(Q(3.5m, "cm2"), Q(3.5m, "cm")));
            Assert.IsFalse(Context.Operators.Equivalent(Q(1m, "cm"), Q(1m, "g")));
        }

        /// <summary>
        /// The default unit '1' matches any other unit without conversion, and equal unit strings never
        /// reach the conversion path at all.
        /// </summary>
        [TestMethod]
        public void Compare_DefaultUnitAndIdenticalUnits_TakeTheDirectPath()
        {
            Assert.AreEqual(true, Context.Operators.Equal(Q(1m, "1"), Q(1m, "mg")));
            Assert.AreEqual(true, Context.Operators.Equal(Q(1m, "mg"), Q(1m, "mg")));
            Assert.AreEqual(true, Context.Operators.Greater(Q(0.25m, "mg/d"), Q(0.125m, "mg/d")));
            Assert.AreEqual(true, Context.Operators.Equal(Q(160m, "mm[Hg]"), Q(160m, "mm[Hg]")));
        }

        /// <summary>
        /// Equality canonicalizes for hashing, so two quantities that compare equal across units have to
        /// land in the same bucket for the HashSet-based operators (Distinct, Union, Except).
        /// </summary>
        [TestMethod]
        public void Distinct_EqualQuantitiesAcrossUnits_Deduplicate()
        {
            var distinct = Context.Operators.Distinct<CqlQuantity>([Q(1m, "mg"), Q(0.001m, "g"), Q(1000m, "mg")]);

            Assert.IsNotNull(distinct);
            Assert.AreEqual(2, distinct!.Count());
        }

        /// <summary>
        /// Equality truncates both values to the CQL Decimal scale, so two quantities that differ only
        /// below the step size are equal and Distinct has to collapse them into one - whatever their
        /// unit is relative to its UCUM base: finer ('mg'), coarser ('kg', 'd'), or not UCUM at all.
        /// </summary>
        [TestMethod]
        [DataRow("mg")]
        [DataRow("kg")]
        [DataRow("d")]
        [DataRow("mg/d")]
        [DataRow("no-such-ucum-unit")]
        public void Distinct_SameUnitDifferingBelowDecimalStepSize_Deduplicates(string unit)
        {
            var comparers = new CqlComparers();
            var x = Q(70.000000001m, unit);
            var y = Q(70.000000002m, unit);

            Assert.AreEqual(true, comparers.Equals(x, y, null));

            var distinct = Context.Operators.Distinct<CqlQuantity>([x, y]);
            Assert.IsNotNull(distinct);
            Assert.AreEqual(1, distinct!.Count());
        }

        /// <summary>
        /// Distinct has to follow equality in both directions: quantities equal across a unit conversion
        /// collapse into one, and quantities that differ at or above the step size are both kept. Only
        /// the first direction constrains the hash - unequal values are free to share a bucket - so it
        /// is the set behavior that is asserted here, never the hash codes themselves.
        /// </summary>
        [TestMethod]
        public void Distinct_AcrossUnits_FollowsEquality()
        {
            var comparers = new CqlComparers();

            AssertDistinctCount(1, Q(1m, "mg"), Q(0.001m, "g"));
            AssertDistinctCount(1, Q(1.000000001m, "mg"), Q(0.001m, "g"));
            AssertDistinctCount(1, Q(0.25m, "mg/d"), Q(0.25m, "mg.d-1"));
            AssertDistinctCount(1, Q(1.0m, "cm"), Q(1.00m, "cm"));

            // Equal because the comparison happens in 'mg', where neither value loses a digit to the
            // truncation, while 'g' alone would drop the 4 below the step size.
            Assert.AreEqual(true, comparers.Equals(Q(1.000000004m, "g"), Q(1000.000004m, "mg"), null));
            AssertDistinctCount(1, Q(1.000000004m, "g"), Q(1000.000004m, "mg"));

            Assert.AreEqual(false, comparers.Equals(Q(70.00000001m, "kg"), Q(70.00000002m, "kg"), null));
            AssertDistinctCount(2, Q(70.00000001m, "kg"), Q(70.00000002m, "kg"));

            static void AssertDistinctCount(int expected, CqlQuantity x, CqlQuantity y)
            {
                var distinct = Context.Operators.Distinct<CqlQuantity>([x, y]);
                Assert.IsNotNull(distinct);
                Assert.AreEqual(expected, distinct!.Count());
            }
        }

        /// <summary>
        /// A metric service that canonicalizes but will not convert between two units directly leaves the
        /// canonical form as the only common ground, and the alignment falls back to it rather than
        /// answering null: the two quantities are commensurable, so the spec has an answer to give
        /// ("the dimensions of each quantity must be the same, but not necessarily the unit", ibid.,
        /// section "5.1 Equal"), and null is reserved for units that do not reduce to a common base.
        /// The fallback carries the rescaling this alignment exists to avoid, so it answers correctly
        /// only while the canonical values stay above the CQL Decimal step size.
        /// </summary>
        [TestMethod]
        public void Compare_ServiceThatWillNotConvertBetweenUnits_FallsBackToTheCanonicalForm()
        {
            var comparers = new CqlComparers(new CanonicalizeOnlyMetricService());

            // Canonicalizing 'g' and 'mg' lands both on 1 'g', which is well above the step size.
            Assert.AreEqual(true, comparers.Equals(Q(1m, "g"), Q(1000m, "mg"), null));
            Assert.AreEqual(1, comparers.Compare(Q(2m, "g"), Q(1000m, "mg"), null));
            Assert.AreEqual(-1, comparers.Compare(Q(1000m, "mg"), Q(2m, "g"), null));

            // Incommensurable units are still null, so the fallback has not swallowed that answer.
            Assert.IsNull(comparers.Compare(Q(1m, "cm"), Q(1m, "g"), null));

            // The cost of the fallback, asserted so that it is visible rather than discovered: canonical
            // 'mg/d' and 'ug/d' are both below the step size, where the Decimal comparer answers 0 for
            // every pair. This is the defect the unit alignment removes for a service that does convert.
            Assert.AreEqual(true, comparers.Equals(Q(0.25m, "mg/d"), Q(125m, "ug/d"), null));
            Assert.AreEqual(true, comparers.Equals(Q(0.25m, "mg/d"), Q(500m, "ug/d"), null));
        }

        /// <summary>
        /// Canonicalizes through the real UCUM service but refuses every direct unit-to-unit conversion,
        /// which is the shape of a service that knows a unit without knowing how to rescale into it.
        /// </summary>
#pragma warning disable CS8767 // IMetricService is compiled without full NRT annotations; this stub matches the production implementation.
        private sealed class CanonicalizeOnlyMetricService : IMetricService
        {
            private static readonly FhirMetricService Ucum = new();

            public bool TryCanonicalize((string value, string unit, string? codesystem) quantity, out (string value, string unit, string? codesystem)? canonical) =>
                Ucum.TryCanonicalize(quantity, out canonical);

            public bool TryConvertTo((string value, string unit, string? codesystem) quantity, string targetUnit, out (string value, string unit, string? codesystem)? result) =>
                Fail(out result);

            public bool TryAdd((string value, string unit, string? codesystem) x, (string value, string unit, string? codesystem) y, out (string value, string unit, string? codesystem)? result) =>
                Fail(out result);

            public bool TrySubtract((string value, string unit, string? codesystem) x, (string value, string unit, string? codesystem) y, out (string value, string unit, string? codesystem)? result) =>
                Fail(out result);

            public bool TryMultiply((string value, string unit, string? codesystem) x, (string value, string unit, string? codesystem) y, out (string value, string unit, string? codesystem)? result) =>
                Fail(out result);

            public bool TryDivide((string value, string unit, string? codesystem) x, (string value, string unit, string? codesystem) y, out (string value, string unit, string? codesystem)? result) =>
                Fail(out result);

            public bool TryCompare((string value, string unit, string? codesystem) x, (string value, string unit, string? codesystem) y, out int? result)
            {
                result = null;
                return false;
            }

            private static bool Fail(out (string value, string unit, string? codesystem)? result)
            {
                result = null;
                return false;
            }
        }
#pragma warning restore CS8767
    }
}
