/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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
        JsonTypeInfo jsonTypeInfo;
        
        // For types with a "type" property, we need to handle them specially in .NET 10+
        // to avoid the conflict with the type discriminator property name.
        // We check if any type in the hierarchy has a "type" property.
#if NET10_0_OR_GREATER
        if (HasTypePropertyInHierarchy(type))
        {
            // Create JsonTypeInfo without going through base resolver to avoid early validation
            jsonTypeInfo = JsonTypeInfo.CreateJsonTypeInfo(type, options);
        }
        else
#endif
        {
            jsonTypeInfo = base.GetTypeInfo(type, options);
        }

        // Remove old "type" property if that is left on ChoiceTypeSpecifier and TupleElementDefinition,
        // it is replaced by the new type discriminator in the current version of ELM.
        // (note: the deserializer will rewrite any old-style type discriminators to the new format in its
        // preprocessing phase).
        // In .NET 10, System.Text.Json is more strict about type discriminator property conflicts,
        // so we proactively remove the "type" property from any types that have it to avoid conflicts.
        if (jsonTypeInfo.Properties.FirstOrDefault(p => p.Name == "type") is { } oldTypeProp)
            jsonTypeInfo.Properties.Remove(oldTypeProp);

        var derivedTypes = BuildDerivedTypes(type).ToList();

        if (!derivedTypes.Any()) return jsonTypeInfo;

#if NET10_0_OR_GREATER
        // In .NET 10+, use "$type" as discriminator to avoid conflicts with actual "type" properties
        const string discriminatorName = "$type";
#else
        // In .NET 8, use "type" as discriminator for backward compatibility
        const string discriminatorName = "type";
#endif

        jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
        {
            TypeDiscriminatorPropertyName = discriminatorName,
            IgnoreUnrecognizedTypeDiscriminators = false,
            UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization,
        };

        // Use a Distinct() here, since the attributes contain superfluous information,
        // and will mention the same derived type multiple times.
        foreach(var derivedType in derivedTypes.DistinctBy(dt => dt.DerivedType))
            jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(derivedType);

        return jsonTypeInfo;
    }

#if NET10_0_OR_GREATER
    private static bool HasTypePropertyInHierarchy(Type type)
    {
        // Check if this type or any of its derived types have a "type" property
        if (type.GetProperty("type", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly) != null)
            return true;
        
        var xmlIncludes = type.GetCustomAttributes<XmlIncludeAttribute>(false);
        foreach (var include in xmlIncludes)
        {
            if (include.Type != null && HasTypePropertyInHierarchy(include.Type))
                return true;
        }
        
        return false;
    }
#endif

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
