/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Exceptions;

namespace Hl7.Cql.Primitives;

/// <summary>
/// An <see cref="ICqlArithmeticError"/> raised when the UCUM year unit <c>"a"</c> is used
/// in a date/time arithmetic calculation.
/// </summary>
/// <remarks>
/// Per the CQL specification (§3232) and FHIRPath semantics, the UCUM unit <c>"a"</c> is a
/// definite-duration quantity. Using it above days in date/time arithmetic will end evaluation
/// and signal an error. Use the calendar duration unit <c>"year"</c> or <c>"years"</c> instead.
/// </remarks>
public readonly record struct CqlUcumYearArithmeticError : ICqlArithmeticError
{
    /// <inheritdoc/>
    public string GetMessage() =>
        "If a definite-duration time-valued unit above days (or weeks) appears in a date/time arithmetic calculation, " +
        "the evaluation will end and signal an error to the calling environment. " +
        "Use 'year' or 'years' instead of UCUM unit 'a'.";
}

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
        "If a definite-duration time-valued unit above days (or weeks) appears in a date/time arithmetic calculation, " +
        "the evaluation will end and signal an error to the calling environment. " +
        "Use 'month' or 'months' instead of UCUM unit 'mo'.";
}

/// <summary>
/// An <see cref="ICqlError"/> raised when the <c>point from</c> operator is applied to an
/// interval that is not a unit interval.
/// </summary>
/// <remarks>
/// Per the CQL specification (§9.B, Point From), extracting a point from an interval whose size
/// is greater than one signals an error to the calling environment. A null closed boundary is
/// the minimum or maximum value of the point type, so an interval with two of them spans the
/// whole domain.
/// </remarks>
/// <param name="Low">The interval's low boundary value.</param>
/// <param name="High">The interval's high boundary value.</param>
/// <param name="LowClosed">Whether the interval's low boundary is closed.</param>
/// <param name="HighClosed">Whether the interval's high boundary is closed.</param>
public readonly record struct CqlPointFromNonUnitIntervalError(
    object? Low,
    object? High,
    bool LowClosed,
    bool HighClosed) : ICqlError
{
    /// <inheritdoc/>
    public string GetMessage() =>
        "The point from operator requires a unit interval, but was given " +
        $"{(LowClosed ? "[" : "(")}{Low?.ToString() ?? "null"}, {High?.ToString() ?? "null"}{(HighClosed ? "]" : ")")}.";
}
