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
    /// <returns>An enumeration of tuples containing the library invoker, definition invoker, and the definition result.</returns>
    ///
    /// <remarks>
    /// <para>
    /// Exceptions are enriched such that the last <see cref="DefinitionInvoker"/> that caused
    /// the exception is available when inspecting the <see cref="Exception.Data">Exception.Data["Current"]</see> property.
    /// </para>
    ///
    /// <para>
    /// From the <see cref="DefinitionInvoker"/> it is possible which library and library set it belongs to via
    /// <see cref="DefinitionInvoker.LibraryInvoker"/> and <see cref="LibraryInvoker.LibrarySetInvoker"/>.
    /// </para>
    /// </remarks>
    public static IEnumerable<(DefinitionInvoker definitionInvoker, object? definitionResult)> EnumerateLibrarySetDefinitionsResults(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext,
        Func<DefinitionInvoker, bool>? includeDefinition = null,
        ValueExceptionHandler<DefinitionInvoker>? definitionInvocationExceptionCallback = null)
    {
        foreach (var libraryInvoker in librarySetInvoker.LibraryInvokers.Values)
            foreach (var (definition, definitionResult) in libraryInvoker.EnumerateLibraryDefinitionsResults(cqlContext, includeDefinition, definitionInvocationExceptionCallback))
                yield return (definition, definitionResult);
    }

    /// <summary>
    /// Enumerates the results of all definitions in the library set.
    /// </summary>
    /// <param name="librarySetInvoker">The library set invoker.</param>
    /// <param name="cqlContext">The CQL context.</param>
    /// <param name="libraryIdentifier">The library on which definitions are run on.</param>
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
    /// <returns>An enumeration of tuples containing the library invoker, definition invoker, and the definition result.</returns>
    ///
    /// <remarks>
    /// <para>
    /// Exceptions are enriched such that the last <see cref="DefinitionInvoker"/> that caused
    /// the exception is available when inspecting the <see cref="Exception.Data">Exception.Data["Current"]</see> property.
    /// </para>
    ///
    /// <para>
    /// From the <see cref="DefinitionInvoker"/> it is possible which library and library set it belongs to via
    /// <see cref="DefinitionInvoker.LibraryInvoker"/> and <see cref="LibraryInvoker.LibrarySetInvoker"/>.
    /// </para>
    /// </remarks>
    public static IEnumerable<(DefinitionInvoker definitionInvoker, object? definitionResult)> EnumerateLibraryDefinitionsResults(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        Func<DefinitionInvoker, bool>? includeDefinition = null,
        ValueExceptionHandler<DefinitionInvoker>? definitionInvocationExceptionCallback = null)
    {
        if (librarySetInvoker.LibraryInvokers.GetValueOrDefault(libraryIdentifier) is { } libraryInvoker)
        {
            foreach (var (definition, definitionResult) in libraryInvoker.EnumerateLibraryDefinitionsResults(cqlContext, includeDefinition, definitionInvocationExceptionCallback))
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
