/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
 
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;

namespace CqlSdkPrototype.Invocation.Extensions;

public static class ElmToolkitExtensions
{
    public static InvocationToolkit CreateInvocationToolkit(
        this ElmToolkit elmToolkit)
    {
        var assemblyBinaries =
            elmToolkit.GetElmToAssemblyResults().Select(t => t.GetAssemblyBinary());

        var invocationToolkit = new InvocationToolkit(elmToolkit.LoggerFactory).AddAssemblyBinaries(assemblyBinaries);
        return invocationToolkit;
    }

    public static LibrarySetInvoker CreateLibrarySetInvoker(
        this ElmToolkit elmToolkit,
        string name = "") =>
        elmToolkit
            .ConvertElmToAssemblies()
            .CreateInvocationToolkit()
            .CreateLibrarySetInvoker(name);
}
