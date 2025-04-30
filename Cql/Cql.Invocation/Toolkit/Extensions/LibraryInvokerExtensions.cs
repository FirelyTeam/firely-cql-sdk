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
/// Provides extension methods for <see cref="LibraryInvoker"/>.
/// </summary>
public static class LibraryInvokerExtensions
{
    /// <summary>
    /// Enumerates the expressions in the library.
    /// </summary>
    /// <param name="libraryInvoker">The library invoker.</param>
    public static IEnumerable<DefinitionInvoker> SelectExpressions(
        this LibraryInvoker libraryInvoker) =>
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
}