using Hl7.Cql.Elm;
using System;
using System.Xml.Serialization;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// A class extends <see cref="UsingDef"/> with a reference to a ModelInfo, so it can function as a symbol table
    /// to resolve identifiers for types within the used model.
    /// </summary>
    [Serializable]
    [XmlType(IncludeInSchema = false, TypeName = nameof(UsingDef), Namespace = "urn:hl7-org:elm:r1")]
    internal class UsingDefSymbol : UsingDef, ISymbolScope
    {
        public UsingDefSymbol(string localIdentifier, Model.ModelInfo model)
        {
            Model = model;

            this.localIdentifier = localIdentifier;
            this.uri = model.url;
            this.version = model.version;
        }

        public Model.ModelInfo Model { get; }

        public ISymbolScope? Parent => null;

        public bool TryAdd(IDefinitionElement _) => throw new InvalidOperationException("Model libraries cannot be added to, they are read-only.");

        public bool TryResolveSymbol(string identifier, out IDefinitionElement? symbol)
        {
            var success = Model.TryGetTypeInfoFor(identifier, out var typeInfo);

            if (success)
            {
                symbol = new ModelType(Model, typeInfo!);
                return true;
            }
            else
            {
                symbol = null;
                return false;
            }
        }
    }
}
