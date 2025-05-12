/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for <see cref="LibrarySetInvoker"/>.
/// </summary>
public static class LibrarySetInvokerExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="librarySetInvoker"></param>
    /// <param name="includeDefinitionsWithParameters"></param>
    /// <returns></returns>
    public static IEnumerable<DefinitionInvoker> SelectExpressions(
        this LibrarySetInvoker librarySetInvoker,
        bool includeDefinitionsWithParameters = false) =>
        librarySetInvoker
            .LibraryInvokers.Values
            .SelectMany(libraryInvoker => libraryInvoker.SelectExpressions(includeDefinitionsWithParameters));

    /// <summary>
    /// Retrieves all function definitions from the libraries within the specified <see cref="LibrarySetInvoker"/>.
    /// </summary>
    /// <param name="librarySetInvoker">
    /// The <see cref="LibrarySetInvoker"/> instance containing the libraries to search for function definitions.
    /// </param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> representing the function definitions
    /// found in the libraries.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectFunctions(
        this LibrarySetInvoker librarySetInvoker) =>
        librarySetInvoker
            .LibraryInvokers.Values
            .SelectMany(libraryInvoker => libraryInvoker.SelectFunctions());

    /// <summary>
    /// Selects the expressions defined in the specified library from the <see cref="LibrarySetInvoker"/>.
    /// </summary>
    /// <param name="librarySetInvoker">
    /// The <see cref="LibrarySetInvoker"/> containing the library invokers.
    /// </param>
    /// <param name="libraryIdentifier">
    /// The identifier of the library whose expressions are to be selected.
    /// </param>
    /// <param name="includeDefinitionsWithParameters">
    /// A boolean value indicating whether to include definitions that have parameters.
    /// Defaults to <c>false</c>.
    /// </param>
    /// <returns>
    /// A collection of <see cref="DefinitionInvoker"/> instances representing the selected expressions.
    /// If the specified library is not found, an empty collection is returned.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectExpressionsForLibrary(
        this LibrarySetInvoker librarySetInvoker,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        bool includeDefinitionsWithParameters = false) =>
        librarySetInvoker.LibraryInvokers.TryGetValue(libraryIdentifier, out var libraryInvoker)
            ? libraryInvoker.SelectExpressions(includeDefinitionsWithParameters)
            : [];

    /// <summary>
    /// Invokes a library definition within the specified library set using the provided context, library identifier, 
    /// definition signature, and arguments.
    /// </summary>
    /// <param name="librarySetInvoker">
    /// The <see cref="LibrarySetInvoker"/> instance that contains the library set to invoke the definition from.
    /// </param>
    /// <param name="cqlContext">
    /// The <see cref="CqlContext"/> representing the execution context for the invocation.
    /// </param>
    /// <param name="libraryIdentifier">
    /// The <see cref="CqlVersionedLibraryIdentifier"/> identifying the library containing the definition to invoke.
    /// </param>
    /// <param name="definitionSignature">
    /// The <see cref="DefinitionSignature"/> representing the signature of the definition to invoke.
    /// </param>
    /// <param name="args">
    /// The arguments to pass to the definition during invocation.
    /// </param>
    /// <returns>
    /// The result of the library definition invocation, or <c>null</c> if the invocation does not produce a result.
    /// </returns>
    /// <exception cref="ArgumentException">
    /// Thrown when the number of provided arguments does not match the number of parameters in the definition signature,
    /// or when the arguments do not match the expected parameter types.
    /// </exception>
    [DebuggerStepThrough]
    public static object? InvokeLibraryDefinition(
        this LibrarySetInvoker librarySetInvoker,
        CqlContext cqlContext,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        DefinitionSignature definitionSignature,
        params object?[] args)
    {
        var libraryInvoker = librarySetInvoker.LibraryInvokers[libraryIdentifier];
        if (definitionSignature.ParameterTypes.Length is {} pLength
            && pLength != args.Length)
        {
            if (pLength != 0 || !args.All(a => a is not null))
                throw new ArgumentException("The arguments must be the same amount as the signature types.", nameof(args));

            // Let's be nice and allow the user to call a definition with no arguments, provided they are not null and match the signature types exactly.
            var signature = args.SelectToArray(a => a!.GetType().MakeNullable() );
            definitionSignature = new DefinitionSignature(definitionSignature.Name, signature);
        }
        var definitionInvoker = libraryInvoker.Definitions[definitionSignature];
        var result = definitionInvoker.Invoke(cqlContext, args);
        return result;
    }
}