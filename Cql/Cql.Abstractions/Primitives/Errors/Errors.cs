/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Exceptions;

namespace Hl7.Cql.Primitives.Errors;

/// <summary>
/// An <see cref="ICqlArithmeticError"/> raised when a Date, DateTime or Time value is shifted by a quantity whose unit is
/// not a time-valued unit for that type.
/// </summary>
/// <remarks>
/// Per the CQL specification (Appendix B - CQL Reference, section "Date and Time Operators", "Add" and "Subtract"),
/// "For Date values, the quantity unit must be one of: years, months, weeks, or days", "For DateTime values, the
/// quantity unit must be one of: years, months, weeks, days, hours, minutes, seconds, or milliseconds" and "For Time
/// values, the quantity unit must be one of: hours, minutes, seconds, or milliseconds"; section "Interval Operators",
/// "Expand", requires for "Date-, DateTime-, and Time-valued intervals [...] a quantity with a temporal unit". Neither
/// section defines a result for any other unit, so such a unit signals an error to the calling environment.
/// </remarks>
public readonly record struct CqlUnsupportedTemporalUnitError : ICqlArithmeticError
{
    internal CqlUnsupportedTemporalUnitError(string unit, string type)
    {
        Unit = unit;
        Type = type;
    }

    /// <summary>The unit of the quantity.</summary>
    public string Unit { get; }

    /// <summary>The CQL type of the value being shifted: <c>Date</c>, <c>DateTime</c> or <c>Time</c>.</summary>
    public string Type { get; }

    /// <inheritdoc/>
    public string GetMessage() =>
        $"The quantity unit '{Unit}' is not supported in {Type} arithmetic. " + Type switch
        {
            "Date" => "For Date values, the quantity unit must be one of: years, months, weeks, or days.",
            "DateTime" => "For DateTime values, the quantity unit must be one of: years, months, weeks, days, hours, minutes, seconds, or milliseconds.",
            "Time" => "For Time values, the quantity unit must be one of: hours, minutes, seconds, or milliseconds.",
            _ => "The quantity unit must be a time-valued unit.",
        };
}

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
