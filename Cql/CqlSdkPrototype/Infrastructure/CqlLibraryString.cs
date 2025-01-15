namespace CqlSdkPrototype.Infrastructure;

public readonly record struct CqlLibraryString
{
    public static CqlLibraryString Empty { get; } = new(CqlVersionedLibraryIdentifier.Empty, string.Empty);

    public static CqlLibraryString FromIdentifierAndString(
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        string cqlContent)
    {
        return new CqlLibraryString(versionedLibraryIdentifier, cqlContent);
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