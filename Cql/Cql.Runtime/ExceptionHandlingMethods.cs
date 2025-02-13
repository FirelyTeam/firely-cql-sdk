namespace Hl7.Cql.Runtime;

internal static class ExceptionHandlingMethods
{
    private static (EnumerationContinuation continuation, TNext next) TryGetNext<T, TNext>(
        T input,
        Func<T, TNext> getNext,
        EnumerateExceptionHandler<T>? exceptionHandler = null)
    {
        try
        {
            TNext next = getNext(input);
            return (EnumerationContinuation.Yield, next);
        }
        catch (Exception e)
        {
            switch (exceptionHandler?.Invoke(input, e))
            {
                case EnumerationExceptionHandling.Break:    return (EnumerationContinuation.Break, default!);
                case EnumerationExceptionHandling.Continue: return (EnumerationContinuation.Continue, default!);
            }
            throw;
        }
    }

    private enum EnumerationContinuation
    {
        Yield,
        Continue,
        Break
    }

    public static IEnumerable<TReturn> TrySelect<T, TReturn>(
        this IEnumerable<T> inputs,
        Func<T, TReturn> getValue,
        EnumerateExceptionHandler<T>? exceptionHandler = null)
    {
        foreach (var input in inputs)
        {
            switch (TryGetNext(input, getValue, exceptionHandler))
            {
                case (EnumerationContinuation.Yield, var @return): yield return @return; break;
                case (EnumerationContinuation.Continue, _):        continue;
                case (EnumerationContinuation.Break, _):           yield break;
            }
        }
    }
}

internal static class LoggerExtensions
{
    public static EnumerateExceptionHandler<TPrev> CreateLogExceptionHandler<TPrev>(
        this ILogger logger,
        EnumerationExceptionHandling exceptionHandling,
        Action<TPrev, LogMessageBuilder> log)
    {
        var logLevel = ToLogLevel(exceptionHandling);
        if (!logger.IsEnabled(logLevel))
            return NoOpExceptionHandler<TPrev>(exceptionHandling);

        return (t, exception) =>
        {
            LogMessageBuilder logMessageBuilder = (message, args) => logger.Log(logLevel, exception, message, args);
            log(t, logMessageBuilder);
            return exceptionHandling;
        };
    }

    private static EnumerateExceptionHandler<TPrev> NoOpExceptionHandler<TPrev>(EnumerationExceptionHandling exceptionHandling) =>
        (_, _) => exceptionHandling;

    private static LogLevel ToLogLevel(EnumerationExceptionHandling exceptionHandling) =>
        exceptionHandling is EnumerationExceptionHandling.Throw ? LogLevel.Error : LogLevel.Warning;

    public delegate void LogMessageBuilder([StructuredMessageTemplate] string message, params object?[] args);
}