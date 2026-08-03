/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Runtime.CompilerServices;
using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Invocation.Toolkit.Internal;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;
using static Hl7.Cql.Invocation.Toolkit.StringBuilderExtensions;

namespace Hl7.Cql.Invocation.Toolkit;


/// <summary>
/// Represents an invoker for a set of CQL libraries.
/// </summary>
public sealed class LibrarySetInvoker : IDisposable, IToolkit<LibrarySetInvoker>
{
    /// <summary>
    /// The assembly load context holding this library set's assemblies, released when it is unloaded.
    /// </summary>
    /// <remarks>
    /// Not <see langword="readonly"/>, and set to <see langword="null"/> by <see cref="Unload"/>, because
    /// this is the last strong reference to the load context that this object holds. Keeping it would mean
    /// a retained invoker pinned the context — and the JIT-compiled code and memory mappings behind it —
    /// no matter that the invoker graph had been released.
    /// </remarks>
    private AssemblyLoadContext? _alc;

    /// <summary>
    /// When <see langword="true"/>, a pool owns this instance's lifetime and <see cref="Dispose"/> is
    /// inert. See the remarks on <see cref="Dispose"/>.
    /// </summary>
    private readonly bool _isPoolOwned;

    /// <summary>
    /// 0 until the assembly load context has been unloaded, then 1. Its only job is to let exactly one
    /// caller through <see cref="Unload"/>, so that the context is never unloaded twice.
    /// </summary>
    /// <remarks>
    /// Deliberately <em>not</em> what <see cref="LibraryInvokers"/> tests to decide whether the library
    /// set is still usable - see the remarks on <see cref="_libraryInvokers"/>.
    /// </remarks>
    private int _unloadInitiated;

    /// <summary>
    /// The invoker graph, or <see langword="null"/> once the assembly load context has been unloaded, so
    /// that the generated assemblies actually become collectable. See the remarks on <see cref="Dispose"/>.
    /// </summary>
    /// <remarks>
    /// <see langword="null"/> <em>is</em> the unloaded sentinel, rather than an empty dictionary guarded
    /// by <see cref="_unloadInitiated"/>. That makes <see cref="LibraryInvokers"/> a single atomic
    /// reference read: a racing reader gets either the live graph or the exception. Testing a separate
    /// flag and then reading this field would leave a window in which the flag was still stale and the
    /// field already cleared, and the getter would hand back a library set containing no libraries -
    /// precisely the silently-wrong-results outcome it exists to prevent.
    /// </remarks>
    private IReadOnlyDictionary<CqlVersionedLibraryIdentifier, LibraryInvoker>? _libraryInvokers;

    /// <summary>
    /// Gets the minimum generator tool version that this invoker supports for executing generated code.
    /// </summary>
    public static readonly Version MinSupportedGeneratorToolVersion = LibraryInstanceInvoker_5_0.MinSupportedGeneratorToolVersion;

    /// <summary>
    /// Gets the first generator tool version that this invoker does not support for executing generated code.
    /// </summary>
    public static readonly Version FirstUnsupportedGeneratorToolVersion = LibraryInstanceInvoker_5_0.FirstUnsupportedGeneratorToolVersion;

    /// <summary>
    /// Initializes a new instance of the <see cref="LibrarySetInvoker"/> class.
    /// </summary>
    internal LibrarySetInvoker(
        AssemblyLoadContext alc,
        ILoggerFactory loggerFactory,
        BatchProcessExceptionContinuation batchProcessExceptionContinuation,
        string librarySetName,
        bool isPoolOwned = false)
    {
        _alc = alc;
        _isPoolOwned = isPoolOwned;
        LoggerFactory = loggerFactory;
        BatchProcessExceptionContinuation = batchProcessExceptionContinuation;
        LibrarySetName = librarySetName;
        // Reads the parameter rather than the field, so the field's nullability stays confined to Unload.
        _libraryInvokers =
            alc.Assemblies
                .SelectMany(a => a.GetTypes())
                .SelectWhereNotNull(libraryType =>
                {
                    _ = LibraryInvoker.TryCreateFromType(this, libraryType, out var libraryInvoker);
                    return libraryInvoker;
                })
                .ToImmutableDictionary(o => o.LibraryIdentifier);
    }

    /// <summary>
    /// Releases all resources used by the <see cref="LibrarySetInvoker"/>, unloading its assemblies
    /// from the application domain.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Calling this more than once is safe and has no additional effect.
    /// </para>
    /// <para>
    /// When this instance is owned by a <see cref="LibrarySetInvokerPool"/> this method does nothing:
    /// the instance is shared, so unloading it here would pull the assemblies out from under every
    /// other consumer of the same pool entry. The pool unloads it when it evicts the entry or is
    /// itself disposed.
    /// </para>
    /// </remarks>
    public void Dispose()
    {
        if (_isPoolOwned)
        {
            this.CreateLogger<LibrarySetInvoker>().LogDebug(
                "Ignoring Dispose() of pooled LibrarySetInvoker {name}; the pool owns its lifetime.",
                LibrarySetName);
            return;
        }

        Unload();
    }

