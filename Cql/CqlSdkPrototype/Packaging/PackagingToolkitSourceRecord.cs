/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Packaging;

/// <summary>
/// Represents the sources for the <see cref="PackagingToolkit"/>
/// </summary>
/// <param name="CqlLibrary">The source CQL library.</param>
/// <param name="ElmLibrary">The source ELM library.</param>
/// <param name="CSharpSourceCode">The source C# source code.</param>
/// <param name="AssemblyBinary">The source .NET assembly bytes.</param>
public readonly record struct PackagingToolkitSourceRecord(
    CqlLibraryString CqlLibrary,
    ElmLibrary ElmLibrary,
    string CSharpSourceCode,
    byte[] AssemblyBinary
)
{
    public CqlVersionedLibraryIdentifier LibraryIdentifier => CqlLibrary.LibraryIdentifier;
}
