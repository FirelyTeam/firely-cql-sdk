using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Packaging;

/// <summary>
/// Represents an input record for the <see cref="PackagingToolkit"/>
/// </summary>
/// <param name="CqlLibrary">The input CQL library.</param>
/// <param name="ElmLibrary">The input ELM library.</param>
/// <param name="CSharpSourceCode">The input C# source code.</param>
/// <param name="AssemblyBinary">The input .NET assembly bytes.</param>
public readonly record struct PackagingToolkitInputRecord(
    CqlLibraryString CqlLibrary,
    ElmLibrary ElmLibrary,
    string CSharpSourceCode,
    byte[] AssemblyBinary
)
{
    public CqlVersionedLibraryIdentifier LibraryIdentifier => CqlLibrary.LibraryIdentifier;
}