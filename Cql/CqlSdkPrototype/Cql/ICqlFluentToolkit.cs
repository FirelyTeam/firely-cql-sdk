using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Cql;

public interface ICqlFluentToolkit
{
    ILoggerFactory LoggerFactory { get; }
    CqlToolkitSettings Settings { get; }
    CqlToElmConversionReadOnlyDictionary CqlToElmConversions { get; }
    ICqlFluentToolkit ReplaceSettings(Func<CqlToolkitSettings, CqlToolkitSettings> replace);
    ICqlFluentToolkit AddCqlLibraries(IEnumerable<CqlLibraryString> libraries);
    ICqlFluentToolkit ProcessCqlToElm();
}