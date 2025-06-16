/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime.Parsing;
using Hl7.Cql.Runtime.Serialization;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents a versioned identifier for a CQL library.
/// </summary>
/// <param name="Identifier">The identifier of the CQL library.</param>
/// <param name="Version">The version of the CQL library.</param>
[JsonConverter(typeof(StringEncapsulatedValueJsonConverter<CqlVersionedLibraryIdentifier>))]
public readonly partial record struct CqlVersionedLibraryIdentifier(
    CqlLibraryIdentifier Identifier,
    CqlLibraryVersion? Version = null) : IParsable<CqlVersionedLibraryIdentifier>
{
    private static readonly CqlParseErrorHandler OnErrorThrowFormatException = CqlParseErrorHandlerStrategies.OnErrorThrowException(typeof(CqlVersionedLibraryIdentifier));

    /// <summary>
    /// The delimiter to use between the qualifier and identifier part in the string representation.
    /// </summary>
    [UsedImplicitly] public const char SystemIdentifierDelimiter = '.';

    /// <summary>
    /// The delimiter to use between the identifier and version part in the string representation.
    /// </summary>
    [UsedImplicitly] public const char IdentifierVersionDelimiter = '-';

    /// <summary>
    /// Implicitly converts a <see cref="CqlVersionedLibraryIdentifier"/> to a <see cref="string"/>.
    /// </summary>
    /// <param name="versionedIdentifier">The <see cref="CqlVersionedLibraryIdentifier"/> to convert.</param>
    /// <returns>The string representation of the versioned identifier.</returns>
    public static implicit operator string(CqlVersionedLibraryIdentifier versionedIdentifier) => versionedIdentifier.ToString();

    /// <summary>
    /// Explicitly converts a <see cref="string"/> to a <see cref="CqlVersionedLibraryIdentifier"/>.
    /// </summary>
    /// <param name="versionedIdentifier">The string to convert.</param>
    /// <returns>The <see cref="CqlVersionedLibraryIdentifier"/> representation of the string.</returns>
    /// <exception cref="FormatException">Thrown when the string is not a valid versioned identifier.</exception>
    public static explicit operator CqlVersionedLibraryIdentifier(string versionedIdentifier) => Parse(versionedIdentifier);

    /// <summary>
    /// Parses a CQL versioned library identifier from the given name and version strings.
    /// </summary>
    /// <param name="identifier">The identifier string.</param>
    /// <param name="version">The version string (optional).</param>
    /// <returns>A <see cref="CqlVersionedLibraryIdentifier"/> instance.</returns>
    public static CqlVersionedLibraryIdentifier ParseFromIdentifierAndVersion(string identifier, string? version = null)
    {
        CqlLibraryIdentifier cqlLibraryIdentifier = (CqlLibraryIdentifier)identifier;
        CqlLibraryVersion? cqlLibraryVersion = version is null ? null : (CqlLibraryVersion?)version;
        return FromIdentifierAndVersion(cqlLibraryIdentifier, cqlLibraryVersion);
    }

    /// <summary>
    /// Creates a <see cref="CqlVersionedLibraryIdentifier"/> from the given identifier and version.
    /// </summary>
    /// <param name="identifier">The CQL library identifier.</param>
    /// <param name="version">The CQL library version (optional).</param>
    /// <returns>A <see cref="CqlVersionedLibraryIdentifier"/> instance.</returns>
    public static CqlVersionedLibraryIdentifier FromIdentifierAndVersion(CqlLibraryIdentifier identifier, CqlLibraryVersion? version = null)
    {
        return new CqlVersionedLibraryIdentifier(identifier, version);
    }

    /// <summary>
    /// Returns a string representation of the CQL versioned library identifier.
    /// </summary>
    /// <returns>A string representation of the CQL versioned library identifier.</returns>
    public override string ToString()
    {
        return ToString(IdentifierVersionDelimiter);
    }

    /// <summary>
    /// Returns a string representation of the CQL versioned library identifier.
    /// </summary>
    /// <returns>A string representation of the CQL versioned library identifier.</returns>
    internal string ToString(char identifierVersionDelimiter)
    {
        return BuildString(Identifier, Version, identifierVersionDelimiter)!;
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
    public static string? BuildString(
        string identifier,
        string? version = null,
        char delimiter = IdentifierVersionDelimiter) =>
        (identifier, version) switch
        {
            ({ Length: > 0 } id, { Length: > 0 } ver) => $"{id}{delimiter}{ver}",
            ({ Length: > 0 } id, _)                   => id,
            _ => null
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
    public static string? BuildString(
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

    #region Parsing

    /// <summary>
    /// Parses a CQL versioned library identifier from the given string.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <param name="provider">The format provider (optional).</param>
    /// <returns>A <see cref="CqlVersionedLibraryIdentifier"/> instance.</returns>
    static CqlVersionedLibraryIdentifier IParsable<CqlVersionedLibraryIdentifier>.Parse(string s, IFormatProvider? provider) =>
        Parse(s);

    /// <summary>
    /// Parses a CQL versioned library identifier from the given string.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <returns>A <see cref="CqlVersionedLibraryIdentifier"/> instance.</returns>
    /// <exception cref="FormatException">Thrown when the string is not a valid CQL versioned library identifier.</exception>
    public static CqlVersionedLibraryIdentifier Parse(string s)
    {
        TryParse(s, out var result, OnErrorThrowFormatException);
        return result!;
    }

    /// <summary>
    /// Tries to parse a CQL versioned library identifier from the given string.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <param name="provider">The format provider (optional).</param>
    /// <param name="result">When this method returns, contains the parsed CQL versioned library identifier, if the parsing succeeded.</param>
    /// <returns><c>true</c> if the parsing succeeded; otherwise, <c>false</c>.</returns>
    static bool IParsable<CqlVersionedLibraryIdentifier>.TryParse(
        [NotNullWhen(true)] string? s,
        IFormatProvider? provider,
        out CqlVersionedLibraryIdentifier result) =>
        TryParse(s, out result);

    /// <summary>
    /// Attempts to parse the specified string into a <see cref="CqlVersionedLibraryIdentifier"/>.
    /// </summary>
    /// <param name="s">
    /// The string to parse. This should represent a versioned library identifier, optionally including a version.
    /// </param>
    /// <param name="result">
    /// When this method returns, contains the parsed <see cref="CqlVersionedLibraryIdentifier"/> if the parsing succeeded;
    /// otherwise, contains the default value of <see cref="CqlVersionedLibraryIdentifier"/>.
    /// </param>
    /// <param name="onError">
    /// An optional error handler to invoke if parsing fails. If not provided, no error handling will occur.
    /// </param>
    /// <returns>
    /// <c>true</c> if the string was successfully parsed into a <see cref="CqlVersionedLibraryIdentifier"/>; otherwise, <c>false</c>.
    /// </returns>
    public static bool TryParse(
        string? s,
        out CqlVersionedLibraryIdentifier result,
        CqlParseErrorHandler? onError = null)
    {
        if (!string.IsNullOrEmpty(s))
        {
            if (TrySplitIdentifierAndVersion(s, out var npair, CqlParseErrorHandlerStrategies.OnErrorIgnore))
            {
                var (identifierPart, versionPart) = npair.Value;
                if (string.IsNullOrEmpty(versionPart)
                    && CqlLibraryIdentifier.TryParse(identifierPart, out var nidentifier))
                {
                    result = FromIdentifierAndVersion(nidentifier.Value);
                    return true;
                }

                if (CqlLibraryIdentifier.TryParse(identifierPart, out nidentifier)
                    && CqlLibraryVersion.TryParse(versionPart, out var nversion))
                {
                    result = FromIdentifierAndVersion(nidentifier.Value, nversion.Value);
                    return true;
                }
            }
        }

        onError?.Invoke(CqlParseErrors.CannotSplitIdentifierAndVersionByDash);
        result = default;
        return false;
    }

    private static bool TrySplitIdentifierAndVersion(
        string s,
        [NotNullWhen(true)] out (string identifier, string? version)? value,
        CqlParseErrorHandler? onError = null)
    {
        Debug.Assert(s.Length > 0, "Span must not be empty.");
        value = null;

        // Stack allocated array of int with length 2
        int indicesCount = 0;
        Span<int> indices = stackalloc int[2];
        var span = s.AsSpan();

        for (int i = span.Length - 1; i >= 0; i--)
        {
            if (span[i] == IdentifierVersionDelimiter)
            {
                indices[indicesCount] = i;
                indicesCount++;
                if (indicesCount == 2)
                {
                    // We found the second delimiter, so we can stop searching
                    break;
                }
            }
        }

        if (indicesCount == 0)
        {
            // No version part, just an identifier
            value = (s, null);
            return true;
        }

        if (indicesCount == 1)
        {
            var version = span[(indices[0] + 1)..];
            if (version.Length == 0)
            {
                // Version part is empty, so assume last dash is part of the identifier
                value = (s, null);
                return true;
            }

            var identifier = span[..indices[0]];
            if (identifier.Length == 0)
            {
                onError?.Invoke(CqlParseErrors.NullOrEmpty);
                return false;
            }

            value = (identifier.ToString(), version.ToString());
            return true;
        }

        // We have two or more delimiters. Both identifier and version parts may contain the delimiter itself
        // for example: "my-lib-1.0.0" or "my-lib-1.0.0-beta" or "my-lib-v1.0.0-beta".
        // In this case we do a regex on the end part for a semantic version pattern.
        //
        // NOTE: Version part doesn't have to be a valid semantic version, it can be any string,
        // in this case we can't detect the correct split.

        var matches = RegexForSemanticVersionAtEnd().Matches(s);
        if (matches.Count == 1)
        {
            var match = matches[0];
            var identifier = s[..match.Index];
            var version = s[(match.Index+1)..]; // +1 to skip the delimiter
            value = (identifier, version);
            return true;
        }

        onError?.Invoke(CqlParseErrors.CannotSplitIdentifierAndVersionByDash);
        return false;
    }
    [GeneratedRegex(
        """
        -          # Match a literal hyphen before the version
        [vV]?      # Optional 'v' or 'V' prefix
        \d+        # Major version (one or more digits)
        \.         # Dot separator
        \d+        # Minor version
        (?:        # Optional non-capturing group for patch
         \.         #  Dot separator
         \d+        #  Patch version
        )?
        (?:        # Optional non-capturing group for pre-release
         \-[\w.-]+  # Hyphen followed by one or more word chars, dots, or hyphens
        )?
        (?:        # Optional non-capturing group for build metadata
         \+[\w.-]+  # Plus sign followed by one or more word chars, dots, or hyphens
        )?
        $          # End of string
        """, RegexOptions.IgnorePatternWhitespace
    )]
    private static partial Regex RegexForSemanticVersionAtEnd();

    #endregion

    #region Cast Operators

    /// <summary>
    /// Implicitly converts a <see cref="CqlLibraryIdentifier"/> to a <see cref="CqlVersionedLibraryIdentifier"/>.
    /// </summary>
    /// <param name="identifier">The CQL library identifier.</param>
    public static implicit operator CqlVersionedLibraryIdentifier(CqlLibraryIdentifier identifier) => FromIdentifierAndVersion(identifier);

    #endregion

}
