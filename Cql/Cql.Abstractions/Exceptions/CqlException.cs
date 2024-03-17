using System;

namespace Hl7.Cql.Abstractions.Exceptions;

internal abstract class CqlException : Exception
{
    protected CqlException(Exception? innerException = null) : base(null, innerException) { }

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