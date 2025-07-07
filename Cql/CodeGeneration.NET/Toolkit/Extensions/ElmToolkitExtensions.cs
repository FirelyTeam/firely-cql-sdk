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
    /// <summary>
    /// Retrieves a collection of results containing Elm libraries and their corresponding C# source code.
    /// </summary>
    /// <param name="elmToolkit">The <see cref="ElmToolkit"/> instance used to access the artifacts and their associated results.</param>
    /// <returns>An enumerable collection of tuples, where each tuple contains: <list type="bullet"> <item><description>The
    /// library identifier (<see cref="CqlVersionedLibraryIdentifier"/>).</description></item> <item><description>The
    /// input Elm library (<see cref="ElmLibrary"/>).</description></item> <item><description>The generated C# source
    /// code as a string.</description></item> </list> The collection will only include entries where C# source code is
    /// available.</returns>
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

    /// <summary>
    /// Retrieves a collection of results containing ELM libraries, their associated CQL identifiers,  generated C#
    /// source code, compiled assembly binaries, and optional debug symbols.
    /// </summary>
    /// <remarks>This method filters and transforms the artifacts stored in the <paramref name="elmToolkit"/>
    /// instance  to produce the results. Only artifacts with valid C# source code, assembly binaries, and optionally 
    /// debug symbols are included in the output.</remarks>
    /// <param name="elmToolkit">The <see cref="ElmToolkit"/> instance used to access the artifacts and their associated results.</param>
    /// <returns>An enumerable collection of tuples, where each tuple contains: <list type="bullet"> <item> <description>The <see
    /// cref="CqlVersionedLibraryIdentifier"/> representing the library identifier.</description> </item> <item>
    /// <description>The <see cref="ElmLibrary"/> representing the input ELM library.</description> </item> <item>
    /// <description>A <see cref="string"/> containing the generated C# source code.</description> </item> <item>
    /// <description>A <see cref="byte"/> array containing the compiled assembly binary.</description> </item> <item>
    /// <description>An optional <see cref="byte"/> array containing the debug symbols, or <see langword="null"/> if not
    /// available.</description> </item> </list></returns>
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