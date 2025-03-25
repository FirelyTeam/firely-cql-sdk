#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    /// <summary>
    /// A comparer that compares to <see cref="CqlQuantity"/> instances, possibly by normalizing their values
    /// using the UCUM system.
    /// </summary>
    internal class CqlQuantityCqlComparer(
        CqlComparers valueComparer,
        ICqlComparer<string> unitComparer) : ICqlComparer<CqlQuantity>//, ICqlComparer
    {
        private CqlComparers ValueComparer { get; } = valueComparer ?? throw new ArgumentNullException(nameof(valueComparer));
        private ICqlComparer<string> UnitComparer { get; } = unitComparer ?? throw new ArgumentNullException(nameof(unitComparer));

        /// <inheritdoc />
        public int? Compare(CqlQuantity? x, CqlQuantity? y, string? precision = null)
        {
            if (x == null)
            {
                if (y == null)
                    return 0;
                else return -1;
            }
            else if (y == null)
                return 1;

            var unitCompare = UnitComparer.Compare(x.unit, y.unit, precision);
            if (unitCompare == 0 || x.unit == "1" || y.unit == "1")
            {
                var valueComparison = ValueComparer.Compare(x.value, y.value, precision);
                return valueComparison;
            }
            else
            {
                // If no direct comparison is possible, normalize the units using UCUM and
                // redo the comparison.
                if (x.TryCanonicalize(out var left) && y.TryCanonicalize(out var right))
                {
                    var valueComparison = ValueComparer.Compare(left!.value!, right!.value!, precision);
                    return valueComparison;
                }
                else
                    throw new NotSupportedException($"Comparison against unlike units {x.unit} and {y.unit} is not supported.");
            }

        }

        // /// <inheritdoc />
        // public int? Compare(object? x, object? y, string? precision = null) => Compare(x as CqlQuantity, y as CqlQuantity, precision);

        /// <inheritdoc />
        public bool? Equals(CqlQuantity? x, CqlQuantity? y, string? precision = null) => Compare(x, y, precision) == 0;

        // /// <inheritdoc />
        // public bool? Equals(object? x, object? y, string? precision = null) => Equals(x as CqlQuantity, y as CqlQuantity, precision);

        /// <inheritdoc />
        public bool Equivalent(CqlQuantity? x, CqlQuantity? y, string? precision = null)
        {
            if (CqlComparers.EquivalentOnNullsOnly(x, y) is { } r)
                return r;

            var unitCompare = UnitComparer.Equivalent(x!.unit, y!.unit, precision);
            if (unitCompare || x.unit == "1" || y.unit == "1")
            {
                var valueComparison = ValueComparer.Equivalent(x.value, y.value, precision);
                return valueComparison;
            }

            return false;
        }

        // /// <inheritdoc />
        // public bool Equivalent(object? x, object? y, string? precision = null) => Equivalent(x as CqlQuantity, y as CqlQuantity, precision);

        /// <inheritdoc />
        public int GetHashCode(CqlQuantity? x) =>
            x?.ToString()?.GetHashCode() ?? typeof(CqlQuantity).GetHashCode();

        // /// <inheritdoc />
        // public int GetHashCode(object? x) =>
        //     GetHashCode(x as CqlQuantity);
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
