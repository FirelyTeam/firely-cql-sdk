namespace CqlSdkPrototype.Logging;

public readonly record struct LogFilterArgs
(
    string? LoggerProviderName,
    string? Category,
    LogLevel LogLevel);