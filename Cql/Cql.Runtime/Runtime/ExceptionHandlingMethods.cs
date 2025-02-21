/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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