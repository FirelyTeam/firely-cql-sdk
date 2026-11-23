/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Serialization;

/// <summary>
/// A JsonTypeInfoResolver that configures System.Text.Json's native polymorphism, with "type" as the
/// discriminator, from the XmlInclude attributes of the ELM model.
/// </summary>
/// <param name="emitConcreteBaseTypeDiscriminator">
/// Set to true for reading. In newer serializations of ELM, if the declared type of an element is a concrete type,
/// and the runtime type is the same as the declared type, the type discriminator is not emitted.
/// Older serializations do emit it. When true, every concrete ELM type (one with an XmlInclude or XmlType attribute)
/// also accepts its own name as discriminator, and rejects any other name.
/// Leave it false for writing: it would make types such as IncludeDef polymorphic, and writing an
/// instance of a subclass outside the ELM model, such as the translator's ReferencedLibrary, would then fail.
/// </param>
internal class PolymorphicTypeResolver(bool emitConcreteBaseTypeDiscriminator = false) : DefaultJsonTypeInfoResolver
{
    public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
    {
        JsonTypeInfo jsonTypeInfo = base.GetTypeInfo(type, options);

        // Polymorphism applies to objects only. Types with a custom converter, collections and primitives are left alone.
        if (jsonTypeInfo.Kind != JsonTypeInfoKind.Object)
            return jsonTypeInfo;

        var derivedTypes = BuildDerivedTypes(type).DistinctBy(dt => dt.DerivedType).ToList();

        if (derivedTypes.Count == 0) return jsonTypeInfo;

        jsonTypeInfo.PolymorphismOptions = new JsonPolymorphismOptions
        {
            TypeDiscriminatorPropertyName = "type",
            IgnoreUnrecognizedTypeDiscriminators = false,
            UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FailSerialization,
        };

        foreach (var derivedType in derivedTypes)
            jsonTypeInfo.PolymorphismOptions.DerivedTypes.Add(derivedType);

        if (type.IsAbstract)
        {
            // Without a discriminator an abstract type cannot be created. Report that as a JsonException.
            jsonTypeInfo.CreateObject = () =>
                throw new JsonException($"Cannot deserialize abstract type '{type.Name}' without a 'type' discriminator property.");
        }

        return jsonTypeInfo;
    }

    private IEnumerable<JsonDerivedType> BuildDerivedTypes(Type baseType)
    {
        var xmlHierarchyAttributes = baseType.GetCustomAttributes<XmlIncludeAttribute>(false).ToList();

        if (emitConcreteBaseTypeDiscriminator && !baseType.IsAbstract &&
            (xmlHierarchyAttributes.Count > 0 || baseType.IsDefined(typeof(XmlTypeAttribute), false)))
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
