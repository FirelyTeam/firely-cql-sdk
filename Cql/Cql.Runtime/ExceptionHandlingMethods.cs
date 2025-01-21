using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Runtime;

internal static class ExceptionHandlingMethods
{
    public static IEnumerable<TriedResult<TInput>> TryProcessEach<TInput>(
        this IEnumerable<TInput> inputs,
        Action<TInput> processInput)
    {
        foreach (var input in inputs)
        {
            TriedResult<TInput> outcome = new(input);
            try
            {
                processInput(input);
            }
            catch (Exception e)
            {
                outcome = outcome with { ExceptionDispatchInfo = ExceptionDispatchInfo.Capture(e) };
            }

            yield return outcome;
        }
    }

    public static IEnumerable<TriedResult<TInput>> WithEachException<TInput>(
        this IEnumerable<TriedResult<TInput>> outcomes,
        Action<InputWithException<TInput>> processOutcome)
    {
        foreach (var outcome in outcomes)
        {
            if (outcome.Exception is { } e)
                processOutcome(new(outcome.Input, e));
            yield return outcome;
        }
    }

    public static IEnumerable<TInput> HandleExceptions<TInput>(
        this IEnumerable<TriedResult<TInput>> processBatchItemResults,
        ProcessBatchItemExceptionHandling exceptionHandling)
    {
        return exceptionHandling switch
        {
            ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak => processBatchItemResults.HandleAndAbortBeforeFirstException(),
            ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue => processBatchItemResults.HandleAndIgnoreAllExceptions(),
            _ => processBatchItemResults.HandleAndThrowAtFirstException()
        };
    }

    public static IEnumerable<TInput> HandleAndThrowAtFirstException<TInput>(
        this IEnumerable<TriedResult<TInput>> processBatchItemResults)
    {
        foreach (var (input, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is not null)
                exceptionDispatchInfo.Throw();
            yield return input;
        }
    }

    public static IEnumerable<TInput> HandleAndAbortBeforeFirstException<TInput>(
        this IEnumerable<TriedResult<TInput>> processBatchItemResults)
    {
        foreach (var (input, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is not null)
                yield break;
            yield return input;
        }
    }

    public static IEnumerable<TInput> HandleAndIgnoreAllExceptions<TInput>(
        this IEnumerable<TriedResult<TInput>> processBatchItemResults)
    {
        foreach (var (input, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo?.SourceException is not null)
                yield return input;
        }
    }

    public static IEnumerable<TriedResult<TInput, TResult>> TryProcessEach<TInput, TResult>(
        this IEnumerable<TInput> inputs,
        Func<TInput, TResult> processInput)
    {
        foreach (var input in inputs)
        {
            TriedResult<TInput, TResult> outcome = new(input);
            try
            {
                outcome = outcome with { Result = processInput(input) };
            }
            catch (Exception e)
            {
                outcome = outcome with { ExceptionDispatchInfo = ExceptionDispatchInfo.Capture(e) };
            }

            yield return outcome;
        }
    }

    public static IEnumerable<TriedResult<TInput, TResult>> WithEachException<TInput, TResult>(
        this IEnumerable<TriedResult<TInput, TResult>> outcomes,
        Action<InputWithException<TInput>> processOutcome)
    {
        foreach (var outcome in outcomes)
        {
            if (outcome.Exception is {} e)
                processOutcome(new (outcome.Input, e));
            yield return outcome;
        }
    }

    public static IEnumerable<TResult> HandleExceptions<TInput, TResult>(
        this IEnumerable<TriedResult<TInput, TResult>> processBatchItemResults,
        ProcessBatchItemExceptionHandling exceptionHandling)
    {
        return exceptionHandling switch
        {
            ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak => processBatchItemResults.HandleAndAbortBeforeFirstException(),
            ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue => processBatchItemResults.HandleAndIgnoreAllExceptions(),
            _ => processBatchItemResults.HandleAndThrowAtFirstException()
        };
    }

    public static IEnumerable<TResult> HandleAndThrowAtFirstException<TInput, TResult>(
        this IEnumerable<TriedResult<TInput, TResult>> processBatchItemResults)
    {
        foreach (var (_, result, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is not null)
                exceptionDispatchInfo.Throw();
            yield return result!;
        }
    }

    public static IEnumerable<TResult> HandleAndAbortBeforeFirstException<TInput, TResult>(
        this IEnumerable<TriedResult<TInput, TResult>> processBatchItemResults)
    {
        foreach (var (_, result, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is null)
                yield return result!;
            else
                yield break;
        }
    }

    public static IEnumerable<TResult> HandleAndIgnoreAllExceptions<TInput, TResult>(
        this IEnumerable<TriedResult<TInput, TResult>> processBatchItemResults)
    {
        foreach (var (_, result, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is null)
                yield return result!;
        }
    }

    public readonly record struct TriedResult<TInput>(
        TInput Input,
        ExceptionDispatchInfo? ExceptionDispatchInfo = null) {
        internal ExceptionDispatchInfo? ExceptionDispatchInfo { get; init; } = ExceptionDispatchInfo;
        public Exception? Exception => ExceptionDispatchInfo?.SourceException;
    }

    public readonly record struct TriedResult<TInput, TResult>(
        TInput Input,
        TResult? Result = default,
        ExceptionDispatchInfo? ExceptionDispatchInfo = null)
    {
        internal ExceptionDispatchInfo? ExceptionDispatchInfo { get; init; } = ExceptionDispatchInfo;
        public Exception? Exception => ExceptionDispatchInfo?.SourceException;
    }

    public readonly record struct InputWithException<TInput>(
        TInput Input,
        Exception Exception);
}