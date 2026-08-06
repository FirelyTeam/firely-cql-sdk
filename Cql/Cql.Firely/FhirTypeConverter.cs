/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Conversion;
using Hl7.Cql.Iso8601;
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

        private static readonly ConcurrentDictionary<(ModelInspector, int?, (int, int)?), WeakReference<TypeConverter>> ConverterCache = new ();

        // Converters over the default model are held strongly, keyed by the cache size and default
        // timezone offset that distinguish them: building one reflects over every FHIR enum, and a
        // service creating a context per request on a host that is not on UTC would otherwise rebuild
        // it whenever a garbage collection clears the weak cache. The offsets in play come from host
        // timezones, so the live set is one or two entries; the bound keeps an unusual caller from
        // pinning memory, and anything past it falls back to the weak cache. A caller-supplied
        // ModelInspector stays weakly cached — the user's model is never pinned.
        private const int MaxStronglyCachedConverters = 64;
        private static readonly ConcurrentDictionary<(int CacheSize, (int, int)? Offset), TypeConverter> DefaultModelConverterCache = new();

        /// <summary>
        /// Allows for the creation of a converter with the specified model
        /// </summary>
        /// <param name="model">the model</param>
        /// <param name="cacheSize">the size of the LRU cache</param>
        /// <returns>the type converter</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="cacheSize"/> is negative.</exception>
        // RS0027 wants the overload carrying optional parameters to be the one with the most parameters. This
        // overload has shipped with its default and cannot grow a parameter without breaking binary compatibility,
        // so the default timezone offset is offered through a separate, fully explicit overload instead.
#pragma warning disable RS0027 // API with optional parameter(s) should have the most parameters amongst its public overloads
        public static TypeConverter Create(ModelInspector model, int? cacheSize = null) =>
            Create(model, cacheSize, defaultTimezoneOffset: null);
