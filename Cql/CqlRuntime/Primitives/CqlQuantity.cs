using Ncqa.Cql.Runtime.Conversion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    [CqlPrimitiveType(CqlPrimitiveType.Quantity)]
    public class CqlQuantity
    {
        public CqlQuantity() { }
        public CqlQuantity(decimal? value, string? unit)
        {
            this.value = value;
            this.unit = unit;
        }

        public decimal? value { get; set; }
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
