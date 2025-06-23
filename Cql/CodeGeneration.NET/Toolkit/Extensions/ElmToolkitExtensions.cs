/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="ElmToolkit"/> class.
/// </summary>
public static partial class ElmToolkitExtensions
{
    /// <summary>
    /// Gets the results of ELM to assembly conversions.
    /// </summary>
    /// <param name="elmToolkit">The <see cref="ElmToolkit"/> instance.</param>
    /// <returns>An enumerable of <see cref="ElmToolkitCSharpResultRecord"/> containing the conversion results.</returns>
    public static IEnumerable<ElmToolkitCSharpResultRecord> GetElmToCSharpResults(
        this ElmToolkit elmToolkit) =>
        elmToolkit.Conversions.Values
                  .SelectWhere(t => t switch
                  {
                      {
                          LibraryIdentifier: { } libId,
                          ResultCSharpSourceCode: { } csharp
                      } => (true, new ElmToolkitCSharpResultRecord(libId, csharp)),
                      _ => default,
                  });

    /// <summary>
    /// Gets the results of ELM to assembly conversions.
    /// </summary>
    /// <param name="elmToolkit">The <see cref="ElmToolkit"/> instance.</param>
    /// <returns>An enumerable of <see cref="ElmToolkitAssemblyResultRecord"/> containing the conversion results.</returns>
    public static IEnumerable<ElmToolkitAssemblyResultRecord> GetElmToAssemblyResults(
        this ElmToolkit elmToolkit) =>
        elmToolkit.Conversions.Values
                  .SelectWhere(t => t switch
                  {
                      {
                          LibraryIdentifier: { } libId,
                          ResultCSharpSourceCode: { } csharp,
                          ResultAssemblyBinary: { } asm,
                          ResultDebugSymbolsBinary: var dbg
                      } => (true, new ElmToolkitAssemblyResultRecord(libId, csharp, asm, dbg)),
                      _ => default,
                  });

    private static ILogger CreateLogger(ElmToolkit elmToolkit)
    {
        return elmToolkit.LoggerFactory.CreateLogger(typeof(ElmToolkitExtensions));
    }
}
