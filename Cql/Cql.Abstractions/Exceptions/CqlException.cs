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

    /// <summary>
    /// The CQL definitions that were being evaluated when this exception was thrown, innermost first: the definition
    /// it was thrown in comes first, and the definition the host invoked comes last. Empty when it was not thrown
    /// while a definition was being evaluated.
    /// </summary>
    /// <remarks>
    /// The same list as <see cref="CqlErrorExtensions.GetCqlEvaluationFrames"/> returns, which describes when a
    /// definition is in it.
    /// </remarks>
    public IReadOnlyList<CqlEvaluationFrame> EvaluationFrames => this.GetCqlEvaluationFrames();

    /// <inheritdoc/>
    /// <remarks>
    /// The message names the innermost of the <see cref="EvaluationFrames"/>, when there are any. That holds for every
    /// <see cref="CqlException"/> thrown while a definition was being evaluated, not only one whose
    /// <see cref="Error"/> is an <see cref="ICqlEvaluationError"/>.
    /// </remarks>
    public override string Message =>
        EvaluationFrames is [var innermost, ..]
            ? $"{EndSentence(Error.GetMessage())} Thrown while evaluating {innermost}."
            : Error.GetMessage();

    // Ends the error's message with a full stop before the frame is appended, unless it already ends a sentence.
    private static string EndSentence(string message) =>
        message is [.., '.' or '!' or '?'] ? message : message + ".";
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