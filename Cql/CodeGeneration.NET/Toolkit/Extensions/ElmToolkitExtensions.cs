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
    /// Configures the <see cref="ElmToolkit"/> to ignore exceptions.
    /// </summary>
    /// <param name="cqlToolkit">The <see cref="ElmToolkit"/> instance.</param>
    /// <param name="stopAfterFirstException">If set to <c>true</c>, stops after the first exception; otherwise, continues.</param>
    /// <returns>The configured <see cref="ElmToolkit"/> instance.</returns>
    public static ElmToolkit SetExceptionHandlingToIgnore(this ElmToolkit cqlToolkit, bool stopAfterFirstException = false) =>
        cqlToolkit.Reconfigure(o => o with
        {
            EnumerationExceptionContinuation = stopAfterFirstException
                                                    ? EnumerationExceptionContinuation.Break
                                                    : EnumerationExceptionContinuation.Continue
        });

    /// <summary>
    /// Configures the <see cref="ElmToolkit"/> to use embedded debug information.
    /// </summary>
    /// <param name="cqlToolkit">The <see cref="ElmToolkit"/> instance.</param>
    /// <returns>The configured <see cref="ElmToolkit"/> instance.</returns>
    public static ElmToolkit SetAssemblyDebugInformationToEmbedded(this ElmToolkit cqlToolkit) =>
        cqlToolkit.Reconfigure(o => o with
        {
            AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.Embedded
        });

    /// <summary>
    /// Configures the <see cref="ElmToolkit"/> to use portable PDB debug information.
    /// </summary>
    /// <param name="cqlToolkit">The <see cref="ElmToolkit"/> instance.</param>
    /// <returns>The configured <see cref="ElmToolkit"/> instance.</returns>
    public static ElmToolkit SetAssemblyDebugInformationToPortablePdb(this ElmToolkit cqlToolkit) =>
        cqlToolkit.Reconfigure(o => o with
        {
            AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.PortablePdb
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
}
