/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    private class DecimalCqlComparer() : CqlComparer<decimal?>(CqlComparerEqualsStrategy.Compare)
    {
        // CQL only supports 8 digits of scale.
        private const int MaxDecimalDigits = 8;

        protected internal override int? CompareValues(
            [DisallowNull] decimal? left,
            [DisallowNull] decimal? right,
            string? precision)
        {
            return Comparer<decimal?>.Default.Compare(TruncateDigits(left ?? 0, MaxDecimalDigits), TruncateDigits(right ?? 0, MaxDecimalDigits));
        }

        // public int? Compare(decimal? left, decimal? right, string? precision = null)
        // {
        //     var result = CompareOnNullsOnly(left, right) ?? Comparer<decimal?>.Default.Compare(TruncateDigits(left ?? 0, MaxDecimalDigits), TruncateDigits(right ?? 0, MaxDecimalDigits));
        //     return result;
        // }

        // public bool? Equals(decimal? left, decimal? right, string? precision = null)
        // {
        //     var result = EquivalentOnNullsOnly(left, right)
        //                  ?? Comparer<decimal>.Default.Compare(left!.Value, right!.Value) == 0;
        //     return result;
        // }

        protected internal override bool EquivalentValues(
            [DisallowNull] decimal? left,
            [DisallowNull] decimal? right,
            string? precision)
        {
            var @thisPrecision = GetPrecision(left.Value);
            var otherPrecision = GetPrecision(right.Value);
            if (@thisPrecision < otherPrecision)
                right = decimal.Round(right.Value, thisPrecision);
            else if (thisPrecision > otherPrecision)
                left = decimal.Round(left.Value, otherPrecision);
            var areEqual = left == right;
            return areEqual;
        }

        // public bool Equivalent(decimal? left, decimal? right, string? precision = null)
        // {
        //     if (EquivalentOnNullsOnly(left, right) is { } r)
        //         return r;
        //
        //     var @thisPrecision = GetPrecision(left!.Value);
        //     var otherPrecision = GetPrecision(right!.Value);
        //     if (@thisPrecision < otherPrecision)
        //         right = decimal.Round(right.Value, thisPrecision);
        //     else if (thisPrecision > otherPrecision)
        //         left = decimal.Round(left.Value, otherPrecision);
        //     var areEqual = left == right;
        //     return areEqual;
        // }

        // public int GetHashCode(decimal? value) =>
        //     value?.GetHashCode() ?? GetHashCodeForType<decimal>();

        private static int GetPrecision(decimal value) => BitConverter.GetBytes(decimal.GetBits(value)[3])[2];

        private static decimal TruncateDigits(decimal value, int places)
        {
            var integral = Math.Truncate(value);
            var fraction = value - integral;

            var multiplier = (decimal)Math.Pow(10, places);
            var truncatedFraction = Math.Truncate(fraction * multiplier) / multiplier;

            return integral + truncatedFraction;
        }

    }
}
