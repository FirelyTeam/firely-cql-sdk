using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// A class extends <see cref="IncludeDef"/> with an actual reference to a Library, so it can function as a symbol table
    /// to resolve identifiers within the included library.
    /// </summary>
    [Serializable]
    [XmlType(IncludeInSchema = false, TypeName = nameof(IncludeDef), Namespace = "urn:hl7-org:elm:r1")]
    internal class IncludeDefSymbol : IncludeDef, ISymbolScope
    {
        public IncludeDefSymbol(string localIdentifier, Library library)
        {
            Library = library;

            this.localIdentifier = localIdentifier;
            path = library.identifier.id;
            version = library.identifier.version;

            symbols = new(loadLibrary);
        }

        private readonly Lazy<Dictionary<string, IDefinitionElement>> symbols;

        private Dictionary<string, IDefinitionElement> loadLibrary()
        {
            var result = new Dictionary<string, IDefinitionElement>();

            add(Library.usings);
            add(Library.includes);
            add(Library.parameters);
            add(Library.codeSystems);
            add(Library.valueSets);
            add(Library.codes);
            add(Library.concepts);
            add(Library.contexts);
            add(Library.statements);

            return result;

            void add(IEnumerable<IDefinitionElement> symbols)
            {
                foreach (var symbol in symbols)
                {
                    if (result.ContainsKey(symbol.Name))
                        throw new InvalidOperationException($"Duplicate symbol {symbol.Name} in library {Library.NameAndVersion}.");
                    else
                    {
                        if (symbol.IsVisible(AccessModifier.Public))
                            result.Add(symbol.Name, symbol);
                    }
                }
            }
        }

        public Library Library { get; }

        public ISymbolScope? Parent => null;

        public bool TryAdd(IDefinitionElement symbol) => throw new InvalidOperationException("Referenced libraries are read-only.");

        public bool TryResolveSymbol(string identifier, out IDefinitionElement? symbol) =>
            symbols.Value.TryGetValue(identifier, out symbol);
    }
}

