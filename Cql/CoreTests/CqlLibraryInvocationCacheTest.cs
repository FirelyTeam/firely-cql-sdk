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
public class CqlLibraryInvocationCacheTest
{
    [TestMethod]
    public void Cache_WithoutCache_ShouldNotCache()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        var lib = RR23_1_0_0.Instance;
        
        // Create library invocation set but don't create/start a cache
        var libraryInvocationSet = new CqlLibraryInvocationSet(lib);

        // Act - Call the same expression twice without cache
        var result1 = lib.Measurement_Period(ctx);
        var result2 = lib.Measurement_Period(ctx);

        // Assert - Both results should be equal but not cached (new instances each time)
        Assert.IsNotNull(result1);
        Assert.IsNotNull(result2);
        Assert.AreEqual(result1, result2);
    }

    [TestMethod]
    public void Cache_WithCache_ShouldCacheResults()
    {
        // Arrange
        var ctx = FhirCqlContext.ForBundle();
        var lib = RR23_1_0_0.Instance;

        // Initialize library invocation set and cache
        var libraryInvocationSet = new CqlLibraryInvocationSet(lib);
        var cache = new CqlLibraryInvocationCache();
        cache.StartNewCache(libraryInvocationSet);

        // Act - Call the same expression twice - cache is accessed via library's invocation set
        var result1 = lib.Measurement_Period(ctx);
        var result2 = lib.Measurement_Period(ctx);

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
        var lib = RR23_1_0_0.Instance;
        var ctx = FhirCqlContext.ForBundle();

        // First cache with first library invocation set
        var libraryInvocationSet1 = new CqlLibraryInvocationSet(lib);
        var cache1 = new CqlLibraryInvocationCache();
        cache1.StartNewCache(libraryInvocationSet1);
        var result1 = lib.Measurement_Period(ctx);

        // Second cache with second library invocation set - reinitializes the library with new set
        var libraryInvocationSet2 = new CqlLibraryInvocationSet(lib);
        var cache2 = new CqlLibraryInvocationCache();
        cache2.StartNewCache(libraryInvocationSet2);
        var result2 = lib.Measurement_Period(ctx);

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
        var lib = RR23_1_0_0.Instance;
        var libraryInvocationSet = new CqlLibraryInvocationSet(lib);
        var cache = new CqlLibraryInvocationCache();
        cache.StartNewCache(libraryInvocationSet);
        var results = new System.Collections.Concurrent.ConcurrentBag<object?>();

        // Act - Multiple threads accessing the same cache simultaneously
        var parallelResult = Parallel.For(0, 20, i =>
        {
            var result = lib.Measurement_Period(ctx);
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
