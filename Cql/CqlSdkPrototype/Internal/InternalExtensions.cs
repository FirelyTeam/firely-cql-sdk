namespace CqlSdkPrototype.Internal;

internal static class InternalExtensions
{
    public static Assembly LoadFromBytes(this AssemblyLoadContext assemblyLoadContext, byte[] assembly, byte[]? symbols = null)
    {
        using var assemblyStream = new MemoryStream(assembly);
        var symbolsStream = symbols is {Length:>0} ? new MemoryStream(symbols) : null;
        using var symbolsStreamDisposable = symbolsStream as IDisposable;
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

    public static LogExceptionMessageAction GetLogExceptionMessageAction(
        this ILogger logger,
        EnumerationExceptionHandling exceptionHandling) =>
        exceptionHandling is EnumerationExceptionHandling.Throw ? logger.LogError : logger.LogWarning;
}

internal delegate void LogExceptionMessageAction(
    Exception? exception,
    string? message,
    params object?[] args);