using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Packaging;

public readonly record struct PackagingToolkitSourceRecord(
    CqlLibraryString CqlLibrary,
    ElmLibrary ElmLibrary,
    string CSharpSourceCode,
    byte[] AssemblyBinary
)
{
    public CqlVersionedLibraryIdentifier VersionedLibraryIdentifier => CqlLibrary.LibraryIdentifier;
}