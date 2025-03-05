/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents a versioned identifier for a CQL library.
/// </summary>
/// <param name="Identifier">The identifier of the CQL library.</param>
/// <param name="Version">The version of the CQL library.</param>
public readonly record struct CqlVersionedLibraryIdentifier(
    CqlLibraryIdentifier Identifier,
    CqlLibraryVersion? Version = null) : IParsable<CqlVersionedLibraryIdentifier>
{
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
    public static CqlVersionedLibraryIdentifier ParseFromNameAndVersion(string identifier, string? version = null)
    {
        CqlLibraryIdentifier cqlLibraryIdentifier = (CqlLibraryIdentifier)identifier;
        CqlLibraryVersion? cqlLibraryVersion = version is null ? null : (CqlLibraryVersion?)version;
        return FromNameAndVersion(cqlLibraryIdentifier, cqlLibraryVersion);
    }

    /// <summary>
    /// Creates a <see cref="CqlVersionedLibraryIdentifier"/> from the given identifier and version.
    /// </summary>
    /// <param name="identifier">The CQL library identifier.</param>
    /// <param name="version">The CQL library version (optional).</param>
    /// <returns>A <see cref="CqlVersionedLibraryIdentifier"/> instance.</returns>
    public static CqlVersionedLibraryIdentifier FromNameAndVersion(CqlLibraryIdentifier identifier, CqlLibraryVersion? version = null)
    {
        return new CqlVersionedLibraryIdentifier(identifier, version);
    }

    /// <summary>
    /// Returns a string representation of the CQL versioned library identifier.
    /// </summary>
    /// <returns>A string representation of the CQL versioned library identifier.</returns>
    public override string ToString()
    {
        return FormatString(Identifier, Version);
    }

    /// <summary>
    /// Returns a string representation of the CQL versioned library identifier.
    /// </summary>
    /// <param name="identifier">The identifier string.</param>
    /// <param name="version">The version string (optional).</param>
    /// <returns>A string representation of the CQL versioned library identifier.</returns>
    public static string FormatString(string identifier, string? version = null) =>
        version switch
        {
            not null => $"{identifier}-{version}",
            _ => identifier,
        };

    #region Parsing

    /// <summary>
    /// Parses a CQL versioned library identifier from the given string.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <param name="provider">The format provider (optional).</param>
    /// <returns>A <see cref="CqlVersionedLibraryIdentifier"/> instance.</returns>
    static CqlVersionedLibraryIdentifier IParsable<CqlVersionedLibraryIdentifier>.Parse(string s, IFormatProvider? provider)
    {
        return Parse(s);
    }

    /// <summary>
    /// Parses a CQL versioned library identifier from the given string.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <returns>A <see cref="CqlVersionedLibraryIdentifier"/> instance.</returns>
    /// <exception cref="FormatException">Thrown when the string is not a valid CQL versioned library identifier.</exception>
    public static CqlVersionedLibraryIdentifier Parse(string s)
    {
        return TryParse(s, out var result)
                   ? result
                   : throw new FormatException("Not a valid CqlVersionedLibraryIdentifier");
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
        out CqlVersionedLibraryIdentifier result)
    {
        return TryParse(s, out result);
    }

    /// <summary>
    /// Tries to parse a CQL versioned library identifier from the given string.
    /// </summary>
    /// <param name="s">The string to parse.</param>
    /// <param name="result">When this method returns, contains the parsed CQL versioned library identifier, if the parsing succeeded.</param>
    /// <returns><c>true</c> if the parsing succeeded; otherwise, <c>false</c>.</returns>
    public static bool TryParse(string? s, out CqlVersionedLibraryIdentifier result)
    {
        if (s is not null)
        {
            var tokens = s.Split('-', 2);
            if (CqlLibraryIdentifier.TryParse(tokens[0], out var name))
            {
                switch (tokens.Length)
                {
                    case 1:
                        result = FromNameAndVersion(name);
                        return true;

                    case 2 when CqlLibraryVersion.TryParse(tokens[1], out var version):
                        result = FromNameAndVersion(name, version);
                        return true;
                }
            }
        }

        result = default;
        return false;
    }

    #endregion

    #region Cast Operators

    /// <summary>
    /// Implicitly converts a <see cref="CqlLibraryIdentifier"/> to a <see cref="CqlVersionedLibraryIdentifier"/>.
    /// </summary>
    /// <param name="identifier">The CQL library identifier.</param>
    public static implicit operator CqlVersionedLibraryIdentifier(CqlLibraryIdentifier identifier) => FromNameAndVersion(identifier);

    #endregion
}
