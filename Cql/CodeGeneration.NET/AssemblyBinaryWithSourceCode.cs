/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Stores information about a dynamically generated assembly.
/// </summary>
/// <param name="AssemblyBytes">This assembly's binary data.</param>
/// <param name="SourceCode">The collection of source code files that contributed to this assembly.</param>
/// <param name="DebugSymbolsBytes">The assembly's debug symbols in binary data.</param>
internal record AssemblyBinaryWithSourceCode(
    byte[]? AssemblyBytes,
    IReadOnlyDictionary<string, string>? SourceCode,
    byte[]? DebugSymbolsBytes = null) : AssemblyBinary(AssemblyBytes, DebugSymbolsBytes)
{
    /// <summary>
    /// An empty instance of <see cref="AssemblyBinaryWithSourceCode"/>.
    /// </summary>
    public new static AssemblyBinaryWithSourceCode Default { get; } = new(null, null, null);

    /// <summary>
    /// Initializes a new instance of the <see cref="AssemblyBinaryWithSourceCode"/> class.
    /// </summary>
    /// <param name="assemblyBytes">This assembly's binary data.</param>
    /// <param name="sourceCodeFileName"></param>
    /// <param name="sourceCode"></param>
    /// <param name="debugSymbolsBytes">The assembly's debug symbols in binary data.</param>
    public AssemblyBinaryWithSourceCode(
        byte[]? assemblyBytes,
        string? sourceCodeFileName,
        string? sourceCode,
        byte[]? debugSymbolsBytes = null) : this(assemblyBytes, ToSingleDictionary(sourceCodeFileName, sourceCode), debugSymbolsBytes)
    {
    }

    private static IReadOnlyDictionary<string, string>? ToSingleDictionary(string? sourceCodeFileName, string? sourceCode)
    {
        return(sourceCodeFileName, sourceCode) is ({}, {})
            ? new Dictionary<string, string> { { sourceCodeFileName, sourceCode } }.AsReadOnly()
            : null;
    }

    public void Deconstruct(out byte[]? assemblyBytes, out IReadOnlyDictionary<string, string>? sourceCode)
    {
        assemblyBytes = AssemblyBytes;
        sourceCode = SourceCode;
    }

    public void Deconstruct(out byte[]? assemblyBytes, out IReadOnlyDictionary<string, string>? sourceCode, out byte[]? debugSymbolsBytes)
    {
        assemblyBytes = AssemblyBytes;
        sourceCode = SourceCode;
        debugSymbolsBytes = DebugSymbolsBytes;
    }
}