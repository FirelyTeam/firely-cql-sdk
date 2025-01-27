using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;

namespace CqlSdkPrototype.Cql;

public class CqlFluentToolkit(CqlToElmProcessor cqlToElmProcessor) :
    ICqlFluentToolkit
{
    public CqlFluentToolkit(
        ILoggerFactory? loggerFactory = null,
        CqlToElmProcessorSettings? settings = null) : this(new CqlToElmProcessor(loggerFactory, settings))
    {
    }

    /// <summary>
    /// For testing purposes only.
    /// </summary>
    internal ServiceProvider ServiceProvider => cqlToElmProcessor.ServiceProviderAccessor;

    public ILoggerFactory LoggerFactory => ServiceProvider.GetRequiredService<ILoggerFactory>();

    public CqlToElmProcessorSettings Settings => cqlToElmProcessor.Settings;

    public CqlToElmConversionReadOnlyDictionary CqlToElmConversions => cqlToElmProcessor.Conversions;

    public ICqlFluentToolkit ReplaceSettings(Func<CqlToElmProcessorSettings, CqlToElmProcessorSettings> replace)
    {
        cqlToElmProcessor.SetSettings(replace(Settings));
        return this;
    }

    public ICqlFluentToolkit AddCqlLibraries(IEnumerable<CqlLibraryString> libraries)
    {
        cqlToElmProcessor.AddCqlLibraries(libraries);
        return this;
    }

    public ICqlFluentToolkit ProcessCqlToElm()
    {
        cqlToElmProcessor.ProcessCqlToElm();
        return this;
    }
}