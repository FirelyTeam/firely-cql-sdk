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
/// Provides extension methods for <see cref="LibrarySetInvoker"/>.
/// </summary>
public static class LibrarySetInvokerExtensions
{
    /// <summary>
    /// Enumerates the results of all definitions in the library set.
    /// </summary>
    /// <param name="librarySetInvoker">The library set invoker.</param>
    /// <param name="cqlContext">The CQL context.</param>
    /// <param name="includeDefinition">The selector for the definition</param>
    /// <param name="definitionInvokerExceptionHandler">An exception handler for invoking a definition. (optional)</param>
    /// <returns>An enumeration of tuples containing the library invoker, definition invoker, and the definition result.</returns>
    public static IEnumerable<(DefinitionInvoker definitionInvoker, object? definitionResult)> EnumerateLibrarySetDefinitionsResults(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext,
        Func<DefinitionInvoker, bool>? includeDefinition = null,
        ValueExceptionHandler<DefinitionInvoker>? definitionInvokerExceptionHandler = null)
    {
        foreach (var libraryInvoker in librarySetInvoker.LibraryInvokers.Values)
            foreach (var (definition, definitionResult) in libraryInvoker.EnumerateLibraryDefinitionsResults(cqlContext, includeDefinition, definitionInvokerExceptionHandler))
                yield return (definition, definitionResult);
    }

    /// <summary>
    /// Enumerates the results of all definitions in the library set.
    /// </summary>
    /// <param name="librarySetInvoker">The library set invoker.</param>
    /// <param name="cqlContext">The CQL context.</param>
    /// <param name="libraryIdentifier">The library on which definitions are run on.</param>
    /// <param name="includeDefinition">The selector for the definition</param>
    /// <param name="definitionInvokerExceptionHandler">An exception handler for invoking a definition. (optional)</param>
    /// <returns>An enumeration of tuples containing the library invoker, definition invoker, and the definition result.</returns>
    public static IEnumerable<(DefinitionInvoker definitionInvoker, object? definitionResult)> EnumerateLibraryDefinitionsResults(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        Func<DefinitionInvoker, bool>? includeDefinition = null,
        ValueExceptionHandler<DefinitionInvoker>? definitionInvokerExceptionHandler = null)
    {
        if (librarySetInvoker.LibraryInvokers.GetValueOrDefault(libraryIdentifier) is { } libraryInvoker)
        {
            foreach (var (definition, definitionResult) in libraryInvoker.EnumerateLibraryDefinitionsResults(cqlContext, includeDefinition, definitionInvokerExceptionHandler))
                yield return (definition, definitionResult);
        }
    }

    /// <summary>
    /// Gets the result of a specific definition in a specific library.
    /// </summary>
    /// <param name="librarySetInvoker">The library set invoker.</param>
    /// <param name="cqlContext">The CQL context.</param>
    /// <param name="libraryIdentifier">The identifier of the library.</param>
    /// <param name="definitionName">The name of the definition.</param>
    /// <returns>The result of the definition invocation.</returns>
    public static object? GetLibraryDefinitionResult(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        string definitionName)
    {
        var libraryInvoker = librarySetInvoker.LibraryInvokers[libraryIdentifier];
        var libraryDefinitionInvoker = libraryInvoker.Definitions[definitionName];
        var result = libraryDefinitionInvoker.Invoke(cqlContext);
        return result;
    }
}
