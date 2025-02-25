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
public delegate void ValueExceptionHandler<in T>(
    T value,
    Exception exception,
    BatchProcessExceptionContinuation continuation = BatchProcessExceptionContinuation.Throw
    );
