/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit;


/// <summary>
/// Represents an invoker for a set of CQL libraries.
/// </summary>
public sealed class LibrarySetInvoker : IDisposable
{
    private readonly AssemblyLoadContext _alc;

    /// <summary>
    /// Initializes a new instance of the <see cref="LibrarySetInvoker"/> class.
    /// </summary>
    /// <param name="invocationToolkit">The builder used to create the library set invoker.</param>
    /// <param name="alc">The assembly load context.</param>
    internal LibrarySetInvoker(InvocationToolkit invocationToolkit, AssemblyLoadContext alc)
    {
        _alc = alc;
        LibraryInvokers =
            _alc.Assemblies
                .SelectMany(a => a.GetTypes())
                .SelectWhereNotNull(t =>
                {
                    LibraryInvoker.TryCreateFromType(invocationToolkit, t, out var libraryInvoker);
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
}
