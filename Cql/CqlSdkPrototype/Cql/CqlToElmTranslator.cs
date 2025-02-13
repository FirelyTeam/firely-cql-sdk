using CqlSdkPrototype.Cql.Fluent;
using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Cql;

using VersionedIdentifierAndCqlToElmTranslation = (CqlVersionedLibraryIdentifier versionedIdentifier, CqlToElmTranslation cqlTranslationEntry);

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

        _services.Dispose();
        Config = config;
        _services = CqlToElmTranslatorServices.Create(_services.LoggerFactory, config, _cqlToElmTranslations);
        _services.LibraryBuilderProvider.CqlToElmTranslatorServices = _services;
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
    private IEnumerable<(CqlLibraryString cqlLibraryString, CqlToElmTranslation cqlToElmTranslationFn)> BuildTranslations(
        IEnumerable<CqlLibraryString> cqlLibraries,
        CqlToElmTranslationDictionary.Builder entriesBuilder)
    {
        var logger = _services.Logger;
        foreach (var cqlLibrary in cqlLibraries)
        {
            var versionedIdentifier = cqlLibrary.VersionedLibraryIdentifier;

            if (entriesBuilder.ContainsKey(versionedIdentifier))
            {
                logger.LogWarning("Skipping adding previous cql to translation: {versionedIdentifier}", versionedIdentifier);
                continue;
            }

            _services.Logger.LogInformation("Adding CQL library to translator: {versionedIdentifier}", versionedIdentifier);
            var translation = new CqlToElmTranslation(cqlLibrary);
            entriesBuilder.Add(versionedIdentifier, translation);
            yield return (cqlLibrary, translation);
        }
    }

    /// <summary>
    /// Translates the CQL libraries to ELM libraries.
    /// </summary>
    public void TranslateCqlToElm()
    {
        CqlToElmTranslationDictionary.Builder itemsBuilder = _services.LibraryBuilderProvider.TranslationsBuilder;
        var logger = _services.Logger;

        var exceptionHandling = Config.EnumerationExceptionHandling;

        var logTranslateFailed =
            logger.CreateLogExceptionHandler<VersionedIdentifierAndCqlToElmTranslation>(
                exceptionHandling,
                (o, messageBuilder) => messageBuilder("Could not translate CQL to ELM for {lib}", o.versionedIdentifier));

        var changedCount =
            _cqlToElmTranslations
                .Select(kv => new VersionedIdentifierAndCqlToElmTranslation(kv.Key, kv.Value))
                .Where(kv => kv.cqlTranslationEntry.ElmLibrary is null)
                .TrySelect(kv =>
                           {
                               var (id, entry) = kv;
                               if (!_services.LibraryBuilderProvider.TryResolveLibrary(id, out var libBuilder, out var error))
                                   throw new InvalidOperationException("Could not resolve CQL library " + id);

                               var lib = libBuilder.Build();
                               var newEntry = entry with { ElmLibrary = lib };
                               itemsBuilder[id] = newEntry;
                               return kv with { cqlTranslationEntry = newEntry };
                           },
                           logTranslateFailed)
                .Count(); // Must enumerate all

        if (changedCount > 0)
            SetCqlToElmTranslations(translations: itemsBuilder.ToImmutable());
    }
}