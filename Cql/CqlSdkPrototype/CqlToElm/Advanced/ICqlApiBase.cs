using CqlSdkPrototype.Advanced;

namespace CqlSdkPrototype.CqlToElm.Advanced;

public interface ICqlApiBase<out TSelf> :
    ILogAccessor<TSelf>
    where TSelf : ICqlApiBase<TSelf>
{
    TSelf AddCqlLibraryStrings(IEnumerable<CqlLibraryString> libraries);
}