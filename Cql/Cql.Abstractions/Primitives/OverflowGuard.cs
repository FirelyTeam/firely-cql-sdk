/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Primitives;

/// <summary>
/// Arithmetic and conversions that answer <see langword="null"/> where the result cannot be represented, for the rule
/// that "operations that cause arithmetic overflow or underflow, or otherwise cannot be performed (such as division by
/// 0) will result in null, rather than a run-time error" (CQL 1.5.3 Errata 2, Appendix B - CQL Reference, section
/// "Arithmetic Operators"). No member throws because a value is out of range.
/// </summary>
internal static class OverflowGuard
{
    /// <summary>The sum, or <see langword="null"/> when it is outside the range of <typeparamref name="T"/>.</summary>
    public static T? Add<T>(T left, T right) where T : struct, INumberBase<T>
    {
        try
        {
            return checked(left + right);
        }
        catch (OverflowException)
        {
            return null;
        }
    }

    /// <summary>The difference, or <see langword="null"/> when it is outside the range of <typeparamref name="T"/>.</summary>
    public static T? Subtract<T>(T left, T right) where T : struct, INumberBase<T>
    {
        try
        {
            return checked(left - right);
        }
        catch (OverflowException)
        {
            return null;
        }
    }

    /// <summary>The product, or <see langword="null"/> when it is outside the range of <typeparamref name="T"/>.</summary>
    public static T? Multiply<T>(T left, T right) where T : struct, INumberBase<T>
    {
        try
        {
            return checked(left * right);
        }
        catch (OverflowException)
        {
            return null;
        }
    }

    /// <summary>
    /// The quotient, truncated for an integer type, or <see langword="null"/> when it is outside the range of
    /// <typeparamref name="T"/>. A zero <paramref name="right"/> is for the caller to handle.
    /// </summary>
    public static T? Divide<T>(T left, T right) where T : struct, INumberBase<T>
    {
        try
        {
            return checked(left / right);
        }
        catch (OverflowException)
        {
            return null;
        }
    }

    /// <summary>The negation, or <see langword="null"/> when it is outside the range of <typeparamref name="T"/>.</summary>
    public static T? Negate<T>(T value) where T : struct, INumberBase<T>
    {
        try
        {
            return checked(-value);
        }
        catch (OverflowException)
        {
            return null;
        }
    }

    /// <summary>The value truncated to an <see cref="int"/>, or <see langword="null"/> when that is outside its range.</summary>
    public static int? ToInt32(decimal value) =>
        decimal.Truncate(value) is var truncated and >= int.MinValue and <= int.MaxValue ? (int)truncated : null;

    /// <summary>The value truncated to an <see cref="int"/>, or <see langword="null"/> when that is outside its range.</summary>
    public static int? ToInt32(double value) =>
        Math.Truncate(value) is var truncated and >= int.MinValue and <= int.MaxValue ? (int)truncated : null;

    /// <summary>
    /// The value as a <see cref="decimal"/>, or <see langword="null"/> when it is outside its range or is not a number.
    /// </summary>
    public static decimal? ToDecimal(double value)
    {
        if (!double.IsFinite(value))
            return null;

        try
        {
            return (decimal)value;
        }
        catch (OverflowException)
        {
            return null;
        }
    }

    /// <summary>
    /// Moves <paramref name="start"/> by <paramref name="amount"/> using <paramref name="shift"/>, or answers
    /// <see langword="null"/> when the amount or the result lies outside the range the date or time type can
    /// represent. <paramref name="shift"/> may convert the amount with a checked narrowing conversion, such as
    /// <see cref="decimal.ToInt32(decimal)"/>, since an overflow there is handled the same way.
    /// </summary>
    public static T? Shift<T>(T start, decimal amount, Func<T, decimal, T> shift) where T : struct
    {
        try
        {
            return shift(start, amount);
        }
        catch (ArgumentOutOfRangeException)
        {
            return null;
        }
        catch (OverflowException)
        {
            return null;
        }
    }
}
