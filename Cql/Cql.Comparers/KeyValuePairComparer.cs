/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers;

internal class KeyValuePairComparer<TKey,TValue>(ICqlComparer cqlComparer) : ICqlComparer, ICqlComparer<KeyValuePair<TKey, TValue>>
{
    /// <inheritdoc />
    public int? Compare(object? x, object? y, string? precision = null)
    {
        if (x is KeyValuePair<TKey, TValue> tx)
        {
            if (y is KeyValuePair<TKey, TValue> ty)
                return Compare(tx, ty, precision);
        }
        return -1;
    }

    /// <inheritdoc />
    public int? Compare(
        KeyValuePair<TKey, TValue> x,
        KeyValuePair<TKey, TValue> y,
        string? precision = null) =>
        cqlComparer.Compare(x.Key, y.Key, precision) switch
        {
            0     => cqlComparer.Compare(x.Value, y.Value, precision),
            var i => i
        };

    /// <inheritdoc />
    public bool? Equals(object? x, object? y, string? precision = null) =>
        Compare(x, y, precision) == 0;

    /// <inheritdoc />
    public bool? Equals(
        KeyValuePair<TKey, TValue> x,
        KeyValuePair<TKey, TValue> y,
        string? precision = null) =>
        cqlComparer.Equals(x.Key, y.Key, precision) switch
        {
            true  => cqlComparer.Equals(x.Value, y.Value, precision),
            var b => b
        };

    /// <inheritdoc />
    public bool Equivalent(object? x, object? y, string? precision = null) =>
        Compare(x, y, precision) == 0;

    /// <inheritdoc />
    public bool Equivalent(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y, string? precision = null) =>
        CqlComparers.EquivalentOnNullsOnly(x, y)
        ?? Compare(x, y, precision) == 0;

    /// <inheritdoc />
    public int GetHashCode(KeyValuePair<TKey, TValue> x) =>
        HashCode.Combine(
            cqlComparer.GetHashCode(x.Key),
            cqlComparer.GetHashCode(x.Value));

    /// <inheritdoc />
    public int GetHashCode(object? x) =>
        x is null
            ? typeof(KeyValuePair<TKey, TValue>).GetHashCode()
            : GetHashCode((KeyValuePair<TKey, TValue>)x);
}