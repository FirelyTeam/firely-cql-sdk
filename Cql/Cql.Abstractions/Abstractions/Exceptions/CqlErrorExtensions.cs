/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions.Exceptions;

internal static class CqlErrorExtensions
{
    public static CqlException<TError> ToException<TError>(this TError cqlError, Exception? innerException = null)
        where TError : struct, ICqlError =>
        new CqlException<TError>(cqlError, innerException);
}