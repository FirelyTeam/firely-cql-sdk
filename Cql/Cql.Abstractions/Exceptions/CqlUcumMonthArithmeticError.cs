/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Exceptions;

/// <summary>
/// An <see cref="ICqlArithmeticError"/> raised when the UCUM month unit <c>"mo"</c> is used
/// in a date/time arithmetic calculation.
/// </summary>
/// <remarks>
/// Per the CQL specification (§3232) and FHIRPath semantics, the UCUM unit <c>"mo"</c> is a
/// definite-duration quantity. Using it above days in date/time arithmetic will end evaluation
/// and signal an error. Use the calendar duration unit <c>"month"</c> or <c>"months"</c> instead.
/// </remarks>
public readonly record struct CqlUcumMonthArithmeticError : ICqlArithmeticError
{
    /// <inheritdoc/>
    public string GetMessage() =>
        "If a definite-quantity duration above days (or weeks) appears in a date/time arithmetic calculation, " +
        "the evaluation will end and signal an error to the calling environment. " +
        "Use 'month' or 'months' instead of UCUM unit 'mo'.";
}
