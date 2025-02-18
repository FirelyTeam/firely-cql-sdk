using System.Text.Json;
using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Packaging;

namespace CqlSdkPrototype.Packaging.Extensions;

public static partial class PackagingToolkitExtensions
{
    public static PackagingToolkit SaveFhirResources(
        this PackagingToolkit packagingToolkit,
        DirectoryInfo directory,
        DirectoryInfoHandler? directoryPreparationStrategy = null)
    {
        (directoryPreparationStrategy ?? DirectoryPreparationStrategy.Recreate)(directory);

        var logger = packagingToolkit.LoggerFactory.CreateLogger(typeof(PackagingToolkitExtensions));
        var jsonSerializerOptions = packagingToolkit.ServiceProvider.GetRequiredService<JsonSerializerOptions>();

        foreach (var resource in packagingToolkit
                                              .GetCompletedConversions(t => (FhirResource?[])[t.fhirLibrary, t.fhirMeasure])
                                              .SelectMany(t => t)
                                              .WhereNotNull())
        {
            var resourceJson = JsonSerializer.Serialize(resource, jsonSerializerOptions);
            var resourceFileName = resource.GetResourceFileName();
            var fullFilePath = Path.Combine(directory.FullName, resourceFileName.ToString());
            logger.LogInformation("Saving FHIR "+ resource.GetType().Name +" {file}", fullFilePath);
            File.WriteAllText(fullFilePath, resourceJson);
        }

        return packagingToolkit;
    }

    public static IEnumerable<(
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        FhirLibrary fhirLibrary,
        FhirMeasure? fhirMeasure)> GetCompletedConversions(
        this PackagingToolkit packagingToolkit) =>
        packagingToolkit.GetCompletedConversions(t => t);

    public static IEnumerable<TR> GetCompletedConversions<TR>(
        this PackagingToolkit packagingToolkit,
        Func<(CqlVersionedLibraryIdentifier versionedLibraryIdentifier, FhirLibrary fhirLibrary, FhirMeasure? fhirMeasure), TR> selector) =>
        packagingToolkit
            .Conversions
            .SelectWhere(kv => kv.Value switch
            {
                { ResultFhirLibrary:null } => (false, default!),
                var val              => (true, selector((kv.Key, val.ResultFhirLibrary, val.ResultFhirMeasure)))
            });

}