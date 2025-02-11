using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Packaging;

public readonly record struct FhirResourcePackaging
(
    // Inputs
    FhirResourcePackagingInput Input,
    // Output
    FhirLibrary? FhirLibrary = null,
    FhirMeasure? FhirMeasure = null)
{
    public CqlVersionedLibraryIdentifier VersionedLibraryIdentifier => Input.VersionedLibraryIdentifier;
}