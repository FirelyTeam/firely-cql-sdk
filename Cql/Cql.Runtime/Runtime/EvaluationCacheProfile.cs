/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

namespace Hl7.Cql.Runtime;

/// <summary>
/// Describes how the definition/expression memoization cache of a <see cref="CqlContext"/> is created, so that
/// callers which do not create the context themselves can still opt into caching and size it for their
/// evaluation.
/// </summary>
/// <remarks>
/// A profile only describes the cache. Sharing one <see cref="CqlContext"/> across threads additionally
/// requires the thread-safety contract documented on <see cref="CqlContext"/>: definitions and parameters
/// fully populated before the fan-out and not mutated during it, and a data source and value set
/// implementation that tolerate concurrent reads.
/// </remarks>
public sealed class EvaluationCacheProfile
{
    /// <summary>
    /// The initial capacity of the cache, passed to <see cref="CqlContext.UseNewCache(int,int)"/>. Sizing this
    /// to (an upper bound of) the number of definitions/expressions expected to be cached avoids internal
    /// resizing. Must be at least <see cref="CqlContext.MinimumCacheInitialCapacity"/>.
    /// </summary>
    public int InitialCapacity { get; init; } = CqlContext.CacheInitialCapacity;

    /// <summary>
    /// The number of threads expected to write to the cache concurrently, passed to
    /// <see cref="CqlContext.UseNewCache(int,int)"/>. Must be at least
    /// <see cref="CqlContext.SequentialCacheConcurrencyLevel"/> and at most
    /// <see cref="CqlContext.MaximumCacheConcurrencyLevel"/>. Cache reads are lock-free at any level; a
    /// higher level keeps concurrent cache misses from serializing on a single write lock.
    /// </summary>
    public int ConcurrencyLevel { get; init; } = CqlContext.SequentialCacheConcurrencyLevel;

    /// <summary>
    /// A profile for evaluation on a single thread: default capacity, and all cache writes through one lock.
    /// </summary>
    public static EvaluationCacheProfile Sequential => new();

    /// <summary>
    /// A profile for evaluation spread over the available cores of the machine: default capacity, and a
    /// concurrency level of <see cref="Environment.ProcessorCount"/>.
    /// </summary>
    public static EvaluationCacheProfile Concurrent =>
        new() { ConcurrencyLevel = Environment.ProcessorCount };
}
