using CqlSdkPrototype.Runtime.Extensibility;
using Microsoft.Extensions.DependencyInjection;

namespace CqlSdkPrototype.Runtime;

internal readonly record struct RuntimeServices(
    ILoggerFactory LoggerFactory,
    RuntimeApiStateEntryHashSet Entries,
    RuntimeApiOptions Options,
    ILogger<RuntimeApi> Logger)
{
    public static RuntimeServices Create(ILoggerFactory? loggerFactory, RuntimeApiOptions options)
    {
        loggerFactory ??= NullLoggerFactory.Instance;
        return new RuntimeServices(loggerFactory, [], null!, null!)
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
            Logger = LoggerFactory.CreateLogger<RuntimeApi>();
        }
    }

    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
}