using Hl7.Cql.Conversion;

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
