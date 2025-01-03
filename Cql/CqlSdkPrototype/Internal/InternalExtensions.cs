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
}