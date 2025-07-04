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
/// Represents an item within the packaging toolkit, encapsulating a versioned library identifier,
/// input artifacts, and optionally result artifacts.
/// </summary>
/// <remarks>
/// This record is used to manage and process CQL libraries and their associated artifacts
/// within the packaging toolkit.
/// </remarks>
/// <param name="LibraryIdentifier">
/// The versioned identifier of the CQL library associated with this toolkit item.
/// </param>
/// <param name="InputArtifacts">
/// The input artifacts required for processing the CQL library, such as CQL, ELM, and assembly binaries.
/// </param>
/// <param name="ResultArtifacts">
/// The optional result artifacts generated after processing the CQL library, such as FHIR libraries or measures.
/// </param>
public readonly record struct PackagingToolkitItem
(
    CqlVersionedLibraryIdentifier LibraryIdentifier,
    PackagingToolkitInputArtifacts InputArtifacts,
    PackagingToolkitResultArtifacts? ResultArtifacts = null
)
{
    public PackagingToolkitItem WithResultArtifacts(
        FhirLibrary fhirLibrary,
        FhirMeasure? fhirMeasure = null) =>
        this with
        {
            ResultArtifacts = new(fhirLibrary, fhirMeasure)
        };
}