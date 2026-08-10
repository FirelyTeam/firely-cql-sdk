/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections;
using System.Collections.Concurrent;
using System.Runtime.Loader;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.CqlToElm.Toolkit.Extensions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Invocation.Toolkit.Extensions;
using Hl7.Cql.Invocation.Toolkit.Internal;
using Hl7.Cql.Runtime;


namespace CoreTests;

/// <summary>
/// Covers <see cref="LibrarySetInvokerPool"/>: that it reuses library sets keyed on binary content,
/// that eviction actually lets an assembly load context unload, and that a shared invoker survives
/// concurrent evaluation.
/// </summary>
[TestClass]
public class LibrarySetInvokerPoolTests
{
    private const string LibraryCql =
        """
        library PoolTestLib version '1.0.0'

        define "Answer": 6 * 7
        define "Greeting": 'hello ' + 'world'
        """;

    private const string OtherLibraryCql =
        """
        library PoolTestOtherLib version '1.0.0'

        define "Answer": 1 + 1
        """;

    private static readonly ElmToolkitConfig ElmToolkitConfig = new();

    /// <summary>
    /// How long a test waits on a thread it has deliberately parked. Generous, because it only ever
    /// elapses when the code under test has deadlocked - in which case failing beats hanging the run.
    /// </summary>
    private static readonly TimeSpan HookTimeout = TimeSpan.FromSeconds(30);

    private static IReadOnlyList<AssemblyBinary> _libraryBinaries = null!;
    private static IReadOnlyList<AssemblyBinary> _otherLibraryBinaries = null!;

    [ClassInitialize]
    public static void ClassInitialize(TestContext _)
    {
        _libraryBinaries = Compile(LibraryCql);
        _otherLibraryBinaries = Compile(OtherLibraryCql);
    }

    #region Content-based reuse

    [TestMethod]
    public void GetOrCreate_SameContentFromSeparateToolkits_ReturnsTheSameInvoker()
    {
        // Arrange - two independent toolkits over byte arrays that are equal in content but are
        // distinct objects. This is the case that reference equality would fail: AssemblyBinary is a
        // record over byte[], so its synthesized equality is reference identity.
        using var pool = new LibrarySetInvokerPool();

        // Act
        var first = pool.GetOrCreate(BuildToolkit(_libraryBinaries));
        var second = pool.GetOrCreate(BuildToolkit(_libraryBinaries));

        // Assert
        second.Should().BeSameAs(first);
        pool.Statistics.Misses.Should().Be(1);
        pool.Statistics.Hits.Should().Be(1);
        pool.Statistics.Entries.Should().Be(1);
    }

    [TestMethod]
    public void GetOrCreate_DifferentContent_ReturnsDifferentInvokers()
    {
        using var pool = new LibrarySetInvokerPool();

        var first = pool.GetOrCreate(BuildToolkit(_libraryBinaries));
        var second = pool.GetOrCreate(BuildToolkit(_otherLibraryBinaries));

        second.Should().NotBeSameAs(first);
        pool.Statistics.Misses.Should().Be(2);
        pool.Statistics.Entries.Should().Be(2);
    }

    [TestMethod]
    public void GetOrCreate_DifferentLibrarySetName_ReturnsDifferentInvokers()
    {
        using var pool = new LibrarySetInvokerPool();

        var first = pool.GetOrCreate(BuildToolkit(_libraryBinaries), "one");
        var second = pool.GetOrCreate(BuildToolkit(_libraryBinaries), "two");

        second.Should().NotBeSameAs(first);
        first.LibrarySetName.Should().Be("one");
        second.LibrarySetName.Should().Be("two");
    }

