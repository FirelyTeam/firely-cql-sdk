using CqlSdkPrototype.Advanced;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.ElmToAssembly;

public readonly record struct ElmCompilationError(
    ElmCompilation ElmCompilation,
    Exception Exception,
    string Method,
    string? Identifier)
{
    public ILogger<ElmCompilation> Logger => ((ILogAccessor<ElmCompilation>)ElmCompilation).Logger;
}