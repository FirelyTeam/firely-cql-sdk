/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler;

internal class LibrarySetDefinitionCache(LibrarySet parent)
{
    public bool TryResolveDefinition<TDefinition>(
        Library refContext,
        IReferenceElement reference,
        [NotNullWhen(true)] out TDefinition? def)
        where TDefinition : IDefinitionElement
    {
        var libraryName = reference is IGetLibraryName gln ? gln.libraryName : null;
        def = default;

        return reference.name is not null && TryResolveDefinition(refContext, reference.name, libraryName, out def);
    }

    public bool TryResolveDefinition<TDefinition>(
        Library refContext,
        string name, string? libraryAlias,
        [NotNullWhen(true)] out TDefinition? def)
        where TDefinition : IDefinitionElement
    {
        var cache = GetLibraryCache(refContext, libraryAlias);
        return cache.TryResolveDefinition(name, out def);
    }

    // Indexed by library name and version
    private readonly ConcurrentDictionary<string, LibraryCache> _cachedLibraries = new();

    private LibraryCache GetLibraryCache(Library library)
    {
        return _cachedLibraries.GetOrAdd(library.GetVersionedIdentifier()!, buildCache);
        LibraryCache buildCache(string _) => LibraryCache.Build(library);
    }

    private LibraryCache GetLibraryCache(Library context, string? libraryAlias)
    {
        var contextCache = GetLibraryCache(context);

        if (libraryAlias is null)
            return contextCache;

        // If a library alias is provided, we need to return the cache for
        // the alias, as defined in the includes in the context Library.
        if (!contextCache.TryResolveDefinition<IncludeDef>(libraryAlias, out var includeDef))
            throw new LibraryAliasUnresolvedError(context, libraryAlias).ToException();

        var aliasedLibrary = parent.GetLibrary(includeDef.GetVersionedIdentifier()!)!;

        return GetLibraryCache(aliasedLibrary);
    }

    private record LibraryCache
    {
        public static LibraryCache Build(Library library)
        {
            var cache = new LibraryCache();

            Index(cache.GetIndexForType<IncludeDef>(), library, library.includes);
            Index(cache.GetIndexForType<CodeSystemDef>(), library, library.codeSystems);
            Index(cache.GetIndexForType<ValueSetDef>(), library, library.valueSets);
            Index(cache.GetIndexForType<CodeDef>(), library, library.codes);
            Index(cache.GetIndexForType<ConceptDef>(), library, library.concepts);

            // Give expressions and functions a separate namespace.
            var expressionDefs = library.statements?.Where(s => s.GetType() == typeof(ExpressionDef)).ToArray();
            Index(cache.GetIndexForType<ExpressionDef>(), library, expressionDefs);

            var functionDefs = library.statements?.OfType<FunctionDef>().Cast<IFunctionElement>().ToArray();
            Index(cache.GetIndexForType<IFunctionElement>(), library, functionDefs);

            return cache;
        }

        public bool TryResolveDefinition<T>(string name, [NotNullWhen(true)] out T? def)
            where T : IDefinitionElement =>
            GetIndexForType<T>().TryGetValue(name, out def);

        private LibraryCache()
        {
            // Nothing
        }

        private readonly Dictionary<Type, object> _cache = new();

        private IDictionary<string, T> GetIndexForType<T>()
        {
            if (_cache.TryGetValue(typeof(T), out var index))
                return (IDictionary<string, T>)index;

            var newIndex = new Dictionary<string, T>();
            _cache.Add(typeof(T), newIndex);

            return newIndex;
        }

        private static void Index<T>(
            IDictionary<string, T> result,
            Library library,
            T[]? definitions) where T : IDefinitionElement
        {
            if (definitions is not { Length: > 0 })
                return;

            foreach (var definition in definitions)
            {
                if (result.TryAdd(
                        definition.Name ?? throw new LibraryDefinitionHasNoName(library, definition).ToException(),
                        definition)) continue;

                // We have a duplicate, this is ok for functions (=overloads), otherwise report
                // an error.
                if (definition is not FunctionDef expr || result[definition.Name] is not IFunctionElement existing)
                    throw new LibraryHasDuplicateDefinition(library, definition).ToException();

                if (existing is OverloadedFunctionDef methodGroup)
                {
                    // We have another overload for a MethodGroup, add it to the method group.
                    methodGroup.Add(expr);
                }
                else
                {
                    // We have the first overload, convert the ExpressionDef to a MethodGroup
                    // and add both methods
                    var newGroup = OverloadedFunctionDef.Create(existing, expr);
                    result[definition.Name] = (T)(object)newGroup;
                }
            }
        }
    }
}