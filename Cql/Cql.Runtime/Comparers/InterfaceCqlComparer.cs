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
    internal class InterfaceCqlComparer<T> : CqlComparer<T>
        where T : class, ICqlComparable<T>, IEquivalentable<T>
    {
        protected internal override int GetEqualsStrategy()
        {
            return EQUALS_VIA_COMPARE;
        }

        protected override int? CompareValues(
            T left,
            T right,
            string? precision)
        {
            return left.CompareTo(right, precision);
        }

        // public int? Compare(T? left, T? right, string? precision)
        // {
        //     if (left == null)
        //     {
        //         if (right == null)
        //             return 0;
        //         else return 1;
        //     }
        //     else if (right == null)
        //         return -1;
        //
        //     return left.CompareTo(right, precision);
        // }

        // public bool? Equals(T? left, T? right, string? precision) =>
        //     Compare(left, right, precision) == 0;

        protected override bool EquivalentValues(
            T left,
            T right,
            string? precision)
        {
            return left.Equivalent(right, precision);
        }

        // public bool Equivalent(T? left, T? right, string? precision) =>
        //     EquivalentOnNullsOnly(left, right)
        //     ?? left!.Equivalent(right, precision);

        // public int GetHashCode(T? value) =>
        //     value?.GetHashCode() ?? typeof(T).GetHashCode();
    }
}
