namespace CqlSdkPrototype.CqlToElm;

public readonly record struct CqlTranslationError(
    CqlTranslation CqlTranslation,
    Exception Exception,
    string Method,
    string? Identifier);