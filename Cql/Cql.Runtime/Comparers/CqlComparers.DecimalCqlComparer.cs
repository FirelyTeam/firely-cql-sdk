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
        protected override int? CompareValues(
            [DisallowNull] decimal? x,
            [DisallowNull] decimal? y,
            string? precision)
        {
            return Comparer<decimal?>.Default.Compare(TruncateToCqlDecimalScale(x ?? 0), TruncateToCqlDecimalScale(y ?? 0));
        }

        protected override bool EquivalentValues(
            [DisallowNull] decimal? x,
            [DisallowNull] decimal? y,
            string? precision)
        {
            // Decimal.Scale is the number of digits after the decimal point, counting trailing zeros.
            var @thisPrecision = x.Value.Scale;
            var otherPrecision = y.Value.Scale;
            if (@thisPrecision < otherPrecision)
                y = decimal.Round(y.Value, thisPrecision);
            else if (thisPrecision > otherPrecision)
                x = decimal.Round(x.Value, otherPrecision);
            var areEqual = x == y;
            return areEqual;
        }

        // Hashes intentionally align with CompareValues (CQL equality semantics), not
        // EquivalentValues. EquivalentValues rounds to the least precise operand, which is
        // non-transitive and therefore has no consistent hash.
        protected override int GetHashCodeValue([DisallowNull] decimal? value) =>
            TruncateToCqlDecimalScale(value ?? 0).GetHashCode();
    }
}
