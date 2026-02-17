/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime.IO;

namespace Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for saving C# files and assembly binaries to a directory.
/// </summary>
public static partial class ElmToolkitExtensions
{
    /// <summary>
    /// Saves the generated C# source files to the specified directory.
    /// </summary>
    /// <param name="elmToolkit">The ElmToolkit instance containing the generated C# source files.</param>
    /// <param name="directory">The directory where the C# source files will be saved.</param>
    /// <param name="directoryPreparationStrategy">Optional strategy for preparing the directory.</param>
    /// <returns>The ElmToolkit instance.</returns>
    public static ElmToolkit SaveCSharpFilesToDirectory(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        DirectoryInfoHandler? directoryPreparationStrategy = null) =>
        SaveCSharpFilesToDirectory(
            elmToolkit,
            new SaveCSharpFilesToDirectoryOptions(
                directory,
                directoryPreparationStrategy));

    /// <summary>
    /// Saves all generated C# source files contained in the specified ElmToolkit to the target directory.
    /// </summary>
    /// <remarks>Each C# source file is saved with a ".g.cs" extension named after its library identifier. The
    /// directory is prepared according to the specified strategy before the first file is written. Existing files with
    /// the same name may be overwritten.</remarks>
    /// <param name="elmToolkit">The ElmToolkit instance containing the generated C# source files.</param>
    /// <param name="opt">EnumerationOptions that specify the target directory and directory preparation strategy.</param>
    /// <returns>The ElmToolkit instance.</returns>
    public static ElmToolkit SaveCSharpFilesToDirectory(
        ElmToolkit elmToolkit,
        SaveCSharpFilesToDirectoryOptions opt)
    {
        opt.Save(elmToolkit);
        return elmToolkit;
    }

    /// <summary>
    /// Saves the generated assembly binaries and debug symbols to the specified directory.
    /// </summary>
    /// <param name="elmToolkit">The ElmToolkit instance containing the generated assembly binaries and debug symbols.</param>
    /// <param name="directory">The directory where the assembly binaries and debug symbols (if provided) will be saved.</param>
    /// <param name="directoryPreparationStrategy">Optional strategy for preparing the directory.</param>
    /// <returns>The ElmToolkit instance.</returns>
    public static ElmToolkit SaveAssemblyBinariesToDirectory(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        DirectoryInfoHandler? directoryPreparationStrategy = null) =>
        SaveAssemblyBinariesToDirectory(
            elmToolkit,
            directory,
            directory,
            directoryPreparationStrategy,
            directoryPreparationStrategy);

    /// <summary>
    /// Saves the generated assembly binaries and debug symbols to the specified directory.
    /// </summary>
    /// <param name="elmToolkit">The ElmToolkit instance containing the generated assembly binaries and debug symbols.</param>
    /// <param name="dllDirectory">The directory where the assembly binaries will be saved.</param>
    /// <param name="pdbDirectory">The directory where the debug symbol binaries (if provided) will be saved.</param>
    /// <param name="dllDirectoryPreparationStrategy">Optional strategy for preparing the dll directory.</param>
    /// <param name="pdbDirectoryPreparationStrategy">Optional strategy for preparing the pdb directory.</param>
    /// <returns>The ElmToolkit instance.</returns>
    public static ElmToolkit SaveAssemblyBinariesToDirectory(
        this ElmToolkit elmToolkit,
        DirectoryInfo dllDirectory,
        DirectoryInfo? pdbDirectory,
        DirectoryInfoHandler? dllDirectoryPreparationStrategy = null,
        DirectoryInfoHandler? pdbDirectoryPreparationStrategy = null) =>
        SaveAssemblyBinariesToDirectory(
            elmToolkit,
            new SaveAssemblyBinariesToDirectoryOptions(
                dllDirectory,
                pdbDirectory,
                dllDirectoryPreparationStrategy,
                pdbDirectoryPreparationStrategy));

    /// <summary>
    /// Saves all generated assembly binaries and debug symbols contained in the specified ElmToolkit to the target directories.
    /// </summary>
    /// <remarks>Each assembly binary is saved with a ".dll" extension and each debug symbol file is saved with a ".pdb"
    /// extension, both named after their library identifier. The directories are prepared according to the specified strategies
    /// before files are written. Existing files with the same name may be overwritten.</remarks>
    /// <param name="elmToolkit">The ElmToolkit instance containing the generated assembly binaries and debug symbols.</param>
    /// <param name="opt">EnumerationOptions that specify the target directories for DLL and PDB files, and their directory preparation strategies.</param>
    /// <returns>The ElmToolkit instance.</returns>
    public static ElmToolkit SaveAssemblyBinariesToDirectory(
        ElmToolkit elmToolkit,
        SaveAssemblyBinariesToDirectoryOptions opt)
    {
        opt.Save(elmToolkit);
        return elmToolkit;
    }
}

