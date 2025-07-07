/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm.Toolkit;

namespace Hl7.Cql.Packaging.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="PackagingToolkit"/> class.
/// </summary>
public static partial class PackagingToolkitExtensions
{
    /// <summary>
    /// Adds packaging inputs from CQL and ELM toolkits to the <see cref="PackagingToolkit"/>.
    /// </summary>
    /// <param name="packagingToolkit">The <see cref="PackagingToolkit"/> to add inputs to.</param>
    /// <param name="cqlToolkit">The <see cref="CqlToolkit"/> containing CQL libraries.</param>
    /// <param name="elmToolkit">The <see cref="ElmToolkit"/> containing ELM compilations.</param>
    /// <returns>The <see cref="PackagingToolkit"/> with added inputs.</returns>
    public static PackagingToolkit AddPackagingInputs(
        this PackagingToolkit packagingToolkit,
        CqlToolkit cqlToolkit,
        ElmToolkit elmToolkit)
    {
        elmToolkit.CompileToAssemblies();
        var cqlLibraries = cqlToolkit.ArtifactsById.Values.Select(o => o.SourceCqlLibrary);
        var inputArtifacts = elmToolkit.GetElmToAssemblyResults();
        var inputs =
            cqlLibraries
                .Join(
                    inputArtifacts,
                    cqlLibraryString => cqlLibraryString.LibraryIdentifier,
                    r => r.libraryIdentifier,
                    (cqlLibraryString, r) => new PackagingToolkitInputArtifacts(cqlLibraryString, r.elmLibrary, r.cSharp, r.assemblyBinary, r.debugSymbols));

        return packagingToolkit.AddPackagingInputs(inputs);
    }
}