using CqlSdkPrototype.Infrastructure;
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

    public static IEnumerable<(
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        CqlLibraryString cqlLibraryString,
        ElmLibrary elmLibrary)> GetCompletedCqlToElmTranslations(
        this FluentCqlToolkit cqlToolkit) =>
        cqlToolkit.GetCompletedCqlToElmTranslations(t => t);

    public static IEnumerable<TR> GetCompletedCqlToElmTranslations<TR>(
        this FluentCqlToolkit cqlToolkit,
        Func<(CqlVersionedLibraryIdentifier versionedLibraryIdentifier, CqlLibraryString cqlLibraryString, ElmLibrary elmLibrary), TR> selector) =>
        cqlToolkit.CqlToElmTranslations
            .Where(kv => kv.Value.ElmLibrary is not null)
            .Select(kv => selector((kv.Key, kv.Value.CqlLibraryString, kv.Value.ElmLibrary!)));
}