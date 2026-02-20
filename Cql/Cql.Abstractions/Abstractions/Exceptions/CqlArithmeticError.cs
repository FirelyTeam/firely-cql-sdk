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
/// <param name="Unit">The UCUM unit string (e.g. <c>"a"</c>, <c>"mo"</c>) that caused the error.</param>
/// <param name="CalendarEquivalent">The calendar duration unit that should be used instead (e.g. <c>"year"</c>, <c>"month"</c>).</param>
public readonly record struct CqlArithmeticError(string Unit, string CalendarEquivalent) : ICqlArithmeticError
{
    /// <inheritdoc/>
    public string GetMessage() =>
        $"If a definite-quantity duration above days (or weeks) appears in a date/time arithmetic calculation, " +
        $"the evaluation will end and signal an error to the calling environment. " +
        $"Use '{CalendarEquivalent}' instead of UCUM unit '{Unit}'.";
}
