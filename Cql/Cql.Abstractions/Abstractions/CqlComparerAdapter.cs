/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

internal class CqlComparerAdapter<T, TInner>(
    ICqlComparer<TInner> inner,
    Func<T, TInner?> getInnerValue) : ICqlComparer<T>, IAdapter
{
    public bool Equivalent(
        T? x,
        T? y,
        string? precision)
    {
        var result =
            EquivalentOnNullsOnly(x, y)
            ?? inner.Equivalent(getInnerValue(x!), getInnerValue(y!), precision);
        return result;
    }

    public int? Compare(
        T? x,
        T? y,
        string? precision)
    {
        var result =
            CompareOnNullsOnly(x, y)
            ?? inner.Compare(getInnerValue(x!), getInnerValue(y!), precision);
        return result;
    }

    public int GetHashCode(T? x)
    {
        var result = x is null
                         ? GetHashCodeForType<T>()
                         : inner.GetHashCode(getInnerValue(x));
        return result;
    }

    public object Inner => inner;
}