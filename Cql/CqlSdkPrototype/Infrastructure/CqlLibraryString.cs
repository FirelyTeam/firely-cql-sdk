using System.Text.RegularExpressions;

namespace CqlSdkPrototype.Infrastructure;

public readonly partial record struct CqlLibraryString
{
    public static CqlLibraryString FromIdentifierAndString(
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        string cqlContent)
    {
        return new CqlLibraryString(versionedLibraryIdentifier, cqlContent);
    }

    /// <summary>
    /// Regex to extract the library name and optional version from a CQL string.
    /// The CQL specification for it can be found at https://cql.hl7.org/19-l-cqlsyntaxdiagrams.html#library
    /// under libraryDefinition.
    /// </summary>
    [GeneratedRegex("""
                    (\s+\r?\n?)*      # Skip whitespace and newlines
                    library           # until "library" is found
                    \s+
                    (?<lib>\S+)       # The name of the library
                    (
                      \s+
                      version
                      \s'(?<ver>[^']+)' # The version of the library between single quotes
                    )?                # Version is optional
                    """,
                    RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline)]
    private static partial Regex LibraryNameAndVersionRegex();

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

    private CqlLibraryString(
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        string cql)
    {
        VersionedLibraryIdentifier = versionedLibraryIdentifier;
        Cql = cql;
    }

    public CqlVersionedLibraryIdentifier VersionedLibraryIdentifier { get; init; }

    public string Cql { get; init; }

    public void Deconstruct(
        out CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        out string cql)
    {
        versionedLibraryIdentifier = VersionedLibraryIdentifier;
        cql = Cql;
    }
}

file static class StringExtensions
{
    public static string? NullIfEmpty(this string? text) => string.IsNullOrEmpty(text) ? null : text;
}
