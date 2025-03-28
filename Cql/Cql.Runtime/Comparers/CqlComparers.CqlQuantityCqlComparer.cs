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
    /// A comparer that compares to <see cref="CqlQuantity"/> instances, possibly by normalizing their values
    /// using the UCUM system.
    /// </summary>
    private class CqlQuantityCqlComparer(
        CqlComparers valueComparer,
        ICqlComparer<string> unitComparer) :
        CqlComparer<CqlQuantity>(CqlComparerEqualsMethod.Compare)
    {
        private CqlComparers ValueComparer { get; } = valueComparer ?? throw new ArgumentNullException(nameof(valueComparer));

        private ICqlComparer<string> UnitComparer { get; } = unitComparer ?? throw new ArgumentNullException(nameof(unitComparer));

        protected internal override int? CompareValues(
            CqlQuantity left,
            CqlQuantity right,
            string? precision)
        {
            var unitCompare = UnitComparer.Compare(left.unit, right.unit, precision);
            if (unitCompare == 0 || left.unit == "1" || right.unit == "1")
            {
                var valueComparison = ValueComparer.Compare(left.value, right.value, precision);
                return valueComparison;
            }

            // If no direct comparison is possible, normalize the units using UCUM and
            // redo the comparison.
            if (left.TryCanonicalize(out var left1) && right.TryCanonicalize(out var right1))
            {
                var valueComparison = ValueComparer.Compare(left1!.value!, right1!.value!, precision);
                return valueComparison;
            }

            throw new NotSupportedException($"Comparison against unlike units {left.unit} and {right.unit} is not supported.");
        }

        protected internal override bool EquivalentValues(
            CqlQuantity left,
            CqlQuantity right,
            string? precision)
        {
            var unitCompare = UnitComparer.Equivalent(left!.unit, right!.unit, precision);
            if (unitCompare || left.unit == "1" || right.unit == "1")
            {
                var valueComparison = ValueComparer.Equivalent(left.value, right.value, precision);
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
