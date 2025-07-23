/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.CqlToElm.LibraryProviders
{
    /// <summary>
    /// Provides libraries through an in-memory dictionary.  Libraries that are referenced, but not included,
    /// will not resolve and will result in errors.  The user of this class is responsible for pre-populating
    /// <see cref="Libraries"/> with all required libraries.
    /// </summary>
    internal class MemoryLibraryProvider : ILibraryProvider
    {
        public VersionedIdentifierDictionary<LibraryBuilder> Libraries { get; } = new();

        public bool TryResolveLibrary(string libraryName, string? version, [NotNullWhen(true)] out LibraryBuilder? libraryBuilder, out string? error)
        {
            if (Libraries.TryGet(libraryName, version, out libraryBuilder))
            {
                error = null;
                return true;
            }
            else
            {
                libraryBuilder = null;
                error = null;
                return false;
            }
        }
    }
}
