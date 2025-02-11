using System.Text.Json;
using CqlSdkPrototype.Infrastructure;
using CqlSdkPrototype.Internal;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Packaging;

namespace CqlSdkPrototype.Packaging.Fluent;

public static partial class FluentPackagingToolkitExtensions
{
    public static FluentPackagingToolkit SaveFhirResources(
        this FluentPackagingToolkit packagingToolkit,
        DirectoryInfo directory,
        DirectoryPreparationStrategy? directoryPreparationStrategy = null)
    {
        (directoryPreparationStrategy ?? DirectoryPreparationStrategy.Recreate).PrepareDirectory(directory);

        var logger = packagingToolkit.LoggerFactory.CreateLogger(typeof(FluentPackagingToolkitExtensions));
        var jsonSerializerOptions = packagingToolkit.ServiceProvider.GetRequiredService<JsonSerializerOptions>();

        foreach (var resource in packagingToolkit
                                              .GetCompletedFhirResources(t => (FhirResource?[])[t.fhirLibrary, t.fhirMeasure])
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
        FhirMeasure? fhirMeasure)> GetCompletedFhirResources(
        this FluentPackagingToolkit packagingToolkit) =>
        packagingToolkit.GetCompletedFhirResources(t => t);

    public static IEnumerable<TR> GetCompletedFhirResources<TR>(
        this FluentPackagingToolkit packagingToolkit,
        Func<(CqlVersionedLibraryIdentifier versionedLibraryIdentifier, FhirLibrary fhirLibrary, FhirMeasure? fhirMeasure), TR> selector) =>
        packagingToolkit
            .FhirResourcePackagings
            .SelectWhere(kv => kv.Value switch
            {
                { FhirLibrary:null } => (false, default!),
                var val              => (true, selector((kv.Key, val.FhirLibrary, val.FhirMeasure)))
            });

}