using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Cql.Extensibility;

public interface ICqlApiExtensible<TCqlApi>
    where TCqlApi : ICqlApiExtensible<TCqlApi>
{
    static abstract TCqlApi Create(CqlApiOptions options);
    CqlApiOptions Options { get; }
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, CqlTranslationEntry> Entries { get; }
    TCqlApi WithOptions(Func<CqlApiOptions, CqlApiOptions> replaceOptions);
    TCqlApi AddCqlLibraries(IEnumerable<CqlLibraryString> libraries);
    TCqlApi Translate(Action<CqlTranslateResult>? result = null);
    TCqlApi UseServices(Func<(TCqlApi cqlApi, ILogger<TCqlApi> logger), TCqlApi> action); // Useful for extensions methods
}

public record CqlTranslateResult; // Will contain the result of the translation from CQL to ELM, and include the deltas of the entities that were added, updated, or removed.