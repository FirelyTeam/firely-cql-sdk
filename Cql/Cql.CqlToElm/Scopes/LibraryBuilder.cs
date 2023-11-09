using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal class LibraryBuilder
    {
        private static readonly VersionedIdentifier schemaIdentifier = new() { id = "urn:hl7-org:elm", version = "r1" };

        public LibraryBuilder(VersionedIdentifier identifier)
        {
            Identifier = identifier;
            CurrentScope = symbols;
        }

        public VersionedIdentifier Identifier { get; }


        public Library Build()
        {
            var localSymbols = symbols.Symbols;

            return new Library
            {
                identifier = Identifier,
                schemaIdentifier = schemaIdentifier,
                usings = usingDefs.ToArray(),
                includes = includeDefs.ToArray(),
                parameters = localSymbols.OfType<ParameterDef>().ToArray(),
                codeSystems = localSymbols.OfType<CodeSystemDef>().ToArray(),
                valueSets = localSymbols.OfType<ValueSetDef>().ToArray(),
                codes = localSymbols.OfType<CodeDef>().ToArray(),
                concepts = localSymbols.OfType<ConceptDef>().ToArray(),
                contexts = localSymbols.OfType<ContextDef>().ToArray(),
                statements = localSymbols.OfType<ExpressionDef>().ToArray(),
            };
        }

        private readonly LocalSymbolTable symbols = new(null);

        public ISymbolScope CurrentScope { get; private set; }

        public void EnterScope()
        {
            var newScope = new LocalSymbolTable(CurrentScope);
            CurrentScope = newScope;
        }

        public void ExitScope()
        {
            if (CurrentScope.Parent is null)
                throw new InvalidOperationException("Tried to pop a scope while already at the root scope.");

            CurrentScope = CurrentScope.Parent;
        }

        private readonly Dictionary<string, UsingDefSymbol> usingDefs = new();
        private readonly Dictionary<string, IncludeDefSymbol> includeDefs = new();

        internal bool TryAddIncludeDef(IncludeDefSymbol include) =>
            includeDefs.TryAdd(include.localIdentifier, include);

        internal bool TryAddUsingDef(UsingDefSymbol usingDef) =>
            usingDefs.TryAdd(usingDef.localIdentifier, usingDef);

        /// <summary>
        /// </summary>
        /// <returns></returns>
        /// <remarks> Definitions in included libraries must *always* be referred to by qualifying their
        /// name with the name of the library they are defined in.</remarks>
        internal bool TryResolveIncludedDefinition(string libraryName, string name, out IDefinitionElement? symbol, out string? error)
        {
            if (includeDefs.TryGetValue(libraryName, out var library))
            {
                if (library.TryResolveDefinition(name, out symbol))
                    error = null;
                else
                    error = $"Cannot find {name} in library {library.NameAndVersion}";
            }
            else
            {
                (symbol, error) = (null, $"There is no included library named '{libraryName}'.");
            }

            return error is not null;
        }

        internal bool TryResolveType(string? libraryName, string typeName, out ModelType? result, out string? error)
        {
            // If the typename is qualified with a library name, only look in the specified model library.
            if (libraryName is not null)
            {
                if (usingDefs.TryGetValue(libraryName, out var model))
                {
                    if (model.TryResolveType(typeName, out result))
                        error = null;
                    else
                        error = $"There is no type named '{typeName}' in model library {libraryName}.";
                }
                else
                {
                    (result, error) = (null, $"There is no model named '{libraryName}'.");
                }

                return error is not null;
            }

            var matches = usingDefs.Values.Select(include => (success: include.TryResolveType(typeName, out var symbol), symbol))
                    .Where(r => r.success).Select(r => r.symbol!).ToList();

            error = (matches.Count, usingDefs.Count) switch
            {
                (_, 0) => $"Cannot resolve type {typeName} as there are no models referenced in this library.",
                (0, 1) => $"There is no type named '{typeName}' in model library {libraryName}.",
                (0, _) => $"There is no type named '{typeName}' in model libraries {string.Join(",", usingDefs.Keys)}.",
                ( > 1, _) => $"Ambiguous type name '{typeName}', found matches in {modelNamesList(matches.Select(m => (m.Model.url, m.Model.version)))}.",
                _ => null,
            };

            var success = error is null;
            result = success ? matches.FirstOrDefault() : null;
            return success;

            static string modelNamesList(IEnumerable<(string uri, string version)> models) =>
                string.Join(", ", models.Select(m => $"{m.uri} (version {m.version ?? "unspecified"})"));
        }

    }
}
