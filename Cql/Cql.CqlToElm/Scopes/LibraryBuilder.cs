using Hl7.Cql.Elm;
using System;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal class LibraryBuilder
    {
        private static readonly VersionedIdentifier schemaIdentifier = new() { id = "urn:hl7-org:elm", version = "r1" };

        public LibraryBuilder()
        {
            CurrentScope = symbolTable;
            Identifier = new VersionedIdentifier() { id = "unset", version = "0.0.0" };
        }

        public VersionedIdentifier Identifier { get; set; }


        public Library Build()
        {
            var symbols = symbolTable.Symbols.ToArray();

            return new Library
            {
                identifier = Identifier,
                schemaIdentifier = schemaIdentifier,
                usings = symbols.OfType<UsingDef>().ToArray(),
                includes = symbols.OfType<IncludeDef>().ToArray(),
                parameters = symbols.OfType<ParameterDef>().ToArray(),
                codeSystems = symbols.OfType<CodeSystemDef>().ToArray(),
                valueSets = symbols.OfType<ValueSetDef>().ToArray(),
                codes = symbols.OfType<CodeDef>().ToArray(),
                concepts = symbols.OfType<ConceptDef>().ToArray(),
                contexts = symbols.OfType<ContextDef>().ToArray(),
                statements = symbols.OfType<ExpressionDef>().ToArray(),
            };
        }

        private readonly SymbolTable symbolTable = new(null);  // we're a top-level scope

        public ISymbolScope CurrentScope { get; private set; }

        public void EnterScope()
        {
            var newScope = new SymbolTable(CurrentScope);
            CurrentScope = newScope;
        }

        public void ExitScope()
        {
            if (CurrentScope.Parent is null)
                throw new InvalidOperationException("Tried to pop a scope while already at the root scope.");

            CurrentScope = CurrentScope.Parent;
        }

        public bool TryResolveType(string? libraryName, string typeName, out ModelType? result, out string? error)
        {
            ModelType? getModelType(UsingDefSymbol s, string name) =>
                s.Model.TryGetTypeInfoFor(typeName, out var typeInfo) ?
                    new ModelType(s.Model, typeInfo!) : null;

            // If the typename is qualified with a library name, only look in the specified model library.
            if (libraryName is not null)
            {
                if (symbolTable.TryResolveSymbol(libraryName, out var model) && model is UsingDefSymbol usingDef)
                {
                    if (getModelType(usingDef, typeName) is { } modelType)
                        (result, error) = (modelType, null);
                    else
                        (result, error) = (null, $"There is no type named '{typeName}' in model library {libraryName}.");
                }
                else
                    (result, error) = (null, $"There is no model named '{libraryName}'.");

                return error is not null;
            }

            // Else, go over all used models to find it. This could mean we find an ambiguous match.
            var usingDefs = symbolTable.Symbols.OfType<UsingDefSymbol>().ToArray();
            var matches = usingDefs.Select(include => (include, modelType: getModelType(include, typeName)))
                    .Where(r => r.modelType is not null).ToList();

            error = (matches.Count, usingDefs.Length) switch
            {
                (_, 0) => $"Cannot resolve type {typeName} as there are no models referenced in this library.",
                (0, 1) => $"There is no type named '{typeName}' in model library {usingDefs.Single().localIdentifier}.",
                (0, _) => $"There is no type named '{typeName}' in model libraries {string.Join(",", usingDefs.Select(u => u.localIdentifier))}.",
                ( > 1, _) => $"Ambiguous type name '{typeName}', found matches in {string.Join(",", matches.Select(m => m.include.localIdentifier))}.",
                _ => null,
            };

            var success = error is null;
            result = success ? matches.Single().modelType : null;
            return success;

            //static string modelNamesList(IEnumerable<(string uri, string version)> models) =>
            //    string.Join(", ", models.Select(m => $"{m.uri} (version {m.version ?? "unspecified"})"));
        }
    }
}
