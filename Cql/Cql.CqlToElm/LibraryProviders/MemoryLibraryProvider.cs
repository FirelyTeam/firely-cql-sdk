using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CqlToElm.LibraryProviders
{
    /// <summary>
    /// Provides libraries through an in-memory dictionary.  Libraries that are referenced, but not included,
    /// will not resolve and will result in errors.  The user of this class is responsible for pre-populating
    /// <see cref="Libraries"/> with all required libraries.
    /// </summary>
    internal class MemoryLibraryProvider : ILibraryProvider
    {
        public VersionedIdentifierDictionary<Library> Libraries { get; } = new();
        public bool TryResolveLibrary(string libraryName, string? version, out Library? library, out string? error)
        {
            if (Libraries.TryGet(libraryName, version, out var lib))
            {
                library = lib;
                error = null;
                return true;
            }
            else
            {
                library = null;
                error = null;
                return false;
            }
        }
    }
}
