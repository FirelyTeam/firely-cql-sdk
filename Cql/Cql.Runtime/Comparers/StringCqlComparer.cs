/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Comparers;

/// <summary>
/// Compares normalized strings given <see cref="StringComparer"/>.
/// </summary>
/// <remarks>
/// Strings are normalized using <see cref="string.Normalize()"/>.
/// </remarks>
internal class StringCqlComparer(StringComparer stringComparer) : ICqlComparer<string> 
{
    private StringComparer StringComparer { get; } = stringComparer ?? throw new ArgumentNullException(nameof(stringComparer));

    /// <inheritdoc/>
    public int? Compare(
        string? x,
        string? y,
        string? precision = null)
    {
        var result = CompareOnNullsOnly(x, y)
                     ?? StringComparer.Compare(x!.Normalize(), y!.Normalize());

        return result;
    }

    /// <inheritdoc/>
    public bool? Equals(
        string? x,
        string? y,
        string? precision = null) => Compare(x, y, precision) == 0;

    /// <inheritdoc/>
    public bool Equivalent(
        string? x,
        string? y,
        string? precision = null)
    {
        if (EquivalentOnNullsOnly(x, y) is { } r)
            return r;

        var thisNormalized = x!.Normalize();
        var otherNormalized = y!.Normalize();
        var areEqual = StringComparer.Equals(thisNormalized, otherNormalized);
        return areEqual;
    }

    /// <inheritdoc/>
    public int GetHashCode(string? x) =>
        x?.GetHashCode() ?? typeof(string).GetHashCode();
}