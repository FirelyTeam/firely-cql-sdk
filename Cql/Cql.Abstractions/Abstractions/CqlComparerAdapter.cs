/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

internal class CqlComparerAdapter<TInner, TOuter>(
    ICqlComparer<TInner> inner,
    Func<TOuter, TInner?> getInner) :
    CqlComparer<TOuter>(
        inner is CqlComparer<TInner> c1 ? c1.EqualsMethod : default,
        inner is CqlComparer<TInner> c2 ? c2.NullComparisonStrategy : default,
        inner is CqlComparer<TInner> c3 ? c3.EquivalentMethod : default), IAdapter
{
    private TInner? GetInner(TOuter? value) => value is null ? default : getInner(value);

    protected internal override bool EquivalentValues(
        [DisallowNull] TOuter left,
        [DisallowNull] TOuter right,
        string? precision) =>
        inner.Equivalent(GetInner(left), GetInner(right), precision);

    protected override bool? EqualsValues(
        [DisallowNull] TOuter x,
        [DisallowNull] TOuter y,
        string? precision) =>
        inner.Equals(GetInner(x), GetInner(y), precision);

    protected internal override int? CompareValues(
        [DisallowNull] TOuter left,
        [DisallowNull] TOuter right,
        string? precision) =>
        inner.Compare(GetInner(left), GetInner(right), precision);

    protected override int GetHashCodeValue([DisallowNull] TOuter value) =>
        inner.GetHashCode(GetInner(value));

    object IAdapter.Inner => inner;
}