    [TestMethod]
    public void GetOrCreate_DifferentExceptionContinuation_ReturnsDifferentInvokers()
    {
        // The continuation is part of the key, so callers wanting different policies over the same
        // binaries get their own instance rather than racing over one shared mutable field.
        using var pool = new LibrarySetInvokerPool();

        var throwing = pool.GetOrCreate(BuildToolkit(_libraryBinaries, BatchProcessExceptionContinuation.Throw));
        var continuing = pool.GetOrCreate(BuildToolkit(_libraryBinaries, BatchProcessExceptionContinuation.Continue));

        continuing.Should().NotBeSameAs(throwing);
        throwing.BatchProcessExceptionContinuation.Should().Be(BatchProcessExceptionContinuation.Throw);
        continuing.BatchProcessExceptionContinuation.Should().Be(BatchProcessExceptionContinuation.Continue);
    }

    [TestMethod]
    public void GetOrCreate_PooledInvokerEvaluatesCorrectly()
    {
        using var pool = new LibrarySetInvokerPool();

        var invoker = pool.GetOrCreate(BuildToolkit(_libraryBinaries));

        Evaluate(invoker).Should().Be("42|hello world");
    }

    [TestMethod]
    public void PoolKey_ContentHash_IsMemoizedPerSetInstanceButStaysContentBased()
    {
        // The content hash is memoized on the identity of the immutable binary set, so that a pool hit
        // does not re-run SHA-256 over multi-megabyte assemblies on the one-call-per-subject hot path.
        // The risk that buys is regressing the key back to identity comparison, which would defeat the
        // whole point of hashing content - so both halves are pinned here.
        var toolkit = BuildToolkit(_libraryBinaries);
        var equivalentToolkit = BuildToolkit(_libraryBinaries);

        var first = LibrarySetInvokerPoolKey.Create(
            toolkit.AssemblyBinaries, "set", BatchProcessExceptionContinuation.Throw);
        var repeated = LibrarySetInvokerPoolKey.Create(
            toolkit.AssemblyBinaries, "set", BatchProcessExceptionContinuation.Throw);
        var equivalent = LibrarySetInvokerPoolKey.Create(
            equivalentToolkit.AssemblyBinaries, "set", BatchProcessExceptionContinuation.Throw);

        repeated.Should().Be(first, "a repeat call over the same set instance must be stable");
        equivalent.Should().Be(
            first,
            "the key must stay content-based: two distinct sets holding equal bytes are the same "
            + "library set as far as the pool is concerned");
    }

    [TestMethod]
    public void PoolKey_ContentHash_ReusesArrayHashesAcrossFreshToolkitsOverTheSameArrays()
    {
        // The hot path this pool exists for builds a fresh toolkit per call - one Library/$evaluate per
        // subject - so the set-instance memo never hits, and only a memo keyed on the byte arrays keeps
        // each call from re-hashing megabytes. The arrays are what a consumer holds stable (typically a
        // per-run artifact cache), so sharing those must be enough.
        //
        // Asserted by membership rather than by timing: both arrays being present in the memo is what
        // makes the next call a lookup instead of another pass over the bytes. Note that asserting the
        // memo merely "did not grow" would be vacuous - bypassing it entirely also never grows it.
        var assemblyBytes = new byte[] { 1, 2, 3, 4 };
        var symbolBytes = new byte[] { 5, 6 };
        var binaries = new[] { new AssemblyBinary(assemblyBytes, symbolBytes) };

        var first = LibrarySetInvokerPoolKey.Create(
            BuildToolkitSharingArrays(binaries).AssemblyBinaries, "set", BatchProcessExceptionContinuation.Throw);

        IsArrayHashMemoized(assemblyBytes).Should().BeTrue(
            "the assembly bytes must be hashed once and remembered, so that a fresh toolkit over the "
            + "same array does not re-hash megabytes on every call");
        IsArrayHashMemoized(symbolBytes).Should().BeTrue("debug symbols are part of the identity too");

        // And a fresh toolkit over those same arrays still derives the same key from the memo.
        var again = LibrarySetInvokerPoolKey.Create(
            BuildToolkitSharingArrays(binaries).AssemblyBinaries, "set", BatchProcessExceptionContinuation.Throw);
        again.Should().Be(first);
    }

    #endregion Content-based reuse

    #region Concurrency

