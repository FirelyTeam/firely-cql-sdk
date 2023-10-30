using Hl7.Cql.Elm;
using Hl7.Cql.Model;
using System;

namespace Hl7.Cql.CqlToElm
{
    internal record ModelResolveResult(ModelInfo Model, TypeInfo Type)
    {
        // public bool Success => Model is not null && Type is not null;

        public Elm.NamedTypeSpecifier ToNamedType()
        {
            //if (Model is null)
            //    return new Elm.NamedTypeSpecifier() { name = new System.Xml.XmlQualifiedName(Identifier) }
            //        .AddError($"Cannot resolve type identifier {Identifier} since its model cannot be resolved.", ErrorType.semantic);
            //else if (Type is null)
            //    return new Elm.NamedTypeSpecifier() { name = new System.Xml.XmlQualifiedName(Identifier) }
            //        .AddError($"Cannot resolve type identifier {Identifier} since the type is not declared in the model.", ErrorType.semantic);
            //else
            return Type.GetNameFromTypeInfo() is { } n ?
                Model.MakeQualifiedTypeName(n).ToNamedType() :
                throw new InvalidOperationException($"Cannot convert {Type} to a NamedTypeSpecifier.");

        }
    }
}
