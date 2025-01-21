using CqlSdkPrototype.Elm.Extensibility;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Logging.Internal;
using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime.Hosting;
using Hl7.Fhir.Introspection;

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
            AddCqlCodeGenerationServices(services);
            ServiceProvider = services.BuildServiceProvider(validateScopes:true);
            Logger = ServiceProvider.GetLogger<ElmApi>();
            AssemblyCompiler = ServiceProvider.GetRequiredService<AssemblyCompiler>();
            LibrarySetCSharpCodeGenerator = ServiceProvider.GetRequiredService<LibrarySetCSharpCodeGenerator>();
        }
    }

    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;

    public ElmApiScopedState CreateScopedState() => new(ServiceProvider.CreateScope());

    private static void AddCqlCodeGenerationServices(IServiceCollection services)
    {
        AddCqlCompilerServices(services);
        services.TryAddSingleton<TypeToCSharpConverter>();
        services.TryAddSingleton<LibrarySetCSharpCodeGenerator>();
        services.TryAddSingleton<AssemblyCompiler>();
    }

    public static IServiceCollection AddCqlCompilerServices(IServiceCollection services)
    {
        services.TryAddSingleton<ModelInspector>(_ => Hl7.Fhir.Model.ModelInfo.ModelInspector);
        services.TryAddSingleton<TypeResolver, FhirTypeResolver>();

        const int cacheSize = 0; // TODO: Must move to configuration
        services.TryAddSingleton<TypeConverter>(sp =>
        {
            var modelInspector = sp.GetRequiredService<ModelInspector>();
            var logger = sp.GetLogger<TypeConverter>();
            var converter = FhirTypeConverter
                            .Create(modelInspector, cacheSize)
                            .UseLogger(logger);
            converter.CaptureAvailableConverters();
            return converter;
        });

        services.TryAddSingleton<CqlOperatorsBinder>();
        services.TryAddSingleton<CqlContextBinder>();
        services.TryAddSingleton<ExpressionBuilderSettings>(_ => ExpressionBuilderSettings.Default); // TODO: Must move to configuration
        services.TryAddScoped<TupleBuilderCache>();
        services.TryAddScoped<LibrarySetExpressionBuilder>();
        services.TryAddScoped<LibraryExpressionBuilder>();
        services.TryAddScoped<ExpressionBuilder>();

        return services;
    }

}