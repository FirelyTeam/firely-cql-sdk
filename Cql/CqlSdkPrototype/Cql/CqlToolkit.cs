using CqlSdkPrototype.Cql.Extensibility;
using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Cql;

public class CqlToolkit :
    ICqlToolkit,
    ITestingOnlyServiceProviderAccessor<CqlToolkit>
{
    public CqlToolkit(
        ILoggerFactory? loggerFactory = null,
        CqlToolkitSettings? settings = null)
    {
        settings ??= CqlToolkitSettings.Default;
        var processItems = CqlToolkitProcessItems.Empty;
        var entriesBuilder = processItems.ToBuilder();
        var libraryProvider = new CqlToolkitProcessItemsLibraryProvider(entriesBuilder);
        _processItems = processItems;
        _services = CqlToolkitServices.Create(loggerFactory ?? NullLoggerFactory.Instance, settings, libraryProvider);
        _settings = settings;
    }

    #region State

    ServiceProvider ITestingOnlyServiceProviderAccessor<CqlToolkit>.ServiceProvider => _services.ServiceProvider;

    private CqlToolkitProcessItems _processItems;
    internal CqlToolkitSettings _settings;
    private CqlToolkitServices _services;

    private void WithEntries(CqlToolkitProcessItems entries)
    {
        _processItems = entries;
        _services.LibraryProvider.ProcessItemsBuilder = entries.ToBuilder();
    }

    internal CqlToolkit SetSettings(
        CqlToolkitSettings value)
    {
        var libraryProvider = _services.LibraryProvider;
        _services.ServiceProvider.Dispose();
        _settings = value;
        _services = CqlToolkitServices.Create(_services.LoggerFactory, _settings, libraryProvider);
        return this;
    }

    ILoggerFactory ICqlToolkit.LoggerFactory => _services.LoggerFactory;
    CqlToolkitSettings ICqlToolkit.Settings => _settings;
    CqlToolkitProcessItemsReadOnly ICqlToolkit.ProcessItems => _processItems;

    #endregion

    #region Input (CQL Library Strings)

    public CqlToolkit AddCqlLibraries(IEnumerable<CqlLibraryString> cqlLibraries)
    {
        var logger = _services.Logger;
        var entriesBuilder = _services.LibraryProvider.ProcessItemsBuilder;
        var cqlToElmConverter = _services.CqlToElmConverter;
        using var scope = _services.ServiceProvider.CreateScope()!;
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
            var entry = new CqlToolkitProcessItem(cqlLibrary) { ElmLibraryBuilder = libraryBuilder };
            entriesBuilder.Add(versionedIdentifier, entry);
            logger.LogInformation("Adding cql library to translation: {versionedIdentifier}", versionedIdentifier);
            hasChanged = true;
        }

        if (hasChanged)
            WithEntries(entries: entriesBuilder.ToImmutable());
        return this;
    }

    #endregion

    #region Processing (CQL-to-ELM)

    public CqlToolkit Translate()
    {
        CqlToolkitProcessItems.Builder processItemsBuilder = _services.LibraryProvider.ProcessItemsBuilder;
        var logger = _services.Logger;
        bool atFirst = true;

        IEnumerable<(CqlVersionedLibraryIdentifier versionedIdentifier, CqlToolkitProcessItem cqlTranslationEntry)> GetLibrariesForProcessing()
        {
            foreach (var (versionedIdentifier, cqlTranslationEntry) in
                     _processItems.Where(kv => kv.Value.ElmLibrary is null))
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

        LogExceptionMessageAction log = logger.GetLogExceptionMessageAction(_settings.ProcessBatchItemExceptionHandling);

        int changedCount =
                GetLibrariesForProcessing()
                    .TryProcessEach(t => ProcessLibrary(t.versionedIdentifier, t.cqlTranslationEntry))
                    .WithEachException(outcome =>
                    {
                        var libraryName = outcome.Input.versionedIdentifier;
                        log(outcome.Exception, "Error translating CQL library '{libraryName}' to ELM.", libraryName);
                    })
                    .HandleExceptions(_settings.ProcessBatchItemExceptionHandling)
                    .Count() // We must enumerate all
            ;

        if (changedCount > 0)
            WithEntries(entries: processItemsBuilder.ToImmutable());
        return this;

        void ProcessLibrary(CqlVersionedLibraryIdentifier versionedIdentifier, CqlToolkitProcessItem cqlTranslationEntry)
        {
            var library = cqlTranslationEntry.ElmLibraryBuilder!.Build();
            processItemsBuilder[versionedIdentifier] = cqlTranslationEntry with { ElmLibrary = library };
        }
    }

    #endregion
}