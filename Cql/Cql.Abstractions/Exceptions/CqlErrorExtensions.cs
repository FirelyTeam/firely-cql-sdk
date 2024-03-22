using System;

namespace Hl7.Cql.Abstractions.Exceptions;

internal static class CqlErrorExtensions
{
    public static CqlException<TError> ToException<TError>(this TError cqlError, Exception? innerException = null)
        where TError : struct, ICqlError =>
        new CqlException<TError>(cqlError, innerException);
}