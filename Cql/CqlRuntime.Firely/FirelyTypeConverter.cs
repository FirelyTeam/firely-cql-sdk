using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using Ncqa.Cql.Runtime.Conversion;
using Ncqa.Cql.Runtime.Primitives;
using System;
using System.Reflection;
using System.Security.AccessControl;

namespace Ncqa.Cql.Runtime.Firely
{
    public class FirelyTypeConverter : TypeConverter
    {
        public static readonly FirelyTypeConverter Default = (new FirelyTypeConverter()
            .ConvertSystemTypes()
            .ConvertIsoToCqlPrimitives() as FirelyTypeConverter)!
            .ConvertFhirToCqlPrimitives()
            .ConvertParametersToCql()
            .ConvertEnumToCode();
        private FirelyTypeConverter()
        {
            
        }

        protected FirelyTypeConverter ConvertFhirToCqlPrimitives()
        {
            AddConversion<string, Id>(@string => new Id { Value = @string });
            AddConversion<Id, string?>(element => element?.Value);
            AddConversion<string, Code>(@string => new Code { Value = @string });
            AddConversion<Code, string?>(element => element?.Value);
            AddConversion<string, FhirString>(@string => new FhirString { Value = @string });
            AddConversion<FhirString, string?>(element => element?.Value);
            AddConversion<string, FhirUri>(@string => new FhirUri { Value = @string });
            AddConversion<FhirUri, string?>(element => element?.Value);

            //AddConversion(typeof(decimal?), typeof(FhirDecimal), d => new FhirDecimal((decimal?)d));
            
            AddConversion<string, CqlDate>(d => new CqlDate(d));
            AddConversion(typeof(DateTimeOffset?), typeof(CqlDateTime), d =>
            {
                var dt = (DateTimeOffset?)d;
                return new CqlDateTime(
                    dt.Value.Year,
                    dt.Value.Month,
                    dt.Value.Day,
                    dt.Value.Hour,
                    dt.Value.Minute,
                    dt.Value.Second,
                    dt.Value.Millisecond,
                    dt.Value.Offset.Hours,
                    dt.Value.Offset.Minutes);
            });

            AddConversion<string, CqlDateTime>(d => new CqlDateTime(d));
            AddConversion<string, CqlTime>(d => new CqlTime(d));
            AddConversion<string, FhirDateTime>(d => new FhirDateTime(d));
            AddConversion<byte[], string>(d => d?.ToString() ?? "");

            AddConversion<FhirDateTime, CqlDate>(d => new CqlDate(d.Value));
            AddConversion<FhirDateTime, CqlDateTime>(d => new CqlDateTime(d.Value));
            AddConversion<Time, CqlTime>(d => new CqlTime(d.Value));

            AddConversion<Quantity, CqlQuantity>(q => new CqlQuantity(q.Value, q.Unit));
            AddConversion<Hl7.Fhir.Model.Range, CqlInterval<CqlQuantity>>(r =>
                new CqlInterval<CqlQuantity>(
                    new CqlQuantity(r.Low.Value, r.Low.Unit),
                    new CqlQuantity(r.High.Value, r.High.Unit),
                    true,
                    true));

            AddConversion<Ratio, CqlRatio>(r =>
                new CqlRatio(
                    new CqlQuantity() { value = r.Numerator.Value, unit = r.Numerator.Unit },
                    new CqlQuantity() { value = r.Denominator.Value, unit = r.Denominator.Unit }
                ));

            AddConversion<Period, CqlInterval<CqlDateTime>>(period =>
                new CqlInterval<CqlDateTime>(
                    new CqlDateTime(period.Start),
                    new CqlDateTime(period.End),
                    true,
                    true));
            AddConversion<Period, CqlInterval<CqlDate>>(period =>
                new CqlInterval<CqlDate>(
                    new CqlDate(period.Start),
                    new CqlDate(period.End),
                    true,
                    true));

            return this;
        }

