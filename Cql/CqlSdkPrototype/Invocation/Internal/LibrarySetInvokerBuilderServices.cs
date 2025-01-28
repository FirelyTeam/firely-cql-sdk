namespace CqlSdkPrototype.Invocation.Internal;

internal readonly record struct LibrarySetInvokerBuilderServices(
    ILoggerFactory LoggerFactory,
    ImmutableHashSet<LibraryBinaries> Entries,
    LibrarySetInvokerBuilderSettings Options,
    ILogger<FluentLibrarySetInvokerBuilder> Logger)
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
            Logger = LoggerFactory.CreateLogger<FluentLibrarySetInvokerBuilder>();
        }
    }

    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
}