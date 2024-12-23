using CqlSdkPrototype.Advanced;

namespace CqlSdkPrototype.CqlToElm.Advanced;

public interface ICqlLibraryStringContentAcceptor<out TSelf> :
    ILogAccessor<TSelf>
    where TSelf : ICqlLibraryStringContentAcceptor<TSelf>
{
    TSelf AcceptLibraries(IEnumerable<CqlLibraryStringContent> libraries);
}