/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;

namespace CoreTests
{
    [TestClass]
    public class UcumTests
    {
        [TestMethod]
        public void NormalizesPrefixes()
        {
            var q = new CqlQuantity(3.14M, "kg");
            var success = q.TryCanonicalize(out var canonical);
            success.Should().BeTrue();
            canonical.unit.Should().Be("g");
            canonical.value.Should().Be(3.14M * 1000.0M);

            q = new CqlQuantity(2.5M, "h");
            success = q.TryCanonicalize(out canonical);
            success.Should().BeTrue();
            canonical.unit.Should().Be("s");
            canonical.value.Should().Be(2.5M * 60.0M * 60.0M);
        }

        [TestMethod, Ignore]
        public void ConvertsUnits()
        {
            var q = new CqlQuantity(3.14M, "kg");
            var success = q.TryConvert("g", out var converted);
            success.Should().BeTrue();
            converted.unit.Should().Be("g");
            converted.value.Should().Be(3.14M * 1000.0M * 1000.0M);
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
            var success = q.TryConvert(ucumUnit, out var converted);
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
            var success = q.TryConvert("hour", out var converted);

            // This should fail because "day" is not a valid UCUM unit for the standard conversion path
            success.Should().BeFalse();
            converted.Should().BeNull();
        }

        #endregion
    }
}
