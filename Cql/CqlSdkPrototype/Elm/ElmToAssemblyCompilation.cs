using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Elm;

/// <summary>
/// Represents the compilation result of an ELM library to an assembly.
/// </summary>
/// <param name="ElmLibrary">The input ELM library being compiled.</param>
/// <param name="CSharpSourceCode">The output generated C# source code from the ELM library.</param>
/// <param name="AssemblyBinary">The output compiled assembly binary.</param>
/// <param name="DebugSymbolsBinary">
/// The output debug symbols binary for the compiled assembly.
/// This is only emitted if <seealso cref="ElmToAssemblyCompilerConfig.AssemblyCompilerDebugInformationFormat"/>
/// is set to <seealso cref="AssemblyCompilerDebugInformationFormat.PortablePdb"/>.
/// </param>
public readonly record struct ElmToAssemblyCompilation(
    ElmLibrary ElmLibrary,
    string? CSharpSourceCode = null,
    byte[]? AssemblyBinary = null,
    byte[]? DebugSymbolsBinary = null);