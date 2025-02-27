/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Toolkit;

/// <summary>
/// Provides extension methods for toolkits.
/// </summary>
public static class ToolkitExtensions
{
    /// <summary>
    /// Configures the toolkit to ignore exceptions.
    /// </summary>
    /// <param name="toolkit">The toolkit instance.</param>
    /// <param name="breakAfterFirstException">If set to <c>true</c>, breaks the enumeration after the first exception; otherwise, continues.</param>
    /// <returns>The toolkit instance.</returns>
    public static TSelf SetIgnoreEnumerationExceptions<TSelf>(this IToolkit<TSelf> toolkit, bool breakAfterFirstException = false)
        where TSelf : IToolkit<TSelf> =>
        toolkit.SetBatchProcessExceptionContinuation(breakAfterFirstException ? BatchProcessExceptionContinuation.Break : BatchProcessExceptionContinuation.Continue);

    /// <summary>
    /// Configures the toolkit to throw exceptions.
    /// </summary>
    /// <param name="toolkit">The toolkit instance.</param>
    /// <returns>The toolkit instance.</returns>
    public static TSelf SetThrowEnumerationExceptions<TSelf>(this IToolkit<TSelf> toolkit)
        where TSelf : IToolkit<TSelf> =>
        toolkit.SetBatchProcessExceptionContinuation(BatchProcessExceptionContinuation.Throw);

    /// <summary>
    /// Creates a new <see cref="ILogger"/> instance using the full name of the given <paramref name="type"/>.
    /// </summary>
    /// <param name="toolkit">The toolkit instance.</param>
    /// <param name="type">The category will use this type's full name.</param>
    /// <returns>An <see cref="ILogger"/> instance.</returns>
    internal static ILogger CreateLogger(this IToolkit toolkit, Type type) =>
        toolkit.LoggerFactory.CreateLogger(type);

    /// <summary>
    /// Creates a new <see cref="ILogger"/> instance using the full name of the given <typeparamref name="TCategory"/>.
    /// </summary>
    /// <typeparam name="TCategory">The category will use this type's full name.</typeparam>
    /// <param name="toolkit">The toolkit instance.</param>
    /// <returns>An <see cref="ILogger"/> instance.</returns>
    internal static ILogger CreateLogger<TCategory>(this IToolkit toolkit) =>
        toolkit.LoggerFactory.CreateLogger<TCategory>();
}
