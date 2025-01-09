using System.Reflection;
using System.Runtime.Loader;
using Hl7.Cql.Runtime;

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

    public static Maybe<T> TryFirst<T>(this IEnumerable<T> source)
    {
        return TryFirstImpl(source, out var value) ? value : Maybe.NoValue;
    }

    public static Maybe<T> TryFirst<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        return TryFirstImpl(source, predicate, out var value) ? value : Maybe.NoValue;
    }

    private static bool TryFirstImpl<TSource>(this IEnumerable<TSource> source, out TSource? found)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        if (source is IList<TSource> list)
        {
            if (list.Count > 0)
            {
                found = list[0];
                return true;
            }
        }
        else
        {
            using IEnumerator<TSource> e = source.GetEnumerator();
            if (e.MoveNext())
            {
                found = e.Current;
                return true;
            }
        }

        found = default;
        return false;
    }

    private static bool TryFirstImpl<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, out TSource? found)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        if (predicate == null)
            throw new ArgumentNullException(nameof(predicate));

        foreach (TSource element in source)
        {
            if (predicate(element))
            {
                found = element;
                return true;
            }
        }

        found = default;
        return false;
    }
}

internal readonly record struct Maybe
{
    public static Maybe NoValue => default;
}

internal readonly record struct Maybe<T>
{
    public static Maybe<T> NoValue => default;

    private readonly T _value;

    private Maybe(T Value)
    {
        this._value = Value;
    }

    public T Value => HasValue ? _value : throw new InvalidOperationException("No value");

    public bool HasValue { get; } = true;

    public static implicit operator Maybe<T>(T? value) => value is null ? NoValue : new(value);
    public static implicit operator Maybe<T>(Maybe value) => NoValue;
}

