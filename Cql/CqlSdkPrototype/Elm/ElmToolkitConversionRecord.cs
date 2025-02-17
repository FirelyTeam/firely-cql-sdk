using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm;

/// <summary>
/// Represents a state record by the <see cref="ElmToolkit"/>
/// to convert the input <see cref="InElmLibrary"/> to
/// the output <see cref="OutCSharpSourceCode"/>, <see cref="OutAssemblyBinary"/>
/// and <see cref="OutDebugSymbolsBinary"/>.
/// </summary>
/// <param name="InElmLibrary">The input ELM library being compiled.</param>
/// <param name="OutCSharpSourceCode">The output generated C# source code from the ELM library.</param>
/// <param name="OutAssemblyBinary">The output compiled assembly binary.</param>
/// <param name="OutDebugSymbolsBinary">
/// The output debug symbols binary for the compiled assembly.
/// This is only emitted if <seealso cref="ElmToolkitConfig.AssemblyCompilerDebugInformationFormat"/>
/// is set to <seealso cref="AssemblyCompilerDebugInformationFormat.PortablePdb"/>.
/// </param>
public readonly record struct ElmToolkitConversionRecord(
    ElmLibrary InElmLibrary,
    string? OutCSharpSourceCode = null,
    byte[]? OutAssemblyBinary = null,
    byte[]? OutDebugSymbolsBinary = null)
{
    /// <summary>
    /// The library identifier of the input CQL library.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier { get; } = CqlVersionedLibraryIdentifier.Parse(InElmLibrary.GetVersionedIdentifier()!);
}