using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Runtime;

internal static class ExceptionHandlingMethods
{
    public static IEnumerable<ProcessBatchItemResult<TInput>> TryProcessEach<TInput>(
        this IEnumerable<TInput> inputs,
        Action<TInput> processInput)
    {
        foreach (var input in inputs)
        {
            ProcessBatchItemResult<TInput> outcome = new(input);
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

    public static IEnumerable<ProcessBatchItemResult<TInput>> ThenForEachOutcome<TInput>(
        this IEnumerable<ProcessBatchItemResult<TInput>> outcomes,
        Action<ProcessBatchItemResult<TInput>> processOutcome)
    {
        foreach (var outcome in outcomes)
        {
            processOutcome(outcome);
            yield return outcome;
        }
    }

    public static void HandleExceptions<TInput>(
        this IEnumerable<ProcessBatchItemResult<TInput>> processBatchItemResults,
        ProcessBatchItemExceptionHandling exceptionHandling)
    {
        switch (exceptionHandling)
        {
            case ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak:
                processBatchItemResults.BreakAtFirstException();
                break;
            case ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue:
                processBatchItemResults.ContinueOnExceptions();
                break;
            default:
                processBatchItemResults.ThrowAtFirstException();
                break;
        }
    }

    public static void ThrowAtFirstException<TInput>(
        this IEnumerable<ProcessBatchItemResult<TInput>> processBatchItemResults)
    {
        foreach (var (_, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is not null)
                exceptionDispatchInfo.Throw();
        }
    }

    public static void BreakAtFirstException<TInput>(
        this IEnumerable<ProcessBatchItemResult<TInput>> processBatchItemResults)
    {
        foreach (var (_, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is not null)
                return;
        }
    }

    public static void ContinueOnExceptions<TInput>(
        this IEnumerable<ProcessBatchItemResult<TInput>> processBatchItemResults)
    {
        foreach (var _ in processBatchItemResults)
        {
            ; // Intentionally empty
        }
    }

    public static IEnumerable<ProcessBatchItemResult<TInput, TResult>> TryProcessEach<TInput, TResult>(
        this IEnumerable<TInput> inputs,
        Func<TInput, TResult> processInput)
    {
        foreach (var input in inputs)
        {
            ProcessBatchItemResult<TInput, TResult> outcome = new(input);
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

    public static IEnumerable<ProcessBatchItemResult<TInput, TResult>> ThenForEachOutcome<TInput, TResult>(
        this IEnumerable<ProcessBatchItemResult<TInput, TResult>> outcomes,
        Action<ProcessBatchItemResult<TInput, TResult>> processOutcome)
    {
        foreach (var outcome in outcomes)
        {
            processOutcome(outcome);
            yield return outcome;
        }
    }

    public static IEnumerable<TResult> HandleExceptions<TInput, TResult>(
        this IEnumerable<ProcessBatchItemResult<TInput, TResult>> processBatchItemResults,
        ProcessBatchItemExceptionHandling exceptionHandling)
    {
        return exceptionHandling switch
        {
            ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak => processBatchItemResults.BreakAtFirstException(),
            ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue => processBatchItemResults.ContinueOnExceptions(),
            _ => processBatchItemResults.ThrowAtFirstException()
        };
    }

    public static IEnumerable<TResult> ThrowAtFirstException<TInput, TResult>(
        this IEnumerable<ProcessBatchItemResult<TInput, TResult>> processBatchItemResults)
    {
        foreach (var (_, result, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is not null)
                exceptionDispatchInfo.Throw();
            yield return result!;
        }
    }

    public static IEnumerable<TResult> BreakAtFirstException<TInput, TResult>(
        this IEnumerable<ProcessBatchItemResult<TInput, TResult>> processBatchItemResults)
    {
        foreach (var (_, result, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is null)
                yield return result!;
            else
                yield break;
        }
    }

    public static IEnumerable<TResult> ContinueOnExceptions<TInput, TResult>(
        this IEnumerable<ProcessBatchItemResult<TInput, TResult>> processBatchItemResults)
    {
        foreach (var (_, result, exceptionDispatchInfo) in processBatchItemResults)
        {
            if (exceptionDispatchInfo is null)
                yield return result!;
        }
    }

    public readonly record struct ProcessBatchItemResult<TInput>(
        TInput Input,
        ExceptionDispatchInfo? Exception = null);

    public readonly record struct ProcessBatchItemResult<TInput, TResult>(
        TInput Input,
        TResult? Result = default,
        ExceptionDispatchInfo? Exception = null);
}