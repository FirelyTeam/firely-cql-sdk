/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

/// <summary>
/// Provides predefined filters for selecting definitions from a CQL library using a functional approach.
/// </summary>
public static class DefinitionPredicates
{
    /// <summary>
    /// Select definitions of type expression exactly (default).
    /// Excludes function definitions.
    /// </summary>
    public static DefinitionPredicate ExpressionsOnly { get; } = definitionInvoker =>
        // Match on exact type, so we do not include CqlFunctionDefinitionAttribute which derives from CqlExpressionDefinitionAttribute
        definitionInvoker.CqlDefinitionAttribute.GetType() == typeof(CqlExpressionDefinitionAttribute);

    /// <summary>
    /// Select definitions of type expression or function.
    /// Note that functions may have zero or more parameters, so special handling is needed when getting results by providing values to them in
    /// <see cref="DefinitionInvokerExtensions.SelectResults"/>.
    /// </summary>
    public static DefinitionPredicate ExpressionsAndFunctions { get; } = definitionInvoker =>
        definitionInvoker.CqlDefinitionAttribute is CqlExpressionDefinitionAttribute;

    /// <summary>
    /// Select definitions of type function.
    /// Note that functions may have zero or more parameters, so special handling is needed when getting results by providing values to them in
    /// <see cref="DefinitionInvokerExtensions.SelectResults"/>.
    /// </summary>
    public static DefinitionPredicate FunctionsOnly { get; } = definitionInvoker =>
        definitionInvoker.CqlDefinitionAttribute is CqlFunctionDefinitionAttribute;

    internal static bool IsExpressionFilter(DefinitionPredicate filter) =>
        filter == ExpressionsOnly
        || filter == FunctionsOnly
        || filter == ExpressionsAndFunctions;
}

/// <summary>
/// Represents a method that defines a filter to determine whether a given definition should be included or processed.
/// </summary>
///
/// <param name="definitionInvoker">An object that provides context or metadata about the definition being evaluated.</param>
///
/// <returns><see langword="true"/> if the definition meets the criteria specified by the filter; otherwise, <see
/// langword="false"/>.</returns>
public delegate bool DefinitionPredicate(DefinitionInvoker definitionInvoker);

