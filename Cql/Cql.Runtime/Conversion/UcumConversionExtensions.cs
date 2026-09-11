/*
 * Copyright (c) 2023, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-net-sdk/master/LICENSE
 */

using System.Collections.Generic;
using Hl7.Cql.Primitives;
using M = Fhir.Metrics;

namespace Hl7.Cql.Conversion
{
    /// <summary>
    /// Utility functions for working with Firely's UCUM library, which allows full support for conversions within the UCUM unit system.
    /// </summary>
    internal static class UcumConversionExtensions
    {
        internal const string UcumSystemUrl = "http://unitsofmeasure.org";

        /// <summary>
        /// The default <see cref="M.IMetricService"/> used when no custom service is injected.
        /// </summary>
        internal static M.IMetricService Default { get; } = new DefaultUcumMetricService();

        /// <summary>
        /// Bidirectional mapping between CQL calendar duration units and their UCUM equivalents.
        /// See https://github.com/FirelyTeam/firely-cql-sdk/issues/1084#issuecomment-3718899170
        /// </summary>
        private static readonly Dictionary<string, string> CalendarDurationMapping = InitializeCalendarDurationMapping();

        /// <summary>
        /// Try to canonicalize the system type quantity to Ucum base quantity using the supplied metric service.
        /// So a 1,000 cm will be 10 m. Or an inch will be converted to a meter.
        /// </summary>
        /// <param name="quantity">A system type Quantity of system Ucum</param>
        /// <param name="service">The <see cref="M.IMetricService"/> to use for the conversion.</param>
        /// <param name="canonicalizedQuantity">The converted system type Quantity when the conversion was a success.</param>
        /// <returns><c>true</c> when the conversion succeeded. Or <c>false</c> otherwise.</returns>
        public static bool TryCanonicalize(this CqlQuantity quantity, M.IMetricService service, out CqlQuantity? canonicalizedQuantity)
        {
            if (quantity is not { value: { } quantityValue, unit: { } quantityUnit })
            {
                canonicalizedQuantity = null;
                return false;
            }

            // Convert CQL calendar duration units to UCUM equivalents before canonicalization.
            // This ensures units like "week" are converted to "wk" before passing to IMetricService.
            if (CalendarDurationMapping.TryGetValue(quantityUnit, out var ucumUnit))
                quantityUnit = ucumUnit;

            // Call the decimal overload from MetricServiceExtensions explicitly to avoid extension method resolution ambiguity.
            if (M.MetricServiceExtensions.TryCanonicalize(service, (quantityValue, quantityUnit, UcumSystemUrl), out var canonical))
            {
                canonicalizedQuantity = new(canonical!.Value.Item1, canonical.Value.Item2);
                return true;
            }

            canonicalizedQuantity = null;
            return false;
        }

        /// <summary>
        /// Try to convert a quantity to another unit using the supplied metric service.
        /// </summary>
        /// <remarks>
        /// This method implements special handling for FHIR calendar duration units, following the FHIRPath specification
        /// (https://hl7.org/fhirpath/N1/#time-valued-quantities and https://fhir.hl7.org/fhir/fhirpath.html#quantity).
        ///
        /// When converting between CQL calendar duration units (year, month, week, day, hour, minute, second, millisecond)
        /// and their UCUM equivalents (a, mo, wk, d, h, min, s, ms), the conversion is performed as a 1-to-1 mapping
        /// without using the metric service. This aligns with FHIR's simplification that these units
        /// are treated as equivalent for conversion purposes, even though semantically "1 a != 1 year" but "1 a ~ 1 year" in CQL.
        ///
        /// For all other unit conversions, the supplied <see cref="M.IMetricService"/> is used.
        /// </remarks>
        /// <returns>false if the conversion was not possible, true otherwise.</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool TryConvert(this CqlQuantity quantity, string unit, M.IMetricService service, out CqlQuantity? convertedQuantity)
        {
            if (quantity.value is not { } quantityValue) throw new ArgumentException("Quantity should have a value for UCUM conversion.", nameof(quantity));
            if (quantity.unit is not { } quantityUnit) throw new ArgumentException("Quantity should have a unit for UCUM conversion.", nameof(quantity));

            // Special handling for FHIR calendar duration units - perform 1-to-1 mapping.
            // This follows FHIRPath's simplification for time-valued quantities.
            if (HasAssumedSameCalendarUnits(quantityUnit, unit))
            {
                convertedQuantity = new(quantityValue, unit);
                return true;
            }

            // Call the decimal overload from MetricServiceExtensions explicitly to avoid extension method resolution ambiguity.
            if (M.MetricServiceExtensions.TryConvertTo(service, (quantityValue, quantityUnit, UcumSystemUrl), unit, out var converted))
            {
                convertedQuantity = new(converted!.Value.Item1, converted.Value.Item2);
                return true;
            }

            convertedQuantity = null;
            return false;
        }

