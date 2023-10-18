using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using System;

namespace Hl7.Cql.CqlToElm
{
    internal record ModelResolveResult(ModelInfo Model, TypeInfo Type)
    {
        public Elm.NamedTypeSpecifier ToNamedType() => 
            Type.GetNameFromTypeInfo() is { } name ? 
                Model.MakeQualifiedTypeName(name).ToNamedType() :
                throw new InvalidOperationException($"Cannot convert {Type} to a NamedTypeSpecifier.");
    }
}
