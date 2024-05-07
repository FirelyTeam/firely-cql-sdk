/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Iso8601;
using Hl7.Cql.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Abstractions.Infrastructure;
using Microsoft.Extensions.Logging;

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
        private readonly Dictionary<Type, Dictionary<Type, Func<object, object>>> _converters
            = new();
        private readonly List<ITypeConverterEntry> _customConverters = [];
        private readonly HashSet<string> _conversionsAvailable = new();
        private readonly HashSet<string> _conversionsUsed = new();
        private ILogger<TypeConverter>? _logger;

        /// <summary>
        /// Add a logger to the TypeConverter.
        /// </summary>
        internal TypeConverter UseLogger(ILogger<TypeConverter> logger)
        {
            _logger = logger;
            return this;
        }

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
                .ConvertsIsoToCqlPrimitives();

        /// <summary>
        /// Returns <see langword="true"/> if this converter is able to convert <paramref name="from"/> to <paramref name="to"/>.
        /// </summary>
        /// <param name="from">The source type.</param>
        /// <param name="to">The desired type.</param>
        /// <returns><see langword="true"/> if this converter is able to convert <paramref name="from"/> to <paramref name="to"/>.</returns>
        internal bool CanConvert(Type from, Type to)
        {
            if (_customConverters.SingleOrDefault(converter => converter.Handles(from, to)) is not null)
            {
                _conversionsUsed.Add(TypesToString((from, to)));
                return true;
            }

            if (_converters.TryGetValue(from, out var toDictionary) &&
                toDictionary.TryGetValue(to, out _))
            {
                _conversionsUsed.Add(TypesToString((from, to)));
                return true;
            }

            return false;
        }

        /// <summary>
        /// Performs the conversion of <paramref name="from"/> to <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The desired type.</typeparam>
        /// <param name="from">The object to convert.</param>
        /// <returns>The result of the conversion.</returns>
        /// <exception cref="InvalidOperationException">If no conversion is defined.</exception>
        /// <remarks>The ExpressionBuilder inserts calls to this method in the generated Linq.Expressions,
        /// so do not rename or change this method, without adapting the ExpressionBuilder.</remarks>
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
            if (from is null) return null;
            var fromType = from.GetType();
            if (fromType.IsAssignableTo(to))
                return from;

            if(_customConverters.SingleOrDefault(converter => converter.Handles(fromType, to)) is {} subConverter)
                return subConverter.Convert(from, to);
            else if (_converters.TryGetValue(fromType, out var toDictionary) &&
                     toDictionary.TryGetValue(to, out Func<object, object>? convert))
                    return convert(from);
            else
                    throw new InvalidOperationException($"No conversion from {from} to {to} is defined.");
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
        }

        /// <summary>
        /// Adds a new converter function.
        /// </summary>
        internal void AddConverter(ITypeConverterEntry converter) =>
            _customConverters.Add(converter);

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

        internal virtual void CaptureAvailableConverters()
        {
            if (_logger is null)
                return;

            _conversionsAvailable.AddRange(
                _converters
                    .SelectMany(kv => kv.Value, ((kvFrom, kvTo) => (From: kvFrom.Key, To: kvTo.Key)))
                    .Select(TypesToString));
        }

        private void LogFinalConverters()
        {
            if (_logger is null)
                return;

            var lines = string.Concat(
                _conversionsAvailable
                    .Order()
                    .Select((line,i) => (line,i:i+1,used: _conversionsUsed.Contains(line)))
                    .OrderBy(o => o.used).ThenBy(o => o.i)
                    .Select(t => $"\n\t{t.i,5}. {(t.used ? "[x]" : "[_]")} {t.line}"));

            _logger.LogDebug(
                "TypeConverter conversions usage ({unusedCount} unused, and {usedCount} used. {totalCount} in total):{lines}",
                _conversionsAvailable.Count - _conversionsUsed.Count,
                _conversionsUsed.Count,
                _conversionsAvailable.Count,
                lines);
        }

        private static readonly TypeCSharpFormat TypeCSharpFormat = new(
            NoNamespaces: true,
            UseKeywords: false);

        private static string TypesToString((Type From, Type To) t) =>
            $"{TypeToString(t.From)} --> {TypeToString(t.To)}";

        private static string TypeToString(Type t) =>
            string.Concat(
                t.Namespace!
                 .Replace("Hl7.Fhir.Model", "fhir ")
                 .Replace("Hl7.Cql.Primitives", "cql ")
                 .Replace("Hl7.Cql.Iso8601", "iso8601 ")
                 .Replace("System", "sys "),
                t switch
                {
                    { IsEnum: true }      => "enum ",
                    { IsValueType: true } => "struct ",
                    _                     => ""
                },
                t.WriteCSharp(TypeCSharpFormat));

        /// <inheritdoc />
        void IDisposable.Dispose()
        {
            if (_logger is not null)
                LogFinalConverters();
        }
    }
}
