/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET.Toolkit;

public readonly record struct ElmToolkitArtifacts(
    ElmLibrary InputElmLibrary,
    ElmToolkitResultArtifacts? Results = null)
{
    /// <summary>
    /// The library identifier of the input CQL library.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier => InputElmLibrary.VersionedLibraryIdentifier;

    public ElmToolkitArtifacts WithResultArtifacts(
        string cSharpSourceCode,
        byte[]? assemblyBinary,
        byte[]? debugSymbols) => this with
    {
        Results = new ElmToolkitResultArtifacts(cSharpSourceCode, assemblyBinary, debugSymbols)
    };
}