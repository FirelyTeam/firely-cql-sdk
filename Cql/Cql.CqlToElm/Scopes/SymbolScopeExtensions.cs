using Hl7.Cql.CqlToElm.Builtin;
using Hl7.Cql.Elm;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace Hl7.Cql.CqlToElm
{
    internal static class SymbolScopeExtensions
    {
        internal static bool TryResolveNamedTypeSpecifier(this SymbolTable symbolTable,
            string? libraryName, string typeName, out NamedTypeSpecifier? namedType, out string? error)
        {
            var success = symbolTable.TryResolveType(libraryName, typeName, out var result, out error);
            namedType = result?.ToNamedType();
            return success;
        }

        public static bool TryResolveType(this SymbolTable symbolTable, string? libraryName, string typeName, out ModelType? result, out string? error)
        {
            ModelType? getModelType(UsingDefSymbol s, string name) =>
                s.Model.TryGetTypeInfoFor(typeName, out var typeInfo) ?
                    new ModelType(s.Model, typeInfo!) : null;

            // If the typename is qualified with a library name, only look in the specified model library.
            if (libraryName is not null)
            {
                if (symbolTable.TryResolveSymbol(libraryName, out var model))
                {
                    if (model is UsingDefSymbol usingDef)
                    {
                        if (getModelType(usingDef, typeName) is { } modelType)
                            (result, error) = (modelType, null);
                        else
                            (result, error) = (null, $"There is no type named '{typeName}' in model library {libraryName}.");
                    }
                    else
                    {
                        (result, error) = (null, $"{libraryName} is not a reference to an model library.");
                    }
                }
                else
                    (result, error) = (null, $"There is no model named '{libraryName}'.");

                return error is not null;
            }

            // Else, go over all used models to find it. This could mean we find an ambiguous match.
            var usingDefs = symbolTable.Symbols.OfType<UsingDefSymbol>().ToArray();
            var matches = usingDefs.Select(include => (include, modelType: getModelType(include, typeName)))
                    .Where(r => r.modelType is not null).ToList();
            if (matches.Count > 1)
            {
                // Reference behavior when there is a conflict (e.g. FHIR.Quantity, System.Quantity) is to prefer the System type.
                // So, an unqualified Quantity type in a library using FHIR will resolve to System.Quantity.
                var systemMatches = matches.Where(m => m.include.Model.name == "System").ToArray();
                if (systemMatches.Length == 1)
                {
                    result = systemMatches[0].modelType;
                    error = null;
                    return true;
                }
                else
                {
                    result = null;
                    error = $"Ambiguous type name '{typeName}', found matches in {string.Join(",", matches.Select(m => m.include.localIdentifier))}.";
                    return false;
                }
            }

            else
            {
                error = (matches.Count, usingDefs.Length) switch
                {
                    (_, 0) => $"Cannot resolve type {typeName} as there are no models referenced in this library.",
                    (0, 1) => $"There is no type named '{typeName}' in model library {usingDefs.Single().localIdentifier}.",
                    (0, _) => $"There is no type named '{typeName}' in model libraries {string.Join(",", usingDefs.Select(u => u.localIdentifier))}.",
                    _ => null,
                };
                var success = error is null;
                result = success ? matches.Single().modelType : null;
                return success;
            }
        }


        public static IdentifierRef MakeErrorReference(string? libraryName, string identifier, string error) =>
             new IdentifierRef() { libraryName = libraryName, name = identifier }
                .WithResultType(SystemTypes.AnyType)
                .AddError(error);

        public static Expression Ref(this ISymbolScope symbolScope, MessageProvider messaging, string? libraryAlias, string identifier)
        {
            var success = TryResolveIdentifier(symbolScope, libraryAlias, identifier, out var result);
            if (success)
            {
                return result!.ToRef(libraryAlias);
            }
            else
            {
                if (libraryAlias is not null)
                {
                    if (symbolScope.TryGetLibraryNameFromLocalAlias(libraryAlias, out var libraryName))
                        return MakeErrorReference(libraryAlias, identifier, messaging.CouldNotResolveInLibrary(identifier, libraryName!));
                    else
                        return MakeErrorReference(libraryAlias, identifier, messaging.CouldNotResolveInLibrary(identifier, libraryAlias));
                }
                else
                {
                    return MakeErrorReference(libraryAlias, identifier, messaging.CouldNotResolveInCurrent(identifier));
                }
            }
        }

        public static bool TryGetLibraryNameFromLocalAlias(this ISymbolScope symbolScope, string libraryAlias, out string? libraryName)
        {
            if (symbolScope.TryResolveIdentifier(null, libraryAlias, out var ele) && ele is IncludeDefSymbol ids)
            {
                libraryName = ids!.path;
                return true;
            }
            libraryName = null;
            return false;
        }

        /// <summary>
        /// Try to resolve the given identifier.
        /// </summary>
        /// <returns>True if the identifier was found, false otherwise. <paramref name="result"/> will contain the reference
        /// to the definition in the <see cref="ISymbolScope"/> on success or an <see cref="IdentifierRef"/> with an error 
        /// annotation otherwise.</returns>
        public static bool TryResolveIdentifier(this ISymbolScope symbolScope, string? libraryName, string identifier, out IDefinitionElement? result)
        {
            result = null;
            if (libraryName is null)
            {
                return symbolScope.TryResolveSymbol(identifier, out result);
            }
            else
            {
                if (symbolScope.TryResolveSymbol(libraryName, out var library))
                {
                    if (library is IncludeDefSymbol includeDef)
                    {
                        return includeDef.Library.TryResolveSymbol(identifier, out result);
                    }
                }
            }
            result = null;
            return false;
        }

    }
}