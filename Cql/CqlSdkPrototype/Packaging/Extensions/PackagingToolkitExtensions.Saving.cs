/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Json;
using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Packaging;
using Hl7.Cql.Runtime.IO;

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
                                 .GetPackagingResults()
                                 .SelectMany(t => t.GetFhirResources()))
        {
            var resourceJson = JsonSerializer.Serialize(resource, jsonSerializerOptions);
            var resourceFileName = resource.GetResourceFileName();
            var fullFilePath = Path.Combine(directory.FullName, resourceFileName.ToString());
            logger.LogInformation("Saving FHIR " + resource.GetType().Name + " {file}", fullFilePath);
            File.WriteAllText(fullFilePath, resourceJson);
        }

        return packagingToolkit;
    }

    public static IEnumerable<PackagingToolkitResultRecord> GetPackagingResults(
        this PackagingToolkit packagingToolkit) =>
        packagingToolkit
            .Conversions
            .SelectWhere(kv => kv.Value switch
            {
                { ResultFhirLibrary: null } => (false, default(PackagingToolkitResultRecord)),
                var val                     => (true, new(kv.Key, val.ResultFhirLibrary, val.ResultFhirMeasure))
            });
}
