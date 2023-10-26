using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using System;

namespace Hl7.Cql.CqlToElm
{
    internal record ModelResolveResult(ModelInfo? Model, TypeInfo? Type)
    {
        public Elm.NamedTypeSpecifier ToNamedType()
        {
            if (Model is null) throw new InvalidOperationException("Cannot convert to a NamedTypeSpecifier without a Model.");
            if (Type is null) throw new InvalidOperationException("Cannot convert to a NamedTypeSpecifier without a Type.");

            return Type.GetNameFromTypeInfo() is { } name ?
                Model.MakeQualifiedTypeName(name).ToNamedType() :
                throw new InvalidOperationException($"Cannot convert {Type} to a NamedTypeSpecifier.");
        }
    }
}
