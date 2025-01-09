using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Runtime;

internal static class ExceptionHandlingMethods
{
    public static IEnumerable<TryOutcome<TInput>> TryProcessEach<TInput>(
        this IEnumerable<TInput> inputs,
        Action<TInput> processInput)
    {
        foreach (var input in inputs)
        {
            TryOutcome<TInput> outcome = new(input);
            try
            {
                processInput(input);
            }
            catch (Exception e)
            {
                outcome = outcome with { Exception = ExceptionDispatchInfo.Capture(e) };
            }

            yield return outcome;
        }
    }

    public static IEnumerable<TryOutcome<TInput>> HandleEachOutcome<TInput>(
        this IEnumerable<TryOutcome<TInput>> outcomes,
        Action<TryOutcome<TInput>> processOutcome)
    {
        foreach (var outcome in outcomes)
        {
            processOutcome(outcome);
            yield return outcome;
        }
    }

    public static IEnumerable<TInput> HandleExceptions<TInput>(
        this IEnumerable<TryOutcome<TInput>> processBatchItemResults,
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
        this IEnumerable<TryOutcome<TInput>> processBatchItemResults)
    {
        foreach (var (input, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is not null)
                exceptionDispatchInfo.Throw();
            yield return input;
        }
    }

    public static IEnumerable<TInput> HandleAndAbortBeforeFirstException<TInput>(
        this IEnumerable<TryOutcome<TInput>> processBatchItemResults)
    {
        foreach (var (input, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is not null)
                yield break;
            yield return input;
        }
    }

    public static IEnumerable<TInput> HandleAndIgnoreAllExceptions<TInput>(
        this IEnumerable<TryOutcome<TInput>> processBatchItemResults)
    {
        foreach (var (input, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo?.SourceException is not null)
                yield return input;
        }
    }

    public static IEnumerable<TryOutcome<TInput, TResult>> TryProcessEach<TInput, TResult>(
        this IEnumerable<TInput> inputs,
        Func<TInput, TResult> processInput)
    {
        foreach (var input in inputs)
        {
            TryOutcome<TInput, TResult> outcome = new(input);
            try
            {
                outcome = outcome with { Result = processInput(input) };
            }
            catch (Exception e)
            {
                outcome = outcome with { Exception = ExceptionDispatchInfo.Capture(e) };
            }

            yield return outcome;
        }
    }

    public static IEnumerable<TryOutcome<TInput, TResult>> HandleEachErroredOutcome<TInput, TResult>(
        this IEnumerable<TryOutcome<TInput, TResult>> outcomes,
        Action<TryOutcome<TInput, TResult>> processOutcome)
    {
        foreach (var outcome in outcomes)
        {
            if (outcome.Exception?.SourceException is not null)
                processOutcome(outcome);
            yield return outcome;
        }
    }

    public static IEnumerable<TryOutcome<TInput, TResult>> HandleEachOutcome<TInput, TResult>(
        this IEnumerable<TryOutcome<TInput, TResult>> outcomes,
        Action<TryOutcome<TInput, TResult>> processOutcome)
    {
        foreach (var outcome in outcomes)
        {
            processOutcome(outcome);
            yield return outcome;
        }
    }

    public static IEnumerable<TResult> HandleExceptions<TInput, TResult>(
        this IEnumerable<TryOutcome<TInput, TResult>> processBatchItemResults,
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
        this IEnumerable<TryOutcome<TInput, TResult>> processBatchItemResults)
    {
        foreach (var (_, result, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is not null)
                exceptionDispatchInfo.Throw();
            yield return result!;
        }
    }

    public static IEnumerable<TResult> HandleAndAbortBeforeFirstException<TInput, TResult>(
        this IEnumerable<TryOutcome<TInput, TResult>> processBatchItemResults)
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
        this IEnumerable<TryOutcome<TInput, TResult>> processBatchItemResults)
    {
        foreach (var (_, result, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is null)
                yield return result!;
        }
    }

    public readonly record struct TryOutcome<TInput>(
        TInput Input,
        ExceptionDispatchInfo? Exception = null);

    public readonly record struct TryOutcome<TInput, TResult>(
        TInput Input,
        TResult? Result = default,
        ExceptionDispatchInfo? Exception = null);
}