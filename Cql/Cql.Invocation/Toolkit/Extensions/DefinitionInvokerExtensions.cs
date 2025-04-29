/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */


using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for enumerations of <see cref="DefinitionInvoker"/>.
/// </summary>
public static class DefinitionInvokerExtensions
{
    /// <summary>
    /// Filters a collection of <see cref="DefinitionInvoker"/> objects to include only those with a
    /// <see cref="CqlDefinitionAttribute"/> of type <see cref="CqlExpressionDefinitionAttribute"/>.
    /// </summary>
    /// <param name="definitionInvokers">The collection of <see cref="DefinitionInvoker"/> objects to filter.</param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> containing the <see cref="DefinitionInvoker"/> objects that have
    /// a <see cref="CqlDefinitionAttribute"/> of type <see cref="CqlExpressionDefinitionAttribute"/>.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> WhereExpressionsDefinitions(
        this IEnumerable<DefinitionInvoker> definitionInvokers) =>
        definitionInvokers.Where(definitionInvoker => definitionInvoker.CqlDefinitionAttribute.GetType() == typeof(CqlExpressionDefinitionAttribute));

    /// <summary>
    /// Enumerates the results of library definitions.
    /// </summary>
    /// <param name="definitionInvokers">The definition invokers to get results from.</param>
    /// <param name="cqlContext">The CQL context used for invocation.</param>
    /// <param name="includeDefinition">The selector for the definition</param>
    /// <param name="definitionInvocationExceptionCallback">
    /// <para>
    /// An optional callback right after an exception is caught, and before it rethrown or ignored,
    /// based on the currently selected
    /// <see cref="LibrarySetInvoker.BatchProcessExceptionContinuation">LibrarySetInvoker.BatchProcessExceptionContinuation</see>.
    /// </para>
    /// <para>
    /// In most cases this is only necessary when the selected strategy is set to Ignore exceptions and when the caller
    /// has a special use case for it, e.g. to keep track of these exceptions.
    /// </para>
    /// <para>
    /// Otherwise, it's best to just catch the exception the normal way.
    /// </para>
    /// </param>
    /// <returns>An enumeration of tuples containing the definition invoker and the result.</returns>
    ///
    /// <remarks>
    /// <para>
    /// Exceptions are enriched such that the last <see cref="DefinitionInvoker"/> that caused
    /// the exception is available when inspecting the <see cref="Exception.Data">Exception.Data["Current"]</see> property.
    /// </para>
    ///
    /// <para>
    /// From the <see cref="DefinitionInvoker"/> the name of the
    /// <see cref="DefinitionInvoker.LibraryIdentifier"/> and <see cref="DefinitionInvoker.DefinitionName"/> are available.
    /// </para>
    /// </remarks>
    public static IEnumerable<(DefinitionInvoker definitionInvoker, object? definitionResult)> EnumerateResults(
        this IEnumerable<DefinitionInvoker> definitionInvokers,
        CqlContext cqlContext,
        Func<DefinitionInvoker, bool>? includeDefinition = null,
        ValueExceptionHandler<DefinitionInvoker>? definitionInvocationExceptionCallback = null)
    {
        if (definitionInvokers.TryGetNonEnumeratedCount(out int count) && count == 0)
            return [];

        if (includeDefinition is { } fn)
            definitionInvokers = definitionInvokers.Where(definitionInvoker => fn(definitionInvoker));

        definitionInvokers = definitionInvokers.Where(definitionInvoker => definitionInvoker.ParameterTypes.Length == 0);

        // We need to enumerate twice, which isn't a problem in the case of collections.
        if (definitionInvokers is not IReadOnlyCollection<DefinitionInvoker> or ICollection<DefinitionInvoker>)
            definitionInvokers = definitionInvokers.ToList();

        ILogger logger = NullLogger.Instance;
        BatchProcessExceptionContinuation continuation = BatchProcessExceptionContinuation.Throw;

        // First enumeration to check if we have a LibrarySetInvoker. We need this to get the logger and continuation.
        // ReSharper disable once PossibleMultipleEnumeration
        if (definitionInvokers.FirstOrDefault() is { LibraryInvoker.LibrarySetInvoker: { } lsi })
        {
            logger = lsi.CreateLogger(typeof(LibraryInvokerExtensions));
            continuation = lsi.BatchProcessExceptionContinuation;
        }

        // Second enumeration to actually invoke the definitions.
        // ReSharper disable once PossibleMultipleEnumeration
        return definitionInvokers
            .TrySelect(
                definitionInvoker => (definitionInvoker, definitionInvoker.Invoke(cqlContext)),
                errorStrategy => errorStrategy
                                 .SetContinuation(continuation)
                                 .AddLoggerExceptionHandler(
                                     logger,
                                     (definitionInvoker, logMessage) => logMessage("Could not invoke definition {definition}", definitionInvoker))
                                 .AddExceptionHandler(definitionInvocationExceptionCallback)
            );
    }
}