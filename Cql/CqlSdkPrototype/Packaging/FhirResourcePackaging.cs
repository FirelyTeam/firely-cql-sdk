using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Packaging;

public readonly record struct FhirResourcePackaging
(
    // Inputs
    FhirResourcePackagingInput Input,
    // Output
    FhirResource? FhirResource = null)
{
    public CqlVersionedLibraryIdentifier VersionedLibraryIdentifier => Input.VersionedLibraryIdentifier;
}