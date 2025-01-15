using CqlSdkPrototype.Runtime.Extensibility;

namespace CqlSdkPrototype.Runtime;

internal readonly record struct RuntimeApiState(
    ILoggerFactory LoggerFactory,
    ImmutableHashSet<RuntimeApiStateEntry> Entries,
    RuntimeApiOptions Options,
    ILogger<RuntimeApi> Logger)
{
    public static RuntimeApiState Create(ILoggerFactory loggerFactory, RuntimeApiOptions options)
    {
        return new RuntimeApiState(loggerFactory, [], null!, null!)
        {
            // Must be set through the property initializer, to ensure the services are created
            Options = options,
        };
    }

    private readonly RuntimeApiOptions _options = Options;

    public RuntimeApiOptions Options
    {
        get => _options;
        init
        {
            if (ReferenceEquals(_options, value))
                return;

            _options = value;
            Logger = value.LoggerFactory.CreateLogger<RuntimeApi>();
        }
    }

    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
}