#nullable enable
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using Hl7.Cql.Conversion;

namespace CoreTests;

internal static class Extensions
{
    public static dynamic AccessMembersDynamically(this object? obj) => obj is null ? DynamicMemberAccessor.Null : new DynamicMemberAccessor(obj);

    public static Maybe<LRUCache<CqlDateTime>> GetLRUCache(this TypeConverter typeConverter)
    {
        Dictionary<Type, Dictionary<Type, Func<object, object>>> converters = typeConverter.AccessMembersDynamically()._converters;
        Dictionary<Type, Func<object, object>> fhirDateTimeConverters = converters[typeof(FhirDateTime)];
        Func<object, object> firstConversion = fhirDateTimeConverters.Values.First();
        LRUCache<CqlDateTime>? lruCache = firstConversion.Target!.AccessMembersDynamically().conversion.Target.dateTimes;
        return lruCache;
    }

    public static int GetCapacity(this LRUCache<CqlDateTime> lruCache)
    {
        int capacity = lruCache.AccessMembersDynamically().Capacity;
        return capacity;
    }
}

public readonly record struct Maybe<T>
{
    private readonly T _value;

    private Maybe(T Value)
    {
        this._value = Value;
    }

    public T Value => HasValue ? _value : throw new InvalidOperationException("No value");

    public bool HasValue { get; } = true;

    public static implicit operator Maybe<T>(T? value) => value is null ? default : new(value);
}

public class DynamicMemberAccessor(object? value) : DynamicObject
{
    public static readonly DynamicMemberAccessor Null = new(null);
    private object? Value { get; } = value;
    private Type? Type { get; } = value?.GetType();

    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {
        switch (Type?.GetMember(binder.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
        {
            case [FieldInfo field]:
                result = field.GetValue(Value).AccessMembersDynamically();
                return true;
            case [PropertyInfo prop] when prop.GetIndexParameters() is []:
                result = prop.GetValue(Value).AccessMembersDynamically();
                return true;
            default:
                result = Null;
                return true;
        }
    }

    public override bool TryConvert(ConvertBinder binder, out object? result)
    {
        result = Value;
        return true;
    }
}