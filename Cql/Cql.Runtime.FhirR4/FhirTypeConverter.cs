using Hl7.Cql.Conversion;
using Hl7.Cql.Poco.Fhir.R4.Model;
using Hl7.Cql.Primitives;
using System;
using Fhir = Hl7.Cql.Poco.Fhir;

namespace Hl7.Cql.Runtime.FhirR4
{
    public static class FhirTypeConverter
    {
        public static readonly TypeConverter Default =
            TypeConverter
                .Create()
                .ConvertToSystemTypes()
                .ConvertFromSystemTypes();


        public static TypeConverter ConvertFromSystemTypes(this TypeConverter converter)
        {
            converter.AddConversion<CqlDate, DateElement>(d => new DateElement() { value = new Iso8601.DateIso8601(d.Value.Year, d.Value.Month, d.Value.Day) });
            converter.AddConversion<CqlDateTime, DateTimeElement>(d => new DateTimeElement() { 
                value = new Iso8601.DateTimeIso8601(
                    d.Value.Year, d.Value.Month, d.Value.Day,
                    d.Value.Hour, d.Value.Minute, d.Value.Second, d.Value.Millisecond,
                    d.Value.OffsetHour, d.Value.OffsetMinute
                ) 
            });
            converter.AddConversion<CqlDateTime, InstantElement>(d => new InstantElement()
            {
                value = new Iso8601.DateTimeIso8601(
                    d.Value.Year, d.Value.Month, d.Value.Day,
                    d.Value.Hour, d.Value.Minute, d.Value.Second, d.Value.Millisecond,
                    d.Value.OffsetHour, d.Value.OffsetMinute
                )
            });
            converter.AddConversion<CqlTime, TimeElement>(d => new TimeElement() { 
                value = new Iso8601.TimeIso8601(
                    d.Value.Hour, d.Value.Minute, d.Value.Second, d.Value.Millisecond,
                    d.Value.OffsetHour, d.Value.OffsetMinute
                ) 
            });
            converter.AddConversion<CqlQuantity, Quantity>(q => new Quantity { 
                value = new DecimalElement() { value = q.value }, 
                unit = new StringElement() { value = q.unit ?? throw new InvalidOperationException("Quantity must have a unit") } 
            });
            converter.AddConversion<CqlInterval<CqlQuantity>, Fhir.R4.Model.Range>(r => new Fhir.R4.Model.Range() {
                low = new Quantity() { 
                    value = new DecimalElement() { value = r.low.value }, 
                    unit = new StringElement() { value = r.low.unit ?? throw new InvalidOperationException("Quantity must have a unit") } 
                },
                high = new Quantity() { 
                    value = new DecimalElement() { value = r.high.value }, 
                    unit = new StringElement() { value = r.high.unit ?? throw new InvalidOperationException("Quantity must have a unit") } 
                },
            });

            converter.AddConversion<CqlInterval<decimal?>, Fhir.R4.Model.Range>(r => new Fhir.R4.Model.Range() {
                low = new Quantity()
                {
                    value = new DecimalElement() { value = r.low }
                },
                high = new Quantity()
                {
                    value = new DecimalElement() { value = r.high }
                },
            });

            converter.AddConversion<CqlInterval<int?>, Fhir.R4.Model.Range>(r => new Fhir.R4.Model.Range() {
                low = new Quantity()
                {
                    value = new DecimalElement() { value = r.low }
                },
                high = new Quantity()
                {
                    value = new DecimalElement() { value = r.high }
                },
            });

            converter.AddConversion<CqlRatio, Ratio>(r =>
                new Ratio()
                {
                    numerator = new Quantity() { 
                        value = new DecimalElement() { value = r.numerator?.value }, 
                        unit = new StringElement() { value = r.numerator?.unit ?? throw new InvalidOperationException("Quantity must have a unit") } 
                    },
                    denominator = new Quantity() { 
                        value = new DecimalElement() { value = r.denominator?.value }, 
                        unit = new StringElement() { value = r.denominator?.unit ?? throw new InvalidOperationException("Quantity must have a unit") } 
                    },
                }
            );

            converter.AddConversion<CqlInterval<CqlDateTime>, CqlInterval<DateTimeElement>>(i =>
                new CqlInterval<DateTimeElement>(i.low?.Value!, i.high?.Value!, i.lowClosed, i.highClosed));

            converter.AddConversion<CqlInterval<CqlDateTime>, Period>(period => new Period() { 
                start = new DateTimeElement() { 
                    value = new Iso8601.DateTimeIso8601(
                        period.low.Value.Year, period.low.Value.Month, period.low.Value.Day, 
                        period.low.Value.Hour, period.low.Value.Minute, period.low.Value.Second, period.low.Value.Millisecond, 
                        period.low.Value.OffsetHour, period.low.Value.OffsetMinute) 
                },
                end = new DateTimeElement()
                {
                    value = new Iso8601.DateTimeIso8601(
                        period.high.Value.Year, period.high.Value.Month, period.high.Value.Day,
                        period.high.Value.Hour, period.high.Value.Minute, period.high.Value.Second, period.high.Value.Millisecond,
                        period.high.Value.OffsetHour, period.high.Value.OffsetMinute)
                }
            });
            converter.AddConversion<CqlInterval<CqlDate>, Period>(period => new Period()
            {
                start = new DateTimeElement()
                {
                    value = new Iso8601.DateTimeIso8601(
                        period.low.Value.Year, period.low.Value.Month, period.low.Value.Day,
                        null, null, null, null, null, null)
                },
                end = new DateTimeElement()
                {
                    value = new Iso8601.DateTimeIso8601(
                        period.high.Value.Year, period.high.Value.Month, period.high.Value.Day,
                        null, null, null, null, null, null)
                }
            });
            return converter;
        }

