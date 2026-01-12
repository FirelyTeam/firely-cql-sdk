/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CodeGeneration.NET;

/// <summary>
/// Provides cache key generation for CQL library definitions.
/// </summary>
internal interface ICacheKeyGenerator
{
    /// <summary>
    /// Generates a deterministic cache key for a given library and definition identifier.
    /// </summary>
    /// <param name="libraryIdentifier">The library identifier (e.g., "LibraryName-1.0.0").</param>
    /// <param name="definitionName">The definition name.</param>
    /// <returns>A unique long identifier for the cache key.</returns>
    long GenerateCacheKey(string libraryIdentifier, string definitionName);
}

/// <summary>
/// Default implementation of cache key generator using FNV-1a hash algorithm.
/// </summary>
internal sealed class FnvCacheKeyGenerator : ICacheKeyGenerator
{
    /// <inheritdoc />
    public long GenerateCacheKey(string libraryIdentifier, string definitionName)
    {
        var cacheKeyString = $"{libraryIdentifier}.{definitionName}";
        return GenerateSnowflakeId(cacheKeyString);
    }

    /// <summary>
    /// Generates a deterministic cache key using FNV-1a hash algorithm.
    /// Uses FNV-1a 64-bit hash for better distribution than GetHashCode.
    /// </summary>
    private static long GenerateSnowflakeId(string input)
    {
        // FNV-1a 64-bit hash constants
        const ulong FnvOffsetBasis = 14695981039346656037;
        const ulong FnvPrime = 1099511628211;

        ulong hash = FnvOffsetBasis;
        foreach (char c in input)
        {
            hash ^= c;
            hash *= FnvPrime;
        }

        // Return as signed long (cast from unsigned hash)
        return unchecked((long)hash);
    }
}