    /// <summary>
    /// The assembly load context holding this library set's assemblies, or <see langword="null"/> once it
    /// has been unloaded. Only used by tests that need to observe the context before it is released;
    /// <see cref="LibrarySetInvokerPool"/> takes the context from <see cref="Unload"/>'s return value.
    /// </summary>
    internal AssemblyLoadContext? AssemblyLoadContext => _alc;

    /// <summary>
    /// Unloads the assembly load context, releasing both the invoker graph and this object's reference to
    /// the context itself.
    /// </summary>
    /// <returns>The context that was unloaded, or <see langword="null"/> if it had already been unloaded.</returns>
    /// <remarks>
    /// <para>
    /// Releasing both references is what makes unloading possible.
    /// <see cref="AssemblyLoadContext.Unload"/> only <em>initiates</em> unloading; the context is reclaimed
    /// once nothing references it any more. Every value in the invoker dictionary holds the generated
    /// library singleton and delegates bound into the generated assembly, and <c>_alc</c> references the
    /// context directly, so leaving either in place keeps the context — and its JIT-compiled code, which
    /// on Linux costs two memory mappings per region — resident for as long as this object is reachable.
    /// </para>
    /// <para>
    /// Note this does <em>not</em> make every retained object harmless. A caller holding a
    /// <see cref="LibraryInvoker"/> or <see cref="DefinitionInvoker"/> still roots the context through the
    /// generated library instance and the bound delegate it holds directly, which is why those must not be
    /// retained beyond the library set.
    /// </para>
    /// <para>
    /// Marked <see cref="MethodImplOptions.NoInlining"/> so that stack slots the JIT may introduce for
    /// the graph or the context do not keep them alive for the enclosing frame's lifetime.
    /// </para>
    /// </remarks>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal AssemblyLoadContext? Unload()
    {
        // Unloading twice was an access violation before .NET 8.0.0 (dotnet/runtime#91283), and is
        // pointless afterwards, so only the first caller gets through.
        if (Interlocked.Exchange(ref _unloadInitiated, 1) != 0)
            return null;

        // Clearing the graph is what releases it; null is the sentinel LibraryInvokers reads. Written
        // with a store fence so a concurrent reader sees it promptly rather than a cached field value.
        Volatile.Write(ref _libraryInvokers, null);

        var alc = _alc!;
        _alc = null;
        alc.Unload();
        return alc;
    }

    /// <summary>
    /// Gets the dictionary of library invokers.
    /// </summary>
    /// <exception cref="ObjectDisposedException">The library set has been unloaded, either by
    /// <see cref="Dispose"/> or because a <see cref="LibrarySetInvokerPool"/> evicted it.</exception>
    /// <remarks>
    /// Throwing rather than returning an empty dictionary is deliberate: the invoker graph is released
    /// when the library set unloads, so that its assemblies can be reclaimed even while something still
    /// references this object. Silently reporting that the library set contains no libraries would turn
    /// that into wrong answers instead of an obvious error.
    /// </remarks>
    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, LibraryInvoker> LibraryInvokers
    {
        [DebuggerStepThrough]
        // One atomic read, deliberately: the field is itself the unloaded sentinel, so a reader racing
        // Unload gets either the live graph or the exception, never an empty library set. See the
        // remarks on _libraryInvokers for why this is not a flag test followed by a field read.
        get => Volatile.Read(ref _libraryInvokers)
               ?? throw new ObjectDisposedException(nameof(LibrarySetInvoker));
    }

    /// <inheritdoc />
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ILoggerFactory LoggerFactory { get; }

    /// <inheritdoc />
    public BatchProcessExceptionContinuation BatchProcessExceptionContinuation { get; private set; }

    /// <summary>
    /// Represents the name of a library set or empty.
    /// </summary>
    public string LibrarySetName { get; }

    /// <inheritdoc />
    /// <remarks>
    /// Has no effect when this instance is owned by a <see cref="LibrarySetInvokerPool"/>. A pooled
    /// instance is shared, and this is the only mutable state in its object graph, so honouring the
    /// change here would silently reconfigure every other consumer of the same pool entry. The
    /// continuation is part of the pool's cache key instead, so ask the pool for the policy you want
    /// and you will get an instance that already has it.
    /// </remarks>
    public LibrarySetInvoker SetBatchProcessExceptionContinuation(BatchProcessExceptionContinuation continuation)
    {
        if (_isPoolOwned)
        {
            this.CreateLogger<LibrarySetInvoker>().LogWarning(
                "Ignoring SetBatchProcessExceptionContinuation({continuation}) on pooled LibrarySetInvoker {name}: "
                + "the instance is shared. Request the desired continuation from the pool instead.",
                continuation,
                LibrarySetName);
            return this;
        }

        BatchProcessExceptionContinuation = continuation;
        return this;
    }

    /// <inheritdoc />
    public override string? ToString() =>
        string.IsNullOrEmpty(LibrarySetName)
            ? base.ToString()
            : StartBrace().AppendMember(LibrarySetName).EndBrace();
}
