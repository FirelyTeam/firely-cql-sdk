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

        // Initialize library invocation set and start caching on context
        var libraryInvocationSet = new CqlLibraryInvocationSet(lib);
        ctx.StartCaching(libraryInvocationSet);

        // Act - Call the same expression twice - cache is accessed via context
        var result1 = lib.Measurement_Period(ctx);
        var result2 = lib.Measurement_Period(ctx);

        // Assert - Both results should be the exact same cached instance
        Assert.IsNotNull(result1);
        Assert.IsNotNull(result2);
        Assert.AreEqual(result1, result2);

        // Verify cache was used
        Assert.AreEqual(2, ctx.CacheCallCount);
        Assert.AreEqual(1, ctx.CacheMisses);
        Assert.AreEqual(1, ctx.CacheHits);
    }

    [TestMethod]
    public void Cache_DifferentCaches_ShouldBeIndependent()
    {
        // Arrange
        var lib = RR23_1_0_0.Instance;
        
        // First context with cache
        var ctx1 = FhirCqlContext.ForBundle();
        var libraryInvocationSet1 = new CqlLibraryInvocationSet(lib);
        ctx1.StartCaching(libraryInvocationSet1);
        var result1 = lib.Measurement_Period(ctx1);

        // Second context with separate cache - reinitializes the library with new set
        var ctx2 = FhirCqlContext.ForBundle();
        var libraryInvocationSet2 = new CqlLibraryInvocationSet(lib);
        ctx2.StartCaching(libraryInvocationSet2);
        var result2 = lib.Measurement_Period(ctx2);

        // Assert - Each context tracks cache independently
        Assert.AreEqual(1, ctx1.CacheCallCount);
        Assert.AreEqual(1, ctx1.CacheMisses);
        Assert.AreEqual(1, ctx2.CacheCallCount);
        Assert.AreEqual(1, ctx2.CacheMisses);
    }

    [TestMethod]
    public void Cache_ParallelExecutionSameCache_ShouldBeThreadSafe()
    {
        // Arrange
        var lib = RR23_1_0_0.Instance;
        var libraryInvocationSet = new CqlLibraryInvocationSet(lib);
        var results = new System.Collections.Concurrent.ConcurrentBag<(object? result, long callCount, long misses, long hits)>();

        // Act - Multiple threads accessing with their own contexts (thread-safe because each thread has its own context)
        var parallelResult = Parallel.For(0, 20, i =>
        {
            var ctx = FhirCqlContext.ForBundle();
            ctx.StartCaching(libraryInvocationSet);
            var result = lib.Measurement_Period(ctx);
            results.Add((result, ctx.CacheCallCount, ctx.CacheMisses, ctx.CacheHits));
        });

        // Assert
        Assert.IsTrue(parallelResult.IsCompleted);
        Assert.AreEqual(20, results.Count);

        // Each context computed once (no sharing across threads with different contexts)
        foreach (var (result, callCount, misses, hits) in results)
        {
            Assert.IsNotNull(result);
            Assert.AreEqual(1, callCount);
            Assert.AreEqual(1, misses);
            Assert.AreEqual(0, hits);
        }
    }
}
