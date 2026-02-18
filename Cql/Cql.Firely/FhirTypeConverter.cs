/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Conversion;
using Hl7.Cql.Primitives;
using Hl7.Cql.Operators;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Utility;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Fhir.Model;
using M = Hl7.Fhir.Model;

namespace Hl7.Cql.Fhir
{
    /// <summary>
    /// Defines conversions between Cql and FHIR data models
    /// </summary>
    public static class FhirTypeConverter
    {
        internal const int DefaultCacheSize = 10_000;

        internal static bool DisableReuseForBenchmarks = false;
        private static readonly LRUCache<CqlDateTime> DefaultDateTimesCache = new(DefaultCacheSize);
        private static readonly Lazy<TypeConverter> DefaultLazy = new(() => CreateImpl(M.ModelInfo.ModelInspector));
        private static readonly Lazy<TypeConverter> DefaultWithCacheLazy = new(() => CreateImpl(M.ModelInfo.ModelInspector, DefaultCacheSize));

        /// <summary>
        /// Singleton for the default configuration of this TypeConverter
        /// </summary>
        public static TypeConverter Default => DefaultLazy.Value;

        /// <summary>
        /// Singleton for the default configuration of this TypeConverter with an LRU cache of 10000
        /// </summary>
        internal static TypeConverter DefaultWithCache => DefaultWithCacheLazy.Value;

        private static readonly ConcurrentDictionary<(ModelInspector, int?), WeakReference<TypeConverter>> ConverterCache = new ();

        /// <summary>
        /// Allows for the creation of a converter with the specified model
        /// </summary>
        /// <param name="model">the model</param>
        /// <param name="cacheSize">the size of the LRU cache</param>
        /// <returns>the type converter</returns>
        public static TypeConverter Create(ModelInspector model, int? cacheSize = null)
        {
            if (DisableReuseForBenchmarks)
                return CreateImpl(model, cacheSize ?? 0);

            return (cacheSize ?? 0) switch
            {
                < 0 => throw new ArgumentOutOfRangeException(nameof(cacheSize), cacheSize, "CacheSize cannot be negative."),
                0 when model == M.ModelInfo.ModelInspector                         => Default,
                DefaultCacheSize when model == M.ModelInfo.ModelInspector => DefaultWithCache,
                { } size                                                           => GetOrCreateConverter(model, size)
            };

            static TypeConverter GetOrCreateConverter(ModelInspector model, int cacheSize)
            {
                var key = (model, cacheSize);
                if (ConverterCache.TryGetValue(key, out var weakRef) && weakRef.TryGetTarget(out var converter))
                {
                    return converter;
                }

                var newConverter = CreateImpl(model, cacheSize);
                ConverterCache[key] = new WeakReference<TypeConverter>(newConverter);
                return newConverter;
            }
        }

        private static readonly ConcurrentDictionary<int, WeakReference<LRUCache<CqlDateTime>>> LRUCacheCache = new();

        private static TypeConverter CreateImpl(ModelInspector model, int cacheSize = 0)
        {
            LRUCache<CqlDateTime>? dateTimesCache = cacheSize switch
            {
                < 0 => throw new ArgumentOutOfRangeException(nameof(cacheSize), cacheSize, "CacheSize cannot be negative."),
                0                         => null,
                DefaultCacheSize => DefaultDateTimesCache,
                _                         => GetOrCreateLRUCache(cacheSize)
            };

            static LRUCache<CqlDateTime> GetOrCreateLRUCache(int cacheSize)
            {
                if (LRUCacheCache.TryGetValue(cacheSize, out var weakRef) && weakRef.TryGetTarget(out var lruCache))
                {
                    return lruCache;
                }

                var newLRUCache = new LRUCache<CqlDateTime>(cacheSize);
                LRUCacheCache[cacheSize] = new WeakReference<LRUCache<CqlDateTime>>(newLRUCache);
                return newLRUCache;
            }

            var converter = TypeConverter
                            .Create()
                            .ConvertDataTypeChoices()
                            .CreateQuantityConversions()
                            .ConvertSystemTypes()
                            .ConvertFhirToCqlPrimitives(dateTimesCache)
                            .ConvertCqlPrimitivesToFhir()
                            .ConvertCodeTypes(model)
                            .ConvertEnumToStrings()
                            .ConvertSubtypeRelationships()
                ;
            return converter;
        }

