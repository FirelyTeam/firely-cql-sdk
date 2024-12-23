using CqlSdkPrototype.Advanced;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.ElmToAssembly.Advanced;

public interface IElmLibraryAcceptor<out TSelf> :
    ILogAccessor<TSelf>
    where TSelf : IElmLibraryAcceptor<TSelf>
{
    TSelf AcceptLibraries(IEnumerable<Library> libraries);
}