/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm.Toolkit;

namespace Hl7.Cql.Packaging.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="CqlToolkit"/> class.
/// </summary>
public static class CqlToolkitPackagingExtensions
{
    /// <summary>
    /// Creates an instance of <see cref="PackagingToolkit"/> using the provided <see cref="ElmToolkit"/>.
    /// </summary>
    ///
    /// <param name="cqlToolkit">
    ///     The <see cref="CqlToolkit"/> instance which contains the CQL libraries which
    ///     will be mapped to the ELM libraries against their versioned identifiers.
    /// </param>
    ///
    /// <param name="elmToolkitConfig">The configuration for the ELM toolkit.</param>
    ///
    /// <param name="packagingToolkitConfig">The configuration for the Packaging toolkit.</param>
    ///
    /// <returns>An instance of <see cref="PackagingToolkit"/>.</returns>
    public static PackagingToolkit CreatePackagingToolkit(
        this CqlToolkit cqlToolkit,
        ElmToolkitConfig? elmToolkitConfig = null,
        PackagingToolkitConfig? packagingToolkitConfig = null) =>
        cqlToolkit
            .TranslateToElm()
            .CreateElmToolkit(elmToolkitConfig)
            .CreatePackagingToolkit(cqlToolkit, packagingToolkitConfig);

    /// <summary>
    /// Matches the results from the ELM toolkit against the CQL libraries from the CQL toolkit
    /// and package them to FHIR resources.
    /// </summary>
    ///
    /// <param name="cqlToolkit">
    /// The <see cref="CqlToolkit"/> instance to use for creating the <see cref="PackagingToolkit"/>,
    /// using the same <see cref="CqlToolkit.BatchProcessExceptionContinuation"/>.
    /// </param>
    ///
    /// <param name="elmToolkitConfig">The configuration for the ELM toolkit.</param>
    ///
    /// <param name="packagingToolkitConfig">The configuration for the Packaging toolkit.</param>
    ///
    /// <returns>An instance of <see cref="PackagingToolkit"/> with the packaged resources.</returns>
    public static PackagingToolkit PackageToFhirResources(
        this CqlToolkit cqlToolkit,
        ElmToolkitConfig? elmToolkitConfig = null,
        PackagingToolkitConfig? packagingToolkitConfig = null) =>
        cqlToolkit.CreatePackagingToolkit(elmToolkitConfig, packagingToolkitConfig)
            .ConvertToFhirResources();
}
