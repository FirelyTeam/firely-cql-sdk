/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// A point-in-time snapshot of a <see cref="LibrarySetInvokerPool"/>'s activity.
/// </summary>
/// <param name="Hits">The number of requests served from an already-loaded library set.</param>
/// <param name="Misses">The number of requests that had to load a library set.</param>
/// <param name="Entries">The number of library sets currently held.</param>
/// <param name="PendingUnloads">
/// The number of evicted assembly load contexts that have not been reclaimed yet.
/// </param>
/// <remarks>
/// <para>
/// <paramref name="PendingUnloads"/> is the number worth alerting on. Unloading an assembly load
/// context is cooperative: it completes only once nothing references the context any more, so a value
/// that keeps climbing means something is holding evicted library sets alive - most likely a consumer
/// caching a <see cref="LibraryInvoker"/> or <see cref="DefinitionInvoker"/>, each of which reaches
/// its whole library set through a back-reference.
/// </para>
/// <para>
/// This is deliberately not derived from <see cref="System.Runtime.Loader.AssemblyLoadContext.All"/>,
/// which drops a context as soon as unloading is initiated and would therefore hide exactly the
/// contexts that are leaking.
/// </para>
/// </remarks>
public readonly record struct LibrarySetInvokerPoolStatistics(
    long Hits,
    long Misses,
    int Entries,
    int PendingUnloads);
