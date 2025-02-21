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
/// Represents a result record for the <see cref="PackagingToolkit"/>.
/// </summary>
/// <param name="LibraryIdentifier">The library identifier of the input library.</param>
/// <param name="FhirLibrary">The result FHIR library.</param>
/// <param name="FhirMeasure">The result FHIR measure.</param>
public readonly record struct PackagingToolkitResultRecord(
    CqlVersionedLibraryIdentifier LibraryIdentifier,
    FhirLibrary FhirLibrary,
    FhirMeasure? FhirMeasure = null)
{
    /// <summary>
    /// Gets the non-null FHIR resources in this record.
    /// </summary>
    public IReadOnlyCollection<FhirResource> GetFhirResources() =>
        FhirMeasure is null
            ? [FhirLibrary]
            : new FhirResource[] { FhirLibrary, FhirMeasure };
}
