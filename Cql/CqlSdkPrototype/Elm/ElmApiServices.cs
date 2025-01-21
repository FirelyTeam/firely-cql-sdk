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

internal readonly record struct ElmApiServices(
    ILoggerFactory LoggerFactory,
    ServiceProvider ServiceProvider,
    AssemblyCompiler AssemblyCompiler,
    LibrarySetCSharpCodeGenerator LibrarySetCSharpCodeGenerator)
{
    public static ElmApiServices Create(ILoggerFactory? loggerFactory)
    {
        loggerFactory ??= NullLoggerFactory.Instance;
        var services = new ServiceCollection();
        services.AddExternalLogging(loggerFactory);
        AddCqlCodeGenerationServices(services);
        var serviceProvider = services.BuildServiceProvider(validateScopes: true);
        var assemblyCompiler = serviceProvider.GetRequiredService<AssemblyCompiler>();
        var librarySetCSharpCodeGenerator = serviceProvider.GetRequiredService<LibrarySetCSharpCodeGenerator>();

        var entries = ElmApiStateEntryDictionary.Empty.WithComparers(CqlVersionedLibraryIdentifier.IdentifierOnlyEqualityComparer);
        return new ElmApiServices(
            loggerFactory,
            serviceProvider,
            assemblyCompiler,
            librarySetCSharpCodeGenerator);
    }

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


    public ILoggerFactory LoggerFactory { get; } = LoggerFactory;
    public ServiceProvider ServiceProvider { get; } = ServiceProvider;
    public ILogger<ElmApi> Logger { get; } = ServiceProvider.GetLogger<ElmApi>();
    public AssemblyCompiler AssemblyCompiler { get; } = AssemblyCompiler;
    public LibrarySetCSharpCodeGenerator LibrarySetCSharpCodeGenerator { get; } = LibrarySetCSharpCodeGenerator;

    public ElmApiScopedServices CreateScopedState() => new(ServiceProvider.CreateScope());
}