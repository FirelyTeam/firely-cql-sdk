/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packaging.Toolkit;

/// <summary>
/// Represents a state record by the <see cref="PackagingToolkit"/>
/// to convert the inputs <see cref="InputCqlLibrary"/>, <see cref="InputElmLibrary"/>,
/// <see cref="InputCSharpSourceCode"/> and <see cref="InputAssemblyBinary"/>
/// to the results <see cref="ResultFhirLibrary"/>, <see cref="ResultFhirMeasure"/>.
/// </summary>
/// <param name="InputCqlLibrary">The input CQL library.</param>
/// <param name="InputElmLibrary">The input ELM library.</param>
/// <param name="InputCSharpSourceCode">The input C# source code.</param>
/// <param name="InputAssemblyBinary">The input .NET assembly bytes.</param>
/// <param name="ResultFhirLibrary">The result FHIR library.</param>
/// <param name="ResultFhirMeasure">The result FHIR measure.</param>
public readonly record struct PackagingToolkitConversionRecord(
    CqlLibraryString InputCqlLibrary,
    ElmLibrary InputElmLibrary,
    string InputCSharpSourceCode,
    byte[] InputAssemblyBinary,
    FhirLibrary? ResultFhirLibrary = null,
    FhirMeasure? ResultFhirMeasure = null)
{
    /// <summary>
    /// The library identifier of the input CQL library.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier => InputCqlLibrary.LibraryIdentifier;

    /// <nodoc/>
    public PackagingToolkitConversionRecord(PackagingToolkitInputRecord inputRecord) :
        this(
            inputRecord.CqlLibrary,
            inputRecord.ElmLibrary,
            inputRecord.CSharpSourceCode,
            inputRecord.AssemblyBinary) { }
}
