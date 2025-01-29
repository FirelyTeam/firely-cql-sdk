using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Cql.Fluent;

public sealed class FluentCqlToolkit(CqlToElmTranslator cqlToElmTranslator)
{
    public FluentCqlToolkit(
        ILoggerFactory? loggerFactory = null,
        CqlToElmTranslatorConfig? config = null) : this(new CqlToElmTranslator(loggerFactory, config))
    {
    }

    /// <remarks>
    /// Used by tests to access the service provider.
    /// </remarks>>
    internal ServiceProvider ServiceProvider => cqlToElmTranslator.ServiceProvider;

    /// <remarks>
    /// Used by extensions to access the logger factory.
    /// </remarks>>
    public ILoggerFactory LoggerFactory => cqlToElmTranslator.LoggerFactory;

    public CqlToElmTranslatorConfig Config => cqlToElmTranslator.Config;

    public CqlToElmTranslationReadOnlyDictionary CqlToElmTranslations => cqlToElmTranslator.CqlToElmTranslations;

    public FluentCqlToolkit Reconfigure(Func<CqlToElmTranslatorConfig, CqlToElmTranslatorConfig> configure)
    {
        cqlToElmTranslator.Reconfigure(configure(Config));
        return this;
    }

    public FluentCqlToolkit AddCqlLibraries(IEnumerable<CqlLibraryString> libraries)
    {
        cqlToElmTranslator.AddCqlLibraries(libraries);
        return this;
    }

    public FluentCqlToolkit TranslateCqlToElm()
    {
        cqlToElmTranslator.TranslateCqlToElm();
        return this;
    }
}