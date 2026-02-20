/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Exceptions;

/// <summary>
/// The base exception type for all errors that occur during the evaluation (execution) of CQL expressions.
/// </summary>
public abstract class CqlEvaluationException : Exception
{
    /// <inheritdoc cref="Exception(string?)"/>
    protected CqlEvaluationException(string? message) : base(message)
    {
    }

    /// <inheritdoc cref="Exception(string?, Exception?)"/>
    protected CqlEvaluationException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
