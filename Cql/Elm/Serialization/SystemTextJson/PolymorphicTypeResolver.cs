using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Xml.Serialization;

namespace Hl7.Cql.Elm.Serialization;

internal class PolymorphicTypeResolver : DefaultJsonTypeInfoResolver
{
    public PolymorphicTypeResolver(bool emitConcreteBaseTypeDiscriminator = false)
    {
        EmitConcreteBaseTypeDiscriminator = emitConcreteBaseTypeDiscriminator;
    }

    /// <summary>
    /// In newer serializations of ELM, if the declared type of an element is a concrete type,
    /// and the runtime type is the same as the declared type, the type discriminator is not emitted.
    /// Set EmitConcreteBaseTypeDiscriminator to true to override this behaviour and emit the type discriminator
    /// for concrete types as well.
    /// </summary>
    public bool EmitConcreteBaseTypeDiscriminator { get; }

    public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
    {
        JsonTypeInfo jsonTypeInfo = base.GetTypeInfo(type, options);

        // Remove old "type" property if that is left on ChoiceTypeSpecifier,
        // it is replaced by the new type discriminator in the current version of ELM.
        // (note: the deserializer will rewrite any old-style type discriminators to the new format in its
        // preprocessing phase).
        if (jsonTypeInfo.Type == typeof(ChoiceTypeSpecifier) &&
            jsonTypeInfo.Properties.FirstOrDefault(p => p.Name == "type") is { } oldTypeProp)
            jsonTypeInfo.Properties.Remove(oldTypeProp);

        var derivedTypes = BuildDerivedTypes(type).ToList();

        if (!derivedTypes.Any()) return jsonTypeInfo;


        jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
        {
            TypeDiscriminatorPropertyName = "type",
            IgnoreUnrecognizedTypeDiscriminators = false,
            UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization,
        };

        // Use a Distinct() here, since the attributes contain superfluous information,
        // and will mention the same derived type multiple times.
        foreach(var derivedType in derivedTypes.DistinctBy(dt => dt.DerivedType))
            jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(derivedType);

        return jsonTypeInfo;
    }

    private IEnumerable<JsonDerivedType> BuildDerivedTypes(Type baseType)
    {
        var xmlHierarchyAttributes = baseType.GetCustomAttributes<XmlIncludeAttribute>(false).ToList();

        if(EmitConcreteBaseTypeDiscriminator && baseType.IsAbstract == false && xmlHierarchyAttributes.Any())
            yield return new JsonDerivedType(baseType, baseType.Name);

        foreach (var type in xmlHierarchyAttributes.Select(a => a.Type).Where(t => t != null))
        {
            if(!type!.IsAbstract)
                yield return new JsonDerivedType(type, type.Name);
            foreach (var derivedType in BuildDerivedTypes(type))
                yield return derivedType;
        }
    }
}