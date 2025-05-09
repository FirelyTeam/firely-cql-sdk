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
    /// 
    /// </summary>
    /// <param name="libraryInvoker"></param>
    /// <param name="includeDefinitionsWithParameters"></param>
    /// <returns></returns>
    public static IEnumerable<DefinitionInvoker> SelectExpressions(
        this LibraryInvoker libraryInvoker,
        bool includeDefinitionsWithParameters = false) =>
        libraryInvoker
            .Definitions.Values
            .Where(definitionInvoker =>
                       definitionInvoker.ParameterTypes.Length == 0
                       && definitionInvoker.CqlDefinitionAttribute.GetType() == typeof(CqlExpressionDefinitionAttribute));

    /// <summary>
    /// Enumerates the functions in the library.
    /// </summary>
    /// <param name="libraryInvoker">The library invoker.</param>
    public static IEnumerable<DefinitionInvoker> SelectFunctions(
        this LibraryInvoker libraryInvoker) =>
        libraryInvoker
            .Definitions.Values
            .Where(definitionInvoker =>
                       definitionInvoker.CqlDefinitionAttribute.GetType() == typeof(CqlFunctionDefinitionAttribute));

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