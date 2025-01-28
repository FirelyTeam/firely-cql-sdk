using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm;

public readonly record struct ElmToAssemblyCompilation(Library ElmLibrary, string? CSharpSourceCode = null, byte[]? AssemblyBinary = null, byte[]? DebugSymbolsBinary = null);