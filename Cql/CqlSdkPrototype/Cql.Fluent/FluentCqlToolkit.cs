using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Cql.Fluent;

public sealed class FluentCqlToolkit(CqlToElmProcessor cqlToElmProcessor)
{
    public FluentCqlToolkit(
        ILoggerFactory? loggerFactory = null,
        CqlToElmProcessorSettings? settings = null) : this(new CqlToElmProcessor(loggerFactory, settings))
    {
    }

    /// <summary>
    /// For testing purposes only.
    /// </summary>
    internal ServiceProvider ServiceProvider => cqlToElmProcessor.ServiceProvider;

    public ILoggerFactory LoggerFactory => ServiceProvider.GetRequiredService<ILoggerFactory>();

    public CqlToElmProcessorSettings Settings => cqlToElmProcessor.Settings;

    public CqlToElmConversionReadOnlyDictionary CqlToElmConversions => cqlToElmProcessor.Conversions;

    public FluentCqlToolkit ReplaceSettings(Func<CqlToElmProcessorSettings, CqlToElmProcessorSettings> replace)
    {
        cqlToElmProcessor.SetSettings(replace(Settings));
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