/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Serialization;

/// <summary>
/// A JsonTypeInfoResolver that adds polymorphic type handling based on XmlInclude attributes.
/// </summary>
/// <param name="emitConcreteBaseTypeDiscriminator">
/// In newer serializations of ELM, if the declared type of an element is a concrete type,
/// and the runtime type is the same as the declared type, the type discriminator is not emitted.
/// Set emitConcreteBaseTypeDiscriminator to true to override this behaviour and emit the type discriminator
/// for concrete types as well.
/// </param>
internal class PolymorphicTypeResolver(bool emitConcreteBaseTypeDiscriminator = false) : DefaultJsonTypeInfoResolver
{
    public override JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
    {
        JsonTypeInfo jsonTypeInfo = base.GetTypeInfo(type, options);

        // Don't apply polymorphism if a custom converter is registered (JsonTypeInfoKind will be None)
        if (jsonTypeInfo.Kind == JsonTypeInfoKind.None)
            return jsonTypeInfo;

        // Don't apply polymorphism to CqlToElmBase and its hierarchy - they have transitive conflicts
        // through properties containing types with "type" properties. Custom converter handles these.
        if (type.FullName == "Hl7.Cql.Elm.CqlToElmBase" ||
            type.BaseType?.FullName == "Hl7.Cql.Elm.CqlToElmBase" ||
            (type.BaseType?.BaseType?.FullName == "Hl7.Cql.Elm.CqlToElmBase"))
            return jsonTypeInfo;

        // Don't apply polymorphism to types with custom converters: Element, Expression, TypeSpecifier, ExpressionDef.
        // These hierarchies have transitive conflicts through properties with "type" names.
        // Arrays of these types are handled by PolymorphicArrayJsonConverter.
        if (type.FullName is "Hl7.Cql.Elm.Element" or "Hl7.Cql.Elm.Expression" or "Hl7.Cql.Elm.TypeSpecifier" or "Hl7.Cql.Elm.OperatorExpression" or "Hl7.Cql.Elm.AggregateExpression" or "Hl7.Cql.Elm.ExpressionDef" or "Hl7.Cql.Elm.FunctionDef")
            return jsonTypeInfo;

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

        if(emitConcreteBaseTypeDiscriminator && baseType.IsAbstract == false && xmlHierarchyAttributes.Any())
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
