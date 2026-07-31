/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Runtime.CompilerServices;
using Hl7.Cql.Invocation.Toolkit.Internal;

#nullable enable

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// Reuses <see cref="LibrarySetInvoker"/> instances across repeated evaluations of the same library
/// set, so that its assemblies are loaded and JIT-compiled once instead of once per evaluation.
/// </summary>
/// <remarks>
/// <para>
/// <see cref="InvocationToolkit.CreateLibrarySetInvoker(string)"/> creates a fresh collectible
/// <see cref="System.Runtime.Loader.AssemblyLoadContext"/> and reloads every assembly on every call.
/// A host that evaluates the same library set repeatedly - say a measure evaluated once per subject -
/// therefore reloads and re-JITs the whole assembly closure each time. Collectible contexts never use
/// ReadyToRun, so every method is JIT-compiled per context, and unloading them is asynchronous, so
/// contexts accumulate faster than they are reclaimed. On Linux each JIT-compiled region costs two
/// memory mappings, and exhausting the kernel's limit aborts the process.
/// </para>
/// <para>
/// Pooling is opt-in: create one pool, keep it for as long as the process needs the library sets, and
/// call <see cref="GetOrCreate"/> instead of <see cref="InvocationToolkit.CreateLibrarySetInvoker(string)"/>.
/// Entries are keyed on the <em>content</em> of the assembly binaries, so rebuilding an equivalent
/// <see cref="InvocationToolkit"/> from freshly read bytes still hits the pool.
/// </para>
/// <para>
/// <b>The pool owns the invokers it returns.</b> Do not dispose them - a returned invoker is shared
/// with every other caller for the same library set. Calling
/// <see cref="LibrarySetInvoker.Dispose"/> on a pooled invoker is a deliberate no-op for that reason.
/// Do not retain a <see cref="LibraryInvoker"/> or <see cref="DefinitionInvoker"/> past the point where
/// you are done with the library set either: both reach their library set through a back-reference, so
/// holding one keeps the whole assembly load context alive even after the pool has evicted it.
/// </para>
/// <para>
/// <b>Thread safety.</b> All members are safe to call concurrently. A returned
/// <see cref="LibrarySetInvoker"/> is safe to share between concurrently evaluating threads, provided
/// each evaluation uses its own <see cref="Hl7.Cql.Runtime.CqlContext"/> - see the thread-safety
/// contract documented on <see cref="Hl7.Cql.Runtime.CqlContext"/>. Note that a long-lived context
/// with caching enabled can retain results that reference the library set's assemblies, because some
/// operators evaluate lazily.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// using var pool = new LibrarySetInvokerPool(new LibrarySetInvokerPoolOptions(Capacity: 4));
///
/// // Per request, over and over: loads once, reused thereafter.
/// var invoker = pool.GetOrCreate(invocationToolkit, "HEDIS");
/// var result = invoker.InvokeLibraryDefinition(FhirCqlContext.ForBundle(bundle), libraryId, "Numerator");
/// </code>
/// </example>
public sealed class LibrarySetInvokerPool : IDisposable
{
    private readonly LibrarySetInvokerPoolOptions _options;
    private readonly ILogger<LibrarySetInvokerPool> _logger;

    /// <summary>
    /// Guards <see cref="_entries"/>, <see cref="_leastRecentlyUsed"/>, <see cref="_pendingUnloads"/>
    /// and <see cref="_disposed"/>. Loading assemblies happens outside this lock.
    /// </summary>
    private readonly object _gate = new();

    private readonly Dictionary<LibrarySetInvokerPoolKey, PoolEntry> _entries = new();

    /// <summary>
    /// Keys ordered most-recently-used first, so the last node is the eviction candidate.
    /// </summary>
    private readonly LinkedList<LibrarySetInvokerPoolKey> _leastRecentlyUsed = new();

    /// <summary>
    /// Weak references to the assembly load contexts of evicted entries, used to report how many have
    /// not been reclaimed yet.
    /// </summary>
    private readonly List<WeakReference<AssemblyLoadContext>> _pendingUnloads = new();

    private long _hits;
    private long _misses;
    private bool _disposed;

