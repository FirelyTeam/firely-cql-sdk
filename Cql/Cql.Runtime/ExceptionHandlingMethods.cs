using System;
using System.Collections.Generic;
using Hl7.Cql.Abstractions.Exceptions;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Runtime;

internal static class ExceptionHandlingMethods
{
    public delegate (string message, object[] args)? ProcessBatchItemExceptionHandlingBuildLoggerMessage<in T>(
        ProcessBatchItemExceptionHandling exceptionHandling,
        T item,
        Exception? exception = null);

    public static void ProcessBatchWithExceptionHandlingAndLogging<T>(
        IEnumerable<T> items,
        Action<T> process,
        ProcessBatchItemExceptionHandling exceptionHandling,
        ILogger logger,
        ProcessBatchItemExceptionHandlingBuildLoggerMessage<T> buildLoggerMessage)
    {
        foreach (var _ in ProcessBatchWithExceptionHandlingAndLogging(
                     items,
                     item => {
                         process(item);
                         return 0;
                     },
                     exceptionHandling,
                     logger,
                     buildLoggerMessage)) ;
    }

    public static IEnumerable<TR> ProcessBatchWithExceptionHandlingAndLogging<T, TR>(
        IEnumerable<T> items,
        Func<T, TR> process,
        ProcessBatchItemExceptionHandling exceptionHandling,
        ILogger logger,
        ProcessBatchItemExceptionHandlingBuildLoggerMessage<T> buildLoggerMessage)
    {
        Action<Exception?, string?, object?[]> logException =
            exceptionHandling is ProcessBatchItemExceptionHandling.ThrowException ? logger.LogError : logger.LogWarning;

        foreach (var item in items)
        {
            TR result;
            try
            {
                result = process(item);
                if (buildLoggerMessage(exceptionHandling, item) is ({ } message, { } args))
                    logger.LogInformation(message, args);
            }
            catch (Exception e)
            {
                if (buildLoggerMessage(exceptionHandling, item, e) is ({ } message, { } args))
                    logException(e, message, args);

                switch (exceptionHandling)
                {
                    default:                                                            throw;
                    case ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue: continue;
                    case ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak:    yield break;
                }
            }
            yield return result;
        }
    }

    // public static IEnumerable<TR> IgnoreExceptionsAndContinue<T, TR>(
    //     IEnumerable<T> items,
    //     Func<T, TR> process)
    // {
    // }
}