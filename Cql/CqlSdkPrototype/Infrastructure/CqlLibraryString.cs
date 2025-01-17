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

    [GeneratedRegex("""
           (\s+\r?\n?)*library\s+(?<lib>\S+)\s+version\s'(?<ver>[^']+)'
           """)]
    private static partial Regex LibraryNameAndVersionRegex();

    public static CqlLibraryString FromCql(string cqlContent)
    {
        var match = LibraryNameAndVersionRegex().Match(cqlContent);
        if (!match.Success)
            throw new FormatException("Could not get library identifier and version from provided cql string/");
        var lib = match.Groups["lib"].Value;
        var ver = match.Groups["ver"].Value;
        var libVer = CqlVersionedLibraryIdentifier.FromNameAndVersion(CqlLibraryIdentifier.Parse(lib), CqlLibraryVersion.Parse(ver));
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