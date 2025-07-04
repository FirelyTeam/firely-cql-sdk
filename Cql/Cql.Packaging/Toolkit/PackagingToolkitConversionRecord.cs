/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packaging.Toolkit;

/// <summary>
/// Represents a conversion record used by the <see cref="PackagingToolkit"/> to transform input artifacts, such as CQL
/// and ELM libraries, C# source code, and .NET assembly binaries, into corresponding FHIR-based outputs.
/// </summary>
/// <remarks>This record encapsulates both the input artifacts required for the conversion process and the
/// resulting outputs. It is designed to facilitate the transformation of clinical quality language (CQL) and related
/// resources into FHIR-compliant libraries and measures.</remarks>
/// <param name="LibraryIdentifier">The identifier of the input CQL library, including its version.</param>
/// <param name="InputArtifacts">The input artifacts required for the conversion process.</param>
/// <param name="ResultArtifacts">The result artifacts produced by the conversion process. Defaults to an empty result record.</param>
public readonly record struct PackagingToolkitConversionRecord
(
    CqlVersionedLibraryIdentifier LibraryIdentifier,
    PackagingToolkitInputArtifacts InputArtifacts,
    PackagingToolkitResultArtifacts? ResultArtifacts = null
)
{
    public PackagingToolkitConversionRecord WithResultArtifacts(
        FhirLibrary fhirLibrary,
        FhirMeasure? fhirMeasure = null) =>
        this with
        {
            ResultArtifacts = new(fhirLibrary, fhirMeasure)
        };
}