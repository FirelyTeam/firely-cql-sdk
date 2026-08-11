/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable disable

using System.Collections.Concurrent;
using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;

namespace CoreTests;

/// <summary>
/// Covers <see cref="EvaluationCacheProfile"/>, its plumbing through <see cref="FhirCqlContextOptions"/>, and the
/// thread-safety contract of a <see cref="CqlContext"/> shared by concurrently evaluating threads.
/// </summary>
[TestClass]
public class EvaluationCacheProfileTests
{
    /// <summary>
    /// The number of threads that evaluate over the one shared context in the stress test.
    /// </summary>
    private const int ThreadCount = 8;

    /// <summary>
    /// The number of times each thread of the stress test evaluates the whole set of definitions.
    /// </summary>
    private const int IterationsPerThread = 200;

    /// <summary>
    /// The number of distinct cache keys <see cref="EvaluateAll"/> touches: the two parameters
    /// (ChosenSubCategory, ChosenCode) and the three expressions (ValueSetA, ValueSetB, Result) of
    /// ValueSetExprExample.
    /// </summary>
    private const int CachedDefinitionCount = 5;

    private static IValueSetDictionary _valueSets;

    [ClassInitialize]
    public static void ClassInitialize(TestContext _) =>
        _valueSets = new[]
        {
            ValueSet("A", "1"),
            ValueSet("A", "2"),
            ValueSet("B", "1"),
            ValueSet("B", "2"),
        }.ToValueSetDictionary();

    #region Profile defaults

    [TestMethod]
    public void EvaluationCacheProfile_Default_ShouldBeSequentialWithDefaultCapacity()
    {
        var profile = new EvaluationCacheProfile();

        profile.InitialCapacity.Should().Be(CqlContext.CacheInitialCapacity);
        profile.ConcurrencyLevel.Should().Be(CqlContext.SequentialCacheConcurrencyLevel);
    }

    [TestMethod]
    public void EvaluationCacheProfile_Sequential_ShouldUseSingleWriteLock()
    {
        EvaluationCacheProfile.Sequential.ConcurrencyLevel.Should().Be(CqlContext.SequentialCacheConcurrencyLevel);
        EvaluationCacheProfile.Sequential.InitialCapacity.Should().Be(CqlContext.CacheInitialCapacity);
    }

    [TestMethod]
    public void EvaluationCacheProfile_Concurrent_ShouldUseOneWriteLockPerProcessor()
    {
        EvaluationCacheProfile.Concurrent.ConcurrencyLevel.Should().Be(Environment.ProcessorCount);
        EvaluationCacheProfile.Concurrent.InitialCapacity.Should().Be(CqlContext.CacheInitialCapacity);
    }

    [TestMethod]
    public void EvaluationCacheProfile_Concurrent_ShouldReturnANewInstancePerCall()
    {
        // A fresh instance per call keeps callers that customize a profile from affecting each other.
        EvaluationCacheProfile.Concurrent.Should().NotBeSameAs(EvaluationCacheProfile.Concurrent);
    }

    #endregion Profile defaults

    #region Options plumb-through

    [TestMethod]
    public void ForBundle_WithoutEvaluationCacheProfile_ShouldNotCache()
    {
        // Arrange - the cache is opt-in, so the default options leave it off
        var ctx = FhirCqlContext.ForBundle();
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act
        lib.Result(ctx);
        lib.Result(ctx);
        lib.Result(ctx);

        // Assert - every call re-evaluates the definition
        var internals = (ICqlContextInternals)ctx;
        internals.CacheCallCount.Should().Be(3);
        internals.CacheMisses.Should().Be(3);
        internals.CacheHits.Should().Be(0);
    }

