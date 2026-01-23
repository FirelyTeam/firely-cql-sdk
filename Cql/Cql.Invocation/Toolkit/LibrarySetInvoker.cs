/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;
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
    /// Initializes a new instance of the <see cref="LibrarySetInvoker"/> class.
    /// </summary>
    internal LibrarySetInvoker(
        AssemblyLoadContext alc,
        ILoggerFactory loggerFactory,
        BatchProcessExceptionContinuation batchProcessExceptionContinuation,
        string librarySetName)
    {
        _alc = alc;
        LoggerFactory = loggerFactory;
        BatchProcessExceptionContinuation = batchProcessExceptionContinuation;
        LibrarySetName = librarySetName;
        LibraryInvokers =
            _alc.Assemblies
                .SelectMany(a => a.GetTypes())
                .SelectWhereNotNull(libraryType =>
                {
                    _ = LibraryInvoker.TryCreateFromType(this, libraryType, out var libraryInvoker);
                    return libraryInvoker;
                })
                .ToImmutableDictionary(o => o.LibraryIdentifier);


            var libraries = GetAllLibraries();
            Cache = new CqlLibrariesExecutionCache(CacheWriteStrategy.ExecutionAndPublication, libraries);
        }

        /// <summary>
        /// Gets the execution cache instance for this library set.
        /// </summary>
        public CqlLibrariesExecutionCache Cache { get; private set; }

    private ILibrary[] GetAllLibraries() => // DO NOT MAKE THIS PUBLIC (Design Decision is to encapsulated Library Instances)
        LibraryInvokers
            .Values
            .Cast<LibraryInstanceInvoker>()
            .SelectToArray(LibraryInvokers.Count, libraryInvoker => libraryInvoker.Library);

    /// <summary>
    /// Releases all resources used by the <see cref="LibrarySetInvoker"/>.
    /// </summary>
    public void Dispose()
    {
        _alc.Unload();
    }

    /// <summary>
    /// Gets the dictionary of library invokers.
    /// </summary>
    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, LibraryInvoker> LibraryInvokers
    {
        [DebuggerStepThrough]
        get;
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
    public LibrarySetInvoker SetBatchProcessExceptionContinuation(BatchProcessExceptionContinuation continuation)
    {
        BatchProcessExceptionContinuation = continuation;
        return this;
    }

    /// <inheritdoc />
    public override string? ToString() =>
        string.IsNullOrEmpty(LibrarySetName)
            ? base.ToString()
            : StartBrace().AppendMember(LibrarySetName).EndBrace();
}
