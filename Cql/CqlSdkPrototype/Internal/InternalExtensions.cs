using System.Reflection;
using System.Runtime.Loader;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Runtime;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Internal;

internal static class InternalExtensions
{
    public static string[] SplitLines(this string multilineString) =>
        multilineString.Split([Environment.NewLine], StringSplitOptions.None);

    public static string Join(this IEnumerable<string> lines) =>
        string.Concat(lines);

    public static string JoinLines(this IEnumerable<string> lines) =>
        string.Join(Environment.NewLine, lines);

    public static string TakeLines(this string multilineString, int count) =>
        multilineString.SplitLines().Take(count).JoinLines();

    public static string TrimFileExtension(this string filePath, string extension) =>
        filePath.EndsWith(extension, StringComparison.OrdinalIgnoreCase)
            ? filePath[..^extension.Length]
            : filePath;

    public static Assembly LoadFromBytes(this AssemblyLoadContext assemblyLoadContext, byte[] assembly, byte[]? symbols = null)
    {
        using var assemblyStream = new MemoryStream(assembly);
        var symbolsStream = symbols is {Length:>0} ? new MemoryStream(symbols) : null;
        using var symbolsStreamDisposable = symbolsStream as IDisposable ?? new EmptyDisposable();
        return assemblyLoadContext.LoadFromStream(assemblyStream, symbolsStream);
    }

    public static IEnumerable<TR> SelectWhereNotNull<T, TR>(
        this IEnumerable<T> enumerable,
        Func<T, TR?> selectNullable)
        where TR : class
    {
        return enumerable
               .Select(selectNullable)
               .WhereNotNull();
    }

    public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> enumerable)
        where T : class
    {
        return enumerable
               .Where(x => x is not null)
               .Select(x => x!);
    }

    public static bool IsBetween(
        this Version value,
        Version lowerIncl,
        Version upperExcl)
    {
        return value >= lowerIncl && value < upperExcl;
    }

    public static Maybe<TSource> TryGetFirst<TSource>(this IEnumerable<TSource> source)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        if (source is IList<TSource> list)
        {
            if (list.Count > 0)
            {
                return list[0];
            }
        }
        else
        {
            using IEnumerator<TSource> e = source.GetEnumerator();
            if (e.MoveNext())
            {
                return e.Current;
            }
        }

        return Maybe<TSource>.NoValue;
    }

    public static Maybe<TSource> TryGetFirst<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        foreach (TSource element in source)
        {
            if (predicate(element))
            {
                return element;
            }
        }

        return Maybe<TSource>.NoValue;
    }

    public static LogExceptionMessageAction GetLogExceptionMessageAction(
        this ILogger logger,
        ProcessBatchItemExceptionHandling exceptionHandling) =>
        exceptionHandling is ProcessBatchItemExceptionHandling.ThrowException ? logger.LogError : logger.LogWarning;
}

internal delegate void LogExceptionMessageAction(
    Exception? exception,
    string? message,
    params object?[] args);