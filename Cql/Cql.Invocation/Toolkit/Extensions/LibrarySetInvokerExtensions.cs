/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for <see cref="LibrarySetInvoker"/>.
/// </summary>
public static class LibrarySetInvokerExtensions
{
    /// <summary>
    /// Retrieves all expression definitions from the specified library set.
    /// Note that functions are excluded.
    /// </summary>
    ///
    /// <remarks>
    /// This method performs an exact type match on <see cref="CqlExpressionDefinitionAttribute"/>, excluding derived types such as <c>CqlFunctionDefinitionAttribute</c>.
    /// </remarks>
    ///
    /// <param name="librarySetInvoker">The <see cref="LibrarySetInvoker"/> containing the libraries with definitions to filter.</param>
    ///
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> objects whose
    /// <see cref="DefinitionInvoker.CqlDefinitionAttribute"/> is exactly of type <see cref="CqlExpressionDefinitionAttribute"/>.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectExpressions(
        this LibrarySetInvoker librarySetInvoker) =>
        librarySetInvoker
            .LibraryInvokers.Values
            .SelectMany(libraryInvoker => libraryInvoker.SelectExpressions());

    /// <summary>
    /// Retrieves all expression definitions from a particular library in the specified library set, matching it's <paramref name="libraryIdentifier"/>.
    /// Note that functions are excluded.
    /// </summary>
    ///
    /// <remarks>
    /// This method performs an exact type match on <see cref="CqlExpressionDefinitionAttribute"/>, excluding derived types such as <c>CqlFunctionDefinitionAttribute</c>.
    /// </remarks>
    ///
    /// <param name="librarySetInvoker">The <see cref="LibrarySetInvoker"/> containing the libraries with definitions to filter.</param>
    ///
    /// <param name="libraryIdentifier">The <see cref="CqlVersionedLibraryIdentifier"/> with the name of the library to select from the library set.</param>
    ///
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> objects whose
    /// <see cref="DefinitionInvoker.CqlDefinitionAttribute"/> is exactly of type <see cref="CqlExpressionDefinitionAttribute"/>.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectExpressionsForLibrary(
        this LibrarySetInvoker librarySetInvoker,
        CqlVersionedLibraryIdentifier libraryIdentifier) =>
        librarySetInvoker.LibraryInvokers.TryGetValue(libraryIdentifier, out var libraryInvoker)
            ? libraryInvoker.SelectExpressions()
            : [];

    /// <summary>
    /// Retrieves all function definitions from the specified library set.
    /// Note that functions may have zero or more parameters, so special handling is needed when getting results by providing values to them in
    /// <see cref="DefinitionInvokerExtensions.SelectResults"/>.
    /// </summary>
    ///
    /// <remarks>
    /// This method selects definitions from the library where the associated <see cref="CqlDefinitionAttribute"/> is of type <see cref="CqlFunctionDefinitionAttribute"/>.
    /// </remarks>
    ///
    /// <param name="librarySetInvoker">The <see cref="LibrarySetInvoker"/> containing the libraries with definitions to filter.</param>
    ///
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> objects representing the function definitions from each library.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectFunctions(
        this LibrarySetInvoker librarySetInvoker) =>
        librarySetInvoker
            .LibraryInvokers.Values
            .SelectMany(libraryInvoker => libraryInvoker.SelectFunctions());

    /// /// <summary>
    /// Retrieves all function definitions from a particular library in the specified library set, matching it's <paramref name="libraryIdentifier"/>.
    /// Note that functions may have zero or more parameters, so special handling is needed when getting results by providing values to them in
    /// <see cref="DefinitionInvokerExtensions.SelectResults"/>.
    /// </summary>
    ///
    /// <remarks>
    /// This method selects definitions from each library where the associated <see cref="CqlDefinitionAttribute"/> is of type <see cref="CqlFunctionDefinitionAttribute"/>.
    /// </remarks>
    ///
    /// <param name="librarySetInvoker">The <see cref="LibrarySetInvoker"/> containing the libraries with definitions to filter.</param>
    ///
    /// <param name="libraryIdentifier">The <see cref="CqlVersionedLibraryIdentifier"/> with the name of the library to select from the library set.</param>
    ///
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> objects representing the function definitions for the selected library.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectFunctionsForLibrary(
        this LibrarySetInvoker librarySetInvoker,
        CqlVersionedLibraryIdentifier libraryIdentifier) =>
        librarySetInvoker.LibraryInvokers.TryGetValue(libraryIdentifier, out var libraryInvoker)
            ? libraryInvoker.SelectFunctions()
            : [];

    /// <summary>
    /// Retrieves all expression and function definitions from the specified library set.
    /// Note that functions may have zero or more parameters, so special handling is needed when getting results by providing values to them in
    /// <see cref="DefinitionInvokerExtensions.SelectResults"/>.
    /// </summary>
    ///
    /// <remarks>
    /// This method selects definitions from each library where the associated <see cref="CqlDefinitionAttribute"/> is of type <see cref="CqlExpressionDefinitionAttribute"/>.
    /// </remarks>
    ///
    /// <param name="librarySetInvoker">The <see cref="LibrarySetInvoker"/> containing the libraries with definitions to filter.</param>
    ///
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> objects representing the expression and function definitions from each library.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectExpressionsAndFunctions(
        this LibrarySetInvoker librarySetInvoker) =>
        librarySetInvoker
            .LibraryInvokers.Values
            .SelectMany(libraryInvoker => libraryInvoker.SelectExpressionsAndFunctions());

    /// /// <summary>
    /// Retrieves all expression and function definitions from a particular library in the specified library set, matching it's <paramref name="libraryIdentifier"/>.
    /// Note that functions may have zero or more parameters, so special handling is needed when getting results by providing values to them in
    /// <see cref="DefinitionInvokerExtensions.SelectResults"/>.
    /// </summary>
    ///
    /// <remarks>
    /// This method selects definitions from the library where the associated <see cref="CqlDefinitionAttribute"/> is of type <see cref="CqlExpressionDefinitionAttribute"/>.
    /// </remarks>
    ///
    /// <param name="librarySetInvoker">The <see cref="LibrarySetInvoker"/> containing the libraries with definitions to filter.</param>
    ///
    /// <param name="libraryIdentifier">The <see cref="CqlVersionedLibraryIdentifier"/> with the name of the library to select from the library set.</param>
    ///
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> objects representing the expression and function definitions for the selected library.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectExpressionsAndFunctionsForLibrary(
        this LibrarySetInvoker librarySetInvoker,
        CqlVersionedLibraryIdentifier libraryIdentifier) =>
        librarySetInvoker.LibraryInvokers.TryGetValue(libraryIdentifier, out var libraryInvoker)
            ? libraryInvoker.SelectExpressionsAndFunctions()
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