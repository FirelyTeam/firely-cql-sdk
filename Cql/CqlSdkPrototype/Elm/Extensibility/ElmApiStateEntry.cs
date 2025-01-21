using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm.Extensibility;

public readonly record struct ElmApiStateEntry
    (Library ElmLibrary, string? CSharpSourceCode = null, byte[]? AssemblyBinary = null, byte[]? DebugSymbolsBinary = null);