    [DataTestMethod]
    [DataRow(false)]
    [DataRow(true)]
    public void ForBundle_WithEvaluationCacheProfile_ShouldCache(bool concurrent)
    {
        // Arrange
        var options = new FhirCqlContextOptions
        {
            EvaluationCache = concurrent ? EvaluationCacheProfile.Concurrent : EvaluationCacheProfile.Sequential
        };
        var ctx = FhirCqlContext.ForBundle(options: options);
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act
        var result1 = lib.Result(ctx);
        var result2 = lib.Result(ctx);

        // Assert - the second call is served from the cache created by the profile
        result2.Should().Be(result1);
        var internals = (ICqlContextInternals)ctx;
        internals.CacheCallCount.Should().Be(2);
        internals.CacheMisses.Should().Be(1);
        internals.CacheHits.Should().Be(1);
    }

    [TestMethod]
    public void WithDataSource_WithEvaluationCacheProfile_ShouldCache()
    {
        // Arrange
        var options = new FhirCqlContextOptions { EvaluationCache = EvaluationCacheProfile.Concurrent };
        var ctx = FhirCqlContext.WithDataSource(options: options);
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act
        lib.Result(ctx);
        lib.Result(ctx);

        // Assert
        var internals = (ICqlContextInternals)ctx;
        internals.CacheMisses.Should().Be(1);
        internals.CacheHits.Should().Be(1);
    }

    [TestMethod]
    public void ForBundle_WithEvaluationCacheProfileCustomCapacity_ShouldCache()
    {
        // Arrange
        var options = new FhirCqlContextOptions
        {
            EvaluationCache = new EvaluationCacheProfile
            {
                InitialCapacity = CqlContext.MinimumCacheInitialCapacity,
                ConcurrencyLevel = 4
            }
        };
        var ctx = FhirCqlContext.ForBundle(options: options);
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act
        lib.Result(ctx);
        lib.Result(ctx);

        // Assert
        var internals = (ICqlContextInternals)ctx;
        internals.CacheMisses.Should().Be(1);
        internals.CacheHits.Should().Be(1);
    }

    [TestMethod]
    public void ForBundle_WithInvalidEvaluationCacheProfile_ShouldThrow()
    {
        // Arrange
        var options = new FhirCqlContextOptions
        {
            EvaluationCache = new EvaluationCacheProfile { InitialCapacity = CqlContext.MinimumCacheInitialCapacity - 1 }
        };

        // Act & Assert - the profile values are validated by the context that consumes them
        var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(() => FhirCqlContext.ForBundle(options: options));
        ex.ParamName.Should().Be("initialCapacity");
    }

    #endregion Options plumb-through

    #region Shared context stress test

    [TestMethod]
    public void SharedContextWithConcurrentProfile_EvaluatedFromManyThreads_ShouldMemoizeAndMatchSequentialBaseline()
    {
        // Arrange - the sequential baseline is computed on its own, uncached context
        var lib = ValueSetExprExample_1_0_0.Instance;
        var baseline = EvaluateAll(lib, CreateContext(cacheProfile: null));

        // One context shared by all threads. Its parameters are fully populated by the factory and are not
        // touched afterwards, and the value sets behind it are immutable, which is what sharing a context
        // across threads requires.
        var shared = CreateContext(EvaluationCacheProfile.Concurrent);

        var observed = new ConcurrentBag<string>();
        var failures = new ConcurrentBag<Exception>();
        var startGate = new Barrier(ThreadCount);
        var threads = new Thread[ThreadCount];

        // Act - fan the evaluation out over ThreadCount threads that all start at the same moment, so the
        // threads race on the same, still empty cache.
        for (var i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(() =>
            {
                try
                {
                    startGate.SignalAndWait();
                    for (var iteration = 0; iteration < IterationsPerThread; iteration++)
                        observed.Add(EvaluateAll(lib, shared));
                }
                catch (Exception e)
                {
                    failures.Add(e);
                }
            });
            threads[i].Start();
        }

        foreach (var thread in threads)
            thread.Join();

        // Assert
        failures.Should().BeEmpty("concurrent evaluation over one shared context should not fail");

        // (a) Every thread observed the same values the sequential baseline produced.
        observed.Should().HaveCount(ThreadCount * IterationsPerThread);
        observed.Should().AllBe(baseline);

        var internals = (ICqlContextInternals)shared;
        var callCount = internals.CacheCallCount;
        var hits = internals.CacheHits;
        var misses = internals.CacheMisses;

        // (b) The counters stay consistent under concurrent increments.
        (hits + misses).Should().Be(callCount);
        callCount.Should().BeGreaterThanOrEqualTo(ThreadCount * IterationsPerThread * CachedDefinitionCount);

        // (c) Misses are bounded: a definition is only evaluated by the threads that reach it before the first
        // of them stores its result, so at most once per thread per definition. Everything after that is a hit,
        // which is what proves memoization survived the concurrency.
        misses.Should().BeGreaterThanOrEqualTo(CachedDefinitionCount);
        misses.Should().BeLessThanOrEqualTo(CachedDefinitionCount * ThreadCount);
        misses.Should().BeLessThan(callCount / 10);
    }

