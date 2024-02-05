using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm
{
    internal class NumericTypeSpecifierComparer : IComparer<NamedTypeSpecifier>, IComparer<TypeSpecifier>
    {
        public static readonly NumericTypeSpecifierComparer Default = new NumericTypeSpecifierComparer();
        private NumericTypeSpecifierComparer() { }

        public int Compare(NamedTypeSpecifier? x, NamedTypeSpecifier? y)
        {
            if (x == null)
            {
                if (y == null) return 0;
                else return -1;
            }
            else if (y == null)
                return 1;

            if (Order.TryGetValue(x, out var orderX)
                && Order.TryGetValue(y, out var orderY))
                return orderX - orderY;
            else return -1;
        }
        public int Compare(TypeSpecifier? x, TypeSpecifier? y) => Compare(x as NamedTypeSpecifier, y as NamedTypeSpecifier);

        public static bool IsNumeric(TypeSpecifier type) => Order.ContainsKey(type);


        private static Dictionary<TypeSpecifier, int> Order = new()
        {
            { SystemTypes.QuantityType, 400 },
            { SystemTypes.DecimalType, 300 },
            { SystemTypes.LongType, 200 },
            { SystemTypes.IntegerType, 100 },
        };

    }
}
