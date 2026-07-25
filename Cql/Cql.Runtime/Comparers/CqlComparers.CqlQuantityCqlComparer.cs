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
            return value.ToString()?.GetHashCode() ?? GetHashCodeForNull();
        }
    }
}
