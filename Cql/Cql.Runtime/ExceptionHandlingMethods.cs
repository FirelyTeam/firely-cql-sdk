using JetBrains.Annotations;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace Hl7.Cql.Runtime;

// internal readonly record struct TryAction<TSource>(TSource SourceItem, Action<TSource> WithSource);
//internal readonly record struct TrySelect<TSource, TResult>(TSource Source, Func<TSource, TResult> GetResult);
// internal readonly record struct Pairwise<TSource, TResult>(TSource Source, TResult Result);


internal static class ExceptionHandlingMethods
{
    public static IEnumerable<(TSource Source, Func<TResult> GetResult)> TrySelect<TSource, TResult>(
        this IEnumerable<TSource> source,
        Func<TSource, TResult> selector) =>
        source.Select(s => (s, (Func<TResult>)(() => selector(s))));

    public static IEnumerable<(TSource Source, TResult Result)> CatchEachPair<TSource, TResult>(
        this IEnumerable<(TSource Source, Func<TResult> GetResult)> eachGetResults,
        EnumerateExceptionHandler<TSource>? exceptionHandler = null)
    {
        foreach (var (source, getResult) in eachGetResults)
        {
            TResult result;
            try
            {
                result = getResult();
            }
            catch (Exception e)
            {
                switch (exceptionHandler?.Invoke(source, e))
                {
                    case EnumerationExceptionHandling.Break:    yield break;
                    case EnumerationExceptionHandling.Continue: continue;
                }
                throw;
            }

            yield return (source, result);
        }
    }

    public static IEnumerable<TResult> CatchEach<TSource, TResult>(
        this IEnumerable<(TSource Source, Func<TResult> GetResult)> eachGetResults,
        EnumerateExceptionHandler<TSource>? exceptionHandler = null) =>
        eachGetResults.CatchEachPair(exceptionHandler).Select(pair => pair.Result);

    public static IEnumerable<(TSource Source, Action<TSource> WithSource)> TryWithEach<TSource>(
        this IEnumerable<TSource> source,
        Action<TSource> withSource) =>
        source.Select(s => (s, withSource));

    public static IEnumerable<TSource> CatchEach<TSource>(
        this IEnumerable<(TSource Source, Action<TSource> WithSource)> eachWithSources,
        EnumerateExceptionHandler<TSource>? exceptionHandler = null)
    {
        foreach (var (source, action) in eachWithSources)
        {
            try
            {
                action(source);
            }
            catch (Exception e)
            {
                switch (exceptionHandler?.Invoke(source, e))
                {
                    case EnumerationExceptionHandling.Break:    yield break;
                    case EnumerationExceptionHandling.Continue: continue;
                }
                throw;
            }

            yield return source;
        }
    }
}

/// <summary>
/// The exception policy to use while processing a batch of items.
/// </summary>
public enum EnumerationExceptionHandling
{
    /// <summary>
    /// Throw an exception when an error occurs.
    /// </summary>
    Throw = 0,

    /// <summary>
    /// Ignore the exception and continue to the next library.
    /// </summary>
    Continue = 1,

    /// <summary>
    /// Ignore the exception and break the process.
    /// </summary>
    Break = 2,
}

public delegate EnumerationExceptionHandling EnumerateExceptionHandler<in TSource>(TSource source, Exception exception);

internal static class LoggerExtensions
{
    private static LogLevel ToLogLevel(this EnumerationExceptionHandling exceptionHandling)
    {
        return exceptionHandling is EnumerationExceptionHandling.Throw ? LogLevel.Error : LogLevel.Warning;
    }

    public static EnumerateExceptionHandler<T> CreateLoggingEnumerateExceptionHandler<T>(
        this ILogger logger,
        EnumerationExceptionHandling enumerationExceptionHandling,
        Action<T, FormattedLogMessageBuilder> logMessage) =>
        (t, exception) =>
        {
            logMessage(t, (message, args) => logger.Log(enumerationExceptionHandling.ToLogLevel(), exception, message, args));
            return enumerationExceptionHandling;
        };

    public delegate void FormattedLogMessageBuilder([StructuredMessageTemplate] string message, params object[] args);
}

// //internal delegate T Deferred<out T>();
// internal readonly record struct TryAction<TSource>(TSource SourceItem, Action<TSource> WithSource);
// internal readonly record struct TrySelect<TSource, TResult>(TSource Source, Func<TSource, TResult> GetResult);
// internal readonly record struct Pairwise<TSource, TResult>(TSource Source, TResult Result);

