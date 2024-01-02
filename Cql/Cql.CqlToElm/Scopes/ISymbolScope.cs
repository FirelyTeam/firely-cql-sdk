using Hl7.Cql.Elm;

namespace Hl7.Cql.CqlToElm
{
    internal interface ISymbolScope
    {
        ///// <summary>
        ///// The name of the scope, used for error messages, e.g. when resolution results in ambiguous matches.
        ///// </summary>
        //string Name { get; }

        /// <summary>
        /// The enclosing scope, if any.
        /// </summary>
        ISymbolScope? Parent { get; }

        ///// <summary>
        ///// Returns all symbols registered in this scope.
        ///// </summary>
        //IEnumerable<IDefinitionElement> Symbols { get; }

        /// <summary>
        /// Adds a symbol to the scope.
        /// </summary>
        /// <returns>true if the symbol was added, false if it already existed in the symbol table.</returns>
        bool TryAdd(IDefinitionElement symbol);

        ///// <summary>
        ///// Adds a nested scope to the symbol table. A nested scope is a scope that is defined within the current scope,
        ///// and the current scope will try to resolve symbols both in itself and the nested scope(s).
        ///// </summary>
        ///// <remarks>If resolution finds the same symbol identifier in the scope and nested scopes, resolution will fail
        ///// and report a message about the ambiguous match.</remarks>
        //bool TryAddNestedScope(ISymbolScope scope);

        /// <summary>
        /// Looks in the scope and its nested scopes and returns all symbols that match the identifier and access modifier.
        /// </summary>
        /// <returns>A list of symbols found, including the (nested) scope it was found in.</returns>
        bool TryResolveSymbol(string identifier, out IDefinitionElement? symbol);
    }
}
