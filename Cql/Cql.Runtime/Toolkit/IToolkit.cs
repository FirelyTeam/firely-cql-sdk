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
/// Represents a toolkit that provides a set of services.
/// </summary>
public interface IToolkit
{
    /// <summary>
    /// Gets the logger factory used by extensions.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    ILoggerFactory LoggerFactory { get; }

    /// <summary>
    /// Gets the continuation policy to use when an exception occurs during enumeration.
    /// </summary>
    BatchProcessExceptionContinuation BatchProcessExceptionContinuation { get; }
}

/// <summary>
/// Represents a toolkit that provides a set of services.
/// </summary>
/// <typeparam name="TSelf">The exact type of the toolkit implementation itself.</typeparam>
public interface IToolkit<out TSelf> : IToolkit where TSelf : IToolkit<TSelf>
{
    /// <summary>
    /// Sets the continuation policy to use when an exception occurs during enumeration.
    /// </summary>
    /// <param name="continuation">The continuation policy to use when an exception occurs during enumeration.</param>
    TSelf SetBatchProcessExceptionContinuation(BatchProcessExceptionContinuation continuation);
}
