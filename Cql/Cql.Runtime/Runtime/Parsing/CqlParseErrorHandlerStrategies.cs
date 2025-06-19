namespace Hl7.Cql.Runtime.Parsing;

internal static class CqlParseErrorHandlerStrategies
{

    public static CqlParseErrorHandler OnErrorThrowException(Type TargetType) =>
        e =>
            throw (e.Format switch
           {
               CqlParseErrors.NullOrEmpty => new ArgumentNullException(),
               _                          => new FormatException($"Not a valid {TargetType}: {e}")
           });

    public static CqlParseErrorHandler OnErrorThrowInvalidOperationException =>
        error => throw new InvalidOperationException(error.ToString());

    public static CqlParseErrorHandler OnErrorIgnore =>
        error => { };
}