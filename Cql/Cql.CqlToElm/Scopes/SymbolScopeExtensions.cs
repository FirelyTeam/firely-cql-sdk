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
        public static IdentifierRef MakeErrorReference(string? libraryName, string identifier, string error) =>
             new IdentifierRef() { libraryName = libraryName, name = identifier }
                .WithResultType(SystemTypes.AnyType)
                .AddError(error);

        public static Expression Ref(this ISymbolScope symbolScope, MessageProvider messaging, string? libraryAlias, string identifier)
        {
            var success = TryResolveSymbol(symbolScope, libraryAlias, identifier, out var result);
            if (success)
            {
                try
                {
                    return result!.ToRef(libraryAlias);
                }
                catch (InvalidOperationException io) 
                {
                    if (io.Message == "ValueFactory attempted to access the Value property of this instance.")
                        return MakeErrorReference(libraryAlias, identifier, messaging.CannotResolveCircularReference());
                    else throw;
                }
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
            if (symbolScope.TryResolveSymbol(null, libraryAlias, out var ele) && ele is ReferencedLibrary ids)
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
        public static bool TryResolveSymbol(this ISymbolScope symbolScope, string? libraryName, string identifier, out IDefinitionElement? result)
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
                    if (library is ReferencedLibrary referencedLibrary)
                    {
                        return referencedLibrary.Symbols.TryResolveSymbol(identifier, out result);
                    }
                }
            }
            result = null;
            return false;
        }

    }
}