/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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
        ICqlComparer<string> unitComparer) :
        CqlComparer<CqlQuantity>(CqlComparerEqualsImplementation.Compare)
    {
        private CqlComparers ValueComparer { get; } = valueComparer ?? throw new ArgumentNullException(nameof(valueComparer));

        private ICqlComparer<string> UnitComparer { get; } = unitComparer ?? throw new ArgumentNullException(nameof(unitComparer));

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

            // If no direct comparison is possible, normalize the units using UCUM and
            // redo the comparison.
            if (x.TryCanonicalize(out var left1) && y.TryCanonicalize(out var right1))
            {
                var valueComparison = ValueComparer.Compare(left1!.value!, right1!.value!, precision);
                return valueComparison;
            }

            throw new NotSupportedException($"Comparison against unlike units {x.unit} and {y.unit} is not supported.");
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

            // Spec §9.B: quantity equivalence considers unit conversion, so normalize the units
            // using UCUM and redo the comparison. Unlike CompareValues, equivalence must never
            // signal an error, so units that cannot be canonicalized, or that canonicalize to
            // different base metrics (incommensurable), are simply not equivalent.
            if (x.TryCanonicalize(out var left1)
                && y.TryCanonicalize(out var right1)
                && left1!.unit == right1!.unit)
            {
                var valueComparison = ValueComparer.Equivalent(left1.value, right1.value, precision);
                return valueComparison;
            }

            return false;
        }

        protected override int GetHashCodeValue(CqlQuantity value)
        {
            // Both equality (CompareValues) and equivalence (EquivalentValues) canonicalize units,
            // so the hash has to be taken over the canonical form: 1 'cm' and 0.01 'm' are equal
            // and must land in the same bucket for the HashSet-based operators (Distinct, Union,
            // Except) to deduplicate them. Value normalization covers the same-unit case, where
            // 1.0 'cm' and 1.00 'cm' are equal but have different decimal representations.
            //
            // Known hash-contract gaps (pre-existing, non-fixable without breaking the equality
            // semantics themselves):
            //   '1' unit wildcard: CompareValues treats unit '1' as matching any other unit, so
            //     (v, '1') equals (v, 'cm'), but their hashes differ. This is inherently
            //     non-transitive — (1,'1') equals both (1,'cm') and (1,'g') while those two are
            //     unequal — so no consistent hash exists for the '1' case.
            //   Rounding-based equivalence: EquivalentValues rounds to the least-precise operand,
            //     which is also non-transitive (0.15 ~ 0.2, 0.2 ~ 0.24, 0.15 !~ 0.24).
            //   Dimension-blind equality (#1417): until that bug is fixed, CompareValues returns 0
            //     for incommensurable units after canonicalization; once #1417 lands the hash will
            //     naturally agree with the corrected equality.
            //
            // Skip canonicalization for null/wildcard units: these can never benefit from unit
            // conversion (null has no UCUM meaning, '1' is already documented as unhashable above).
            if (value.unit != null && value.unit != "1" && value.TryCanonicalize(out var canonical))
                return combine(canonical!.value, canonical.unit);

            // A unit UCUM cannot canonicalize -- and a quantity whose value or unit is null, which
            // this comparer does not treat as a null quantity -- must still hash without throwing.
            return combine(value.value, value.unit);

            static int combine(decimal? quantityValue, string? unit) =>
                HashCode.Combine(quantityValue is { } v ? NormalizeDecimalScale(v) : (decimal?)null, unit);
        }
    }
}
