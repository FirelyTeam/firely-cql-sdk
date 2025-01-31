using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Packaging;

public readonly record struct FhirResourcePackaging
(
    // Inputs
    FhirResourcePackagingInput Input,
    // Output
    string? FhirLibraryResourceJson = null
)
{
    public CqlVersionedLibraryIdentifier VersionedLibraryIdentifier => Input.VersionedLibraryIdentifier;
}