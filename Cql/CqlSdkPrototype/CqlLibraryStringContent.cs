namespace CqlSdkPrototype;

public readonly record struct CqlLibraryStringContent
{
    public static CqlLibraryStringContent Empty { get; } = new(CqlVersionedLibraryIdentifier.Empty, string.Empty);

    public static CqlLibraryStringContent FromIdentifierAndString(
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        string cqlContent)
    {
        return new CqlLibraryStringContent(versionedLibraryIdentifier, cqlContent);
    }

    private CqlLibraryStringContent(
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