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
/// Represents the artifacts used and produced by the packaging toolkit in the CQL packaging process.
/// </summary>
/// <param name="Input">
/// The input artifacts required for the packaging process, including the CQL library, ELM library, 
/// C# source code, assembly binary, and optional debug symbols.
/// </param>
/// <param name="Result">
/// The optional result artifacts produced by the packaging process, including the FHIR library 
/// and an optional FHIR measure.
/// </param>
public readonly record struct PackagingToolkitArtifacts
(
    PackagingToolkitInputArtifacts Input,
    PackagingToolkitResultArtifacts? Result = null
)
{
    /// <summary>
    /// Gets the identifier for the versioned library associated with the current input.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier => Input.LibraryIdentifier;

    /// <summary>
    /// Creates a new instance of <see cref="PackagingToolkitArtifacts"/> with updated result artifacts.
    /// </summary>
    /// <param name="fhirLibrary">The <see cref="FhirLibrary"/> instance representing the library of FHIR resources to include in the result.</param>
    /// <param name="fhirMeasure">An optional <see cref="FhirMeasure"/> instance representing the measure to include in the result. If not
    /// provided, the result will only include the <paramref name="fhirLibrary"/>.</param>
    /// <returns>A new <see cref="PackagingToolkitArtifacts"/> instance with the specified result artifacts.</returns>
    public PackagingToolkitArtifacts WithResultArtifacts(
        FhirLibrary fhirLibrary,
        FhirMeasure? fhirMeasure = null) =>
        this with
        {
            Result = new(fhirLibrary, fhirMeasure)
        };
}