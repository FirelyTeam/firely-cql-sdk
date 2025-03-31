/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

partial class CqlComparers
{
    private class DecimalCqlComparer() : CqlComparer<decimal?>(CqlComparerEqualsMethod.Compare)
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

        protected override bool EquivalentValues(
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

        private static int GetPrecision(decimal value) =>
            BitConverter.GetBytes(decimal.GetBits(value)[3])[2];

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