        internal static TypeConverter CreateQuantityConversions(this TypeConverter converter)
        {
            converter.AddConversion<M.Quantity, M.Age>(q =>
            {
                var a = new M.Age();
                q.CopyTo(a);
                return a;
            });
            return converter;
        }

        internal static TypeConverter ConvertFhirToCqlPrimitives(
            this TypeConverter converter,
            LRUCache<CqlDateTime>? dateTimes = null)
        {
            HashSet<Type> toTypes = new();

            add((M.Integer p) => p.Value);
            add((M.FhirString p) => p.Value);
            add((M.FhirBoolean p) => p.Value);
            add((M.FhirDecimal p) => p.Value);
            add((M.Markdown p) => p.Value);
            add((M.Instant p) => p.Value);
            add((M.Instant p) => p.Value switch
            {
                { } dto => new CqlDateTime(dto.Year, dto.Month, dto.Day, dto.Hour, dto.Minute, dto.Second, dto.Millisecond, dto.Offset.Hours, dto.Offset.Minutes),
                _ => null
            });
            add((M.FhirUrl p) => p.Value);
            add((M.Integer c) => new M.UnsignedInt(c.Value));
            add((M.Integer c) => new M.PositiveInt(c.Value));
            add((M.Code c) => c.Value);
            add((M.Date f) => f.TryToSystemDate(out var date) ? new CqlDate(date!.Years!.Value, date.Months, date.Days) : null);
            add((M.Date f) => f.TryToSystemDate(out var date) ? new CqlDateTime(date!.Years!.Value, date.Months, date.Days, 0, 0, 0, 0, 0, 0) : null);
            add((M.Date f) => f.ToString());
            add((M.Time f) => f.TryToSystemTime(out var time) ? new CqlTime(time!.Hours!.Value, time.Minutes, time.Seconds, time.Millis, null, null) : null);
            add((M.Time f) => f.ToString());
            add((M.FhirDateTime f) => FhirDateTimeToCqlDateTimeViaCaching(f));
            add((M.FhirDateTime f) => f.ToString());
            add((M.FhirDateTime f) => FhirDateTimeToCqlDateTimeViaCaching(f)?.DateOnly);
            add((M.Quantity f) => new CqlQuantity(f.Value, f.Unit));
            add((M.Quantity f) => f.Value);
            add((M.Quantity f) => (int?)f.Value);
            add((M.Period f) => new CqlInterval<CqlDateTime>(converter.Convert<CqlDateTime>(f.StartElement), converter.Convert<CqlDateTime>(f.EndElement), lowClosed: true, highClosed: true));
            add((M.Period f) => new CqlInterval<CqlDate>(converter.Convert<CqlDate>(f.StartElement), converter.Convert<CqlDate>(f.EndElement), lowClosed: true, highClosed: true));
            add((M.Range f) => new CqlInterval<CqlQuantity>(converter.Convert<CqlQuantity>(f.Low), converter.Convert<CqlQuantity>(f.High), lowClosed: true, highClosed: true));
            add((M.Range f) => new CqlInterval<decimal?>(converter.Convert<decimal?>(f.Low), converter.Convert<decimal?>(f.High), lowClosed: true, highClosed: true));
            add((M.Range f) => new CqlInterval<int?>(converter.Convert<int?>(f.Low), converter.Convert<int?>(f.High), lowClosed: true, highClosed: true));

            add((M.Id id) => id.Value);

            add((M.PositiveInt pi) => new M.Integer(pi.Value));
            add((M.PositiveInt pi) => pi.ToString());
            add((M.UnsignedInt ui) => new M.Integer(ui.Value));
            add((M.UnsignedInt ui) => ui.ToString());
            add((M.DataType dt) => ConvertChoiceTypeToString(dt));

            add((M.Canonical c) => c.ToString());

            addParametersToCqlPrimitivesConverters(toTypes);
            return converter;

            // Add a basic Fhir primitive->Cql primitive conversion
            void add<I, O>(Func<I, O> tos)
            {
                converter.AddConversion(tos);
                toTypes.Add(typeof(O));
            }

            // Add a ParameterComponent->Cql primitive via the now registered basic conversion.
            void addParametersToCqlPrimitivesConverters(IEnumerable<Type> tos)
            {
                foreach (Type t in tos) converter.AddConversion(typeof(M.Parameters.ParameterComponent), t,
                    f => converter.Convert(((M.Parameters.ParameterComponent)f).Value, t)!);
            }

            // This is our implementation of FHIRHelpers.ToString() for the basic datatypes,
            // since the ELM->CQL generator does not always insert a ToString() where we would
            // need it (i.e. when it know that a choice type is a string, but we don't).
            string? ConvertChoiceTypeToString(M.DataType dt)
            {
                return dt switch
                {
                    M.FhirString fs => fs.Value,
                    M.PrimitiveType { JsonValue: string os } => os,
                    M.PrimitiveType pt => pt.JsonValue?.ToString(),
                    _ => throw new InvalidCastException($"Cannot cast a FHIR value of type {dt.TypeName} to a string")
                };
            }

            CqlDateTime? FhirDateTimeToCqlDateTimeViaCaching(M.FhirDateTime f)
            {
                if (f.Value is null)
                    return null;

                if (dateTimes?.TryGetValue(f.Value, out var datetime) ?? false)
                    return datetime;

                if (!f.TryToSystemDateTime(out var dt))
                    return null;

                var cqlDateTime = new CqlDateTime(
                    dt!.Years!.Value, dt.Months,
                    dt.Days, dt.Hours, dt.Minutes, dt.Seconds, dt.Millis,
                    dt.HasOffset ? dt.Offset!.Value.Hours : null, dt.HasOffset ? dt.Offset!.Value.Minutes : null);

                dateTimes?.Insert(f.Value, cqlDateTime);
                return cqlDateTime;

            }
        }

