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
/// Default implementation of cache key generator using deterministic SHA256 hashing.
/// </summary>
/// <remarks>
/// Generates deterministic 64-bit cache keys using SHA256 hash of the combined input:
/// libraryIdentifier + definitionName + salt + version.
/// The salt is derived from the library set name (or a random value if null).
/// The version parameter (0-255) handles hash collisions by generating alternative keys.
/// </remarks>
internal sealed class DeterministicIdGenerator : ICacheKeyGenerator
{
    private readonly string _salt;
    private readonly Dictionary<string, byte> _collisionVersions = new();

    /// <summary>
    /// Initializes a new instance of <see cref="DeterministicIdGenerator"/>.
    /// </summary>
    /// <param name="salt">Salt string for key generation. If null or empty, uses empty string.</param>
    public DeterministicIdGenerator(string? salt = null)
    {
        _salt = salt ?? string.Empty;
    }

    /// <inheritdoc />
    public long GenerateCacheKey(string libraryIdentifier, string definitionName)
    {
        var key = $"{libraryIdentifier}.{definitionName}";

        lock (_collisionVersions)
        {
            if (!_collisionVersions.TryGetValue(key, out var version))
            {
                version = 0;
                _collisionVersions[key] = version;
            }
            else
            {
                // Increment version on subsequent calls (for collision handling)
                version++;
                _collisionVersions[key] = version;
            }

            return GenerateDeterministicId(libraryIdentifier, definitionName, version);
        }
    }

    /// <summary>
    /// Generates a deterministic 64-bit ID using SHA256 hash.
    /// </summary>
    /// <param name="libraryIdentifier">The library identifier.</param>
    /// <param name="definitionName">The definition name.</param>
    /// <param name="version">Version byte for collision handling (0-255).</param>
    /// <returns>A deterministic 64-bit signed long.</returns>
    private long GenerateDeterministicId(string libraryIdentifier, string definitionName, byte version)
    {
        // Combine all inputs: libraryIdentifier + definitionName + salt + version
        var input = $"{libraryIdentifier}.{definitionName}.{_salt}.{version}";
        var bytes = Encoding.UTF8.GetBytes(input);

        // Compute SHA256 hash
        var hashBytes = SHA256.HashData(bytes);

        // Take first 8 bytes and convert to long
        var id = BitConverter.ToInt64(hashBytes, 0);

        return id;
    }
}