/// <summary>
/// Represents configuration options for saving compiled assembly and debug symbol binaries to specified directories.
/// </summary>
/// <remarks>Use this record to control the output locations and preparation strategies for saving binaries
/// generated from ELM to assemblies. Custom directory preparation strategies can be provided to handle directory
/// creation or cleanup as needed.</remarks>
/// <param name="DllDirectory">The directory where assembly (.dll) files will be saved.</param>
/// <param name="PdbDirectory">The directory where debug symbol (.pdb) files will be saved if its provided.</param>
/// <param name="DllDirectoryPreparationStrategy">An optional strategy for preparing the assembly directory before saving files. If null, the default strategy is
/// used.</param>
/// <param name="PdbDirectoryPreparationStrategy">An optional strategy for preparing the debug symbol directory before saving files. If null, the default strategy is
/// used.</param>
public record SaveAssemblyBinariesToDirectoryOptions(
    DirectoryInfo DllDirectory,
    DirectoryInfo? PdbDirectory,
    DirectoryInfoHandler? DllDirectoryPreparationStrategy,
    DirectoryInfoHandler? PdbDirectoryPreparationStrategy)
{
    internal void Save(ElmToolkit elmToolkit)
    {
        var dllDirectory = DllDirectory;
        var pdbDirectory = PdbDirectory;
        var dllDirectoryPreparationStrategy = DllDirectoryPreparationStrategy;
        var pdbDirectoryPreparationStrategy = PdbDirectoryPreparationStrategy;
        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));

        var elmToAssemblyResults = elmToolkit.GetElmToAssemblyResults().ToList();
        if (elmToAssemblyResults.Count == 0)
        {
            // No results to save, return the toolkit as is
            return;
        }

        // Prepare the directories
        (dllDirectoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(dllDirectory);

        bool hasAnyDebugSymbols = elmToAssemblyResults.Any(t => t.debugSymbolsBinary is { Length: > 0 });
        if (hasAnyDebugSymbols && pdbDirectory is not null)
        {
            if (dllDirectory.FullName == pdbDirectory.FullName
                && pdbDirectoryPreparationStrategy != DirectoryPreparationStrategy.Recreate)
            {
                // We do not want to recreate the pdb directory if it is the same as the dll directory
            }
            else
            {
                (pdbDirectoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(pdbDirectory);
            }
        }


        foreach (var (libraryIdentifier, _, _, assemblyBytes, debugSymbolsBytes) in elmToAssemblyResults)
        {
            var dllFileName = Path.Combine(dllDirectory.FullName, $"{libraryIdentifier}.dll");
            File.WriteAllBytes(dllFileName, assemblyBytes);
            logger.LogInformation("Saved assembly to file: {file}", dllFileName);

            if (debugSymbolsBytes is { Length: > 0 } pdb && pdbDirectory is not null)
            {
                var pdbFileName = Path.Combine(pdbDirectory.FullName, $"{libraryIdentifier}.pdb");
                File.WriteAllBytes(pdbFileName, pdb);
                logger.LogInformation("Saved debug symbols to file: {file}", pdbFileName);
            }
        }
    }
}

/// <summary>
/// Represents options for saving generated C# source files to a specified directory, including directory preparation
/// strategy.
/// </summary>
/// <remarks>Use this record to configure how and where C# files generated from ELM are written. The directory
/// preparation strategy allows customization of directory handling, such as cleaning or creating the directory prior to
/// file output.</remarks>
/// <param name="Directory">The target directory where C# source files will be saved.</param>
/// <param name="DirectoryPreparationStrategy">An optional strategy for preparing the target directory before saving files. If null, the default strategy creates
/// the directory if it does not exist.</param>
public record SaveCSharpFilesToDirectoryOptions(
    DirectoryInfo Directory,
    DirectoryInfoHandler? DirectoryPreparationStrategy)
{
    internal void Save(ElmToolkit elmToolkit)
    {
        var directory = Directory;
        var directoryPreparationStrategy = DirectoryPreparationStrategy;
        var prepCsDir = true;
        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));

        foreach (var (libraryIdentifier, _, csharpSourceCode) in elmToolkit.GetElmToCSharpResults())
        {
            if (prepCsDir)
            {
                prepCsDir = false;
                (directoryPreparationStrategy ?? Runtime.IO.DirectoryPreparationStrategy.CreateIfNotExists)(directory);
            }
            var fileName = Path.Combine(directory.FullName, $"{libraryIdentifier}.g.cs");
            File.WriteAllText(fileName, csharpSourceCode);
            logger.LogInformation("Saved C# source code to file: {file}", fileName);
        }
    }
}
