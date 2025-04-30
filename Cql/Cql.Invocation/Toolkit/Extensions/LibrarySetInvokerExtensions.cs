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
    /// Enumerates the expressions in the library set.
    /// </summary>
    /// <param name="librarySetInvoker">The library set invoker of which to enumerate expressions for all libraries.</param>
    public static IEnumerable<DefinitionInvoker> SelectExpressions(
        this LibrarySetInvoker librarySetInvoker) =>
        librarySetInvoker
            .LibraryInvokers.Values
            .SelectMany(libraryInvoker => libraryInvoker.SelectExpressions());

    /// <summary>
    /// Enumerates the functions in the library set.
    /// </summary>
    /// <param name="librarySetInvoker">The library set invoker of which to enumerate functions for all libraries.</param>
    public static IEnumerable<DefinitionInvoker> SelectFunctions(
        this LibrarySetInvoker librarySetInvoker) =>
        librarySetInvoker
            .LibraryInvokers.Values
            .SelectMany(libraryInvoker => libraryInvoker.SelectFunctions());

    /// <summary>
    /// Enumerates the definitions in the library set.
    /// </summary>
    /// <param name="librarySetInvoker">The library set invoker.</param>
    /// <param name="libraryIdentifier">The library on which definitions enumerated.</param>
    public static IEnumerable<DefinitionInvoker> SelectExpressionsForLibrary(
        this LibrarySetInvoker librarySetInvoker,
        CqlVersionedLibraryIdentifier libraryIdentifier) =>
        librarySetInvoker.LibraryInvokers.TryGetValue(libraryIdentifier, out var libraryInvoker)
            ? libraryInvoker.SelectExpressions()
            : [];

    /// <summary>
    /// Gets the result of a specific definition in a specific library.
    /// </summary>
    /// <param name="librarySetInvoker">The library set invoker.</param>
    /// <param name="cqlContext">The CQL context.</param>
    /// <param name="libraryIdentifier">The identifier of the library.</param>
    /// <param name="definitionSignature">The name of the definition with its associated parameter types.</param>
    /// <param name="args">Any additional arguments for the invocation (typically when calling a function definition).</param>
    /// <returns>The result of the definition invocation.</returns>
    [DebuggerStepperBoundary]
    public static object? InvokeLibraryDefinition(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        DefinitionSignature definitionSignature,
        params object?[] args)
    {
        var libraryInvoker = librarySetInvoker.LibraryInvokers[libraryIdentifier];
        var definitionInvoker = libraryInvoker.Definitions[definitionSignature];
        var result = definitionInvoker.Invoke(cqlContext, args);
        return result;
    }
}