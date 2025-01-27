using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Cql;

public class CqlToolkit :
    ICqlFluentToolkit,
    IServiceProviderAccessorForTesting<CqlToolkit>
{
    public CqlToolkit(
        ILoggerFactory? loggerFactory = null,
        CqlToolkitSettings? settings = null)
    {
        settings ??= CqlToolkitSettings.Default;
        var processItems = CqlToElmConversionDictionary.Empty;
        var entriesBuilder = processItems.ToBuilder();
        var libraryProvider = new CqlToolkitProcessItemsLibraryProvider(entriesBuilder);
        _cqlToElmConversions = processItems;
        _services = CqlToolkitServices.Create(loggerFactory ?? NullLoggerFactory.Instance, settings, libraryProvider);
        _settings = settings;
        SetSettings(settings);
    }

    public ICqlFluentToolkit AsFluent() => this;

    private CqlToElmConversionDictionary _cqlToElmConversions;
    private CqlToolkitServices _services;
    private CqlToolkitSettings _settings;

    ServiceProvider IServiceProviderAccessorForTesting<CqlToolkit>.ServiceProvider => _services.ServiceProvider;

    ILoggerFactory ICqlFluentToolkit.LoggerFactory => _services.LoggerFactory;

    public CqlToolkitSettings Settings => _settings;

    public CqlToElmConversionReadOnlyDictionary CqlToElmConversions => _cqlToElmConversions;

    ICqlFluentToolkit ICqlFluentToolkit.ReplaceSettings(Func<CqlToolkitSettings, CqlToolkitSettings> replace)
    {
        SetSettings(replace(Settings));
        return this;
    }

    ICqlFluentToolkit ICqlFluentToolkit.AddCqlLibraries(IEnumerable<CqlLibraryString> libraries)
    {
        AddCqlLibraries(libraries);
        return this;
    }

    ICqlFluentToolkit ICqlFluentToolkit.ProcessCqlToElm()
    {
        ProcessCqlToElm();
        return this;
    }

    private void SetItems(
        CqlToElmConversionDictionary conversions)
    {
        _cqlToElmConversions = conversions;
        _services.LibraryProvider.ProcessItemsBuilder = conversions.ToBuilder();
    }

    private void SetSettings(
        CqlToolkitSettings settings)
    {
        var libraryProvider = _services.LibraryProvider;
        _services.ServiceProvider.Dispose();
        _settings = settings;
        _services = CqlToolkitServices.Create(_services.LoggerFactory, Settings, libraryProvider);
    }

    private void AddCqlLibraries(IEnumerable<CqlLibraryString> cqlLibraries)
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
            var entry = new CqlToElmConversion(cqlLibrary) { ElmLibraryBuilder = libraryBuilder };
            entriesBuilder.Add(versionedIdentifier, entry);
            logger.LogInformation("Adding cql library to translation: {versionedIdentifier}", versionedIdentifier);
            hasChanged = true;
        }

        if (hasChanged)
            SetItems(conversions: entriesBuilder.ToImmutable());
    }

    private void ProcessCqlToElm()
    {
        CqlToElmConversionDictionary.Builder processItemsBuilder = _services.LibraryProvider.ProcessItemsBuilder;
        var logger = _services.Logger;
        bool atFirst = true;

        IEnumerable<(CqlVersionedLibraryIdentifier versionedIdentifier, CqlToElmConversion cqlTranslationEntry)> GetLibrariesForProcessing()
        {
            foreach (var (versionedIdentifier, cqlTranslationEntry) in
                     _cqlToElmConversions.Where(kv => kv.Value.ElmLibrary is null))
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

        LogExceptionMessageAction log = logger.GetLogExceptionMessageAction(Settings.ProcessBatchItemExceptionHandling);

        int changedCount =
                GetLibrariesForProcessing()
                    .TryProcessEach(t => ProcessLibrary(t.versionedIdentifier, t.cqlTranslationEntry))
                    .WithEachException(outcome =>
                    {
                        var libraryName = outcome.Input.versionedIdentifier;
                        log(outcome.Exception, "Error translating CQL library '{libraryName}' to ELM.", libraryName);
                    })
                    .HandleExceptions(Settings.ProcessBatchItemExceptionHandling)
                    .Count() // We must enumerate all
            ;

        if (changedCount > 0)
            SetItems(conversions: processItemsBuilder.ToImmutable());
        return;

        void ProcessLibrary(CqlVersionedLibraryIdentifier versionedIdentifier, CqlToElmConversion cqlTranslationEntry)
        {
            var library = cqlTranslationEntry.ElmLibraryBuilder!.Build();
            processItemsBuilder[versionedIdentifier] = cqlTranslationEntry with { ElmLibrary = library };
        }
    }
}