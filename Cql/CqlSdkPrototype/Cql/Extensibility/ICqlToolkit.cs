using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Cql.Extensibility;

public interface ICqlToolkit
{
    ILoggerFactory LoggerFactory { get; }
    CqlToolkitSettings Settings { get; }
    CqlToolkitProcessItemsReadOnly ProcessItems { get; }
    CqlToolkit AddCqlLibraries(IEnumerable<CqlLibraryString> libraries);
    CqlToolkit Translate();
}