/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Exceptions;

/// <summary>
/// Extension methods for <see cref="ICqlError"/> values.
/// </summary>
public static class CqlErrorExtensions
{
    /// <summary>
    /// Wraps this <see cref="ICqlError"/> in a <see cref="CqlException{TError}"/> that can be thrown.
    /// </summary>
    /// <typeparam name="TError">The concrete error type.</typeparam>
    /// <param name="cqlError">The structured error to wrap.</param>
    /// <param name="innerException">An optional inner exception, or <see langword="null"/>.</param>
    /// <returns>A <see cref="CqlException{TError}"/> wrapping <paramref name="cqlError"/>.</returns>
    public static CqlException<TError> ToException<TError>(this TError cqlError, Exception? innerException = null)
        where TError : struct, ICqlError =>
        new CqlException<TError>(cqlError, innerException);
}