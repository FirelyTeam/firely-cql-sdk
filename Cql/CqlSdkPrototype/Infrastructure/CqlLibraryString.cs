using System.Text.RegularExpressions;

namespace CqlSdkPrototype.Infrastructure;

public readonly partial record struct CqlLibraryString
{
    public static CqlLibraryString Empty { get; } = new(CqlVersionedLibraryIdentifier.Empty, string.Empty);

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
                    (?<id>\S+)       # The identifier of the library
                    \s+
                    version
                    \s'(?<ver>[^']+)' # The version of the library between single quotes
                    """,
                    RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline)]
    private static partial Regex LibraryNameAndVersionRegex();

    public static CqlLibraryString FromCql(string cqlContent)
    {
        var match = LibraryNameAndVersionRegex().Match(cqlContent);
        if (!match.Success)
            throw new FormatException("Could not get library identifier and version from provided cql string.");
        var id = match.Groups["id"].Value;
        var ver = match.Groups["ver"].Value;
        var libVer = CqlVersionedLibraryIdentifier.FromNameAndVersion(CqlLibraryIdentifier.Parse(id), CqlLibraryVersion.Parse(ver));
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