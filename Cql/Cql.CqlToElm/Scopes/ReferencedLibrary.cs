/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Scopes;
using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// A class extends <see cref="IncludeDef"/> with an actual reference to a Library, so it can function as a symbol table
    /// to resolve identifiers within the included library.
    /// </summary>
    internal class ReferencedLibrary : IncludeDef, IDefinitionElement
    {
        public ReferencedLibrary(string localIdentifier, VersionedIdentifier id, SymbolTable symbols)
        {
            this.localIdentifier = localIdentifier;
            path = id.id;
            version = id.version;
            Id = id;
            Symbols = symbols;
        }
        public VersionedIdentifier Id { get; }
        public ISymbolScope Symbols { get; }

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
        public IncludeRef(ReferencedLibrary includeDef)
        {
            IncludeDef = includeDef;
        }

        public ReferencedLibrary IncludeDef { get; }
    }
}
