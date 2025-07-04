/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packaging.Toolkit;

/// <summary>
/// Represents the input data required for the packaging toolkit, including libraries, source code, and binaries.
/// </summary>
/// <remarks>This record is used to encapsulate all necessary components for processing and packaging within the
/// toolkit. It includes CQL and ELM libraries, C# source code, and compiled binaries, with optional debug
/// symbols.</remarks>
/// <param name="CqlLibrary">The CQL library string used for clinical quality language processing.</param>
/// <param name="ElmLibrary">The ELM library object representing the executable logic model.</param>
/// <param name="CSharpSourceCode">The C# source code as a string, which is used for generating the assembly binary.</param>
/// <param name="AssemblyBinary">The compiled assembly binary as a byte array.</param>
/// <param name="DebugSymbolsBinary">The optional debug symbols binary as a byte array, or <see langword="null"/> if debug symbols are not provided.</param>
public readonly record struct PackagingToolkitInputArtifacts
(
    CqlLibraryString CqlLibrary,
    ElmLibrary ElmLibrary,
    string CSharpSourceCode,
    byte[] AssemblyBinary,
    byte[]? DebugSymbolsBinary)
{
    /// <summary>
    /// Gets the identifier for the versioned CQL library associated with this instance.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier { get; } = CqlLibrary.LibraryIdentifier;

    /// <summary>
    /// Converts the current instance into a <see cref="ResourcePackager.InputArtifacts"/> object.
    /// </summary>
    /// <returns>A <see cref="ResourcePackager.InputArtifacts"/> object containing the CQL library, ELM library,  C# source code,
    /// assembly binary, and debug symbols binary from the current instance.</returns>
    internal ResourcePackager.InputArtifacts ToResourcePackagerInputArtifacts() =>
        new(CqlLibrary, ElmLibrary, CSharpSourceCode, AssemblyBinary, DebugSymbolsBinary);
}