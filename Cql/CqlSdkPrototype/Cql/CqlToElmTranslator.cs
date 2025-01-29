using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Cql;

public sealed class CqlToElmTranslator
{
    public CqlToElmTranslator(
        ILoggerFactory? loggerFactory = null,
        CqlToElmTranslatorConfig? config = null)
    {
        config ??= CqlToElmTranslatorConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        _cqlToElmTranslations = CqlToElmTranslationDictionary.Empty;
        Config = config;
        _services = CqlToElmProcessorServices.Create(loggerFactory, config, _cqlToElmTranslations);
    }

    private CqlToElmTranslationDictionary _cqlToElmTranslations;
    private CqlToElmProcessorServices _services;

    /// <remarks>
    /// Used by extensions on the <seealso cref="FluentCqlToolkit"/> to access the logger factory.
    /// </remarks>>
    internal ILoggerFactory LoggerFactory { get; }

    /// <remarks>
    /// Used by tests on the <seealso cref="FluentCqlToolkit"/> to access the service provider.
    /// </remarks>>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;

    public CqlToElmTranslatorConfig Config { get; private set; }

    public CqlToElmTranslationReadOnlyDictionary CqlToElmTranslations => _cqlToElmTranslations;

    private void SetCqlToElmConversions(
        CqlToElmTranslationDictionary translations)
    {
        _cqlToElmTranslations = translations;
        _services.LibraryProvider.Builder = translations.ToBuilder();
    }

    public void Reconfigure(
        CqlToElmTranslatorConfig config)
    {
        if (Config == config)
            return;

        _services.ServiceProvider.Dispose();
        Config = config;
        _services = CqlToElmProcessorServices.Create(_services.LoggerFactory, config, _cqlToElmTranslations);
    }

    public void AddCqlLibraries(IEnumerable<CqlLibraryString> cqlLibraries)
    {
        var logger = _services.Logger;
        var entriesBuilder = _services.LibraryProvider.Builder;
        LogExceptionMessageAction log = logger.GetLogExceptionMessageAction(Config.ProcessBatchItemExceptionHandling);

        int addedCount =
                AddTranslations(cqlLibraries, entriesBuilder)
                    .TryProcessEach(t => (t.cqlLibraryString, cqlToElmTranslation: t.cqlToElmTranslationFn()))
                    .WithEachException(outcome =>
                    {
                        var libraryName = outcome.Input.cqlLibraryString.VersionedLibraryIdentifier;
                        log(outcome.Exception, "Error parsing CQL library '{libraryName}' to ELM.", libraryName);
                    })
                    .HandleExceptions(Config.ProcessBatchItemExceptionHandling)
                    .Count() // We must enumerate all
            ;


        if (addedCount > 0)
            SetCqlToElmConversions(translations: entriesBuilder.ToImmutable());
    }

    private IEnumerable<(CqlLibraryString cqlLibraryString, Func<CqlToElmTranslation> cqlToElmTranslationFn)> AddTranslations(
        IEnumerable<CqlLibraryString> cqlLibraries,
        CqlToElmTranslationDictionary.Builder entriesBuilder)
    {
        var logger = _services.Logger;
        var cqlToElmConverter = _services.CqlToElmConverter;
        using var scope = _services.ServiceProvider.CreateScope()!;
        foreach (var cqlLibrary in cqlLibraries)
        {
            var versionedIdentifier = cqlLibrary.VersionedLibraryIdentifier;

            if (entriesBuilder.ContainsKey(versionedIdentifier))
            {
                logger.LogInformation("Skipping adding previous cql to translation: {versionedIdentifier}", versionedIdentifier);
                continue;
            }

            yield return (cqlLibrary,
                             () =>
                             {
                                 var libraryVisitor = CqlToElmConverter.GetLibraryVisitorScoped(scope);
                                 var libraryBuilder = cqlToElmConverter.GetBuilder(libraryVisitor, cqlLibrary.Cql);
                                 var translation = new CqlToElmTranslation(cqlLibrary) { ElmLibraryBuilder = libraryBuilder };
                                 entriesBuilder.Add(versionedIdentifier, translation);
                                 return translation;
                             });
        }
    }

    public void TranslateCqlToElm()
    {
        CqlToElmTranslationDictionary.Builder processItemsBuilder = _services.LibraryProvider.Builder;
        var logger = _services.Logger;
        bool atFirst = true;

        IEnumerable<(CqlVersionedLibraryIdentifier versionedIdentifier, CqlToElmTranslation cqlTranslationEntry)> GetLibrariesForProcessing()
        {
            foreach (var (versionedIdentifier, cqlTranslationEntry) in
                     _cqlToElmTranslations.Where(kv => kv.Value.ElmLibrary is null))
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

        LogExceptionMessageAction log = logger.GetLogExceptionMessageAction(Config.ProcessBatchItemExceptionHandling);

        int changedCount =
                GetLibrariesForProcessing()
                    .TryProcessEach(t => ProcessLibrary(t.versionedIdentifier, t.cqlTranslationEntry))
                    .WithEachException(outcome =>
                    {
                        var libraryName = outcome.Input.versionedIdentifier;
                        log(outcome.Exception, "Error translating CQL library '{libraryName}' to ELM.", libraryName);
                    })
                    .HandleExceptions(Config.ProcessBatchItemExceptionHandling)
                    .Count() // We must enumerate all
            ;

        if (changedCount > 0)
            SetCqlToElmConversions(translations: processItemsBuilder.ToImmutable());

        void ProcessLibrary(CqlVersionedLibraryIdentifier versionedIdentifier, CqlToElmTranslation cqlTranslationEntry)
        {
            var library = cqlTranslationEntry.ElmLibraryBuilder!.Build();
            processItemsBuilder[versionedIdentifier] = cqlTranslationEntry with { ElmLibrary = library };
        }
    }
}