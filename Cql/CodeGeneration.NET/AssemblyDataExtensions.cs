/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Extension methods for <see cref="AssemblyData"/>.
/// </summary>
public static class AssemblyDataExtensions
{
    /// <summary>
    /// Writes the assembly data to disk.
    /// </summary>
    /// <param name="self">The assembly data to write.</param>
    /// <param name="assemblyFile">The path to write the assembly to.</param>
    /// <param name="debugSymbolsFile">The path to write the debug symbols to.</param>
    public static TAssemblyData SaveToFiles<TAssemblyData>(
        this TAssemblyData self,
        FileInfo? assemblyFile = null,
        FileInfo? debugSymbolsFile = null)
        where TAssemblyData : AssemblyData
    {
        if (assemblyFile is { } asmFile && self.AssemblyBytes is { Length: > 0 } asmBytes)
        {
            assemblyFile.Directory?.Create();
            File.WriteAllBytes(asmFile.FullName, asmBytes);
        }

        if (debugSymbolsFile is { } pdbFile && self.AssemblyBytes is { Length: > 0 } pdbBytes)
        {
            debugSymbolsFile.Directory?.Create();
            File.WriteAllBytes(pdbFile.FullName, pdbBytes);
        }

        return self;
    }

    /// <summary>
    /// Loads assembly data from files and returns a new instance.
    /// </summary>
    /// <typeparam name="TAssemblyData"></typeparam>
    /// <param name="self">The assembly data to start from</param>
    /// <param name="assemblyFile">The path to read the assembly from.</param>
    /// <param name="debugSymbolsFile">The path to read the debug symbols from.</param>
    /// <returns></returns>
    public static TAssemblyData LoadFromFiles<TAssemblyData>(
        this TAssemblyData self,
        FileInfo? assemblyFile = null,
        FileInfo? debugSymbolsFile = null)
        where TAssemblyData : AssemblyData
    {
        var assemblyBytes = assemblyFile is {} f1 ? File.ReadAllBytes(f1.FullName) : self.AssemblyBytes;
        var debugSymbolsBytes = debugSymbolsFile is {} f2 ? File.ReadAllBytes(f2.FullName) : self.DebugSymbolsBytes;
        return self with { AssemblyBytes = assemblyBytes, DebugSymbolsBytes = debugSymbolsBytes };
    }
}