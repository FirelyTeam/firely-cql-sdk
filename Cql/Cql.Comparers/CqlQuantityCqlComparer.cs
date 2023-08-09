#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using System;

namespace Hl7.Cql.Comparers
{
    public class CqlQuantityCqlComparer : ICqlComparer<CqlQuantity>, ICqlComparer
    {
        public CqlQuantityCqlComparer(ICqlComparer valueComparer, ICqlComparer unitComparer)
        {
            ValueComparer = valueComparer ?? throw new ArgumentNullException(nameof(valueComparer));
            UnitComparer = unitComparer ?? throw new ArgumentNullException(nameof(unitComparer));
        }

        public ICqlComparer ValueComparer { get; }
        public ICqlComparer UnitComparer { get; }

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

            var unitCompare = UnitComparer.Compare(x.unit!, y.unit!, precision);
            if (unitCompare == 0 || x.unit == "1" || y.unit == "1")
            {
                var valueComparison = ValueComparer.Compare(x.value!, y.value!, precision);
                return valueComparison;
            }
            else
                throw new NotSupportedException($"Comparison against unlike units {x.unit} and {y.unit} is not supported.");
        }

        public int? Compare(object? x, object? y, string? precision = null) => Compare(x as CqlQuantity, y as CqlQuantity, precision);

        public bool? Equals(CqlQuantity? x, CqlQuantity? y, string? precision = null) => Compare(x, y, precision) == 0;

        public bool? Equals(object? x, object? y, string? precision = null) => Equals(x as CqlQuantity, y as CqlQuantity, precision);

        public bool Equivalent(CqlQuantity? x, CqlQuantity? y, string? precision = null)
        {
            if (x == null)
                throw new ArgumentNullException(nameof(x));
            if (y == null)
                throw new ArgumentNullException(nameof(y));

            return x.value == y.value && x.unit == y.unit;
        }

        public bool Equivalent(object? x, object? y, string? precision = null) => Equivalent(x as CqlQuantity, y as CqlQuantity, precision);

        public int GetHashCode(CqlQuantity? x) =>
            x == null
            ? typeof(CqlQuantity).GetHashCode()
            : x.ToString()!.GetHashCode();

        public int GetHashCode(object x) => GetHashCode(x as CqlQuantity);
    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
