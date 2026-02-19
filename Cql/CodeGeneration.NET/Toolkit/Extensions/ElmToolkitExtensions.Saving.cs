/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime.IO;
using Hl7.Cql.Toolkit;

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
    /// <param name="subdirectoryPreserver">Optional subdirectory preserver to maintain directory structure.</param>
    /// <param name="directoryPostProcessingStrategy">An optional delegate that is invoked on the directory after all files have been saved.</param>
    /// <returns>The ElmToolkit instance.</returns>
    public static ElmToolkit SaveCSharpFilesToDirectory(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        DirectoryInfoHandler? directoryPreparationStrategy = null,
        SubdirectoryPreserver? subdirectoryPreserver = null,
        DirectoryInfoHandler? directoryPostProcessingStrategy = null) =>
        SaveCSharpFilesToDirectory(
            elmToolkit,
            new SaveCSharpFilesToDirectoryOptions(
                directory,
                directoryPreparationStrategy,
                subdirectoryPreserver,
                directoryPostProcessingStrategy));

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
    /// <param name="subdirectoryPreserver">Optional subdirectory preserver to maintain directory structure.</param>
    /// <param name="directoryPostProcessingStrategy">An optional delegate that is invoked on the directory after all files have been saved.</param>
    /// <returns>The ElmToolkit instance.</returns>
    public static ElmToolkit SaveAssemblyBinariesToDirectory(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        DirectoryInfoHandler? directoryPreparationStrategy = null,
        SubdirectoryPreserver? subdirectoryPreserver = null,
        DirectoryInfoHandler? directoryPostProcessingStrategy = null) =>
        SaveAssemblyBinariesToDirectory(
            elmToolkit,
            directory,
            directory,
            directoryPreparationStrategy,
            directoryPreparationStrategy,
            subdirectoryPreserver,
            directoryPostProcessingStrategy);

    /// <summary>
    /// Saves the generated assembly binaries and debug symbols to the specified directory.
    /// </summary>
    /// <param name="elmToolkit">The ElmToolkit instance containing the generated assembly binaries and debug symbols.</param>
    /// <param name="dllDirectory">The directory where the assembly binaries will be saved.</param>
    /// <param name="pdbDirectory">The directory where the debug symbol binaries (if provided) will be saved.</param>
    /// <param name="dllDirectoryPreparationStrategy">Optional strategy for preparing the dll directory.</param>
    /// <param name="pdbDirectoryPreparationStrategy">Optional strategy for preparing the pdb directory.</param>
    /// <param name="subdirectoryPreserver">Optional subdirectory preserver to maintain directory structure.</param>
    /// <param name="directoryPostProcessingStrategy">An optional delegate that is invoked on both directories after all files have been saved.</param>
    /// <returns>The ElmToolkit instance.</returns>
    public static ElmToolkit SaveAssemblyBinariesToDirectory(
        this ElmToolkit elmToolkit,
        DirectoryInfo dllDirectory,
        DirectoryInfo? pdbDirectory,
        DirectoryInfoHandler? dllDirectoryPreparationStrategy = null,
        DirectoryInfoHandler? pdbDirectoryPreparationStrategy = null,
        SubdirectoryPreserver? subdirectoryPreserver = null,
        DirectoryInfoHandler? directoryPostProcessingStrategy = null) =>
        SaveAssemblyBinariesToDirectory(
            elmToolkit,
            new SaveAssemblyBinariesToDirectoryOptions(
                dllDirectory,
                pdbDirectory,
                dllDirectoryPreparationStrategy,
                pdbDirectoryPreparationStrategy,
                subdirectoryPreserver,
                directoryPostProcessingStrategy));

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
/// <param name="SubdirectoryPreserver">An optional subdirectory preserver to maintain directory structure from input.</param>
/// <param name="DirectoryPostProcessingStrategy">An optional delegate that is invoked on both directories after all files have been saved.</param>
public record SaveAssemblyBinariesToDirectoryOptions(
    DirectoryInfo DllDirectory,
    DirectoryInfo? PdbDirectory,
    DirectoryInfoHandler? DllDirectoryPreparationStrategy,
    DirectoryInfoHandler? PdbDirectoryPreparationStrategy,
    SubdirectoryPreserver? SubdirectoryPreserver = null,
    DirectoryInfoHandler? DirectoryPostProcessingStrategy = null)
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

        bool dllDirectoryPrepared = false;
        bool pdbDirectoryPrepared = false;
        bool hasAnyDebugSymbols = elmToAssemblyResults.Any(t => t.debugSymbolsBinary is { Length: > 0 });

        foreach (var (libraryIdentifier, _, _, assemblyBytes, debugSymbolsBytes) in elmToAssemblyResults)
        {
            // Prepare top-level DLL directory if not already prepared (only once)
            if (!dllDirectoryPrepared)
            {
                (dllDirectoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(dllDirectory);
                dllDirectoryPrepared = true;
            }

            // Prepare top-level PDB directory if not already prepared (only once)
            if (hasAnyDebugSymbols && pdbDirectory is not null && !pdbDirectoryPrepared)
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
                pdbDirectoryPrepared = true;
            }

            // Determine target directories based on subdirectory preservation
            DirectoryInfo targetDllDirectory = dllDirectory;
            DirectoryInfo? targetPdbDirectory = pdbDirectory;

            if (SubdirectoryPreserver is not null)
            {
                var (relativePath, found) = SubdirectoryPreserver.TryGetRelativePath(libraryIdentifier);
                if (found && !string.IsNullOrEmpty(relativePath))
                {
                    targetDllDirectory = new DirectoryInfo(Path.Combine(dllDirectory.FullName, relativePath));
                    // Ensure subdirectory exists
                    if (!targetDllDirectory.Exists)
                    {
                        targetDllDirectory.Create();
                    }

                    if (pdbDirectory is not null)
                    {
                        targetPdbDirectory = new DirectoryInfo(Path.Combine(pdbDirectory.FullName, relativePath));
                        // Ensure subdirectory exists
                        if (!targetPdbDirectory.Exists)
                        {
                            targetPdbDirectory.Create();
                        }
                    }
                }
            }

            var dllFileName = Path.Combine(targetDllDirectory.FullName, $"{libraryIdentifier}.dll");
            File.WriteAllBytes(dllFileName, assemblyBytes);
            logger.LogInformation("Saved assembly to file: {file}", dllFileName);

            if (debugSymbolsBytes is { Length: > 0 } pdb && targetPdbDirectory is not null)
            {
                var pdbFileName = Path.Combine(targetPdbDirectory.FullName, $"{libraryIdentifier}.pdb");
                File.WriteAllBytes(pdbFileName, pdb);
                logger.LogInformation("Saved debug symbols to file: {file}", pdbFileName);
            }
        }

        // Post-process directories after all files have been saved
        var postProcessingStrategy = DirectoryPostProcessingStrategy ?? (SubdirectoryPreserver is not null ? Runtime.IO.DirectoryPostProcessingStrategy.DeleteEmptySubdirectories : null);
        if (postProcessingStrategy is not null)
        {
            postProcessingStrategy(dllDirectory);
            if (pdbDirectory is not null && pdbDirectory.FullName != dllDirectory.FullName)
            {
                postProcessingStrategy(pdbDirectory);
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
/// <param name="SubdirectoryPreserver">An optional subdirectory preserver to maintain directory structure from input.</param>
/// <param name="DirectoryPostProcessingStrategy">An optional delegate that is invoked on the directory after all files have been saved.</param>
public record SaveCSharpFilesToDirectoryOptions(
    DirectoryInfo Directory,
    DirectoryInfoHandler? DirectoryPreparationStrategy,
    SubdirectoryPreserver? SubdirectoryPreserver = null,
    DirectoryInfoHandler? DirectoryPostProcessingStrategy = null)
{
    internal void Save(ElmToolkit elmToolkit)
    {
        var directory = Directory;
        var directoryPreparationStrategy = DirectoryPreparationStrategy;
        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));
        bool directoryPrepared = false;

        foreach (var (libraryIdentifier, _, csharpSourceCode) in elmToolkit.GetElmToCSharpResults())
        {
            // Prepare top-level directory if not already prepared (only once)
            if (!directoryPrepared)
            {
                (directoryPreparationStrategy ?? Runtime.IO.DirectoryPreparationStrategy.CreateIfNotExists)(directory);
                directoryPrepared = true;
            }

            // Determine target directory based on subdirectory preservation
            DirectoryInfo targetDirectory = directory;
            if (SubdirectoryPreserver is not null)
            {
                var (relativePath, found) = SubdirectoryPreserver.TryGetRelativePath(libraryIdentifier);
                if (found && !string.IsNullOrEmpty(relativePath))
                {
                    targetDirectory = new DirectoryInfo(Path.Combine(directory.FullName, relativePath));
                    // Ensure subdirectory exists
                    if (!targetDirectory.Exists)
                    {
                        targetDirectory.Create();
                    }
                }
            }

            var fileName = Path.Combine(targetDirectory.FullName, $"{libraryIdentifier}.g.cs");
            File.WriteAllText(fileName, csharpSourceCode);
            logger.LogInformation("Saved C# source code to file: {file}", fileName);
        }

        // Post-process the directory after all files have been saved
        var postProcessingStrategy = DirectoryPostProcessingStrategy ?? (SubdirectoryPreserver is not null ? Runtime.IO.DirectoryPostProcessingStrategy.DeleteEmptySubdirectories : null);
        if (postProcessingStrategy is not null)
        {
            postProcessingStrategy(directory);
        }
    }
}
