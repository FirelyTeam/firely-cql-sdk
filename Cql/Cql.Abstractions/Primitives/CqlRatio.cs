/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// Implements the System Ratio type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#ratio"/>
    [CqlPrimitiveType(CqlPrimitiveType.Ratio)]
    public class CqlRatio
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        public CqlRatio() { }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="numerator">The numerator of this ratio.</param>
        /// <param name="denominator">The denominator of this ratio.</param>
        public CqlRatio(CqlQuantity? numerator, CqlQuantity? denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        /// <summary>
        /// The numerator of this ratio.
        /// </summary>
        public CqlQuantity? numerator { get; init;  }
        /// <summary>
        /// The denominator of this ratio.
        /// </summary>
        public CqlQuantity? denominator { get; init;  }

        /// <summary>
        /// Gets a string representation of this ratio.
        /// </summary>
        public override string ToString() => $"{numerator}:{denominator}";

        /// <summary>
        /// Tries to parse a ratio from a string in the format the CQL <c>ToRatio</c> operator accepts,
        /// e.g. <c>1.0 'mg':2.0 'mL'</c> or <c>1:128</c>.
        /// </summary>
        /// <remarks>
        /// CQL 1.5.3, Appendix B - CQL Reference, Type Operators, ToRatio: "The operator accepts strings using the
        /// following format: &lt;quantity&gt;:&lt;quantity&gt; where &lt;quantity&gt; is the format used to by the
        /// ToQuantity operator."
        /// <para>
        /// CQL 1.5.3, Appendix B - CQL Reference, Type Operators, ToQuantity: "<c>(+|-)?#0(.0#)?('&lt;unit&gt;')?</c>
        /// Meaning an optional polarity indicator, followed by any number of digits (including none) followed by at
        /// least one digit, optionally followed by a decimal point, at least one digit, and any number of additional
        /// digits, all optionally followed by a unit designator as a string literal [...]. Spaces are allowed between
        /// the quantity value and the unit designator."
        /// </para>
        /// <para>
        /// A quantity without a unit designator has the default unit <c>'1'</c>. Whitespace around each quantity is
        /// ignored, and a colon inside a unit designator does not separate the quantities. The unit is not checked
        /// against UCUM.
        /// </para>
        /// </remarks>
        /// <see href="https://cql.hl7.org/09-b-cqlreference.html#toratio"/>
        /// <param name="s">The string to parse</param>
        /// <param name="value">The resulting ratio.</param>
        /// <returns><see langword="true"/> if successfully parsed; otherwise, <see langword="false"/>.</returns>
        public static bool? TryParse(string s, out CqlRatio? value)
        {
            value = null;
            if (s == null)
                return false;

            var separator = IndexOfSeparator(s);
            if (separator < 0)
                return false;

            if (!TryParseQuantity(s.AsSpan(0, separator), out var numerator)
                || !TryParseQuantity(s.AsSpan(separator + 1), out var denominator))
                return false;

            value = new CqlRatio(numerator, denominator);
            return true;
        }

        /// <summary>
        /// The index of the only colon outside a quoted unit designator, or -1 when there is no such colon,
        /// more than one, or an unterminated quote.
        /// </summary>
        private static int IndexOfSeparator(string s)
        {
            var separator = -1;
            var inUnit = false;
            for (var i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '\'':
                        inUnit = !inUnit;
                        break;
                    case ':' when !inUnit:
                        if (separator >= 0)
                            return -1;
                        separator = i;
                        break;
                }
            }
            return inUnit ? -1 : separator;
        }

        /// <summary>
        /// Parses one quantity of a ratio string in the format <c>(+|-)?#0(.0#)?('&lt;unit&gt;')?</c>,
        /// with optional whitespace around it and between the value and the unit designator.
        /// </summary>
        private static bool TryParseQuantity(ReadOnlySpan<char> s, [NotNullWhen(true)] out CqlQuantity? quantity)
        {
            quantity = null;
            s = s.Trim();

            var i = 0;
            if (i < s.Length && (s[i] == '+' || s[i] == '-'))
                i++;
            var integerDigits = CountDigits(s, i);
            if (integerDigits == 0)
                return false;
            i += integerDigits;
            if (i < s.Length && s[i] == '.')
            {
                var fractionDigits = CountDigits(s, i + 1);
                if (fractionDigits == 0)
                    return false;
                i += 1 + fractionDigits;
            }

            if (!decimal.TryParse(s[..i], NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out var number))
                return false;

            var rest = s[i..].TrimStart();
            string unit;
            if (rest.IsEmpty)
                unit = UCUMUnits.Default;
            else if (rest.Length > 2 && rest[0] == '\'' && rest[^1] == '\'' && rest[1..^1].IndexOf('\'') < 0)
                unit = rest[1..^1].ToString();
            else
                return false;

            quantity = new CqlQuantity(number, unit);
            return true;
        }

        private static int CountDigits(ReadOnlySpan<char> s, int start)
        {
            var count = 0;
            while (start + count < s.Length && char.IsAsciiDigit(s[start + count]))
                count++;
            return count;
        }
    }
}