        private class DataTypeSubTypeConverter(TypeConverter converter) : ITypeConverterEntry
        {
            public bool Handles(Type from, Type to) => from == typeof(M.DataType);

            public object? Convert(object? instance, Type to)
            {
                var toIsDataType = to.IsAssignableTo(typeof(M.DataType));
                return (instance, toIsDataType) switch
                {
                    (M.DataType, true) => instance,
                    (M.DataType dt, false) => converter.Convert(instance, to),
                    _ => null
                };
            }
        }

        internal static TypeConverter ConvertDataTypeChoices(this TypeConverter converter)
        {
            converter.AddConverter(new DataTypeSubTypeConverter(converter));
            return converter;
        }

        private class EnumToStringTypeConverterEntry : ITypeConverterEntry
        {
            public bool Handles(Type from, Type to)
            {
                var shouldHandle = IsFhirEnum(from)
                    && to == typeof(string);
                return shouldHandle;
            }

            public object? Convert(object? instance, Type to) =>
                instance is Enum e ? e.GetLiteral() : null;
        }

        internal static bool IsFhirEnum(Type from) =>
            (from.IsNullable(out var nonNullableType) || true)
            &&
            nonNullableType.IsEnum
            && nonNullableType.GetCustomAttribute<FhirEnumerationAttribute>() is { };

        internal static TypeConverter ConvertEnumToStrings(this TypeConverter converter)
        {
            converter.AddConverter(new EnumToStringTypeConverterEntry());
            return converter;
        }

