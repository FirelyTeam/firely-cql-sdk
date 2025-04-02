/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

internal class CqlComparerWrapper<T, TInner>(
    ICqlComparer<TInner> inner,
    Func<T, TInner?> getInner) :
    CqlComparer<T>(
        equalsMethod: inner is CqlComparer<TInner> c1 ? c1.EqualsMethod : default,
        equivalentMethod: inner is CqlComparer<TInner> c3 ? c3.EquivalentMethod : default)
{
    private TInner? GetInner(T? value) => value is null ? default : getInner(value);

    protected override bool EquivalentValues(
        [DisallowNull] T x,
        [DisallowNull] T y,
        string? precision) =>
        inner.Equivalent(GetInner(x), GetInner(y), precision);

    protected override bool? EqualsValues(
        [DisallowNull] T x,
        [DisallowNull] T y,
        string? precision) =>
        inner.Equals(GetInner(x), GetInner(y), precision);

    protected override int? CompareValues(
        [DisallowNull] T x,
        [DisallowNull] T y,
        string? precision) =>
        inner.Compare(GetInner(x), GetInner(y), precision);

    protected override int GetHashCodeValue([DisallowNull] T value) =>
        inner.GetHashCode(GetInner(value));
}