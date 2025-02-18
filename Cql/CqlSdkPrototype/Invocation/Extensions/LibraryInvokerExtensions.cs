/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
 
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Invocation.Extensions;

public static class LibraryInvokerExtensions
{
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
