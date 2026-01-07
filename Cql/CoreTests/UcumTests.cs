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

        [TestMethod]
        public void ConvertCalendarDuration_Day_To_D()
        {
            var q = new CqlQuantity(5m, "day");
            var success = q.TryConvert("d", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(5m);
            converted.unit.Should().Be("d");
        }

        [TestMethod]
        public void ConvertCalendarDuration_D_To_Day()
        {
            var q = new CqlQuantity(3m, "d");
            var success = q.TryConvert("day", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(3m);
            converted.unit.Should().Be("day");
        }

        [TestMethod]
        public void ConvertCalendarDuration_Month_To_Mo()
        {
            var q = new CqlQuantity(2m, "month");
            var success = q.TryConvert("mo", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(2m);
            converted.unit.Should().Be("mo");
        }

        [TestMethod]
        public void ConvertCalendarDuration_Mo_To_Month()
        {
            var q = new CqlQuantity(2m, "mo");
            var success = q.TryConvert("month", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(2m);
            converted.unit.Should().Be("month");
        }

        [TestMethod]
        public void ConvertCalendarDuration_Year_To_A()
        {
            var q = new CqlQuantity(1m, "year");
            var success = q.TryConvert("a", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(1m);
            converted.unit.Should().Be("a");
        }

        [TestMethod]
        public void ConvertCalendarDuration_A_To_Year()
        {
            var q = new CqlQuantity(1m, "a");
            var success = q.TryConvert("year", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(1m);
            converted.unit.Should().Be("year");
        }

        [TestMethod]
        public void ConvertCalendarDuration_Week_To_Wk()
        {
            var q = new CqlQuantity(4m, "week");
            var success = q.TryConvert("wk", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(4m);
            converted.unit.Should().Be("wk");
        }

        [TestMethod]
        public void ConvertCalendarDuration_Hour_To_H()
        {
            var q = new CqlQuantity(24m, "hour");
            var success = q.TryConvert("h", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(24m);
            converted.unit.Should().Be("h");
        }

        [TestMethod]
        public void ConvertCalendarDuration_Minute_To_Min()
        {
            var q = new CqlQuantity(60m, "minute");
            var success = q.TryConvert("min", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(60m);
            converted.unit.Should().Be("min");
        }

        [TestMethod]
        public void ConvertCalendarDuration_Second_To_S()
        {
            var q = new CqlQuantity(30m, "second");
            var success = q.TryConvert("s", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(30m);
            converted.unit.Should().Be("s");
        }

        [TestMethod]
        public void ConvertCalendarDuration_Millisecond_To_Ms()
        {
            var q = new CqlQuantity(1000m, "millisecond");
            var success = q.TryConvert("ms", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(1000m);
            converted.unit.Should().Be("ms");
        }

        [TestMethod]
        public void ConvertCalendarDuration_IsCaseInsensitive()
        {
            // Test that the calendar duration mapping is case-insensitive
            var q = new CqlQuantity(5m, "DAY");
            var success = q.TryConvert("D", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(5m);
            converted.unit.Should().Be("D");
        }

        [TestMethod]
        public void ConvertCalendarDuration_PreservesDecimalPrecision()
        {
            // Ensure that fractional values are preserved in 1-to-1 mappings
            var q = new CqlQuantity(2.5m, "day");
            var success = q.TryConvert("d", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            converted!.value.Should().Be(2.5m);
            converted.unit.Should().Be("d");
        }

        [TestMethod]
        public void ConvertNonCalendarDuration_UsesStandardUcumConversion()
        {
            // Test that non-calendar duration units still use the standard UCUM conversion
            // For example, converting between actual UCUM units like "kg" to "g"
            var q = new CqlQuantity(1m, "kg");
            var success = q.TryConvert("g", out var converted);
            
            success.Should().BeTrue();
            converted.Should().NotBeNull();
            // Standard UCUM conversion: 1 kg = 1000 g
            converted!.value.Should().Be(1000m);
            converted.unit.Should().Be("g");
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
