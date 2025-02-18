using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Cql;

/// <summary>
/// Translates CQL libraries to ELM libraries.
/// </summary>
public sealed class CqlToolkit
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CqlToolkit"/> class.
    /// </summary>
    /// <param name="loggerFactory">The logger factory to use for logging.</param>
    /// <param name="config">The configuration settings for the translator.</param>
    public CqlToolkit(
        ILoggerFactory? loggerFactory = null,
        CqlToolkitConfig? config = null)
    {
        config ??= CqlToolkitConfig.Default;
        loggerFactory ??= NullLoggerFactory.Instance;
        LoggerFactory = loggerFactory;
        _conversions = CqlToolkitConversionDictionary.Empty;
        Config = config;
        _services = CqlToolkitServices.Create(loggerFactory, config, _conversions);
    }

    private CqlToolkitConversionDictionary _conversions;
    private CqlToolkitServices _services;

    /// <summary>
    /// Gets the logger factory used by extensions.
    /// </summary>
    public ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the service provider used by tests.
    /// </summary>
    internal ServiceProvider ServiceProvider => _services.ServiceProvider;

    /// <summary>
    /// Gets the configuration.
    /// </summary>
    public CqlToolkitConfig Config { get; private set; }

    /// <summary>
    /// Gets the dictionary of CQL to ELM translations.
    /// </summary>
    public CqlToolkitConversionReadOnlyDictionary Conversions => _conversions;

    /// <summary>
    /// Replaces the CQL to ELM conversions.
    /// </summary>
    /// <param name="conversions">The dictionary of translations to set.</param>
    private void ReplaceConversions(
        CqlToolkitConversionDictionary conversions)
    {
        _conversions = conversions;
        _services.LibraryBuilderProvider.ConversionsBuilder = conversions.ToBuilder();
    }

    /// <summary>
    /// Reconfigures the translator with new configuration settings.
    /// </summary>
    /// <param name="reconfigure">A function that takes the current configuration and returns a new configuration.</param>
    public CqlToolkit Reconfigure(
        Mutator<CqlToolkitConfig> reconfigure)
    {
        var config = reconfigure(Config);

        if (Config == config)
            return this;

        _services.Dispose();
        Config = config;
        _services = CqlToolkitServices.Create(_services.LoggerFactory, config, _conversions);
        _services.LibraryBuilderProvider.CqlToElmTranslatorServices = _services;

        return this;
    }

    /// <summary>
    /// Adds CQL libraries to the translator.
    /// </summary>
    /// <param name="cqlLibraries">The CQL libraries to add.</param>
    public CqlToolkit AddCqlLibraries(IEnumerable<CqlLibraryString> cqlLibraries)
    {
        var logger = _services.Logger;
        var conversions = _services.LibraryBuilderProvider.ConversionsBuilder;

        var count = cqlLibraries
                    .Select(lib => new CqlToolkitConversionRecord(lib))
                    .TryForEach(
                        conversionRecord =>
                        {
                            var libId = conversionRecord.LibraryIdentifier;
                            logger.LogInformation("Adding CQL library to CqlToolkit: {lib}", libId);
                            conversions.Add(libId, conversionRecord); // This fails on duplicate key and value
                        },
                        errorStrategy => errorStrategy
                                         .SetContinuation(Config.ErroredEnumerationContinuation)
                                         .AddLoggerExceptionHandler(
                                             logger,
                                             (conversionRecord, logMessage) =>
                                                 logMessage("Could not add CQL library to CqlToolkit: {lib}.", conversionRecord.LibraryIdentifier)));

        if (count > 0)
            ReplaceConversions(conversions.ToImmutable());

        return this;
    }

    /// <summary>
    /// Translates the CQL libraries to ELM libraries.
    /// </summary>
    public CqlToolkit ConvertCqlToElm()
    {
        CqlToolkitConversionDictionary.Builder conversions = _services.LibraryBuilderProvider.ConversionsBuilder;

        var count =
            _conversions
                .Values
                .Where(conversion => conversion.OutElmLibrary is null)
                .TryForEach(
                    r =>
                    {
                        if (!_services.LibraryBuilderProvider.TryResolveLibrary(r.LibraryIdentifier, out var libraryBuilder, out var error))
                            throw new InvalidOperationException($"Could not resolve CQL library: {r.LibraryIdentifier} with error {error}.");

                        var elmLibrary = libraryBuilder.Build();
                        var newConversionRecord = r with { OutElmLibrary = elmLibrary };
                        conversions[r.LibraryIdentifier] = newConversionRecord;
                    },
                    errorStrategy => errorStrategy
                                     .SetContinuation(ErroredEnumerationContinuation.Continue)
                                     .AddLoggerExceptionHandler(_services.Logger,
                                                                (conversion, messageBuilder) =>
                                                                    messageBuilder("Could not translate CQL to ELM: {lib}", conversion.LibraryIdentifier))
                );

        if (count > 0)
            ReplaceConversions(conversions: conversions.ToImmutable());

        return this;
    }
}