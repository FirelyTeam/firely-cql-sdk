/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Iso8601;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Conversion
{
    /// <summary>
    /// A custom single-step conversion within the list of conversions in the TypeConverter.
    /// </summary>
    public interface ITypeConverterEntry
    {
        /// <summary>
        /// Returns whether this converter can convert from <paramref name="from"/> to <paramref name="to"/>.
        /// </summary>
        bool Handles(Type from, Type to);

        /// <summary>
        /// Actually runs the conversion from an instance to the desired type.
        /// </summary>
        object? Convert(object? instance, Type to);
    }

    /// <summary>
    /// Converts CQL model types to .NET types, and vice versa.
    /// </summary>
    public class TypeConverter : IDisposable
    {
        private readonly Dictionary<Type, Dictionary<Type, Func<object, object>>> _converters = new();
        private readonly List<ITypeConverterEntry> _customConverters = [];

        /// <summary>
        /// Memoizes which conversion — a registered <see cref="ITypeConverterEntry"/>, a registered delegate, or none
        /// at all — applies to a (from, to) pair. Resolving that from scratch means scanning
        /// <see cref="_customConverters"/> before consulting <see cref="_converters"/>, which is pure overhead on the
        /// second and every later conversion of the same pair — and conversions run per value during an evaluation.
        /// A <see langword="null"/> entry records that no conversion exists, so repeated probing (<see cref="CanConvert"/>)
        /// costs one lookup as well. Registering a conversion clears the memo, since it can turn a
        /// <see langword="null"/> entry into a real conversion.
        /// </summary>
        private readonly ConcurrentDictionary<(Type From, Type To), Func<object, object?>?> _resolvedConversions = new();

        /// <summary>
        /// Creates a TypeConverter with an empty set of conversions.
        /// </summary>
        private TypeConverter()
        {
        }

        /// <summary>
        /// Creates a default instance that provides some default conversions.
        /// </summary>
        /// <returns>An instance with default conversions supplied.</returns>
        public static TypeConverter Create() =>
            new TypeConverter()
                .ConvertNetTypes()
                .ConvertsIsoToCqlPrimitives()
                .ConvertCqlIntervalOfTypeToCqlIntervalOfObject();

        /// <summary>
        /// Returns <see langword="true"/> if this converter is able to convert <paramref name="from"/> to <paramref name="to"/>.
        /// </summary>
        /// <param name="from">The source type.</param>
        /// <param name="to">The desired type.</param>
        /// <returns><see langword="true"/> if this converter is able to convert <paramref name="from"/> to <paramref name="to"/>.</returns>
        internal bool CanConvert(Type from, Type to) =>
            ResolveConversion(from, to) is not null;

        /// <summary>
        /// Returns the conversion registered for the given pair, or <see langword="null"/> when there is none.
        /// </summary>
        private Func<object, object?>? ResolveConversion(Type from, Type to) =>
            _resolvedConversions.GetOrAdd(
                (from, to),
                static (key, self) => self.ResolveConversionUncached(key.From, key.To),
                this);

        private Func<object, object?>? ResolveConversionUncached(Type from, Type to)
        {
            // A custom converter wins over a registered delegate, the order Convert has always applied.
            // SingleOrDefault (rather than FirstOrDefault) keeps rejecting a pair two custom converters both claim.
            if (_customConverters.SingleOrDefault(converter => converter.Handles(from, to)) is { } customConverter)
                return instance => customConverter.Convert(instance, to);

            if (_converters.TryGetValue(from, out var toDictionary)
                && toDictionary.TryGetValue(to, out var convert))
                return convert;

            return null;
        }

        /// <summary>
        /// Performs the conversion of <paramref name="from"/> to <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The desired type.</typeparam>
        /// <param name="from">The object to convert.</param>
        /// <returns>The result of the conversion.</returns>
        /// <exception cref="InvalidOperationException">If no conversion is defined.</exception>
        /// <remarks>The CodeBuilder inserts calls to this method in the generated C# output,
        /// so do not rename or change this method, without adapting the CodeBuilder.</remarks>
        public T? Convert<T>(object? from) => (T?)Convert(from, typeof(T));

        /// <summary>
        /// Performs the conversion of an instance to type <paramref name="to"/> />.
        /// </summary>
        /// <param name="from">The object to convert.</param>
        /// <param name="to">The type to convert the object to.</param>
        /// <returns>The result of the conversion.</returns>
        /// <exception cref="InvalidOperationException">If no conversion is defined.</exception>
        public object? Convert(object? from, Type to)
        {
            if (from is null)
                return null;

            var fromType = from.GetType();
            if (fromType.IsAssignableTo(to))
                return from;

            if (ResolveConversion(fromType, to) is { } convert)
                return convert(from);

            throw new InvalidOperationException($"No conversion from {fromType} to {to} is defined.");
        }

        /// <summary>
        /// Adds a new function for converting <paramref name="from"/> to <paramref name="to"/>.
        /// </summary>
        /// <param name="from">The source type.</param>
        /// <param name="to">The desired type.</param>
        /// <param name="conversion">The function which implements the conversion.</param>
        /// <exception cref="ArgumentException">If this conversion is already defined.</exception>
        internal void AddConversion(Type from, Type to, Func<object, object> conversion)
        {
            if (!_converters.TryGetValue(from, out var toDictionary))
            {
                toDictionary = new Dictionary<Type, Func<object, object>>();
                _converters.Add(from, toDictionary);
            }
            if (toDictionary.TryGetValue(to, out _))
                throw new ArgumentException($"Conversion from {from} to {to} is already defined.");
            else
                toDictionary.Add(to, conversion);

            _resolvedConversions.Clear();
        }

        /// <summary>
        /// Adds a new converter function.
        /// </summary>
        internal void AddConverter(ITypeConverterEntry converter)
        {
            _customConverters.Add(converter);
            _resolvedConversions.Clear();
        }

        /// <summary>
        /// Adds a new function for converting  <typeparamref name="TFrom"/> to <typeparamref name="TTo"/>.
        /// </summary>
        /// <typeparam name="TFrom">The source type.</typeparam>
        /// <typeparam name="TTo">The desired type.</typeparam>
        /// <param name="conversion">The function which implements the conversion.</param>
        /// <exception cref="ArgumentException">If this conversion is already defined.</exception>
        internal void AddConversion<TFrom, TTo>(Func<TFrom, TTo> conversion)
        {
            if (!_converters.TryGetValue(typeof(TFrom), out var toDictionary))
            {
                toDictionary = new Dictionary<Type, Func<object, object>>();
                _converters.Add(typeof(TFrom), toDictionary);
            }
            if (toDictionary.TryGetValue(typeof(TTo), out Func<object, object>? existing))
                throw new ArgumentException($"Conversion from {typeof(TFrom)} to {typeof(TTo)} is already defined.");
            else toDictionary.Add(typeof(TTo), x => conversion((TFrom)x)!);

            _resolvedConversions.Clear();
        }


        /// <summary>
        /// Provides utility for converting common .NET types that don't have implicit conversions defined, e.g. <see cref="string"/> and <see cref="Uri"/>.
        /// </summary>
        /// <returns>This instance.</returns>
        private TypeConverter ConvertNetTypes()
        {
            AddConversion<Uri, string>(uri => uri.AbsoluteUri);
            AddConversion<string, Uri>(@string => new Uri(@string));
            return this;
        }

        private TypeConverter ConvertCqlIntervalOfTypeToCqlIntervalOfObject()
        {
            AddConverter(CqlIntervalOfTypeToCqlIntervalOfObjectConverter.Instance);
            return this;
        }

        private class CqlIntervalOfTypeToCqlIntervalOfObjectConverter : ITypeConverterEntry
        {
            public static readonly CqlIntervalOfTypeToCqlIntervalOfObjectConverter Instance = new CqlIntervalOfTypeToCqlIntervalOfObjectConverter();

            public bool Handles(Type from, Type to)
            {
                var handle = to == typeof(CqlInterval<object>)
                                                          && from != to
                                                          && from.IsImplementingGenericTypeDefinition(typeof(CqlInterval<>));
                return handle;
            }

            public object? Convert(object? instance, Type to)
            {
                return (instance as ICqlInterval)?.ToCqlIntervalOfObject();
            }
        }

        /// <summary>
        /// Provides conversion between types in the <see cref="Hl7.Cql.Primitives"/> namespace to equivalent <see cref="Iso8601"/> types.
        /// </summary>
        /// <returns>This instance.</returns>
        private TypeConverter ConvertsIsoToCqlPrimitives()
        {
            AddConversion<DateIso8601, CqlDate>(isoDate => new CqlDate(isoDate));
            AddConversion<DateIso8601, CqlDateTime>(isoDate => new CqlDateTime(isoDate.Year, isoDate.Month, isoDate.Day, null, null, null, null, null, null));
            AddConversion<DateTimeIso8601, CqlDateTime>(isoDateTime => new CqlDateTime(isoDateTime));
            AddConversion<TimeIso8601, CqlTime>(isoTime => new CqlTime(isoTime));
            AddConversion<CqlDate, DateIso8601>(cqlDate => cqlDate.Value);
            AddConversion<CqlDate, CqlDateTime>(cqlDate => new CqlDateTime(cqlDate));
            AddConversion<CqlDateTime, DateTimeIso8601>(cqlDateTime => cqlDateTime.Value);
            AddConversion<CqlDateTime, DateIso8601>(cqlDateTime => cqlDateTime.DateOnly.Value);
            AddConversion<CqlTime, TimeIso8601>(cqlTime => cqlTime.Value);
            return this;
        }

        /// <inheritdoc />
        void IDisposable.Dispose()
        {
        }
    }
}