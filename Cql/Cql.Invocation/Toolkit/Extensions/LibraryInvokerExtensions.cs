/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Primitives;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for <see cref="LibraryInvoker"/>.
/// </summary>
public static class LibraryInvokerExtensions
{
    /// <summary>
    /// Retrieves expression definitions from the specified library based on the provided filter criteria.
    /// </summary>
    ///
    /// <remarks>
    /// <para>
    /// This method filters definitions based on the specified <paramref name="filter"/> function:
    /// </para>
    /// <list type="bullet">
    /// <item><description><see cref="DefinitionPredicates.ExpressionsOnly"/> (default): Performs an exact type match on <see cref="CqlExpressionDefinitionAttribute"/>, excluding derived types such as <c>CqlFunctionDefinitionAttribute</c>.</description></item>
    /// <item><description><see cref="DefinitionPredicates.FunctionsOnly"/>: Selects definitions where the associated <see cref="CqlDefinitionAttribute"/> is of type <see cref="CqlFunctionDefinitionAttribute"/>.</description></item>
    /// <item><description><see cref="DefinitionPredicates.ExpressionsAndFunctions"/>: Selects definitions where the associated <see cref="CqlDefinitionAttribute"/> is of type <see cref="CqlExpressionDefinitionAttribute"/> or any derived type.</description></item>
    /// </list>
    /// <para>
    /// When using <see cref="DefinitionPredicates.FunctionsOnly"/> or <see cref="DefinitionPredicates.ExpressionsAndFunctions"/>,
    /// note that functions may have zero or more parameters, so special handling is needed when getting results by providing values to them in
    /// <see cref="DefinitionInvokerExtensions.SelectResults"/>.
    /// </para>
    /// <para>
    /// You can also provide a custom filter function to implement your own filtering logic.
    /// </para>
    /// </remarks>
    ///
    /// <param name="libraryInvoker">The <see cref="LibraryInvoker"/> containing the definitions to filter.</param>
    /// <param name="filter">The filter function to apply. Defaults to <see cref="DefinitionPredicates.ExpressionsOnly"/> if not provided.</param>
    ///
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> objects that match the specified filter criteria.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectExpressions(
        this LibraryInvoker libraryInvoker,
        DefinitionPredicate? filter = null) =>
        libraryInvoker.SelectDefinitions().Where(CalcExpressionPredicate(filter));

    private static Func<DefinitionInvoker, bool> CalcExpressionPredicate(DefinitionPredicate? filter)
    {
        if (filter is null)
            return DefinitionPredicates.ExpressionsOnly.Invoke;

        // Return our own filters as-is
        if (DefinitionPredicates.IsExpressionFilter(filter))
            return filter.Invoke;

        // Combine the custom filter
        return def => DefinitionPredicates.ExpressionsAndFunctions(def) && filter(def);
    }

    /// <summary>
    /// Retrieves expression definitions from the specified library.
    /// </summary>
    ///
    /// <param name="libraryInvoker">The <see cref="LibraryInvoker"/> containing the definitions .</param>
    ///
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> objects.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectDefinitions(
        this LibraryInvoker libraryInvoker) =>
        libraryInvoker.Definitions.Values;

    /// <summary>
    /// Enumerates the value sets in the library.
    /// </summary>
    /// <param name="libraryInvoker">The library invoker.</param>
    public static IEnumerable<(DefinitionInvoker definition, CqlValueSet valueSet)> SelectValueSets(
        this LibraryInvoker libraryInvoker) =>
        libraryInvoker
            .SelectDefinitions()
            .SelectWhere(definitionInvoker => definitionInvoker.CqlDefinitionAttribute is CqlValueSetDefinitionAttribute attr
                ? (true, (definitionInvoker, new CqlValueSet(attr.ValueSetId, attr.ValueSetVersion)))
                : default);

    /// <summary>
    /// Enumerates the codes in the library.
    /// </summary>
    /// <param name="libraryInvoker">The library invoker.</param>
    public static IEnumerable<(DefinitionInvoker definition, CqlCode code)> SelectCodes(
        this LibraryInvoker libraryInvoker) =>
        libraryInvoker
            .SelectDefinitions()
            .SelectWhere(definitionInvoker => definitionInvoker.CqlDefinitionAttribute is CqlCodeDefinitionAttribute attr
                ? (true, (definitionInvoker, new CqlCode(attr.CodeId, attr.CodeSystem, attr.CodeVersion, attr.CodeDisplay)))
                : default);
}