/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

internal static class EnumerationErrorStrategyExtensions
{
    public static EnumerationErrorStrategy<T> SetContinuation<T>(
        this EnumerationErrorStrategy<T> strategy,
        ErroredEnumerationContinuation continuation) =>
        strategy with
        {
            Continuation = continuation
        };

    public static EnumerationErrorStrategy<T> AddLoggerExceptionHandler<T>(
        this EnumerationErrorStrategy<T> strategy,
        ILogger logger,
        LogMessageBuilder<T> logMessageBuilder)
    {
        var logLevel = ToLogLevel(strategy.Continuation);
        if (!logger.IsEnabled(logLevel))
            return strategy;

        return strategy with
        {
            ExceptionHandler = strategy.ExceptionHandler ?? CreateLogExceptionHandler(logger, logLevel, logMessageBuilder)
        };
    }

    private static ValueExceptionHandler<TCurrent> CreateLogExceptionHandler<TCurrent>(
        this ILogger logger,
        LogLevel logLevel,
        LogMessageBuilder<TCurrent> logMessageBuilder)
    {
        return (current, exception) => logMessageBuilder(current, (message, args) => logger.Log(logLevel, exception, message, args));
    }

    private static LogLevel ToLogLevel(ErroredEnumerationContinuation erroredEnumerationContinuation) =>
        erroredEnumerationContinuation is ErroredEnumerationContinuation.Throw ? LogLevel.Error : LogLevel.Warning;

    public delegate void LogMessageBuilder<in TCurrent>(TCurrent current, LogMessage logMessage);

    public delegate void LogMessage([StructuredMessageTemplate] string message, params object?[] args);
}