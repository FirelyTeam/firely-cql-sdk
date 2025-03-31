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
    internal class InterfaceCqlComparer<T>() :
        CqlComparer<T>(
            CqlComparerEqualsMethod.Compare,
            CqlComparerNullComparisonStrategy.EitherNullReturnsNull
            /*,
        equivalentMethod:CqlComparerEquivalentMethod.Compare */
        )
        where T : class, ICqlComparable<T>, IEquivalentable<T>
    {
        protected internal override int? CompareValues(
            T left,
            T right,
            string? precision) =>
            left.CompareToValue(right, precision);

        protected override bool EquivalentValues(
            T left,
            T right,
            string? precision) =>
            left.EquivalentToValue(right, precision);
    }
}