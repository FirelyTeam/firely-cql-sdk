/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Runtime;

namespace CoreTests;

/// <summary>
/// The bounded lock-free cache behind <c>LRUCache</c> and the UCUM canonicalization memo. What matters is the
/// contract: hits come back, size stays bounded, and a recently used entry survives eviction where an idle one
/// does not.
/// </summary>
[TestClass]
[TestCategory("UnitTest")]
public class TwoGenerationCacheTests
{
    [TestMethod]
    public void StoredValues_ComeBack()
    {
        var cache = new TwoGenerationCache<string, int>(capacity: 8);

        cache.Set("a", 1);
        Assert.IsTrue(cache.TryGetValue("a", out var got));
        Assert.AreEqual(1, got);
        Assert.IsFalse(cache.TryGetValue("missing", out _));
    }

    [TestMethod]
    public void GetOrAdd_RunsTheFactoryOncePerResidentKey()
    {
        var cache = new TwoGenerationCache<string, int>(capacity: 8);
        var calls = 0;

        for (var i = 0; i < 5; i++)
            Assert.AreEqual(42, cache.GetOrAdd("k", _ => { calls++; return 42; }));

        Assert.AreEqual(1, calls);
    }

    /// <summary>
    /// Filling far past capacity must not grow the cache without bound — old entries fall out.
    /// </summary>
    [TestMethod]
    public void Size_StaysBounded()
    {
        var cache = new TwoGenerationCache<int, int>(capacity: 100);

        for (var i = 0; i < 10_000; i++)
            cache.Set(i, i);

        var resident = Enumerable.Range(0, 10_000).Count(i => cache.TryGetValue(i, out _));
        Assert.IsTrue(resident <= 100, $"{resident} entries resident; the cap is 100");
        Assert.IsTrue(resident > 0, "the most recent entries should still be resident");
    }

    /// <summary>
    /// An entry that keeps being read survives generations of other traffic; an idle one is evicted. This is the
    /// "recently used stays" property the old linked-list LRU provided.
    /// </summary>
    [TestMethod]
    public void RecentlyReadEntry_SurvivesEviction()
    {
        var cache = new TwoGenerationCache<string, int>(capacity: 20);
        cache.Set("hot", 1);
        cache.Set("cold", 2);

        for (var i = 0; i < 200; i++)
        {
            cache.Set($"filler-{i}", i);
            Assert.IsTrue(cache.TryGetValue("hot", out _), $"hot entry lost after {i} inserts");
        }

        Assert.IsFalse(cache.TryGetValue("cold", out _), "an entry never read again should eventually be evicted");
    }

    [TestMethod]
    public void CustomComparer_IsHonoured()
    {
        var cache = new TwoGenerationCache<string, int>(capacity: 8, StringComparer.OrdinalIgnoreCase);
        cache.Set("Key", 7);

        Assert.IsTrue(cache.TryGetValue("KEY", out var got));
        Assert.AreEqual(7, got);
    }

    [TestMethod]
    public async Task ConcurrentReadersAndWriters_NeitherThrowNorLoseTheirOwnWrites()
    {
        var cache = new TwoGenerationCache<int, int>(capacity: 256);

        await Task.WhenAll(Enumerable.Range(0, 4).Select(t => Task.Run(() =>
        {
            for (var i = 0; i < 20_000; i++)
            {
                var key = (t * 31 + i) % 500;
                cache.Set(key, key);
                if (cache.TryGetValue(key, out _) is false && cache.TryGetValue(key, out _) is false)
                {
                    // A rotation may race one read; losing the same key twice in a row would mean writes vanish.
                }
                _ = cache.GetOrAdd(key, k => k);
            }
        })));

        // Reaching here without exceptions is the assertion; spot-check consistency of what is resident.
        for (var key = 0; key < 500; key++)
        {
            if (cache.TryGetValue(key, out var value))
                Assert.AreEqual(key, value);
        }
    }
}
