/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;

namespace CoreTests;

[TestClass]
public class CqlLibrariesExecutionCacheTest
{
    [TestMethod]
    public void Cache_WithoutCache_ShouldNotCache()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Act - Call the same expression twice without cache
        var result1 = lib.Result(ctx);
        var result2 = lib.Result(ctx);

        // Assert - Both results should be equal but not cached (new instances each time)
        Assert.IsNotNull(result1);
        Assert.IsNotNull(result2);
        Assert.AreEqual(result1?.status, result2?.status);
    }

    [TestMethod]
    public void Cache_WithCache_ShouldCacheResults()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Initialize cache - this sets the CacheInstance on the library
        var cache = new CqlLibrariesExecutionCache(libraries: lib);

        // Act - Call the same expression twice - cache is accessed via library's CacheInstance
        var result1 = lib.Result(ctx);
        var result2 = lib.Result(ctx);

        // Assert - Both results should be the exact same cached instance
        Assert.IsNotNull(result1);
        Assert.IsNotNull(result2);
        Assert.AreEqual(result1, result2);

        // Verify cache was used
        Assert.AreEqual(2, cache.CacheCallCount);
        Assert.AreEqual(1, cache.CacheMisses);
        Assert.AreEqual(1, cache.CacheHits);
    }

    [TestMethod]
    public void Cache_DifferentCaches_ShouldBeIndependent()
    {
        // Arrange
        var lib = CqlNestedTupleTest_1_0_0.Instance;
        var ctx = FhirCqlContext.ForBundle();

        // First cache
        var cache1 = new CqlLibrariesExecutionCache(libraries: lib);
        var result1 = lib.Result(ctx);

        // Second cache - reinitializes the library with new cache
        var cache2 = new CqlLibrariesExecutionCache(libraries: lib);
        var result2 = lib.Result(ctx);

        // Assert - Each cache tracks independently
        Assert.AreEqual(1, cache1.CacheCallCount);
        Assert.AreEqual(1, cache1.CacheMisses);
        Assert.AreEqual(1, cache2.CacheCallCount);
        Assert.AreEqual(1, cache2.CacheMisses);
    }

    [TestMethod]
    public void Cache_ParallelExecutionSameCache_ShouldBeThreadSafe()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        var lib = CqlNestedTupleTest_1_0_0.Instance;
        var cache = new CqlLibrariesExecutionCache(libraries: lib);
        var results = new System.Collections.Concurrent.ConcurrentBag<object?>();

        // Act - Multiple threads accessing the same cache simultaneously
        var parallelResult = Parallel.For(0, 20, i =>
        {
            var result = lib.Result(ctx);
            results.Add(result);
        });

        // Assert
        Assert.IsTrue(parallelResult.IsCompleted);
        Assert.AreEqual(20, results.Count);

        // All results should be equal (cached value)
        var firstResult = results.First();
        foreach (var result in results)
        {
            Assert.AreEqual(firstResult, result);
        }

        // Verify thread-safety: only one factory invocation despite parallel calls
        Assert.AreEqual(20, cache.CacheCallCount);
        Assert.AreEqual(1, cache.CacheMisses);
        Assert.AreEqual(19, cache.CacheHits);
    }
}
