/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET.Toolkit;

/// <summary>
/// Represents a result record by the <see cref="ElmToolkit"/>.
/// </summary>
/// <param name="CSharpSourceCode">The result c# source code.</param>
/// <param name="AssemblyBinary">The result compiled assembly binary.</param>
/// <param name="DebugSymbolsBinary">
/// The result debug symbols binary for the compiled assembly.
/// This is only emitted if <seealso cref="ElmToolkitConfig.AssemblyCompilerDebugInformationFormat"/>
/// is set to <seealso cref="AssemblyCompilerDebugInformationFormat.PortablePdb"/>.
/// </param>
public readonly record struct ElmToolkitResultArtifacts(
    string CSharpSourceCode,
    byte[]? AssemblyBinary,
    byte[]? DebugSymbolsBinary = null) {

    /// <summary>
    /// Gets the assembly binary and optional debug symbols binary.
    /// </summary>
    public AssemblyBinary GetAssemblyBinary() =>
        this is { AssemblyBinary:null, DebugSymbolsBinary:null }
        ? NET.AssemblyBinary.Default
        : new(AssemblyBinary, DebugSymbolsBinary);

    internal AssemblyBinary GetAssemblyBinaryWithSourceCode() =>
        new AssemblyBinaryWithSourceCode(AssemblyBinary, null, CSharpSourceCode, DebugSymbolsBinary);
}