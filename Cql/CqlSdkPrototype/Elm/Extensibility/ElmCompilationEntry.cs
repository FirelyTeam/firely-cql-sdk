using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm.Extensibility;

public readonly record struct ElmCompilationEntry
    (Library ElmLibrary, string? CSharpSourceCode = null, byte[]? AssemblyBinary = null, byte[]? DebugSymbolsBinary = null);