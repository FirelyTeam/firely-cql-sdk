/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;
using M = global::Fhir.Metrics;

namespace CoreTests
{
    [TestClass]
    public class UcumTests
    {
        private static readonly M.IMetricService Service = UcumConversionExtensions.Default;

        [TestMethod]
        public void NormalizesPrefixes()
        {
            var q = new CqlQuantity(3.14M, "kg");
            var success = q.TryCanonicalize(Service, out var canonical);
            success.Should().BeTrue();
            canonical.unit.Should().Be("g");
            canonical.value.Should().Be(3.14M * 1000.0M);

            q = new CqlQuantity(2.5M, "h");
            success = q.TryCanonicalize(Service, out canonical);
            success.Should().BeTrue();
            canonical.unit.Should().Be("s");
            canonical.value.Should().Be(2.5M * 60.0M * 60.0M);
        }

        [TestMethod]
        public void ConvertsUnits()
        {
            var q = new CqlQuantity(3.14M, "kg");
            var success = q.TryConvert("g", Service, out var converted);
            success.Should().BeTrue();
            converted.unit.Should().Be("g");
            converted.value.Should().Be(3.14M * 1000.0M);
        }

        #region Calendar Duration Unit Conversions (FHIR simplification)

        [DataTestMethod]
        [DataRow("year", "a")]
        [DataRow("month", "mo")]
        [DataRow("week", "wk")]
        [DataRow("day", "d")]
        [DataRow("hour", "h")]
        [DataRow("minute", "min")]
        [DataRow("second", "s")]
        [DataRow("millisecond", "ms")]
        public void ConvertCalendarDuration_CqlToUcum(string cqlUnit, string ucumUnit)
        {
            var q = new CqlQuantity(1m, cqlUnit);
            var success = q.TryConvert(ucumUnit, Service, out var converted);
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(1m);
            converted.unit.Should().Be(ucumUnit);
        }

        [TestMethod]
        public void ConvertInvalidCalendarDuration_ReturnsFalse()
        {
            // Test that converting from "day" to something that's not "d" doesn't use the calendar mapping
            // and falls back to standard UCUM conversion (which would fail for this case)
            var q = new CqlQuantity(1m, "day");
            var success = q.TryConvert("hour", Service, out var converted);

            // This should fail because "day" is not a valid UCUM unit for the standard conversion path
            success.Should().BeFalse();
            converted.Should().BeNull();
        }

        #endregion

        #region Plural Calendar Duration Unit Conversions

        [DataTestMethod]
        [DataRow("years", "a")]
        [DataRow("months", "mo")]
        [DataRow("weeks", "wk")]
        [DataRow("days", "d")]
        [DataRow("hours", "h")]
        [DataRow("minutes", "min")]
        [DataRow("seconds", "s")]
        [DataRow("milliseconds", "ms")]
        public void ConvertCalendarDuration_PluralCqlToUcum(string cqlUnit, string ucumUnit)
        {
            var q = new CqlQuantity(5m, cqlUnit);
            var success = q.TryConvert(ucumUnit, Service, out var converted);
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(5m);
            converted.unit.Should().Be(ucumUnit);
        }

        [DataTestMethod]
        [DataRow("years", "a")]
        [DataRow("months", "mo")]
        [DataRow("weeks", "wk")]
        [DataRow("days", "d")]
        [DataRow("hours", "h")]
        [DataRow("minutes", "min")]
        [DataRow("seconds", "s")]
        [DataRow("milliseconds", "ms")]
        public void CanonicalizeCalendarDuration_PluralForm(string pluralUnit, string ucumUnit)
        {
            var q = new CqlQuantity(10m, pluralUnit);
            var success = q.TryCanonicalize(Service, out var canonical);
            success.Should().BeTrue();
            canonical.Should().NotBeNull();
            // All time units should canonicalize to seconds
            canonical!.unit.Should().Be("s");
        }

        [DataTestMethod]
        [DataRow("week", "weeks")]
        [DataRow("day", "days")]
        [DataRow("hour", "hours")]
        [DataRow("month", "months")]
        [DataRow("year", "years")]
        public void CanonicalizeCalendarDuration_SingularAndPluralEquivalent(string singular, string plural)
        {
            var q1 = new CqlQuantity(7m, singular);
            var q2 = new CqlQuantity(7m, plural);

            var success1 = q1.TryCanonicalize(Service, out var canonical1);
            var success2 = q2.TryCanonicalize(Service, out var canonical2);

            success1.Should().BeTrue();
            success2.Should().BeTrue();
            canonical1.Should().NotBeNull();
            canonical2.Should().NotBeNull();

            // Both should canonicalize to the same unit and value
            canonical1!.unit.Should().Be(canonical2!.unit);
            canonical1.value.Should().Be(canonical2.value);
        }

        [TestMethod]
        public void ConvertCalendarDuration_PreservesDecimalPrecision_Plural()
        {
            var q = new CqlQuantity(37.5m, "weeks");
            var success = q.TryConvert("wk", Service, out var converted);
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(37.5m);
            converted.unit.Should().Be("wk");
        }

        #endregion
    }
}
