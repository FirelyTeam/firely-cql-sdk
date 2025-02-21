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
/// Provides extension methods for <see cref="LibraryInvoker"/>.
/// </summary>
public static class LibraryInvokerExtensions
{
    /// <summary>
    /// Enumerates the results of library definitions.
    /// </summary>
    /// <param name="libraryInvoker">The library invoker containing the definitions.</param>
    /// <param name="cqlContext">The CQL context used for invocation.</param>
    /// <returns>An enumerable of tuples containing the definition invoker and a function to get the result.</returns>
    public static IEnumerable<(DefinitionInvoker definitionInvoker, Func<object?> getResult)> EnumerateLibraryDefinitionsResults(
        this LibraryInvoker libraryInvoker,
        CqlContext cqlContext)
    {
        foreach (var definitionInvoker in libraryInvoker.Definitions.Values)
        {
            if (definitionInvoker.ValueSetId is not null)
                continue;

            yield return (definitionInvoker,
                             () =>
                             {
                                 var result = definitionInvoker.Invoke(cqlContext);
                                 return result;
                             }
            );
        }
    }
}
