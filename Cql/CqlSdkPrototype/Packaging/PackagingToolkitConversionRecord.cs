using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Packaging;

public readonly record struct PackagingToolkitConversionRecord(
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
    public PackagingToolkitConversionRecord(PackagingToolkitSourceRecord sourceRecords) :
        this(
            sourceRecords.CqlLibrary,
            sourceRecords.ElmLibrary,
            sourceRecords.CSharpSourceCode,
            sourceRecords.AssemblyBinary) { }

    public CqlVersionedLibraryIdentifier VersionedLibraryIdentifier => CqlLibrary.LibraryIdentifier;
}