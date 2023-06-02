using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;
using M = Hl7.Fhir.Model;

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
            List<Type> toTypes = new();

            add((M.Integer p) => p.Value);
            add((M.FhirString p) => p.Value);
            add((M.FhirBoolean p) => p.Value);
            add((M.FhirDecimal p) => p.Value);
            add((M.Date f) => CqlDate.TryParse(f.Value, out var cqld) ? cqld : null);
            add((M.Time f) => CqlTime.TryParse(f.Value, out var cqld) ? cqld : null);
            add((M.FhirDateTime f) => CqlDateTime.TryParse(f.Value, out var cqld) ? cqld : null);
            add((M.Quantity f) => new CqlQuantity(f.Value, f.Unit));
            add((M.Period f) => new CqlInterval<CqlDateTime>(
                converter.Convert<CqlDateTime>(f.StartElement), converter.Convert<CqlDateTime>(f.EndElement), lowClosed: true, highClosed: true));
            add((M.Range f) => new CqlInterval<CqlQuantity>(
                    converter.Convert<CqlQuantity>(f.Low), converter.Convert<CqlQuantity>(f.High), lowClosed: true, highClosed: true));

            addParametersToCqlPrimitivesConverters(toTypes);
            return converter;

            // Add a basic Fhir primitive->Cql primitive conversion
            void add<I, O>(Func<I, O> tos)
            {
                converter.AddConversion<I, O>(tos);
                toTypes.Add(typeof(O));
            }

            // Add a ParameterComponent->Cql primitive via the now registered basic conversion.
            void addParametersToCqlPrimitivesConverters(IEnumerable<Type> tos)
            {
                foreach (Type t in tos) converter.AddConversion(typeof(M.Parameters.ParameterComponent), t,
                    f => converter.Convert(((M.Parameters.ParameterComponent)f).Value, t)!);
            }
        }

        public static TypeConverter ConvertCqlPrimitivesToFhir(this TypeConverter converter)
        {
            converter.AddConversion((CqlDate f) => new M.Date(f.ToString()));
            converter.AddConversion((CqlDateTime f) => new M.FhirDateTime(f.ToString()));
            converter.AddConversion((CqlDate f) => new M.FhirDateTime(f.ToString()));
            converter.AddConversion((CqlTime f) => new M.Time(f.ToString()));
            converter.AddConversion((CqlQuantity f) => f.value is not null ? new M.Quantity(f.value.Value, f.unit, Fhir.ElementModel.Types.Quantity.UCUM) : null);
            converter.AddConversion((CqlInterval<CqlQuantity> f) => v(f, new M.Range(converter.Convert<M.Quantity>(f.low), converter.Convert<M.Quantity>(f.high))));
            converter.AddConversion((CqlInterval<decimal?> f) => v(f, new M.Range(new M.Quantity(f.low!.Value, "1"), new M.Quantity(f.high!.Value, "1"))));
            converter.AddConversion((CqlInterval<int?> f) => v(f, new M.Range(new M.Quantity(f.low!.Value, "1"), new M.Quantity(f.high!.Value, "1"))));
            converter.AddConversion((CqlInterval<CqlDateTime> f) => v(f, new M.Period(converter.Convert<M.FhirDateTime>(f.low), converter.Convert<M.FhirDateTime>(f.high))));
            converter.AddConversion((CqlInterval<CqlDate> f) => v(f, new M.Period(converter.Convert<M.FhirDateTime>(f.low), converter.Convert<M.FhirDateTime>(f.high))));

            converter.AddConversion((CqlRatio f) => (f.denominator is not null && f.numerator is not null) ?
                new M.Ratio(converter.Convert<M.Quantity>(f.numerator), converter.Convert<M.Quantity>(f.denominator)) : null);

            return converter;

            // If the interval is convertable to for FHIR, convert it
            static U? v<T, U>(CqlInterval<T> f, U value) => f.lowClosed == true && f.highClosed == true && f.low is not null && f.high is not null ?
                    value : default;
        }



        public static TypeConverter ConvertSystemTypes(this TypeConverter converter)
        {
            converter.AddConversion<byte[], string>(binary => Convert.ToBase64String(binary));
            converter.AddConversion<DateTimeOffset?, CqlDateTime?>(dto => dto == null ? null : new CqlDateTime(dto.Value, Iso8601.DateTimePrecision.Millisecond));
            return converter;
        }
    }
}
