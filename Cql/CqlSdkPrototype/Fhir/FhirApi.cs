using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Logging.Internal;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Introspection;

namespace CqlSdkPrototype.Fhir;

using ElmLibrary = Hl7.Cql.Elm.Library;
using FhirLibrary = Hl7.Fhir.Model.Library;
using DateTime = System.DateTime;

public class FhirApi(ILoggerFactory? loggerFactory)
{
    private readonly FhirApiServices _services = CreateServices(loggerFactory ?? NullLoggerFactory.Instance);

    private static FhirApiServices CreateServices(ILoggerFactory loggerFactory)
    {
        var services = new ServiceCollection().AddExternalLogging(loggerFactory);
        services.TryAddSingleton<ModelInspector>(_ => Hl7.Fhir.Model.ModelInfo.ModelInspector);
        services.TryAddSingleton<TypeResolver, FhirTypeResolver>();
        services.TryAddSingleton<CqlTypeToFhirTypeMapper>();
        var serviceProvider = services.BuildServiceProvider();
        CqlTypeToFhirTypeMapper cqlTypeToFhirTypeMapper = serviceProvider.GetRequiredService<CqlTypeToFhirTypeMapper>();
        return new FhirApiServices(serviceProvider, cqlTypeToFhirTypeMapper);
    }

    public FhirLibrary CreateLibraryResource(
        ElmLibrary elmLibrary,
        byte[] elmBytes,
        byte[]? cqlBytes,
        string? cSharpSourceCode,
        byte[]? assemblyBinary,
        string? resourceCanonicalRootUrl = null,
        DateTime? elmFileLastWriteTimeUtc = null)
    {
        var libraryResource = LibraryPackager.CreateLibraryResource(
            _services.CqlTypeToFhirTypeMapper,
            elmLibrary,
            elmBytes,
            cqlBytes,
            assemblyBinary,
            cSharpSourceCode is not null
                ? KeyValuePair.Create($"{CqlVersionedLibraryIdentifier.FromVersionedIdentifier(elmLibrary.identifier)}", cSharpSourceCode).EnumerateSingle()
                : [],
            resourceCanonicalRootUrl,
            elmFileLastWriteTimeUtc);
        return libraryResource;
    }
}

internal record FhirApiServices(ServiceProvider ServiceProvider, CqlTypeToFhirTypeMapper CqlTypeToFhirTypeMapper);