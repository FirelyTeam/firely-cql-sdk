using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using System;

namespace Hl7.Cql.CqlToElm
{
    /// <summary>
    /// A class that represents a <see cref="TypeInfo"/> and its <see cref="Model.ModelInfo"/> as a resolvable symbol
    /// in an <see cref="ISymbolScope"/>.
    /// </summary>
    /// <remarks>In many contexts where a <see cref="TypeInfo"/> is used, it is also useful to have
    /// the parent <see cref="ModelInfo"/> available. Unfortunately, TypeInfo does not refer to its
    /// ModelInfo, so this symbol provides an easy way to return both at the same time.</remarks>
    internal record ModelType(ModelInfo Model, TypeInfo Type) : IDefinitionElement
    {
        public AccessModifier Access => AccessModifier.Public;

        public string Name => Type.GetNameFromTypeInfo() is { } name ? name :
            throw new InvalidOperationException($"{Type} does not have a name.");

        public Elm.NamedTypeSpecifier ToNamedType()
        {
            return Type.GetNameFromTypeInfo() is { } n ?
                Model.MakeQualifiedTypeName(n).ToNamedType() :
                throw new InvalidOperationException($"Cannot convert {Type} to a NamedTypeSpecifier.");
        }

        public Expression ToRef(string? _) => throw new InvalidOperationException("Cannot refer to a ModelType where an expression is expected.");
    }
}
