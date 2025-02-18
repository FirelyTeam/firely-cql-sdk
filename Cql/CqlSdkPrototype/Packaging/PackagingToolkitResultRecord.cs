using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Packaging;

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