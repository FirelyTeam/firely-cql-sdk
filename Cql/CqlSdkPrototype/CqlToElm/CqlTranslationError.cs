using CqlSdkPrototype.Advanced;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.CqlToElm;

public readonly record struct CqlTranslationError
(
    CqlTranslator CqlTranslator,
    Exception Exception,
    string Method,
    string? Identifier)
{
    public ILogger<CqlTranslator> Logger => ((ILogAccessor<CqlTranslator>)CqlTranslator).Logger;
}