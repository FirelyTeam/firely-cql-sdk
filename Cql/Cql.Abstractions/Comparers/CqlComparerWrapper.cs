/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers;

internal class CqlComparerWrapper<T, TInner>(
    ICqlComparer<TInner> inner,
    Func<T, TInner?> getInner) :
    CqlComparer<T>(
        inner is CqlComparer<TInner> c1 ? c1.EqualsMethod : default,
        inner is CqlComparer<TInner> c2 ? c2.NullComparisonStrategy : default,
        inner is CqlComparer<TInner> c3 ? c3.EquivalentMethod : default), IWrapper
{
    private TInner? GetInner(T? value) => value is null ? default : getInner(value);

    protected override bool EquivalentValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision) =>
        inner.Equivalent(GetInner(left), GetInner(right), precision);

    protected override bool? EqualsValues(
        [DisallowNull] T x,
        [DisallowNull] T y,
        string? precision) =>
        inner.Equals(GetInner(x), GetInner(y), precision);

    protected internal override int? CompareValues(
        [DisallowNull] T left,
        [DisallowNull] T right,
        string? precision) =>
        inner.Compare(GetInner(left), GetInner(right), precision);

    protected override int GetHashCodeValue([DisallowNull] T value) =>
        inner.GetHashCode(GetInner(value));

    object IWrapper.Inner => inner;
}