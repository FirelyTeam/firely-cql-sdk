using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Packaging;

public readonly record struct FhirResourcePackaging
(
    // Sources
    CqlLibraryString CqlLibrary,
    ElmLibrary ElmLibrary,
    string CSharpSourceCode,
    byte[] AssemblyBinary,
    // Results
    FhirLibrary? FhirLibrary = null,
    FhirMeasure? FhirMeasure = null)
{
    /// <nodoc/>
    public FhirResourcePackaging(FhirResourcePackagingSources sources) :
        this(
            sources.CqlLibrary,
            sources.ElmLibrary,
            sources.CSharpSourceCode,
            sources.AssemblyBinary) { }

    public CqlVersionedLibraryIdentifier VersionedLibraryIdentifier => CqlLibrary.VersionedLibraryIdentifier;
}