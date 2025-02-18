using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Packaging;

/// <summary>
/// Represents a state record by the <see cref="PackagingToolkit"/>
/// to convert the sources <see cref="SourceCqlLibrary"/>, <see cref="SourceElmLibrary"/>,
/// <see cref="SourceCSharpSourceCode"/> and <see cref="SourceAssemblyBinary"/>
/// to the results <see cref="ResultFhirLibrary"/>, <see cref="ResultFhirMeasure"/>.
/// </summary>
/// <param name="SourceCqlLibrary">The source CQL library.</param>
/// <param name="SourceElmLibrary">The source ELM library.</param>
/// <param name="SourceCSharpSourceCode">The source C# source code.</param>
/// <param name="SourceAssemblyBinary">The source .NET assembly bytes.</param>
/// <param name="ResultFhirLibrary">The result FHIR library.</param>
/// <param name="ResultFhirMeasure">The result FHIR measure.</param>
public readonly record struct PackagingToolkitConversionRecord(
    CqlLibraryString SourceCqlLibrary,
    ElmLibrary SourceElmLibrary,
    string SourceCSharpSourceCode,
    byte[] SourceAssemblyBinary,
    FhirLibrary? ResultFhirLibrary = null,
    FhirMeasure? ResultFhirMeasure = null)
{
    /// <summary>
    /// The library identifier of the input CQL library.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier => SourceCqlLibrary.LibraryIdentifier;

    /// <nodoc/>
    public PackagingToolkitConversionRecord(PackagingToolkitSourceRecord sourceRecord) :
        this(
            sourceRecord.CqlLibrary,
            sourceRecord.ElmLibrary,
            sourceRecord.CSharpSourceCode,
            sourceRecord.AssemblyBinary) { }
}