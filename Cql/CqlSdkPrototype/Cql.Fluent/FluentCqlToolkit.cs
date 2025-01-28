using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Cql.Fluent;

public sealed class FluentCqlToolkit(CqlToElmProcessor cqlToElmProcessor)
{
    public FluentCqlToolkit(
        ILoggerFactory? loggerFactory = null,
        CqlToElmProcessorConfig? config = null) : this(new CqlToElmProcessor(loggerFactory, config))
    {
    }

    /// <summary>
    /// For testing purposes only.
    /// </summary>
    internal ServiceProvider ServiceProvider => cqlToElmProcessor.ServiceProvider;

    public ILoggerFactory LoggerFactory => ServiceProvider.GetRequiredService<ILoggerFactory>();

    public CqlToElmProcessorConfig Config => cqlToElmProcessor.Config;

    public CqlToElmConversionReadOnlyDictionary CqlToElmConversions => cqlToElmProcessor.Conversions;

    public FluentCqlToolkit Reconfigure(Func<CqlToElmProcessorConfig, CqlToElmProcessorConfig> configure)
    {
        cqlToElmProcessor.Reconfigure(configure(Config));
        return this;
    }

    public FluentCqlToolkit AddCqlLibraries(IEnumerable<CqlLibraryString> libraries)
    {
        cqlToElmProcessor.AddCqlLibraries(libraries);
        return this;
    }

    public FluentCqlToolkit ProcessCqlToElm()
    {
        cqlToElmProcessor.ProcessCqlToElm();
        return this;
    }
}