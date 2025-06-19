/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

internal static class CqlVersionedLibraryIdentifierFormatting
{
    /// <summary>
    /// The delimiter to use between the qualifier and identifier part in the string representation.
    /// </summary>
    [UsedImplicitly] public const char SystemIdentifierDelimiter = '.';

    /// <summary>
    /// The delimiter to use between the identifier and version part in the string representation.
    /// </summary>
    [UsedImplicitly] public const char IdentifierVersionDelimiter = '-';

    /// <summary>
    /// Constructs a string representation of a system identifier using the specified qualifiers.
    /// </summary>
    /// <param name="qualifiers">
    /// An array of strings representing the qualifiers that make up the system identifier.
    /// Each element in the array corresponds to a part of the system identifier.
    /// </param>
    /// <param name="delimiter">
    /// The character used to separate the qualifiers in the resulting string.
    /// Defaults to <see cref="SystemIdentifierDelimiter"/>.
    /// </param>
    /// <returns>
    /// A string representation of the system identifier, with qualifiers separated by the specified delimiter.
    /// If the <paramref name="qualifiers"/> array is empty, returns <c>null</c>.
    /// </returns>
    internal static string? FormatSystem(
        string[] qualifiers,
        char delimiter = SystemIdentifierDelimiter)
    {
        return qualifiers switch
        {
            { Length: > 0 } q => string.Join(delimiter, q),
            _                 => null,
        };
    }

    /// <summary>
    /// Constructs a string representation of a CQL versioned library identifier.
    /// </summary>
    /// <param name="identifier">The identifier of the CQL library.</param>
    /// <param name="version">The version of the CQL library. This parameter is optional.</param>
    /// <param name="delimiter">The delimiter used to separate the identifier and version. Defaults to "-".</param>
    /// <returns>A string combining the identifier and version, separated by the specified delimiter.
    /// If the version is not provided, only the identifier is returned.
    /// If the identifier is not provided, null is returned.</returns>
    internal static string? FormatIdentifierVersion(
        string identifier,
        string? version = null,
        char delimiter = IdentifierVersionDelimiter) =>
        (identifier, version) switch
        {
            ({ Length: > 0 } id, { Length: > 0 } ver) => $"{id}{delimiter}{ver}",
            ({ Length: > 0 } id, _)                   => id,
            _                                         => null
        };

    /// <summary>
    /// Constructs a string representation of a CQL versioned library identifier.
    /// </summary>
    /// <param name="system">The system of the CQL library.</param>
    /// <param name="identifier">The identifier of the CQL library.</param>
    /// <param name="version">The version of the CQL library. This parameter is optional.</param>
    /// <param name="systemDelimiter">The delimiter used to separate the system and identifier. Defaults to '.'.</param>
    /// <param name="versionDelimiter">The delimiter used to separate the identifier and version. Defaults to '-'.</param>
    /// <returns>A string combining the system, identifier and version, separated by the specified delimiters.</returns>
    internal static string? FormatSystemIdentifierVersion(
        string system,
        string identifier,
        string? version = null,
        char systemDelimiter = SystemIdentifierDelimiter,
        char versionDelimiter = IdentifierVersionDelimiter) =>
        (system, identifier, version) switch
        {
            ({ Length: > 0 } sys, { Length: > 0 } id, { Length: > 0 } ver) => $"{sys}{systemDelimiter}{id}{versionDelimiter}{ver}",
            ({ Length: > 0 } sys, { Length: > 0 } id, _)                   => $"{sys}{systemDelimiter}{id}",
            (_, { Length: > 0 } id, { Length: > 0 } ver)                   => $"{id}{versionDelimiter}{ver}",
            (_, { Length: > 0 } id, _)                                     => id,
            _                                                              => null
        };
}