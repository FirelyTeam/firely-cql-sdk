#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System;
using System.Collections.Generic;

namespace Hl7.Cql.Comparers
{
    internal class DecimalCqlComparer : ICqlComparer, ICqlComparer<decimal?>
    {
        // CQL only supports 8 digits of scale.
        private const int MaxDecimalDigits = 8;

        public int? Compare(object? x, object? y, string? precision = null) =>
            Compare(x as decimal?, y as decimal?, precision);

        public int? Compare(decimal? x, decimal? y, string? precision = null)
        {
            if (x == null)
            {
                if (y == null)
                    return 0;
                else return -1;
            }
            else if (y == null)
                return 1;
            return Comparer<decimal?>.Default.Compare(TruncateDigits(x ?? 0, MaxDecimalDigits), TruncateDigits(y ?? 0, MaxDecimalDigits));
        }


        public bool? Equals(object? x, object? y, string? precision = null) =>
            Equals(x as decimal?, y as decimal?, precision);

        public bool? Equals(decimal? x, decimal? y, string? precision = null)
        {
            if (x == null)
            {
                if (y == null)
                    return true;
                else return false;
            }
            else if (y == null)
                return false;
            return Comparer<decimal?>.Default.Compare(x, y) == 0;
        }

        public bool Equivalent(object? x, object? y, string? precision = null) =>
            Equivalent(x as decimal?, y as decimal?, precision);

        public bool Equivalent(decimal? x, decimal? y, string? precision = null)
        {
            if (x == null)
            {
                if (y == null)
                    return true;
                else return false;
            }
            else if (y == null)
                return false;
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
            x == null
            ? typeof(decimal).GetHashCode()
            : x.GetHashCode();

        public int GetHashCode(object x) => GetHashCode(x as decimal?);

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
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member