/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime.Internal
{
    /// <summary>
    /// Represents a cache entry that can store a value (including null) and track whether it has been cached.
    /// This class is designed for thread-safe access in read-heavy, write-once scenarios with per-entry locking.
    /// </summary>
    /// <remarks>
    /// This class uses a flag to distinguish between "not cached" and "cached with null value".
    /// Thread safety is achieved through volatile semantics and per-entry locking, allowing concurrent
    /// writes to different cache entries without contention.
    /// </remarks>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    internal sealed class CacheEntry
    {
        /// <summary>
        /// The cached value. Can be null if the computation result was null.
        /// </summary>
        public object? Value;

        /// <summary>
        /// Indicates whether this entry has been cached (true) or is empty (false).
        /// Uses volatile semantics for thread-safe reads.
        /// </summary>
        public volatile bool IsCached;

        /// <summary>
        /// Creates a new cached entry with the specified value.
        /// </summary>
        /// <param name="value">The value to cache (can be null).</param>
        /// <returns>A cache entry marked as cached with the given value.</returns>
        public static CacheEntry Create(object? value)
        {
            return new CacheEntry
            {
                Value = value,
                IsCached = true
            };
        }

        private object? DebuggerDisplay
        {
            get
            {
                bool isCached = IsCached;
                if (!isCached)
                    return "<empty>";

                return Value;
            }
        }
    }
}
