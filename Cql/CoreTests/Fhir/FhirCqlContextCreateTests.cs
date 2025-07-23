/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable
using Hl7.Cql.Fhir;
using Hl7.Cql.Operators;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;

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

    protected static CqlContext CreateCqlContext(
        FhirCqlContextOptions? options = null)
    {
        var context = FhirCqlContext.CreateContext(options: options);
        context.Should().NotBeNull();
        return context;
    }
}

file static class Extensions
{
    public static CqlOperators GetCqlOperators(this CqlContext context) => context.Operators.Should().BeOfType<CqlOperators>().Subject;
}
