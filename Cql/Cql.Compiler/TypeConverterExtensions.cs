using Hl7.Cql.Conversion;
using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.MeasureCompiler
{
    public static class TypeConverterExtensions
    {
        public static TypeConverter AddElmConversions(this TypeConverter converter)
        {
            converter.AddConversion<DateTimePrecision, string?>(dtp => Enum.GetName(dtp));
            converter.AddConversion<string, DateTimePrecision>(Enum.Parse<DateTimePrecision>);
            return converter;
        }
    }
}
