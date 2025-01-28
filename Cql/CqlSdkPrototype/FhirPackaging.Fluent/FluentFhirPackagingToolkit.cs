using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Introspection;

namespace CqlSdkPrototype.FhirPackaging.Fluent;

using ElmLibrary = Hl7.Cql.Elm.Library;
using FhirLibrary = Hl7.Fhir.Model.Library;
using DateTime = System.DateTime;

public class FluentFhirPackagingToolkit(
    ILoggerFactory? loggerFactory)
{
    private readonly FhirPackagerServices _services = FhirPackagerServices.Create(loggerFactory ?? NullLoggerFactory.Instance);

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

public class FhirPackager(
    ILoggerFactory? loggerFactory = null)
{
    public ILoggerFactory? LoggerFactory { get; } = loggerFactory;
}

internal record FhirPackagerServices(
    ServiceProvider ServiceProvider,
    CqlTypeToFhirTypeMapper CqlTypeToFhirTypeMapper)
{
    public static FhirPackagerServices Create(ILoggerFactory loggerFactory)
    {
        var services = new ServiceCollection().AddExternalLogging(loggerFactory);
        services.TryAddSingleton<ModelInspector>(_ => Hl7.Fhir.Model.ModelInfo.ModelInspector);
        services.TryAddSingleton<TypeResolver, FhirTypeResolver>();
        services.TryAddSingleton<CqlTypeToFhirTypeMapper>();
        var serviceProvider = services.BuildServiceProvider();
        return ActivatorUtilities.CreateInstance<FhirPackagerServices>(serviceProvider, serviceProvider);
    }

}