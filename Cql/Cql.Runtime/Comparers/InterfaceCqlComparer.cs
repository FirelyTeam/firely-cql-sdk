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
    internal class InterfaceCqlComparer<T> : ICqlComparer<T>
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

        public bool? Equals(T? x, T? y, string? precision) => Compare(x, y, precision) == 0;

        public bool Equivalent(T? x, T? y, string? precision) =>
            EquivalentOnNullsOnly(x, y)
            ?? x!.Equivalent(y, precision);

        public int GetHashCode(T? x) =>
            x?.GetHashCode() ?? typeof(T).GetHashCode();
    }
}
