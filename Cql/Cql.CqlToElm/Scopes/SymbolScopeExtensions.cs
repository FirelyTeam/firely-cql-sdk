using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm
{
    internal static class SymbolScopeExtensions
    {
        internal static bool TryGetRef(this ISymbolScope scope, string identifier, out Expression? definitionRef)
        {
            var libraryName = scope is IDefinitionElement def ? def.Name : null;

            if (scope.TryResolveSymbol(identifier, out var symbol))
            {
                definitionRef = symbol!.ToRef(libraryName);
                //(definitionRef, error, var success) = checkReferable(symbol!);
                return true;
            }
            else
            {
                definitionRef = default;
                return false;
            }

            //(Expression?, string?, bool) checkReferable(IDefinitionElement def)
            //{
            //    return def switch
            //    {
            //        ContextDef => (null, $"Identifier {identifier} refers to a context, which cannot be used here.", false),
            //        IncludeDef => (null, $"Identifier {identifier} refers to an included library, which cannot be used here.", false),
            //        UsingDef => (null, $"Identifier {identifier} refers to a model library, which cannot be used here.", false),
            //        _ => (def.ToRef(libraryName), null, true)
            //    };
            //}
        }

        internal static bool TryResolveNamedTypeSpecifier(this ISymbolScope systab,
            string? libraryName, string typeName, out NamedTypeSpecifier? namedType, out string? error)
        {
            var success = systab.TryResolveType(libraryName, typeName, out var result, out error);
            namedType = result is not null ? result.ToNamedType() : null;
            return success;
        }



    }
}
