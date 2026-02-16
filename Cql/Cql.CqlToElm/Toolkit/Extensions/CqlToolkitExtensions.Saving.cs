/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime.IO;

namespace Hl7.Cql.CqlToElm.Toolkit.Extensions;

public class SaveElmFilesToDirectoryOptions(DirectoryInfo directory, bool writeIndented, DirectoryInfoHandler? directoryPreparationStrategy)
{
    public DirectoryInfo Directory { get; } = directory;
    public bool WriteIndented { get; } = writeIndented;
    public DirectoryInfoHandler? DirectoryPreparationStrategy { get; } = directoryPreparationStrategy;
}

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
        SaveElmFilesToDirectory(cqlToolkit, new SaveElmFilesToDirectoryOptions(directory, writeIndented, directoryPreparationStrategy));

    /// <summary>
    /// Saves all ELM (Expression Logical Model) libraries contained in the specified CQL toolkit to JSON files in the
    /// target directory.
    /// </summary>
    /// <remarks>Each ELM library is serialized to a JSON file named after its library identifier. The
    /// directory is prepared according to the specified strategy before files are written. Existing files with the same
    /// name may be overwritten.</remarks>
    /// <param name="cqlToolkit">The CQL toolkit containing the ELM libraries to be saved.</param>
    /// <param name="opt">Options that specify the target directory, file formatting, and directory preparation strategy.</param>
    /// <returns>The same CQL toolkit instance provided in the input parameter.</returns>
    public static CqlToolkit SaveElmFilesToDirectory(
        CqlToolkit cqlToolkit,
        SaveElmFilesToDirectoryOptions opt)
    {
        var directory = opt.Directory;
        var writeIndented = opt.WriteIndented;
        var directoryPreparationStrategy = opt.DirectoryPreparationStrategy;
        var prepElmDir = true;
        var logger = cqlToolkit.CreateLogger();

        foreach (var (libraryIdentifier, elmLibrary) in cqlToolkit.GetCqlToolkitResults())
        {
            if (prepElmDir)
            {
                prepElmDir = false;
                (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(directory);
            }
            var fileName = Path.Combine(directory.FullName, $"{libraryIdentifier}.json");
            File.WriteAllText(fileName, elmLibrary.SerializeToJson(writeIndented));
            logger.LogInformation("Saved ELM to file: {file}", fileName);
        }

        return cqlToolkit;
    }
}
