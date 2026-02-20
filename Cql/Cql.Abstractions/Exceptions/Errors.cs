/*
 * Copyright (c) 2024, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Exceptions;

internal readonly record struct KeyNotFoundError(string Key, string? TypeName = null) : ICqlError
{
    public string GetMessage() => $"{TypeName ?? "Object"} not found by key. Key: '{Key}'";
}

internal readonly record struct CouldNotValidateLibraryError(string? FilePath, string? TypeName = null) : ICqlError
{
    public string GetMessage() => $"Could not validate {TypeName ?? "Object"}. " +
                                  (FilePath is not null ? $"Path: '{FilePath}'" : "");
}

internal readonly record struct CouldNotConvertInstanceToTargetType(object Instance, Type TargetType) : ICqlError
{
    public string GetMessage() => $"Could not convert instance '{Instance}' of type '{Instance?.GetType()} to type {TargetType}";
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
        "If a definite-quantity duration above days (or weeks) appears in a date/time arithmetic calculation, " +
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
        "If a definite-quantity duration above days (or weeks) appears in a date/time arithmetic calculation, " +
        "the evaluation will end and signal an error to the calling environment. " +
        "Use 'month' or 'months' instead of UCUM unit 'mo'.";
}