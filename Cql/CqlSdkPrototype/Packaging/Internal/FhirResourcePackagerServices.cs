using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using System.Text.Json;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Introspection;

namespace CqlSdkPrototype.Packaging.Internal;

internal readonly record struct FhirResourcePackagerServices(
    ServiceProvider ServiceProvider,
    ILogger<FhirResourcePackager> Logger,
    ResourcePackager ResourcePackager,
    JsonSerializerOptions JsonSerializerOptions)
{
    public static FhirResourcePackagerServices Create(ILoggerFactory loggerFactory)
    {
        var services = new ServiceCollection();
        services.AddExternalLogging(loggerFactory);
        services.TryAddSingleton(_ => FhirModelInfo.ModelInspector);
        services.TryAddSingleton<TypeResolver, FhirTypeResolver>();
        services.TryAddSingleton<CqlTypeToFhirTypeMapper>();
        services.TryAddSingleton<ResourcePackager>();
        services.TryAddSingleton((IServiceProvider _, ModelInspector modelInspector) => new JsonSerializerOptions().ForFhir(modelInspector));
        var serviceProvider = services.BuildServiceProvider();
        return ActivatorUtilities.CreateInstance<FhirResourcePackagerServices>(serviceProvider, serviceProvider);

    }

//    private static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector).Pretty();

}

file static class Extensions
{
    public static void TryAddSingleton<TService, TDep1>(
        this IServiceCollection services,
        Func<IServiceProvider, TDep1, TService> implementationFactory)
        where TService : class
        where TDep1 : notnull
    {
        services.TryAddSingleton(sp => implementationFactory(sp, sp.GetRequiredService<TDep1>()));
    }
}