    /// <summary>
    /// Initializes a new pool.
    /// </summary>
    /// <param name="options">Pool settings, or <see langword="null"/> for
    /// <see cref="LibrarySetInvokerPoolOptions.Default"/>.</param>
    /// <param name="loggerFactory">Optional logger factory for logging purposes.</param>
    /// <exception cref="ArgumentOutOfRangeException"><see cref="LibrarySetInvokerPoolOptions.Capacity"/>
    /// is less than 1.</exception>
    public LibrarySetInvokerPool(
        LibrarySetInvokerPoolOptions? options = null,
        ILoggerFactory? loggerFactory = null)
    {
        options ??= LibrarySetInvokerPoolOptions.Default;

        if (options.Capacity < 1)
            throw new ArgumentOutOfRangeException(
                nameof(options),
                options.Capacity,
                "The pool capacity must be at least 1.");

        _options = options;
        _logger = (loggerFactory ?? NullLoggerFactory.Instance).CreateLogger<LibrarySetInvokerPool>();
    }

    /// <summary>
    /// Returns a pooled <see cref="LibrarySetInvoker"/> for <paramref name="toolkit"/>'s current
    /// assembly binaries, loading them only if no equivalent library set is already held.
    /// </summary>
    /// <param name="toolkit">The toolkit whose assembly binaries identify the library set. The pool
    /// does not take ownership of it, and does not observe later changes to it - each call re-reads its
    /// current binaries.</param>
    /// <param name="librarySetName">The name of the library set, used for the assembly load context's
    /// name and as part of the pool key.</param>
    /// <returns>An invoker owned by this pool. Do not dispose it.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="toolkit"/> or
    /// <paramref name="librarySetName"/> is <see langword="null"/>.</exception>
    /// <exception cref="ObjectDisposedException">The pool has been disposed.</exception>
    public LibrarySetInvoker GetOrCreate(InvocationToolkit toolkit, string librarySetName = "")
    {
        ArgumentNullException.ThrowIfNull(toolkit);
        ArgumentNullException.ThrowIfNull(librarySetName);

        var key = LibrarySetInvokerPoolKey.Create(
            toolkit.AssemblyBinaries,
            librarySetName,
            toolkit.BatchProcessExceptionContinuation);

        Lazy<LibrarySetInvoker> lazyInvoker;
        List<LibrarySetInvoker> evicted;

        lock (_gate)
        {
            ObjectDisposedException.ThrowIf(_disposed, this);

            if (_entries.TryGetValue(key, out var existing))
            {
                _hits++;
                _leastRecentlyUsed.Remove(existing.LeastRecentlyUsedNode);
                _leastRecentlyUsed.AddFirst(existing.LeastRecentlyUsedNode);
                lazyInvoker = existing.Invoker;
                evicted = [];
            }
            else
            {
                _misses++;
                // ExecutionAndPublication so that concurrent misses on one key load the assemblies
                // once. Tolerating a duplicate load instead would leak the losing context: nothing
                // would ever unload it.
                lazyInvoker = new Lazy<LibrarySetInvoker>(
                    () => toolkit.CreateLibrarySetInvoker(librarySetName, isPoolOwned: true),
                    LazyThreadSafetyMode.ExecutionAndPublication);
                _entries[key] = new PoolEntry(lazyInvoker, _leastRecentlyUsed.AddFirst(key));
                evicted = CollectEvictions();
            }
        }

        // Outside the lock: loading assemblies is expensive, and blocking unrelated keys behind it
        // would defeat the point.
        LibrarySetInvoker invoker;
        try
        {
            invoker = lazyInvoker.Value;
        }
        catch
        {
            RemoveFailedEntry(key, lazyInvoker);
            UnloadEvicted(evicted);
            throw;
        }

        UnloadEvicted(evicted);
        return invoker;
    }

    /// <summary>
    /// Gets a snapshot of this pool's activity.
    /// </summary>
    public LibrarySetInvokerPoolStatistics Statistics
    {
        get
        {
            lock (_gate)
                return new LibrarySetInvokerPoolStatistics(
                    _hits,
                    _misses,
                    _entries.Count,
                    CountPendingUnloads());
        }
    }

    /// <summary>
    /// Unloads every library set held by this pool.
    /// </summary>
    /// <remarks>
    /// Invokers handed out earlier become unusable, and any assembly load context still referenced by
    /// a consumer is reclaimed only once that reference is gone.
    /// </remarks>
    public void Dispose()
    {
        List<LibrarySetInvoker> remaining;

        lock (_gate)
        {
            if (_disposed)
                return;

            _disposed = true;
            remaining = CollectAll();
        }

        UnloadEvicted(remaining);
    }

