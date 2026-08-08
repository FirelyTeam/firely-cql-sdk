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
/// Configuration settings for a <see cref="LibrarySetInvokerPool"/>.
/// </summary>
/// <param name="Capacity">
/// The number of distinct library sets to keep loaded. Must be at least 1. Size this to the number of
/// library sets evaluated concurrently: an undersized pool alternating between more library sets than
/// it can hold misses on every request, which is no better than not pooling at all.
/// </param>
/// <param name="MaxPendingUnloads">
/// When greater than 0, the pool logs a warning once more than this many evicted assembly load
/// contexts are still awaiting reclamation. 0, the default, disables the warning.
/// </param>
public record LibrarySetInvokerPoolOptions(
    int Capacity = 8,
    int MaxPendingUnloads = 0)
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static LibrarySetInvokerPoolOptions Default { get; } = new();

    /// <summary>
    /// The number of distinct library sets to keep loaded.
    /// </summary>
    /// <remarks>
    /// This is a target rather than a hard ceiling. A library set whose assemblies are still being
    /// loaded is never evicted, so a burst of concurrent misses on distinct library sets can briefly
    /// leave more entries in the pool than this. Eviction also only <em>initiates</em> unloading:
    /// reclaiming the memory needs the garbage collector to run and finalizers to complete, so
    /// resident memory lags this number.
    /// </remarks>
    public int Capacity { get; init; } = Capacity;
}
