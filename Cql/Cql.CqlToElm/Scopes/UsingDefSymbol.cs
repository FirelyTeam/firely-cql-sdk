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
            uri = model.Uri;
            this.version = version;
            Symbols = new(uri, null);
            AddSymbols();
        }

        public ModelDefinition Model { get; }

        public SymbolTable Symbols { get; }

        public Expression ToRef(string? _) => new UsingRef(this);

        // Adds all model declarations to the symbol table
        private void AddSymbols()
        {
            foreach(var kvp in Model.TypeDefinitions)
            {
                var typeDef = new TypeDef()
                {
                    name = kvp.Value.Name,
                    uri = Model.Uri,
                    accessLevel = kvp.Value.Access switch
                    {
                        Cql.Model.AccessModifier.Public => Elm.AccessModifier.Public,
                        _ => Elm.AccessModifier.Private
                    },
                    baseType = kvp.Value.BaseType switch
                    {
                        { } => TypeBridge.ToElmSpecifier(kvp.Value.BaseType.ToTypeSpecifier()),
                        _ => null
                    },
                };
                if (!Symbols.TryAdd(typeDef))
                    throw new InvalidOperationException($"Could not add type {typeDef.Name} to the symbol table.");
            }
            foreach(var kvp in Model.Contexts) { 
                var contextDef = new ContextDefinitionSymbol(kvp.Value);
                if (!Symbols.TryAdd(contextDef))
                    throw new InvalidOperationException($"Could not add context {contextDef.Name} to the symbol table.");
            }
        }

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
