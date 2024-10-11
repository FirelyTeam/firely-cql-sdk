#nullable enable
using System;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using FluentAssertions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Fhir.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeConverter = Hl7.Cql.Conversion.TypeConverter;

namespace CoreTests.Fhir;

[TestClass]
public class FhirCqlContextCreateTests
{
    private static LRUCache<CqlDateTime> CacheForFhirTypeConverterDefaultWithCache = null!;

    [ClassInitialize]
    public static void ClassInitialize(TestContext context)
    {
        CacheForFhirTypeConverterDefaultWithCache = FhirTypeConverter.DefaultWithCache.GetLRUCache().Value;
    }

    [TestMethod]
    public void CacheForFhirTypeConverterDefault_ShouldBeNull()
    {
        FhirTypeConverter.Default.GetLRUCache().HasValue.Should().BeFalse();
    }

    [TestMethod]
    public void CacheForFhirTypeConverterDefaultWithCache_ShouldHaveCapacityOf10000()
    {
        CacheForFhirTypeConverterDefaultWithCache.GetCapacity().Should().Be(10000);
    }


    [TestMethod]
    public void CreateContext_WithDefaultOptions_ShouldHaveFhirTypeConverterWithCache()
    {
        var context = CreateCqlContext();
        var typeConverter = context.GetCqlOperators().TypeConverter;
        typeConverter.Should().BeSameAs(FhirTypeConverter.DefaultWithCache);
    }

    [TestMethod]
    public void CreateContext_WithZeroCacheSizeOptions_ShouldHaveFhirTypeConverterWithoutCache()
    {
        var context = CreateCqlContext(new FhirCqlContextOptions { OverrideFhirTypeConverterCacheSize = 0 });
        var typeConverter = context.GetCqlOperators().TypeConverter;
        typeConverter.Should().BeSameAs(FhirTypeConverter.Default);
    }

    [TestMethod]
    public void CreateContextTwice_WithDefaultOptions_ShouldBeSameFhirTypeConverterWithCache()
    {
        var typeConverter1 = FhirCqlContext.CreateContext().GetCqlOperators().TypeConverter;
        var typeConverter2 = FhirCqlContext.CreateContext().GetCqlOperators().TypeConverter;
        typeConverter1.Should().BeSameAs(typeConverter2);
    }

    [TestMethod]
    public void CreateContext_WithCacheSizeOptions_ShouldHaveFhirTypeConverterWithoutCache()
    {
        var context = CreateCqlContext(new FhirCqlContextOptions { OverrideFhirTypeConverterCacheSize = 13 });
        var typeConverter = context.GetCqlOperators().TypeConverter;
        var lruCacheCapacity = typeConverter.GetLRUCache().Value.GetCapacity();
        lruCacheCapacity.Should().Be(13);
    }

    [TestMethod]
    public void CreateContextTwice_WithCacheSizeOptions_ShouldBeSameCache()
    {
        var typeConverterLRUCache1 = CreateCqlContext(new FhirCqlContextOptions { OverrideFhirTypeConverterCacheSize = 13 }).GetCqlOperators().TypeConverter.GetLRUCache().Value;
        var typeConverterLRUCache2 = CreateCqlContext(new FhirCqlContextOptions { OverrideFhirTypeConverterCacheSize = 13 }).GetCqlOperators().TypeConverter.GetLRUCache().Value;
        typeConverterLRUCache1.Should().BeSameAs(typeConverterLRUCache2);
    }

    #region Helpers

    private static CqlContext CreateCqlContext(
        FhirCqlContextOptions? options = null)
    {
        var context = FhirCqlContext.CreateContext(options: options);
        context.Should().NotBeNull();
        return context;
    }

    #endregion
}

file static class Extensions
{
    public static CqlOperators GetCqlOperators(this CqlContext context) => context.Operators.Should().BeOfType<CqlOperators>().Subject;

    public static dynamic AccessMembersDynamically(this object? obj) => obj is null ? DynamicMemberAccessor.Null : new DynamicMemberAccessor(obj);

    public static Maybe<LRUCache<CqlDateTime>> GetLRUCache(this TypeConverter typeConverter)
    {
        var fhirDateTimeConverters = typeConverter._converters[typeof(FhirDateTime)];
        LRUCache<CqlDateTime>? lruCache = fhirDateTimeConverters.Values.First().Target!.AccessMembersDynamically().conversion.Target.dateTimes;
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
                result =field.GetValue(Value).AccessMembersDynamically();
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