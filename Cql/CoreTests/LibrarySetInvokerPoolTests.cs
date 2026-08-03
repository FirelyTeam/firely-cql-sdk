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
using Hl7.Cql.Runtime;

#nullable enable

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

        // Act
        for (var i = 0; i < threadCount; i++)
        {
            var index = i;
            threads[i] = new Thread(() =>
            {
                try
                {
                    var toolkit = BuildToolkit(_libraryBinaries);
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

        // Assert - one load, and everybody got the very same instance. Reference identity is the
        // point: a tolerate-and-discard race would have created a second assembly load context that
        // nothing would ever unload, and two such invokers could still look structurally equivalent.
        failures.Should().BeEmpty();
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
        BatchProcessExceptionContinuation continuation = BatchProcessExceptionContinuation.Throw) =>
        new InvocationToolkit(batchProcessExceptionContinuation: continuation)
            .AddAssemblyBinaries(
                binaries.Select(binary => new AssemblyBinary(
                    (byte[])binary.AssemblyBytes!.Clone(),
                    (byte[]?)binary.DebugSymbolsBytes?.Clone())));

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
