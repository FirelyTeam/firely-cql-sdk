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
#if NET10_0_OR_GREATER
    private readonly HashSet<Type> _processedTypes = [];
#endif

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

#if NET10_0_OR_GREATER
        // .NET 10 System.Text.Json enforces that type discriminator property names cannot conflict
        // with existing property names. Remove the legacy "type" property from ChoiceTypeSpecifier 
        // and TupleElementDefinition before any polymorphism setup. These legacy properties are 
        // replaced by the polymorphic type discriminator system.
        if (!_processedTypes.Contains(type) &&
            (type == typeof(ChoiceTypeSpecifier) || type == typeof(TupleElementDefinition)) &&
            jsonTypeInfo.Properties.FirstOrDefault(p => p.Name == "type") is { } oldTypeProp)
        {
            jsonTypeInfo.Properties.Remove(oldTypeProp);
            _processedTypes.Add(type);
        }
#endif

        var derivedTypes = BuildDerivedTypes(type).ToList();

        if (!derivedTypes.Any()) return jsonTypeInfo;

#if NET10_0_OR_GREATER
        // .NET 10 has stricter validation for polymorphic type discriminators and cannot handle
        // certain ELM type hierarchies. Skip polymorphism setup for these to avoid build-time errors.
        // 
        // Note: Skipping polymorphism for these base types means we rely on custom converters
        // (Net10PolymorphicConverter) to handle deserialization for these hierarchies.
        //
        // Affected hierarchies that need to be skipped:
        // - CqlToElmBase (annotations) - contains CqlToElmInfo, Locator, CqlToElmError
        // - TypeSpecifier - contains ParameterTypeSpecifier, ChoiceTypeSpecifier with "type" properties
        // - AliasedQuerySource/RelationshipClause - nested types have conflicts
        //
        // These types have "type" properties that conflict with the polymorphic discriminator name,
        // or contain nested polymorphic types that have such conflicts.
        if (type == typeof(CqlToElmBase) || type == typeof(Locator) || type == typeof(TypeSpecifier) ||
            type == typeof(AliasedQuerySource) || type == typeof(RelationshipClause))
        {
            return jsonTypeInfo;
        }
#endif

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
