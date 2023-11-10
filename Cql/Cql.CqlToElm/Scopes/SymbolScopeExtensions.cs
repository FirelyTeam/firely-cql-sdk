using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm
{
    internal static class SymbolScopeExtensions
    {
        internal static bool TryGetRef(this ISymbolScope scope, string? libraryName, string identifier, out Expression? definitionRef)
        {
            if (scope.TryResolveSymbol(identifier, out var symbol))
            {
                definitionRef = symbol!.ToRef(libraryName);
                return true;
            }
            else
            {
                definitionRef = default;
                return false;
            }
        }

        internal static bool TryResolveNamedTypeSpecifier(this LibraryBuilder builder,
            string? libraryName, string typeName, out NamedTypeSpecifier? namedType, out string? error)
        {
            var success = builder.TryResolveType(libraryName, typeName, out var result, out error);
            namedType = result?.ToNamedType();
            return success;
        }
    }
}