        internal static TypeConverter ConvertCqlPrimitivesToFhir(this TypeConverter converter)
        {
            converter.AddConversion((CqlDate f) => new M.Date(f.ToString()));
            converter.AddConversion((CqlDateTime f) => new M.FhirDateTime(f.ToString()));
            converter.AddConversion((CqlDate f) => new M.FhirDateTime(f.ToString()));
            converter.AddConversion((CqlTime f) => new M.Time(f.ToString()));
            converter.AddConversion((CqlQuantity f) => f.value is not null ? new M.Quantity(f.value.Value, f.unit ?? "1", Hl7.Fhir.ElementModel.Types.Quantity.UCUM) : null);
            converter.AddConversion((CqlInterval<CqlQuantity>? interval) =>
            {
                if (interval is null)
                    return null;
                else
                {
                    var range = new M.Range();
                    if (interval.low is { value: { } low, unit: var lowUnit })
                    {
                        range.Low = new M.Quantity(low, lowUnit ?? "1");
                    }

                    if (interval.high is { value: { } high, unit: var highUnit })
                    {
                        range.High = new M.Quantity(high, highUnit ?? "1");
                    }
                    return range;
                }
            });
            converter.AddConversion((CqlInterval<decimal?> interval) =>
            {
                if (interval is null)
                    return null;
                else
                {
                    var range = new M.Range();
                    if (interval.low is { } low)
                    {
                        range.Low = new M.Quantity(low, "1");
                    }

                    if (interval.high is { } high)
                    {
                        range.High = new M.Quantity(high, "1");
                    }
                    return range;
                }
            });
            converter.AddConversion((CqlInterval<int?> interval) =>
            {
                if (interval is null)
                    return null;
                else
                {
                    var range = new M.Range();
                    if (interval.low is { } low)
                    {
                        range.Low = new M.Quantity(low, "1");
                    }

                    if (interval.high is { } high)
                    {
                        range.High = new M.Quantity(high, "1");
                    }
                    return range;
                }
            });
            converter.AddConversion((CqlInterval<CqlDateTime> interval) =>
            {
                if (interval is null)
                    return null;
                else
                {
                    var period = new M.Period();
                    if (interval.low is { } low)
                    {
                        period.Start = low.ToString();
                    }

                    if (interval.high is { } high)
                    {
                        period.End = high.ToString();
                    }
                    return period;
                }
            });
            converter.AddConversion((CqlInterval<CqlDate> interval) =>
            {
                if (interval is null)
                    return null;
                else
                {
                    var period = new M.Period();
                    if (interval.low is { } low)
                    {
                        period.Start = low.ToString();
                    }

                    if (interval.high is { } high)
                    {
                        period.End = high.ToString();
                    }
                    return period;
                }
            });
            converter.AddConversion((CqlRatio f) => (f.denominator is not null && f.numerator is not null) ?
                new M.Ratio(converter.Convert<M.Quantity>(f.numerator)!, converter.Convert<M.Quantity>(f.denominator)!) : null);

            return converter;
        }

        internal static TypeConverter ConvertSystemTypes(this TypeConverter converter)
        {
            converter.AddConversion<byte[], string>(binary => Encoding.UTF8.GetString(binary));
            converter.AddConversion<DateTimeOffset?, CqlDateTime?>(dto => dto == null ? null : new CqlDateTime(dto.Value, Iso8601.DateTimePrecision.Millisecond));
            converter.AddConversion<DateTimeOffset, CqlDateTime>(dto => new CqlDateTime(dto, Iso8601.DateTimePrecision.Millisecond));
            
            // TODO: this is a performance problem
            // CQL string conversions - return null on invalid input
            converter.AddConversion<string, bool?>(s => ConvertStringToBoolean(s));
            converter.AddConversion<string, int?>(s => ConvertStringToInteger(s));
            converter.AddConversion<string, long?>(s => ConvertStringToLong(s));
            converter.AddConversion<string, decimal?>(s => ConvertStringToDecimal(s));
            converter.AddConversion<string, CqlQuantity?>(s => ConvertStringToQuantity(s));
            converter.AddConversion<string, CqlDate?>(s => ConvertStringToDate(s));
            converter.AddConversion<string, CqlDateTime?>(s => ConvertStringToDateTime(s));
            converter.AddConversion<string, CqlTime?>(s => ConvertStringToTime(s));
            
            converter.AddConversion<string, M.FhirUri>(str => new M.FhirUri(str));
            converter.AddConversion<string, M.FhirString>(str => new M.FhirString(str));
            converter.AddConversion<M.FhirUri, string?>(uri => uri.Value);
            converter.AddConversion<M.FhirUri, M.FhirString?>(uri => new M.FhirString(uri.Value));

            return converter;
        }

