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

namespace Hl7.Cql.Conversion;

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
            newFromDictionary: () =>
                new MatchDerivedTypesDictionary<IBasicDictionary<Type, Func<object, object>>>()
                    .HandleNullableValueTypes(),
            newToDictionary: _ =>
                new MatchDerivedTypesDictionary<Func<object, object>>()
                    .HandleNullableValueTypes());
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
    /// <param name="reverseConversion">The function which implements the reverse of the conversion.</param>
    /// <exception cref="ArgumentException">If this conversion is already defined.</exception>
    internal void AddConversion(
        Type from, Type to,
        Func<object, object> conversion,
        Func<object, object>? reverseConversion = null)
    {
        _converters.Add((from, to), conversion);
        if (reverseConversion is not null)
            _converters.Add((to, from), reverseConversion);
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
    /// <param name="reverseConversion">The function which implements the reverse of the conversion.</param>
    /// <exception cref="ArgumentException">If this conversion is already defined.</exception>
    internal void AddConversion<TFrom, TTo>(
        Func<TFrom, TTo> conversion,
        Func<TTo, TFrom>? reverseConversion = null)
    {
        AddConversion(
            typeof(TFrom),
            typeof(TTo),
            fromVal => conversion((TFrom)fromVal)!,
            reverseConversion is {} fn ? toVal => fn((TTo)toVal)! : null);
    }

    internal void AddConversion<TFrom, TTo>(Func<TFrom?, TTo> conversion)
        where TFrom : struct
    {
        AddConversion(typeof(TFrom), typeof(TTo), (obj) => conversion((TFrom?)obj)!);
    }


    /// <summary>
    /// Provides utility for converting common .NET types that don't have implicit conversions defined, e.g. <see cref="string"/> and <see cref="Uri"/>.
    /// </summary>
    /// <returns>This instance.</returns>
    private TypeConverter ConvertNetTypes()
    {
        AddConversion<string, Uri>(
            @string => new Uri(@string),
            uri => uri.AbsoluteUri);
        return this;
    }

    /// <summary>
    /// Provides conversion between types in the <see cref="Hl7.Cql.Primitives"/> namespace to equivalent <see cref="Iso8601"/> types.
    /// </summary>
    /// <returns>This instance.</returns>
    private TypeConverter ConvertsIsoToCqlPrimitives()
    {
        AddConversion<DateIso8601, CqlDate>(
            isoDate => new CqlDate(isoDate),
            cqlDate => cqlDate.Value);

        AddConversion<DateIso8601, CqlDateTime>(
            isoDate => new CqlDateTime(isoDate.Year, isoDate.Month, isoDate.Day, null, null, null, null, null, null),
            cqlDateTime => cqlDateTime.DateOnly.Value);

        AddConversion<DateTimeIso8601, CqlDateTime>(
            isoDateTime => new CqlDateTime(isoDateTime),
            cqlDateTime => cqlDateTime.Value);

        AddConversion<TimeIso8601, CqlTime>(
            isoTime => new CqlTime(isoTime),
            cqlTime => cqlTime.Value);

        AddConversion<CqlDate, CqlDateTime>(cqlDate => new CqlDateTime(cqlDate));
        return this;
    }

    internal virtual void LogAllConverters(ILogger<TypeConverter> logger)
    {
        CSharpWriteTypeOptions o = new(
            HideNamespaces:true,
            PreferKeywords:false);

        string TypeToString(Type t) =>
            string.Concat(
                t.Namespace!
                 .Replace("Hl7.Fhir.Model", "fhir ")
                 .Replace("Hl7.Cql.Primitives", "cql ")
                 .Replace("Hl7.Cql.Iso8601", "iso8601 ")
                 .Replace("System", "sys "),
                t switch {
                    {IsEnum:true}      => "enum ",
                    {IsValueType:true} => "struct ",
                    _                  => ""
                },
                t.WriteCSharp(o).ToString()!);

        var lines = string.Concat(
            _converters
                .Select(kv => $"\n\t* {TypeToString(kv.Key.From)} --> {TypeToString(kv.Key.To)}")
                .Order()
        );
        logger.LogDebug("TypeConverter has the following conversions defined:{lines}", lines);
    }
}


internal interface IBasicDictionary<TKey, TValue> :
    IEnumerable<KeyValuePair<TKey, TValue>>
    where TKey: notnull
{
    void Add(TKey key, TValue value);
    bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value);
    bool IsEmpty { get; }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

