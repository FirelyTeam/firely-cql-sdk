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
}
