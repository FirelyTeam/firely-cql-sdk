namespace CqlSdkPrototype.Cql.Extensibility;

public interface ICqlApiExtensible<TCqlApi>
    where TCqlApi : ICqlApiExtensible<TCqlApi>
{
    CqlApiOptions Options { get; }
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, CqlTranslationEntry> Entries { get; }
    TCqlApi WithOptions(Func<CqlApiOptions, CqlApiOptions> replaceOptions);
    TCqlApi AddCqlLibraries(IEnumerable<CqlLibraryString> libraries);
    TCqlApi Translate();
}