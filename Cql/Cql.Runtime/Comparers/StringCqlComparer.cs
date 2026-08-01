/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Comparers;

/// <summary>
/// Compares normalized strings given <see cref="StringComparer"/>.
/// </summary>
/// <remarks>
/// Strings are normalized using <see cref="string.Normalize()"/>.
/// </remarks>
internal class StringCqlComparer(StringComparer stringComparer) : CqlComparer<string>(
    equivalentImplementation: CqlComparerEquivalentImplementation.Equals
    )
{
    private StringComparer StringComparer { get; } = stringComparer ?? throw new ArgumentNullException(nameof(stringComparer));

    /// <inheritdoc/>
    protected override int? CompareValues(
        string x,
        string y,
        string? precision)
    {
        var result = StringComparer.Compare(x.Normalize(), y.Normalize());
        return result;
    }

    /// <inheritdoc/>
    protected override bool? EqualsValues(
        string x,
        string y,
        string? precision)
    {
        var thisNormalized = x.Normalize();
        var otherNormalized = y.Normalize();
        var areEqual = StringComparer.Equals(thisNormalized, otherNormalized);
        return areEqual;
    }

    /// <inheritdoc/>
    /// <remarks>
    /// Hashes the same normalized string <see cref="EqualsValues"/> compares, using the same
    /// <see cref="System.StringComparer"/>. Hashing the raw value instead would put two strings this comparer
    /// considers equal — differing only in Unicode normalization form, or in case for a case-insensitive comparer —
    /// in different buckets of the hash-based operators (<c>distinct</c>, <c>union</c>, <c>except</c>,
    /// <c>includes</c>), which would then report them as distinct.
    /// </remarks>
    protected override int GetHashCodeValue(string value) => StringComparer.GetHashCode(value.Normalize());
}