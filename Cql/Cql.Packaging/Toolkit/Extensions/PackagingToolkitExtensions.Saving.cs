/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.IO;

namespace Hl7.Cql.Packaging.Toolkit.Extensions;

public static partial class PackagingToolkitExtensions
{
    /// <summary>
    /// Saves FHIR resources to the specified directory.
    /// </summary>
    /// <param name="packagingToolkit">The packaging toolkit instance.</param>
    /// <param name="directory">The directory where the FHIR resources will be saved.</param>
    /// <param name="writeIndented">if set to <c>true</c> [write indented].</param>
    /// <param name="directoryPreparationStrategy">Optional strategy for preparing the directory.</param>
    /// <param name="configureJsonSerializerOptions">Optional mutator for JSON serialization options.</param>
    /// <returns>The packaging toolkit instance.</returns>
    public static PackagingToolkit SaveFhirResourcesToDirectory(
        this PackagingToolkit packagingToolkit,
        DirectoryInfo directory,
        bool writeIndented = false,
        DirectoryInfoHandler? directoryPreparationStrategy = null,
        Mutator<JsonSerializerOptions>? configureJsonSerializerOptions = null)
    {
        bool prepFhirDir = true;
        ILogger? logger = null;
        var fhirResources = packagingToolkit
                            .GetPackagingResults()
                            .SelectMany(t => t.resultArtifacts.GetFhirResources());
        foreach (var (resourceFileName, resourceJson) in
                 packagingToolkit.SerializeFhirResourcesToJson(fhirResources, writeIndented, configureJsonSerializerOptions))
        {
            if (prepFhirDir)
            {
                prepFhirDir = false;
                (directoryPreparationStrategy ?? DirectoryPreparationStrategy.Recreate)(directory);
            }

            logger ??= packagingToolkit.LoggerFactory.CreateLogger(typeof(PackagingToolkitExtensions));
            var fullFilePath = Path.Combine(directory.FullName, resourceFileName.ToString());
            logger.LogInformation("Saving FHIR Resource: {file}", fullFilePath);
            File.WriteAllText(fullFilePath, resourceJson);
        }

        return packagingToolkit;
    }

    /// <summary>
    /// Gets the packaging results from the packaging toolkit.
    /// </summary>
    /// <param name="packagingToolkit">The packaging toolkit instance.</param>
    /// <returns>An enumerable of packaging toolkit result records.</returns>
    public static IEnumerable<(CqlVersionedLibraryIdentifier libraryIdentifier, PackagingToolkitResultArtifacts resultArtifacts)> GetPackagingResults(
        this PackagingToolkit packagingToolkit) =>
        packagingToolkit
            .ArtifactsById
            .SelectWhere(kv => kv.Value switch
            {
                { Result: {} resultArtifacts } => (true, (kv.Key, resultArtifacts)),
                _ => default,
            });
}
