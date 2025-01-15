namespace CqlSdkPrototype.Cql.Extensibility;

public interface ICqlApiExtensible<TCqlApi>
    where TCqlApi : ICqlApiExtensible<TCqlApi>
{
    ILoggerFactory LoggerFactory { get; }
    CqlApiOptions Options { get; }
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry> Entries { get; }
    TCqlApi WithOptions(Func<CqlApiOptions, CqlApiOptions> replaceOptions);
    TCqlApi AddCqlLibraries(IEnumerable<CqlLibraryString> libraries);
    TCqlApi Translate();
}