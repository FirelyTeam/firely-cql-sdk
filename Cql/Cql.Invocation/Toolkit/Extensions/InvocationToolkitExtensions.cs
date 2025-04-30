/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="InvocationToolkit"/> class.
/// </summary>
public static partial class InvocationToolkitExtensions
{
    public static void UseLibrarySetInvoker(
        this InvocationToolkit invocationToolkit,
        Action<LibrarySetInvoker> useLibrarySetInvoker,
        string librarySetName = "")
    {
        using var librarySetInvoker = invocationToolkit.CreateLibrarySetInvoker(librarySetName);
        useLibrarySetInvoker(librarySetInvoker);
    }

    private static ILogger CreateLogger(this InvocationToolkit invocationToolkit)
    {
        return invocationToolkit.LoggerFactory.CreateLogger(typeof(InvocationToolkitExtensions));
    }
}