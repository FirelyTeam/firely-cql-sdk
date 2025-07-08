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
        DirectoryInfoHandler? directoryPreparationStrategy = null)
    {
        var prepCsDir = true;
        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));

        foreach (var (libraryIdentifier, _, csharpSourceCode) in elmToolkit.GetElmToCSharpResults())
        {
            if (prepCsDir)
            {
                prepCsDir = false;
                (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(directory);
            }
            var fileName = Path.Combine(directory.FullName, $"{libraryIdentifier}.g.cs");
            File.WriteAllText(fileName, csharpSourceCode);
            logger.LogInformation("Saved C# source code to file: {file}", fileName);
        }

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
        SaveAssemblyBinariesToDirectory(elmToolkit, directory, directory, directoryPreparationStrategy, directoryPreparationStrategy);

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
        DirectoryInfo pdbDirectory,
        DirectoryInfoHandler? dllDirectoryPreparationStrategy = null,
        DirectoryInfoHandler? pdbDirectoryPreparationStrategy = null)
    {
        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));

        var elmToAssemblyResults = elmToolkit.GetElmToAssemblyResults().ToList();
        if (elmToAssemblyResults.Count == 0)
        {
            // No results to save, return the toolkit as is
            return elmToolkit;
        }

        // Prepare the directories
        (dllDirectoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(dllDirectory);

        bool hasAnyDebugSymbols = elmToAssemblyResults.Any(t => t.debugSymbolsBinary is { Length: > 0 });
        if (hasAnyDebugSymbols)
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

            if (debugSymbolsBytes is { Length: > 0 } pdb)
            {
                var pdbFileName = Path.Combine(pdbDirectory.FullName, $"{libraryIdentifier}.pdb");
                File.WriteAllBytes(pdbFileName, pdb);
                logger.LogInformation("Saved debug symbols to file: {file}", pdbFileName);
            }
        }

        return elmToolkit;
    }
}
