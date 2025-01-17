using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging.Abstractions;

namespace CqlSdkPrototype.Cql;

using CqlTranslationEntriesMap = System.Collections.Immutable.ImmutableDictionary<
    CqlVersionedLibraryIdentifier,
    CqlApiStateEntry>;

public class CqlApi :
    ICqlApiExtendable<CqlApi>,
    ICqlApiInternal<CqlApi>
{
    internal CqlApi(CqlApiState state) => _state = state; // Might make this public later. Used for testing now.

    public CqlApi(
        ILoggerFactory? loggerFactory = null,
        CqlApiOptions? options = null) : this(CqlApiState.Create(loggerFactory ?? NullLoggerFactory.Instance, options ?? CqlApiOptions.Default))
    {}

    #region State

    private CqlApiState _state;

    private CqlApi WithEntries(
        CqlTranslationEntriesMap entries)
    {
        _state = _state with { Entries = entries };
        return this;
        // return new CqlApi(_state with { Entries = entries });
    }

    public CqlApi WithOptions(
        Func<CqlApiOptions, CqlApiOptions> replaceOptions)
    {
        var newOptions = replaceOptions(_state.Options);
        _state = _state with { Options = newOptions };
        return this;
    }

    ILoggerFactory ICqlApiExtendable<CqlApi>.LoggerFactory => _state.LoggerFactory;
    CqlApiOptions ICqlApiExtendable<CqlApi>.Options => _state.Options;
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry> ICqlApiExtendable<CqlApi>.Entries => _state.Entries;
    CqlApiState ICqlApiInternal<CqlApi>.State => _state;

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

            var libraryCompilation = new CqlApiStateEntry(cqlLibrary);
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

    public CqlApi Translate()
    {
        CqlToElmConverter cqlToElmConverter = _state.CqlToElmConverter;
        CqlTranslationEntriesMap.Builder entriesBuilder = null!;
        var logger = _state.Logger;
        bool atFirst = true;

        IEnumerable<(CqlVersionedLibraryIdentifier versionedIdentifier, CqlApiStateEntry cqlTranslationEntry)> GetLibrariesForProcessing()
        {
            foreach (var (versionedIdentifier, cqlTranslationEntry) in
                     _state.Entries.Where(kv => kv.Value.ElmLibrary is null))
            {
                if (atFirst)
                {
                    atFirst = false;
                    logger.LogInformation("Translating CQL into ELM");
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

        void ProcessLibrary(CqlVersionedLibraryIdentifier versionedIdentifier, CqlApiStateEntry cqlTranslationEntry)
        {
            var cql = cqlTranslationEntry.CqlLibraryString.Cql;
            var library = cqlToElmConverter.ConvertLibrary(new StringReader(cql));
            entriesBuilder[versionedIdentifier] = cqlTranslationEntry with { ElmLibrary = library };
        }
    }

    #endregion
}