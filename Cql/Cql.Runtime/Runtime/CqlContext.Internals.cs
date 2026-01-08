#nullable enable

using System.Threading;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Defines members that provide internal context information for internal use by CQL libraries.
/// </summary>
/// <remarks>This interface is intended for internal scenarios where access to internal context details is
/// required. It is not intended for general application use and may be subject to change in future
/// versions.</remarks>
[EditorBrowsable(EditorBrowsableState.Advanced)]
public interface ICqlContextInternals
{
    /// <summary>
    /// Gets an object representing the current cache version.
    /// When caching is disabled, this value is <see langword="null"/>.
    /// When this value changes, it indicates that the cache was invalidated, and cached data should be refreshed on next access.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public long CacheVersion { get; }
}

partial class CqlContext : ICqlContextInternals
{
    private static long _globalCacheVersion = 0;

    private long _cacheVersion;

    /// <summary>
    /// Invalidates the current cache, forcing subsequent operations to use fresh data.
    /// </summary>
    /// <remarks>Call this method to clear any cached data and ensure that future operations do not use stale
    /// information. This is useful when the underlying data source has changed and the cache needs to be
    /// refreshed. This does not clear out existing cache data maintained in CQL libraries.</remarks>
    public void UseNewCache() => _cacheVersion = Interlocked.Increment(ref _globalCacheVersion);

    /// <summary>
    /// Disables caching for subsequent operations by resetting the cache state.
    /// </summary>
    /// <remarks>Call this method to ensure that future operations do not use any previously cached data. This
    /// may impact performance if caching is typically used to improve efficiency.</remarks>
    public void DontUseCaching() => _cacheVersion = 0;

    long ICqlContextInternals.CacheVersion => _cacheVersion;
}