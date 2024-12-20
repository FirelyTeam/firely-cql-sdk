using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Advanced;

public interface ILibraryAcceptor<out TSelf> :
    ILogAccessor<TSelf>
    where TSelf : ILibraryAcceptor<TSelf>
{
    TSelf AcceptLibraries(IEnumerable<Library> libraries);
}