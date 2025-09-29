/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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
        /// Tries to parse a quantity from this string, e.g. <code>1.0m 'a'</code>.
        /// </summary>
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
            var parts = s.Split(' ');
            if (parts.Length == 2)
            {
                if (decimal.TryParse(parts[0], NumberStyles.Number, CultureInfo.InvariantCulture, out var value) && !string.IsNullOrWhiteSpace(parts[1]))
                {
                    var units = Dequote(parts[1])!;
                    q = new CqlQuantity(value, units);
                    return true;
                }
            }
            q = null;
            return false;
        }

        private static string? Dequote(string? v)
        {
            if (v == null)
                return null;
            v = v.Trim();
            if (v[0] == '\'')
            {
                if (v[v.Length - 1] == '\'')
                    return v.Substring(1, v.Length - 2);
                else return v.Substring(1);
            }
            else if (v[v.Length - 1] == '\'')
                return v.Substring(0, v.Length - 2);
            else return v;
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
