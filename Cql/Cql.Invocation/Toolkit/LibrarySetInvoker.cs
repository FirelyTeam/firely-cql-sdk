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
        EnumerationExceptionContinuation enumerationExceptionContinuation)
    {
        _alc = alc;
        LoggerFactory = loggerFactory;
        EnumerationExceptionContinuation = enumerationExceptionContinuation;
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
    public EnumerationExceptionContinuation EnumerationExceptionContinuation { get; private set; }

    /// <inheritdoc />
    public LibrarySetInvoker SetEnumerationExceptionContinuation(EnumerationExceptionContinuation continuation)
    {
        EnumerationExceptionContinuation = continuation;
        return this;
    }
}
