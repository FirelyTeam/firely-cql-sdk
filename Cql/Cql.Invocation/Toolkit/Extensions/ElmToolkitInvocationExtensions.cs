/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="ElmToolkit"/> class.
/// </summary>
public static class ElmToolkitInvocationExtensions
{
    /// <summary>
    /// Creates an <see cref="InvocationToolkit"/> from the specified <see cref="ElmToolkit"/>.
    /// </summary>
    /// <param name="elmToolkit">The <see cref="ElmToolkit"/> instance to use.</param>
    /// <returns>An <see cref="InvocationToolkit"/> instance.</returns>
    public static InvocationToolkit CreateInvocationToolkit(
        this ElmToolkit elmToolkit)
    {
        var assemblyBinaries =
            elmToolkit.GetElmToAssemblyResults().Select(t => t.GetAssemblyBinary());

        var invocationToolkit = new InvocationToolkit(elmToolkit.LoggerFactory, elmToolkit.BatchProcessExceptionContinuation)
            .AddAssemblyBinaries(assemblyBinaries);
        return invocationToolkit;
    }

    /// <summary>
    /// Creates a <see cref="LibrarySetInvoker"/> from the specified <see cref="ElmToolkit"/>.
    /// </summary>
    /// <param name="elmToolkit">The <see cref="ElmToolkit"/> instance to use.</param>
    /// <param name="name">The name of the <see cref="LibrarySetInvoker"/>. Default is an empty string.</param>
    /// <returns>A <see cref="LibrarySetInvoker"/> instance.</returns>
    public static LibrarySetInvoker CreateLibrarySetInvoker(
        this ElmToolkit elmToolkit,
        string name = "") =>
        elmToolkit
            .CompileToAssemblies()
            .CreateInvocationToolkit()
            .CreateLibrarySetInvoker(name);
}
