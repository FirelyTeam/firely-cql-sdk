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
        Mutator<JsonSerializerOptions>? configureJsonSerializerOptions = null) =>
        SaveFhirResourcesToDirectory(packagingToolkit, directory, null, writeIndented, directoryPreparationStrategy, configureJsonSerializerOptions);

    /// <summary>
    /// Saves FHIR resources to the specified directory with options.
    /// </summary>
    /// <param name="packagingToolkit">The packaging toolkit instance.</param>
    /// <param name="directory">The directory where the FHIR resources will be saved.</param>
    /// <param name="options">Options for saving FHIR resources.</param>
    /// <returns>The packaging toolkit instance.</returns>
    public static PackagingToolkit SaveFhirResourcesToDirectory(
        this PackagingToolkit packagingToolkit,
        DirectoryInfo directory,
        SaveFhirResourcesOptions options) =>
        SaveFhirResourcesToDirectory(
            packagingToolkit,
            directory,
            options.ComputeOutputPath,
            options.WriteIndented,
            options.DirectoryPreparationStrategy,
            options.ConfigureJsonSerializerOptions);

    /// <summary>
    /// Saves FHIR resources to the specified directory, optionally preserving subdirectory structure.
    /// </summary>
    /// <param name="packagingToolkit">The packaging toolkit instance.</param>
    /// <param name="directory">The directory where the FHIR resources will be saved.</param>
    /// <param name="computeOutputPath">Optional delegate to compute custom output paths.</param>
    /// <param name="writeIndented">if set to <c>true</c> [write indented].</param>
    /// <param name="directoryPreparationStrategy">Optional strategy for preparing the directory.</param>
    /// <param name="configureJsonSerializerOptions">Optional mutator for JSON serialization options.</param>
    /// <returns>The packaging toolkit instance.</returns>
    public static PackagingToolkit SaveFhirResourcesToDirectory(
        this PackagingToolkit packagingToolkit,
        DirectoryInfo directory,
        ComputeFhirOutputPathDelegate? computeOutputPath,
        bool writeIndented = false,
        DirectoryInfoHandler? directoryPreparationStrategy = null,
        Mutator<JsonSerializerOptions>? configureJsonSerializerOptions = null)
    {
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

                logger ??= packagingToolkit.LoggerFactory.CreateLogger(typeof(PackagingToolkitExtensions));

                var fullFilePath = computeOutputPath?.Invoke(directory, libraryIdentifier, resourceFileName.ToString())
                    ?? Path.Combine(directory.FullName, resourceFileName.ToString());

                logger.LogInformation("Saving FHIR Resource: {file}", fullFilePath);
                File.WriteAllText(fullFilePath, resourceJson);
            }
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
