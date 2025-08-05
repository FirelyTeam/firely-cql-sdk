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
    /// Retrieves definitions from the specified library set based on the provided filter criteria.
    /// </summary>
    ///
    /// <remarks>
    /// <para>
    /// This method filters definitions based on the specified <paramref name="filter"/>:
    /// </para>
    /// <list type="bullet">
    /// <item><description><see cref="DefinitionFilter.ExpressionsOnly"/> (default): Performs an exact type match on <see cref="CqlExpressionDefinitionAttribute"/>, excluding derived types such as <c>CqlFunctionDefinitionAttribute</c>.</description></item>
    /// <item><description><see cref="DefinitionFilter.FunctionsOnly"/>: Selects definitions where the associated <see cref="CqlDefinitionAttribute"/> is of type <see cref="CqlFunctionDefinitionAttribute"/>.</description></item>
    /// <item><description><see cref="DefinitionFilter.ExpressionsAndFunctions"/>: Selects definitions where the associated <see cref="CqlDefinitionAttribute"/> is of type <see cref="CqlExpressionDefinitionAttribute"/> or any derived type.</description></item>
    /// </list>
    /// <para>
    /// When using <see cref="DefinitionFilter.FunctionsOnly"/> or <see cref="DefinitionFilter.ExpressionsAndFunctions"/>, 
    /// note that functions may have zero or more parameters, so special handling is needed when getting results by providing values to them in
    /// <see cref="DefinitionInvokerExtensions.SelectResults"/>.
    /// </para>
    /// </remarks>
    ///
    /// <param name="librarySetInvoker">The <see cref="LibrarySetInvoker"/> containing the libraries with definitions to filter.</param>
    /// <param name="filter">The filter criteria to apply. Defaults to <see cref="DefinitionFilter.ExpressionsOnly"/>.</param>
    ///
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> objects that match the specified filter criteria.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectExpressions(
        this LibrarySetInvoker librarySetInvoker,
        DefinitionFilter filter = DefinitionFilter.ExpressionsOnly) =>
        librarySetInvoker
            .LibraryInvokers.Values
            .SelectMany(libraryInvoker => libraryInvoker.SelectExpressions(filter));

    /// <summary>
    /// Retrieves definitions from a particular library in the specified library set, matching its <paramref name="libraryIdentifier"/> and based on the provided filter criteria.
    /// </summary>
    ///
    /// <remarks>
    /// <para>
    /// This method filters definitions based on the specified <paramref name="filter"/>:
    /// </para>
    /// <list type="bullet">
    /// <item><description><see cref="DefinitionFilter.ExpressionsOnly"/> (default): Performs an exact type match on <see cref="CqlExpressionDefinitionAttribute"/>, excluding derived types such as <c>CqlFunctionDefinitionAttribute</c>.</description></item>
    /// <item><description><see cref="DefinitionFilter.FunctionsOnly"/>: Selects definitions where the associated <see cref="CqlDefinitionAttribute"/> is of type <see cref="CqlFunctionDefinitionAttribute"/>.</description></item>
    /// <item><description><see cref="DefinitionFilter.ExpressionsAndFunctions"/>: Selects definitions where the associated <see cref="CqlDefinitionAttribute"/> is of type <see cref="CqlExpressionDefinitionAttribute"/> or any derived type.</description></item>
    /// </list>
    /// <para>
    /// When using <see cref="DefinitionFilter.FunctionsOnly"/> or <see cref="DefinitionFilter.ExpressionsAndFunctions"/>, 
    /// note that functions may have zero or more parameters, so special handling is needed when getting results by providing values to them in
    /// <see cref="DefinitionInvokerExtensions.SelectResults"/>.
    /// </para>
    /// </remarks>
    ///
    /// <param name="librarySetInvoker">The <see cref="LibrarySetInvoker"/> containing the libraries with definitions to filter.</param>
    /// <param name="libraryIdentifier">The <see cref="CqlVersionedLibraryIdentifier"/> with the name of the library to select from the library set.</param>
    /// <param name="filter">The filter criteria to apply. Defaults to <see cref="DefinitionFilter.ExpressionsOnly"/>.</param>
    ///
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> objects that match the specified filter criteria.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectExpressionsForLibrary(
        this LibrarySetInvoker librarySetInvoker,
        CqlVersionedLibraryIdentifier libraryIdentifier,
        DefinitionFilter filter = DefinitionFilter.ExpressionsOnly) =>
        librarySetInvoker.LibraryInvokers.TryGetValue(libraryIdentifier, out var libraryInvoker)
            ? libraryInvoker.SelectExpressions(filter)
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