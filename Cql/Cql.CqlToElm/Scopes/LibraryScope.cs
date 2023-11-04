using Hl7.Cql.Elm;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal partial class LibraryScope : ISymbolScope
    {
        private static readonly VersionedIdentifier schemaIdentifier = new() { id = "urn:hl7-org:elm", version = "r1" };

        public LibraryScope(VersionedIdentifier identifier)
        {
            Identifier = identifier;
        }

        public VersionedIdentifier Identifier { get; }

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

        public Library BuildLibrary()
        {
            return new Library
            {
                identifier = Identifier,
                schemaIdentifier = schemaIdentifier,
                usings = symbols.Values.OfType<ModelLibrary>().Select(uds => uds.ToUsingDef()).ToArray(),
                includes = symbols.Values.OfType<IncludedLibrary>().Select(uds => uds.ToIncludeDef()).ToArray(),
                parameters = symbols.Values.OfType<ParameterDef>().ToArray(),
                codeSystems = symbols.Values.OfType<CodeSystemDef>().ToArray(),
                valueSets = symbols.Values.OfType<ValueSetDef>().ToArray(),
                codes = symbols.Values.OfType<CodeDef>().ToArray(),
                concepts = symbols.Values.OfType<ConceptDef>().ToArray(),
                contexts = symbols.Values.OfType<ContextDef>().ToArray(),
                statements = symbols.Values.OfType<ExpressionDef>().ToArray(),
            };
        }

        public IReadOnlyCollection<ModelLibrary> Models =>
            symbols.Values.OfType<ModelLibrary>().ToArray();

        private readonly Dictionary<string, ISymbol> symbols = new();

        public ISymbolScope? Parent => null;   // this kind of symbol table is always the root.

        public bool TryResolveSymbol(string identifier, AccessModifier access, out ISymbol? symbol) =>
             symbols.TryGetValue(identifier, out symbol) && access >= symbol.Access;

        public bool TryAdd(ISymbol symbol) => symbols.TryAdd(symbol.Name, symbol);
    }
}
