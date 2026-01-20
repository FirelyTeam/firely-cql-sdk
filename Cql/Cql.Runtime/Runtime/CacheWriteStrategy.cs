/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime
{
    /// <summary>
    /// Specifies how a cache handles concurrent access when multiple threads attempt to compute and cache the same value.
    /// </summary>
    public enum CacheWriteStrategy
    {
        /// <summary>
        /// Multiple threads can compute the value concurrently. The last thread to write wins.
        /// This is the fastest mode for read-heavy scenarios where all threads will compute the same value.
        /// Similar to <see cref="System.Threading.LazyThreadSafetyMode.PublicationOnly"/>.
        /// </summary>
        /// <remarks>
        /// In this mode, if multiple threads concurrently attempt to cache a value at the same index,
        /// all threads will invoke the factory function and compute the value. The last thread to write
        /// will determine the final cached value. This is acceptable when all computations produce the same result.
        /// This mode provides the best performance for read-heavy workloads with minimal write contention.
        /// </remarks>
        PublicationOnly = 0,

        /// <summary>
        /// Ensures that only one thread computes the value. Other threads wait for the computation to complete.
        /// This mode guarantees the factory function is called at most once per cache index.
        /// Similar to <see cref="System.Threading.LazyThreadSafetyMode.ExecutionAndPublication"/>.
        /// </summary>
        /// <remarks>
        /// In this mode, if multiple threads concurrently attempt to cache a value at the same index,
        /// only one thread will invoke the factory function. Other threads will spin-wait until the
        /// computation completes, then read the cached value. This ensures expensive computations
        /// are performed only once, at the cost of some threads waiting.
        /// Use this mode when computations are very expensive or have side effects that should occur only once.
        /// </remarks>
        ExecutionAndPublication = 1
    }
}
