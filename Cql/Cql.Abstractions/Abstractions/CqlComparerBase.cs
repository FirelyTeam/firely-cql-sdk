/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

/// <summary>
/// Base type to implement CQL comparison
/// </summary>
/// <typeparam name="T">The type to compare.</typeparam>
internal abstract class CqlComparerBase<T> :
    ICqlComparer<T>
{
    /// <inheritdoc />
    public abstract int? Compare(T? x, T? y, string? precision);

    /// <inheritdoc />
    public bool Equivalent(T? x, T? y, string? precision) =>
        EquivalentOnNullsOnly(x, y)
        ?? EquivalentImpl(x!, y!, precision);

    protected abstract bool EquivalentImpl(T x, T y, string? precision);

    /// <inheritdoc />
    public abstract int GetHashCode(T? x);
}