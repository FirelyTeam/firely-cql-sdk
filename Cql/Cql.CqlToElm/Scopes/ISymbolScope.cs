using Hl7.Cql.Elm;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.CqlToElm
{
    internal interface ISymbolScope: IEnumerable<IDefinitionElement>, IDisposable
    {
        string Name { get; }

        /// <summary>
        /// The enclosing scope, if any.
        /// </summary>
        ISymbolScope? Parent { get; }

        /// <summary>
        /// Adds a symbol to the scope.
        /// </summary>
        /// <returns>true if the symbol was added, false if it already existed in the symbol table.</returns>
        bool TryAdd(IDefinitionElement symbol);

        /// <summary>
        /// Looks in the scope and its parent scopes and returns all symbols that match the identifier and access modifier.
        /// </summary>
        /// <returns>A list of symbols found, including the (nested) scope it was found in.</returns>
        bool TryResolveSymbol(string identifier, [NotNullWhen(true)] out IDefinitionElement? symbol);

        /// <summary>
        /// Looks in the scope and its parent scopes and returns all functions that match the identifier and access modifier.
        /// </summary>
        /// <returns>A list of functions found, including the (nested) scope it was found in.</returns>
        bool TryResolveFunction(string identifier, [NotNullWhen(true)] out IFunctionElement? symbol);

        /// <summary>
        /// Looks in scope and parent scopes for fluent functions.  This function will look into referenced libraries in any scope
        /// to identify fluent functions also.
        /// </summary>
        bool TryResolveFluentFunction(string identifier, [NotNullWhen(true)] out IFunctionElement? symbol);


        /// <summary>
        /// Looks in scope and referenced models for types.
        /// </summary>
        /// <param name="identifier">The name of the type.</param>
        /// <param name="type">The type, if found.  Otherwise, <see langword="null"/>.</param>
        /// <returns><see langword="true"/> if found; otherwise, <see langword="false"/>.</returns>
        bool TryResolveType(string identifier, [NotNullWhen(true)] out TypeDef? type);

        /// <summary>
        /// Gets any referenced libraries in this scope, including those in <see cref="Parent"/> if defined.
        /// </summary>
        IEnumerable<ReferencedLibrary> ReferencedLibraries { get; }

        /// <summary>
        /// Creates a child scope for which this scope is its <see cref="Parent"/>.
        /// </summary>
        /// <returns>A new scope whose <see cref="Parent"/> is this scope.</returns>
        ISymbolScope EnterScope(string name);
    }
}
