/*
 * Copyright (c) 2026, Firely, NCQA and contributors
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
/// Default implementation of cache key generator using a Snowflake-like algorithm.
/// </summary>
/// <remarks>
/// The cache key is a 64-bit signed long structured as follows:
/// - Bits 63-34 (30 bits): Seconds since 2020-01-01 00:00:00 UTC (allows dates up to ~2054)
/// - Bits 33-2 (32 bits): FNV-1a hash of the library and definition identifier
/// - Bits 1-0 (2 bits): Sequence counter for collision handling (0-3)
/// This ensures uniqueness by combining temporal, content-based, and sequential components.
/// </remarks>
internal sealed class SnowflakeAlgorithmCacheKeyGenerator : ICacheKeyGenerator
{
    private static readonly DateTime Epoch = new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    private static readonly DateTime GenerationTime = DateTime.UtcNow;
    private readonly Dictionary<long, int> _sequenceCounters = new();
    
    /// <inheritdoc />
    public long GenerateCacheKey(string libraryIdentifier, string definitionName)
    {
        var cacheKeyString = $"{libraryIdentifier}.{definitionName}";
        return GenerateUniqueId(cacheKeyString);
    }

    /// <summary>
    /// Generates a unique cache key combining timestamp, FNV-1a hash, and sequence counter.
    /// Uses the generation time captured at class initialization for deterministic builds.
    /// If the sequence counter overflows (>3), waits one second to get a new timestamp and retries.
    /// </summary>
    private long GenerateUniqueId(string input)
    {
        // Start with the static generation time for deterministic builds
        var timestamp = GenerationTime;
        
        while (true)
        {
            // Calculate seconds since epoch (30 bits - supports dates until ~2054)
            var secondsSinceEpoch = (uint)(timestamp - Epoch).TotalSeconds;
            
            // Generate FNV-1a 32-bit hash for the input
            var hash = GenerateFnv1aHash32(input);
            
            // Create base key (without sequence)
            var baseKey = (((long)secondsSinceEpoch & 0x3FFFFFFFL) << 34) | (((long)hash & 0xFFFFFFFFL) << 2);
            
            // Handle collisions with sequence counter
            lock (_sequenceCounters)
            {
                if (!_sequenceCounters.TryGetValue(baseKey, out var sequence))
                {
                    sequence = 0;
                    _sequenceCounters[baseKey] = sequence;
                    
                    // Combine: high 30 bits = timestamp, middle 32 bits = hash, low 2 bits = sequence
                    return baseKey | (long)sequence;
                }
                else
                {
                    sequence++;
                    if (sequence > 3)
                    {
                        // Sequence overflow - we'll wait 1 second and use a new timestamp
                        // Continue outside the lock to avoid holding it during sleep
                    }
                    else
                    {
                        _sequenceCounters[baseKey] = sequence;
                        
                        // Combine: high 30 bits = timestamp, middle 32 bits = hash, low 2 bits = sequence
                        return baseKey | (long)sequence;
                    }
                }
            }
            
            // Only reached if sequence > 3
            // Wait 1 second and use current time for next iteration
            Thread.Sleep(1000);
            timestamp = DateTime.UtcNow;
        }
    }

    /// <summary>
    /// Generates a 32-bit FNV-1a hash for better distribution than GetHashCode.
    /// </summary>
    private static uint GenerateFnv1aHash32(string input)
    {
        // FNV-1a 32-bit hash constants
        const uint FnvOffsetBasis = 2166136261;
        const uint FnvPrime = 16777619;

        uint hash = FnvOffsetBasis;
        foreach (char c in input)
        {
            hash ^= c;
            hash *= FnvPrime;
        }

        return hash;
    }
}
