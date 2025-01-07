using CqlSdkPrototype.Advanced;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.ElmToAssembly.Advanced;

public interface IElmApiBase<out TSelf> :
    ILogAccessor<TSelf>
    where TSelf : IElmApiBase<TSelf>
{
    TSelf AddElmLibraries(IEnumerable<Library> libraries);
}