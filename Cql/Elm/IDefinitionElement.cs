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
    /// Represents an ELM Element that is used as a definition in a library or other resolution scope.
    /// </summary>
    public interface IDefinitionElement
    {
        /// <summary>
        /// The visibility of the definition within a resolution scope.
        /// </summary>
        AccessModifier Access { get; }

        /// <summary>
        /// The name of the definition by which it can be referenced.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Converts a definition symbol to its reference counterpart.
        /// </summary>
        /// <param name="libraryName">The qualifier part of the identifier found at the point of reference.</param>
        /// <returns></returns>
        Expression ToRef(string? libraryName);
    }

    public partial class ValueSetDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => accessLevel;

        string IDefinitionElement.Name => name;

        Expression IDefinitionElement.ToRef(string? libraryName) => new ValueSetRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(SystemTypes.ValueSetType);
    }

    public partial class CodeSystemDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => accessLevel;

        string IDefinitionElement.Name => name;

        Expression IDefinitionElement.ToRef(string? libraryName) => new CodeSystemRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(SystemTypes.CodeSystemType);
    }

    public partial class ConceptDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => accessLevel;

        string IDefinitionElement.Name => name;

        Expression IDefinitionElement.ToRef(string? libraryName) => new ConceptRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(SystemTypes.ConceptType);
    }

    public partial class CodeDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => accessLevel;

        string IDefinitionElement.Name => name;

        Expression IDefinitionElement.ToRef(string? libraryName) => new CodeRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(SystemTypes.CodeType);
    }

    public partial class ParameterDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => accessLevel;

        string IDefinitionElement.Name => name;

        Expression IDefinitionElement.ToRef(string? libraryName) => new ParameterRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(parameterTypeSpecifier);
    }

    public partial class ExpressionDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => accessLevel;

        string IDefinitionElement.Name => name;

        Expression IDefinitionElement.ToRef(string? libraryName) => new ExpressionRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(resultTypeSpecifier);
    }

    public partial class FunctionDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => accessLevel;

        string IDefinitionElement.Name => name;

        Expression IDefinitionElement.ToRef(string? libraryName) => new FunctionRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(resultTypeSpecifier);
    }

    public partial class ContextDef : IDefinitionElement
    {
        // ContextDefs are represented by expressions with the same name in the symbol table,
        // so for ContextDefs themselves, we will return an "unresolvable" name.
        string IDefinitionElement.Name => $"_context_{this.name}_";

        public bool IsUnfiltered => name == "Unfiltered";

        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        // Since there is no way to reference a context definition, we will throw an exception
        // if we ever try to do that.
        Expression IDefinitionElement.ToRef(string? libraryName) =>
            throw new InvalidOperationException("There is no reference type for a context definition.");
    }

    public partial class OperandDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        string IDefinitionElement.Name => name;

        Expression IDefinitionElement.ToRef(string? libraryName) => new OperandRef
        {
            name = name,
        }.WithId().WithResultType(operandTypeSpecifier);
    }

    public partial class AliasedQuerySource : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        string IDefinitionElement.Name => alias;

        Expression IDefinitionElement.ToRef(string? libraryName) => new AliasRef
        {
            name = alias,
        }.WithId().WithResultType(resultTypeSpecifier);
    }

    public partial class LetClause : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        string IDefinitionElement.Name => identifier;

        Expression IDefinitionElement.ToRef(string? _) => new QueryLetRef
        {
            name = identifier,
        }.WithId().WithResultType(resultTypeSpecifier);
    }

    public partial class UsingDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        string IDefinitionElement.Name => localIdentifier;

        Expression IDefinitionElement.ToRef(string? _) =>
            throw new InvalidOperationException("There is no reference type for a using statement.");
    }

    public partial class IncludeDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        string IDefinitionElement.Name => localIdentifier;

        Expression IDefinitionElement.ToRef(string? _) =>
            throw new InvalidOperationException("There is no reference type for an include statement.");
    }
}
