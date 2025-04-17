/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;
using System.Text;
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
    }

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
    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, LibraryInvoker> LibraryInvokers { get; }

    /// <inheritdoc />
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public ILoggerFactory LoggerFactory { get; }

    /// <inheritdoc />
    public BatchProcessExceptionContinuation BatchProcessExceptionContinuation { get; private set; }

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
