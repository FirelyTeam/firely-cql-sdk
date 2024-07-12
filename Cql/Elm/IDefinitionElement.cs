/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Linq;
using System.Xml;

namespace Hl7.Cql.Elm
{
    /// <summary>
    /// Represents an ELM element that is used a a reference to a definition in a library.
    /// </summary>
    internal interface IReferenceElement : IGetName
    {
    }

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

        /// <summary>
        /// Adds an error to this element.
        /// </summary>
        /// <param name="error">The error.</param>
        /// <returns><see langword="this" /></returns>
        IDefinitionElement AddError(CqlToElmError error);
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

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);
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

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);
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

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

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

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

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

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

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

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    public partial class FunctionDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => accessLevel;

        string IDefinitionElement.Name => name;

        Expression IDefinitionElement.ToRef(string? libraryName) => ToRef(libraryName);

        internal FunctionRef ToRef(string? libraryName) => new FunctionRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(resultTypeSpecifier ?? throw new InvalidOperationException("Missing result type specifier for function ref"));

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

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

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    public partial class OperandDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        string IDefinitionElement.Name => name;

        Expression IDefinitionElement.ToRef(string? libraryName) => new OperandRef
        {
            name = name,
        }.WithId().WithResultType(operandTypeSpecifier);

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    public partial class AliasedQuerySource : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        string IDefinitionElement.Name => alias;

        Expression IDefinitionElement.ToRef(string? libraryName)
        {
            TypeSpecifier aliasType;
            if (resultTypeSpecifier is ListTypeSpecifier list)
                aliasType = list.elementType;
            else
                aliasType = resultTypeSpecifier;
            if (aliasType is null)
                throw new InvalidOperationException($"Alias type is null");
            var aliasRef = new AliasRef { name = alias }.WithResultType(aliasType);
            return aliasRef;
        }

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    public partial class LetClause : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        string IDefinitionElement.Name => identifier;

        Expression IDefinitionElement.ToRef(string? _) => new QueryLetRef
        {
            name = identifier,
        }.WithId().WithResultType(resultTypeSpecifier);

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    public partial class UsingDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        string IDefinitionElement.Name => localIdentifier;

        Expression IDefinitionElement.ToRef(string? _) =>
            throw new InvalidOperationException("There is no reference type for a using statement.");

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    public partial class IncludeDef : IDefinitionElement
    {
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        string IDefinitionElement.Name => localIdentifier;

        Expression IDefinitionElement.ToRef(string? _) =>
            throw new InvalidOperationException("There is no reference type for an include statement.");

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    /// <summary>
    /// Defines a function with multiple overloads.
    /// </summary>
    public sealed class OverloadedFunctionDef: IDefinitionElement
    {
        public static OverloadedFunctionDef Create(params FunctionDef[] functions)
        {
            if (functions.Length < 2)
                throw new ArgumentException($"Overloads must have at least two functions provided.", nameof(functions));
            var names = functions.Select(fd => fd.name).Distinct().ToArray();
            if (names.Length > 1)
                throw new ArgumentException($"All functions in an overload must have the same name. Found {string.Join(", ", names)}", nameof(functions));
            if (functions.Any(f => f.resultTypeSpecifier is null))
                throw new ArgumentException("At least one function is missing a result type specifier.");
            var accessLevel = functions.Select(fd => fd.accessLevel).Min(); // public < private; any public overload makes this public
            return new OverloadedFunctionDef(functions, names[0], accessLevel);
        }

        public static OverloadedFunctionDef Create(params IDefinitionElement[] elements)
        {
#if DEBUG
            for (int i = 0; i < elements.Length; i++)
                if (elements[i] is not FunctionDef && elements[i] is not OverloadedFunctionDef)
                    throw new ArgumentException($"Only functions and overloads can be passed to this method.", nameof(elements));
            if (elements.Select(e => e.Name).Distinct().Count() != 1)
                throw new ArgumentException($"All functions should have the same name.", nameof(elements));
#endif
            var allFunctions = elements
                .OfType<OverloadedFunctionDef>()
                .SelectMany(ofd => ofd.Functions)
                .Concat(elements.OfType<FunctionDef>())
                .ToArray();
            var overload = Create(allFunctions);
            return overload;
        }


        public FunctionDef[] Functions { get; }

        public string Name { get; }
        public AccessModifier Access { get; }

        private OverloadedFunctionDef(FunctionDef[] functions,
            string name,
            AccessModifier access)
        {
            Functions = functions;
            Name = name;
            Access = access;
        }

        Expression IDefinitionElement.ToRef(string? libraryName) => ToRef(libraryName);

        internal FunctionRef ToRef(string? libraryName) => throw new NotSupportedException($"Refs cannot be created until the overload is resolved.");

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => throw new NotSupportedException("An overloaded def cannot have an error.");
    }
}