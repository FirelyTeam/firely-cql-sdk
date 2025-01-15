using Microsoft.Extensions.Logging.Abstractions;

namespace CqlSdkPrototype.Runtime;

public record RuntimeApiOptions(
    ILoggerFactory? LoggerFactory)
{
    public static RuntimeApiOptions Default { get; } = new();
    public RuntimeApiOptions() : this(NullLoggerFactory.Instance) { }
    public ILoggerFactory LoggerFactory { get; } = LoggerFactory ?? NullLoggerFactory.Instance;
}