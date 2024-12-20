using CqlSdkPrototype.Advanced;

namespace CqlSdkPrototype.ElmToAssembly;

public readonly record struct ElmCompilationError(
    ILibraryAcceptor<ElmCompilation> ElmCompilation,
    Exception Exception,
    string Method,
    string? Identifier);