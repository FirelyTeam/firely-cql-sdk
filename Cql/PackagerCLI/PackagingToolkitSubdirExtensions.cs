/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Packaging.Toolkit;
using Hl7.Cql.Packaging.Toolkit.Extensions;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.IO;

namespace Hl7.Cql.Packager;

/// <summary>
/// Extension methods for PackagingToolkit that support preserving subdirectory structure.
/// </summary>
internal static class PackagingToolkitSubdirExtensions
{
    /// <summary>
    /// Saves FHIR resources to the specified directory, optionally preserving subdirectory structure.
    /// </summary>
    public static PackagingToolkit SaveFhirResourcesToDirectoryWithSubdirs(
        this PackagingToolkit packagingToolkit,
        DirectoryInfo directory,
        SubdirectoryPathMapper? pathMapper,
        bool writeIndented = false,
        DirectoryInfoHandler? directoryPreparationStrategy = null,
        Mutator<JsonSerializerOptions>? configureJsonSerializerOptions = null)
    {
        if (pathMapper is null)
        {
            // Use default behavior
            return packagingToolkit.SaveFhirResourcesToDirectory(
                directory,
                writeIndented,
                directoryPreparationStrategy,
                configureJsonSerializerOptions);
        }

        bool prepFhirDir = true;
        ILogger? logger = null;

        // Get packaging results with library identifiers
        var packagingResults = packagingToolkit.GetPackagingResults().ToList();

        foreach (var (libraryIdentifier, resultArtifacts) in packagingResults)
        {
            var fhirResources = resultArtifacts.GetFhirResources();

            foreach (var (resourceFileName, resourceJson) in
                     packagingToolkit.SerializeFhirResourcesToJson(fhirResources, writeIndented, configureJsonSerializerOptions))
            {
                if (prepFhirDir)
                {
                    prepFhirDir = false;
                    (directoryPreparationStrategy ?? DirectoryPreparationStrategy.Recreate)(directory);
                }

                logger ??= packagingToolkit.LoggerFactory.CreateLogger(typeof(PackagingToolkitSubdirExtensions));

                var fullFilePath = pathMapper.GetOutputPath(directory, libraryIdentifier, resourceFileName.ToString());
                logger.LogInformation("Saving FHIR Resource: {file}", fullFilePath);
                File.WriteAllText(fullFilePath, resourceJson);
            }
        }

        return packagingToolkit;
    }
}
