using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;

namespace CqlSdkPrototype.Packaging.Internal;

internal readonly record struct FhirResourcePackagerServices(
    ServiceProvider ServiceProvider,
    ILogger<FhirResourcePackager> Logger,
    CqlTypeToFhirTypeMapper CqlTypeToFhirTypeMapper)
{
    public static FhirResourcePackagerServices Create(ILoggerFactory loggerFactory)
    {
        var services = new ServiceCollection();
        services.AddExternalLogging(loggerFactory);
        services.TryAddSingleton(_ => Hl7.Fhir.Model.ModelInfo.ModelInspector);
        services.TryAddSingleton<TypeResolver, FhirTypeResolver>();
        services.TryAddSingleton<CqlTypeToFhirTypeMapper>();
        var serviceProvider = services.BuildServiceProvider();
        return ActivatorUtilities.CreateInstance<FhirResourcePackagerServices>(serviceProvider, serviceProvider);
    }

}