/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;

namespace Hl7.Cql.Elm
{
    /// <summary>
    /// Represents a symbol in a library or nested construct that can be referenced by name.
    /// </summary>
    internal interface ISymbol
    {
        /// <summary>
        /// The visibility of the symbol from outside the library.
        /// </summary>
        AccessModifier Access { get; }

        /// <summary>
        /// The name of the symbol.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Converts a definition symbol to its reference counterpart.
        /// </summary>
        /// <param name="libraryName">The qualifier part of the identifier found at the point of reference.</param>
        /// <returns></returns>
        Element ToRef(string libraryName);
    }

    public partial class ValueSetDef : ISymbol
    {
        AccessModifier ISymbol.Access => accessLevel;

        string ISymbol.Name => name;

        Element ISymbol.ToRef(string libraryName) => new ValueSetRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(SystemTypes.ValueSetType);
    }

    public partial class CodeSystemDef : ISymbol
    {
        AccessModifier ISymbol.Access => accessLevel;

        string ISymbol.Name => name;

        Element ISymbol.ToRef(string libraryName) => new CodeSystemRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(SystemTypes.CodeSystemType);
    }

    public partial class ConceptDef : ISymbol
    {
        AccessModifier ISymbol.Access => accessLevel;

        string ISymbol.Name => name;

        Element ISymbol.ToRef(string libraryName) => new ConceptRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(SystemTypes.ConceptType);
    }

    public partial class CodeDef : ISymbol
    {
        AccessModifier ISymbol.Access => accessLevel;

        string ISymbol.Name => name;

        Element ISymbol.ToRef(string libraryName) => new CodeRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(SystemTypes.CodeType);
    }

    public partial class ParameterDef : ISymbol
    {
        AccessModifier ISymbol.Access => accessLevel;

        string ISymbol.Name => name;

        Element ISymbol.ToRef(string libraryName) => new ParameterRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(parameterTypeSpecifier);
    }

    public partial class ExpressionDef : ISymbol
    {
        AccessModifier ISymbol.Access => accessLevel;

        string ISymbol.Name => name;

        Element ISymbol.ToRef(string libraryName) => new ExpressionRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(resultTypeSpecifier);
    }

    public partial class FunctionDef : ISymbol
    {
        AccessModifier ISymbol.Access => accessLevel;

        string ISymbol.Name => name;

        Element ISymbol.ToRef(string libraryName) => new FunctionRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(resultTypeSpecifier);
    }

    public partial class ContextDef : ISymbol
    {
        // ContextDefs are represented by expressions with the same name in the symbol table,
        // so for ContextDefs themselves, we will return an "unresolvable" name.
        string ISymbol.Name => $"_context_{this.name}_";

        AccessModifier ISymbol.Access => AccessModifier.Private;

        // Since there is no way to reference a context definition, we will throw an exception
        // if we ever try to do that.
        Element ISymbol.ToRef(string libraryName) =>
            throw new InvalidOperationException("There is no reference type for a context definition."),
    }

    public partial class OperandDef : ISymbol
    {
        AccessModifier ISymbol.Access => AccessModifier.Private;

        string ISymbol.Name => name;

        Element ISymbol.ToRef(string libraryName) => new OperandRef
        {
            name = name,
        }.WithId().WithResultType(operandTypeSpecifier);
    }

    public partial class AliasedQuerySource : ISymbol
    {
        AccessModifier ISymbol.Access => AccessModifier.Private;

        string ISymbol.Name => alias;

        Element ISymbol.ToRef(string libraryName) => new AliasRef
        {
            name = alias,
        }.WithId().WithResultType(resultTypeSpecifier);
    }

    public partial class QueryLetRef : ISymbol
    {
        AccessModifier ISymbol.Access => AccessModifier.Private;

        string ISymbol.Name => name;

        Element ISymbol.ToRef(string libraryName) => new QueryLetRef
        {
            name = name,
        }.WithId().WithResultType(resultTypeSpecifier);
    }
}
