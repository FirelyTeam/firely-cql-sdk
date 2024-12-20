using CqlSdkPrototype.Advanced;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.CqlToElm;

public readonly record struct CqlTranslationError
(
    CqlTranslation CqlTranslation,
    Exception Exception,
    string Method,
    string? Identifier)
{
    public ILogger<CqlTranslation> Logger => ((ILogAccessor<CqlTranslation>)CqlTranslation).Logger;
}