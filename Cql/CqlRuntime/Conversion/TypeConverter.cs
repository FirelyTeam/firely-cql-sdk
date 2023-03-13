using Ncqa.Cql.Runtime.Primitives;
using Ncqa.Iso8601;
using System;
using System.Collections.Generic;

namespace Ncqa.Cql.Runtime.Conversion
{
    public class TypeConverter
    {
        private readonly Dictionary<Type, Dictionary<Type, Func<object, object>>> Converters 
            = new Dictionary<Type, Dictionary<Type, Func<object, object>>>();

        public TypeConverter()
        {
        }

        public TypeConverter ConvertSystemTypes()
        {
            AddConversion<Uri, string>(uri => uri.AbsoluteUri);
            AddConversion<string, Uri>(@string => new Uri(@string));

            return this;
        }

        public TypeConverter ConvertIsoToCqlPrimitives()
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

        public T Convert<T>(object from) => (T)ConvertHelper(from, typeof(T))!;

        protected object? ConvertHelper(object from, Type to)
        {
            if (from == null)
                return null;
            var fromType = from?.GetType() ?? throw new ArgumentNullException(nameof(from));
            if (Converters.TryGetValue(fromType, out var toDictionary))
                if (toDictionary.TryGetValue(to, out Func<object, object> convert))
                    return convert(from);
            throw new InvalidOperationException($"No conversion from {from} to {to} is defined.");
        }

        public bool CanConvert(Type from, Type to)
        {
            if (Converters.TryGetValue(from, out var toDictionary))
                if (toDictionary.TryGetValue(to, out Func<object, object> existing))
                    return true;
            return false;
        }
    }
}
