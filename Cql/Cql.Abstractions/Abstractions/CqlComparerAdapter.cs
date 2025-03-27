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
    Func<TOuter, TInner?> getInner) : CqlComparer<TOuter>, IAdapter
{
    private readonly CqlComparer<TInner>? _innerCqlComparer = inner as CqlComparer<TInner>;

    private TInner? GetInner(TOuter? value) => value is null ? default : getInner(value);

    protected internal override int GetEquivalentStrategy()
    {
        var equivalentStrategy = base.GetEquivalentStrategy();
        Trace.Assert(
            _innerCqlComparer is null
            || equivalentStrategy == _innerCqlComparer.GetEquivalentStrategy());
        return equivalentStrategy;
    }

    protected internal override int GetEqualsStrategy()
    {
        var equalsStrategy = base.GetEqualsStrategy();
        Trace.Assert(
            _innerCqlComparer is null
            || equalsStrategy == _innerCqlComparer.GetEqualsStrategy());
        return equalsStrategy;
    }

    protected internal override bool CompareReturnNullOnAnyNull()
    {
        var compareReturnNullOnAnyNull = base.CompareReturnNullOnAnyNull();
        Trace.Assert(
            _innerCqlComparer is null
            || compareReturnNullOnAnyNull == _innerCqlComparer.CompareReturnNullOnAnyNull());
        return compareReturnNullOnAnyNull;
    }

    protected override bool EquivalentValues(
        [DisallowNull] TOuter left,
        [DisallowNull] TOuter right,
        string? precision) =>
        inner.Equivalent(GetInner(left), GetInner(right), precision);

    protected override bool? EqualsValues(
        [DisallowNull] TOuter x,
        [DisallowNull] TOuter y,
        string? precision) =>
        inner.Equals(GetInner(x), GetInner(y), precision);

    protected override int? CompareValues(
        [DisallowNull] TOuter left,
        [DisallowNull] TOuter right,
        string? precision) =>
        inner.Compare(GetInner(left), GetInner(right), precision);

    protected override int GetHashCodeValue([DisallowNull] TOuter value) =>
        inner.GetHashCode(GetInner(value));

    object IAdapter.Inner => inner;
}