    [TestMethod]
    public void SharedContextWithoutProfile_EvaluatedFromManyThreads_ShouldMatchSequentialBaselineWithoutMemoizing()
    {
        // Arrange - same fan-out, but without the opt-in cache every call re-evaluates
        var lib = ValueSetExprExample_1_0_0.Instance;
        var shared = CreateContext(cacheProfile: null);
        var baseline = EvaluateAll(lib, CreateContext(cacheProfile: null));

        var observed = new ConcurrentBag<string>();

        // Act
        Parallel.For(0, ThreadCount, _ =>
        {
            for (var iteration = 0; iteration < IterationsPerThread; iteration++)
                observed.Add(EvaluateAll(lib, shared));
        });

        // Assert
        observed.Should().HaveCount(ThreadCount * IterationsPerThread);
        observed.Should().AllBe(baseline);

        var internals = (ICqlContextInternals)shared;
        internals.CacheHits.Should().Be(0, "without a cache no call can be a hit");
        internals.CacheMisses.Should().Be(internals.CacheCallCount);
    }

    #endregion Shared context stress test

    /// <summary>
    /// Evaluates every cached definition of ValueSetExprExample and folds the results into one comparable
    /// signature. The definitions are interdependent — Result reads ChosenCode, ValueSetA and ValueSetB, and both
    /// value set expressions read ChosenSubCategory — so a shared cache is exercised through nested references as
    /// well as through the direct calls made here.
    /// </summary>
    private static string EvaluateAll(ValueSetExprExample_1_0_0 lib, CqlContext ctx) =>
        string.Join(
            "|",
            lib.ChosenSubCategory(ctx),
            lib.ChosenCode(ctx)?.code,
            lib.ValueSetA(ctx)?.id,
            lib.ValueSetB(ctx)?.id,
            lib.Result(ctx));

    private static CqlContext CreateContext(EvaluationCacheProfile cacheProfile) =>
        FhirCqlContext.ForBundle(
            valueSets: _valueSets,
            parameters: new Dictionary<string, object>(),
            options: new FhirCqlContextOptions { EvaluationCache = cacheProfile });

    private static ValueSet ValueSet(string category, string subCategory) =>
        new()
        {
            Id = ValueSetIdFor(category, subCategory),
            Url = ValueSetIdFor(category, subCategory),
            Expansion = new ValueSet.ExpansionComponent
            {
                Contains =
                [
                    new()
                    {
                        Code = $"{category}-{subCategory}-A",
                        System = "http://fire.ly/CodeSystem/Test"
                    },
                    new()
                    {
                        Code = $"{category}-{subCategory}-B",
                        System = "http://fire.ly/CodeSystem/Test"
                    },
                ]
            }
        };

    private static string ValueSetIdFor(string category, string subCategory) =>
        $"http://fire.ly/ValueSet/ValueSet-{category}-{subCategory}";
}
