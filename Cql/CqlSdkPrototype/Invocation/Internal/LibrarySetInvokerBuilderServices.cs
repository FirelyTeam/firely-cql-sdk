namespace CqlSdkPrototype.Invocation.Internal;

internal readonly record struct LibrarySetInvokerBuilderServices(
    ILogger<LibrarySetInvokerBuilder> Logger)
{
    public static LibrarySetInvokerBuilderServices Create(
        ILoggerFactory loggerFactory)
    {
        // No other services needed at this time.
        return new LibrarySetInvokerBuilderServices(loggerFactory.CreateLogger<LibrarySetInvokerBuilder>());
    }
}