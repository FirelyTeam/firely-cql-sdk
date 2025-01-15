using CqlSdkPrototype.Elm.Extensibility;
using CqlSdkPrototype.Elm.Internal;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Logging.Internal;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime.Hosting;

namespace CqlSdkPrototype.Elm;

internal readonly record struct ElmApiState(
    ILoggerFactory LoggerFactory,
    ImmutableDictionary<CqlVersionedLibraryIdentifier, ElmApiStateEntry> Entries,
    ElmApiOptions Options,
    ServiceProvider ServiceProvider,
    ILogger<ElmApi> Logger,
    AssemblyCompiler AssemblyCompiler,
    LibrarySetCSharpCodeGenerator LibrarySetCSharpCodeGenerator)
{
    public static ElmApiState Create(
        ILoggerFactory loggerFactory,
        ElmApiOptions options)
    {
        var entries = ImmutableDictionary<CqlVersionedLibraryIdentifier, ElmApiStateEntry>.Empty.WithComparers(CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
        return new ElmApiState(loggerFactory, entries, null!, null!, null!, null!, null!)
        {
            // Must be set through the property initializer, to ensure the services are created
            Options = options
        };
    }

    private readonly ElmApiOptions _options = Options;

    public ElmApiOptions Options
    {
        get => _options;
        init
        {
            if (ReferenceEquals(_options, value))
                return;

            ServiceProvider?.Dispose();

            _options = value;

            var services = new ServiceCollection();
            services.AddExternalLogging(LoggerFactory!);
            services.AddElmApi();
            ServiceProvider = services.BuildServiceProvider();
            Logger = ServiceProvider.GetLogger<ElmApi>();
            AssemblyCompiler = ServiceProvider.GetAssemblyCompiler();
            LibrarySetCSharpCodeGenerator = ServiceProvider.GetLibrarySetCSharpCodeGenerator();
        }
    }

    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;

    public ElmApiScopedState CreateScopedState() => new(ServiceProvider.CreateScope());
}