/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime.IO;

namespace Hl7.Cql.CqlToElm.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="CqlToolkit"/> class.
/// </summary>
public static partial class CqlToolkitExtensions
{
    /// <summary>
    /// Saves the ELM files to the specified directory.
    /// </summary>
    /// <param name="cqlToolkit">The CQL toolkit instance.</param>
    /// <param name="directory">The directory to save the ELM files to.</param>
    /// <param name="writeIndented">if set to <c>true</c> [write indented].</param>
    /// <param name="directoryPreparationStrategy">The directory preparation strategy.</param>
    /// <returns>The <see cref="CqlToolkit"/> instance.</returns>
    public static CqlToolkit SaveElmFilesToDirectory(
        this CqlToolkit cqlToolkit,
        DirectoryInfo directory,
        bool writeIndented = false,
        DirectoryInfoHandler? directoryPreparationStrategy = null) =>
        SaveElmFilesToDirectory(cqlToolkit, directory, null, writeIndented, directoryPreparationStrategy);

    /// <summary>
    /// Saves the ELM files to the specified directory with options.
    /// </summary>
    /// <param name="cqlToolkit">The CQL toolkit instance.</param>
    /// <param name="directory">The directory to save the ELM files to.</param>
    /// <param name="options">Options for saving ELM files.</param>
    /// <returns>The <see cref="CqlToolkit"/> instance.</returns>
    public static CqlToolkit SaveElmFilesToDirectory(
        this CqlToolkit cqlToolkit,
        DirectoryInfo directory,
        SaveElmFilesOptions options) =>
        SaveElmFilesToDirectory(
            cqlToolkit,
            directory,
            options.ComputeOutputPath,
            options.WriteIndented,
            options.DirectoryPreparationStrategy);

    /// <summary>
    /// Saves the ELM files to the specified directory, optionally preserving subdirectory structure.
    /// </summary>
    /// <param name="cqlToolkit">The CQL toolkit instance.</param>
    /// <param name="directory">The directory to save the ELM files to.</param>
    /// <param name="computeOutputPath">Optional delegate to compute custom output paths.</param>
    /// <param name="writeIndented">if set to <c>true</c> [write indented].</param>
    /// <param name="directoryPreparationStrategy">The directory preparation strategy.</param>
    /// <returns>The <see cref="CqlToolkit"/> instance.</returns>
    public static CqlToolkit SaveElmFilesToDirectory(
        this CqlToolkit cqlToolkit,
        DirectoryInfo directory,
        ComputeOutputPathDelegate? computeOutputPath,
        bool writeIndented = false,
        DirectoryInfoHandler? directoryPreparationStrategy = null)
    {
        var prepElmDir = true;
        var logger = cqlToolkit.CreateLogger();

        foreach (var (libraryIdentifier, elmLibrary) in cqlToolkit.GetCqlToolkitResults())
        {
            if (prepElmDir)
            {
                prepElmDir = false;
                (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(directory);
            }

            var fileName = $"{libraryIdentifier}.json";
            var fullPath = computeOutputPath?.Invoke(directory, libraryIdentifier, fileName)
                ?? Path.Combine(directory.FullName, fileName);

            File.WriteAllText(fullPath, elmLibrary.SerializeToJson(writeIndented));
            logger.LogInformation("Saved ELM to file: {file}", fullPath);
        }

        return cqlToolkit;
    }
}
