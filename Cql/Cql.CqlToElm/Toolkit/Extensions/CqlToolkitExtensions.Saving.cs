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
        SaveElmFilesToDirectory(
            cqlToolkit,
            new SaveElmFilesToDirectoryOptions(
                directory,
                writeIndented,
                directoryPreparationStrategy));

    /// <summary>
    /// Saves all ELM (Expression Logical Model) libraries contained in the specified CQL toolkit to JSON files in the
    /// target directory.
    /// </summary>
    /// <remarks>Each ELM library is serialized to a JSON file named after its library identifier. The
    /// directory is prepared according to the specified strategy before files are written. Existing files with the same
    /// name may be overwritten.</remarks>
    /// <param name="cqlToolkit">The CQL toolkit containing the ELM libraries to be saved.</param>
    /// <param name="opt">EnumerationOptions that specify the target directory, file formatting, and directory preparation strategy.</param>
    /// <returns>The same CQL toolkit instance provided in the input parameter.</returns>
    public static CqlToolkit SaveElmFilesToDirectory(
        CqlToolkit cqlToolkit,
        SaveElmFilesToDirectoryOptions opt)
    {
        opt.Save(cqlToolkit);
        return cqlToolkit;
    }
}

/// <summary>
/// Represents options for saving ELM (Expression Logical Model) files to a specified directory.
/// </summary>
/// <remarks>Use this record to configure how ELM files are output by specifying the destination directory,
/// formatting preferences, and any custom directory preparation logic. The directory preparation strategy allows for
/// custom behaviors such as cleaning, validating, or creating the directory before files are written.</remarks>
/// <param name="Directory">The target directory where ELM files will be saved. Must not be null.</param>
/// <param name="WriteIndented">true to write the ELM JSON files with indented formatting; otherwise, false for compact formatting.</param>
/// <param name="DirectoryPreparationStrategy">An optional delegate that defines how the target directory should be prepared before saving files. If null, the
/// default strategy creates the directory if it does not exist.</param>
public record SaveElmFilesToDirectoryOptions(
    DirectoryInfo Directory,
    bool WriteIndented,
    DirectoryInfoHandler? DirectoryPreparationStrategy)
{
    internal void Save(CqlToolkit cqlToolkit)
    {
        var directory = Directory;
        var writeIndented = WriteIndented;
        var directoryPreparationStrategy = DirectoryPreparationStrategy;
        var prepElmDir = true;
        var logger = cqlToolkit.CreateLogger();

        foreach (var (libraryIdentifier, elmLibrary) in cqlToolkit.GetCqlToolkitResults())
        {
            if (prepElmDir)
            {
                prepElmDir = false;
                (directoryPreparationStrategy ?? Runtime.IO.DirectoryPreparationStrategy.CreateIfNotExists)(directory);
            }
            var fileName = Path.Combine(directory.FullName, $"{libraryIdentifier}.json");
            File.WriteAllText(fileName, elmLibrary.SerializeToJson(writeIndented));
            logger.LogInformation("Saved ELM to file: {file}", fileName);
        }
    }
}