    /// <summary>
    /// Takes the least-recently-used entries until the pool is back within
    /// <see cref="LibrarySetInvokerPoolOptions.Capacity"/>, skipping any whose assemblies are still
    /// being loaded. Callers must hold <see cref="_gate"/>.
    /// </summary>
    /// <remarks>
    /// Skipping entries that are still loading is what keeps a concurrent miss from having its
    /// assembly load context evicted before the loading thread ever receives it - which would leave a
    /// context nothing owns, and so nothing ever unloads. The cost is that the pool can briefly hold
    /// more than <see cref="LibrarySetInvokerPoolOptions.Capacity"/> entries.
    /// </remarks>
    private List<LibrarySetInvoker> CollectEvictions()
    {
        var evicted = new List<LibrarySetInvoker>();
        var node = _leastRecentlyUsed.Last;

        while (_entries.Count > _options.Capacity && node is not null)
        {
            var next = node.Previous;

            if (_entries.TryGetValue(node.Value, out var entry) && entry.Invoker.IsValueCreated)
            {
                _entries.Remove(node.Value);
                _leastRecentlyUsed.Remove(node);
                evicted.Add(entry.Invoker.Value);
            }

            node = next;
        }

        return evicted;
    }

    /// <summary>
    /// Takes every entry whose assemblies have been loaded. Callers must hold <see cref="_gate"/>.
    /// </summary>
    private List<LibrarySetInvoker> CollectAll()
    {
        var all = _entries.Values
            .Where(entry => entry.Invoker.IsValueCreated)
            .Select(entry => entry.Invoker.Value)
            .ToList();

        _entries.Clear();
        _leastRecentlyUsed.Clear();
        return all;
    }

    /// <summary>
    /// Drops an entry whose assemblies failed to load, so that a later call retries instead of
    /// replaying the failure from a cached <see cref="Lazy{T}"/>.
    /// </summary>
    private void RemoveFailedEntry(LibrarySetInvokerPoolKey key, Lazy<LibrarySetInvoker> lazyInvoker)
    {
        lock (_gate)
        {
            // Only remove our own entry: another thread may already have replaced it.
            if (_entries.TryGetValue(key, out var entry) && ReferenceEquals(entry.Invoker, lazyInvoker))
            {
                _entries.Remove(key);
                _leastRecentlyUsed.Remove(entry.LeastRecentlyUsedNode);
            }
        }
    }

    /// <summary>
    /// Unloads evicted library sets and records their assembly load contexts so that
    /// <see cref="Statistics"/> can report ones that have not been reclaimed.
    /// </summary>
    /// <remarks>
    /// Not inlined, so that stack slots the JIT may introduce for the invokers do not keep them - and
    /// therefore their assembly load contexts - alive for the caller's frame.
    /// </remarks>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnloadEvicted(List<LibrarySetInvoker> evicted)
    {
        if (evicted.Count == 0)
            return;

        foreach (var invoker in evicted)
        {
            lock (_gate)
                _pendingUnloads.Add(new WeakReference<AssemblyLoadContext>(invoker.AssemblyLoadContext, trackResurrection: true));

            _logger.LogDebug("Unloading evicted library set {name}.", invoker.LibrarySetName);
            invoker.Unload();
        }

        evicted.Clear();
        WarnIfTooManyPendingUnloads();
    }

    private void WarnIfTooManyPendingUnloads()
    {
        if (_options.MaxPendingUnloads <= 0)
            return;

        int pending;
        lock (_gate)
            pending = CountPendingUnloads();

        if (pending > _options.MaxPendingUnloads)
            _logger.LogWarning(
                "{pending} evicted library sets have not been reclaimed, above the configured maximum of {max}. "
                + "Something is most likely holding on to an evicted library set - a retained LibraryInvoker or "
                + "DefinitionInvoker reaches its whole library set through a back-reference.",
                pending,
                _options.MaxPendingUnloads);
    }

    /// <summary>
    /// Counts evicted assembly load contexts that are still alive, dropping the reclaimed ones.
    /// Callers must hold <see cref="_gate"/>.
    /// </summary>
    private int CountPendingUnloads()
    {
        _pendingUnloads.RemoveAll(weak => !weak.TryGetTarget(out _));
        return _pendingUnloads.Count;
    }

    /// <inheritdoc />
    public override string ToString() =>
        $"{{{nameof(LibrarySetInvokerPool)}: {Statistics}}}";

    private sealed record PoolEntry(
        Lazy<LibrarySetInvoker> Invoker,
        LinkedListNode<LibrarySetInvokerPoolKey> LeastRecentlyUsedNode);
}
