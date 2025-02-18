/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Elm.Extensions;

public static partial class ElmToolkitExtensions
{
    public static ElmToolkit SetExceptionHandlingToIgnore(this ElmToolkit cqlToolkit, bool stopAfterFirstException = false) =>
        cqlToolkit.Reconfigure(o => o with
        {
            ErroredEnumerationContinuation = stopAfterFirstException
                                                    ? ErroredEnumerationContinuation.Break
                                                    : ErroredEnumerationContinuation.Continue
        });

    public static ElmToolkit SetAssemblyDebugInformationToEmbedded(this ElmToolkit cqlToolkit) =>
        cqlToolkit.Reconfigure(o => o with
        {
            AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.Embedded
        });

    public static ElmToolkit SetAssemblyDebugInformationToPortablePdb(this ElmToolkit cqlToolkit) =>
        cqlToolkit.Reconfigure(o => o with
        {
            AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.PortablePdb
        });


    public static IEnumerable<ElmToolkitResultRecord> GetElmToAssemblyResults(
        this ElmToolkit elmToolkit) =>
        elmToolkit.Conversions.Values
                  .SelectWhere(t => t switch
                  {
                      {
                          LibraryIdentifier: {} libId,
                          ResultCSharpSourceCode: {} csharp,
                          ResultAssemblyBinary: {} asm,
                          ResultDebugSymbolsBinary: var dbg
                      } => (true, new ElmToolkitResultRecord(libId, csharp, asm, dbg)),
                      _ => default,
                  });

}
