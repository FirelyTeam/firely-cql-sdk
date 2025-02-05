using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Fhir.Metrics;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Cql;

using VersionedIdentifierAndCqlToElmTranslation = (CqlVersionedLibraryIdentifier versionedIdentifier, CqlToElmTranslation cqlTranslationEntry);
using VersionedIdentifierAndCqlToElmTranslationDeferred = (CqlVersionedLibraryIdentifier versionedIdentifier, Func<CqlToElmTranslation> cqlTranslationEntryFn);

// using VersionedIdentifierAndCqlToElmTranslationEnumerable = IEnumerable<VersionedIdentifierAndCqlToElmTranslation>;
// using VersionedIdentifierAndCqlToElmTranslationDeferredEnumerable = IEnumerable<(CqlVersionedLibraryIdentifier versionedIdentifier, Func<CqlToElmTranslation> cqlTranslationEntryFn)>;

/// <summary>
/// Translates CQL libraries to ELM libraries.
/// </summary>
public sealed class CqlToElmTranslator
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CqlToElmTranslator"/> class.
    /// </summary>
    /// <param name="loggerFactory">The logger factory to use for logging.</param>
    /// <param name="config">The configuration settings for the translator.</param>
    public CqlToElmTranslator(
        ILoggerFactory? loggerFactory = null,
        CqlToElmTranslatorConfig? config = null)
    {
        config ??= CqlToElmTranslatorConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        _cqlToElmTranslations = CqlToElmTranslationDictionary.Empty;
        Config = config;
        _services = CqlToElmTranslatorServices.Create(loggerFactory, config, _cqlToElmTranslations);
    }

    private CqlToElmTranslationDictionary _cqlToElmTranslations;
    private CqlToElmTranslatorServices _services;

    /// <summary>
    /// Gets the logger factory used by extensions via <see cref="FluentCqlToolkit.LoggerFactory"/>.
    /// </summary>
    internal ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the service provider used by tests via <see cref="FluentCqlToolkit.ServiceProvider"/>.
    /// </summary>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;

    /// <summary>
    /// Gets the configuration settings for the translator.
    /// </summary>
    public CqlToElmTranslatorConfig Config { get; private set; }

    /// <summary>
    /// Gets the dictionary of CQL to ELM translations.
    /// </summary>
    public CqlToElmTranslationReadOnlyDictionary CqlToElmTranslations => _cqlToElmTranslations;

    /// <summary>
    /// Sets the CQL to ELM conversions.
    /// </summary>
    /// <param name="translations">The dictionary of translations to set.</param>
    private void SetCqlToElmTranslations(
        CqlToElmTranslationDictionary translations)
    {
        _cqlToElmTranslations = translations;
        _services.LibraryBuilderProvider.TranslationsBuilder = translations.ToBuilder();
    }

    /// <summary>
    /// Reconfigures the translator with new configuration settings.
    /// </summary>
    /// <param name="config">The new configuration settings.</param>
    public void Reconfigure(
        CqlToElmTranslatorConfig config)
    {
        if (Config == config)
            return;

        _services.ServiceProvider.Dispose();
        Config = config;
        _services = CqlToElmTranslatorServices.Create(_services.LoggerFactory, config, _cqlToElmTranslations);
    }

    /// <summary>
    /// Adds CQL libraries to the translator.
    /// </summary>
    /// <param name="cqlLibraries">The CQL libraries to add.</param>
    public void AddCqlLibraries(IEnumerable<CqlLibraryString> cqlLibraries)
    {
        var entriesBuilder = _services.LibraryBuilderProvider.TranslationsBuilder;
        int addedCount =
                BuildTranslations(cqlLibraries, entriesBuilder)
                .Count() // We must enumerate all
                ;

        if (addedCount > 0)
            SetCqlToElmTranslations(translations: entriesBuilder.ToImmutable());
    }

    /// <summary>
    /// Builds the translations for the given CQL libraries.
    /// </summary>
    /// <param name="cqlLibraries">The CQL libraries to translate.</param>
    /// <param name="entriesBuilder">The builder for the translation entries.</param>
    /// <returns>A collection of CQL library strings and their corresponding translation functions.</returns>
    private IEnumerable<(CqlLibraryString cqlLibraryString, Func<CqlToElmTranslation> cqlToElmTranslationFn)> BuildTranslations(
        IEnumerable<CqlLibraryString> cqlLibraries,
        CqlToElmTranslationDictionary.Builder entriesBuilder)
    {
        var logger = _services.Logger;
        // var cqlToElmConverter = _services.CqlToElmConverter;
        // using var scope = _services.ServiceProvider.CreateScope()!;
        foreach (var cqlLibrary in cqlLibraries)
        {
            var versionedIdentifier = cqlLibrary.VersionedLibraryIdentifier;

            if (entriesBuilder.ContainsKey(versionedIdentifier))
            {
                logger.LogWarning("Skipping adding previous cql to translation: {versionedIdentifier}", versionedIdentifier);
                continue;
            }

            _services.Logger.LogInformation("Adding CQL library to translator: {versionedIdentifier}", versionedIdentifier);
            yield return (cqlLibrary,
                             () =>
                             {
                                 // var libraryVisitor = CqlToElmConverter.GetLibraryVisitorScoped(scope);
                                 // var libraryBuilder = cqlToElmConverter.GetBuilder(libraryVisitor, cqlLibrary.Cql);
                                 //var translation = new CqlToElmTranslation(cqlLibrary) { ElmLibraryBuilder = libraryBuilder };
                                 var translation = new CqlToElmTranslation(cqlLibrary);
                                 entriesBuilder.Add(versionedIdentifier, translation);
                                 return translation;
                             }
                         );
        }
    }

    /// <summary>
    /// Translates the CQL libraries to ELM libraries.
    /// </summary>
    public void TranslateCqlToElm()
    {
        CqlToElmTranslationDictionary.Builder processItemsBuilder = _services.LibraryBuilderProvider.TranslationsBuilder;
        var logger = _services.Logger;
        bool atFirst = true;

//        LogExceptionMessageAction log = logger.GetLogExceptionMessageAction(Config.EnumerationExceptionHandling);
        logger.CreateLoggingEnumerateExceptionHandler(Config.EnumerationExceptionHandling, ())

        var preprocessed =
            TryPreprocessLibraryBuilders()
                .TrySelect()
                // .SelectCatch(
                //     Config.EnumerationExceptionHandling,
                //     (id,e) => log(e, "Could not preprocess CQL: {id}", id))
                .ToList() // Complete preprocessing by ToList, before processing
            ;

        int changedCount =
                ProcessLibraries(preprocessed)
                    .TryProcessEach(t => ProcessLibrary(t.versionedIdentifier, t.cqlTranslationEntry))
                    .WithEachException(outcome =>
                    {
                        var libraryName = outcome.Input.versionedIdentifier;
                        log(outcome.Exception, "Error translating CQL library '{libraryName}' to ELM.", libraryName);
                    })
                    .SelectUndeferred(Config.EnumerationExceptionHandling)
                    .Count() // We must enumerate all
            ;

        if (changedCount > 0)
            SetCqlToElmTranslations(translations: processItemsBuilder.ToImmutable());
        return;

        IEnumerable<VersionedIdentifierAndCqlToElmTranslation> ProcessLibraries(IEnumerable<VersionedIdentifierAndCqlToElmTranslation> preprocessed)
        {
            foreach (var (versionedIdentifier, cqlTranslationEntry) in preprocessed)
            {
                if (cqlTranslationEntry.ElmLibrary is not null)
                    continue;

                if (atFirst)
                {
                    atFirst = false;
                    logger.LogInformation("Translating CQL into ELM");
                }

                logger.LogInformation("Translating CQL: {id}", versionedIdentifier);
                yield return (versionedIdentifier, cqlTranslationEntry);
            }
        }

        void ProcessLibrary(CqlVersionedLibraryIdentifier versionedIdentifier, CqlToElmTranslation cqlTranslationEntry)
        {
            var library = cqlTranslationEntry.ElmLibraryBuilder!.Build();
            processItemsBuilder[versionedIdentifier] = cqlTranslationEntry with { ElmLibrary = library };
        }

        IReadOnlyCollection<VersionedIdentifierAndCqlToElmTranslation> TryPreprocessLibraryBuilders()
        {
            var cqlToElmConverter = _services.CqlToElmConverter;
            using var scope = _services.ServiceProvider.CreateScope()!;
            var libraryVisitor = CqlToElmConverter.GetLibraryVisitorScoped(scope);

            var results =
                _cqlToElmTranslations
                .AsValueTupleEnumeration()
                .TrySelect(kv =>
                {
                    if (kv.Value.ElmLibraryBuilder is {})
                        return kv;

                    logger.LogInformation("Preprocessing CQL: {id}", kv.Key);
                    var libraryBuilder = cqlToElmConverter.GetBuilder(libraryVisitor, kv.Value.CqlLibraryString.Cql);
                    var cqlToElmTranslation = kv.Value with { ElmLibraryBuilder = libraryBuilder };
                    return kv with { Value = cqlToElmTranslation};
                })
                .Catch()
                .ToList();

            return results;
        }
    }
}
