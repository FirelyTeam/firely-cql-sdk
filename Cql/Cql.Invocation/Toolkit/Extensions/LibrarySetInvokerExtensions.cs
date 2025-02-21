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
    /// <returns>An enumerable of tuples containing the library invoker, definition invoker, and a function to get the result.</returns>
    public static IEnumerable<(LibraryInvoker libraryInvoker, DefinitionInvoker definitionInvoker, Func<object?> getResult)> EnumerateLibrarySetDefinitionsResults(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext)
    {
        foreach (var libraryInvoker in librarySetInvoker.LibraryInvokers.Values)
            foreach (var (definition, getResult) in libraryInvoker.EnumerateLibraryDefinitionsResults(cqlContext))
                yield return (libraryInvoker, definition, getResult);
    }

    /// <summary>
    /// Enumerates the results of all definitions in a specific library.
    /// </summary>
    /// <param name="librarySetInvoker">The library set invoker.</param>
    /// <param name="cqlContext">The CQL context.</param>
    /// <param name="libraryIdentifier">The identifier of the library.</param>
    /// <returns>An enumerable of tuples containing the library invoker, definition invoker, and a function to get the result.</returns>
    public static IEnumerable<(LibraryInvoker libraryInvoker, DefinitionInvoker definitionInvoker, Func<object?> getResult)> EnumerateLibraryDefinitionsResults(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext,
        CqlVersionedLibraryIdentifier libraryIdentifier)
    {
        var libraryInvoker = librarySetInvoker.LibraryInvokers[libraryIdentifier];
        foreach (var (definitionInvoker, getResult) in libraryInvoker.EnumerateLibraryDefinitionsResults(cqlContext))
            yield return (libraryInvoker, definitionInvoker, getResult);
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
