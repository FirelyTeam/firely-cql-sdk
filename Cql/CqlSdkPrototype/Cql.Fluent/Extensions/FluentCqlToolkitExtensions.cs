using Hl7.Cql.Abstractions.Exceptions;

namespace CqlSdkPrototype.Cql.Fluent.Extensions;

public static partial class FluentCqlToolkitExtensions
{
    private static ILogger CreateLogger(this FluentCqlToolkit cqlToolkit) =>
        cqlToolkit.LoggerFactory.CreateLogger(typeof(FluentCqlToolkitExtensions));

    public static FluentCqlToolkit ConfigIgnoreExceptions(this FluentCqlToolkit cqlToolkit, bool stopAfterFirstException = false) =>
        cqlToolkit.Reconfigure(o => o with
        {
            ProcessBatchItemExceptionHandling = stopAfterFirstException
                                                    ? ProcessBatchItemExceptionHandling.IgnoreExceptionAndBreak
                                                    : ProcessBatchItemExceptionHandling.IgnoreExceptionAndContinue
        });
}