        // CQL conversion helper methods that return null on invalid input
        private static bool? ConvertStringToBoolean(string? s) =>
            CqlOperators.ConvertStringToBooleanImpl(s);

        private static int? ConvertStringToInteger(string? s) =>
            s == null ? null :
            int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out int value) ? value : null;

        private static long? ConvertStringToLong(string? s) =>
            s == null ? null :
            long.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out long value) ? value : null;

        private static decimal? ConvertStringToDecimal(string? s) =>
            s == null ? null :
            decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal value) ? value : null;

        private static CqlQuantity? ConvertStringToQuantity(string? s) =>
            s == null ? null :
            CqlQuantity.TryParse(s, out CqlQuantity? value) ? value : null;

        private static CqlDate? ConvertStringToDate(string? s) =>
            s == null ? null :
            CqlDate.TryParse(s, out CqlDate? value) ? value : null;

        private static CqlDateTime? ConvertStringToDateTime(string? s) =>
            s == null ? null :
            CqlDateTime.TryParse(s, out CqlDateTime? value) ? value : null;

        private static CqlTime? ConvertStringToTime(string? s) =>
            s == null ? null :
            CqlTime.TryParse(s, out CqlTime? value) ? value : null;

        internal static TypeConverter ConvertCodeTypes(this TypeConverter converter, ModelInspector model)
        {
            var enumTypes = model.EnumMappings
                .Select(map => map.NativeType)
                .Concat(model.ClassMappings
                    .SelectMany(map => map.NativeType
                        .GetNestedTypes()
                        .Where(t => t.GetCustomAttribute<FhirEnumerationAttribute>() != null)))
                .Distinct()
                .ToArray();

            foreach (var enumType in enumTypes)
            {
                addEnumConversion(enumType);
            }

            void addEnumConversion(Type enumType)
            {
                var codeOfEnumType = typeof(M.Code<>).MakeGenericType(enumType);
                var nullableEnumType = typeof(Nullable<>).MakeGenericType(enumType);

                converter.AddConversion(codeOfEnumType, typeof(CqlCode), code =>
                {
                    var systemAndCode = ((ICoded)code).ToCodings().Single();
                    return new CqlCode(systemAndCode.Code, systemAndCode.System);
                });
                converter.AddConversion(codeOfEnumType, nullableEnumType, code => code.GetType().GetProperty("ObjectValue")!.GetValue(code)!);
                converter.AddConversion(codeOfEnumType, typeof(string), code =>
                {
                    var systemAndCode = ((ICoded)code).ToCodings().Single();
                    return systemAndCode.Code!;
                });

                converter.AddConversion(nullableEnumType, codeOfEnumType, enumValue => Activator.CreateInstance(codeOfEnumType, enumValue)!);
                converter.AddConversion(nullableEnumType, typeof(string), (@enum) => Enum.GetName(nullableEnumType, @enum) ?? throw new InvalidOperationException($"Did not find enum member {@enum} on type {nullableEnumType}."));

                converter.AddConversion(enumType, codeOfEnumType, enumValue => Activator.CreateInstance(codeOfEnumType, enumValue)!);
            }
            return converter;
        }

        /// <summary>
        /// Adds conversions for types which the ELM model defines a type relationship that does not exist in the POCOs
        /// </summary>
        internal static TypeConverter ConvertSubtypeRelationships(this TypeConverter converter)
        {
            converter.AddConversion<M.Id, M.FhirString>(id => new M.FhirString(id.Value));
            converter.AddConversion<M.Code, M.FhirString>(code => new M.FhirString(code.Value));
            return converter;
        }
    }
}