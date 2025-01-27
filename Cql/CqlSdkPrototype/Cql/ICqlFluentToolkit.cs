using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Cql;

public interface ICqlFluentToolkit
{
    ILoggerFactory LoggerFactory { get; }
    CqlToElmProcessorSettings Settings { get; }
    CqlToElmConversionReadOnlyDictionary CqlToElmConversions { get; }
    ICqlFluentToolkit ReplaceSettings(Func<CqlToElmProcessorSettings, CqlToElmProcessorSettings> replace);
    ICqlFluentToolkit AddCqlLibraries(IEnumerable<CqlLibraryString> libraries);
    ICqlFluentToolkit ProcessCqlToElm();
}