using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Cql.Extensibility;

public interface ICqlApi
{
    ILoggerFactory LoggerFactory { get; }
    CqlApiOptions Options { get; }
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry> Entries { get; }
    CqlApi WithOptions(Func<CqlApiOptions, CqlApiOptions> replaceOptions);
    CqlApi AddCqlLibraries(IEnumerable<CqlLibraryString> libraries);
    CqlApi Translate();
}