/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Runtime;

namespace CoreTests;

internal static class LibraryInvokerTestExtensions
{
    /// <summary>
    /// Invokes the delegate <paramref name="define"/> in <paramref name="libraryName"/> with <paramref name="parameters"/>.
    /// </summary>
    /// <typeparam name="T">The expected return type of the delegate.</typeparam>
    /// <param name="libraryInvoker">The delegates containing this definition.</param>
    /// <param name="define">The name of the definition.</param>
    /// <param name="rtx">The runtime context to use for the execution.</param>
    /// <param name="parameters">The definition's parameters, excluding <paramref name="rtx"/>.</param>
    /// <returns></returns>
    public static T? Invoke<T>(
        this LibraryInvoker libraryInvoker,
        string define,
        CqlContext rtx,
        params object[] parameters)
    {
        var parameterTypes = parameters.Select(p => p.GetType()).ToArray();
        var definitionSignature = new DefinitionSignature(define, parameterTypes);
        var definition = libraryInvoker.Definitions[definitionSignature];
        var resultObj = definition.Invoke(rtx, parameters);
        var result = (T?)resultObj;
        return result;
    }

}