// internal static partial class ExceptionHandlingMethods
// {
//     public static IEnumerable<TriedResult<TInput>> TryProcessEach<TInput>(
//         this IEnumerable<TInput> inputs,
//         Action<TInput> processInput)
//     {
//         foreach (var input in inputs)
//         {
//             TriedResult<TInput> outcome = new(input);
//             try
//             {
//                 processInput(input);
//             }
//             catch (Exception e)
//             {
//                 outcome = outcome with { ExceptionDispatchInfo = ExceptionDispatchInfo.Capture(e) };
//             }
//
//             yield return outcome;
//         }
//     }
//
//     public static IEnumerable<TriedResult<TInput>> WithEachException<TInput>(
//         this IEnumerable<TriedResult<TInput>> outcomes,
//         Action<InputWithException<TInput>> processOutcome)
//     {
//         foreach (var outcome in outcomes)
//         {
//             if (outcome.Exception is { } e)
//                 processOutcome(new(outcome.Input, e));
//             yield return outcome;
//         }
//     }
//     }
//
//     public static IEnumerable<TInput> HandleExceptions<TInput>(
//         this IEnumerable<TriedResult<TInput>> processBatchItemResults,
//         ProcessBatchItemExceptionHandling exceptionHandling)
//     {
//         return exceptionHandling switch
//         {
//             ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak => processBatchItemResults.HandleAndAbortBeforeFirstException(),
//             ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue => processBatchItemResults.HandleAndIgnoreAllExceptions(),
//             _ => processBatchItemResults.HandleAndThrowAtFirstException()
//         };
//     }
//
//     public static IEnumerable<TInput> HandleAndThrowAtFirstException<TInput>(
//         this IEnumerable<TriedResult<TInput>> processBatchItemResults)
//     {
//         foreach (var (input, exceptionDispatchInfo) in processBatchItemResults)
//         {
//             if (exceptionDispatchInfo is not null)
//                 exceptionDispatchInfo.Throw();
//             yield return input;
//         }
//     }
//
//     public static IEnumerable<TInput> HandleAndAbortBeforeFirstException<TInput>(
//         this IEnumerable<TriedResult<TInput>> processBatchItemResults)
//     {
//         foreach (var (input, exceptionDispatchInfo) in processBatchItemResults)
//         {
//             if (exceptionDispatchInfo is not null)
//                 yield break;
//             yield return input;
//         }
//     }
//
//     public static IEnumerable<TInput> HandleAndIgnoreAllExceptions<TInput>(
//         this IEnumerable<TriedResult<TInput>> processBatchItemResults)
//     {
//         foreach (var (input, exceptionDispatchInfo) in processBatchItemResults)
//         {
//             if (exceptionDispatchInfo?.SourceException is not null)
//                 yield return input;
//         }
//     }
//
//     public static IEnumerable<TriedResult<TInput, TResult>> TryProcessEach<TInput, TResult>(
//         this IEnumerable<TInput> inputs,
//         Func<TInput, TResult> processInput)
//     {
//         foreach (var input in inputs)
//         {
//             TriedResult<TInput, TResult> outcome = new(input);
//             try
//             {
//                 outcome = outcome with { Result = processInput(input) };
//             }
//             catch (Exception e)
//             {
//                 outcome = outcome with { ExceptionDispatchInfo = ExceptionDispatchInfo.Capture(e) };
//             }
//
//             yield return outcome;
//         }
//     }
//
//     public static IEnumerable<TriedResult<TInput, TResult>> WithEachException<TInput, TResult>(
//         this IEnumerable<TriedResult<TInput, TResult>> outcomes,
//         Action<InputWithException<TInput>> processOutcome)
//     {
//         foreach (var outcome in outcomes)
//         {
//             if (outcome.Exception is {} e)
//                 processOutcome(new (outcome.Input, e));
//             yield return outcome;
//         }
//     }
//
//     public static IEnumerable<TResult> HandleExceptions<TInput, TResult>(
//         this IEnumerable<TriedResult<TInput, TResult>> processBatchItemResults,
//         ProcessBatchItemExceptionHandling exceptionHandling)
//     {
//         return exceptionHandling switch
//         {
//             ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak => processBatchItemResults.HandleAndAbortBeforeFirstException(),
//             ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue => processBatchItemResults.HandleAndIgnoreAllExceptions(),
//             _ => processBatchItemResults.HandleAndThrowAtFirstException()
//         };
//     }
//
//     public static IEnumerable<TResult> HandleAndThrowAtFirstException<TInput, TResult>(
//         this IEnumerable<TriedResult<TInput, TResult>> processBatchItemResults)
//     {
//         foreach (var (_, result, exceptionDispatchInfo) in processBatchItemResults)
//         {
//             if (exceptionDispatchInfo is not null)
//                 exceptionDispatchInfo.Throw();
//             yield return result!;
//         }
//     }
//
//     public static IEnumerable<TResult> HandleAndAbortBeforeFirstException<TInput, TResult>(
//         this IEnumerable<TriedResult<TInput, TResult>> processBatchItemResults)
//     {
//         foreach (var (_, result, exceptionDispatchInfo) in processBatchItemResults)
//         {
//             if (exceptionDispatchInfo is null)
//                 yield return result!;
//             else
//                 yield break;
//         }
//     }
//
//     public static IEnumerable<TResult> HandleAndIgnoreAllExceptions<TInput, TResult>(
//         this IEnumerable<TriedResult<TInput, TResult>> processBatchItemResults)
//     {
//         foreach (var (_, result, exceptionDispatchInfo) in processBatchItemResults)
//         {
//             if (exceptionDispatchInfo is null)
//                 yield return result!;
//         }
//     }
//
//     public readonly record struct TriedResult<TInput>(
//         TInput Input,
//         ExceptionDispatchInfo? ExceptionDispatchInfo = null) {
//         internal ExceptionDispatchInfo? ExceptionDispatchInfo { get; init; } = ExceptionDispatchInfo;
//         public Exception? Exception => ExceptionDispatchInfo?.SourceException;
//     }
//
//     public readonly record struct TriedResult<TInput, TResult>(
//         TInput Input,
//         TResult? Result = default,
//         ExceptionDispatchInfo? ExceptionDispatchInfo = null)
//     {
//         internal ExceptionDispatchInfo? ExceptionDispatchInfo { get; init; } = ExceptionDispatchInfo;
//         public Exception? Exception => ExceptionDispatchInfo?.SourceException;
//     }
//
//     public readonly record struct InputWithException<TInput>(
//         TInput Input,
//         Exception Exception);
// }