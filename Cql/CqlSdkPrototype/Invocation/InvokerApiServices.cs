namespace CqlSdkPrototype.Invocation;

internal readonly record struct InvokerApiServices(
    ILoggerFactory LoggerFactory)
{
    public static InvokerApiServices Create(ILoggerFactory? loggerFactory)
    {
        loggerFactory ??= NullLoggerFactory.Instance;
        return new InvokerApiServices(loggerFactory);
    }

    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
}