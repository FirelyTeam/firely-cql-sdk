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
internal class StringCqlComparer(StringComparer stringComparer) : CqlComparerNew<string>
{
    private StringComparer StringComparer { get; } = stringComparer ?? throw new ArgumentNullException(nameof(stringComparer));

    /// <inheritdoc/>
    protected override int? CompareValues(
        string left,
        string right,
        string? precision = null)
    {
        var result = StringComparer.Compare(left.Normalize(), right.Normalize());
        return result;
    }

    /// <inheritdoc/>
    public override bool? Equals(
        string? left,
        string? right,
        string? precision) =>
        Compare(left, right, precision) == 0;

    protected override bool? EqualsValues(
        string left,
        string right,
        string? precision) =>
        throw new UnreachableException();

    /// <inheritdoc/>
    protected override bool EquivalentValues(
        string left,
        string right,
        string? precision)
    {
        var thisNormalized = left.Normalize();
        var otherNormalized = right.Normalize();
        var areEqual = StringComparer.Equals(thisNormalized, otherNormalized);
        return areEqual;
    }

    /// <inheritdoc/>
    protected override int GetHashCodeValue(string value) => value.GetHashCode();
}