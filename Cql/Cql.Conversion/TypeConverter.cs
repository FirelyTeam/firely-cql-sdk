using Hl7.Cql.Primitives;
using Hl7.Cql.Iso8601;
using System;
using System.Collections.Generic;

namespace Hl7.Cql.Conversion
{
    /// <summary>
    /// Converts CQL model types to .NET types, and vice versa.
    /// </summary>
    public class TypeConverter
    {
        private readonly Dictionary<Type, Dictionary<Type, Func<object, object>>> Converters 
            = new();

        /// <summary>
        /// Creates a default instance that provides some default conversions.
        /// </summary>
        /// <returns>An instance with default conversions supplied.</returns>
        public static TypeConverter Create() =>
            new TypeConverter()
                .ConvertNetTypes()
                .ConvertsIsoToCqlPrimitives();

        protected TypeConverter()
        {
        }

        /// <summary>
        /// Provides utility for converting common .NET types that don't have implicit conversions defined, e.g. <see cref="string"/> and <see cref="Uri"/>.
        /// </summary>
        /// <returns>This instance.</returns>
        public TypeConverter ConvertNetTypes()
        {
            AddConversion<Uri, string>(uri => uri.AbsoluteUri);
            AddConversion<string, Uri>(@string => new Uri(@string));

            return this;
        }

        /// <summary>
        /// Provides conversion between types in the <see cref="Hl7.Cql.Primitives"/> namespace to equivalent <see cref="Iso8601"/> types.
        /// </summary>
        /// <returns>This instance.</returns>
        public TypeConverter ConvertsIsoToCqlPrimitives()
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

        /// <summary>
        /// Adds a new function for converting <paramref name="from"/> to <paramref name="to"/>.
        /// </summary>
        /// <param name="from">The source type.</param>
        /// <param name="to">The desired type.</param>
        /// <param name="conversion">The function which implements the conversion.</param>
        /// <exception cref="ArgumentException">If this conversion is already defined.</exception>
        public void AddConversion(Type from, Type to, Func<object,object> conversion)
        {
            if (!Converters.TryGetValue(from, out var toDictionary))
            {
                toDictionary = new Dictionary<Type, Func<object, object>>();
                Converters.Add(from, toDictionary);
            }
            if (toDictionary.TryGetValue(to, out Func<object, object> existing))
                throw new ArgumentException($"Conversion from {from} to {to} is already defined.");
            else toDictionary.Add(to, conversion);
        }

        /// <summary>
        /// Adds a new function for converting <paramref name="from"/> to <paramref name="to"/>.
        /// </summary>
        /// <typeparam name="TFrom">The source type.</typeparam>
        /// <typeparam name="TTo">The desired type.</typeparam>
        /// <param name="conversion">The function which implements the conversion.</param>
        /// <exception cref="ArgumentException">If this conversion is already defined.</exception>
        public void AddConversion<TFrom, TTo>(Func<TFrom, TTo> conversion)
        {
            if (!Converters.TryGetValue(typeof(TFrom), out var toDictionary))
            {
                toDictionary = new Dictionary<Type, Func<object, object>>();
                Converters.Add(typeof(TFrom), toDictionary);
            }
            if (toDictionary.TryGetValue(typeof(TTo), out Func<object, object> existing))
                throw new ArgumentException($"Conversion from {typeof(TFrom)} to {typeof(TTo)} is already defined.");
            else toDictionary.Add(typeof(TTo), x => conversion((TFrom)x)!);
        }

        /// <summary>
        /// Performs the conversion of <paramref name="from"/> to <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The desired type.</typeparam>
        /// <param name="from">The object to convert.</param>
        /// <returns>The result of the conversion.</returns>
        public T Convert<T>(object? from) => (T)ConvertHelper(from, typeof(T))!;

        protected object? ConvertHelper(object? from, Type to)
        {
            if (from == null)
                return null;
            var fromType = from?.GetType() ?? throw new ArgumentNullException(nameof(from));
            if (Converters.TryGetValue(fromType, out var toDictionary))
                if (toDictionary.TryGetValue(to, out Func<object, object> convert))
                    return convert(from);
            throw new InvalidOperationException($"No conversion from {from} to {to} is defined.");
        }

        /// <summary>
        /// Returns <see langword="true"/> if this converter is able to convert <see cref="from"/> to <see cref="to"/>.
        /// </summary>
        /// <typeparam name="TFrom">The source type.</typeparam>
        /// <typeparam name="TTo">The desired type.</typeparam>
        /// <returns><see langword="true"/> if this converter is able to convert <see cref="from"/> to <see cref="to"/>.</returns>
        public bool CanConvert(Type from, Type to)
        {
            if (Converters.TryGetValue(from, out var toDictionary))
                if (toDictionary.TryGetValue(to, out Func<object, object> existing))
                    return true;
            return false;
        }
    }
}
