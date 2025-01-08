using CqlSdkPrototype.Advanced;
using CqlSdkPrototype.CqlToElm.Advanced;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CqlSdkPrototype.CqlToElm;

using CqlTranslationEntriesMap = System.Collections.Immutable.ImmutableDictionary<
    CqlVersionedLibraryIdentifier,
    CqlApi.CqlTranslationEntry>;

public class CqlApi :
    ICqlApiBase<CqlApi>,
    ILogAccessor<CqlApi>
{
    private readonly State _state;
    ILogger<CqlApi> ILogAccessor<CqlApi>.Logger => _state.Logger;

    public CqlApiOptions Options => _state.Options;

    public IReadOnlyDictionary<CqlLibraryIdentifier, CqlVersionedLibraryIdentifier> GetVersionedIdentifiers() =>
        _state.Entries
              .ToDictionary(kv => kv.Key.Identifier, kv => kv.Key);

    internal IReadOnlyDictionary<CqlVersionedLibraryIdentifier, Library> GetElmLibraries() =>
        _state.Entries
              .Where(kv => kv.Value.ElmLibrary is not null)
              .ToDictionary(kv => kv.Key, kv => kv.Value.ElmLibrary!);

    internal IReadOnlyDictionary<CqlVersionedLibraryIdentifier, string> GetElmJsonStrings() =>
        GetElmLibraries()
            .ToDictionary(kv => kv.Key, kv =>
            {
                var json = kv.Value.SerializeToJson(true);
                return json;
            });

    #region Nested Types

    private readonly record struct State(
        CqlApiOptions Options,
        CqlTranslationEntriesMap Entries)
    {
        public ILogger<CqlApi> Logger { get; } = Options.ServiceProvider.GetLogger<CqlApi>();
        public CqlToElmConverter CqlToElmConverter { get; } = Options.ServiceProvider.GetCqlToElmConverter();
    }

    internal readonly record struct CqlTranslationEntry(CqlLibraryString CqlLibraryString, Library? ElmLibrary = null);

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
        var newOptions = replaceOptions(Options);
        return ReferenceEquals(Options, newOptions) ? this : new CqlApi(_state with { Options = newOptions });
    }

    #endregion

    #region Adding CQL Libraries

    public CqlApi AddCqlLibraryStrings(IEnumerable<CqlLibraryString> cqlLibraries)
    {
        var libraryCompilationsBuilder = _state.Entries.ToBuilder();
        var hasChanged = false;
        foreach (var cqlLibrary in cqlLibraries)
        {
            var versionedIdentifier = cqlLibrary.VersionedLibraryIdentifier;

            if (libraryCompilationsBuilder.ContainsKey(versionedIdentifier))
            {
                _state.Logger.LogInformation("Skipping adding previous cql to translation: {versionedIdentifier}", versionedIdentifier);
                continue;
            }

            var libraryCompilation = new CqlTranslationEntry(cqlLibrary);
            libraryCompilationsBuilder.Add(versionedIdentifier, libraryCompilation);
            _state.Logger.LogInformation("Adding cql library to translation: {versionedIdentifier}", versionedIdentifier);
            hasChanged = true;
        }

        return hasChanged
                   ? WithEntries(entries: libraryCompilationsBuilder.ToImmutable())
                   : this;
    }

    #endregion

    #region Processing

    public CqlApi ConvertToElm()
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

        int changedCount =
            GetLibrariesForProcessing()
            .TryProcessEach(t => ProcessLibrary(t.versionedIdentifier, t.cqlTranslationEntry))
            .HandleEachOutcome(outcome =>
            {
                if (outcome.Exception?.SourceException is { } exception)
                {
                    var libraryName = outcome.Input.versionedIdentifier;
                    switch (_state.Options.ProcessBatchItemExceptionHandling)
                    {
                        case ProcessBatchItemExceptionHandling.ThrowException:
                            logger.LogError(exception, "Error translating CQL library '{libraryName}' to ELM.", libraryName);
                            break;
                        case ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue:
                            logger.LogWarning(exception, "Error ignored CQL translating library '{libraryName}' to ELM, continuing to next library.", libraryName);
                            break;
                        case ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak:
                            logger.LogWarning(exception, "Error ignored CQL translating library '{libraryName}' to ELM, abort processing more libraries.", libraryName);
                            break;
                    }
                }
            })
            .HandleExceptions(_state.Options.ProcessBatchItemExceptionHandling)
            .Count() // We must enumerate all
            ; ;

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