using CqlSdkPrototype.Advanced;
using CqlSdkPrototype.CqlToElm.Advanced;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

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

    internal static CqlApi Create(CqlApiOptions options)
    {
        var entries = CqlTranslationEntriesMap.Empty.WithComparers(CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
        var state = new State(options, entries);
        return new CqlApi(state);
    }

    private CqlApi(State state)
    {
        _state = state;
    }

    private CqlApi Mutate(
        CqlTranslationEntriesMap? entries = null)
    {
        return new CqlApi(_state with
        {
            Entries = entries ?? _state.Entries,
        });
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
                   ? Mutate(entries: libraryCompilationsBuilder.ToImmutable())
                   : this;
    }

    #endregion

    #region Processing

    public CqlApi ConvertToElm()
    {
        CqlToElmConverter cqlToElmConverter = null!;
        var entriesBuilder = _state.Entries.ToBuilder();
        int changedCount = 0;

        IEnumerable<(CqlVersionedLibraryIdentifier versionedIdentifier, CqlTranslationEntry cqlTranslationEntry)> GetLibrariesForProcessing()
        {
            foreach (var (versionedIdentifier, cqlTranslationEntry) in entriesBuilder
                         .Where(kv => kv.Value.ElmLibrary is null))
            {
                if (changedCount == 0)
                {
                    _state.Logger.LogInformation("Translating CQL into ELM");
                    cqlToElmConverter = _state.CqlToElmConverter;
                    entriesBuilder = _state.Entries.ToBuilder();
                }

                _state.Logger.LogInformation("Translating CQL: {id}", versionedIdentifier);
                yield return (versionedIdentifier, cqlTranslationEntry);
                changedCount++;
            }
        }

        ExceptionHandlingMethods.ProcessBatchWithExceptionHandlingAndLogging(
            items: GetLibrariesForProcessing(),
            process: t => ProcessLibrary(t.versionedIdentifier, t.cqlTranslationEntry),
            exceptionHandling: _state.Options.ProcessBatchItemExceptionHandling,
            logger: _state.Logger,
            buildLoggerMessage: (exceptionHandling, item, exception) => (exceptionHandling, exception) switch
            {
                (ProcessBatchItemExceptionHandling.ThrowException, { }) => ("Error translating CQL library '{libraryName}' to ELM.", [item.versionedIdentifier]),
                (ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue, { }) => ("Error ignored CQL translating library '{libraryName}' to ELM, continuing to next library.", [item.versionedIdentifier]),
                (ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak, { }) => ("Error ignored CQL translating library '{libraryName}' to ELM, abort processing more libraries.", [item.versionedIdentifier]),
                _ => null,
            });

        return changedCount > 0
                   ? Mutate(entries: entriesBuilder.ToImmutable())
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