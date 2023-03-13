using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.Primitives
{
    [CqlPrimitiveType(CqlPrimitiveType.Ratio)]
    public class CqlRatio
    {
        public CqlRatio() { }
        public CqlRatio(CqlQuantity? numerator, CqlQuantity? denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }


        public CqlQuantity? numerator { get; }
        public CqlQuantity? denominator { get; }


        public override string ToString() => $"{numerator}:{denominator}";

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
