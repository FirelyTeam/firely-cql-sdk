/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="ElmToolkit"/> class.
/// </summary>
public static partial class ElmToolkitExtensions
{
    public static IEnumerable<(
        CqlVersionedLibraryIdentifier libraryIdentifier,
        ElmLibrary elmLibrary,
        string cSharp)> GetElmToCSharpResults(
        this ElmToolkit elmToolkit) =>
        elmToolkit.ArtifactsById
                  .SelectWhere(kv => kv.Value.Results switch
                  {
                      { CSharpSourceCode: {} cSharp } => (true, (kv.Key, kv.Value.InputElmLibrary, cSharp)),
                      _ => default
                  });

    public static IEnumerable<(
        CqlVersionedLibraryIdentifier libraryIdentifier,
        ElmLibrary elmLibrary,
        string cSharp,
        byte[] assemblyBinary,
        byte[]? debugSymbols)> GetElmToAssemblyResults(
        this ElmToolkit elmToolkit) =>
        elmToolkit.ArtifactsById
                  .SelectWhere(kv => kv.Value.Results switch
                  {
                      {
                              CSharpSourceCode: { } cSharp,
                              AssemblyBinary: {} assembly,
                              DebugSymbolsBinary: var debugSymbols
                      } => (true, (kv.Key, kv.Value.InputElmLibrary, cSharp, assembly, debugSymbols)),
                      _                                                                         => default
                  });

    private static ILogger CreateLogger(this ElmToolkit elmToolkit) =>
        elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));
}