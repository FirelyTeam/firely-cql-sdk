/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

internal static class EnumerableExceptionHandlingExtensions
{
    private static void EnrichException<TCurrent, TNext>(TCurrent current, Exception e)
    {
        e.Data["Current"] = current;
        e.Data["CurrentType"] = typeof(TCurrent);
        e.Data["NextType"] = typeof(TNext);
    }

    public static int TryForEach<T>(
        this IEnumerable<T> inputs,
        Action<T> withValue,
        BatchProcessExceptionHandlingStrategyBuilder<T>? buildExceptionHandlingStrategy = null) =>
        inputs.TrySelect(
                  input =>
                  {
                      withValue(input);
                      return 0;
                  },
                  buildExceptionHandlingStrategy)
              .Count();

    public static IEnumerable<TReturn> TrySelect<T, TReturn>(
        this IEnumerable<T> inputs,
        Func<T, TReturn> selector,
        BatchProcessExceptionHandlingStrategyBuilder<T>? buildExceptionHandlingStrategy = null,
        Func<T, TReturn>? selectOnException = null)
    {
        bool firstException = true, breakLoop = false;
        BatchProcessExceptionHandlingStrategy<T> strategy = default;
        foreach (var input in inputs)
        {
            TReturn next = default!;
            try
            {
                next = selector(input);
            }
            catch (Exception e)
            {
                EnrichException<T, TReturn>(input, e);

                if (firstException)
                {
                    firstException = false;
                    strategy = buildExceptionHandlingStrategy?.Invoke(default) ?? default;
                }

                strategy.ExceptionHandler?.Invoke(input, e, strategy.ExceptionContinuation);

                if (strategy.ExceptionContinuation is BatchProcessExceptionContinuation.Throw)
                    throw;

                if (selectOnException is not null)
                {
                    next = selectOnException(input);
                    breakLoop = strategy.ExceptionContinuation is BatchProcessExceptionContinuation.Break;
                }
                else
                {
                    switch (strategy.ExceptionContinuation)
                    {
                        case BatchProcessExceptionContinuation.Continue: continue;
                        case BatchProcessExceptionContinuation.Break: yield break;
                        default: throw new UnreachableException(); // Should never happen
                    }
                }
            }

            yield return next;

            if (breakLoop)
                break;
        }
    }
}