internal static class BasicDictionaryExtensions
{
    public static TValue GetOrAddValue<TKey, TValue>(
        this IBasicDictionary<TKey, TValue> d,
        TKey key,
        Func<TKey, TValue> addValue) where TKey : notnull
    {
        if (d.TryGetValue(key, out var value))
            return value;

        value = addValue(key);
        d.Add(key, value);
        return value;
    }

    public static IBasicDictionary<Type, TValue> HandleNullableValueTypes<TValue>(
        this IBasicDictionary<Type, TValue> d) =>
        new HandleNullableValueTypesDecorator<TValue>(d);
}

internal readonly struct FromToTypeDictionary<TValue>(
    Func<IBasicDictionary<Type, IBasicDictionary<Type, TValue>>> newFromDictionary,
    Func<Type, IBasicDictionary<Type, TValue>> newToDictionary)
    : IBasicDictionary<(Type From, Type To), TValue>
{
    private readonly IBasicDictionary<Type, IBasicDictionary<Type, TValue>> _fromToMap = newFromDictionary();

    public void Add((Type From, Type To) keyPair, TValue value)
    {
        var func = newToDictionary;
        _fromToMap.GetOrAddValue(keyPair.From, func).Add(keyPair.To, value);
    }

    public bool TryGetValue((Type From, Type To) keyPair, [MaybeNullWhen(false)] out TValue value)
    {
        value = default;
        return _fromToMap.TryGetValue(keyPair.From, out var toDictionary)
               && toDictionary.TryGetValue(keyPair.To, out value);
    }

    public bool IsEmpty => _fromToMap.IsEmpty;

    public IEnumerator<KeyValuePair<(Type From, Type To), TValue>> GetEnumerator() =>
        _fromToMap
            .SelectMany(
                kvFrom => kvFrom.Value,
                (kvFrom, kvTo) => KeyValuePair.Create((kvFrom.Key, kvTo.Key), kvTo.Value))
            .ToList()
            .GetEnumerator();

}

internal readonly struct HandleNullableValueTypesDecorator<TValue>(
    IBasicDictionary<Type, TValue> inner) : IBasicDictionary<Type, TValue>
{
    private static Type DeNullifyValueType(Type key)
    {
        var type = Nullable.GetUnderlyingType(key);
        if (type == null) return key;
        return type;
    }

    public void Add(Type key, TValue value) =>
        inner.Add(DeNullifyValueType(key), value);
    public bool TryGetValue(Type key, [MaybeNullWhen(false)] out TValue value) =>
        inner.TryGetValue(DeNullifyValueType(key), out value);

    public bool IsEmpty => inner.IsEmpty;

    public IEnumerator<KeyValuePair<Type, TValue>> GetEnumerator() =>
        inner.GetEnumerator();
}

internal readonly struct MatchDerivedTypesDictionary<TValue>() : IBasicDictionary<Type, TValue>
{
    private readonly MatchExactTypeDictionary<TValue> _types = new();
    private readonly MatchExactTypeDictionary<TValue> _genTypeDefinitions = new();

    public void Add(Type key, TValue value)
    {
        if (key.IsInterface)
            throw new NotSupportedException();

        if (key.IsGenericTypeDefinition)
            _genTypeDefinitions.Add(key, value);

        else
            _types.Add(key, value);
    }

    public bool TryGetValue(Type key, [MaybeNullWhen(false)] out TValue value)
    {
        var d = key.IsGenericTypeDefinition
                    ? _genTypeDefinitions
                    : _types;
        while (true)
        {
            if (!d.IsEmpty)
            {
                foreach (var t in key.BaseTypes(includeSelf:true, excludeInterfaces:true))
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

    public bool IsEmpty => _types.IsEmpty && _genTypeDefinitions.IsEmpty;

    public IEnumerator<KeyValuePair<Type, TValue>> GetEnumerator()
    {
        foreach (var kv in _types)
            yield return kv;

        foreach (var kv in _genTypeDefinitions)
            yield return kv;
    }
}

internal readonly struct MatchExactTypeDictionary<TValue>() : IBasicDictionary<Type, TValue>
{
    private readonly Dictionary<Type, TValue> _types = new();

    public void Add(Type key, TValue value) =>
        _types.Add(key, value);

    public bool TryGetValue(Type key, [MaybeNullWhen(false)] out TValue value) =>
        _types.TryGetValue(key, out value);

    public bool IsEmpty => _types.Count == 0;

    public IEnumerator<KeyValuePair<Type, TValue>> GetEnumerator() =>
        _types.GetEnumerator();

}