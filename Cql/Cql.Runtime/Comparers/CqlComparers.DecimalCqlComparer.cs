/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;

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
            var @thisPrecision = x.Value.GetScale();
            var otherPrecision = y.Value.GetScale();
            if (@thisPrecision < otherPrecision)
                y = decimal.Round(y.Value, thisPrecision);
            else if (thisPrecision > otherPrecision)
                x = decimal.Round(x.Value, otherPrecision);
            var areEqual = x == y;
            return areEqual;
        }

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
