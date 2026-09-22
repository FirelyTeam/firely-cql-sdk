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
        /// <param name="equivalenceStep">
        /// The step size of the least precise of the two operands, expressed in the common unit, or
        /// <see langword="null"/> when it could not be determined. See <see cref="TryGetEquivalenceStep"/>.
        /// </param>
        /// <returns><see langword="true"/> when both quantities could be expressed in one common unit; otherwise <see langword="false"/>.</returns>
        internal static bool TryAlignUnits(
            this CqlQuantity x,
            CqlQuantity y,
            M.IMetricService service,
            out CqlQuantity? alignedX,
            out CqlQuantity? alignedY,
            out decimal? equivalenceStep)
        {
            alignedX = null;
            alignedY = null;
            equivalenceStep = null;

            if (!x.TryCanonicalize(service, out var canonicalX)
                || !y.TryCanonicalize(service, out var canonicalY)
                || canonicalX!.unit != canonicalY!.unit)
            {
                return false;
            }

            // The metric service does not know the CQL calendar duration aliases ('day', 'weeks'), only
            // their UCUM equivalents, so an operand authored in one has to carry its UCUM spelling into
            // the conversion or nothing below would resolve and every calendar pair would fall through
            // to the canonical form.
            var unitX = ToUcumUnit(x.unit!);
            var unitY = ToUcumUnit(y.unit!);

            // Two spellings of one unit ('mg/d' and 'mg.d-1') carry the same factor, so their values are
            // already in one scale and converting either would only pad it out. Both operands keep the
            // value they were authored with, which is also what keeps the result independent of the
            // operand order: no operand is picked as the conversion target, so neither can be the one
            // whose precision the other inherits.
            if (TryGetUnitFactor(unitX, service, out var factorX)
                && TryGetUnitFactor(unitY, service, out var factorY))
            {
                if (factorX == factorY)
                {
                    alignedX = x;
                    alignedY = y;
                    equivalenceStep = TryGetEquivalenceStep(x, factorX, y, factorY, factorX);
                    return true;
                }

                var (commonUnit, factorCommon) = factorX < factorY ? (unitX, factorX) : (unitY, factorY);
                if (TryExpressIn(x, unitX, commonUnit, service, out alignedX)
                    && TryExpressIn(y, unitY, commonUnit, service, out alignedY))
                {
                    equivalenceStep = TryGetEquivalenceStep(x, factorX, y, factorY, factorCommon);
                    return true;
                }
            }

            // A unit that canonicalizes but that the service will not convert directly into leaves the canonical
            // form as the only common ground. Its rescaling is what this method exists to avoid, so it is a fallback
            // and never the first choice.
            alignedX = canonicalX;
            alignedY = canonicalY;
            return true;
        }

        /// <summary>
        /// Expresses a quantity in <paramref name="unit"/>, returning it unchanged when it already carries that unit,
        /// and otherwise converting it from <paramref name="sourceUnit"/> and quantizing the result to the scale of
        /// the CQL <c>Decimal</c> type.
        /// </summary>
        /// <remarks>
        /// The metric service returns a result at its own working scale, which is both longer and, for a conversion
        /// that divides by a non-decimal factor, inexact: 0.25 'mg/d' expressed in 'ug/d' comes back as
        /// 249.99999999999999999999999999. Comparison truncates rather than rounds at the eighth decimal
        /// ("a <i>scale</i> [...] of 8 [...] with a step size of 10^-8", CQL 1.5.3 Errata 2, Appendix B - CQL
        /// Reference, 1.1 Decimal), which would drop that operand a full step below the 250 it is exactly equal to.
        /// Rounding to the same scale first puts the converted value back on the step the comparison works in, and
        /// stripping the trailing zeros leaves it in the shortest form of that value.
        /// </remarks>
        private static bool TryExpressIn(CqlQuantity quantity, string sourceUnit, string unit, M.IMetricService service, out CqlQuantity? expressed)
        {
            if (string.Equals(sourceUnit, unit, StringComparison.Ordinal))
            {
                expressed = quantity;
                return true;
            }

            CqlQuantity? converted;
            try
            {
                if (!new CqlQuantity(quantity.value, sourceUnit).TryConvert(unit, service, out converted))
                {
                    expressed = null;
                    return false;
                }
            }
            catch (OverflowException)
            {
                // Converting into the finer unit multiplies by the full factor ratio, which is unbounded
                // (1e20 'm' in 'fm'), and a comparison may not abort the evaluation of the whole define
                // over an operand it cannot rescale. Failing here sends the pair down the canonical
                // fallback, which is the path for "these units cannot be converted between".
                expressed = null;
                return false;
            }

            expressed = converted!.value is { } value
                ? new CqlQuantity(
                    Comparers.CqlComparerSharedMethods.NormalizeDecimalScale(
                        decimal.Round(value, Comparers.CqlComparerSharedMethods.CqlDecimalScale, MidpointRounding.AwayFromZero)),
                    converted.unit)
                : converted;
            return true;
        }

        /// <summary>
        /// Returns the step size of the least precise of the two operands, expressed in the common unit, or
        /// <see langword="null"/> when it does not fit a <see cref="decimal"/>.
        /// </summary>
        /// <remarks>
        /// Equivalence rounds to "the precision of the least precise operand" (CQL 1.5.3 Errata 2, Appendix B - CQL
        /// Reference, 5.2 Equivalent), and across units that precision has to be compared as an absolute step size,
        /// not as a count of decimal places: 1000.4 'mg' is written to one decimal place but resolves a tenth of a
        /// milligram, which is finer than the single decimal place of 1.0 'g'. The scale of the converted value
        /// cannot carry it either - it describes the magnitude the conversion produced rather than the precision the
        /// author wrote - so the step is derived from the authored scale of each operand and its own unit's factor,
        /// before any conversion.
        /// </remarks>
        private static decimal? TryGetEquivalenceStep(
            CqlQuantity x,
            decimal factorX,
            CqlQuantity y,
            decimal factorY,
            decimal factorCommon)
        {
            if (x.value is not { } valueX || y.value is not { } valueY || factorCommon <= 0m)
                return null;

            try
            {
                var stepX = StepOf(valueX) * factorX / factorCommon;
                var stepY = StepOf(valueY) * factorY / factorCommon;
                var step = Math.Max(stepX, stepY);
                return step > 0m ? step : null;
            }
            catch (OverflowException)
            {
                return null;
            }
            catch (DivideByZeroException)
            {
                return null;
            }

            // Bits[3] bits 16-23 hold the scale; 10^-scale is the smallest difference the value can express.
            static decimal StepOf(decimal value) =>
                new(1, 0, 0, false, (byte)(decimal.GetBits(value)[3] >> 16));
        }

        /// <summary>
        /// Returns the UCUM spelling of a CQL calendar duration alias (<c>"day"</c> becomes <c>"d"</c>), or the unit
        /// unchanged when it is not one.
        /// </summary>
        private static string ToUcumUnit(string unit) =>
            CalendarDurationMapping.TryGetValue(unit, out var ucumUnit) ? ucumUnit : unit;

        /// <summary>
        /// Memoizes <see cref="TryGetUnitFactor"/> per metric service. A factor depends only on the unit string, the
        /// set of unit strings a measure uses is small, and every cross-unit comparison needs two of them, so without
        /// this each comparison pays two extra canonicalizations on top of its own.
        /// </summary>
        private static readonly ConditionalWeakTable<M.IMetricService, ConcurrentDictionary<string, decimal?>> UnitFactorCache = new();

        /// <summary>
        /// Returns the canonical value of a single <paramref name="unit"/> - its factor against the base unit,
        /// and so the measure of how fine the unit is - or <see langword="false"/> when it cannot be canonicalized.
        /// </summary>
        private static bool TryGetUnitFactor(string unit, M.IMetricService service, out decimal factor)
        {
            var cache = UnitFactorCache.GetValue(service, static _ => new ConcurrentDictionary<string, decimal?>(StringComparer.Ordinal));
            var cached = cache.GetOrAdd(
                unit,
                static (u, svc) => new CqlQuantity(1m, u).TryCanonicalize(svc, out var one) ? one!.value : null,
                service);

            factor = cached ?? default;
            return cached is not null;
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
