using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm;

/// <summary>
/// Represents a state record by the <see cref="ElmToolkit"/>
/// to convert the source <see cref="SourceElmLibrary"/> to
/// the results <see cref="ResultCSharpSourceCode"/>, <see cref="ResultAssemblyBinary"/>
/// and <see cref="ResultDebugSymbolsBinary"/>.
/// </summary>
/// <param name="SourceElmLibrary">The source ELM library being compiled.</param>
/// <param name="ResultCSharpSourceCode">The result generated C# source code from the ELM library.</param>
/// <param name="ResultAssemblyBinary">The result compiled assembly binary.</param>
/// <param name="ResultDebugSymbolsBinary">
/// The result debug symbols binary for the compiled assembly.
/// This is only emitted if <seealso cref="ElmToolkitConfig.AssemblyCompilerDebugInformationFormat"/>
/// is set to <seealso cref="AssemblyCompilerDebugInformationFormat.PortablePdb"/>.
/// </param>
public readonly record struct ElmToolkitConversionRecord(
    ElmLibrary SourceElmLibrary,
    string? ResultCSharpSourceCode = null,
    byte[]? ResultAssemblyBinary = null,
    byte[]? ResultDebugSymbolsBinary = null)
{
    /// <summary>
    /// The library identifier of the input CQL library.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier { get; } = CqlVersionedLibraryIdentifier.Parse(SourceElmLibrary.GetVersionedIdentifier()!);
}