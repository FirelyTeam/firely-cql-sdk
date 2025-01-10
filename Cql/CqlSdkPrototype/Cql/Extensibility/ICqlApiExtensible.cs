namespace CqlSdkPrototype.Cql.Extensibility;

public interface ICqlApiExtensible<TCqlApi>
    where TCqlApi : ICqlApiExtensible<TCqlApi>
{
    static abstract TCqlApi Create(CqlApiOptions options);
    CqlApiOptions Options { get; }
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, CqlTranslationEntry> Entries { get; }
    TCqlApi WithOptions(Func<CqlApiOptions, CqlApiOptions> replaceOptions);
    TCqlApi AddCqlLibraries(IEnumerable<CqlLibraryString> libraries);
    TCqlApi Translate();
    TCqlApi UseServices(Func<(TCqlApi cqlApi, ILogger<TCqlApi> logger), TCqlApi> action); // Useful for extensions methods
}