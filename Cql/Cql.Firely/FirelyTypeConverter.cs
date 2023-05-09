using Ncqa.Cql.Runtime.Conversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cql.Firely
{
    public static class FirelyTypeConverter
    {
        public static readonly TypeConverter Default =
            TypeConverter
                .Create()
                .ConvertFhirToCqlPrimitives()
                .ConvertCqlPrimitivesToFhir();

        public static TypeConverter ConvertFhirToCqlPrimitives(this TypeConverter converter)
        {
            return converter;
        }

        public static TypeConverter ConvertCqlPrimitivesToFhir(this TypeConverter converter)
        {
            return converter;
        }
    }
}
