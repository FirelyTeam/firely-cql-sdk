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
    /// Initializes cache indices for this library and its dependencies.
    /// </summary>
    /// <param name="cache">The execution cache instance.</param>
    /// <returns>The total number of cache indices initialized in this library and all its dependencies.</returns>
    int InitializeCacheIndices(CqlLibrariesExecutionCache cache);
}
