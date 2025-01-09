using CqlSdkPrototype.Advanced;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm.Extensibility;

public interface IElmApi
{
}

public interface IElmApiExtensible<out TSelf> :
    IElmApi,
    ILogAccessor<TSelf>
    where TSelf : IElmApiExtensible<TSelf>
{
    ElmApiOptions Options { get; }
    TSelf AddElmLibraries(IEnumerable<Library> libraries);
    TSelf CompileAssemblies();
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, ElmCompilationEntry> Entries { get; }
}