/*
 * Copyright (c) 2023, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-net-sdk/master/LICENSE
 */

using Hl7.Cql.Primitives;
using M = Fhir.Metrics;

namespace Hl7.Cql.Conversion
{
    /// <summary>
    /// Utility functions for working with Firely's UCUM library, which allows full support for conversions within the UCUM unit system.
    /// </summary>
    internal static class Ucum
    {
        private static readonly Lazy<M.SystemOfUnits> _system = new(M.UCUM.Load);
        private static readonly M.SystemOfUnits SYSTEM = _system.Value;

        /// <summary>
        /// Try to canonicalize the system type quantity to Umum base quantity. So a 1,000 cm will be 10 m. Or an inch will be converted to a meter.
        /// </summary>
        /// <param name="quantity">A system type Quantity of system Ucum</param>
        /// <param name="canonicalizedQuantity">The converted system type Quantity when the conversion was a success.</param>
        /// <returns><c>true</c> when the conversion succeeded. Or <c>false</c> otherwise.</returns>
        public static bool TryCanonicalize(this CqlQuantity quantity, out CqlQuantity? canonicalizedQuantity)
        {
            if (quantity.value is null || quantity.unit is null)
            {
                canonicalizedQuantity = null;
                return false;
            }

            try
            {
                M.Quantity metricsQuantity = quantity.value.Value.toUnitsOfMeasureQuantity(quantity.unit);
                metricsQuantity = SYSTEM.Canonical(metricsQuantity);
                canonicalizedQuantity = new(metricsQuantity.Value.ToDecimal(), metricsQuantity.Metric.ToString());
                return true;
            }
            catch (Exception ex) when (ex is ArgumentException or InvalidCastException)
            {
                canonicalizedQuantity = null;
                return false;
            }
        }

        /// <summary>
        /// Try to convert a quantity to another unit.
        /// </summary>
        /// <remarks>
        /// This method implements special handling for FHIR calendar duration units, following the FHIRPath specification
        /// (https://hl7.org/fhirpath/N1/#time-valued-quantities and https://fhir.hl7.org/fhir/fhirpath.html#quantity).
        /// 
        /// When converting between CQL calendar duration units (year, month, week, day, hour, minute, second, millisecond)
        /// and their UCUM equivalents (a, mo, wk, d, h, min, s, ms), the conversion is performed as a 1-to-1 mapping
        /// without using the Fhir.Metrics SYSTEM conversion. This aligns with FHIR's simplification that these units
        /// are treated as equivalent for conversion purposes, even though semantically "1 a != 1 year" but "1 a ~ 1 year" in CQL.
        /// 
        /// For all other unit conversions, the standard UCUM conversion logic is applied.
        /// </remarks>
        /// <returns>false if the conversion was not possible, true otherwise.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool TryConvert(this CqlQuantity quantity, string unit, out CqlQuantity? convertedQuantity)
        {
            if (quantity.value is null) throw new ArgumentException("Quantity should have a value for UCUM conversion.", nameof(quantity));
            if (quantity.unit is null) throw new ArgumentException("Quantity should have a unit for UCUM conversion.", nameof(quantity));

            // Special handling for FHIR calendar duration units - perform 1-to-1 mapping
            // This follows FHIRPath's simplification for time-valued quantities
            var mappedUnit = TryGetCalendarDurationMapping(quantity.unit, unit);
            if (mappedUnit != null)
            {
                convertedQuantity = new(quantity.value.Value, mappedUnit);
                return true;
            }

            try
            {
                M.Quantity metricsQuantity = quantity.value.Value.toUnitsOfMeasureQuantity(quantity.unit);
                metricsQuantity = SYSTEM.Convert(metricsQuantity, unit);
                convertedQuantity = new(metricsQuantity.Value.ToDecimal(), metricsQuantity.Metric.ToString());
                return true;
            }
            catch (Exception ex) when (ex is ArgumentException or InvalidCastException)
            {
                convertedQuantity = null;
                return false;
            }

        }

        /// <summary>
        /// Checks if the conversion is between CQL calendar duration units and their UCUM equivalents,
        /// and returns the target unit if it's a valid 1-to-1 mapping, otherwise returns null.
        /// </summary>
        private static string? TryGetCalendarDurationMapping(string fromUnit, string toUnit)
        {
            // Define the bidirectional mapping between CQL calendar duration units and UCUM units
            // Based on https://hl7.org/fhirpath/N1/#time-valued-quantities
            var mapping = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "year", "a" },
                { "a", "year" },
                { "month", "mo" },
                { "mo", "month" },
                { "week", "wk" },
                { "wk", "week" },
                { "day", "d" },
                { "d", "day" },
                { "hour", "h" },
                { "h", "hour" },
                { "minute", "min" },
                { "min", "minute" },
                { "second", "s" },
                { "s", "second" },
                { "millisecond", "ms" },
                { "ms", "millisecond" }
            };

            // Check if this is a valid calendar duration mapping
            if (mapping.TryGetValue(fromUnit, out var expectedToUnit) &&
                string.Equals(expectedToUnit, toUnit, StringComparison.OrdinalIgnoreCase))
            {
                return toUnit;
            }

            return null;
        }

        private static M.Quantity toUnitsOfMeasureQuantity(this decimal value, string unit)
        {
            var metric = SYSTEM.Metric(unit);
            return new M.Quantity(value, metric);
        }
    }
}
