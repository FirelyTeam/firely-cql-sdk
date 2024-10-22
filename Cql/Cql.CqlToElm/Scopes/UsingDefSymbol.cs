using Hl7.Cql.CqlToElm.Scopes;
using Hl7.Cql.Elm;
using Hl7.Cql.Model;
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
    internal class UsingDefSymbol : UsingDef, IDefinitionElement
    {
        public UsingDefSymbol(string localIdentifier, string? version, ModelDefinition model)
        {
            Model = model;

            this.localIdentifier = localIdentifier;
            uri = model.Url;
            this.version = version;
            Symbols = new(uri, null);
        }

        public ModelDefinition Model { get; }

        public SymbolTable Symbols { get; }

        public Expression ToRef(string? _) => new UsingRef(this);
    }

    /// <summary>
    /// This class is used to represent a reference to a model library. Although it does not exist in ELM officially,
    /// we introduce it here to allow the term parsing rules to return a reference to a model, which we can then
    /// handle in the higher-level parsing rules. This class is not supposed to be externally visible, so should never be serialized
    /// into an ELM library.
    /// </summary>
    internal class UsingRef : Expression
    {
        public UsingRef(UsingDefSymbol usingDef)
        {
            UsingDef = usingDef;
        }

        public UsingDefSymbol UsingDef { get; }
    }
}
