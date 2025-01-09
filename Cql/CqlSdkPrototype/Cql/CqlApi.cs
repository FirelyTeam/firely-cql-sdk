using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Cql;

using CqlTranslationEntriesMap = System.Collections.Immutable.ImmutableDictionary<
    CqlVersionedLibraryIdentifier,
    CqlTranslationEntry>;

public class CqlApi :
    ICqlApi<CqlApi>
{
    #region State

    private readonly State _state;
    CqlApiOptions ICqlApi<CqlApi>.Options => _state.Options;
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, CqlTranslationEntry> ICqlApi<CqlApi>.Entries => _state.Entries;

    private readonly record struct State(
        CqlApiOptions Options,
        CqlTranslationEntriesMap Entries)
    {
        public ILogger<CqlApi> Logger { get; } = Options.ServiceProvider.GetLogger<CqlApi>();
        public CqlToElmConverter CqlToElmConverter { get; } = Options.ServiceProvider.GetCqlToElmConverter();
    }

    #endregion

    #region Construction

    public static CqlApi Create(IServiceProvider serviceProvider)
    {
        var options = CqlApiOptions.Create(serviceProvider);
        var entries = CqlTranslationEntriesMap.Empty.WithComparers(CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
        var state = new State(options, entries);
        return new CqlApi(state);
    }

    private CqlApi(State state)
    {
        _state = state;
    }

    private CqlApi WithEntries(CqlTranslationEntriesMap entries)
    {
        return new CqlApi(_state with { Entries = entries });
    }

    public CqlApi WithOptions(Func<CqlApiOptions, CqlApiOptions> replaceOptions)
    {
        var newOptions = replaceOptions(_state.Options);
        return ReferenceEquals(_state.Options, newOptions) ? this : new CqlApi(_state with { Options = newOptions });
    }

    #endregion

    #region Input (CQL Library Strings)

    public CqlApi AddCqlLibraries(IEnumerable<CqlLibraryString> cqlLibraries)
    {
        var logger = _state.Logger;
        var libraryCompilationsBuilder = _state.Entries.ToBuilder();
        var hasChanged = false;
        foreach (var cqlLibrary in cqlLibraries)
        {
            var versionedIdentifier = cqlLibrary.VersionedLibraryIdentifier;

            if (libraryCompilationsBuilder.ContainsKey(versionedIdentifier))
            {
                logger.LogInformation("Skipping adding previous cql to translation: {versionedIdentifier}", versionedIdentifier);
                continue;
            }

            var libraryCompilation = new CqlTranslationEntry(cqlLibrary);
            libraryCompilationsBuilder.Add(versionedIdentifier, libraryCompilation);
            logger.LogInformation("Adding cql library to translation: {versionedIdentifier}", versionedIdentifier);
            hasChanged = true;
        }

        return hasChanged
                   ? WithEntries(entries: libraryCompilationsBuilder.ToImmutable())
                   : this;
    }

    #endregion

    #region Processing (CQL-to-ELM)

    public CqlApi Translate(Action<CqlTranslateResult>? result = null)
    {
        CqlToElmConverter cqlToElmConverter = null!;
        CqlTranslationEntriesMap.Builder entriesBuilder = null!;
        var logger = _state.Logger;
        bool atFirst = true;

        IEnumerable<(CqlVersionedLibraryIdentifier versionedIdentifier, CqlTranslationEntry cqlTranslationEntry)> GetLibrariesForProcessing()
        {
            foreach (var (versionedIdentifier, cqlTranslationEntry) in
                     _state.Entries.Where(kv => kv.Value.ElmLibrary is null))
            {
                if (atFirst)
                {
                    atFirst = false;
                    logger.LogInformation("Translating CQL into ELM");
                    cqlToElmConverter = _state.CqlToElmConverter;
                    entriesBuilder = _state.Entries.ToBuilder();
                }

                logger.LogInformation("Translating CQL: {id}", versionedIdentifier);
                yield return (versionedIdentifier, cqlTranslationEntry);
            }
        }

        LogExceptionMessageAction log = logger.GetLogExceptionMessageAction(_state.Options.ProcessBatchItemExceptionHandling);

        int changedCount =
                GetLibrariesForProcessing()
                    .TryProcessEach(t => ProcessLibrary(t.versionedIdentifier, t.cqlTranslationEntry))
                    .WithEachException(outcome =>
                    {
                        var libraryName = outcome.Input.versionedIdentifier;
                        log(outcome.Exception, "Error translating CQL library '{libraryName}' to ELM.", libraryName);
                    })
                    .HandleExceptions(_state.Options.ProcessBatchItemExceptionHandling)
                    .Count() // We must enumerate all
            ;

        return changedCount > 0
                   ? WithEntries(entries: entriesBuilder.ToImmutable())
                   : this;

        void ProcessLibrary(CqlVersionedLibraryIdentifier versionedIdentifier, CqlTranslationEntry cqlTranslationEntry)
        {
            var cql = cqlTranslationEntry.CqlLibraryString.Cql;
            var library = cqlToElmConverter.ConvertLibrary(new StringReader(cql));
            entriesBuilder[versionedIdentifier] = cqlTranslationEntry with { ElmLibrary = library };
        }
    }

    #endregion
}