namespace CqlSdkPrototype.Cql.Extensibility;

public interface ICqlApi<out TCqlApi>
    where TCqlApi : ICqlApi<TCqlApi>
{
    // static abstract TCqlApi Create(CqlApiOptions options);
    static abstract TCqlApi Create(IServiceProvider serviceProvider);
    CqlApiOptions Options { get; }
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, CqlTranslationEntry> Entries { get; }
    TCqlApi WithOptions(Func<CqlApiOptions, CqlApiOptions> replaceOptions);
    TCqlApi AddCqlLibraries(IEnumerable<CqlLibraryString> libraries);
    TCqlApi Translate(Action<CqlTranslateResult>? result = null);
}

public record CqlTranslateResult; // Will contain the result of the translation from CQL to ELM, and include the deltas of the entities that were added, updated, or removed.