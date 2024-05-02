/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
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
    public new TError Error { get; }
    protected override ICqlError GetError() => Error;

    public CqlException(TError error, Exception? innerException = null) : base(innerException) =>
        Error = error;
}