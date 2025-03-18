/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;

namespace Hl7.Cql.ValueSets;

/// <summary>
/// A set of helper methods for working with valueset facades.
/// </summary>
public static class CqlCodeExtensions
{
    /// <summary>
    /// Returns a facade on a <see cref="IValueSetDictionary"/> that represents access to the valueset within the dictionary.
    /// </summary>
    /// <remarks>This method does not check that the dictionary contains the given valueset.</remarks>
    public static IValueSetFacade GetValueSet(this IValueSetDictionary all, string canonical) => new CqlValueSetFacade(canonical, all);

    /// <summary>
    /// Returns a facade on a <see cref="IValueSetDictionary"/> that represents access to the valueset within the dictionary.
    /// </summary>
    /// <remarks>This method does not check that the dictionary contains the given valueset.</remarks>
    public static IValueSetFacade GetValueSet(this IValueSetDictionary all, CqlValueSet valueset) =>
        GetValueSet(all, valueset.id ?? throw new ArgumentException("Valueset does not have a canonical."));


    /// <summary>
    /// Create a union from two sets of codes.
    /// </summary>
    public static IEnumerable<CqlCode> Union(this IEnumerable<CqlCode> left, IEnumerable<CqlCode> right)
    {
        var l = left as IValueSetFacade ?? new InMemoryValueSet(left);
        var r = right as IValueSetFacade ?? new InMemoryValueSet(right);

        return l.Union(r);
    }

    /// <summary>
    /// Create a union from two <see cref="IValueSetFacade"/>s.
    /// </summary>
    public static IValueSetFacade Union(this IValueSetFacade left, IValueSetFacade right) => new ValueSetUnion(left, right);

    /// <summary>
    /// Create an <see cref="IEqualityComparer"/> based on the given <see cref="ICqlComparer"/>.
    /// </summary>
    public static IEqualityComparer<T> ToEqualityComparer<T>(this ICqlComparer<T> comparer, string? precision = null, bool useEquivalence = false) =>
        new CqlCodeEqualityComparer<T>(comparer ?? throw new ArgumentNullException(nameof(comparer)), precision, useEquivalence);

    private class CqlCodeEqualityComparer<T>
        (ICqlComparer<T> comparer, string? precision = null, bool useEquivalence = false)
        : IEqualityComparer<T>
    {
        public ICqlComparer<T> Comparer { get; } = comparer ?? throw new ArgumentNullException(nameof(comparer));

        public bool Equals(T? x, T? y) =>
            ReferenceEquals(x, y) ||
            useEquivalence ? Comparer.Equivalent(x, y, precision) == true : Comparer.Equals(x, y, precision) == true;

        public int GetHashCode(T obj) => Comparer.GetHashCode(obj);
    }
}