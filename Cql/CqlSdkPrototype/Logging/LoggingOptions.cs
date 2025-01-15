using Microsoft.Extensions.Logging.Abstractions;

namespace CqlSdkPrototype.Logging;

public record LoggingOptions(
    ILoggerFactory? LoggerFactory)
{
    public static LoggingOptions Default { get; } = new(default(ILoggerFactory));
    public ILoggerFactory LoggerFactory { get; init; } = LoggerFactory ?? NullLoggerFactory.Instance;
}