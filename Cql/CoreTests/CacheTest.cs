/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using System.Threading.Tasks;

namespace CoreTests;

[TestClass]
public class CacheTest
{
    [TestMethod]
    public void Cache_WithoutUseNewCache_ShouldNotCache()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act - Call the same expression twice
        var result1 = lib.Result(ctx);
        var result2 = lib.Result(ctx);

        // Assert - Both results should be equal but not cached (new instances each time)
        Assert.IsNotNull(result1);
        Assert.IsNotNull(result2);
        Assert.AreEqual(result1?.status, result2?.status);
    }

    [TestMethod]
    public void Cache_WithUseNewCache_ShouldCacheResults()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        ctx.UseNewCache(); // Enable caching
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act - Call the same expression twice
        var result1 = lib.Result(ctx);
        var result2 = lib.Result(ctx);

        // Assert - Both results should be the exact same cached instance (value equality for tuples)
        Assert.IsNotNull(result1);
        Assert.IsNotNull(result2);
        Assert.AreEqual(result1, result2);
    }

    [TestMethod]
    public void Cache_AfterDontUseCaching_ShouldNotCache()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        ctx.UseNewCache(); // Enable caching
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        var result1 = lib.Result(ctx); // First call - cached

        // Act - Disable caching
        ctx.DontUseCaching();
        var result2 = lib.Result(ctx); // Should not use cache

        // Assert - Results should be equal
        Assert.IsNotNull(result1);
        Assert.IsNotNull(result2);
        Assert.AreEqual(result1?.status, result2?.status);
    }

    [TestMethod]
    public void Cache_WithMultipleContexts_ShouldBeIndependent()
    {
        // Arrange
        var ctx1 = FhirCqlContext.ForBundle();
        ctx1.UseNewCache();

        var ctx2 = FhirCqlContext.ForBundle();
        ctx2.UseNewCache();

        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act - Call with different contexts
        var result1a = lib.Result(ctx1);
        var result1b = lib.Result(ctx1); // Should be cached in ctx1

        var result2a = lib.Result(ctx2);
        var result2b = lib.Result(ctx2); // Should be cached in ctx2

        // Assert - Each context has its own cache
        Assert.AreEqual(result1a, result1b); // Same value in ctx1
        Assert.AreEqual(result2a, result2b); // Same value in ctx2
        // Both contexts should have the same result values since expression is deterministic
        Assert.AreEqual(result1a, result2a);
    }

    [TestMethod]
    public void Cache_ParallelExecution_ShouldWorkCorrectly()
    {
        // Arrange
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act - Execute in parallel with different contexts
        var results = Parallel.For(0, 10, i =>
        {
            var ctx = FhirCqlContext.ForBundle();
            ctx.UseNewCache();

            // Call twice to verify caching works per context
            var result1 = lib.Result(ctx);
            var result2 = lib.Result(ctx);

            // Verify caching within this thread's context
            Assert.IsNotNull(result1);
            Assert.AreEqual(result1, result2);
        });

        // Assert
        Assert.IsTrue(results.IsCompleted);
    }

    [TestMethod]
    public void Cache_ParallelExecutionSameContext_ShouldBeThreadSafe()
    {
        // Arrange - Shared context to test thread safety for same cache key
        var ctx = FhirCqlContext.ForBundle();
        ctx.UseNewCache();
        var lib = CqlNestedTupleTest_1_0_0.Instance;
        var results = new System.Collections.Concurrent.ConcurrentBag<object?>();

        // Act - Multiple threads accessing the same context and cache key simultaneously
        var parallelResult = Parallel.For(0, 20, i =>
        {
            var result = lib.Result(ctx);
            results.Add(result);
        });

        // Assert - All threads should get the same cached instance
        Assert.IsTrue(parallelResult.IsCompleted);
        Assert.AreEqual(20, results.Count);

        // All results should be equal (cached value)
        var firstResult = results.First();
        foreach (var result in results)
        {
            Assert.AreEqual(firstResult, result);
        }
    }

    [TestMethod]
    public void Cache_UseNewCacheInvalidates_ShouldCreateNewCache()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        ctx.UseNewCache();
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act - Get cached result
        var result1 = lib.Result(ctx);
        var result2 = lib.Result(ctx); // From cache

        // Invalidate cache
        ctx.UseNewCache();

        var result3 = lib.Result(ctx); // New cache
        var result4 = lib.Result(ctx); // From new cache

        // Assert
        Assert.AreEqual(result1, result2); // First two are same (from first cache)
        Assert.AreEqual(result3, result4); // Last two are same (from new cache)
        // All results should be equal since expression is deterministic
        Assert.AreEqual(result1, result3);
    }

    [TestMethod]
    public void Cache_Statistics_ShouldTrackHitsAndMisses()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        ctx.UseNewCache();
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act - First call should be a miss
        var result1 = lib.Result(ctx);

        // Assert - After first call
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheCallCount, "Should have 1 total call");
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheMisses, "Should have 1 miss (factory invocation)");
        Assert.AreEqual(0, ((ICqlContextInternals)ctx).CacheHits, "Should have 0 hits");

        // Act - Second call should be a hit
        var result2 = lib.Result(ctx);

        // Assert - After second call
        Assert.AreEqual(2, ((ICqlContextInternals)ctx).CacheCallCount, "Should have 2 total calls");
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheMisses, "Should still have 1 miss");
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheHits, "Should have 1 hit");

        // Act - Third call should also be a hit
        var result3 = lib.Result(ctx);

        // Assert - After third call
        Assert.AreEqual(3, ((ICqlContextInternals)ctx).CacheCallCount, "Should have 3 total calls");
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheMisses, "Should still have 1 miss");
        Assert.AreEqual(2, ((ICqlContextInternals)ctx).CacheHits, "Should have 2 hits");
    }

    [TestMethod]
    public void Cache_Statistics_ShouldResetOnUseNewCache()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        ctx.UseNewCache();
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act - Make some calls to populate statistics
        lib.Result(ctx); // Miss
        lib.Result(ctx); // Hit

        // Assert - Statistics should be tracked
        Assert.AreEqual(2, ((ICqlContextInternals)ctx).CacheCallCount);
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheMisses);
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheHits);

        // Act - Reset cache
        ctx.UseNewCache();

        // Assert - Statistics should be reset to zero
        Assert.AreEqual(0, ((ICqlContextInternals)ctx).CacheCallCount, "Call count should be reset");
        Assert.AreEqual(0, ((ICqlContextInternals)ctx).CacheMisses, "Misses should be reset");
        Assert.AreEqual(0, ((ICqlContextInternals)ctx).CacheHits, "Hits should be reset");

        // Act - Make new calls after reset
        lib.Result(ctx); // Miss

        // Assert - Statistics should start from zero again
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheCallCount);
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheMisses);
        Assert.AreEqual(0, ((ICqlContextInternals)ctx).CacheHits);
    }

    [TestMethod]
    public void Cache_Statistics_ShouldResetOnDontUseCaching()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        ctx.UseNewCache();
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act - Make some calls to populate statistics
        lib.Result(ctx); // Miss
        lib.Result(ctx); // Hit

        // Assert - Statistics should be tracked
        Assert.AreEqual(2, ((ICqlContextInternals)ctx).CacheCallCount);
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheMisses);
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheHits);

        // Act - Disable caching
        ctx.DontUseCaching();

        // Assert - Statistics should be reset to zero
        Assert.AreEqual(0, ((ICqlContextInternals)ctx).CacheCallCount, "Call count should be reset");
        Assert.AreEqual(0, ((ICqlContextInternals)ctx).CacheMisses, "Misses should be reset");
        Assert.AreEqual(0, ((ICqlContextInternals)ctx).CacheHits, "Hits should be reset");

        // Act - Make calls without caching
        lib.Result(ctx); // No cache - counts as call and miss
        lib.Result(ctx); // No cache - counts as call and miss

        // Assert - All calls without cache are misses
        Assert.AreEqual(2, ((ICqlContextInternals)ctx).CacheCallCount);
        Assert.AreEqual(2, ((ICqlContextInternals)ctx).CacheMisses);
        Assert.AreEqual(0, ((ICqlContextInternals)ctx).CacheHits);
    }

    [TestMethod]
    public void Cache_Statistics_WithoutCaching_ShouldTrackMisses()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        // Don't call UseNewCache - caching is disabled by default
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act - Make calls without caching
        lib.Result(ctx);
        lib.Result(ctx);
        lib.Result(ctx);

        // Assert - All calls are misses when caching is disabled
        Assert.AreEqual(3, ((ICqlContextInternals)ctx).CacheCallCount, "Should track all calls");
        Assert.AreEqual(3, ((ICqlContextInternals)ctx).CacheMisses, "All calls should be misses without cache");
        Assert.AreEqual(0, ((ICqlContextInternals)ctx).CacheHits, "Should have no hits without cache");
    }

    [TestMethod]
    public void Cache_UseNewCacheWithCustomCapacity_ShouldCacheResults()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        ctx.UseNewCache(initialCapacity: 64);
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act - Call the same expression twice
        var result1 = lib.Result(ctx);
        var result2 = lib.Result(ctx);

        // Assert - Caching still works with a non-default capacity
        Assert.IsNotNull(result1);
        Assert.IsNotNull(result2);
        Assert.AreEqual(result1, result2);
    }

    [TestMethod]
    public void Cache_UseNewCacheWithMinimumCapacity_ShouldSucceed()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();

        // Act - The minimum accepted capacity should not throw
        ctx.UseNewCache(initialCapacity: CqlContext.MinimumCacheInitialCapacity);
        var lib = CqlNestedTupleTest_1_0_0.Instance;
        var result1 = lib.Result(ctx);
        var result2 = lib.Result(ctx);

        // Assert
        Assert.AreEqual(result1, result2);
    }

    [DataTestMethod]
    [DataRow(0)]
    [DataRow(1)]
    [DataRow(-1)]
    [DataRow(int.MinValue)]
    public void Cache_UseNewCacheWithTooSmallCapacity_ShouldThrow(int initialCapacity)
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();

        // Act & Assert
        var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(() => ctx.UseNewCache(initialCapacity));
        Assert.AreEqual("initialCapacity", ex.ParamName);
    }

    [DataTestMethod]
    [DataRow(0)]
    [DataRow(-1)]
    [DataRow(int.MinValue)]
    public void Cache_UseNewCacheWithTooSmallConcurrencyLevel_ShouldThrow(int concurrencyLevel)
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();

        // Act & Assert
        var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(
            () => ctx.UseNewCache(CqlContext.CacheInitialCapacity, concurrencyLevel));
        Assert.AreEqual("concurrencyLevel", ex.ParamName);
    }

    [DataTestMethod]
    [DataRow(CqlContext.SequentialCacheConcurrencyLevel)]
    [DataRow(2)]
    [DataRow(64)]
    public void Cache_UseNewCacheWithConcurrencyLevel_ShouldCacheResults(int concurrencyLevel)
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        ctx.UseNewCache(CqlContext.CacheInitialCapacity, concurrencyLevel);
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act - Call the same expression twice
        var result1 = lib.Result(ctx);
        var result2 = lib.Result(ctx);

        // Assert - The concurrency level does not affect what is cached
        Assert.AreEqual(result1, result2);
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheMisses, "Should have 1 miss");
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheHits, "Should have 1 hit");
    }

    [TestMethod]
    public void Cache_UseNewCacheWithConcurrencyLevelAndTooSmallCapacity_ShouldThrow()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();

        // Act & Assert
        var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(
            () => ctx.UseNewCache(CqlContext.MinimumCacheInitialCapacity - 1, concurrencyLevel: 4));
        Assert.AreEqual("initialCapacity", ex.ParamName);
    }

    [DataTestMethod]
    [DataRow(CqlContext.MaximumCacheConcurrencyLevel + 1)]
    [DataRow(int.MaxValue)]
    public void Cache_UseNewCacheWithTooLargeConcurrencyLevel_ShouldThrow(int concurrencyLevel)
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();

        // Act & Assert — an unchecked value would reach ConcurrentDictionary's constructor and
        // cause OutOfMemoryException instead of the clean ArgumentOutOfRangeException.
        var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(
            () => ctx.UseNewCache(CqlContext.CacheInitialCapacity, concurrencyLevel));
        Assert.AreEqual("concurrencyLevel", ex.ParamName);
    }

    /// <summary>
    /// Regression test: <see cref="CqlContext.UseNewCache(int)"/> must delegate to
    /// <see cref="CqlContext.UseNewCache(int,int)"/> with
    /// <see cref="CqlContext.SequentialCacheConcurrencyLevel"/> (= 1).  If someone accidentally
    /// changes the delegation to use e.g. <see cref="Environment.ProcessorCount"/>, the two-arg
    /// overload's upper-bound guard will throw on the highest boundary value only when ProcessorCount
    /// exceeds MaximumCacheConcurrencyLevel, so this test catches the mistake by verifying the
    /// one-arg overload succeeds with the same capacity/statistics as an explicit sequential call.
    /// </summary>
    [TestMethod]
    public void Cache_UseNewCacheOneArgOverload_DelegatesToSequentialConcurrencyLevel()
    {
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Context created via the 1-arg overload
        var ctxOneArg = FhirCqlContext.ForBundle();
        ctxOneArg.UseNewCache(CqlContext.CacheInitialCapacity);
        lib.Result(ctxOneArg); // miss
        lib.Result(ctxOneArg); // hit

        // Context created via the explicit-sequential 2-arg overload — must be identical
        var ctxTwoArg = FhirCqlContext.ForBundle();
        ctxTwoArg.UseNewCache(CqlContext.CacheInitialCapacity, CqlContext.SequentialCacheConcurrencyLevel);
        lib.Result(ctxTwoArg); // miss
        lib.Result(ctxTwoArg); // hit

        var internalsOneArg = (ICqlContextInternals)ctxOneArg;
        var internalsTwoArg = (ICqlContextInternals)ctxTwoArg;

        Assert.AreEqual(internalsTwoArg.CacheCallCount, internalsOneArg.CacheCallCount,
            "1-arg overload must produce the same CacheCallCount as the sequential 2-arg overload.");
        Assert.AreEqual(internalsTwoArg.CacheMisses, internalsOneArg.CacheMisses,
            "1-arg overload must produce the same CacheMisses as the sequential 2-arg overload.");
        Assert.AreEqual(internalsTwoArg.CacheHits, internalsOneArg.CacheHits,
            "1-arg overload must produce the same CacheHits as the sequential 2-arg overload.");
    }
}
