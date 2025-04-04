/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm;

/// <summary>
/// Represents a CQL library with its content as a string
/// as well as its library identifier, extracted from the content.
/// </summary>
public readonly partial record struct CqlLibraryString
{
    /// <summary>
    /// Creates a new instance of <see cref="CqlLibraryString"/> from the given identifier and content.
    /// </summary>
    /// <param name="libraryIdentifier">The identifier of the CQL library.</param>
    /// <param name="cqlContent">The content of the CQL library.</param>
    /// <returns>A new instance of <see cref="CqlLibraryString"/>.</returns>
    public static CqlLibraryString FromIdentifierAndString(
        CqlVersionedLibraryIdentifier libraryIdentifier,
        string cqlContent)
    {
        return new CqlLibraryString(libraryIdentifier, cqlContent);
    }

    /// <summary>
    /// Regex to extract the library name and optional version from a CQL string.
    /// The CQL specification for it can be found at https://cql.hl7.org/19-l-cqlsyntaxdiagrams.html#library
    /// under libraryDefinition.
    /// </summary>
    /// <returns>A <see cref="Regex"/> to extract the library name and version.</returns>
    [GeneratedRegex("""
                         \A
                         (?:                # Non-capturing group for block comments, line comments and whitespace
                           /\*              #   Start of block comment
                           [\s\S]*?         #   Match any characters (including newlines) non-greedily
                           \*/              #   End of block comment
                         |                  # OR
                           //               #   Start of line comment
                           [^\r\n]*         #   Match any characters except newlines
                         |                  # OR
                           \s               #   Match any whitespace character
                         )*                 # Zero or more occurrences of the above
                         library            # until "library" is found
                         \s+                # at least one space
                         (?<lib>\S+)        # The name of the library
                         (?:
                           \s+              # at least one space
                           version          # version keyword
                           \s*              # optional spaces
                           '(?<ver>[^']+)'  # The version of the library between single quotes
                         )?                 # Version is optional
                     """,
                    RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline)]
    private static partial Regex LibraryNameAndVersionRegex();

    /// <summary>
    /// Parses a CQL string to create a <see cref="CqlLibraryString"/> instance.
    /// </summary>
    /// <param name="cqlContent">The content of the CQL library.</param>
    /// <returns>A new instance of <see cref="CqlLibraryString"/>.</returns>
    /// <exception cref="FormatException">Thrown when the library identifier and version cannot be extracted from the provided CQL string.</exception>
    public static CqlLibraryString Parse(string cqlContent)
    {
        var match = LibraryNameAndVersionRegex().Match(cqlContent);
        if (!match.Success)
            throw new FormatException("Could not get library identifier and version from provided cql string.");

        var lib = match.Groups["lib"].Value;
        var ver = match.Groups["ver"].Value.NullIfEmpty();
        var libVer = CqlVersionedLibraryIdentifier.ParseFromNameAndVersion(lib, ver);
        return new CqlLibraryString(libVer, cqlContent);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CqlLibraryString"/> struct.
    /// </summary>
    /// <param name="libraryIdentifier">The identifier of the CQL library.</param>
    /// <param name="cql">The content of the CQL library.</param>
    private CqlLibraryString(
        CqlVersionedLibraryIdentifier libraryIdentifier,
        string cql)
    {
        LibraryIdentifier = libraryIdentifier;
        Cql = cql;
    }

    /// <summary>
    /// Gets the identifier of the CQL library.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier { get; }

    /// <summary>
    /// Gets the content of the CQL library.
    /// </summary>
    public string Cql { get; }

    /// <summary>
    /// Deconstructs the <see cref="CqlLibraryString"/> into its components.
    /// </summary>
    /// <param name="libraryIdentifier">The identifier of the CQL library.</param>
    /// <param name="cql">The content of the CQL library.</param>
    public void Deconstruct(
        out CqlVersionedLibraryIdentifier libraryIdentifier,
        out string cql)
    {
        libraryIdentifier = LibraryIdentifier;
        cql = Cql;
    }

    /// <summary>
    /// Implicitly converts a <see cref="CqlLibraryString"/> to a <see cref="string"/> using the CQL content.
    /// </summary>
    /// <returns>Returns the CQL.</returns>
    public static implicit operator string(CqlLibraryString cqlLibraryString) => cqlLibraryString.Cql;

    /// <summary>
    /// Explicitly parses a <see cref="string"/> to a <see cref="CqlLibraryString"/>.
    /// </summary>
    /// <returns>Returns the <see cref="CqlLibraryString"/>.</returns>
    public static explicit operator CqlLibraryString(string cqlLibraryString) => Parse(cqlLibraryString);
}
