using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Elm;

/// <summary>
/// Represents the compilation result of an ELM library to an assembly.
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
    byte[]? OutDebugSymbolsBinary = null);