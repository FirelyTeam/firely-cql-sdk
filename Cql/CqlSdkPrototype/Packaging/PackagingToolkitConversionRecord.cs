using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Packaging;

/// <summary>
/// Represents a state record by the <see cref="PackagingToolkit"/>
/// to convert the input <see cref="InCqlLibrary"/>, <see cref="InElmLibrary"/>,
/// <see cref="InCSharpSourceCode"/> and <see cref="InAssemblyBinary"/>
/// to the output <see cref="OutFhirLibrary"/>, <see cref="OutFhirMeasure"/>.
/// </summary>
/// <param name="InCqlLibrary">The input CQL library.</param>
/// <param name="InElmLibrary">The input ELM library.</param>
/// <param name="InCSharpSourceCode">The input C# source code.</param>
/// <param name="InAssemblyBinary">The input .NET assembly bytes.</param>
/// <param name="OutFhirLibrary">The output FHIR library.</param>
/// <param name="OutFhirMeasure">The output FHIR measure.</param>
public readonly record struct PackagingToolkitConversionRecord(
    CqlLibraryString InCqlLibrary,
    ElmLibrary InElmLibrary,
    string InCSharpSourceCode,
    byte[] InAssemblyBinary,
    FhirLibrary? OutFhirLibrary = null,
    FhirMeasure? OutFhirMeasure = null)
{
    /// <summary>
    /// The library identifier of the input CQL library.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier => InCqlLibrary.LibraryIdentifier;

    /// <nodoc/>
    public PackagingToolkitConversionRecord(PackagingToolkitInputRecord inputRecord) :
        this(
            inputRecord.CqlLibrary,
            inputRecord.ElmLibrary,
            inputRecord.CSharpSourceCode,
            inputRecord.AssemblyBinary) { }

}