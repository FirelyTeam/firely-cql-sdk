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
/// Represents the inputs for the <see cref="PackagingToolkit"/>
/// </summary>
/// <param name="CqlLibrary">The input CQL library.</param>
/// <param name="ElmLibrary">The input ELM library.</param>
/// <param name="CSharpSourceCode">The input C# source code.</param>
/// <param name="AssemblyBinary">The input .NET assembly bytes.</param>
public readonly record struct PackagingToolkitInputRecord(
    CqlLibraryString CqlLibrary,
    ElmLibrary ElmLibrary,
    string CSharpSourceCode,
    byte[] AssemblyBinary
)
{
    /// <summary>
    /// Gets the library identifier from the CQL library.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier => CqlLibrary.LibraryIdentifier;
}