#pragma warning restore RS0027

        /// <summary>
        /// Allows for the creation of a converter with the specified model and default timezone offset.
        /// </summary>
        /// <param name="model">the model</param>
        /// <param name="cacheSize">the size of the LRU cache</param>
        /// <param name="defaultTimezoneOffset">the timezone offset used when a CQL value without one has to be
        /// emitted as a FHIR <c>dateTime</c> carrying a time component, which FHIR requires to have an offset;
        /// <see langword="null"/> means UTC. Per the CQL specification (§2 Author's Guide) this is the timezone
        /// offset of the evaluation request. It must be a whole number of minutes within ±14:00, and never applies
        /// to a FHIR <c>time</c> (which forbids an offset) or to a date-only <c>dateTime</c>.</param>
        /// <returns>the type converter</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="cacheSize"/> is negative, or
        /// <paramref name="defaultTimezoneOffset"/> is not a whole number of minutes within ±14:00.</exception>
        public static TypeConverter Create(ModelInspector model, int? cacheSize, TimeSpan? defaultTimezoneOffset)
        {
            var offset = NormalizeDefaultTimezoneOffset(defaultTimezoneOffset);

            if (DisableReuseForBenchmarks)
                return CreateImpl(model, cacheSize ?? 0, offset);

            return (cacheSize ?? 0) switch
            {
                < 0 => throw new ArgumentOutOfRangeException(nameof(cacheSize), cacheSize, "CacheSize cannot be negative."),
                0 when model == M.ModelInfo.ModelInspector && offset is null                => Default,
                DefaultCacheSize when model == M.ModelInfo.ModelInspector && offset is null => DefaultWithCache,
                { } size when model == M.ModelInfo.ModelInspector                           => GetOrCreateDefaultModelConverter(size, offset),
                { } size                                                                    => GetOrCreateConverter(model, size, offset)
            };

            static TypeConverter GetOrCreateDefaultModelConverter(int cacheSize, (int Hours, int Minutes)? defaultTimezoneOffset)
            {
                var key = (cacheSize, ((int, int)?)defaultTimezoneOffset);
                if (DefaultModelConverterCache.TryGetValue(key, out var converter))
                    return converter;

                if (DefaultModelConverterCache.Count >= MaxStronglyCachedConverters)
                    return GetOrCreateConverter(M.ModelInfo.ModelInspector, cacheSize, defaultTimezoneOffset);

                // Racing callers may both build; the loser's converter is simply discarded, exactly as
                // in the weak cache below.
                return DefaultModelConverterCache.GetOrAdd(key,
                    static k => CreateImpl(M.ModelInfo.ModelInspector, k.CacheSize, k.Offset));
            }

            static TypeConverter GetOrCreateConverter(ModelInspector model, int cacheSize, (int Hours, int Minutes)? defaultTimezoneOffset)
            {
                var key = (model, (int?)cacheSize, ((int, int)?)defaultTimezoneOffset);
                if (ConverterCache.TryGetValue(key, out var weakRef) && weakRef.TryGetTarget(out var converter))
                {
                    return converter;
                }

                // A miss is where the entries left behind by collected converters get dropped, so the
                // cache holds at most one tombstone per key between misses instead of accumulating one
                // per key ever asked for. TryRemove(KeyValuePair) only removes an entry still holding
                // the reference just observed to be dead, so a concurrent re-add survives.
                foreach (var entry in ConverterCache)
                {
                    if (!entry.Value.TryGetTarget(out _))
                        ConverterCache.TryRemove(entry);
                }

                var newConverter = CreateImpl(model, cacheSize, defaultTimezoneOffset);
                ConverterCache[key] = new WeakReference<TypeConverter>(newConverter);
                return newConverter;
            }
        }

        // The widest timezone offset FHIR and ISO 8601 admit.
        private static readonly TimeSpan MaxTimezoneOffset = TimeSpan.FromHours(14);

        /// <summary>
        /// The single rule every default timezone offset has to satisfy, wherever it enters the SDK: a whole
        /// number of minutes within ±14:00. <paramref name="paramName"/> names the parameter or property the
        /// caller supplied it through, so the failure points at that instead of at an internal parameter.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="offset"/> is not a whole number of
        /// minutes within ±14:00.</exception>
        internal static TimeSpan? ValidateDefaultTimezoneOffset(TimeSpan? offset, string paramName)
        {
            if (offset is not { } value)
                return null;

            if (value.Ticks % TimeSpan.TicksPerMinute != 0)
                throw new ArgumentOutOfRangeException(paramName, offset,
                    "A timezone offset must be a whole number of minutes.");

            if (value < -MaxTimezoneOffset || value > MaxTimezoneOffset)
                throw new ArgumentOutOfRangeException(paramName, offset,
                    "A timezone offset must be within ±14:00.");

            return offset;
        }

        // A zero offset renders as 'Z', exactly like an absent default does, so it normalizes to "no default"
        // and keeps the shared singletons and cache entries of the default configuration in play.
        private static (int Hours, int Minutes)? NormalizeDefaultTimezoneOffset(TimeSpan? defaultTimezoneOffset)
        {
            if (ValidateDefaultTimezoneOffset(defaultTimezoneOffset, nameof(defaultTimezoneOffset)) is not { } offset
                || offset == TimeSpan.Zero)
                return null;

            return (offset.Hours, offset.Minutes);
        }

        private static readonly ConcurrentDictionary<int, WeakReference<LRUCache<CqlDateTime>>> LRUCacheCache = new();

        private static TypeConverter CreateImpl(
            ModelInspector model,
            int cacheSize = 0,
            (int Hours, int Minutes)? defaultTimezoneOffset = null)
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
                            .ConvertCqlPrimitivesToFhir(defaultTimezoneOffset)
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
            add((M.Code c) => new CqlCode { code = c.Value });
            add((M.Date f) => f.TryToSystemDate(out var date) ? new CqlDate(date!.Years!.Value, date.Months, date.Days) : null);
            add((M.Date f) => f.TryToSystemDate(out var date) ? new CqlDateTime(date!.Years!.Value, date.Months, date.Days, 0, 0, 0, 0, 0, 0) : null);
            add((M.Date f) => f.ToString());
            add((M.Time f) => FhirTimeToCqlTime(f));
            add((M.Time f) => f.ToString());
            add((M.FhirDateTime f) => FhirDateTimeToCqlDateTimeViaCaching(f));
            add((M.FhirDateTime f) => f.ToString());
            add((M.FhirDateTime f) => FhirDateTimeToCqlDateTimeViaCaching(f)?.DateOnly);
            add((M.Quantity f) => new CqlQuantity(f.Value, f.Unit));
            add((M.Quantity f) => f.Value);
            add((M.Quantity f) => (int?)f.Value);
            // Like the Quantity->int? conversion above, a fractional value is truncated towards zero
            // (the C# decimal->long conversion), and a value outside the range of long throws an OverflowException.
            add((M.Quantity f) => (long?)f.Value);
            add((M.Period f) => new CqlInterval<CqlDateTime>(converter.Convert<CqlDateTime>(f.StartElement), converter.Convert<CqlDateTime>(f.EndElement), lowClosed: true, highClosed: true));
            add((M.Period f) => new CqlInterval<CqlDate>(converter.Convert<CqlDate>(f.StartElement), converter.Convert<CqlDate>(f.EndElement), lowClosed: true, highClosed: true));
            add((M.Range f) => new CqlInterval<CqlQuantity>(converter.Convert<CqlQuantity>(f.Low), converter.Convert<CqlQuantity>(f.High), lowClosed: true, highClosed: true));
            add((M.Range f) => new CqlInterval<decimal?>(converter.Convert<decimal?>(f.Low), converter.Convert<decimal?>(f.High), lowClosed: true, highClosed: true));
            add((M.Range f) => new CqlInterval<int?>(converter.Convert<int?>(f.Low), converter.Convert<int?>(f.High), lowClosed: true, highClosed: true));
            add((M.Range f) => new CqlInterval<long?>(converter.Convert<long?>(f.Low), converter.Convert<long?>(f.High), lowClosed: true, highClosed: true));

            add((M.Id id) => id.Value);

            // Mirror the FHIRHelpers ToCode/ToConcept conversions, which the CQL type system
            // treats as implicit FHIR-to-System conversions.
            add((M.Coding c) => new CqlCode(c.Code, c.System, c.Version, c.Display));
            add((M.CodeableConcept cc) => new CqlConcept(
                cc.Coding?.Select(c => new CqlCode(c.Code, c.System, c.Version, c.Display)).ToList(),
                cc.Text));

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

                // A time-precision extension changes the resulting value, so such values cannot
                // share the string-keyed cache with unadorned ones.
                if (GetDeclaredTimePrecision(f) is { } declaredPrecision)
                    return FhirDateTimeToCqlDateTime(f, declaredPrecision);

                if (dateTimes?.TryGetValue(f.Value, out var datetime) ?? false)
                    return datetime;

                var cqlDateTime = FhirDateTimeToCqlDateTime(f, declaredPrecision: null);
                if (cqlDateTime is not null)
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

        internal static TypeConverter ConvertCqlPrimitivesToFhir(
            this TypeConverter converter,
            (int Hours, int Minutes)? defaultTimezoneOffset = null)
        {
            // A FHIR dateTime carrying a time component SHALL carry an offset, so a CQL value without one is
            // emitted with the default — rendered once here, since it is fixed for the converter's lifetime.
            var dateTimeOffsetWhenAbsent = defaultTimezoneOffset is { } offset
                ? new DefaultOffset(DateTimeIso8601.FormatKnownOffset(offset.Hours, offset.Minutes),
                    offset.Hours * 60 + offset.Minutes)
                : new DefaultOffset(Utc, 0);

            converter.AddConversion((CqlDate f) => new M.Date(f.ToString()));
            converter.AddConversion((CqlDateTime f) => CqlDateTimeToFhirDateTime(f, dateTimeOffsetWhenAbsent));
            converter.AddConversion((CqlDate f) => new M.FhirDateTime(f.ToString()));
            converter.AddConversion((CqlTime f) => CqlTimeToFhirTime(f));
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
            converter.AddConversion((CqlInterval<decimal?> interval) => interval is null
                ? null
                : NumericIntervalToRange(interval.low, interval.high, interval.lowClosed, interval.highClosed, CqlOperators.MinDecimalPrecisionValue));
            converter.AddConversion((CqlInterval<int?> interval) => interval is null
                ? null
                : NumericIntervalToRange(interval.low, interval.high, interval.lowClosed, interval.highClosed, 1m));
            converter.AddConversion((CqlInterval<long?> interval) => interval is null
                ? null
                : NumericIntervalToRange(interval.low, interval.high, interval.lowClosed, interval.highClosed, 1m));
            converter.AddConversion((CqlInterval<CqlDateTime> interval) =>
            {
                if (interval is null)
                    return null;
                else
                {
                    var period = new M.Period();
                    if (interval.low is { } low)
                    {
                        period.StartElement = CqlDateTimeToFhirDateTime(low, dateTimeOffsetWhenAbsent);
                    }

                    if (interval.high is { } high)
                    {
                        period.EndElement = CqlDateTimeToFhirDateTime(high, dateTimeOffsetWhenAbsent);
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
            converter.AddConversion((CqlInterval<CqlTime> interval) =>
            {
                if (interval is null)
                    return null;
                else
                {
                    var period = new M.Period();
                    if (interval.low is { } low)
                    {
                        period.StartElement = CqlTimeToFhirDateTime(low);
                    }

                    if (interval.high is { } high)
                    {
                        period.EndElement = CqlTimeToFhirDateTime(high);
                    }
                    return period;
                }
            });
            converter.AddConversion((CqlRatio f) => (f.denominator is not null && f.numerator is not null) ?
                new M.Ratio(converter.Convert<M.Quantity>(f.numerator)!, converter.Convert<M.Quantity>(f.denominator)!) : null);
            converter.AddConversion((CqlCode f) => new M.Coding(f.system, f.code, f.display) { Version = f.version });
            converter.AddConversion((CqlCode f) => new M.Code(f.code));
            // In FHIR R4 the CQL Long type maps to a FHIR string (see CqlTypeToFhirTypeMapper);
            // FHIR R5 hosts can convert to integer64 once that mapping is enabled.
            converter.AddConversion<long, M.FhirString>(l => new M.FhirString(l.ToString(CultureInfo.InvariantCulture)));
            converter.AddConversion((CqlConcept f) => new M.CodeableConcept
            {
                Coding = f.codes?.Select(c => new M.Coding(c.system, c.code, c.display) { Version = c.version }).ToList() ?? [],
                Text = f.display
            });

            return converter;
        }

        /// <summary>
        /// The extension conveying the actual precision of a time or dateTime value whose trailing time
        /// components were zero-padded to satisfy FHIR's lexical rules, used by the CQL IG's FHIR type
        /// mapping for partial-precision System.Time and System.DateTime values. Its value is a UCUM
        /// time-duration code: "h", "min", "s" or "ms". This converter only ever pads (and therefore
        /// emits) hour- and minute-precision values — second precision and finer is natively valid
        /// FHIR — but all four codes are honored when reading values produced by other emitters.
        /// </summary>
        internal const string TimePrecisionExtensionUrl = "http://hl7.org/fhir/StructureDefinition/time-precision";

        // FHIR time requires all of hh:mm:ss, and FHIR dateTime requires minutes and seconds once hours
        // are present, but CQL permits hour- and minute-precision values. Values at second precision or
        // finer round-trip through their ISO 8601 string unchanged; coarser values get their missing
        // components zero-padded, with the original precision recorded in the time-precision extension.
        // FHIR time forbids a timezone offset (R4: "A time zone SHALL NOT be present"), so any offset
        // on a CqlTime — which is vestigial and unreachable from CQL source because CQL's Time type has
        // no timezone concept — is unconditionally dropped.
        private static M.Time CqlTimeToFhirTime(CqlTime time)
        {
            var t = time.Value;
            if (t.Precision >= DateTimePrecision.Second)
            {
                // Build a TimeIso8601 without offset to prevent any vestigial offset from leaking into
                // the FHIR value.
                var noOffset = new TimeIso8601(t.Hour, t.Minute, t.Second, t.Millisecond, null, null);
                return new M.Time(noOffset.ToString());
            }

            var fhirTime = new M.Time(FormatPaddedTime(t.Hour, t.Minute, null, null, offsetWhenAbsent: NoOffset));
            AddTimePrecisionExtension(fhirTime, t.Precision);
            return fhirTime;
        }

        // The offset rendered in place of an absent one: none at all for a FHIR time, and UTC for a FHIR
        // dateTime whose converter was given no default timezone offset.
        private const string NoOffset = "";
        private const string Utc = "Z";

        // The converter's default timezone offset in the two forms emission needs: the text it renders as,
        // and the whole minutes it amounts to, which decide whether a value at the edge of the representable
        // instant range can carry it at all. Both components of a negative offset are negative, so the
        // minute total carries the sign.
        private readonly record struct DefaultOffset(string Rendered, int TotalMinutes);

        // FHIR R4 requires a timezone offset on every dateTime that carries a time component ("if hours
        // and minutes are specified, a time zone SHALL be populated"), while a CQL value may have none.
        // Per the CQL specification (§2 Author's Guide) an absent offset is the evaluation request's
        // timezone offset, which reaches this converter as defaultOffset (FhirCqlContext passes the
        // 'now' argument's offset, or the caller's FhirCqlContextOptions override). UTC applies when
        // neither was supplied, matching the UTC evaluation timestamp CqlOperators synthesizes then, and
        // for the handful of values that cannot carry the default at all (see ResolveOffsetWhenAbsent).
        // The remaining deviation from the specification is construction-side and outside this converter:
        // CqlOperators.DateTimeOperators leaves the offset of an offset-less value null rather than
        // defaulting it, so 'timezoneoffset from X' still returns null (tracked in #1507).
        private static M.FhirDateTime CqlDateTimeToFhirDateTime(CqlDateTime dateTime, DefaultOffset defaultOffset)
        {
            var dt = dateTime.Value;

            // A date-only value stays offset-free — FHIR forbids an offset without a time, and a CQL
            // value coarser than hour precision cannot carry one either.
            if (dt.Precision < DateTimePrecision.Hour)
                return new M.FhirDateTime(dateTime.ToString());

            var offsetWhenAbsent = ResolveOffsetWhenAbsent(dt, defaultOffset);

            // Hour and minute precision need the seconds (and, at hour precision, the minutes) padded,
            // and the precision they lose recorded in the time-precision extension.
            if (dt.Precision is DateTimePrecision.Hour or DateTimePrecision.Minute)
            {
                var padded = FormattableString.Invariant($"{dt.Year:D4}-{dt.Month!.Value:D2}-{dt.Day!.Value:D2}T")
                    + FormatPaddedTime(dt.Hour!.Value, dt.Minute, dt.OffsetHour, dt.OffsetMinute, offsetWhenAbsent);
                var fhirDateTime = new M.FhirDateTime(padded);
                AddTimePrecisionExtension(fhirDateTime, dt.Precision);
                return fhirDateTime;
            }

            // Second precision and finer is already lexically valid FHIR apart from the offset, which
            // the ISO 8601 string may leave out.
            return new M.FhirDateTime(dateTime.ToString() + FormatOffsetOmittedFromIso8601(dt.OffsetHour, dt.OffsetMinute, offsetWhenAbsent));
        }

        // A value whose rendering under the default offset would leave the representable instant range
        // keeps UTC instead: a FHIR dateTime is read back as a DateTimeOffset, whose UTC instant SHALL lie
        // between DateTime.MinValue and DateTime.MaxValue, and 0001-01-01T00:30:00+02:00 and
        // 9999-12-31T23:30:00-05:00 do not — FhirDateTime.IsValidValue rejects both, as does this SDK's own
        // FHIR-to-CQL conversion. Only the two extreme dates can be pushed out, and only their hour and
        // minute components decide it: the default offset is a whole number of minutes, so a value's
        // seconds and milliseconds move its instant strictly inside the minute those two components already
        // select. Below 0001-01-01T00:00 a time of day short of the offset stays short of it whatever
        // sub-minute remainder it carries, and above 9999-12-31 the last representable tick is
        // 23:59:59.9999999, which lies inside minute 23:59, so any remainder within the minute reached is
        // still representable.
        private static string ResolveOffsetWhenAbsent(DateTimeIso8601 dt, DefaultOffset defaultOffset)
        {
            var timeOfDayMinutes = dt.Hour!.Value * 60 + (dt.Minute ?? 0);
            var representable = (dt.Year, dt.Month, dt.Day, defaultOffset.TotalMinutes) switch
            {
                (1, 1, 1, > 0)      => timeOfDayMinutes >= defaultOffset.TotalMinutes,
                (9999, 12, 31, < 0) => timeOfDayMinutes - defaultOffset.TotalMinutes < 24 * 60,
                _                   => true
            };
            return representable ? defaultOffset.Rendered : Utc;
        }

        private static string FormatPaddedTime(int hour, int? minute, int? offsetHour, int? offsetMinute, string offsetWhenAbsent) =>
            FormattableString.Invariant($"{hour:D2}:{minute ?? 0:D2}:00{FormatOffset(offsetHour, offsetMinute, offsetWhenAbsent)}");

        // DateTimeIso8601 and TimeIso8601 render an offset only when its hour component is present, so
        // the offset of a value carrying minutes alone — constructible because neither type validates
        // that pairing outside strict mode — is missing from their string and has to be appended, as
        // does the default standing in for an entirely absent offset.
        private static string FormatOffsetOmittedFromIso8601(int? offsetHour, int? offsetMinute, string offsetWhenAbsent) =>
            offsetHour is null ? FormatOffset(offsetHour, offsetMinute, offsetWhenAbsent) : "";

        // offsetWhenAbsent is the already-rendered offset standing in for a CQL value that has none: the
        // converter's default (UTC absent one) for a FHIR dateTime, which SHALL carry an offset once it
        // has hours and minutes, and nothing for a FHIR time, which SHALL NOT carry one.
        // An offset counts as absent only when both of its components are: a minutes-only offset is a
        // real offset against a zero hour component, and carries its own sign.
        // A zero offset is always rendered as 'Z', the form ISO 8601 uses for it as well.
        private static string FormatOffset(int? offsetHour, int? offsetMinute, string offsetWhenAbsent) =>
            (offsetHour, offsetMinute) switch
            {
                (null, null) => offsetWhenAbsent,
                var (oh, om) => DateTimeIso8601.FormatKnownOffset(oh ?? 0, om ?? 0)
            };

        private static void AddTimePrecisionExtension(M.PrimitiveType element, DateTimePrecision precision) =>
            element.Extension.Add(new M.Extension(TimePrecisionExtensionUrl,
                new M.Code(precision switch
                {
                    DateTimePrecision.Hour => "h",
                    DateTimePrecision.Minute => "min",
                    DateTimePrecision.Second => "s",
                    DateTimePrecision.Millisecond => "ms",
                    _ => throw new ArgumentOutOfRangeException(nameof(precision), precision,
                        "Only time-component precisions can be conveyed by the time-precision extension.")
                })));

        /// <summary>
        /// Reads the precision declared by a <see cref="TimePrecisionExtensionUrl"/> extension, or
        /// <see langword="null"/> when the extension is absent or carries a code that does not describe
        /// a time component (coarser precisions are natively representable and never need the extension).
        /// </summary>
        private static DateTimePrecision? GetDeclaredTimePrecision(M.PrimitiveType element) =>
            element.GetExtensionValue<M.Code>(TimePrecisionExtensionUrl)?.Value switch
            {
                "h" => DateTimePrecision.Hour,
                "min" => DateTimePrecision.Minute,
                "s" => DateTimePrecision.Second,
                "ms" => DateTimePrecision.Millisecond,
                _ => null
            };

        // The inverse of CqlTimeToFhirTime: a time-precision extension marks zero-padded components,
        // so drop them to restore the value's original partial precision.
        private static CqlTime? FhirTimeToCqlTime(M.Time f)
        {
            if (!f.TryToSystemTime(out var time))
                return null;

            var hours = time!.Hours!.Value;
            return GetDeclaredTimePrecision(f) switch
            {
                DateTimePrecision.Hour => new CqlTime(hours, null, null, null, null, null),
                DateTimePrecision.Minute => new CqlTime(hours, time.Minutes, null, null, null, null),
                DateTimePrecision.Second => new CqlTime(hours, time.Minutes, time.Seconds, null, null, null),
                _ => new CqlTime(hours, time.Minutes, time.Seconds, time.Millis, null, null)
            };
        }

        // The inverse of CqlDateTimeToFhirDateTime; declaredPrecision comes from the time-precision
        // extension and truncates the zero-padded components it marks.
        private static CqlDateTime? FhirDateTimeToCqlDateTime(M.FhirDateTime f, DateTimePrecision? declaredPrecision)
        {
            if (!f.TryToSystemDateTime(out var dt))
                return null;

            var offsetHours = dt!.HasOffset ? dt.Offset!.Value.Hours : (int?)null;
            var offsetMinutes = dt.HasOffset ? dt.Offset!.Value.Minutes : (int?)null;
            return declaredPrecision switch
            {
                DateTimePrecision.Hour => new CqlDateTime(dt.Years!.Value, dt.Months, dt.Days, dt.Hours, null, null, null, offsetHours, offsetMinutes),
                DateTimePrecision.Minute => new CqlDateTime(dt.Years!.Value, dt.Months, dt.Days, dt.Hours, dt.Minutes, null, null, offsetHours, offsetMinutes),
                DateTimePrecision.Second => new CqlDateTime(dt.Years!.Value, dt.Months, dt.Days, dt.Hours, dt.Minutes, dt.Seconds, null, offsetHours, offsetMinutes),
                _ => new CqlDateTime(dt.Years!.Value, dt.Months, dt.Days, dt.Hours, dt.Minutes, dt.Seconds, dt.Millis, offsetHours, offsetMinutes)
            };
        }

        // CQL Time values have no date component; anchor them on the minimum FHIR date
        // (0001-01-01) so they can be represented within a Period.
        // Unlike a FHIR time, the resulting dateTime must carry an offset, and an offset-less time
        // takes UTC — never the converter's default timezone offset. The anchor date leaves no room
        // below it, so any positive default would put every time of day earlier than that offset
        // before DateTime.MinValue in UTC terms (0001-01-01T00:30:00+02:00 is not a value FHIR or
        // .NET can read back), while UTC keeps the whole 00:00-23:59 range representable. It is also
        // what the specification asks for: the evaluation request's offset is the default for a
        // DateTime whose offset is absent, and a Time has no offset to default — CQL's Time type has
        // no timezone concept at all, and this anchor date is synthetic.
        // The value is composed from the time's ISO 8601 string rather than built from a
        // DateTimeOffset, so that the string keeps the time's original precision.
        // Hour- and minute-precision times are zero-padded and marked with the time-precision
        // extension, like in CqlTimeToFhirTime. A vestigial explicit offset on the CqlTime still
        // renders as-is.
        private static M.FhirDateTime CqlTimeToFhirDateTime(CqlTime time)
        {
            var t = time.Value;
            var timePart = t.Precision >= DateTimePrecision.Second
                ? t.ToString() + FormatOffsetOmittedFromIso8601(t.OffsetHour, t.OffsetMinute, Utc)
                : FormatPaddedTime(t.Hour, t.Minute, t.OffsetHour, t.OffsetMinute, Utc);
            var fhirDateTime = new M.FhirDateTime("0001-01-01T" + timePart);
            if (t.Precision < DateTimePrecision.Second)
                AddTimePrecisionExtension(fhirDateTime, t.Precision);
            return fhirDateTime;
        }

        /// <summary>
        /// Converts a <see cref="CqlCode"/> to the most appropriate FHIR type: a bare <see cref="M.Code"/>
        /// when only the code element is populated, otherwise a <see cref="M.Coding"/>.
        /// </summary>
        /// <param name="converter">the type converter</param>
        /// <param name="code">the CQL code to convert, or <see langword="null"/></param>
        /// <returns>a <see cref="M.Code"/> or <see cref="M.Coding"/>, or <see langword="null"/> when <paramref name="code"/> is
        /// <see langword="null"/> or has no elements populated at all</returns>
        public static M.DataType? ConvertCqlCodeToFhir(this TypeConverter converter, CqlCode? code) =>
            code switch
            {
                null => null,
                { system: null, version: null, display: null, code: null or "" } => null,
                { system: null, version: null, display: null } => converter.Convert<M.Code>(code),
                _ => converter.Convert<M.Coding>(code)
            };

        /// <summary>
        /// Converts a FHIR <see cref="M.Period"/> to a CQL interval, using the CQL type name
        /// (typically the cqf-cqlType extension value from a Library parameter, e.g. "Interval&lt;Date&gt;" or
        /// "Interval&lt;DateTime&gt;")
        /// to disambiguate the otherwise ambiguous Period mapping.
        /// </summary>
        /// <param name="converter">the type converter</param>
        /// <param name="period">the period to convert, or <see langword="null"/></param>
        /// <param name="cqlPointTypeName">the CQL type name; "Interval&lt;Date&gt;" (and the bare "Date" for callers that
        /// already strip the wrapper) yields an Interval&lt;Date&gt;, anything else an Interval&lt;DateTime&gt;</param>
        /// <returns>a <see cref="CqlInterval{CqlDate}"/> or <see cref="CqlInterval{CqlDateTime}"/>, or <see langword="null"/> when <paramref name="period"/> is <see langword="null"/></returns>
        public static object? ConvertPeriodToCqlInterval(this TypeConverter converter, M.Period? period, string? cqlPointTypeName) =>
            GetCqlIntervalPointTypeName(cqlPointTypeName) switch
            {
                nameof(CqlPrimitiveType.Date) => converter.Convert<CqlInterval<CqlDate>>(period),
                _ => converter.Convert<CqlInterval<CqlDateTime>>(period)
            };

        /// <summary>
        /// Converts a FHIR <see cref="M.Range"/> to a CQL interval, using the CQL type name
        /// (typically the cqf-cqlType extension value from a Library parameter, e.g. "Interval&lt;Integer&gt;" or
        /// "Interval&lt;Long&gt;")
        /// to disambiguate the otherwise ambiguous Range mapping.
        /// </summary>
        /// <param name="converter">the type converter</param>
        /// <param name="range">the range to convert, or <see langword="null"/></param>
        /// <param name="cqlPointTypeName">the CQL type name; "Interval&lt;Integer&gt;", "Interval&lt;Decimal&gt;" and
        /// "Interval&lt;Long&gt;" (and the corresponding bare point type names for callers that already strip the wrapper)
        /// yield an Interval&lt;Integer&gt;, Interval&lt;Decimal&gt; and Interval&lt;Long&gt; of the Range's unit-less Quantity
        /// values, anything else - including an absent hint - the widest reading, an Interval&lt;Quantity&gt;</param>
        /// <returns>a <see cref="CqlInterval{T}"/> of <see cref="int"/>, <see cref="decimal"/>, <see cref="long"/> or
        /// <see cref="CqlQuantity"/>, or <see langword="null"/> when <paramref name="range"/> is <see langword="null"/></returns>
        public static object? ConvertRangeToCqlInterval(this TypeConverter converter, M.Range? range, string? cqlPointTypeName) =>
            GetCqlIntervalPointTypeName(cqlPointTypeName) switch
            {
                nameof(CqlPrimitiveType.Integer) => converter.Convert<CqlInterval<int?>>(range),
                nameof(CqlPrimitiveType.Decimal) => converter.Convert<CqlInterval<decimal?>>(range),
                nameof(CqlPrimitiveType.Long) => converter.Convert<CqlInterval<long?>>(range),
                _ => converter.Convert<CqlInterval<CqlQuantity>>(range)
            };

        private static string? GetCqlIntervalPointTypeName(string? cqlPointTypeName)
        {
            if (cqlPointTypeName is null)
                return null;

            var trimmed = cqlPointTypeName.Trim();
            const string intervalPrefix = "Interval<";

            return trimmed.StartsWith(intervalPrefix, StringComparison.Ordinal)
                && trimmed.EndsWith('>')
                ? trimmed[intervalPrefix.Length..^1].Trim()
                : trimmed;
        }

        /// <summary>
        /// The extension conveying the number of digits after the decimal point of a Quantity's value, used by
        /// the CQL IG's FHIR type mapping to make the precision of a value explicit.
        /// </summary>
        internal const string QuantityPrecisionExtensionUrl = "http://hl7.org/fhir/StructureDefinition/quantity-precision";

        /// <summary>
        /// Converts an interval of Integer, Decimal or Long to a FHIR Range of unit-less Quantities (FHIR-56226).
        /// FHIR Range bounds are always inclusive, so an open endpoint is emitted as its closed equivalent, i.e.
        /// the successor of an open low bound and the predecessor of an open high bound, stepping by <paramref name="step"/> -
        /// the same minimum precision value the engine's ToClosed() applies for the interval's point type.
        /// </summary>
        /// <remarks>
        /// The step is applied in <c>decimal</c> arithmetic. This intentionally diverges from the engine's
        /// <c>Successor</c>/<c>Predecessor</c> for Integer and Long, which use unchecked integer arithmetic and wrap
        /// at <c>int.MaxValue</c>/<c>long.MaxValue</c>. FHIR <c>Quantity</c> values are <c>decimal</c>-based, so
        /// representing <c>int.MaxValue + 1</c> as 2147483648 is more meaningful than wrapping to <c>int.MinValue</c>.
        /// These boundary values are practically unreachable in real CQL expressions.
        /// </remarks>
        private static M.Range NumericIntervalToRange(decimal? low, decimal? high, bool? lowClosed, bool? highClosed, decimal step)
        {
            var range = new M.Range();
            if (low is { } l)
            {
                range.Low = UnitlessQuantity((lowClosed ?? false) ? l : l + step);
            }

            if (high is { } h)
            {
                range.High = UnitlessQuantity((highClosed ?? false) ? h : h - step);
            }
            return range;
        }

        /// <summary>
        /// Creates the unit-less (UCUM <c>1</c>) Quantity used for the bounds of a Range converted from an interval
        /// of Integer, Decimal or Long. The <see cref="QuantityPrecisionExtensionUrl"/> extension is always added, so
        /// that the number of digits after the decimal point does not depend on a serializer preserving trailing zeros.
        /// </summary>
        private static M.Quantity UnitlessQuantity(decimal value)
        {
            var quantity = new M.Quantity(value, "1");
            // The extension's value is the bound's number of digits after the decimal point, which is exactly
            // Decimal.Scale (so 1.50m yields 2, and the trailing zero survives even if the serializer drops it).
            quantity.Extension.Add(new M.Extension(QuantityPrecisionExtensionUrl, new M.Integer(value.Scale)));
            return quantity;
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