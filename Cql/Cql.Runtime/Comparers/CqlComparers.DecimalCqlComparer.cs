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
    private class DecimalCqlComparer : ICqlComparer<decimal?>
    {
        // CQL only supports 8 digits of scale.
        private const int MaxDecimalDigits = 8;

        public int? Compare(decimal? x, decimal? y, string? precision = null)
        {
            var result = CompareOnNullsOnly(x, y) ?? Comparer<decimal?>.Default.Compare(TruncateDigits(x ?? 0, MaxDecimalDigits), TruncateDigits(y ?? 0, MaxDecimalDigits));
            return result;
        }

        public bool Equivalent(decimal? x, decimal? y, string? precision = null)
        {
            if (EquivalentOnNullsOnly(x, y) is { } r)
                return r;

            var @thisPrecision = GetPrecision(x!.Value!);
            var otherPrecision = GetPrecision(y!.Value!);
            if (@thisPrecision < otherPrecision)
                y = decimal.Round(y!.Value!, thisPrecision);
            else if (thisPrecision > otherPrecision)
                x = decimal.Round(x!.Value!, otherPrecision);
            var areEqual = x == y;
            return areEqual;
        }

        public int GetHashCode(decimal? x) =>
            x?.GetHashCode() ?? GetHashCodeForType<decimal>();

        // public int GetHashCode(object? x) =>
        //     GetHashCode(x as decimal?);

        public int GetPrecision(decimal value) => BitConverter.GetBytes(decimal.GetBits(value)[3])[2];
        private decimal TruncateDigits(decimal value, int places)
        {
            var integral = Math.Truncate(value);
            var fraction = value - integral;

            var multiplier = (decimal)Math.Pow(10, places);
            var truncatedFraction = Math.Truncate(fraction * multiplier) / multiplier;

            return integral + truncatedFraction;
        }

    }
}
