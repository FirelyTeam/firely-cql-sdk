using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;

namespace Hl7.Cql.Firely
{
    public static class FirelyTypeConverter
    {
        public static readonly TypeConverter Default =
            TypeConverter
                .Create()
                .ConvertSystemTypes()
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

        public static TypeConverter ConvertSystemTypes(this TypeConverter converter)
        {
            converter.AddConversion<byte[], string>(binary => Convert.ToBase64String(binary));
            converter.AddConversion<DateTimeOffset?, CqlDateTime?>(dto => dto == null ? null : new CqlDateTime(dto.Value, Iso8601.DateTimePrecision.Millisecond));
            return converter;
        }
    }
}
