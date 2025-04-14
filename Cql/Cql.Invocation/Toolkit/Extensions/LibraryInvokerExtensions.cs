/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for <see cref="LibraryInvoker"/>.
/// </summary>
public static class LibraryInvokerExtensions
{
    /// <summary>
    /// Enumerates the results of library definitions.
    /// </summary>
    /// <param name="libraryInvoker">The library invoker containing the definitions.</param>
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
    public static IEnumerable<(DefinitionInvoker definitionInvoker, object? definitionResult)> EnumerateLibraryDefinitionsResults(
        this LibraryInvoker libraryInvoker,
        CqlContext cqlContext,
        Func<DefinitionInvoker, bool>? includeDefinition = null,
        ValueExceptionHandler<DefinitionInvoker>? definitionInvocationExceptionCallback = null)
    {
        var logger = libraryInvoker.LibrarySetInvoker.CreateLogger(typeof(LibraryInvokerExtensions));
        var continuation = libraryInvoker.LibrarySetInvoker.BatchProcessExceptionContinuation;
        includeDefinition ??= _ => true;

        return libraryInvoker.Definitions.Values
                             .Where(includeDefinition)
                             .TrySelect(
                                 definitionInvoker => (definitionInvoker, definitionInvoker.Invoke(cqlContext)),
                                 errorStrategy => errorStrategy
                                                  .SetContinuation(continuation)
                                                  .AddLoggerExceptionHandler(
                                                      logger,
                                                      (definitionInvoker, logMessage) =>
                                                          logMessage("Could not invoke definition {definition} on library {id}",
                                                                     definitionInvoker.DefinitionName, libraryInvoker.LibraryIdentifier))
                                                  .AddExceptionHandler(definitionInvocationExceptionCallback)
                             );
    }
}