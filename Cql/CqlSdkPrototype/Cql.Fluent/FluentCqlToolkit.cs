using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Cql.Fluent;

public sealed class FluentCqlToolkit(CqlToElmTranslator cqlToElmTranslator)
{
    public FluentCqlToolkit(
        ILoggerFactory? loggerFactory = null,
        CqlToElmTranslatorConfig? config = null) : this(new CqlToElmTranslator(loggerFactory, config))
    {
    }

    /// <summary>
    /// For testing purposes only.
    /// </summary>
    internal ServiceProvider ServiceProvider => cqlToElmTranslator.ServiceProvider;

    /// <summary>
    /// Used by extensions to access the logger factory.
    /// </summary>
    public ILoggerFactory LoggerFactory => cqlToElmTranslator.LoggerFactory;

    public CqlToElmTranslatorConfig Config => cqlToElmTranslator.Config;

    public CqlToElmConversionReadOnlyDictionary CqlToElmConversions => cqlToElmTranslator.Conversions;

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