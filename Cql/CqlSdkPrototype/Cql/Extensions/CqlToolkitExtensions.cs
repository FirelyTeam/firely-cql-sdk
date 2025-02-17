using CqlSdkPrototype.Infrastructure;
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

    public static IEnumerable<(
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        CqlLibraryString cqlLibraryString,
        ElmLibrary elmLibrary)> GetCompletedCqlToElmTranslations(
        this CqlToolkit cqlToolkit) =>
        cqlToolkit.GetCompletedCqlToElmTranslations(t => t);

    public static IEnumerable<TR> GetCompletedCqlToElmTranslations<TR>(
        this CqlToolkit cqlToolkit,
        Func<(CqlVersionedLibraryIdentifier versionedLibraryIdentifier, CqlLibraryString cqlLibraryString, ElmLibrary elmLibrary), TR> selector) =>
        cqlToolkit.Conversions
            .Where(kv => kv.Value.OutElmLibrary is not null)
            .Select(kv => selector((kv.Key, kv.Value.InCqlLibraryString, kv.Value.OutElmLibrary!)));
}