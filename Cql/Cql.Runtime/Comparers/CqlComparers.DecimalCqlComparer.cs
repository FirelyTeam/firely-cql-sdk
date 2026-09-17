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
    private class DecimalCqlComparer() : CqlComparer<decimal?>(CqlComparerEqualsImplementation.Compare)
    {
        // CQL only supports 8 digits of scale.
        private const int MaxDecimalDigits = 8;

        protected override int? CompareValues(
            [DisallowNull] decimal? x,
            [DisallowNull] decimal? y,
            string? precision)
        {
            return Comparer<decimal?>.Default.Compare(TruncateDigits(x ?? 0, MaxDecimalDigits), TruncateDigits(y ?? 0, MaxDecimalDigits));
        }

        protected override bool EquivalentValues(
            [DisallowNull] decimal? x,
            [DisallowNull] decimal? y,
            string? precision)
        {
            // CQL 1.5.3 §9.B (Equivalent): "For decimals, equivalent means the values are the same
            // with the comparison done on values rounded to the precision of the least precise
            // operand; trailing zeroes after the decimal are ignored in determining precision for
            // equivalent comparison."
            var left = StripTrailingZeroes(x.Value);
            var right = StripTrailingZeroes(y.Value);
            var leastPrecise = Math.Min(left.Scale, right.Scale);
            return decimal.Round(left, leastPrecise, MidpointRounding.AwayFromZero)
                   == decimal.Round(right, leastPrecise, MidpointRounding.AwayFromZero);
        }

        // Hashes intentionally align with CompareValues (CQL equality semantics), not
        // EquivalentValues. EquivalentValues rounds to the least precise operand, which is
        // non-transitive and therefore has no consistent hash.
        protected override int GetHashCodeValue([DisallowNull] decimal? value) =>
            TruncateDigits(value ?? 0, MaxDecimalDigits).GetHashCode();

        /// <summary>
        /// Returns <paramref name="value"/> with any trailing zeroes after the decimal point removed,
        /// so that its <see cref="decimal.Scale"/> is the count of significant fractional digits:
        /// 1.000 yields scale 0, 1.50 yields scale 1 and 1.55 yields scale 2.
        /// </summary>
        /// <remarks>
        /// Dividing by one normalizes the scale of the quotient to the minimum needed to represent it.
        /// </remarks>
        private static decimal StripTrailingZeroes(decimal value) =>
            value / 1.000000000000000000000000000000000m;

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
