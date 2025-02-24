/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packaging.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="PackagingToolkit"/> class.
/// </summary>
public static partial class PackagingToolkitExtensions
{
    /// <summary>
    /// Configures the <see cref="PackagingToolkit"/> to ignore exceptions.
    /// </summary>
    /// <param name="packagingToolkit">The <see cref="PackagingToolkit"/> to configure.</param>
    /// <param name="stopAfterFirstException">If set to <c>true</c>, stops after the first exception; otherwise, continues.</param>
    /// <returns>The configured <see cref="PackagingToolkit"/>.</returns>
    public static PackagingToolkit SetExceptionHandlingToIgnore(this PackagingToolkit packagingToolkit, bool stopAfterFirstException = false) =>
        packagingToolkit.Reconfigure(o => o with
        {
            EnumerationExceptionContinuation = stopAfterFirstException
                                                    ? EnumerationExceptionContinuation.Break
                                                    : EnumerationExceptionContinuation.Continue
        });

    /// <summary>
    /// Adds packaging inputs from CQL and ELM toolkits to the <see cref="PackagingToolkit"/>.
    /// </summary>
    /// <param name="packagingToolkit">The <see cref="PackagingToolkit"/> to add inputs to.</param>
    /// <param name="cqlToolkit">The <see cref="CqlToolkit"/> containing CQL libraries.</param>
    /// <param name="elmToolkit">The <see cref="ElmToolkit"/> containing ELM compilations.</param>
    /// <returns>The <see cref="PackagingToolkit"/> with added inputs.</returns>
    public static PackagingToolkit AddPackagingInputsFromCqlAndElmToolkits(
        this PackagingToolkit packagingToolkit,
        CqlToolkit cqlToolkit,
        ElmToolkit elmToolkit)
    {
        var cqlLibraries = cqlToolkit.Conversions.Values.Select(o => o.SourceCqlLibrary);
        var compilations = elmToolkit.Conversions.Values.SelectWhere(o => o switch
        {
            { ResultCSharpSourceCode: { } ResultCSharpSourceCode, ResultAssemblyBinary: { } ResultAssemblyBinary } => (true, (o.LibraryIdentifier, o.SourceElmLibrary, ResultCSharpSourceCode, ResultAssemblyBinary)),
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