        public static TypeConverter ConvertToSystemTypes(this TypeConverter converter)
        {
            converter.AddConversion<string, IdElement>(@string => new IdElement { value = @string });
            converter.AddConversion<IdElement, string?>(element => element?.value);
            converter.AddConversion<string, CodeElement>(@string => new CodeElement { value = @string });
            converter.AddConversion<CodeElement, string?>(element => element?.value);
            converter.AddConversion<string, StringElement>(@string => new StringElement { value = @string });
            converter.AddConversion<StringElement, string?>(element => element?.value);
            converter.AddConversion<string, UriElement>(@string => new UriElement { value = @string });
            converter.AddConversion<UriElement, string?>(element => element?.value);

            converter.AddConversion<DateElement, CqlDate>(d => new CqlDate(d.value.Year, d.value.Month, d.value.Day));
            converter.AddConversion<DateTimeElement, CqlDateTime>(d =>
                new CqlDateTime(
                    d.value.Year, d.value.Month, d.value.Day,
                    d.value.Hour, d.value.Minute, d.value.Second, d.value.Millisecond,
                    d.value.OffsetHour, d.value.OffsetMinute
                ));
            converter.AddConversion<TimeElement, CqlTime>(d =>
                new CqlTime(
                    d.value.Hour, d.value.Minute, d.value.Second, d.value.Millisecond,
                    d.value.OffsetHour, d.value.OffsetMinute
                ));
            converter.AddConversion<InstantElement, CqlDateTime>(d =>
                new CqlDateTime(
                    d.value.Year, d.value.Month, d.value.Day,
                    d.value.Hour, d.value.Minute, d.value.Second, d.value.Millisecond,
                    d.value.OffsetHour, d.value.OffsetMinute
                ));

            converter.AddConversion<Quantity, CqlQuantity>(q => new CqlQuantity(q.value.value, q.unit.value));
            converter.AddConversion<Fhir.R4.Model.Range, CqlInterval<CqlQuantity>>(r =>
                new CqlInterval<CqlQuantity>(
                    new CqlQuantity(r.low.value.value, r.low.unit),
                    new CqlQuantity(r.high.value.value, r.high.unit),
                    true,
                    true));
            converter.AddConversion<Fhir.R4.Model.Range, CqlInterval<decimal?>>(r =>
               new CqlInterval<decimal?>(
                   r.low.value.value,
                   r.high.value.value,
                   true,
                   true));

            converter.AddConversion<Fhir.R4.Model.Range, CqlInterval<int?>>(r =>
               new CqlInterval<int?>(
                   (int?)r.low.value.value,
                   (int?)r.high.value.value,
                   true,
                   true));

            converter.AddConversion<Ratio, CqlRatio>(r => 
                new CqlRatio(
                    new CqlQuantity() {value = r.numerator.value.value, unit = r.numerator.unit},
                    new CqlQuantity() { value = r.denominator.value.value, unit = r.denominator.unit }
                ));

            converter.AddConversion<Period, CqlInterval<CqlDateTime>>(period =>
                new CqlInterval<CqlDateTime>(
                    new CqlDateTime(period.start.value),
                    new CqlDateTime(period.end.value),
                    true,
                    true));
            converter.AddConversion<Period, CqlInterval<CqlDate>>(period =>
                new CqlInterval<CqlDate>(
                    new CqlDate(period.start.value.Year, period.start.value.Month, period.start.value.Day),
                    new CqlDate(period.end.value.Year, period.end.value.Month, period.end.value.Day),
                    true,
                    true));
            return converter;
        }
    }
}
