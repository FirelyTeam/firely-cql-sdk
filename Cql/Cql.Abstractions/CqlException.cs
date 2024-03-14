using System;

namespace Hl7.Cql.Abstractions;

internal interface ICqlError
{
    string GetMessage();
}

internal static class CqlErrorExtensions
{
    public static CqlException<TError> ToException<TError>(this TError cqlError, Exception? innerException = null)
        where TError : struct, ICqlError =>
        new CqlException<TError>(cqlError, innerException);
}

internal abstract class CqlException : Exception
{
    protected CqlException(Exception? innerException = null) : base(null, innerException) {}

    public ICqlError Error => GetError();
    protected abstract ICqlError GetError();

    public override string Message => Error.GetMessage();
}

internal class CqlException<TError> : CqlException
    where TError : struct, ICqlError
{
    public new ICqlError Error { get; }
    protected override ICqlError GetError() => Error;

    public CqlException(ICqlError error, Exception? innerException = null) : base(innerException) => 
        Error = error;
}

