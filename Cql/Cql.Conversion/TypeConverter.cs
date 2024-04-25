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
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
    public class TypeConverter
    {
        private readonly FromToTypeDictionary<Func<object, object>> _converters;
        private readonly List<ITypeConverterEntry> _customConverters = [];

        /// <summary>
        /// Creates a TypeConverter with an empty set of conversions.
        /// </summary>
        internal TypeConverter()
        {
            _converters = new(
                () => new ExactTypeDictionary<IBasicDictionary<Type, Func<object, object>>>(),
                _ => new InheritingTypeDictionary<Func<object, object>>());
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
                return true;

            return _converters.TryGetValue((from, to), out _);
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

            if(_customConverters.SingleOrDefault(converter => converter.Handles(fromType, to)) is {} subConverter)
                return subConverter.Convert(from, to);


            if (_converters.TryGetValue((fromType, to), out var convert))
                return convert(from);

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
            _converters.Add((from, to), conversion);
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
            AddConversion(typeof(TFrom), typeof(TTo), (obj) => conversion((TFrom)obj)!);
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

        internal virtual void LogAllConverters(ILogger<TypeConverter> logger)
        {
            CSharpWriteTypeOptions o = new(
                HideNamespaces:true,
                PreferKeywords:true);

            string TypeToString(Type t) =>
                (t.IsValueType ? "struct ": "") + t.WriteCSharp(o);

            var lines = string.Concat(
                _converters
                    .Select(kv => $"\n\t* {TypeToString(kv.Key.From)} --> {TypeToString(kv.Key.To)}")
                    .Order()
                );
            logger.LogDebug("TypeConverter has the following conversions defined:{lines}", lines);
        }
    }
}

internal readonly struct FromToTypeDictionary<TValue> : IBasicDictionary<(Type From, Type To), TValue>
{
    private readonly Func<Type, IBasicDictionary<Type, TValue>> _newToDictionary;
    private readonly IBasicDictionary<Type, IBasicDictionary<Type, TValue>> _fromToMap;

    public FromToTypeDictionary(
        Func<IBasicDictionary<Type, IBasicDictionary<Type, TValue>>>? newFromDictionary = null,
        Func<Type, IBasicDictionary<Type, TValue>>? newToDictionary = null)
    {
        _newToDictionary = newToDictionary ?? (_ => new InheritingTypeDictionary<TValue>());
        _fromToMap = newFromDictionary?.Invoke() ?? new InheritingTypeDictionary<IBasicDictionary<Type, TValue>>();
    }

    public IEnumerator<KeyValuePair<(Type From, Type To), TValue>> GetEnumerator() =>
        _fromToMap
            .SelectMany(
                kvFrom => kvFrom.Value,
                (kvFrom, kvTo) => KeyValuePair.Create((kvFrom.Key, kvTo.Key), kvTo.Value))
            .ToList()
            .GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public int Count => _fromToMap.Sum(kv => kv.Value.Count);

    public void Add((Type From, Type To) keyPair, TValue value)
    {
        var func = _newToDictionary;
        _fromToMap.GetOrAddValue(keyPair.From, func).Add(keyPair.To, value);
    }

    public bool TryGetValue((Type From, Type To) keyPair, [MaybeNullWhen(false)] out TValue value)
    {
        value = default;
        return _fromToMap.TryGetValue(keyPair.From, out var toDictionary)
               && toDictionary.TryGetValue(keyPair.To, out value);
    }
}

internal interface IBasicDictionary<TKey, TValue> :
    IReadOnlyCollection<KeyValuePair<TKey, TValue>>,
    IEnumerable<KeyValuePair<TKey, TValue>>,
    IEnumerable
{
    void Add(TKey key, TValue value);
    bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value);
}

file static class BasicDictionaryExtensions
{
    public static TValue GetOrAddValue<TKey, TValue>(
        this IBasicDictionary<TKey, TValue> d,
        TKey key,
        Func<TKey, TValue> addValue)
    {
        if (d.TryGetValue(key, out var value))
            return value;

        value = addValue(key);
        d.Add(key, value);
        return value;
    }
}

file readonly struct InheritingTypeDictionary<TValue>() : IBasicDictionary<Type, TValue>
{
    private readonly ExactTypeDictionary<TValue> _types = new();
    private readonly ExactTypeDictionary<TValue> _genTypeDefinitions = new();

    public void Add(Type key, TValue value)
    {
        if (!IsTypeAllowed(key))
            throw new ArgumentException("Cannot add object or ValueType to InheritingTypeDictionary");

        if (key.IsGenericTypeDefinition)
            _genTypeDefinitions.Add(key, value);

        else
            _types.Add(key, value);
    }

    public bool TryGetValue(Type key, [MaybeNullWhen(false)] out TValue value)
    {
        if (!IsTypeAllowed(key))
        {
            value = default;
            return false;
        }

        ExactTypeDictionary<TValue> d = key.IsGenericTypeDefinition
                                            ? _genTypeDefinitions
                                            : _types;
        while (true)
        {
            if (d.Count > 0)
            {
                // Try exact type first
                if (d.TryGetValue(key, out value)) return true;

                // Then try base types and interfaces
                foreach (var t in key.BaseTypesAndInterfaces().Where(t => IsTypeAllowed(t)))
                    if (d.TryGetValue(t, out value))
                        return true;
            }

            // Then try again on the generic type definition if applicable
            if (key.IsConstructedGenericType)
            {
                key = key.GetGenericTypeDefinition();
                d = _genTypeDefinitions;
                continue;
            }

            // No match
            value = default;
            return false;
        }
    }

    private static bool IsTypeAllowed(Type key)
    {
        return true;
    }

    public IEnumerator<KeyValuePair<Type, TValue>> GetEnumerator()
    {
        foreach (var kv in _types)
            yield return kv;

        foreach (var kv in _genTypeDefinitions)
            yield return kv;
    }

    public int Count => _types.Count + _genTypeDefinitions.Count;

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

file readonly struct ExactTypeDictionary<TValue>() : IBasicDictionary<Type, TValue>
{
    private readonly Dictionary<Type, TValue> _types = new();

    public void Add(Type key, TValue value) =>
        _types.Add(key, value);

    public bool TryGetValue(Type key, [MaybeNullWhen(false)] out TValue value) =>
        _types.TryGetValue(key, out value);

    public IEnumerator<KeyValuePair<Type, TValue>> GetEnumerator() =>
        _types.GetEnumerator();

    public int Count =>
        _types.Count;

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}