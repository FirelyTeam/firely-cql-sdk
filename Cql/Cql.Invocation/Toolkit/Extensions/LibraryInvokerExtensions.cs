/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

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
    /// <returns>An enumeration of tuples containing the definition invoker and the result.</returns>
    public static IEnumerable<(DefinitionInvoker definitionInvoker, object? definitionResult)> EnumerateLibraryDefinitionsResults(
        this LibraryInvoker libraryInvoker,
        CqlContext cqlContext)
    {
        var logger = libraryInvoker.LibrarySetInvoker.InvocationToolkit.LoggerFactory.CreateLogger(typeof(LibraryInvokerExtensions));
        var enumerationContinuation = libraryInvoker.LibrarySetInvoker.InvocationToolkit.Config.ErroredEnumerationContinuation;

        return libraryInvoker.Definitions.Values
                      .Where(definitionInvoker => definitionInvoker.ValueSetId is not null)
                      .TrySelect(
                          definitionInvoker => (definitionInvoker,definitionInvoker.Invoke(cqlContext)),
                          errorStrategy => errorStrategy
                                           .SetContinuation(enumerationContinuation)
                                           .AddLoggerExceptionHandler(
                                               logger,
                                               (definitionInvoker, logMessage) =>
                                                   logMessage("Could not invoke definition {definition} on library {id}", definitionInvoker.DefinitionName, libraryInvoker.LibraryIdentifier))
                          );
    }
}
