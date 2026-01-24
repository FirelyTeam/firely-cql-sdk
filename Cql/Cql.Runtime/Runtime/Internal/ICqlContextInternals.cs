/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime.Internal;

/// <summary>
/// Internal interface for accessing cache functionality on CqlContext.
/// This interface is used by generated libraries and should not be used directly by consumers.
/// </summary>
public interface ICqlContextInternals
{
    /// <summary>
    /// Gets or computes a cached value for the specified cache index.
    /// </summary>
    /// <typeparam name="T">The type of the cached value.</typeparam>
    /// <param name="cacheIndex">The index identifying the cached value.</param>
    /// <param name="factory">A function to compute the value if it's not in the cache.</param>
    /// <returns>The cached or newly computed value.</returns>
    /// <remarks>
    /// This method is thread-safe and can be called concurrently from multiple threads.
    /// If caching is disabled or the cache index is invalid, the factory function is called without caching the result.
    /// </remarks>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    T GetOrCompute<T>(int cacheIndex, Func<CqlContext, T> factory);
}
