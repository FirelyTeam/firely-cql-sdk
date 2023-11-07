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
                return true;
            }
            else
            {
                definitionRef = default;
                return false;
            }
        }

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


        internal static bool TryResolveType(this ISymbolScope scope,
            string? libraryName, string typeName, out ModelType? result, out string? error)
        {
            // If the typename is qualified with a library name, only look in the specified model library.
            if (libraryName is not null)
            {
                if (scope.TryResolveSymbol(libraryName, out var librarySymbol))
                {
                    if (librarySymbol is UsingDefSymbol usingDef)
                    {
                        (result, error) = usingDef.TryResolveSymbol(typeName, out var typeInfo) switch
                        {
                            true => (new ModelType(usingDef.Model, (Model.TypeInfo)typeInfo!), default(string)),
                            false => (null, $"There is no type named '{typeName}' in model library {libraryName}."),
                        };
                    }
                    else
                    {
                        (result, error) = (null, $"'{libraryName}' is not a model library.");
                    }
                }
                else
                {
                    (result, error) = (null, $"There is no model named '{libraryName}'.");
                }

                return error is not null;
            }


            if (scope.TryResolveSymbol(typeName, out var symbol))
            {
                if (symbol is ModelType modelType)
                {
                    (result, error) = (modelType, default(string));
                }
                else
                {
                    (result, error) = (null, $"'{typeName}' is not a type.");
                }
            }
            else
            {
                (result, error) = (null, $"Cannot resolve type '{typeName}'.");
            }

            return error is not null;

            //error = (matches.Count, models.Count) switch
            //{
            //    (0, 0) => $"There is no model named '{libraryName}'.",
            //    (0, 1) => $"There is no type named '{typeName}' in model library {libraryName}.",
            //    (0, _) => $"There is no type named '{typeName}' in model libraries {modelNamesList(models.Select(m => (m.Model.url, m.Model.version)))}.",
            //    ( > 1, _) => $"Ambiguous type name '{typeName}', matches {modelNamesList(matches.Select(m => (m.Model.url, m.Model.version)))}.",
            //    _ => null,
            //};

            //result = matches.FirstOrDefault();
            //return matches.Count == 1;

            //static string modelNamesList(IEnumerable<(string uri, string version)> models) =>
            //    string.Join(", ", models.Select(m => $"{m.uri} (version {m.version ?? "unspecified"})"));
        }

    }
}
