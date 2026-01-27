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
        /// Bidirectional mapping between CQL calendar duration units and their UCUM equivalents.
        /// See https://github.com/FirelyTeam/firely-cql-sdk/issues/1084#issuecomment-3718899170
        /// </summary>
        private static readonly Dictionary<string, string> CalendarDurationMapping = InitializeCalendarDurationMapping();

        /// <summary>
        /// Try to canonicalize the system type quantity to Umum base quantity. So a 1,000 cm will be 10 m. Or an inch will be converted to a meter.
        /// </summary>
        /// <param name="quantity">A system type Quantity of system Ucum</param>
        /// <param name="canonicalizedQuantity">The converted system type Quantity when the conversion was a success.</param>
        /// <returns><c>true</c> when the conversion succeeded. Or <c>false</c> otherwise.</returns>
        public static bool TryCanonicalize(this CqlQuantity quantity, out CqlQuantity? canonicalizedQuantity)
        {
            if (quantity is not { value: { } quantityValue, unit: { } quantityUnit })
            {
                canonicalizedQuantity = null;
                return false;
            }
            // Convert CQL calendar duration units to UCUM equivalents before canonicalization
            // This ensures units like "week" are converted to "wk" before passing to Fhir.Metrics
            if (CalendarDurationMapping.TryGetValue(quantityUnit, out var ucumUnit))
            {
                quantityUnit = ucumUnit;
            }

            try
            {
                M.Quantity metricsQuantity = quantityValue.toUnitsOfMeasureQuantity(quantityUnit);
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
            if (quantity.value is not {} quantityValue) throw new ArgumentException("Quantity should have a value for UCUM conversion.", nameof(quantity));
            if (quantity.unit is not {} quantityUnit) throw new ArgumentException("Quantity should have a unit for UCUM conversion.", nameof(quantity));

            // Special handling for FHIR calendar duration units - perform 1-to-1 mapping
            // This follows FHIRPath's simplification for time-valued quantities
            if (HasAssumedSameCalendarUnits(quantityUnit, unit))
            {
                convertedQuantity = new(quantityValue, unit);
                return true;
            }

            try
            {
                M.Quantity metricsQuantity = quantityValue.toUnitsOfMeasureQuantity(quantityUnit);
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
        /// Initializes the bidirectional mapping between CQL calendar duration units and UCUM units.
        /// This implements the FHIR simplification where calendar duration units are treated as equivalent
        /// for conversion purposes. See https://github.com/FirelyTeam/firely-cql-sdk/issues/1084#issuecomment-3718899170
        /// for the specification of which units should be mapped.
        /// </summary>
        private static Dictionary<string, string> InitializeCalendarDurationMapping()
        {
            var mapping = new Dictionary<string, string>(StringComparer.Ordinal);

            void AddMappingSingularAndPlural(string cqlUnitSingular, string ucumUnit)
            {
                var cqlUnitPlural = $"{cqlUnitSingular}s"; // In these cases, plural is just adding 's'
                mapping[cqlUnitSingular] = ucumUnit;
                mapping[cqlUnitPlural] = ucumUnit;
            }

            // Add all calendar duration unit mappings
            // Based on https://hl7.org/fhirpath/N1/#time-valued-quantities
            AddMappingSingularAndPlural("year", "a");
            AddMappingSingularAndPlural("month", "mo");
            AddMappingSingularAndPlural("week", "wk");
            AddMappingSingularAndPlural("day", "d");
            AddMappingSingularAndPlural("hour", "h");
            AddMappingSingularAndPlural("minute", "min");
            AddMappingSingularAndPlural("second", "s");
            AddMappingSingularAndPlural("millisecond", "ms");
            
            return mapping;
        }

        /// <summary>
        /// Determines whether the specified CQL calendar unit and UCUM unit are assumed to represent the same calendar
        /// duration.
        /// </summary>
        /// <remarks>This method checks for a known mapping between CQL calendar units and UCUM units,
        /// using a case-insensitive comparison. Use this method to verify compatibility when converting or comparing
        /// calendar-based durations between CQL and UCUM representations.</remarks>
        /// <param name="fromCqlUnit">The calendar unit as defined in CQL to compare. Cannot be null.</param>
        /// <param name="toUcumUnit">The UCUM unit to compare against the CQL calendar unit. Cannot be null.</param>
        /// <returns>true if the CQL calendar unit and UCUM unit are assumed to represent the same calendar duration; otherwise,
        /// false.</returns>
        private static bool HasAssumedSameCalendarUnits(string fromCqlUnit, string toUcumUnit)
        {
            var isCalendarUnitsAssumedSame =
                CalendarDurationMapping.TryGetValue(fromCqlUnit, out var expectedToUnit)
                && string.Equals(expectedToUnit, toUcumUnit, StringComparison.OrdinalIgnoreCase);
            return isCalendarUnitsAssumedSame;
        }

        private static M.Quantity toUnitsOfMeasureQuantity(this decimal value, string unit)
        {
            var metric = SYSTEM.Metric(unit);
            return new M.Quantity(value, metric);
        }
    }
}
