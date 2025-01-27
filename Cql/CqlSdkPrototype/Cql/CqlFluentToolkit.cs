using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Cql;

public sealed class CqlFluentToolkit(CqlToElmProcessor cqlToElmProcessor)
{
    public CqlFluentToolkit(
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

    public CqlFluentToolkit ReplaceSettings(Func<CqlToElmProcessorSettings, CqlToElmProcessorSettings> replace)
    {
        cqlToElmProcessor.SetSettings(replace(Settings));
        return this;
    }

    public CqlFluentToolkit AddCqlLibraries(IEnumerable<CqlLibraryString> libraries)
    {
        cqlToElmProcessor.AddCqlLibraries(libraries);
        return this;
    }

    public CqlFluentToolkit ProcessCqlToElm()
    {
        cqlToElmProcessor.ProcessCqlToElm();
        return this;
    }
}