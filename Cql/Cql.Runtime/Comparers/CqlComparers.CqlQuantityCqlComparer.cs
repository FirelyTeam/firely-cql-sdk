/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Fhir.Metrics;
using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    /// <summary>
    /// A comparer that compares two <see cref="CqlQuantity"/> instances, possibly by normalizing their values
    /// using the UCUM system.
    /// </summary>
    private class CqlQuantityCqlComparer(
        CqlComparers valueComparer,
        ICqlComparer<string> unitComparer,
        IMetricService? metricService = null) :
        CqlComparer<CqlQuantity>(CqlComparerEqualsImplementation.Compare)
    {
        private CqlComparers ValueComparer { get; } = valueComparer ?? throw new ArgumentNullException(nameof(valueComparer));

        private ICqlComparer<string> UnitComparer { get; } = unitComparer ?? throw new ArgumentNullException(nameof(unitComparer));

        private IMetricService MetricService { get; } = metricService ?? UcumConversionExtensions.Default;

        protected override int? CompareValues(
            CqlQuantity x,
            CqlQuantity y,
            string? precision)
        {
            var unitCompare = UnitComparer.Compare(x.unit, y.unit, precision);
            if (unitCompare == 0 || x.unit == "1" || y.unit == "1")
            {
                var valueComparison = ValueComparer.Compare(x.value, y.value, precision);
                return valueComparison;
            }

            // Redo the comparison with both quantities brought into one common unit. That unit is the
            // finer of the two operand units rather than the canonical base unit: canonicalizing
            // rescales the values, and for a clinical unit far from its base it pushes them below the
            // step size of a CQL Decimal (0.25 'mg/d' canonicalizes to 0.0000000028935185 'g.s-1'),
            // where the Decimal comparer's 8-digit quantization answers 0 for every pair. See
            // UcumConversionExtensions.TryAlignUnits, which also establishes commensurability.
            if (x.TryAlignUnits(y, MetricService, out var left1, out var right1))
            {
                var valueComparison = ValueComparer.Compare(left1!.value!, right1!.value!, precision);
                return valueComparison;
            }

            // Spec §9.B, stated identically for Equal, Less, Greater, LessOrEqual, GreaterOrEqual
            // and between: "For comparisons involving quantities, the dimensions of each quantity
            // must be the same, but not necessarily the unit. [...] Attempting to operate on
            // quantities with invalid units will result in a null." Units that do not reduce to a
            // shared base unit -- incommensurable ('cm' vs 'g') or not valid UCUM at all -- make
            // the comparison unknown, not an error: real measure logic compares dirty clinical
            // data (a '%' against a '/min'), which must degrade to null rather than abort the
            // evaluation of the whole define.
            return null;
        }

        protected override bool EquivalentValues(
            CqlQuantity x,
            CqlQuantity y,
            string? precision)
        {
            var unitCompare = UnitComparer.Equivalent(x!.unit, y!.unit, precision);
            if (unitCompare || x.unit == "1" || y.unit == "1")
            {
                var valueComparison = ValueComparer.Equivalent(x.value, y.value, precision);
                return valueComparison;
            }

            // Spec §9.B: quantity equivalence considers unit conversion, so bring both quantities into
            // one common unit and redo the comparison. Equivalence rounds to the precision of the
            // least precise operand, which makes the choice of that unit matter even more than it does
            // for CompareValues -- rounding two canonical values that both sit below 1e-8 makes every
            // pair of clinical quantities equivalent. The units must be commensurable for the same
            // reason they must in CompareValues, but where that method answers null, equivalence never
            // may -- it "will always return true or false": units that cannot be canonicalized, or that
            // canonicalize to different base metrics (incommensurable), are simply not equivalent
            // (spec example: 3.5 'cm2' ~ 3.5 'cm' is false).
            if (x.TryAlignUnits(y, MetricService, out var left1, out var right1))
            {
                var valueComparison = ValueComparer.Equivalent(left1!.value, right1!.value, precision);
                return valueComparison;
            }

            return false;
        }

        protected override int GetHashCodeValue(CqlQuantity value)
        {
            // Equality (CompareValues) compares the values truncated to the CQL Decimal scale, in one
            // common unit when the units differ, so the hash is taken over that same truncation and
            // then over the canonical form: 1.000000001 'mg' and 1.000000002 'mg' are equal and so are
            // 1 'mg' and 0.001 'g', and both pairs must land in the same bucket for the HashSet-based
            // operators (Distinct, Union, Except) to deduplicate them. The truncation happens in the
            // quantity's own unit, before canonicalization, because that is the unit equality truncates
            // in whenever the units agree; truncating the canonical value instead would collapse every
            // clinical dose rate to zero (0.25 'mg/d' is 0.0000000028935185 'g.s-1') and would keep
            // digits that equality drops for a unit coarser than its base (70.000000001 'kg' is
            // 70000.000001 'g'). Value normalization covers the scale: 1.0 'cm' and 1.00 'cm' are equal
            // but have different decimal representations.
            //
            // Known hash-contract gaps, inherent to equality semantics that are not transitive and so
            // admit no consistent hash:
            //   '1' unit wildcard: CompareValues treats unit '1' as matching any other unit, so
            //     (v, '1') equals (v, 'cm'), but their hashes differ. (1,'1') equals both (1,'cm') and
            //     (1,'g') while those two are unequal.
            //   Rounding-based equivalence: EquivalentValues rounds to the least-precise operand
            //     (0.15 ~ 0.2, 0.2 ~ 0.24, 0.15 !~ 0.24).
            //   Cross-unit pairs whose coarser operand carries digits below the step size of its own
            //     unit that are above the step size of the finer one: 1.000000004 'g' equals both
            //     1000.000004 'mg' (compared in 'mg') and 1.000000006 'g' (compared in 'g'), while
            //     those two are unequal. The hash drops such digits with the coarser operand's own
            //     truncation, so the first pair hashes differently.
            //
            // Skip canonicalization for null/wildcard units: these can never benefit from unit
            // conversion (null has no UCUM meaning, '1' is already documented as unhashable above).
            var truncatedValue = value.value is { } quantityValue ? TruncateToCqlDecimalScale(quantityValue) : (decimal?)null;
            if (truncatedValue is { } && value.unit is { } unit && unit != "1"
                && new CqlQuantity(truncatedValue, unit).TryCanonicalize(MetricService, out var canonical))
            {
                return combine(canonical!.value, canonical.unit);
            }

            // A unit UCUM cannot canonicalize -- and a quantity whose value or unit is null, which
            // this comparer does not treat as a null quantity -- must still hash without throwing.
            // Equality compares such quantities in their own unit, truncated, so the truncated value
            // is what gets hashed.
            return combine(truncatedValue, value.unit);

            static int combine(decimal? quantityValue, string? unit) =>
                HashCode.Combine(quantityValue is { } v ? NormalizeDecimalScale(v) : (decimal?)null, unit);
        }

    }
}
