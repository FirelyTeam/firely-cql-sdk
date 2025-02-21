namespace Hl7.Cql.Runtime;


internal static class ExceptionHandlingMethods
{
    private static (bool success, TNext next) Try<TCurrent, TNext>(
        TCurrent current,
        Func<TCurrent, TNext> getNext,
        bool noThrow,
        ValueExceptionHandler<TCurrent>? valueExceptionHandler)
    {
        try
        {
            TNext next = getNext(current);
            return (true, next);
        }
        catch (Exception e)
        {
            e.Data["Current"] = current;
            e.Data["CurrentType"] = typeof(TCurrent);
            e.Data["NextType"] = typeof(TNext);
            valueExceptionHandler?.Invoke(current, e);
            if (noThrow)
                return (false, default!);

            throw;
        }
    }

    public static int TryForEach<T>(
        this IEnumerable<T> inputs,
        Action<T> withValue,
        EnumerationErrorStrategyBuilder<T>? buildErrorStrategy = null) =>
        inputs.TrySelect(
                  input =>
                  {
                      withValue(input);
                      return 0;
                  },
                  buildErrorStrategy)
              .Count();

    public static IEnumerable<TReturn> TrySelect<T, TReturn>(
        this IEnumerable<T> inputs,
        Func<T, TReturn> selector,
        EnumerationErrorStrategyBuilder<T>? buildErrorStrategy = null)
    {
        var errorStrategy = buildErrorStrategy?.Invoke(default) ?? default;
        foreach (var input in inputs)
        {
            var noThrow = errorStrategy.NoThrow;
            var (success, next) = Try(input, selector, noThrow, errorStrategy.ExceptionHandler);
            switch (success, next, errorStrategy.Continuation)
            {
                case (true, var @return, _): yield return @return; break;
                case (_, _, ErroredEnumerationContinuation.Continue): continue;
                case (_, _, ErroredEnumerationContinuation.Break): yield break;
            }
        }
    }
}
internal readonly record struct EnumerationErrorStrategy<T>(
    ErroredEnumerationContinuation Continuation = ErroredEnumerationContinuation.Throw,
    ValueExceptionHandler<T>? ExceptionHandler = null)
{
    public bool NoThrow => Continuation is not ErroredEnumerationContinuation.Throw;
}

internal delegate EnumerationErrorStrategy<T> EnumerationErrorStrategyBuilder<T>(EnumerationErrorStrategy<T> options);

internal static class LoggerExtensions
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