    [TestMethod]
    public void GetOrCreate_ConcurrentMissesOnOneKey_LoadsTheLibrarySetOnce()
    {
        // Arrange - all threads start together so they race on the same, still-empty pool.
        using var pool = new LibrarySetInvokerPool();
        const int threadCount = 8;
        var startGate = new Barrier(threadCount);
        var observed = new LibrarySetInvoker[threadCount];
        var failures = new ConcurrentBag<Exception>();
        var threads = new Thread[threadCount];

        // Counts loads that actually happened, rather than inferring it from the result. The pool's own
        // Misses counter cannot serve: it counts threads that found no entry, not assembly loads, so it
        // reads 1 even if the entry's factory then ran on every thread. CreateLibrarySetInvoker logs
        // once per invocation, before it creates the context, so this counts real loads.
        var loads = 0;
        var loadCounter = new CallbackLoggerFactory(message =>
        {
            if (message.Contains("Creating LibrarySetInvoker"))
                Interlocked.Increment(ref loads);
        });

        // Act
        for (var i = 0; i < threadCount; i++)
        {
            var index = i;
            threads[i] = new Thread(() =>
            {
                try
                {
                    var toolkit = BuildToolkit(_libraryBinaries, loggerFactory: loadCounter);
                    startGate.SignalAndWait();
                    observed[index] = pool.GetOrCreate(toolkit);
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

        // Assert - the library set was loaded exactly once, and everybody got the very same instance.
        //
        // Counting loads is the assertion that actually guards the leak. Reference identity alone does
        // not: a LazyThreadSafetyMode.PublicationOnly entry runs the factory on every racing thread and
        // publishes one winner, so identity, Distinct(), Misses and Entries would all still hold while
        // each discarded load left an assembly load context nothing will ever unload. Verified by
        // mutation - switching the pool to PublicationOnly leaves every other assertion here green.
        failures.Should().BeEmpty();
        loads.Should().Be(
            1,
            "concurrent misses on one key must collapse to a single load; every discarded load is an "
            + "assembly load context that nothing owns and nothing will ever unload");
        observed.Should().OnlyContain(invoker => ReferenceEquals(invoker, observed[0]));
        observed.Distinct(ReferenceEqualityComparer.Instance).Should().HaveCount(1);
        pool.Statistics.Misses.Should().Be(1);
        pool.Statistics.Entries.Should().Be(1);
    }

    [TestMethod]
    public void SharedInvoker_EvaluatedConcurrentlyFromManyThreads_MatchesSequentialBaseline()
    {
        // Arrange
        using var pool = new LibrarySetInvokerPool();
        var invoker = pool.GetOrCreate(BuildToolkit(_libraryBinaries));
        var baseline = Evaluate(invoker);

        const int threadCount = 8;
        const int iterationsPerThread = 50;
        var observed = new ConcurrentBag<string>();
        var failures = new ConcurrentBag<Exception>();
        var startGate = new Barrier(threadCount);
        var threads = new Thread[threadCount];

        // Act - one shared invoker, a fresh CqlContext per evaluation.
        for (var i = 0; i < threadCount; i++)
        {
            threads[i] = new Thread(() =>
            {
                try
                {
                    startGate.SignalAndWait();
                    for (var iteration = 0; iteration < iterationsPerThread; iteration++)
                        observed.Add(Evaluate(invoker));
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
        failures.Should().BeEmpty("a pooled invoker is meant to be shared between concurrent evaluations");
        observed.Should().HaveCount(threadCount * iterationsPerThread);
        observed.Should().AllBe(baseline);
    }

    #endregion Concurrency

    #region Eviction and unloading

    [TestMethod]
    public void Eviction_AfterAllReferencesReleased_UnloadsTheAssemblyLoadContext()
    {
        // This is the test that proves the leak this pool exists to fix is actually fixed: eviction
        // must let the assembly load context - and therefore its JIT-compiled code and its memory
        // mappings - be reclaimed.
        var (weakContext, pool) = EvictFirstEntryAndWeaklyReferenceIt();

        using (pool)
        {
            CollectUntil(() => !weakContext.TryGetTarget(out _))
                .Should().BeTrue("an evicted library set must become collectable");
        }
    }

    /// <summary>
    /// Fills a capacity-1 pool, then pushes the first entry out with a second one, returning only a
    /// weak reference to the evicted context so no strong reference survives in the caller's frame.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static (WeakReference<AssemblyLoadContext>, LibrarySetInvokerPool) EvictFirstEntryAndWeaklyReferenceIt()
    {
        var pool = new LibrarySetInvokerPool(new LibrarySetInvokerPoolOptions(Capacity: 1));

        var evicted = pool.GetOrCreate(BuildToolkit(_libraryBinaries));
        Evaluate(evicted).Should().Be("42|hello world");
        // Non-null: nothing has evicted this entry yet, so its context has not been released.
        var weakContext = new WeakReference<AssemblyLoadContext>(evicted.AssemblyLoadContext!, trackResurrection: true);

        // Evicts the first entry, because capacity is 1.
        pool.GetOrCreate(BuildToolkit(_otherLibraryBinaries));
        pool.Statistics.Entries.Should().Be(1);

        return (weakContext, pool);
    }

    [TestMethod]
    public void Eviction_WhileAConsumerStillHoldsTheInvoker_StillReleasesTheAssemblyLoadContext()
    {
        // This is what releasing the invoker graph in Unload() actually buys, and the only test that
        // detects its removal. Unload() alone merely *initiates* unloading: while a consumer holds the
        // invoker, its LibraryInvokers dictionary transitively roots the generated library singletons and
        // the delegates bound into the assemblies, so the context stays resident. Clearing the graph is
        // what breaks that chain. Note the invoker deliberately stays strongly referenced across the GC
        // loop below — that is the whole point.
        var (weakContext, heldInvoker, pool) = EvictWhileKeepingTheInvokerAlive();

        using (pool)
        {
            var collected = CollectUntil(() => !weakContext.TryGetTarget(out _));

            // Keep the invoker alive until after the assertion, so the test cannot pass for the trivial
            // reason that the invoker itself became unreachable.
            GC.KeepAlive(heldInvoker);
            collected.Should().BeTrue(
                "clearing the invoker graph must let the assembly load context go even while a consumer "
                + "still holds the evicted invoker");
        }
    }

    /// <summary>
    /// Fills a capacity-1 pool, evicts the first entry, and returns the evicted invoker together with a
    /// weak reference to its assembly load context — so the caller holds the invoker but not the context.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static (WeakReference<AssemblyLoadContext>, LibrarySetInvoker, LibrarySetInvokerPool) EvictWhileKeepingTheInvokerAlive()
    {
        var pool = new LibrarySetInvokerPool(new LibrarySetInvokerPoolOptions(Capacity: 1));

        var evicted = pool.GetOrCreate(BuildToolkit(_libraryBinaries), "held");
        Evaluate(evicted).Should().Be("42|hello world");
        // Non-null: nothing has evicted this entry yet, so its context has not been released.
        var weakContext = new WeakReference<AssemblyLoadContext>(evicted.AssemblyLoadContext!, trackResurrection: true);

        pool.GetOrCreate(BuildToolkit(_otherLibraryBinaries), "evictor");

        return (weakContext, evicted, pool);
    }

    [TestMethod]
    public void Eviction_WhileAConsumerStillHoldsTheInvoker_MakesThatInvokerUnusable()
    {
        // Eviction releases the invoker graph so the assemblies can be reclaimed even though this
        // consumer still references the invoker. That is the deliberate trade-off: preventing the leak
        // matters more than letting a consumer keep using a library set the pool has evicted - and the
        // failure is loud rather than an empty library set that would produce wrong answers.
        using var pool = new LibrarySetInvokerPool(new LibrarySetInvokerPoolOptions(Capacity: 1));

        var invoker = pool.GetOrCreate(BuildToolkit(_libraryBinaries));
        pool.GetOrCreate(BuildToolkit(_otherLibraryBinaries));

        var act = () => Evaluate(invoker);

        act.Should().Throw<ObjectDisposedException>();
    }

    [TestMethod]
    public void Eviction_EvictsTheLeastRecentlyUsedEntry_NotTheMostRecentlyUsed()
    {
        // Capacity 1 cannot detect a recency bug, because there is only ever one candidate: walking the
        // list from the wrong end, or dropping the recency touch on the hit path, would look identical.
        // Capacity 2 with an interleaved re-request distinguishes them. Three distinct library set names
        // over the same binaries give three distinct keys.
        using var pool = new LibrarySetInvokerPool(new LibrarySetInvokerPoolOptions(Capacity: 2));

        var a = pool.GetOrCreate(BuildToolkit(_libraryBinaries), "A");
        var b = pool.GetOrCreate(BuildToolkit(_libraryBinaries), "B");

        // Touching A makes B the least recently used.
        pool.GetOrCreate(BuildToolkit(_libraryBinaries), "A").Should().BeSameAs(a);

        // Adding a third key must therefore evict B, not A.
        pool.GetOrCreate(BuildToolkit(_libraryBinaries), "C");

        pool.GetOrCreate(BuildToolkit(_libraryBinaries), "A").Should().BeSameAs(
            a,
            "A was used more recently than B, so it must have survived eviction");

        var usingEvictedB = () => b.LibraryInvokers;
        usingEvictedB.Should().Throw<ObjectDisposedException>("B was the least recently used entry");
    }

    [TestMethod]
    public void Statistics_PendingUnloads_CountsEvictedContextsThatAreStillAlive()
    {
        using var pool = new LibrarySetInvokerPool(new LibrarySetInvokerPoolOptions(Capacity: 1));

        var evicted = pool.GetOrCreate(BuildToolkit(_libraryBinaries), "A");
        pool.Statistics.PendingUnloads.Should().Be(0, "nothing has been evicted yet");

        pool.GetOrCreate(BuildToolkit(_libraryBinaries), "B");

        // Holding the evicted invoker keeps its context alive, so it must still be reported as pending.
        // This is the signal a host is told to alarm on, so a value stuck at 0 would hide the leak it
        // exists to surface.
        pool.Statistics.PendingUnloads.Should().Be(1);
        GC.KeepAlive(evicted);
    }

    [TestMethod]
    public void UnloadEvicted_PrunesReclaimedContexts_WithoutNeedingAStatisticsRead()
    {
        // Reading Statistics prunes as a side effect, so a test that inspects it cannot tell whether
        // eviction pruned. Read the private list directly instead: on the default options
        // (MaxPendingUnloads = 0) an eviction-time prune is the only thing keeping this bounded, and
        // without it the list — and the long GC handle behind every entry — grows once per eviction for
        // the lifetime of the process.
        using var pool = new LibrarySetInvokerPool(new LibrarySetInvokerPoolOptions(Capacity: 1));

        for (var i = 0; i < 8; i++)
        {
            pool.GetOrCreate(BuildToolkit(_libraryBinaries), $"set-{i}");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        PendingUnloadsListCount(pool).Should().BeLessThan(
            8,
            "evicting must prune contexts that have already been reclaimed, without relying on a "
            + "consumer reading the diagnostic Statistics property");
    }

    /// <summary>
    /// Reads the count of <c>_pendingUnloads</c> without going through <see cref="LibrarySetInvokerPool.Statistics"/>,
    /// which would prune as a side effect and so mask what is being tested.
    /// </summary>
    private static int PendingUnloadsListCount(LibrarySetInvokerPool pool)
    {
        var field = typeof(LibrarySetInvokerPool)
            .GetField("_pendingUnloads", BindingFlags.Instance | BindingFlags.NonPublic)!;
        return ((ICollection)field.GetValue(pool)!).Count;
    }

    [TestMethod]
    public void Dispose_UnloadsEveryHeldLibrarySet()
    {
        var pool = new LibrarySetInvokerPool();
        var invoker = pool.GetOrCreate(BuildToolkit(_libraryBinaries));

        pool.Dispose();

        // Unloaded means the invoker graph is released, which is what allows the context to go.
        var act = () => invoker.LibraryInvokers;
        act.Should().Throw<ObjectDisposedException>();
        pool.Statistics.Entries.Should().Be(0);
    }

    [TestMethod]
    public void Dispose_CalledTwice_DoesNotThrow()
    {
        var pool = new LibrarySetInvokerPool();
        pool.GetOrCreate(BuildToolkit(_libraryBinaries));

        pool.Dispose();
        var second = () => pool.Dispose();

        second.Should().NotThrow();
    }

    [TestMethod]
    public void CreateLibrarySetInvoker_WhenLoadingFails_UnloadsTheAssemblyLoadContext()
    {
        // A failed load leaves no LibrarySetInvoker owning the context, and cooperative unloading does
        // not begin until Unload() is called - so without unwinding, the context stays resident for the
        // life of the process. Pooling makes retries after a failure more likely.
        const string librarySetName = "corrupt-binary-unwind-test";
        var toolkit = new InvocationToolkit()
            .AddAssemblyBinaries([new AssemblyBinary([0x00, 0x01, 0x02, 0x03])]);

        var act = () => toolkit.CreateLibrarySetInvoker(librarySetName);

        act.Should().Throw<Exception>("a corrupt assembly cannot be loaded");
        // Initiating an unload removes a context from AssemblyLoadContext.All, so one that is still
        // listed here is one whose unload was never started.
        AssemblyLoadContext.All.Should().NotContain(
            context => context.Name == librarySetName,
            "a failed load must initiate unloading of the context it created");
    }

    [TestMethod]
    public void GetOrCreate_AfterDispose_Throws()
    {
        var pool = new LibrarySetInvokerPool();
        pool.Dispose();

        var act = () => pool.GetOrCreate(BuildToolkit(_libraryBinaries));

        act.Should().Throw<ObjectDisposedException>();
    }

    [TestMethod]
    public void Dispose_RacingAnInFlightLoad_UnloadsTheOrphanedContextAndThrows()
    {
        // Loading happens outside the pool lock, and Dispose skips entries whose Lazy has not completed
        // yet - so a dispose landing mid-load leaves the finished invoker known to nobody: the pool has
        // dropped the entry, and the invoker's own Dispose() is inert because it is pool-owned. Nothing
        // would ever unload that context, which is a permanent leak of exactly the class this pool
        // exists to prevent, and worse than not pooling, since the caller cannot unload it either.
        //
        // Deterministic rather than timing-based: the toolkit's logger fires inside the load, after the
        // entry is registered and the lock released, so the loading thread parks exactly in the window.
        const string librarySetName = "dispose-race";
        var pool = new LibrarySetInvokerPool();

        using var loadReachedTheHook = new ManualResetEventSlim();
        using var disposeCompleted = new ManualResetEventSlim();

        var toolkit = BuildToolkit(
            _libraryBinaries,
            loggerFactory: new CallbackLoggerFactory(message =>
            {
                if (!message.Contains("Creating LibrarySetInvoker"))
                    return;

                loadReachedTheHook.Set();
                disposeCompleted.Wait(HookTimeout);
            }));

        Exception? thrown = null;
        var loader = new Thread(() =>
        {
            try
            {
                pool.GetOrCreate(toolkit, librarySetName);
            }
            catch (Exception exception)
            {
                thrown = exception;
            }
        });
        loader.Start();

        loadReachedTheHook.Wait(HookTimeout).Should().BeTrue("the load must reach the hook inside the pool");
        pool.Dispose();
        disposeCompleted.Set();
        loader.Join(HookTimeout).Should().BeTrue("the loading thread must finish");

        thrown.Should().BeOfType<ObjectDisposedException>(
            "a load completing after the pool was disposed must not hand out an invoker the pool no "
            + "longer tracks");
        // Initiating an unload removes a context from AssemblyLoadContext.All, so one still listed here
        // is precisely one whose unload never started. Deterministic, and needs no GC.
        AssemblyLoadContext.All.Should().NotContain(
            context => context.Name == librarySetName,
            "the orphaned context must be unloaded rather than leaked for the life of the process");
    }

    #endregion Eviction and unloading

    #region Pooled-instance ownership

    [TestMethod]
    public void PooledInvoker_Dispose_DoesNotUnloadTheSharedLibrarySet()
    {
        // A stray `using` on a shared instance must not pull the assemblies out from under everyone
        // else, so Dispose() is deliberately inert while the pool owns the instance.
        using var pool = new LibrarySetInvokerPool();
        var invoker = pool.GetOrCreate(BuildToolkit(_libraryBinaries));

        invoker.Dispose();

        invoker.LibraryInvokers.Should().NotBeEmpty();
        Evaluate(invoker).Should().Be("42|hello world");
        pool.GetOrCreate(BuildToolkit(_libraryBinaries)).Should().BeSameAs(invoker);
    }

    [TestMethod]
    public void PooledInvoker_SetBatchProcessExceptionContinuation_IsIgnored()
    {
        // The continuation is the only mutable state in the shared graph and is part of the pool key,
        // so letting one consumer change it would both reconfigure the others and leave the entry
        // filed under a key that no longer describes it.
        using var pool = new LibrarySetInvokerPool();
        var invoker = pool.GetOrCreate(BuildToolkit(_libraryBinaries, BatchProcessExceptionContinuation.Throw));

        invoker.SetBatchProcessExceptionContinuation(BatchProcessExceptionContinuation.Continue);

        invoker.BatchProcessExceptionContinuation.Should().Be(BatchProcessExceptionContinuation.Throw);
    }

    [TestMethod]
    public void UnpooledInvoker_SetBatchProcessExceptionContinuation_StillApplies()
    {
        using var invoker = BuildToolkit(_libraryBinaries).CreateLibrarySetInvoker();

        invoker.SetBatchProcessExceptionContinuation(BatchProcessExceptionContinuation.Continue);

        invoker.BatchProcessExceptionContinuation.Should().Be(BatchProcessExceptionContinuation.Continue);
    }

    [TestMethod]
    public void UnpooledInvoker_DisposedTwice_DoesNotThrow()
    {
        var invoker = BuildToolkit(_libraryBinaries).CreateLibrarySetInvoker();

        invoker.Dispose();
        var second = () => invoker.Dispose();

        second.Should().NotThrow();
    }

    [TestMethod]
    public void UnpooledInvoker_Dispose_ReleasesTheInvokerGraph()
    {
        var invoker = BuildToolkit(_libraryBinaries).CreateLibrarySetInvoker();
        invoker.LibraryInvokers.Should().NotBeEmpty();

        invoker.Dispose();

        var act = () => invoker.LibraryInvokers;
        act.Should().Throw<ObjectDisposedException>();
    }

    #endregion Pooled-instance ownership

    #region Options

    [TestMethod]
    [DataRow(0)]
    [DataRow(-1)]
    [DataRow(int.MinValue)]
    public void Constructor_CapacityBelowOne_Throws(int capacity)
    {
        var act = () => new LibrarySetInvokerPool(new LibrarySetInvokerPoolOptions(Capacity: capacity));

        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [TestMethod]
    public void Options_Default_HasAUsableCapacity() =>
        LibrarySetInvokerPoolOptions.Default.Capacity.Should().BeGreaterThan(0);

    #endregion Options

    #region Helpers

    /// <summary>
    /// Compiles CQL down to assembly binaries, so tests can build several independent
    /// <see cref="InvocationToolkit"/> instances over equal-but-distinct byte arrays.
    /// </summary>
    private static IReadOnlyList<AssemblyBinary> Compile(string cql)
    {
        var elmToolkit =
            new CqlToolkit()
                .AddCqlLibraries((CqlLibraryString)cql)
                .TranslateToElm()
                .CreateElmToolkit(ElmToolkitConfig)
                .CompileToAssemblies();

        return elmToolkit
               .GetElmToAssemblyResults()
               .Select(result => new AssemblyBinary(result.assemblyBinary, result.debugSymbolsBinary))
               .ToList();
    }

    /// <summary>
    /// Builds a toolkit over fresh copies of the binaries, so that nothing but the <em>content</em>
    /// of the assemblies can make two toolkits look alike to the pool.
    /// </summary>
    private static InvocationToolkit BuildToolkit(
        IReadOnlyList<AssemblyBinary> binaries,
        BatchProcessExceptionContinuation continuation = BatchProcessExceptionContinuation.Throw,
        ILoggerFactory? loggerFactory = null) =>
        new InvocationToolkit(loggerFactory, continuation)
            .AddAssemblyBinaries(
                binaries.Select(binary => new AssemblyBinary(
                    (byte[])binary.AssemblyBytes!.Clone(),
                    (byte[]?)binary.DebugSymbolsBytes?.Clone())));

    /// <summary>
    /// Builds a toolkit over the <em>same</em> byte arrays rather than copies, which is what a consumer
    /// reusing a per-run artifact cache does. <see cref="BuildToolkit"/> clones deliberately, to prove
    /// content-based keying; this one shares, to exercise the per-array hash memo.
    /// </summary>
    private static InvocationToolkit BuildToolkitSharingArrays(IReadOnlyList<AssemblyBinary> binaries) =>
        new InvocationToolkit().AddAssemblyBinaries(binaries);

    /// <summary>
    /// Whether <c>LibrarySetInvokerPoolKey</c>'s private per-array hash memo holds this exact array.
    /// Reflection because memoizing is an implementation detail whose only effect is not doing the work
    /// twice; membership of the specific array is the one direct observation of it.
    /// </summary>
    private static bool IsArrayHashMemoized(byte[] array)
    {
        var field = typeof(LibrarySetInvokerPoolKey)
            .GetField("ArrayHashes", BindingFlags.Static | BindingFlags.NonPublic)!;
        return ((ConditionalWeakTable<byte[], string>)field.GetValue(null)!).TryGetValue(array, out _);
    }

    /// <summary>
    /// An <see cref="ILoggerFactory"/> that runs a callback for every message logged, so a test can
    /// suspend a thread at a known point inside the SDK. <c>CreateLibrarySetInvoker</c> logs before it
    /// creates the assembly load context, which makes it a usable hook for the window between a pool
    /// entry being registered and its load completing.
    /// </summary>
    private sealed class CallbackLoggerFactory(Action<string> onMessage) : ILoggerFactory
    {
        public ILogger CreateLogger(string categoryName) => new CallbackLogger(onMessage);

        public void AddProvider(ILoggerProvider provider) { }

        public void Dispose() { }

        private sealed class CallbackLogger(Action<string> onMessage) : ILogger
        {
            public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

            public bool IsEnabled(LogLevel logLevel) => true;

            public void Log<TState>(
                LogLevel logLevel,
                EventId eventId,
                TState state,
                Exception? exception,
                Func<TState, Exception?, string> formatter) =>
                onMessage(formatter(state, exception));
        }
    }

    private static string Evaluate(LibrarySetInvoker invoker)
    {
        var libraryIdentifier = CqlVersionedLibraryIdentifier.Parse("PoolTestLib-1.0.0");
        var context = FhirCqlContext.ForBundle();

        return string.Join(
            '|',
            invoker.InvokeLibraryDefinition(context, libraryIdentifier, "Answer"),
            invoker.InvokeLibraryDefinition(context, libraryIdentifier, "Greeting"));
    }

    /// <summary>
    /// Runs full collections until <paramref name="condition"/> holds, since unloading an assembly
    /// load context completes only after the collector and the finalizer thread have both run.
    /// </summary>
    private static bool CollectUntil(Func<bool> condition, int maxRounds = 20)
    {
        for (var round = 0; round < maxRounds; round++)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            if (condition())
                return true;
        }

        return false;
    }

    #endregion Helpers
}
