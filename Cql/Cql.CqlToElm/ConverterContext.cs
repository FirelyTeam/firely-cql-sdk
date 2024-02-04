﻿using Hl7.Cql.Elm;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal class ConverterContext : ILibraryProvider
    {
        private readonly Dictionary<(string name, string version), Library> Libraries = new();

        public bool TryAddLibrary(Library library)
        {
            return Libraries.TryAdd((library.identifier.id, library.identifier.version), library);
        }

        public bool TryResolveLibrary(string libraryName, string? version, out Library? library, out string? error)
        {
            error = null;

            if (version is not null)
            {
                var success = Libraries.TryGetValue((libraryName, version), out library);
                error = success ? null : $"Could not find library: {libraryName} version '{version ?? "latest"}'. Are you sure this library version exists and that you have access?";
                return success;
            }
            else
            {
                var hits = Libraries.Keys.Where(l => l.name == libraryName).ToArray();

                (var success, error, library) = hits.Length switch
                {
                    0 => (false, $"Could not find library: {libraryName} version '{version ?? "latest"}'. Are you sure this library version exists and that you have access?", default(Library)),
                    1 => (true, null, Libraries[hits.Single()]),
                    // reference impl allows the same lib to be included multiple times as long as the local identifier is different
                    _ => (false, $"Found multiple libraries with name '{libraryName}'.", null)
                    
                };

                return success;
            }

        }
    }
}