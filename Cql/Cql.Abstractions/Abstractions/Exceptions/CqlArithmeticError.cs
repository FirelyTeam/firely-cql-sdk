/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Exceptions;

/// <summary>
/// An <see cref="ICqlError"/> that represents an arithmetic operation that cannot be performed
/// during CQL expression evaluation.
/// </summary>
/// <remarks>
/// Per the CQL specification (§3232) and FHIRPath semantics, using a definite-quantity duration
/// above days (or weeks) in a date/time arithmetic expression is an error; a calendar duration
/// must be used instead. Use <see cref="CqlErrorExtensions.ToException{TError}"/> to convert
/// this error into a throwable <see cref="CqlException{TError}"/>.
/// </remarks>
/// <param name="Message">The human-readable message describing why the arithmetic cannot be performed.</param>
public readonly record struct CqlArithmeticError(string Message) : ICqlError
{
    /// <inheritdoc/>
    public string GetMessage() => Message;
}
