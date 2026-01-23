/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Runtime.Internal;

/// <summary>
/// Internal interface for CQL libraries to support cache index initialization.
/// This interface is implemented by generated libraries and should not be used directly by consumers.
/// </summary>
public interface ILibraryInternals
{
    /// <summary>
    /// Initializes cache indices for this library, but excluding its dependencies.
    /// </summary>
    /// <param name="librarySet">The library invocation set being initialized.</param>
    /// <param name="startIndex">The start index for cache indices.</param>
    /// <returns>The total number of cache indices initialized in this library.</returns>
    int InitializeCacheIndices(CqlLibraryInvocationSet librarySet, int startIndex);
    
    /// <summary>
    /// Sets the cache instance that this library will use for caching computed values.
    /// </summary>
    /// <param name="cache">The cache instance to use.</param>
    void SetCacheInstance(CqlLibraryInvocationCache cache);
}
