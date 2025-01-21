namespace CqlSdkPrototype.Invocation;

internal readonly record struct InvocationApiServices(
    ILoggerFactory LoggerFactory)
{
    public static InvocationApiServices Create(ILoggerFactory? loggerFactory)
    {
        loggerFactory ??= NullLoggerFactory.Instance;
        return new InvocationApiServices(loggerFactory);
    }

    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
}