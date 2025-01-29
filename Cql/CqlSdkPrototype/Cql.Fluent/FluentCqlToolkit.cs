using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Cql.Fluent;

/// <summary>
/// Provides a fluent interface for working with CQL to ELM translations.
/// </summary>
public sealed class FluentCqlToolkit(CqlToElmTranslator cqlToElmTranslator)
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FluentCqlToolkit"/> class.
    /// </summary>
    /// <param name="loggerFactory">The logger factory to use for logging.</param>
    /// <param name="config">The configuration settings for the translator.</param>
    public FluentCqlToolkit(
        ILoggerFactory? loggerFactory = null,
        CqlToElmTranslatorConfig? config = null) : this(new CqlToElmTranslator(loggerFactory, config))
    {
    }

    /// <summary>
    /// Gets the service provider used by tests.
    /// </summary>
    internal ServiceProvider ServiceProvider => cqlToElmTranslator.ServiceProvider;

    /// <summary>
    /// Gets the logger factory used by extensions.
    /// </summary>
    public ILoggerFactory LoggerFactory => cqlToElmTranslator.LoggerFactory;

    /// <summary>
    /// Gets the configuration settings for the translator.
    /// </summary>
    public CqlToElmTranslatorConfig Config => cqlToElmTranslator.Config;

    /// <summary>
    /// Gets the dictionary of CQL to ELM translations.
    /// </summary>
    public CqlToElmTranslationReadOnlyDictionary CqlToElmTranslations => cqlToElmTranslator.CqlToElmTranslations;

    /// <summary>
    /// Reconfigures the translator with new configuration settings.
    /// </summary>
    /// <param name="configure">A function that takes the current configuration and returns a new configuration.</param>
    /// <returns>The current instance of <see cref="FluentCqlToolkit"/>.</returns>
    public FluentCqlToolkit Reconfigure(Func<CqlToElmTranslatorConfig, CqlToElmTranslatorConfig> configure)
    {
        cqlToElmTranslator.Reconfigure(configure(Config));
        return this;
    }

    /// <summary>
    /// Adds CQL libraries to the translator.
    /// </summary>
    /// <param name="libraries">The CQL libraries to add.</param>
    /// <returns>The current instance of <see cref="FluentCqlToolkit"/>.</returns>
    public FluentCqlToolkit AddCqlLibraries(IEnumerable<CqlLibraryString> libraries)
    {
        cqlToElmTranslator.AddCqlLibraries(libraries);
        return this;
    }

    /// <summary>
    /// Translates the CQL libraries to ELM libraries.
    /// </summary>
    /// <returns>The current instance of <see cref="FluentCqlToolkit"/>.</returns>
    public FluentCqlToolkit TranslateCqlToElm()
    {
        cqlToElmTranslator.TranslateCqlToElm();
        return this;
    }
}