        /// <summary>
        /// Brings two commensurable quantities into a single common unit, so that their values may be compared or
        /// combined without the rescaling that canonicalization applies.
        /// </summary>
        /// <remarks>
        /// Commensurability is decided on the canonical form, because <c>TryCanonicalize</c> succeeds for any valid
        /// UCUM unit: the canonical units have to agree before two values mean anything to each other, or the
        /// comparison would answer as if both quantities were dimensionless (1 'cm' = 0.01 'g').
        /// <para>
        /// The common unit is the finer of the two operand units - the one whose single unit has the smaller canonical
        /// value - and deliberately not the canonical base unit. Canonicalizing rescales a value by its unit's factor,
        /// and for a clinical unit far from its base that factor drives the value below the step size of the CQL
        /// Decimal type: 0.25 'mg/d' canonicalizes to 0.0000000028935185 'g.s-1', where a Decimal has "a <i>scale</i>
        /// (meaning number of possible digits to the right of the decimal) of 8 [...] with a step size of 10^-8"
        /// (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, 1.1 Decimal). Every quantity in a clinical range then
        /// quantizes to zero and compares equal to every other. The operand units are the scale the values were
        /// authored at, so Decimal quantization is meaningful there, and the finer of the two preserves the larger
        /// magnitudes and hence the most significant digits.
        /// </para>
        /// </remarks>
        /// <param name="x">The first quantity.</param>
        /// <param name="y">The second quantity.</param>
        /// <param name="service">The <see cref="M.IMetricService"/> to use for the conversions.</param>
        /// <param name="alignedX"><paramref name="x"/> expressed in the common unit, when this method returns <see langword="true"/>.</param>
        /// <param name="alignedY"><paramref name="y"/> expressed in the common unit, when this method returns <see langword="true"/>.</param>
        /// <returns><see langword="true"/> when both quantities could be expressed in one common unit; otherwise <see langword="false"/>.</returns>
        internal static bool TryAlignUnits(
            this CqlQuantity x,
            CqlQuantity y,
            M.IMetricService service,
            out CqlQuantity? alignedX,
            out CqlQuantity? alignedY)
        {
            alignedX = null;
            alignedY = null;

            if (!x.TryCanonicalize(service, out var canonicalX)
                || !y.TryCanonicalize(service, out var canonicalY)
                || canonicalX!.unit != canonicalY!.unit)
            {
                return false;
            }

            var commonUnit = PickFinerUnit(x.unit!, y.unit!, service);
            if (commonUnit != null
                && TryExpressIn(x, commonUnit, service, out alignedX)
                && TryExpressIn(y, commonUnit, service, out alignedY))
            {
                return true;
            }

            // A unit that canonicalizes but that the service will not convert directly into leaves the canonical
            // form as the only common ground. Its rescaling is what this method exists to avoid, so it is a fallback
            // and never the first choice.
            alignedX = canonicalX;
            alignedY = canonicalY;
            return true;
        }

