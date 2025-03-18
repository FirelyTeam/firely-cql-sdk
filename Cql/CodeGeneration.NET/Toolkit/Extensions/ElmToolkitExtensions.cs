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
    /// Gets the C# results of ELM to assembly conversions, ignores the assembly binaries and debug symbols.
    /// </summary>
    /// <param name="elmToolkit">The <see cref="ElmToolkit"/> instance.</param>
    /// <returns>An enumerable of the library identifiers and the associated C#.</returns>
    internal static IEnumerable<(CqlVersionedLibraryIdentifier libraryIdentifier, string csharpSourceCode)> GetElmToCSharpSourceCodeResults(
        this ElmToolkit elmToolkit) =>
        elmToolkit.Conversions.Values
                  .SelectWhere(t => t switch
                  {
                      {
                              LibraryIdentifier: { } libId,
                              ResultCSharpSourceCode: { } csharp,
                          } => (true, (libId, csharp)),
                      _ => default,
                  });


    /// <summary>
    /// Gets the results of ELM to assembly conversions.
    /// </summary>
    /// <param name="elmToolkit">The <see cref="ElmToolkit"/> instance.</param>
    /// <returns>An enumerable of <see cref="ElmToolkitResultRecord"/> containing the conversion results.</returns>
    public static IEnumerable<ElmToolkitResultRecord> GetElmToAssemblyResults(
        this ElmToolkit elmToolkit) =>
        elmToolkit.Conversions.Values
                  .SelectWhere(t => t switch
                  {
                      {
                          LibraryIdentifier: { } libId,
                          ResultCSharpSourceCode: { } csharp,
                          ResultAssemblyBinary: { } asm,
                          ResultDebugSymbolsBinary: var dbg
                      } => (true, new ElmToolkitResultRecord(libId, csharp, asm, dbg)),
                      _ => default,
                  });

    private static ILogger CreateLogger(ElmToolkit elmToolkit)
    {
        return elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));
    }
}
