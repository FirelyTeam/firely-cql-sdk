using Hl7.Cql.Elm;
using System;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// Represents a <see cref="Library"/> as a resolvable symbol in an <see cref="ISymbolScope"/>.
    /// </summary>
    internal class IncludedLibrary : Element, ISymbol, ISymbolScope
    {
        public IncludedLibrary(string localIdentifier, LibraryScope library)
        {
            Library = library;
            Name = localIdentifier;
        }

        public LibraryScope Library { get; }

        public AccessModifier Access => AccessModifier.Private;

        public string Name { get; }

        public ISymbolScope? Parent => Library.Parent;

        public IncludeDef ToIncludeDef() => new IncludeDef()
        {
            path = Library.Identifier.id,
            version = Library.Identifier.version,
            localIdentifier = Name,
        }.WithLocator(locator);

        public Element ToRef(string libraryName) =>
             throw new InvalidOperationException("There is no reference type for a library include statement.");

        public bool TryAdd(ISymbol symbol) => Library.TryAdd(symbol);

        public bool TryResolveSymbol(string identifier, AccessModifier access, out ISymbol? symbol) =>
            Library.TryResolveSymbol(identifier, access, out symbol);
    }
}

