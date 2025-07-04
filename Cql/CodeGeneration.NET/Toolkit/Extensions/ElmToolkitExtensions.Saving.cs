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
        (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(directory);

        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));

        foreach (var (libraryIdentifier, csharpSourceCode) in elmToolkit.GetElmToCSharpResults())
        {
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
        SaveAssemblyBinariesToDirectory(elmToolkit, directory, directory, directoryPreparationStrategy);

    /// <summary>
    /// Saves the generated assembly binaries and debug symbols to the specified directory.
    /// </summary>
    /// <param name="elmToolkit">The ElmToolkit instance containing the generated assembly binaries and debug symbols.</param>
    /// <param name="dllDirectory">The directory where the assembly binaries will be saved.</param>
    /// <param name="pdbDirectory">The directory where the debug symbol binaries (if provided) will be saved.</param>
    /// <param name="directoryPreparationStrategy">Optional strategy for preparing the directory.</param>
    /// <returns>The ElmToolkit instance.</returns>
    public static ElmToolkit SaveAssemblyBinariesToDirectory(
        this ElmToolkit elmToolkit,
        DirectoryInfo dllDirectory,
        DirectoryInfo pdbDirectory,
        DirectoryInfoHandler? directoryPreparationStrategy = null)
    {
        var logger = elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));
        var (prepDllDir, prepPdbDir) = (true, dllDirectory.FullName != pdbDirectory.FullName);

        foreach (var (libraryIdentifier, _, assemblyBytes, debugSymbolsBytes) in elmToolkit.GetElmToAssemblyResults())
        {
            if (prepDllDir)
            {
                prepDllDir = false;
                (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(dllDirectory);
            }
            var fileName = Path.Combine(dllDirectory.FullName, $"{libraryIdentifier}.dll");
            File.WriteAllBytes(fileName, assemblyBytes);
            logger.LogInformation("Saved assembly to file: {file}", fileName);

            if (debugSymbolsBytes is { Length: > 0 } pdb)
            {
                if (prepPdbDir)
                {
                    prepPdbDir = false;
                    (directoryPreparationStrategy ?? DirectoryPreparationStrategy.CreateIfNotExists)(pdbDirectory);
                }
                fileName = Path.Combine(pdbDirectory.FullName, $"{libraryIdentifier}.pdb");
                File.WriteAllBytes(fileName, pdb);
                logger.LogInformation("Saved debug symbols to file: {file}", fileName);
            }
        }

        return elmToolkit;
    }
}
