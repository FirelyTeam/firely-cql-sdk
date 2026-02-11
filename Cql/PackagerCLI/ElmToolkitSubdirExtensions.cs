/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.Runtime.IO;

namespace Hl7.Cql.Packager;

/// <summary>
/// Extension methods for ElmToolkit that support preserving subdirectory structure.
/// </summary>
internal static class ElmToolkitSubdirExtensions
{
    /// <summary>
    /// Saves the generated C# source files to the specified directory, optionally preserving subdirectory structure.
    /// </summary>
    public static ElmToolkit SaveCSharpFilesToDirectoryWithSubdirs(
        this ElmToolkit elmToolkit,
        DirectoryInfo directory,
        SubdirectoryPathMapper? pathMapper,
        DirectoryInfoHandler? directoryPreparationStrategy = null)
    {
        if (pathMapper is null)
        {
            // Use default behavior
            return elmToolkit.SaveCSharpFilesToDirectory(directory, directoryPreparationStrategy);
        }

        var prepCsDir = true;
        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitSubdirExtensions));

        foreach (var (libraryIdentifier, _, csharpSourceCode) in elmToolkit.GetElmToCSharpResults())
        {
            if (prepCsDir)
            {
                prepCsDir = false;
                (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(directory);
            }

            var fileName = $"{libraryIdentifier}.g.cs";
            var fullPath = pathMapper.GetOutputPath(directory, libraryIdentifier, fileName);

            File.WriteAllText(fullPath, csharpSourceCode);
            logger.LogInformation("Saved C# source code to file: {file}", fullPath);
        }

        return elmToolkit;
    }

    /// <summary>
    /// Saves the generated assembly binaries and debug symbols to the specified directory, optionally preserving subdirectory structure.
    /// </summary>
    public static ElmToolkit SaveAssemblyBinariesToDirectoryWithSubdirs(
        this ElmToolkit elmToolkit,
        DirectoryInfo dllDirectory,
        DirectoryInfo pdbDirectory,
        SubdirectoryPathMapper? pathMapper,
        DirectoryInfoHandler? dllDirectoryPreparationStrategy = null,
        DirectoryInfoHandler? pdbDirectoryPreparationStrategy = null)
    {
        if (pathMapper is null)
        {
            // Use default behavior
            return elmToolkit.SaveAssemblyBinariesToDirectory(
                dllDirectory,
                pdbDirectory,
                dllDirectoryPreparationStrategy,
                pdbDirectoryPreparationStrategy);
        }

        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitSubdirExtensions));

        var elmToAssemblyResults = elmToolkit.GetElmToAssemblyResults().ToList();
        if (elmToAssemblyResults.Count == 0)
        {
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
            var dllFileName = $"{libraryIdentifier}.dll";
            var dllFullPath = pathMapper.GetOutputPath(dllDirectory, libraryIdentifier, dllFileName);
            File.WriteAllBytes(dllFullPath, assemblyBytes);
            logger.LogInformation("Saved assembly to file: {file}", dllFullPath);

            if (debugSymbolsBytes is { Length: > 0 } pdb)
            {
                var pdbFileName = $"{libraryIdentifier}.pdb";
                var pdbFullPath = pathMapper.GetOutputPath(pdbDirectory, libraryIdentifier, pdbFileName);
                File.WriteAllBytes(pdbFullPath, pdb);
                logger.LogInformation("Saved debug symbols to file: {file}", pdbFullPath);
            }
        }

        return elmToolkit;
    }
}
