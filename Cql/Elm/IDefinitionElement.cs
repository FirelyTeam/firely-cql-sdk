/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Hl7.Cql.Elm
{
    /// <summary>
    /// Represents an ELM element that is used as a reference to a definition in a library.
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

    /// <summary>
    /// Represents a function-typed element.
    /// </summary>
    public interface IFunctionElement : IDefinitionElement
    {
    }
    public interface IHasSignature : IFunctionElement
    {
        IEnumerable<OperandDef> Operands { get; }
        TypeSpecifier ResultTypeSpecifier { get; }
        bool Fluent { get; }
        string Library { get; }
    }

    public partial class ValueSetDef : IDefinitionElement
    {
        [JsonIgnore]
        AccessModifier IDefinitionElement.Access => accessLevel;

        [JsonIgnore]
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
        [JsonIgnore]
        AccessModifier IDefinitionElement.Access => accessLevel;

        [JsonIgnore]
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
        [JsonIgnore]
        AccessModifier IDefinitionElement.Access => accessLevel;

        [JsonIgnore]
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
        [JsonIgnore]
        AccessModifier IDefinitionElement.Access => accessLevel;

        [JsonIgnore]
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

        [JsonIgnore]
        string IDefinitionElement.Name => name;

        Expression IDefinitionElement.ToRef(string? libraryName) => new ParameterRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(parameterTypeSpecifier);

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    /// <summary>
    /// Describes a non-functional statement, e.g.:
    /// define foo: true
    /// </summary>
    public interface IExpressionElement : IDefinitionElement { }

    public partial class ExpressionDef : IExpressionElement
    {
        [JsonIgnore]
        AccessModifier IDefinitionElement.Access => accessLevel;

        [JsonIgnore]
        string IDefinitionElement.Name => name;

        Expression IDefinitionElement.ToRef(string? libraryName) => new ExpressionRef
        {
            libraryName = libraryName,
            name = name,
        }.WithId().WithResultType(resultTypeSpecifier);

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    public partial class FunctionDef : IFunctionElement, IHasSignature
    {
        [JsonIgnore]
        AccessModifier IDefinitionElement.Access => accessLevel;

        [JsonIgnore]
        string IDefinitionElement.Name => name;

        [JsonIgnore]
        [XmlIgnore]
        public IEnumerable<OperandDef> Operands => operand ?? Enumerable.Empty<OperandDef>();

        [JsonIgnore]
        [XmlIgnore]
        public TypeSpecifier ResultTypeSpecifier => resultTypeSpecifier!;

        [JsonIgnore]
        [XmlIgnore]
        public bool Fluent => fluentSpecified && fluent;

        [JsonIgnore]
        [XmlIgnore]
        public virtual string Library => "";

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
        [JsonIgnore]
        string IDefinitionElement.Name => $"$context:{this.name}";

        [JsonIgnore]
        [XmlIgnore]
        public bool IsUnfiltered => name == "Unfiltered";

        [JsonIgnore]
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        // Since there is no way to reference a context definition, we will throw an exception
        // if we ever try to do that.
        Expression IDefinitionElement.ToRef(string? libraryName) =>
            throw new InvalidOperationException("There is no reference type for a context definition.");

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    public partial class OperandDef : IDefinitionElement
    {
        [JsonIgnore]
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        [JsonIgnore]
        string IDefinitionElement.Name => name;

        Expression IDefinitionElement.ToRef(string? libraryName) => new OperandRef
        {
            name = name,
        }.WithId().WithResultType(operandTypeSpecifier);

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    public partial class AliasedQuerySource : IDefinitionElement
    {
        [JsonIgnore]
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        [JsonIgnore]
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
        [JsonIgnore]
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        [JsonIgnore]
        string IDefinitionElement.Name => identifier;

        Expression IDefinitionElement.ToRef(string? _) => new QueryLetRef
        {
            name = identifier,
        }.WithId().WithResultType(resultTypeSpecifier);

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    public partial class UsingDef : IDefinitionElement
    {
        [JsonIgnore]
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        [JsonIgnore]
        string IDefinitionElement.Name => localIdentifier;

        Expression IDefinitionElement.ToRef(string? _) =>
            throw new InvalidOperationException("There is no reference type for a using statement.");

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    /// <summary>
    /// An identifier that resolves to an <see cref="IdentifierRef"/>.  Used for special $this variables e.g. in queries.
    /// </summary>
    partial class IdentifierRef : IDefinitionElement
    {
        [JsonIgnore]
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        [JsonIgnore]
        [XmlIgnore]
        public string Name => name;

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

        public Expression ToRef(string? libraryName) => this;
    }

    public partial class IncludeDef : IDefinitionElement
    {
        [JsonIgnore]
        AccessModifier IDefinitionElement.Access => AccessModifier.Private;

        [JsonIgnore]
        string IDefinitionElement.Name => localIdentifier;

        Expression IDefinitionElement.ToRef(string? _) =>
            throw new InvalidOperationException("There is no reference type for an include statement.");

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => this.AddError(error);

    }

    /// <summary>
    /// Defines a function with multiple overloads.
    /// </summary>
    public sealed class OverloadedFunctionDef : IFunctionElement
    {
        /// <summary>
        /// Returns true if these elements can be combined into a single overload; false otherwise.
        /// </summary>
        public static bool CanCombine(params IFunctionElement[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
                if (elements[i] is not IHasSignature && elements[i] is not OverloadedFunctionDef)
                    return false;
            if (elements.Select(e => e.Name).Distinct().Count() != 1)
                return false;
            var allFunctions = elements
                  .OfType<OverloadedFunctionDef>()
                  .SelectMany(ofd => ofd.Functions)
                  .Concat(elements.OfType<IHasSignature>())
                  .ToArray();
            var distinctSignatures = new List<TypeSpecifier[]>();
            // TODO: make this better than O(n2)
            foreach (var function in allFunctions)
            {
                var opTypes = function.Operands
                    .Select(op => op.operandTypeSpecifier)
                    .ToArray();
                if (distinctSignatures.Any(sig => opTypes.SequenceEqual(sig)))
                    return false;
                else
                    distinctSignatures.Add(opTypes);
            }
            return true;
        }

        /// <summary>
        /// Creates an overloaded function from <paramref name="elements"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If <see cref="CanCombine"/> returns false.</exception>
        public static OverloadedFunctionDef Create(params IFunctionElement[] elements)
        {
            var allFunctions = elements
                .OfType<OverloadedFunctionDef>()
                .SelectMany(ofd => ofd.Functions)
                .Concat(elements.OfType<IHasSignature>())
                .ToArray();
            if (!CanCombine(allFunctions))
                throw new ArgumentException("Cannot combine these functions.", nameof(elements));
            var accessLevel = allFunctions.Select(f => f.Access).Min(); // public < private; any public overload makes this public
            return new OverloadedFunctionDef(allFunctions, allFunctions[0].Name, accessLevel);
        }


        private readonly List<IHasSignature> _functions;

        [JsonIgnore]
        [XmlIgnore]
        public IReadOnlyList<IHasSignature> Functions => _functions!.AsReadOnly();

        [JsonIgnore]
        [XmlIgnore]
        public string Name { get; }

        [JsonIgnore]
        [XmlIgnore]
        public AccessModifier Access { get; }

        private OverloadedFunctionDef(IEnumerable<IHasSignature> functions,
            string name,
            AccessModifier access)
        {
            _functions = functions.ToList();
            Name = name;
            Access = access;
        }

        public OverloadedFunctionDef Add(FunctionDef function)
        {
            if (function.name != Name)
                throw new InvalidOperationException($"All functions should have the same name.");
            _functions.Add(function);
            return this;
        }

        Expression IDefinitionElement.ToRef(string? libraryName) => ToRef(libraryName);

        internal FunctionRef ToRef(string? libraryName) => throw new NotSupportedException($"Refs cannot be created until the overload is resolved.");

        IDefinitionElement IDefinitionElement.AddError(CqlToElmError error) => throw new NotSupportedException("An overloaded def cannot have an error.");
    }

    /// <summary>
    /// Defines a deferred symbol that will be resolved later.
    /// </summary>
    public abstract class DeferredDefinition<T>
        (string name, AccessModifier access, Func<T> resolve) : IDefinitionElement
        where T : IDefinitionElement
    {
        [JsonIgnore]
        [XmlIgnore]
        public string Name { get; } = name;

        [JsonIgnore]
        [XmlIgnore]
        public AccessModifier Access { get; } = access;

        [JsonIgnore]
        [XmlIgnore]
        protected Lazy<T> Definition { get; } = new(resolve);

        [JsonIgnore]
        [XmlIgnore]
        public string Library { get; set; } = ""; // used for error reporting for fluent function collisions

        public T Resolve() => Definition.Value;

        public IDefinitionElement AddError(CqlToElmError error) => Definition.Value.AddError(error);

        public Expression ToRef(string? libraryName) => Resolve().ToRef(libraryName);
    }
    /// <summary>
    /// Defines a deferred expression (define).
    /// </summary>
    public sealed class DeferredExpressionDef(string name, AccessModifier access, Func<ExpressionDef> resolve)
        : DeferredDefinition<ExpressionDef>(name, access, resolve), IExpressionElement;
    /// <summary>
    /// Defines a deferred expression (define).
    /// </summary>
    public sealed class DeferredFunctionDef
    (
        AccessModifier access,
        bool fluent,
        string name,
        OperandDef[] operand,
        Func<FunctionDef> resolve)
        : DeferredDefinition<FunctionDef>(name, access, resolve), IHasSignature
    {
        // the signature has to be known initially without resolution.
        [JsonIgnore]
        [XmlIgnore]
        public IEnumerable<OperandDef> Operands { get; } = operand;

        [JsonIgnore]
        [XmlIgnore]
        public bool Fluent { get; } = fluent;

        [JsonIgnore]
        [XmlIgnore]
        public TypeSpecifier ResultTypeSpecifier => Resolve().ResultTypeSpecifier;
    }
}