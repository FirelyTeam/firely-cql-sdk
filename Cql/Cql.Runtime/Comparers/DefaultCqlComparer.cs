/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

/// <summary>
/// Implements comparison through <see cref="Comparer{T}.Default"/>.
/// </summary>
/// <typeparam name="T">The type to compare.</typeparam>
internal class DefaultCqlComparer<T>() : CqlComparer<T>(
    equivalentImplementation: CqlComparerEquivalentImplementation.Compare)
{
    public static DefaultCqlComparer<T> Instance { get; } = new();

    protected override int? CompareValues(T x, T y, string? precision) =>
        Comparer<T>.Default.Compare(x, y);

    protected override bool? EqualsValues(T x, T y, string? precision) =>
        Comparer<T>.Default.Compare(x, y) == 0;

    protected override int GetHashCodeValue([DisallowNull] T value) =>
        EqualityComparer<T>.Default.GetHashCode(value);
}