        protected FirelyTypeConverter ConvertParametersToCql()
        {
            AddConversion<Parameters.ParameterComponent, CqlDate>(p =>
            {
                if (p.Value is Date valueDate) return Convert<CqlDate>(valueDate);
                else if (p.Value is FhirDateTime) throw new InvalidOperationException("Cannot convert parameter type DateTime to CqlDate");
                else if (p.Value is FhirString valueString) return Convert<CqlDate>(valueString);
                return null;
            });

            AddConversion<Parameters.ParameterComponent, CqlDateTime>(p =>
            {
                if (p.Value is Date) throw new InvalidOperationException("Cannot convert parameter type Date to CqlDateTime");
                else if (p.Value is FhirDateTime valueDateTime) return Convert<CqlDateTime>(valueDateTime);
                else if (p.Value is FhirString valueString) return Convert<CqlDateTime>(valueString);
                return null;
            });

            AddConversion<Parameters.ParameterComponent, CqlTime>(p =>
            {
                if (p.Value is Date) throw new InvalidOperationException("Cannot convert parameter type Date to CqlDateTime");
                else if (p.Value is FhirDateTime valueTime) return Convert<CqlTime>(valueTime);
                else if (p.Value is FhirString valueString) return Convert<CqlTime>(valueString);
                return null;
            });

            AddConversion<Parameters.ParameterComponent, CqlRatio>(p =>
            {
                if (p.Value is Ratio valueRatio) return Convert<CqlRatio>(valueRatio);
                return null;
            });

            AddConversion<Parameters.ParameterComponent, CqlQuantity>(p =>
            {
                if (p.Value is Quantity valueQuantity) return Convert<CqlQuantity>(valueQuantity);
                return null;
            });

            AddConversion<Parameters.ParameterComponent, CqlInterval<CqlDateTime>>(p =>
            {
                if (p.Value is Period valuePeriod) return Convert<CqlInterval<CqlDateTime>>(valuePeriod);
                return null;
            });
            AddConversion<Parameters.ParameterComponent, CqlInterval<CqlDate>>(p =>
            {
                if (p.Value is Period valuePeriod) return Convert<CqlInterval<CqlDate>>(valuePeriod);
                return null;
            });
            AddConversion<Parameters.ParameterComponent, CqlInterval<int>>(p =>
            {
                if (p.Value is Hl7.Fhir.Model.Range valueRange) return Convert<CqlInterval<int>>(valueRange);
                return null;
            });
            AddConversion<Parameters.ParameterComponent, CqlInterval<decimal>>(p =>
            {
                if (p.Value is Hl7.Fhir.Model.Range valueRange) return Convert<CqlInterval<decimal>>(valueRange);
                return null;
            });
            AddConversion<Parameters.ParameterComponent, CqlInterval<CqlQuantity>>(p =>
            {
                if (p.Value is Hl7.Fhir.Model.Range valueRange) return Convert<CqlInterval<CqlQuantity>>(valueRange);
                return null;
            });

            AddConversion<Parameters.ParameterComponent, string>(p =>
            {
                if (p.Value is FhirString valueString) return valueString.Value;
                return null;
            });
            AddConversion<Parameters.ParameterComponent, int?>(p =>
            {
                if (p.Value is Integer valueInteger) return valueInteger.Value;
                if (p.Value is PositiveInt valuePositiveInt) return valuePositiveInt.Value;
                return null;
            });
            AddConversion<Parameters.ParameterComponent, int>(p =>
            {
                if (p.Value is Integer valueInteger) return valueInteger.Value ?? default;
                if (p.Value is PositiveInt valuePositiveInt) return valuePositiveInt.Value ?? default;
                return default;
            });
            AddConversion<Parameters.ParameterComponent, decimal?>(p =>
            {
                if (p.Value is FhirDecimal valueDecimal) return valueDecimal.Value;
                return null;
            });
            AddConversion<Parameters.ParameterComponent, decimal>(p =>
            {
                if (p.Value is FhirDecimal valueDecimal) return valueDecimal.Value ?? default;
                return default;
            });
            AddConversion<Parameters.ParameterComponent, bool?>(p =>
            {
                if (p.Value is FhirBoolean valueBoolean) return valueBoolean.Value ?? null;
                return null;
            });
            AddConversion<Parameters.ParameterComponent, bool>(p =>
            {
                if (p.Value is FhirBoolean valueBoolean) return valueBoolean.Value ?? default;
                return default;
            });

            return this;
        }

        protected FirelyTypeConverter ConvertEnumToCode()
        {
            // get all enum types from both assemblies
            var enumTypes = typeof(Resource).Assembly
                .GetTypes()
                .Concat(typeof(AdministrativeGender).Assembly.GetTypes())
                .Where(t => t.IsEnum 
                    && t.GetCustomAttributes(typeof(FhirEnumerationAttribute), false).Length > 0);

            foreach (var type in enumTypes)
            {
                var enumType = type.GetCustomAttributes(typeof(FhirEnumerationAttribute), false).FirstOrDefault();
                if (enumType != null)
                {
                    // add nullable and non-nullable conversion
                    var nullable = typeof(Nullable<>).MakeGenericType(type);
                    AddConversion(nullable, typeof(Code), p => {
                        var enumValue = type.GetField(p?.ToString() ?? "");
                        var attribute = enumValue?.GetCustomAttribute(typeof(EnumLiteralAttribute)) as EnumLiteralAttribute;

                        return new Code
                        {
                            Value = attribute?.Literal,
                            //System = system
                        };
                    });

                    AddConversion(nullable, typeof(string), p => p?.ToString() ?? "");
                    AddConversion(type, typeof(Code), p => {
                        var enumValue = type.GetField(p?.ToString() ?? "");
                        var attribute = enumValue?.GetCustomAttribute(typeof(EnumLiteralAttribute)) as EnumLiteralAttribute;

                        return new Code
                        {
                            Value = attribute?.Literal,
                            //System = system
                        };
                    });

                    AddConversion(type, typeof(string), p => {
                        var enumValue = type.GetField(p?.ToString() ?? "");
                        var attribute = enumValue?.GetCustomAttribute(typeof(EnumLiteralAttribute)) as EnumLiteralAttribute;

                        return attribute?.Literal ?? "";
                    });
                }
            }

            return this;
        }
    }
}
