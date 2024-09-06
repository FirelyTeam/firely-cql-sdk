/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */


using System.Runtime.CompilerServices;
using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers;

internal class TupleComparer(ICqlComparer memberComparer) : ICqlComparer<ITuple?>, ICqlComparer
{
    public int? Compare(
        ITuple? x,
        ITuple? y,
        string? precision)
    {
        if (x == null || y == null)
            return null;

        if (x.Length != y.Length)
            return null;

        var xType = x.GetType();
        var yType = y.GetType();
        if (xType != yType)
            return null;

        for (int i = 0; i < x.Length; i++)
        {
            var compare = memberComparer.Compare(x[i], y[i], precision);
            if (compare is null or not 0)
                return compare;
        }

        return 0;
    }

    public int GetHashCode(ITuple? obj) =>
        obj?.GetHashCode() ?? typeof(ITuple).GetHashCode() ^ 098174506;

    public bool? Equals(ITuple? x, ITuple? y, string? precision = null) =>
        Compare(x, y, null) == 0;

    public bool Equivalent(
        ITuple? x,
        ITuple? y,
        string? precision)
    {
        if (CqlComparers.EquivalentOnNullsOnly(x, y) is { } r)
            return r;

        if (x!.Length != y!.Length)
            return false;

        var xType = x.GetType();
        var yType = y.GetType();
        if (xType != yType)
            return false;

        for (int i = 0; i < x.Length; i++)
        {
            if (!memberComparer.Equivalent(x[i], y[i], precision))
                return false;
        }

        return true;
    }

    public bool Equivalent(object? x, object? y, string? precision) =>
        Equivalent(x as ITuple, y as ITuple, precision);

    public bool? Equals(object? x, object? y, string? precision) =>
        Equals(x as ITuple, y as ITuple, precision);

    public int? Compare(object? x, object? y, string? precision) =>
        Compare(x as ITuple, y as ITuple, precision);

    public int GetHashCode(object? x) => GetHashCode(x as ITuple);
}