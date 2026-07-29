/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

internal static class CqlComparerSharedMethods
{
    public static bool CqlComparisonToEquivalence(int? cqlComparisonResult) => cqlComparisonResult is null or 0;

    public static int? CompareTemporalIntegers(int? x, int? y) =>
        x is null || y is null
            ? null
            : Math.Sign(x.Value - y.Value);

    public static bool CqlEqualityToEquivalence(bool? cqlEqualsResult) => cqlEqualsResult is null or true;

    public static bool? CqlComparisonToEquals(int? compareValues) =>
        compareValues switch
        {
            null => null,
            0    => true,
            _    => false,
        };

    /// <summary>
    /// Returns <paramref name="value"/> with the trailing zeros stripped from its scale, so that
    /// decimals which are equal but differently scaled (<c>1.0m</c> and <c>1.00m</c>) share a
    /// single representation.
    /// </summary>
    /// <remarks>
    /// Hashing call sites must normalize through this before combining a decimal into a hash code:
    /// CQL comparison ignores scale, so scale alone must never place two equal values in different
    /// buckets, and the hash must not depend on <see cref="decimal.GetHashCode"/> doing its own
    /// unscaling.
    /// </remarks>
    public static decimal NormalizeDecimalScale(decimal value)
    {
        // Dropping one decimal place at a time via decimal.Round and keeping the result only while
        // it still equals the input is exact -- Round lowers the scale but leaves the value alone
        // when the digit it drops is a zero. Bits[3] bits 16-23 hold the scale.
        var scale = (byte)(decimal.GetBits(value)[3] >> 16);
        while (scale > 0)
        {
            var rounded = decimal.Round(value, scale - 1);
            if (rounded != value)
                break;

            value = rounded;
            scale--;
        }

        return value;
    }
}