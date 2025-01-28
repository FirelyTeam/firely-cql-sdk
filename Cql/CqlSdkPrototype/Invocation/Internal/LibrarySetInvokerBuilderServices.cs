using CqlSdkPrototype.Invocation.Extensibility;

namespace CqlSdkPrototype.Invocation.Internal;

internal readonly record struct LibrarySetInvokerBuilderServices(
    ILoggerFactory LoggerFactory,
    ImmutableHashSet<RuntimeApiStateEntry> Entries,
    LibrarySetInvokerBuilderSettings Options,
    ILogger<LibrarySetInvokerBuilder> Logger)
{
    public static LibrarySetInvokerBuilderServices Create(ILoggerFactory loggerFactory, LibrarySetInvokerBuilderSettings options)
    {
        return new LibrarySetInvokerBuilderServices(loggerFactory, [], null!, null!)
        {
            // Must be set through the property initializer, to ensure the services are created
            Options = options,
        };
    }

    private readonly LibrarySetInvokerBuilderSettings _options = Options;

    public LibrarySetInvokerBuilderSettings Options
    {
        get => _options;
        init
        {
            if (ReferenceEquals(_options, value))
                return;

            _options = value;
            Logger = LoggerFactory.CreateLogger<LibrarySetInvokerBuilder>();
        }
    }

    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
}