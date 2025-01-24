using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Cql;

public class CqlApi :
    ICqlApiExtendable<CqlApi>
{
    public CqlApi(
        ILoggerFactory? loggerFactory = null,
        CqlApiOptions? options = null)
    {
        options ??= CqlApiOptions.Default;
        var entries = CqlApiStateEntryDictionary.Empty.WithComparers(CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
        var entriesBuilder = entries.ToBuilder();
        var libraryProvider = new EntriesBuilderLibraryProvider(entriesBuilder);
        _entries = entries;
        Services = CqlApiServices.Create(loggerFactory ?? NullLoggerFactory.Instance, options, libraryProvider);
        _options = options;
    }

    #region State

    internal CqlApiServices Services { get; private set; }
    private CqlApiStateEntryDictionary _entries;
    private CqlApiOptions _options;

    private CqlApi WithEntries(
        CqlApiStateEntryDictionary entries)
    {
        _entries = entries;
        Services.LibraryProvider.EntriesBuilder = entries.ToBuilder();
        return this;
    }

    public CqlApi WithOptions(
        Func<CqlApiOptions, CqlApiOptions> replaceOptions)
    {
        var libraryProvider = Services.LibraryProvider;
        Services.ServiceProvider.Dispose();
        _options = replaceOptions(_options);
        Services = CqlApiServices.Create(Services.LoggerFactory, _options, libraryProvider);
        return this;
    }

    ILoggerFactory ICqlApiExtendable<CqlApi>.LoggerFactory => Services.LoggerFactory;
    CqlApiOptions ICqlApiExtendable<CqlApi>.Options => _options;
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, CqlApiStateEntry> ICqlApiExtendable<CqlApi>.Entries => _entries;

    #endregion

    #region Input (CQL Library Strings)

    public CqlApi AddCqlLibraries(IEnumerable<CqlLibraryString> cqlLibraries)
    {
        var logger = Services.Logger;
        var entriesBuilder = Services.LibraryProvider.EntriesBuilder;
        var cqlToElmConverter = Services.CqlToElmConverter;
        using var scope = Services.ServiceProvider.CreateScope()!;
        var hasChanged = false;
        foreach (var cqlLibrary in cqlLibraries)
        {
            var versionedIdentifier = cqlLibrary.VersionedLibraryIdentifier;

            if (entriesBuilder.ContainsKey(versionedIdentifier))
            {
                logger.LogInformation("Skipping adding previous cql to translation: {versionedIdentifier}", versionedIdentifier);
                continue;
            }

            var libraryVisitor = CqlToElmConverter.GetLibraryVisitorScoped(scope);
            var libraryBuilder = cqlToElmConverter.GetBuilder(libraryVisitor, cqlLibrary.Cql);
            var entry = new CqlApiStateEntry(cqlLibrary) { ElmLibraryBuilder = libraryBuilder };
            entriesBuilder.Add(versionedIdentifier, entry);
            logger.LogInformation("Adding cql library to translation: {versionedIdentifier}", versionedIdentifier);
            hasChanged = true;
        }

        return hasChanged
                   ? WithEntries(entries: entriesBuilder.ToImmutable())
                   : this;
    }

    #endregion

    #region Processing (CQL-to-ELM)

    public CqlApi Translate()
    {
        CqlApiStateEntryDictionary.Builder entriesBuilder = Services.LibraryProvider.EntriesBuilder;
        var logger = Services.Logger;
        bool atFirst = true;

        IEnumerable<(CqlVersionedLibraryIdentifier versionedIdentifier, CqlApiStateEntry cqlTranslationEntry)> GetLibrariesForProcessing()
        {
            foreach (var (versionedIdentifier, cqlTranslationEntry) in
                     _entries.Where(kv => kv.Value.ElmLibrary is null))
            {
                if (atFirst)
                {
                    atFirst = false;
                    logger.LogInformation("Translating CQL into ELM");
                }

                logger.LogInformation("Translating CQL: {id}", versionedIdentifier);
                yield return (versionedIdentifier, cqlTranslationEntry);
            }
        }

        LogExceptionMessageAction log = logger.GetLogExceptionMessageAction(_options.ProcessBatchItemExceptionHandling);

        int changedCount =
                GetLibrariesForProcessing()
                    .TryProcessEach(t => ProcessLibrary(t.versionedIdentifier, t.cqlTranslationEntry))
                    .WithEachException(outcome =>
                    {
                        var libraryName = outcome.Input.versionedIdentifier;
                        log(outcome.Exception, "Error translating CQL library '{libraryName}' to ELM.", libraryName);
                    })
                    .HandleExceptions(_options.ProcessBatchItemExceptionHandling)
                    .Count() // We must enumerate all
            ;

        if (changedCount <= 0)
            return this;

        return WithEntries(entries: entriesBuilder.ToImmutable());

        void ProcessLibrary(CqlVersionedLibraryIdentifier versionedIdentifier, CqlApiStateEntry cqlTranslationEntry)
        {
            var library = cqlTranslationEntry.ElmLibraryBuilder!.Build();
            entriesBuilder[versionedIdentifier] = cqlTranslationEntry with { ElmLibrary = library };
        }
    }

    #endregion
}