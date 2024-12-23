using CqlSdkPrototype.Advanced;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.ElmToAssembly;

public readonly record struct ElmCompilationError(
    ElmCompiler ElmCompiler,
    Exception Exception,
    string Method,
    string? Identifier)
{
    public ILogger<ElmCompiler> Logger => ((ILogAccessor<ElmCompiler>)ElmCompiler).Logger;
}