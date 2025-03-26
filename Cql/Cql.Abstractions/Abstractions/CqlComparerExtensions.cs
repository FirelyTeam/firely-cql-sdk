/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

/// <summary>
/// Extension methods for <see cref="ICqlComparer{T}"/>.
/// </summary>
public static class CqlComparerExtensions
{
    /// <summary>
    /// Compares two objects for equality. This method is equivalent to calling <see cref="ICqlComparer{T}.Compare(T, T, string?)"/> and comparing its result with 0.  When equal, this method returns <see langword="true"/>.
    /// </summary>
    /// <param name="comparer">The comparer on which equality is compared.</param>
    /// <param name="x">The first object to compare.</param>
    /// <param name="y">The second object to compare.</param>
    /// <param name="precision">The precision to use in this comparison, or <see langword="null"/>.</param>
    /// <returns><see langword="true"/> if the objects are equal, <see langword="false"/> if not, and <see langword="null"/> if the answer cannot be computed due to uncertainty related to <paramref name="precision"/>.</returns>
    public static bool? Equals<T>(
        this ICqlComparer<T> comparer,
        T? x,
        T? y,
        string? precision)
    {
        var result = EquivalentOnNullsOnly(x, y) ?? comparer.Compare(x, y, precision) == 0;
        return result;
    }

}