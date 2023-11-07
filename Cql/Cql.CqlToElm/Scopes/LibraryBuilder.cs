using Hl7.Cql.Elm;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal class LibraryBuilder : ISymbolScope
    {
        private static readonly VersionedIdentifier schemaIdentifier = new() { id = "urn:hl7-org:elm", version = "r1" };

        public LibraryBuilder(VersionedIdentifier identifier)
        {
            Identifier = identifier;
        }

        public VersionedIdentifier Identifier { get; }

        public ISymbolScope? Parent => null;

        //TODO: This code should go into the loading logic for libraries that are delivered to us
        //as ELM. The loading of these files should be done before compilation starts and errors should
        //not be reported as semantic compile errors in the compiler output, but as errors in a separate
        //loading phase.

        //public static bool TryMakeSymbolForUsing(IModelProvider modelProvider,
        //    UsingDef def, out UsingDefSymbol? symbol, out string? error)
        //{
        //    var model = modelProvider.ModelFromUri(def.uri, def.version);

        //    if (model is not null)
        //    {
        //        error = null;
        //        symbol = new UsingDefSymbol(def, model);
        //        return true;
        //    }
        //    else
        //    {
        //        error = $"Model with uri {def.uri} and version {def.version ?? "<unspecified>"} is not available."
        //        symbol = null;
        //        return false;
        //    }
        //}

        //public static bool TryMakeSymbolForIncludeDef(ILibraryProvider libraryProvider, IncludeDef def,
        //        out IncludeDefSymbol? symbol, out string? error)
        //{
        //    var success = libraryProvider.TryResolveLibrary(def.path, def.version, out var library, out error);
        //    symbol = success ? new IncludeDefSymbol(def, library!) : null;
        //    return success;
        //}

        //public static bool TryBuildFromLibrary(IModelProvider modelProvider, ILibraryProvider libraryProvider, Library source, out string? error)
        //{
        //    var result = new LibrarySymbolTable(source.identifier);

        //    foreach (var @using in source.usings)
        //    {
        //        if (TryMakeSymbolForUsing(modelProvider, @using, out var symbol, out var error))
        //        {
        //            if(!result.TryAdd(symbol!, out error))
        //            {

        //            }
        //        }
        //        else
        //            throw new InvalidOperationException(error);
        //    }
        //    result.Add(new UsingDefSymbol(new UsingDef { localIdentifier = "System" }, Model.ModelInfo.SystemModel));

        //}

        public Library Build()
        {
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

        private readonly Dictionary<string, IDefinitionElement> symbols = new();

        public bool TryAdd(IDefinitionElement symbol)
        {
            throw new System.NotImplementedException();
        }

        private readonly List<UsingDefSymbol> includedModels = new();

        public bool TryResolveSymbol(string identifier, out IDefinitionElement? symbol)
        {
            // First, resolve the symbol in the current scope.
            if (symbols.TryGetValue(identifier, out symbol))
                return true;

            // Now, also try to find it in the included models. Since there may be more than
            // one model included, this could result in an ambiguous match.
            var matches = new List<ModelType>();

            // For each of the used models in the library, now resolve the type.
            foreach (var model in includedModels)
            {
                if (model.TryResolveSymbol(identifier, out var modelType))
                    matches.Add((ModelType)modelType!);
            }

            switch (matches.Count)
            {
                case 0:
                    symbol = null;
                    return false;
                case 1:
                    symbol = matches.Single();
                    return true;
                default:
                    symbol = matches.First();
                    return false;
            }
        }
    }
}
