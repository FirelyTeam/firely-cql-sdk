#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers
{
    internal class InterfaceCqlComparer<T> : ICqlComparer<T>, ICqlComparer
        where T : class, ICqlComparable<T>, IEquivalentable<T>
    {
        public int? Compare(T? x, T? y, string? precision)
        {
            if (x == null)
            {
                if (y == null)
                    return 0;
                else return 1;
            }
            else if (y == null)
                return -1;

            return x.CompareTo(y, precision);
        }

        public int? Compare(object? x, object? y, string? precision) => (x as T)?.CompareTo(y as T, precision);

        public bool? Equals(T? x, T? y, string? precision) => Compare(x, y, precision) == 0;

        public bool? Equals(object? x, object? y, string? precision) => Equals((x as T)!, (y as T)!, precision);

        public bool Equivalent(T? x, T? y, string? precision)
        {
            if (x == null)
            {
                if (y == null)
                    return true;
                else
                    return false;
            }
            else if (y == null)
                return false;

            return x.Equivalent(y, precision);
        }

        public bool Equivalent(object? x, object? y, string? precision) => Equivalent(x as T, y as T, precision);

        public int GetHashCode(T? x) =>
            x == null
            ? typeof(T).GetHashCode()
            : x.GetHashCode();

        public int GetHashCode(object x) => GetHashCode(x as T);
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member