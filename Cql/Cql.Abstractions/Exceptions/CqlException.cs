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
/// The base exception type for all structured errors in the CQL SDK.
/// The human-readable message is derived from an <see cref="ICqlError"/> payload.
/// </summary>
public abstract class CqlException : Exception
{
    /// <summary>
    /// Initializes a new instance of <see cref="CqlException"/> with an optional inner exception.
    /// </summary>
    /// <param name="innerException">The exception that caused this exception, or <see langword="null"/>.</param>
    protected CqlException(Exception? innerException = null) : base(null, innerException) { }

    /// <summary>The structured error payload that produced this exception.</summary>
    public ICqlError Error => GetError();

    /// <summary>Returns the structured error payload.</summary>
    protected abstract ICqlError GetError();

    /// <inheritdoc/>
    public override string Message => Error.GetMessage();
}

/// <summary>
/// A strongly-typed CQL SDK exception whose message and details are carried by an
/// <see cref="ICqlError"/> value of type <typeparamref name="TError"/>.
/// </summary>
/// <typeparam name="TError">The concrete error type that describes what went wrong.</typeparam>
public class CqlException<TError> : CqlException
    where TError : struct, ICqlError
{
    /// <summary>The strongly-typed error payload.</summary>
    public new TError Error { get; }

    /// <inheritdoc/>
    protected override ICqlError GetError() => Error;

    /// <summary>
    /// Initializes a new instance of <see cref="CqlException{TError}"/> with the given error payload.
    /// </summary>
    /// <param name="error">The structured error describing what went wrong.</param>
    /// <param name="innerException">The exception that caused this exception, or <see langword="null"/>.</param>
    public CqlException(TError error, Exception? innerException = null) : base(innerException) =>
        Error = error;
}