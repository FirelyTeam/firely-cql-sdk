using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Cql.Extensibility;

public interface ICqlApiExtendable<TCqlApi>
    where TCqlApi : ICqlApiExtendable<TCqlApi>
{
    ILoggerFactory LoggerFactory { get; }
    CqlApiOptions Options { get; }
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry> Entries { get; }
    TCqlApi WithOptions(Func<CqlApiOptions, CqlApiOptions> replaceOptions);
    TCqlApi AddCqlLibraries(IEnumerable<CqlLibraryString> libraries);
    TCqlApi Translate();
}