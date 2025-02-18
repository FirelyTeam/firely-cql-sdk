using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Cql.Extensions;

public static partial class CqlToolkitExtensions
{
    private static ILogger CreateLogger(this CqlToolkit cqlToolkit) =>
        cqlToolkit.LoggerFactory.CreateLogger(typeof(CqlToolkitExtensions));

    public static CqlToolkit SetExceptionHandlingToIgnore(this CqlToolkit cqlToolkit, bool stopAfterFirstException = false) =>
        cqlToolkit.Reconfigure(o => o with
        {
            ErroredEnumerationContinuation = stopAfterFirstException ? ErroredEnumerationContinuation.Break : ErroredEnumerationContinuation.Continue
        });

    public static IEnumerable<CqlToolkitResultRecord> GetCqlToolkitResults(
        this CqlToolkit cqlToolkit) =>
        cqlToolkit.Conversions.Values
                  .SelectWhere(conversionRecord => conversionRecord switch
                  {
                      { LibraryIdentifier: { } id, ResultElmLibrary: { } elmLib } => (true, new CqlToolkitResultRecord(id, elmLib)),
                      _                                                           => default
                  });
}