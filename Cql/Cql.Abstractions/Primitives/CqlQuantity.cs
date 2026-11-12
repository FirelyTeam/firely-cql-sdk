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
    /// Implements the System Quantity type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#quantity"/>
    [CqlPrimitiveType(CqlPrimitiveType.Quantity)]
    public class CqlQuantity : IUnaryNegationOperators<CqlQuantity?, CqlQuantity?>
    {
        /// <summary>
        /// Creates an instance.
        /// </summary>
        public CqlQuantity() { }

        /// <summary>
        /// Creates an instance.
        /// </summary>
        /// <param name="value">The value of this quantity.</param>
        /// <param name="unit">The UCUM units of this quantity.</param>
        public CqlQuantity(decimal? value, string? unit)
        {
            this.value = value;
            this.unit = unit;
        }

        /// <summary>
        /// The value of this quantity.
        /// </summary>
        public decimal? value { get; init; }

        /// <summary>
        /// The UCUM units of this quantity.
        /// </summary>
        public string? unit { get; init;  }

        /// <summary>
        /// Gets a string representation of this quantity.
        /// </summary>
        public override string? ToString()
        {
            if (value == null || unit == null)
                return null;
            var unitString = unit;

            return string.Create(CultureInfo.InvariantCulture, $"{value} '{unitString}'");
        }

        /// <summary>
        /// Tries to parse a quantity from a string in the format the CQL <c>ToQuantity</c> operator accepts, e.g.
        /// <c>1.0 'mg'</c>, <c>1.0'mg'</c> or <c>1.0</c>.
        /// </summary>
        /// <remarks>
        /// CQL 1.5.3, Appendix B - CQL Reference, Type Operators, ToQuantity: "<c>(+|-)?#0(.0#)?('&lt;unit&gt;')?</c>
        /// Meaning an optional polarity indicator, followed by any number of digits (including none) followed by at
        /// least one digit, optionally followed by a decimal point, at least one digit, and any number of additional
        /// digits, all optionally followed by a unit designator as a string literal [...]. Spaces are allowed between
        /// the quantity value and the unit designator."
        /// <para>
        /// A quantity without a unit designator has the default unit <c>'1'</c>. Whitespace is allowed only between
        /// the value and the unit designator. The unit is not yet checked against UCUM or the calendar duration
        /// keywords, which the specification requires (#1782).
        /// </para>
        /// </remarks>
        /// <see href="https://cql.hl7.org/09-b-cqlreference.html#toquantity"/>
        /// <param name="s">The string to parse</param>
        /// <param name="q">The resulting quantity.</param>
        /// <returns><see langword="true"/> if successfully parsed; otherwise, <see langword="false"/>.</returns>
        public static bool TryParse(string s, out CqlQuantity? q)
        {
            if (s == null)
            {
                q = null;
                return false;
            }
            return TryParse(s.AsSpan(), out q);
        }

        /// <inheritdoc cref="TryParse(string, out CqlQuantity?)"/>
        internal static bool TryParse(ReadOnlySpan<char> s, [NotNullWhen(true)] out CqlQuantity? q)
        {
            q = null;

            var numberLength = CqlNumberFormat.NumberLength(s, allowFraction: true);
            if (numberLength == 0 || !CqlNumberFormat.TryParseDecimal(s[..numberLength], out var value))
                return false;

            var rest = s[numberLength..];
            var designator = rest.TrimStart();
            string unit;
            if (rest.IsEmpty)
                unit = UCUMUnits.Default;
            else if (designator.Length > 2 && designator[0] == '\'' && designator[^1] == '\'' && designator[1..^1].IndexOf('\'') < 0)
                unit = designator[1..^1].ToString();
            else
                return false;

            q = new CqlQuantity(value, unit);
            return true;
        }

        /// <summary>
        /// Returns the negated value of the specified <see cref="CqlQuantity"/> instance.
        /// </summary>
        /// <param name="value">The <see cref="CqlQuantity"/> to negate. If <see langword="null"/>, the result is <see langword="null"/>.</param>
        /// <returns>A <see cref="CqlQuantity"/> representing the negated value of <paramref name="value"/>; or <see
        /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
        public static CqlQuantity? operator -(CqlQuantity? value) => Negate(value)!;

        /// <summary>
        /// Returns a new CqlQuantity with the value negated, preserving the unit. If the input value is null, the
        /// result will also have a null value.
        /// </summary>
        /// <param name="cqlQuantity">The quantity to negate. May be null.</param>
        /// <returns>A new CqlQuantity with the negated value and the same unit as the input; or null if the input is null.</returns>
        public static CqlQuantity? Negate(CqlQuantity? cqlQuantity) =>
            cqlQuantity switch
            {
                { value: { } value, unit: var unit } => new CqlQuantity(-value, unit),
                { value: null, unit: var unit }      => new CqlQuantity(null, unit),
                null                                 => null,
            };
    }
}
