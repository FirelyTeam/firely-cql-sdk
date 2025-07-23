/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

/// <summary>
/// Extensions for <see cref="ICqlComparer{T}"/>.
/// </summary>
public static class CqlComparerExtensions
{

    /// <summary>
    /// Create an <see cref="IEqualityComparer"/> based on the given <see cref="ICqlComparer{T}"/>.
    /// </summary>
    public static IEqualityComparer<T> ToEqualityComparer<T>(
        this ICqlComparer<T> comparer,
        string? precision = null,
        bool useEquivalence = false) =>
        useEquivalence
            ? new CqlEquivalenceToEqualityComparer<T>(comparer, precision)
            : new CqlEqualityToEqualityComparer<T>(comparer, precision);
}

file class CqlEqualityToEqualityComparer<T>
    (ICqlComparer<T> comparer, string? precision = null)
    : IEqualityComparer<T>
{
    private readonly ICqlComparer<T> _comparer = comparer ?? throw new ArgumentNullException(nameof(comparer));

    public bool Equals(T? x, T? y) =>
        ReferenceEquals(x, y) ||
        _comparer.Equals(x, y, precision) is true;

    public int GetHashCode(T obj) => _comparer.GetHashCode(obj);
}

file class CqlEquivalenceToEqualityComparer<T>
    (ICqlComparer<T> comparer, string? precision = null)
    : IEqualityComparer<T>
{
    private readonly ICqlComparer<T> _comparer = comparer ?? throw new ArgumentNullException(nameof(comparer));

    public bool Equals(T? x, T? y) =>
        ReferenceEquals(x, y) ||
        _comparer.Equivalent(x, y, precision);

    public int GetHashCode(T obj) => _comparer.GetHashCode(obj);
}