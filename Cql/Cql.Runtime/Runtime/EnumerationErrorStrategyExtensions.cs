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
        EnumerationExceptionContinuation continuation) =>
        strategy with { ExceptionContinuation = continuation };

    public static EnumerationErrorStrategy<T> AddLoggerExceptionHandler<T>(
        this EnumerationErrorStrategy<T> strategy,
        ILogger logger,
        LogMessageBuilder<T> logMessageBuilder) =>
        AddExceptionHandler(strategy, CreateLogExceptionHandler(logger, logMessageBuilder));

    public static EnumerationErrorStrategy<T> AddExceptionHandler<T>(
        this EnumerationErrorStrategy<T> strategy,
        ValueExceptionHandler<T>? exceptionHandler)
    {
        return
            exceptionHandler is null
            ? strategy
            : strategy with { ExceptionHandler = strategy.ExceptionHandler + exceptionHandler };
    }

    private static ValueExceptionHandler<TCurrent> CreateLogExceptionHandler<TCurrent>(
        this ILogger logger,
        LogMessageBuilder<TCurrent> logMessageBuilder) =>
        (current,
         exception,
         continuation) =>
        {
            var logLevel = ToLogLevel(continuation);
            if (logger.IsEnabled(logLevel))
            {
                logMessageBuilder(
                    current,
                    (message, args) => logger.Log(logLevel, exception, message, args));
            }
        };

    private static LogLevel ToLogLevel(EnumerationExceptionContinuation enumerationExceptionContinuation) =>
        enumerationExceptionContinuation is EnumerationExceptionContinuation.Throw ? LogLevel.Error : LogLevel.Warning;

    public delegate void LogMessageBuilder<in TCurrent>(
        TCurrent current,
        LogMessage logMessage);

    public delegate void LogMessage(
        [StructuredMessageTemplate] string message,
        params object?[] args);
}