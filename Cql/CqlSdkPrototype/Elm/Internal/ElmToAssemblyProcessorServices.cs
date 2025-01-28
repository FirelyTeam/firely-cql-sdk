using CqlSdkPrototype.Logging.Internal;
using Hl7.Cql.Abstractions;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime.Hosting;
using Hl7.Fhir.Introspection;

namespace CqlSdkPrototype.Elm.Internal;

internal readonly record struct ElmToAssemblyProcessorServices(
    ServiceProvider ServiceProvider,
    ILogger<ElmToAssemblyProcessor> Logger,
    AssemblyCompiler AssemblyCompiler,
    LibrarySetCSharpCodeGenerator LibrarySetCSharpCodeGenerator)
{
    public static ElmToAssemblyProcessorServices Create(
        ILoggerFactory loggerFactory)
    {
        var services = new ServiceCollection();
        services.AddExternalLogging(loggerFactory);
        AddCqlCodeGenerationServices(services);
        var serviceProvider = services.BuildServiceProvider(validateScopes: true);

        return ActivatorUtilities.CreateInstance<ElmToAssemblyProcessorServices>(serviceProvider, serviceProvider);
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
        services.TryAddSingleton(_ => Hl7.Fhir.Model.ModelInfo.ModelInspector);
        services.TryAddSingleton<TypeResolver, FhirTypeResolver>();

        const int cacheSize = 0; // TODO: Must move to configuration
        services.TryAddSingleton(sp =>
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
        services.TryAddSingleton(_ => ExpressionBuilderSettings.Default); // TODO: Must move to configuration
        services.TryAddScoped<TupleBuilderCache>();
        services.TryAddScoped<LibrarySetExpressionBuilder>();
        services.TryAddScoped<LibraryExpressionBuilder>();
        services.TryAddScoped<ExpressionBuilder>();

        return services;
    }

    public ServiceProvider ServiceProvider { get; } = ServiceProvider;
    public AssemblyCompiler AssemblyCompiler { get; } = AssemblyCompiler;
    public LibrarySetCSharpCodeGenerator LibrarySetCSharpCodeGenerator { get; } = LibrarySetCSharpCodeGenerator;
    public ElmApiScopedState CreateScopedState() => new(ServiceProvider.CreateScope());
}