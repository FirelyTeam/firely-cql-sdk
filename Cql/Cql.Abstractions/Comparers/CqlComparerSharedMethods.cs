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
    /// <summary>
    /// Maps the result of a comparison onto equivalence, for the comparers and primitives that
    /// answer equivalence by reusing their comparison implementation.
    /// </summary>
    /// <remarks>
    /// A null comparison means the two values could not be ordered, and maps to <c>false</c>:
    /// equivalence "will always return true or false" (spec §9.B, Equivalent), so there is nothing
    /// else it could become. Every call site wants exactly that. The comparers reach here with
    /// operands already known non-null, so a null can only mean incomparable -- quantities whose
    /// units share no base unit, which the same section makes <c>false</c> (<c>3.5 'cm2' ~ 3.5
    /// 'cm'</c>). <see cref="Hl7.Cql.Primitives.CqlDate"/>/<see cref="Hl7.Cql.Primitives.CqlTime"/>/
    /// <see cref="Hl7.Cql.Primitives.CqlDateTime"/> reach here with a null from insufficient precision,
    /// which the same section also makes <c>false</c>: "if one input has a value for a given
    /// precision and the other does not, the comparison stops and the result is false, rather than
    /// null" (<c>@2012-01-01 ~ @2012-01-01T12</c> is false).
    /// </remarks>
    public static bool CqlComparisonToEquivalence(int? cqlComparisonResult) => cqlComparisonResult is 0;

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