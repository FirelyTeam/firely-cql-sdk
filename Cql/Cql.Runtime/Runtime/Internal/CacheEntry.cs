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
    /// This struct is designed for thread-safe access in read-heavy, write-once scenarios.
    /// </summary>
    /// <remarks>
    /// This struct uses a flag to distinguish between "not cached" and "cached with null value".
    /// Thread safety for writes is achieved through external locking in CqlLibraryInvocationCache.
    /// Using a struct provides better memory locality and reduces GC pressure compared to a class.
    /// </remarks>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    internal struct CacheEntry
    {
        /// <summary>
        /// The cached value. Can be null if the computation result was null.
        /// </summary>
        internal object? Value;

        /// <summary>
        /// Indicates whether this entry has been cached (true) or is empty (false).
        /// </summary>
        internal bool IsCached;

        private readonly object? DebuggerDisplay
        {
            get
            {
                if (!IsCached)
                    return "<empty>";

                return Value;
            }
        }
    }
}
