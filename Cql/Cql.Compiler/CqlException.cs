using System;

namespace Hl7.Cql.Compiler;

internal interface ICqlError
{
    string GetMessage();
}

internal static class CqlErrorExtensions
{
    public static CqlException ToException(this ICqlError cqlError, Exception? innerException = null) => new CqlException(cqlError, innerException);
}

internal sealed class CqlException : Exception
{
    internal CqlException(ICqlError error, Exception? innerException = null) : base(null, innerException) => Error = error;

    public ICqlError Error { get; }

    public override string Message => Error.GetMessage();
}