        /// <summary>
        /// Expresses a quantity in <paramref name="unit"/>, returning it unchanged when it already carries that unit.
        /// </summary>
        /// <remarks>
        /// The shortcut is not only an optimization. Asking the metric service to convert a value into the unit it
        /// already has pads the result out to the service's own working scale (0.25 'mg/d' comes back as
        /// 0.2500000000000000000000000000 'mg/d'), and equivalence rounds to "the precision of the least precise
        /// operand" (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, 5.2 Equivalent). A padded operand is no longer
        /// the least precise one, so the operand that genuinely was authored at two decimal places stops setting the
        /// rounding precision and the comparison starts turning on digits the author never wrote.
        /// </remarks>
        private static bool TryExpressIn(CqlQuantity quantity, string unit, M.IMetricService service, out CqlQuantity? expressed)
        {
            if (string.Equals(quantity.unit, unit, StringComparison.Ordinal))
            {
                expressed = quantity;
                return true;
            }

            return quantity.TryConvert(unit, service, out expressed);
        }

        /// <summary>
        /// Returns whichever of the two units is the finer one - the unit whose single quantity has the smaller
        /// canonical value - or <see langword="null"/> when neither can be canonicalized for the comparison.
        /// </summary>
        private static string? PickFinerUnit(string unitX, string unitY, M.IMetricService service)
        {
            if (string.Equals(unitX, unitY, StringComparison.Ordinal))
                return unitX;

            if (!new CqlQuantity(1m, unitX).TryCanonicalize(service, out var oneX)
                || !new CqlQuantity(1m, unitY).TryCanonicalize(service, out var oneY))
            {
                return null;
            }

            return oneX!.value <= oneY!.value ? unitX : unitY;
        }

        /// <summary>
        /// Returns <see langword="true"/> if both units are CQL calendar duration aliases that map to the same UCUM unit
        /// (e.g., <c>"day"</c> and <c>"days"</c> both map to <c>"d"</c>).
        /// </summary>
        internal static bool AreSameCqlCalendarUnit(string? unitA, string? unitB) =>
            unitA != null && unitB != null
            && CalendarDurationMapping.TryGetValue(unitA, out var ucumA)
            && CalendarDurationMapping.TryGetValue(unitB, out var ucumB)
            && string.Equals(ucumA, ucumB, StringComparison.Ordinal);

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
            return CalendarDurationMapping.TryGetValue(fromCqlUnit, out var expectedToUnit)
                && string.Equals(expectedToUnit, toUcumUnit, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Default <see cref="M.IMetricService"/> implementation used when no custom service is injected.
        /// Delegates all operations to <see cref="M.FhirMetricService"/>.
        /// </summary>
#pragma warning disable CS8767 // IMetricService is compiled without full NRT annotations; delegate implementations match at runtime.
        private sealed class DefaultUcumMetricService : M.IMetricService
        {
            private static readonly M.FhirMetricService _fhirService = new();

            public bool TryCanonicalize((string value, string unit, string? codesystem) quantity, out (string value, string unit, string? codesystem)? canonical)
                => _fhirService.TryCanonicalize(quantity, out canonical);

            public bool TryConvertTo((string value, string unit, string? codesystem) quantity, string targetUnit, out (string value, string unit, string? codesystem)? result)
                => _fhirService.TryConvertTo(quantity, targetUnit, out result);

            public bool TryAdd((string value, string unit, string? codesystem) x, (string value, string unit, string? codesystem) y, out (string value, string unit, string? codesystem)? result)
                => _fhirService.TryAdd(x, y, out result);

            public bool TrySubtract((string value, string unit, string? codesystem) x, (string value, string unit, string? codesystem) y, out (string value, string unit, string? codesystem)? result)
                => _fhirService.TrySubtract(x, y, out result);

            public bool TryMultiply((string value, string unit, string? codesystem) x, (string value, string unit, string? codesystem) y, out (string value, string unit, string? codesystem)? result)
                => _fhirService.TryMultiply(x, y, out result);

            public bool TryDivide((string value, string unit, string? codesystem) x, (string value, string unit, string? codesystem) y, out (string value, string unit, string? codesystem)? result)
                => _fhirService.TryDivide(x, y, out result);

            public bool TryCompare((string value, string unit, string? codesystem) x, (string value, string unit, string? codesystem) y, out int? result)
                => _fhirService.TryCompare(x, y, out result);
        }
#pragma warning restore CS8767
    }
}
