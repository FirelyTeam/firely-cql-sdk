using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// A class extends <see cref="IncludeDef"/> with an actual reference to a Library, so it can function as a symbol table
    /// to resolve identifiers within the included library.
    /// </summary>
    internal class IncludeDefSymbol : IncludeDef, IDefinitionElement
    {
        public IncludeDefSymbol(string localIdentifier, ReferencedLibrary library)
        {
            Library = library;

            this.localIdentifier = localIdentifier;
            path = library.Source.identifier.id;
            version = library.Source.identifier.version;
        }

        public ReferencedLibrary Library { get; }

        public Expression ToRef(string? _) => new IncludeRef(this);
    }

    /// <summary>
    /// This class is used to represent a reference to an included library. Although it does not exist in ELM officially,
    /// we introduce it here to allow the term parsing rules to return a reference to the included library, which we can then
    /// handle in the higher-level parsing rules. This class is not supposed to be externally visible, so should never be serialized
    /// into an ELM library.
    /// </summary>
    internal class IncludeRef : Expression
    {
        public IncludeRef(IncludeDefSymbol includeDef)
        {
            IncludeDef = includeDef;
        }

        public IncludeDefSymbol IncludeDef { get; }
    }
}
