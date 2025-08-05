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
    /// Retrieves all expression definitions from the specified library.
    /// Note that functions are excluded.
    /// </summary>
    ///
    /// <remarks>
    /// This method performs an exact type match on <see cref="CqlExpressionDefinitionAttribute"/>, excluding derived types such as <c>CqlFunctionDefinitionAttribute</c>.
    /// </remarks>
    ///
    /// <param name="libraryInvoker">The <see cref="LibraryInvoker"/> containing the definitions to filter.</param>
    ///
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> objects whose
    /// <see cref="DefinitionInvoker.CqlDefinitionAttribute"/> is exactly of type <see cref="CqlExpressionDefinitionAttribute"/>.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectExpressions(
        this LibraryInvoker libraryInvoker) =>
        libraryInvoker
            .Definitions.Values
            .Where(definitionInvoker =>
               // Match on exact type, so we do not include CqlFunctionDefinitionAttribute which derives from CqlExpressionDefinitionAttribute
               definitionInvoker.CqlDefinitionAttribute.GetType() == typeof(CqlExpressionDefinitionAttribute));

    /// <summary>
    /// Retrieves all function definitions from the specified library.
    /// Note that functions may have zero or more parameters, so special handling is needed when getting results by providing values to them in
    /// <see cref="DefinitionInvokerExtensions.SelectResults"/>.
    /// </summary>
    ///
    /// <remarks>
    /// This method selects definitions from the library where the associated <see cref="CqlDefinitionAttribute"/> is of type <see cref="CqlFunctionDefinitionAttribute"/>.
    /// </remarks>
    ///
    /// <param name="libraryInvoker">The <see cref="LibraryInvoker"/> instance containing the definitions to filter.</param>
    ///
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> objects representing the function definitions in the library.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectFunctions(
        this LibraryInvoker libraryInvoker) =>
        libraryInvoker
            .Definitions.Values
            .Where(definitionInvoker => definitionInvoker.CqlDefinitionAttribute is CqlFunctionDefinitionAttribute);

    /// <summary>
    /// Retrieves all expression and function definitions from the specified library.
    /// Note that functions may have zero or more parameters, so special handling is needed when getting results by providing values to them in
    /// <see cref="DefinitionInvokerExtensions.SelectResults"/>.
    /// </summary>
    ///
    /// <remarks>
    /// This method selects definitions from the library where the associated <see cref="CqlDefinitionAttribute"/> is of type <see cref="CqlExpressionDefinitionAttribute"/>.
    /// </remarks>
    ///
    /// <param name="libraryInvoker">The <see cref="LibraryInvoker"/> instance containing the definitions to filter.</param>
    ///
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="DefinitionInvoker"/> objects representing the expression and function definitions in the library.
    /// </returns>
    public static IEnumerable<DefinitionInvoker> SelectExpressionsAndFunctions(
        this LibraryInvoker libraryInvoker) =>
        libraryInvoker
            .Definitions.Values
            .Where(definitionInvoker => definitionInvoker.CqlDefinitionAttribute is CqlExpressionDefinitionAttribute);

    /// <summary>
    /// Enumerates the value sets in the library.
    /// </summary>
    /// <param name="libraryInvoker">The library invoker.</param>
    public static IEnumerable<(DefinitionInvoker definition, CqlValueSet valueSet)> SelectValueSets(
        this LibraryInvoker libraryInvoker) =>
        libraryInvoker
            .Definitions.Values
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
            .Definitions.Values
            .SelectWhere(definitionInvoker => definitionInvoker.CqlDefinitionAttribute is CqlCodeDefinitionAttribute attr
                ? (true, (definitionInvoker, new CqlCode(attr.CodeId, attr.CodeSystem, attr.CodeVersion, attr.CodeDisplay)))
                : default);
}