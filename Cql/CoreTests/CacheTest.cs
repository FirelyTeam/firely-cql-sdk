/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.Internal;
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
    public void CacheIndexInitializer_ShouldSetIndicesSequentially()
    {
        // Arrange
        var lib = ConceptDefTest_1_0_0.Instance;

        // Act
        var initializer = new CacheIndexInitializer(lib);

        // Assert - Cache indices should be set sequentially starting from 1
        var libraryType = lib.GetType();
        var cacheIndexFields = libraryType
            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
            .Where(f => f.Name.StartsWith("_cacheIndex_") && f.FieldType == typeof(int))
            .OrderBy(f => f.Name)
            .ToArray();

        Assert.IsTrue(cacheIndexFields.Length > 0, "Should have cache index fields");

        foreach (var field in cacheIndexFields)
        {
            var value = (int)field.GetValue(lib)!;
            Assert.IsTrue(value > 0, $"Field {field.Name} should have a positive index, but was {value}");
        }

        // Verify CacheIndexCount property
        Assert.AreEqual(cacheIndexFields.Length, initializer.CacheIndexCount, "CacheIndexCount should match number of cache index fields");
    }

    [TestMethod]
    public void CacheIndexInitializer_ShouldIncludeDependencies()
    {
        // Arrange
        var lib = TestRetrieve_1_0_1.Instance;

        // Act
        var initializer = new CacheIndexInitializer(lib);

        // Assert - Dependencies should also have indices set
        Assert.IsTrue(lib.Dependencies.Length > 0, "TestRetrieve should have dependencies");

        var totalFields = 0;
        foreach (var dependency in lib.Dependencies)
        {
            var depType = dependency.GetType();
            var cacheIndexFields = depType
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(f => f.Name.StartsWith("_cacheIndex_") && f.FieldType == typeof(int))
                .ToArray();

            if (cacheIndexFields.Length > 0)
            {
                totalFields += cacheIndexFields.Length;
                foreach (var field in cacheIndexFields)
                {
                    var value = (int)field.GetValue(dependency)!;
                    Assert.IsTrue(value > 0, $"Dependency field {field.Name} should have a positive index");
                }
            }
        }

        // Count fields in the root library too
        var libType = lib.GetType();
        var libCacheIndexFields = libType
            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
            .Where(f => f.Name.StartsWith("_cacheIndex_") && f.FieldType == typeof(int))
            .ToArray();
        totalFields += libCacheIndexFields.Length;

        // Verify CacheIndexCount includes dependencies
        Assert.AreEqual(totalFields, initializer.CacheIndexCount, "CacheIndexCount should include all libraries and dependencies");
    }

    [TestMethod]
    public void CacheIndexInitializer_ShouldFailIfAlreadyInitialized()
    {
        // Arrange - use a library that should already be initialized from other tests
        var lib = RR23_1_0_0.Instance;

        // Verify it's already initialized
        var libraryType = lib.GetType();
        var anyField = libraryType
            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
            .FirstOrDefault(f => f.Name.StartsWith("_cacheIndex_") && f.FieldType == typeof(int));

        if (anyField != null)
        {
            var currentValue = (int)anyField.GetValue(lib)!;
            if (currentValue == 0)
            {
                // Initialize it first
                _ = new CacheIndexInitializer(lib);
            }
        }

        // Act & Assert - Second initialization should throw
        Assert.ThrowsException<InvalidOperationException>(() =>
        {
            _ = new CacheIndexInitializer(lib);
        });
    }

    [TestMethod]
    public void Cache_WithInitializedIndices_ShouldCacheCorrectly()
    {
        // Arrange
        var lib = CqlNestedTupleTest_1_0_0.Instance;

        // Initialize if not already initialized
        var libraryType = lib.GetType();
        var anyField = libraryType
            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
            .FirstOrDefault(f => f.Name.StartsWith("_cacheIndex_") && f.FieldType == typeof(int));

        if (anyField != null)
        {
            var currentValue = (int)anyField.GetValue(lib)!;
            if (currentValue == 0)
            {
                _ = new CacheIndexInitializer(lib);
            }
        }

        var ctx = FhirCqlContext.ForBundle();
        ctx.UseNewCache();

        // Act - Call the same expression twice
        var result1 = lib.Result(ctx);
        var result2 = lib.Result(ctx);

        // Assert - Results should be cached
        Assert.IsNotNull(result1);
        Assert.IsNotNull(result2);
        Assert.AreEqual(result1, result2);
        Assert.AreEqual(2, ((ICqlContextInternals)ctx).CacheCallCount);
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheMisses);
        Assert.AreEqual(1, ((ICqlContextInternals)ctx).CacheHits);
    }
}
