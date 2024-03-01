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
        public CqlQuantity? numerator { get; set;  }
        /// <summary>
        /// The denominator of this ratio.
        /// </summary>
        public CqlQuantity? denominator { get; set;  }

        /// <summary>
        /// Gets a string representation of this ratio.
        /// </summary>
        public override string ToString() => $"{numerator}:{denominator}";

        /// <summary>
        /// Tries to parse a quantity from this string, e.g. <code>365 'd':1.0m 'a'</code>.
        /// </summary>
        /// <param name="s">The string to parse</param>
        /// <param name="value">The resulting ratio.</param>
        /// <returns><see langword="true"/> if successfully parsed; otherwise, <see langword="false"/>.</returns>
        public static bool? TryParse(string s, out CqlRatio? value)
        {
            if (s == null)
            {
                value = null;
                return false;
            }
            var parts = s.Split(':');
            if (parts.Length != 2)
            {
                value = null;
                return false;
            }
            if (CqlQuantity.TryParse(parts[0], out var numerator))
            {
                if (CqlQuantity.TryParse(parts[1], out var denominator))
                {
                    value = new CqlRatio(numerator, denominator);
                    return true;
                }
            }
            value = null;
            return false;
        }
    }
}
