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
/// Extension methods for <see cref="ICqlError"/> values and the exceptions thrown while CQL is evaluated.
/// </summary>
public static class CqlErrorExtensions
{
    /// <summary>
    /// The CQL definitions that were being evaluated when <paramref name="exception"/> was thrown, innermost first: the
    /// definition it was thrown in comes first, and the definition the host invoked comes last. Empty when it was not
    /// thrown while a definition was being evaluated.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This reads the frames of any exception, so a host can tell where a failure inside the SDK or a data source
    /// happened, not only an error in a <see cref="CqlException"/>, whose <see cref="CqlException.EvaluationFrames"/>
    /// returns the same list.
    /// </para>
    /// <para>
    /// A definition is in the list while it computes its value. A value can be a sequence that is only read later,
    /// such as a retrieve from a data source that reads lazily. An exception thrown while that sequence is read names
    /// the definition reading it, or has no frames when the host reads it.
    /// </para>
    /// <para>
    /// An exception instance that is thrown again from another definition, such as a failure the host caches and
    /// rethrows, lists the definitions of its second pass after those of its first.
    /// </para>
    /// </remarks>
    /// <param name="exception">The exception to read the frames of.</param>
    /// <returns>The frames recorded on <paramref name="exception"/>, innermost first.</returns>
    public static IReadOnlyList<CqlEvaluationFrame> GetCqlEvaluationFrames(this Exception exception) =>
        CqlEvaluationFrames.Get(exception);

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