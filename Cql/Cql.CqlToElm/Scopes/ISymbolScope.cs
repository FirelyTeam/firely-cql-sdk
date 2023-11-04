using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal static class SymbolScopeExtensions
    {
        internal static bool TryResolveNamedTypeSpecifier(this ISymbolScope systab,
            string? libraryName, string typeName, out NamedTypeSpecifier namedType, out string? error)
        {
            var success = systab.TryResolveType(libraryName, typeName, out var result, out error);

            if (result is null)
                namedType = new NamedTypeSpecifier { name = Model.QualifiedName.MakeQualifiedTypeName(libraryName ?? "nosystem", typeName) };
            else
                namedType = result.ToNamedType();

            return success;
        }

        /// <summary>
        /// Find the top-level <see cref="ISymbolScope"/>, which is always the library under compilation.
        /// </summary>
        /// <param name="scope"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        internal static LibraryScope FindTopLevelLibraryScope(this ISymbolScope scope)
        {
            if (scope is LibraryScope lst)
                return lst;
            else
            {
                while (scope.Parent is not null)
                    scope = scope.Parent;

                return scope as LibraryScope ??
                    throw new InvalidOperationException("Expected root of the symbol table hierarchy to be a library symbol table.");
            }
        }

        internal static bool TryResolveType(this ISymbolScope systab,
            string? libraryName, string typeName, out ModelType? result, out string? error)
        {
            var topLevelScope = systab.FindTopLevelLibraryScope();
            var models = topLevelScope.Models;

            // If the typename is qualified with a library name, only look in the specified model,
            // otherwise try all models.
            if (libraryName is not null)
                models = models.Where(m => m.Name == libraryName).ToArray();

            var matches = new List<ModelType>();

            // For each of the used models in the library, now resolve the type.
            foreach (var model in models)
            {
                if (model.TryResolveSymbol(typeName, AccessModifier.Public, out var typeInfo))
                    matches.Add(new ModelType(model.Model, (Model.TypeInfo)typeInfo!));
            }

            error = (matches.Count, models.Count) switch
            {
                (0, 0) => $"There is no model named '{libraryName}'.",
                (0, 1) => $"There is no type named '{typeName}' in model library {libraryName}.",
                (0, _) => $"There is no type named '{typeName}' in model libraries {modelNamesList(models.Select(m => (m.Model.url, m.Model.version)))}.",
                ( > 1, _) => $"Ambiguous type name '{typeName}', matches {modelNamesList(matches.Select(m => (m.Model.url, m.Model.version)))}.",
                _ => null,
            };

            result = matches.FirstOrDefault();
            return matches.Count == 1;

            static string modelNamesList(IEnumerable<(string uri, string version)> models) =>
                string.Join(", ", models.Select(m => $"{m.uri} (version {m.version ?? "unspecified"})"));
        }

    }

    internal interface ILibraryProvider
    {
        bool TryResolveLibrary(string libraryName, string? version, out LibraryScope? library, out string? error);
    }


    internal interface ISymbolScope
    {
        ISymbolScope? Parent { get; }

        /// <summary>
        /// Adds a symbol to the scope.
        /// </summary>
        /// <returns>true if the symbol was added, false if it already existed in the symbol table.</returns>
        bool TryAdd(ISymbol symbol);

        /// <summary>
        /// Returns the definition plus reference to a symbol like ValueSet, CodeSystem, Concept, etcetera.
        /// </summary>
        /// <returns>true if the symbol was found in the table, false otherwise.</returns> 
        bool TryResolveSymbol(string identifier, AccessModifier access, out ISymbol? symbol);
    }
}
