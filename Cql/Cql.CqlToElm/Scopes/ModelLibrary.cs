using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// A class that represents a <see cref="Model.ModelInfo"/> as a resolvable symbol in an <see cref="ISymbolScope"/>.
    /// </summary>
    /// <remarks>The ModelLibrary is itself a scope for the <see cref="Model.TypeInfo"/> contained in the ModelInfo.</remarks>
    internal record ModelLibrary : Element, ISymbol, ISymbolScope
    {
        public static bool FromName(IModelProvider modelProvider,
            string modelName, string modelVersion, string? localIdentifier,
            out ModelLibrary? symbol, out string? error)
        {
            var model = modelProvider.ModelFromName(modelName, modelVersion);

            if (model is not null)
            {
                error = null;
                symbol = new ModelLibrary(localIdentifier ?? modelName, model);
                return true;
            }
            else
            {
                error = $"Model {modelName} version {modelVersion ?? "<unspecified>"} is not available.";
                symbol = null;
                return false;
            }
        }


        public ModelLibrary(string localIdentifier, Model.ModelInfo model)
        {
            Model = model;
            Name = localIdentifier;
        }

        public Model.ModelInfo Model { get; }

        public AccessModifier Access => AccessModifier.Private;

        public string Name { get; }

        public ISymbolScope? Parent => null;

        public bool TryAdd(ISymbol _) => throw new InvalidOperationException("Model libraries cannot be added to.");

        public bool TryResolveSymbol(string identifier, AccessModifier _, out ISymbol? symbol)
        {
            var success = Model.TryGetTypeInfoFor(identifier, out var typeInfo);
            symbol = typeInfo is not null ? new ModelType(Model, typeInfo) : null;

            return success;
        }

        public UsingDef ToUsingDef()
        {
            return new UsingDef
            {
                uri = Model.url,
                version = Model.version,
                localIdentifier = Name,
            }.WithId();
        }
    }
}
