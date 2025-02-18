/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Packaging.Extensions;

public static partial class PackagingToolkitExtensions
{
    public static PackagingToolkit SetExceptionHandlingToIgnore(this PackagingToolkit packagingToolkit, bool stopAfterFirstException = false) =>
        packagingToolkit.Reconfigure(o => o with
        {
            ErroredEnumerationContinuation = stopAfterFirstException
                                                    ? ErroredEnumerationContinuation.Break
                                                    : ErroredEnumerationContinuation.Continue
        });


    public static PackagingToolkit AddPackagingInputsFromCqlAndElmToolkits(
        this PackagingToolkit packagingToolkit,
        CqlToolkit cqlToolkit,
        ElmToolkit elmToolkit)
    {
        var cqlLibraries = cqlToolkit.Conversions.Values.Select(o => o.SourceCqlLibrary);
        var compilations = elmToolkit.Conversions.Values.SelectWhere(o => o switch
        {
            { ResultCSharpSourceCode:{} ResultCSharpSourceCode, ResultAssemblyBinary: {} ResultAssemblyBinary } => (true, (o.LibraryIdentifier, o.SourceElmLibrary, ResultCSharpSourceCode, ResultAssemblyBinary)),
            _ => default
        });
        var inputs =
            cqlLibraries
                .Join(compilations,
                      l => l.LibraryIdentifier, r => r.LibraryIdentifier,
                      (l, r) => new PackagingToolkitSourceRecord(l, r.SourceElmLibrary, r.ResultCSharpSourceCode, r.ResultAssemblyBinary));
        return packagingToolkit.AddPackagingInputs(inputs);
    }
}
