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
    /// <summary>
    /// Configures and utilizes a <see cref="LibrarySetInvoker"/> for the specified <see cref="InvocationToolkit"/> instance.
    /// </summary>
    /// <param name="invocationToolkit">
    /// The <see cref="InvocationToolkit"/> instance to configure and use the <see cref="LibrarySetInvoker"/>.
    /// </param>
    /// <param name="useLibrarySetInvoker">
    /// An action to perform with the configured <see cref="LibrarySetInvoker"/>.
    /// </param>
    /// <param name="librarySetName">
    /// The name of the library set to be invoked. Defaults to an empty string.
    /// </param>
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