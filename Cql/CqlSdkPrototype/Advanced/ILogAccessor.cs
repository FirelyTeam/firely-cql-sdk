using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Advanced;

public interface ILogAccessor<out TSelf>
    where TSelf : ILogAccessor<TSelf>
{
    ILogger<TSelf> Logger { get; }
}