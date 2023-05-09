using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    /// <summary>
    /// Implements the System Quantity type.
    /// </summary>
    /// <see href="https://cql.hl7.org/09-b-cqlreference.html#quantity"/>
    [CqlPrimitiveType(CqlPrimitiveType.Quantity)]
    public class CqlQuantity
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
        public decimal? value { get; set; }
        /// <summary>
        /// The UCUM units of this quantity.
        /// </summary>
        public string? unit
        {
            get => _unit;
            set
            {
                if (value != null && Units.CqlUnitsToUCUM.TryGetValue(value, out var ucumUnits))
                {
                    _unit = ucumUnits;
                }
                else _unit = value;
            }
        }
        private string? _unit;

        /// <summary>
        /// Gets a string representation of this quantity.
        /// </summary>
        public override string? ToString()
        {
            if (value == null || unit == null)
                return null;
            var unitString = unit;
            if (Units.UCUMUnitsToCql.TryGetValue(unit, out var cqlUnit))
            {
                unitString = cqlUnit;
            }
            return $"{value}{unitString}";
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
                if (decimal.TryParse(parts[0], out var value) && !string.IsNullOrWhiteSpace(parts[1]))
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

    }
}
