using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="CqlToolkit"/> class.
/// </summary>
public static partial class CqlToolkitExtensions
{
    /// <summary>
    /// Creates a logger for the specified <see cref="CqlToolkit"/>.
    /// </summary>
    /// <param name="cqlToolkit">The CQL toolkit instance.</param>
    /// <returns>An <see cref="ILogger"/> instance.</returns>
    private static ILogger CreateLogger(this CqlToolkit cqlToolkit) =>
        cqlToolkit.LoggerFactory.CreateLogger(typeof(CqlToolkitExtensions));

    /// <summary>
    /// Configures the <see cref="CqlToolkit"/> to ignore exceptions during enumeration.
    /// </summary>
    /// <param name="cqlToolkit">The CQL toolkit instance.</param>
    /// <param name="stopAfterFirstException">If set to <c>true</c>, stops after the first exception; otherwise, continues.</param>
    /// <returns>The configured <see cref="CqlToolkit"/> instance.</returns>
    public static CqlToolkit SetExceptionHandlingToIgnore(this CqlToolkit cqlToolkit, bool stopAfterFirstException = false) =>
        cqlToolkit.Reconfigure(o => o with
        {
            ErroredEnumerationContinuation = stopAfterFirstException ? ErroredEnumerationContinuation.Break : ErroredEnumerationContinuation.Continue
        });

    /// <summary>
    /// Gets the completed CQL to ELM translations.
    /// </summary>
    /// <param name="cqlToolkit">The CQL toolkit instance.</param>
    /// <returns>An enumerable of completed CQL to ELM translations.</returns>
    public static IEnumerable<(
        CqlVersionedLibraryIdentifier versionedLibraryIdentifier,
        CqlLibraryString cqlLibraryString,
        ElmLibrary elmLibrary)> GetCompletedCqlToElmTranslations(
        this CqlToolkit cqlToolkit) =>
        cqlToolkit.GetCompletedCqlToElmTranslations(t => t);

    /// <summary>
    /// Gets the completed CQL to ELM translations with a specified selector.
    /// </summary>
    /// <typeparam name="TR">The type of the result.</typeparam>
    /// <param name="cqlToolkit">The CQL toolkit instance.</param>
    /// <param name="selector">A function to select the result.</param>
    /// <returns>An enumerable of selected results from completed CQL to ELM translations.</returns>
    public static IEnumerable<TR> GetCompletedCqlToElmTranslations<TR>(
        this CqlToolkit cqlToolkit,
        Func<(CqlVersionedLibraryIdentifier versionedLibraryIdentifier, CqlLibraryString cqlLibraryString, ElmLibrary elmLibrary), TR> selector) =>
        cqlToolkit.Conversions
            .Where(kv => kv.Value.OutElmLibrary is not null)
            .Select(kv => selector((kv.Key, kv.Value.InCqlLibraryString, kv.Value.OutElmLibrary!)));
}
