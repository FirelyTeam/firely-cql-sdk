using JetBrains.Annotations;

namespace Hl7.Cql.Runtime;

internal static class ExceptionHandlingMethods
{
    public static IEnumerable<(TInput Input, Func<T> GetValue)> TrySelect<TInput, T>(
        this IEnumerable<TInput> inputs,
        Func<TInput, T> getValue) =>
        inputs.Select(input => (input, (Func<T>)(() => getValue(input))));

    public static IEnumerable<(TInput Input, T Value)> CatchEachPair<TInput, T>(
        this IEnumerable<(TInput Input, Func<T> GetValue)> inputGetValuePairs,
        EnumerateExceptionHandler<TInput>? exceptionHandler = null)
    {
        foreach (var (input, getValue) in inputGetValuePairs)
        {
            T value;
            try
            {
                value = getValue();
            }
            catch (Exception e)
            {
                switch (exceptionHandler?.Invoke(input, e))
                {
                    case EnumerationExceptionHandling.Break:    yield break;
                    case EnumerationExceptionHandling.Continue: continue;
                }
                throw;
            }

            yield return (input, value);
        }
    }

    public static IEnumerable<T> CatchEach<TInput, T>(
        this IEnumerable<(TInput Input, Func<T> GetValue)> inputGetValuePairs,
        EnumerateExceptionHandler<TInput>? exceptionHandler = null) =>
        inputGetValuePairs.CatchEachPair(exceptionHandler).Select(pair => pair.Value);

    public static IEnumerable<(T Value, Action<T> WithValue)> TryWithEach<T>(
        this IEnumerable<T> values,
        Action<T> withValue) =>
        values.Select(s => (s, withValue));

    public static IEnumerable<T> CatchEach<T>(
        this IEnumerable<(T Value, Action<T> WithValue)> withEachValues,
        EnumerateExceptionHandler<T>? exceptionHandler = null)
    {
        foreach (var (value, withValue) in withEachValues)
        {
            try
            {
                withValue(value);
            }
            catch (Exception e)
            {
                switch (exceptionHandler?.Invoke(value, e))
                {
                    case EnumerationExceptionHandling.Break:    yield break;
                    case EnumerationExceptionHandling.Continue: continue;
                }
                throw;
            }

            yield return value;
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