/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents a method that handles exceptions that occur during batch processing.
/// </summary>
/// <typeparam name="T">The type of the source object that caused the exception.</typeparam>
/// <param name="value">The item in the enumerations which caused the exception.</param>
/// <param name="continuation">The continuation of the enumeration after handling the exception.</param>
/// <param name="exception">The exception that occurred.</param>
public delegate void BatchProcessExceptionHandler<in T>(
    T value,
    Exception exception,
    BatchProcessExceptionContinuation continuation = BatchProcessExceptionContinuation.Throw);


/// <summary>
/// Represents a delegate that yields a return value after an exception is ignored.
/// </summary>
/// <typeparam name="T">The type of the input value to be processed.</typeparam>
/// <typeparam name="TReturn">The type of the return value produced by the handler.</typeparam>
/// <param name="value">The input value to be processed by the exception handler.</param>
/// <returns>
/// A tuple containing:
/// <list type="bullet">
///   <item>
///     <description><typeparamref name="TReturn"/> returnValue: The result of handling the exception.</description>
///   </item>
///   <item>
///     <description>bool yieldValue: Indicates whether the value should be yielded.</description>
///   </item>
/// </list>
/// </returns>
/// <remarks>Implementations of this callback must avoid throwing exceptions.</remarks>
internal delegate (bool shouldYieldValue, TReturn yieldedValue) YieldValueWhenExceptionIgnoredHandler<in T, TReturn>(T value);
