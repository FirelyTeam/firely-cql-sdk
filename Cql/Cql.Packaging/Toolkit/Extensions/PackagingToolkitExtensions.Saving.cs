/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime.IO;
using Hl7.Cql.Toolkit;

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
    /// <param name="subdirectoryPreserver">An optional subdirectory preserver to maintain directory structure from input.</param>
    /// <param name="directoryPostProcessingStrategy">An optional delegate that is invoked on the directory after all resources have been saved.</param>
    /// <returns>The packaging toolkit instance.</returns>
    public static PackagingToolkit SaveFhirResourcesToDirectory(
        this PackagingToolkit packagingToolkit,
        DirectoryInfo directory,
        bool writeIndented = false,
        DirectoryInfoHandler? directoryPreparationStrategy = null,
        Mutator<JsonSerializerOptions>? configureJsonSerializerOptions = null,
        SubdirectoryPreserver? subdirectoryPreserver = null,
        DirectoryInfoHandler? directoryPostProcessingStrategy = null) =>
        packagingToolkit.SaveFhirResourcesToDirectory(
            new SaveFhirResourcesToDirectoriesOptions(
                directory,
                writeIndented,
                directoryPreparationStrategy,
                configureJsonSerializerOptions,
                subdirectoryPreserver,
                directoryPostProcessingStrategy));

    /// <summary>
    /// Saves all FHIR resources from the specified PackagingToolkit to the specified directory or directories.
    /// </summary>
    /// <remarks>Library and Measure resources are saved according to the directory configuration in the options.
    /// Each resource is serialized to a JSON file. The directories are prepared according to the specified strategy
    /// before files are written. Existing files with the same name may be overwritten.</remarks>
    /// <param name="packagingToolkit">The packaging toolkit instance.</param>
    /// <param name="opt">Options that specify the target directories for libraries and measures, JSON formatting, directory preparation strategy, and JSON serialization options.</param>
    /// <returns>The packaging toolkit instance.</returns>
    public static PackagingToolkit SaveFhirResourcesToDirectory(
        this PackagingToolkit packagingToolkit,
        SaveFhirResourcesToDirectoriesOptions opt)
    {
        opt.Save(packagingToolkit);
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

/// <summary>
/// Provides options for saving FHIR Library and Measure resources to specified directories, with configurable JSON
/// serialization and directory preparation behavior.
/// </summary>
/// <param name="LibrariesDirectory">The directory in which to save FHIR Library resources.</param>
/// <param name="MeasuresDirectory">The directory in which to save FHIR Measure resources.</param>
/// <param name="WriteIndented">true to write JSON output with indentation for readability; otherwise, false.</param>
/// <param name="DirectoryPreparationStrategy">An optional delegate that defines how to prepare the target directory before saving resources. If null, a default
/// preparation strategy is used.</param>
/// <param name="ConfigureJsonSerializerOptions">An optional delegate to configure the JsonSerializerOptions used when serializing FHIR resources to JSON.</param>
/// <param name="SubdirectoryPreserver">An optional subdirectory preserver to maintain directory structure from input.</param>
/// <param name="DirectoryPostProcessingStrategy">An optional delegate that is invoked on each top-level directory after all resources have been saved to that directory.</param>
public record SaveFhirResourcesToDirectoriesOptions(
    DirectoryInfo LibrariesDirectory,
    DirectoryInfo MeasuresDirectory,
    bool WriteIndented = false,
    DirectoryInfoHandler? DirectoryPreparationStrategy = null,
    Mutator<JsonSerializerOptions>? ConfigureJsonSerializerOptions = null,
    SubdirectoryPreserver? SubdirectoryPreserver = null,
    DirectoryInfoHandler? DirectoryPostProcessingStrategy = null)
{
    /// <summary>
    /// Initializes a new instance of the SaveFhirResourcesToDirectoriesOptions class with the specified output
    /// directory and optional configuration settings.
    /// </summary>
    /// <param name="directory">The directory in which to save the FHIR resources. This directory will be used for both input and output unless
    /// otherwise specified.</param>
    /// <param name="WriteIndented">true to write JSON output with indentation for readability; otherwise, false.</param>
    /// <param name="DirectoryPreparationStrategy">An optional delegate that defines how to prepare the target directory before saving resources. If null, no
    /// special preparation is performed.</param>
    /// <param name="ConfigureJsonSerializerOptions">An optional delegate to configure the JsonSerializerOptions used when serializing FHIR resources to JSON.</param>
    /// <param name="SubdirectoryPreserver">An optional subdirectory preserver to maintain directory structure from input.</param>
    /// <param name="DirectoryPostProcessingStrategy">An optional delegate that is invoked on the directory after all resources have been saved.</param>
    public SaveFhirResourcesToDirectoriesOptions(
        DirectoryInfo directory,
        bool WriteIndented = false,
        DirectoryInfoHandler? DirectoryPreparationStrategy = null,
        Mutator<JsonSerializerOptions>? ConfigureJsonSerializerOptions = null,
        SubdirectoryPreserver? SubdirectoryPreserver = null,
        DirectoryInfoHandler? DirectoryPostProcessingStrategy = null) : this(directory, directory, WriteIndented, DirectoryPreparationStrategy, ConfigureJsonSerializerOptions, SubdirectoryPreserver, DirectoryPostProcessingStrategy) {}

    internal void Save(PackagingToolkit packagingToolkit)
    {
        var preparedBaseDirectories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        ILogger? logger = null;

        var packagingResults = packagingToolkit.GetPackagingResults();

        foreach (var (libraryIdentifier, resultArtifacts) in packagingResults)
        {
            var fhirResources = resultArtifacts.GetFhirResources();

            foreach (var (resourceFileName, resourceJson) in
                     packagingToolkit.SerializeFhirResourcesToJson(fhirResources, WriteIndented, ConfigureJsonSerializerOptions))
            {
                // Determine the base directory based on resource type
                var (resourceType, _, _) = resourceFileName;
                DirectoryInfo baseDirectory = resourceType switch
                {
                    "Library" => LibrariesDirectory,
                    "Measure" => MeasuresDirectory,
                    _ => throw new InvalidOperationException(
                        $"Unsupported FHIR resource type '{resourceType}'. Only 'Library' and 'Measure' resources are supported.")
                };

                // Prepare base directory if not already prepared (only once per top-level directory)
                if (preparedBaseDirectories.Add(baseDirectory.FullName))
                {
                    (DirectoryPreparationStrategy ?? Runtime.IO.DirectoryPreparationStrategy.Recreate)(baseDirectory);
                }

                // Determine target directory based on subdirectory preservation
                DirectoryInfo targetDirectory = baseDirectory;
                if (SubdirectoryPreserver is not null)
                {
                    var (relativePath, found) = SubdirectoryPreserver.TryGetRelativePath(libraryIdentifier);
                    if (found && !string.IsNullOrEmpty(relativePath))
                    {
                        targetDirectory = new DirectoryInfo(Path.Combine(baseDirectory.FullName, relativePath));
                        // Ensure subdirectory exists
                        if (!targetDirectory.Exists)
                        {
                            targetDirectory.Create();
                        }
                    }
                }

                logger ??= packagingToolkit.LoggerFactory.CreateLogger(typeof(PackagingToolkitExtensions));
                var fullFilePath = Path.Combine(targetDirectory.FullName, resourceFileName.ToString());
                logger.LogInformation("Saving FHIR Resource: {file}", fullFilePath);
                File.WriteAllText(fullFilePath, resourceJson);
            }
        }

        // Post-process each top-level directory after all files have been saved
        if (DirectoryPostProcessingStrategy is not null)
        {
            foreach (var baseDirectoryPath in preparedBaseDirectories)
            {
                var baseDirectory = new DirectoryInfo(baseDirectoryPath);
                DirectoryPostProcessingStrategy(baseDirectory);
            }
        }
    }
}
