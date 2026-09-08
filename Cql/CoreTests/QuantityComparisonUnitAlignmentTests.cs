/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

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
        /// "5.2 Equivalent"), so the operand already carrying the target unit must be left alone: asking
        /// the metric service to convert a value into its own unit pads it out to the service's working
        /// scale, and a padded operand stops being the least precise one.
        /// </summary>
        [TestMethod]
        public void Equivalent_CanonicalOperandBelowDecimalStepSize_RoundsToTheAuthoredPrecision()
        {
            Assert.IsTrue(Context.Operators.Equivalent(Q(0.0000000028935185185185185185m, "g.s-1"), Q(0.25m, "mg/d")));
            Assert.IsTrue(Context.Operators.Equivalent(Q(0.25m, "mg/d"), Q(0.25m, "mg.d-1")));
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
            Assert.AreEqual(true, Context.Operators.Equal(Q(1m, "a"), Q(1m, "year")));
            Assert.IsTrue(Context.Operators.Equivalent(Q(1m, "wk"), Q(7m, "d")));
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
        /// below the step size are equal and have to hash alike - in the quantity's own unit, whether that
        /// unit is finer than its UCUM base ('mg'), coarser than it ('kg', 'd'), or not UCUM at all.
        /// Hashing the canonical value untruncated put such pairs in different buckets, so Distinct kept
        /// both.
        /// </summary>
        [TestMethod]
        [DataRow("mg")]
        [DataRow("kg")]
        [DataRow("d")]
        [DataRow("mg/d")]
        [DataRow("no-such-ucum-unit")]
        public void GetHashCode_SameUnitDifferingBelowDecimalStepSize_HashesAlike(string unit)
        {
            var comparers = new CqlComparers();
            var x = Q(70.000000001m, unit);
            var y = Q(70.000000002m, unit);

            Assert.AreEqual(true, comparers.Equals(x, y, null));
            Assert.AreEqual(comparers.GetHashCode(x), comparers.GetHashCode(y));

            var distinct = Context.Operators.Distinct<CqlQuantity>([x, y]);
            Assert.IsNotNull(distinct);
            Assert.AreEqual(1, distinct!.Count());
        }

        /// <summary>
        /// The truncation must not cost the cross-unit buckets: quantities equal across a unit conversion
        /// keep hashing alike, and quantities that differ at or above the step size keep hashing apart.
        /// </summary>
        [TestMethod]
        public void GetHashCode_EqualAcrossUnitsAndDistinctAboveStepSize_FollowsEquality()
        {
            var comparers = new CqlComparers();

            Assert.AreEqual(comparers.GetHashCode(Q(1m, "mg")), comparers.GetHashCode(Q(0.001m, "g")));
            Assert.AreEqual(comparers.GetHashCode(Q(1.000000001m, "mg")), comparers.GetHashCode(Q(0.001m, "g")));
            Assert.AreEqual(comparers.GetHashCode(Q(0.25m, "mg/d")), comparers.GetHashCode(Q(0.25m, "mg.d-1")));
            Assert.AreEqual(comparers.GetHashCode(Q(1.0m, "cm")), comparers.GetHashCode(Q(1.00m, "cm")));

            Assert.AreEqual(false, comparers.Equals(Q(70.00000001m, "kg"), Q(70.00000002m, "kg"), null));
            Assert.AreNotEqual(comparers.GetHashCode(Q(70.00000001m, "kg")), comparers.GetHashCode(Q(70.00000002m, "kg")));
        }
    }
}
