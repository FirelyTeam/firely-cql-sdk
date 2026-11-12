/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// The number formats that the <c>ToInteger</c>, <c>ToLong</c>, <c>ToDecimal</c> and <c>ToQuantity</c> operators
    /// accept in a string.
    /// </summary>
    /// <remarks>
    /// CQL 1.5.3, Appendix B - CQL Reference, Type Operators, ToInteger and ToLong: "<c>(+|-)?#0</c> Meaning an optional
    /// polarity indicator, followed by any number of digits (including none), followed by at least one digit."
    /// <para>
    /// ToDecimal: "<c>(+|-)?#0(.0#)?</c> Meaning an optional polarity indicator, followed by any number of digits
    /// (including none), followed by at least one digit, followed optionally by a decimal point, at least one digit,
    /// and any number of additional digits (including none)."
    /// </para>
    /// <para>
    /// Nothing else is accepted: no whitespace, group separator, trailing sign, exponent or leading decimal point.
    /// </para>
    /// </remarks>
    internal static class CqlNumberFormat
    {
        /// <summary>
        /// The length of the number in the format <c>(+|-)?#0(.0#)?</c> at the start of <paramref name="s"/>, or of
        /// <c>(+|-)?#0</c> when <paramref name="allowFraction"/> is <see langword="false"/>; 0 when
        /// <paramref name="s"/> does not start with one. A decimal point not followed by a digit is not part of the
        /// number.
        /// </summary>
        internal static int NumberLength(ReadOnlySpan<char> s, bool allowFraction)
        {
            var i = s.Length > 0 && s[0] is '+' or '-' ? 1 : 0;
            var integerDigits = CountDigits(s, i);
            if (integerDigits == 0)
                return 0;
            i += integerDigits;

            if (allowFraction && i < s.Length && s[i] == '.' && CountDigits(s, i + 1) is var fractionDigits and > 0)
                i += 1 + fractionDigits;

            return i;
        }

        /// <summary>
        /// Parses <paramref name="s"/> when all of it is in the format <c>(+|-)?#0</c> and the value lies within the
        /// Integer range.
        /// </summary>
        internal static bool TryParseInteger(ReadOnlySpan<char> s, out int value)
        {
            value = default;
            return IsNumber(s, allowFraction: false)
                && int.TryParse(s, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out value);
        }

        /// <summary>
        /// Parses <paramref name="s"/> when all of it is in the format <c>(+|-)?#0</c> and the value lies within the
        /// Long range.
        /// </summary>
        internal static bool TryParseLong(ReadOnlySpan<char> s, out long value)
        {
            value = default;
            return IsNumber(s, allowFraction: false)
                && long.TryParse(s, NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out value);
        }

        /// <summary>
        /// Parses <paramref name="s"/> when all of it is in the format <c>(+|-)?#0(.0#)?</c> and the value lies within
        /// the Decimal range. Digits beyond the precision of <see cref="decimal"/> are rounded.
        /// </summary>
        internal static bool TryParseDecimal(ReadOnlySpan<char> s, out decimal value)
        {
            value = default;
            return IsNumber(s, allowFraction: true)
                && decimal.TryParse(s, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out value);
        }

        private static bool IsNumber(ReadOnlySpan<char> s, bool allowFraction) =>
            NumberLength(s, allowFraction) is var length and > 0 && length == s.Length;

        private static int CountDigits(ReadOnlySpan<char> s, int start)
        {
            var count = 0;
            while (start + count < s.Length && char.IsAsciiDigit(s[start + count]))
                count++;
            return count;
        }
    }
}
