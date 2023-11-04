using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Cql.CqlToElm
{
    internal class ConverterContext
    {
        public ConverterContext()
        {
        }

        private readonly List<Library> Libraries = new List<Library>();

        public Library? GetLibrary(string name, string version) =>
            Libraries.SingleOrDefault(l => l.identifier.id == name && l.identifier.version == version);

        public Library? GetLibrary(string name) =>
            Libraries.SingleOrDefault(l => l.identifier.id == name);

        public void AddLibrary(Library library)
        {
            if (GetLibrary(library.identifier.id, library.identifier.version) == null)
                Libraries.Add(library);
            else throw new ArgumentException($"Library already exists.", nameof(library));
        }

        public ISymbolScope? CurrentScope { get; private set; }

        public void EnterScope(ISymbolScope scope)
        {
            CurrentScope = scope;
        }

        public void ExitScope()
        {
            CurrentScope = CurrentScope?.Parent;
        }
    }
}
