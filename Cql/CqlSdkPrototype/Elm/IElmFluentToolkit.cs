using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm;

public interface IElmFluentToolkit
{
    ElmToolkit ElmToolkit { get; }
    ILoggerFactory LoggerFactory { get; }
    ElmToolkitSettings Settings { get; }
    ElmToAssemblyConversionReadOnlyDictionary ElmToAssemblyConversions { get; }
    IElmFluentToolkit ReplaceSettings(Func<ElmToolkitSettings, ElmToolkitSettings> replace);
    IElmFluentToolkit AddElmLibraries(IEnumerable<Library> libraries);
    IElmFluentToolkit ProcessElmToAssemblies();
}