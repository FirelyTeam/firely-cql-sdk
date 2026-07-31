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
    private readonly AssemblyLoadContext _alc;

    /// <summary>
    /// When <see langword="true"/>, a pool owns this instance's lifetime and <see cref="Dispose"/> is
    /// inert. See the remarks on <see cref="Dispose"/>.
    /// </summary>
    private readonly bool _isPoolOwned;

    /// <summary>
    /// 0 until the assembly load context has been unloaded, then 1. Guards against unloading twice.
    /// </summary>
    private int _unloadInitiated;

    /// <summary>
    /// The invoker graph, cleared when the assembly load context is unloaded so that the generated
    /// assemblies actually become collectable. See the remarks on <see cref="Dispose"/>.
    /// </summary>
    private IReadOnlyDictionary<CqlVersionedLibraryIdentifier, LibraryInvoker> _libraryInvokers;

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
        _libraryInvokers =
            _alc.Assemblies
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
    /// The assembly load context holding this library set's assemblies, so that
    /// <see cref="LibrarySetInvokerPool"/> can hold a weak reference to it and report how many evicted
    /// contexts have not been reclaimed yet.
    /// </summary>
    internal AssemblyLoadContext AssemblyLoadContext => _alc;

    /// <summary>
    /// Unloads the assembly load context and releases the invoker graph.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Clearing <see cref="LibraryInvokers"/> is not housekeeping, it is what makes unloading
    /// possible. <see cref="AssemblyLoadContext.Unload"/> only <em>initiates</em> unloading; the
    /// context is reclaimed once nothing references it any more. Every value in that dictionary holds
    /// the generated library singleton and delegates bound into the generated assembly, so leaving it
    /// populated keeps the context - and its JIT-compiled code, which on Linux costs two memory
    /// mappings per region - resident for as long as this object is reachable.
    /// </para>
    /// <para>
    /// Marked <see cref="MethodImplOptions.NoInlining"/> so that stack slots the JIT may introduce for
    /// the graph do not keep it alive for the enclosing frame's lifetime.
    /// </para>
    /// </remarks>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Unload()
    {
        // Unloading twice was an access violation before .NET 8.0.0 (dotnet/runtime#91283), and is
        // pointless afterwards, so only the first caller gets through.
        if (Interlocked.Exchange(ref _unloadInitiated, 1) != 0)
            return;

        _libraryInvokers = ImmutableDictionary<CqlVersionedLibraryIdentifier, LibraryInvoker>.Empty;
        _alc.Unload();
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
        get
        {
            ObjectDisposedException.ThrowIf(_unloadInitiated != 0, this);
            return _libraryInvokers;
        }
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
