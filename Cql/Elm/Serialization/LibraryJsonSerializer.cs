/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Exceptions;

namespace Hl7.Cql.Elm.Serialization;

// The property should be 'library', not 'Library', to match the JSON structure.
// ReSharper disable once InconsistentNaming
internal record LibraryContainer(Library library);

/// <summary>
/// Internal type responsible for JSON serialization and deserialization of Library objects.
/// This class contains specialized logic for handling ELM JSON format quirks and legacy constructs.
/// </summary>
internal static class LibraryJsonSerializer
{
    /// <summary>
    /// Enables debug assertions for serialization diagnostics.
    /// </summary>
    internal static bool EnableDebugAssertions = true;

    private const int MaxDepth = 4096; // int.MaxValue is not a good idea
    private static readonly JsonSerializerOptions _jsonSerializerOptions = BuildSerializerOptions(allowOldStyleTypeDiscriminators: false);
    private static readonly JsonSerializerOptions _jsonDeserializerOptions = BuildSerializerOptions(allowOldStyleTypeDiscriminators: true);
    private static readonly JsonDocumentOptions _jsonDocumentOptions = BuildJsonDocumentOptions();

    /// <summary>
    /// Parses the specified JSON string and returns a corresponding JsonNode representation.
    /// </summary>
    /// <param name="json">The JSON string to parse. Cannot be null or empty. The string must contain valid JSON.</param>
    /// <returns>A JsonNode representing the parsed JSON data.</returns>
    /// <exception cref="InvalidOperationException">Thrown if the JSON string cannot be parsed into a JsonNode.</exception>
    internal static JsonNode ParseToJsonNode(string json)
    {
        return JsonNode.Parse(json, documentOptions: _jsonDocumentOptions) ??
               throw new InvalidOperationException("JsonNode.Parse unexpectedly returned null.");
    }

    /// <summary>
    /// Deserializes a Library from a JsonNode.
    /// </summary>
    /// <param name="node">The JSON node to deserialize.</param>
    /// <param name="validate">Whether to validate the library after deserialization.</param>
    /// <param name="originalFilePath">Optional file path for error reporting.</param>
    /// <returns>The deserialized Library.</returns>
    internal static Library DeserializeFromJsonNode(JsonNode node, bool validate, string? originalFilePath)
    {
        // Note that we need to reorder the JSON object to ensure that the "type" property is the first property,
        // for which we need to visit the entire object. It is possible to avoid this by first inspecting the
        // compiler tool and version that generated the ELM, so we know whether the compiler tool is known to
        // generate the "type" property first. Also, this will make sure the "type" property is only used for
        // string, if it is used differently, the property is upgraded to "resultTypeSpecifier".
        CorrectLegacyConstructs(node!);

        var container = node.Deserialize<LibraryContainer>(_jsonDeserializerOptions) ??
                        throw new InvalidOperationException("Deserialization unexpectedly returned null.");
        var library = container.library;

        if (validate)
        {
            try
            {
                library.Validate();
            }
            catch (Exception e)
            {
                throw new CouldNotValidateLibraryError(originalFilePath, typeof(Library).FullName).ToException(e);
            }
        }

        return library;
    }

    /// <summary>
    /// Serializes a Library to a JSON string.
    /// </summary>
    /// <param name="library">The library to serialize.</param>
    /// <param name="writeIndented">Whether to format the JSON with indentation.</param>
    /// <returns>The JSON string representation of the library.</returns>
    internal static string SerializeToJson(Library library, bool writeIndented = true)
    {
        // I hope (and think) this will clone the original options,
        // including all cached metadata, otherwise serialization will be a
        // lot slower than it should be.
        var options = new JsonSerializerOptions(_jsonSerializerOptions)
        {
            WriteIndented = writeIndented
        };

        var container = new LibraryContainer(library);
        return JsonSerializer.Serialize(container, options);
    }

    /// <summary>
    /// Serializes a Library to a stream in JSON format.
    /// </summary>
    /// <param name="library">The library to serialize.</param>
    /// <param name="stream">The stream to write to.</param>
    /// <param name="writeIndented">Whether to format the JSON with indentation.</param>
    internal static void SerializeToStream(Library library, Stream stream, bool writeIndented = true)
    {
        var options = new JsonSerializerOptions(_jsonSerializerOptions)
        {
            WriteIndented = writeIndented
        };

        var container = new LibraryContainer(library);
        JsonSerializer.Serialize(stream, container, options);
    }

    /// <summary>
    /// Gets the JSON document options used for parsing.
    /// </summary>
    internal static JsonDocumentOptions GetJsonDocumentOptions() => _jsonDocumentOptions;

    /// <summary>
    /// Builds JSON serializer options for ELM serialization.
    /// </summary>
    /// <param name="allowOldStyleTypeDiscriminators">Whether to allow old-style type discriminators.</param>
    /// <returns>Configured JsonSerializerOptions.</returns>
    internal static JsonSerializerOptions BuildSerializerOptions(bool allowOldStyleTypeDiscriminators = false)
    {
        var options = new JsonSerializerOptions
        {
            MaxDepth = MaxDepth,
            UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,
        };

        // Register custom converters for polymorphic types to work around System.Text.Json limitation
        // with "type" property name conflicts
        options.Converters.Add(new PolymorphicObjectJsonConverter<CqlToElmBase>(allowOldStyleTypeDiscriminators));
        options.Converters.Add(new PolymorphicObjectJsonConverter<ExpressionDef>(allowOldStyleTypeDiscriminators));
        options.Converters.Add(new PolymorphicObjectJsonConverter<Expression>(allowOldStyleTypeDiscriminators));
        options.Converters.Add(new PolymorphicObjectJsonConverter<TypeSpecifier>(allowOldStyleTypeDiscriminators));
        options.Converters.Add(new PolymorphicObjectJsonConverter<Element>(allowOldStyleTypeDiscriminators));
        options.Converters.Add(new PolymorphicObjectJsonConverter<RelationshipClause>(allowOldStyleTypeDiscriminators));
        options.Converters.Add(new PolymorphicObjectJsonConverter<AliasedQuerySource>(allowOldStyleTypeDiscriminators));
        options.Converters.Add(new PolymorphicObjectJsonConverter<SortByItem>(allowOldStyleTypeDiscriminators));

        options.Converters.Add(new TopLevelDefinitionConverterFactory(allowOldStyleTypeDiscriminators));
        options.Converters.Add(new XmlQualifiedNameConverter());
        options.Converters.Add(new JsonStringEnumConverter());

        var resolver = new PolymorphicTypeResolver(allowOldStyleTypeDiscriminators)
                      .WithAddedModifier(ModifyNarrative)
                      .WithAddedModifier(DoNotSerializeDefaultValues)
                      .WithAddedModifier(HandleSpecifiedProperties)
                      .WithAddedModifier(RespectXmlIgnoreAttribute);

        if (allowOldStyleTypeDiscriminators)
            resolver = resolver.WithAddedModifier(AllowOldStyleTypeDiscriminators);

        options.TypeInfoResolver = resolver;

        return options;
    }

    /// <summary>
    /// Builds a type resolver with only the modifiers (DoNotSerializeDefaultValues, HandleSpecifiedProperties, ModifyNarrative, RespectXmlIgnoreAttribute)
    /// but without polymorphism configuration. This is used by PolymorphicObjectJsonConverter when deserializing
    /// derived types to avoid "type" property conflicts while still applying the necessary serialization modifiers.
    /// </summary>
    internal static IJsonTypeInfoResolver BuildModifiersOnlyResolver()
    {
        return new DefaultJsonTypeInfoResolver()
            .WithAddedModifier(ModifyNarrative)
            .WithAddedModifier(DoNotSerializeDefaultValues)
            .WithAddedModifier(HandleSpecifiedProperties)
            .WithAddedModifier(RespectXmlIgnoreAttribute);
    }

    /// <summary>
    /// Builds a type resolver with modifiers including AllowOldStyleTypeDiscriminators.
    /// This is used when deserializing legacy ELM files that include "type" discriminators
    /// on concrete types outside the polymorphic hierarchies.
    /// </summary>
    internal static IJsonTypeInfoResolver BuildModifiersOnlyResolverWithOldStyleTypeDiscriminators()
    {
        return new DefaultJsonTypeInfoResolver()
            .WithAddedModifier(ModifyNarrative)
            .WithAddedModifier(DoNotSerializeDefaultValues)
            .WithAddedModifier(HandleSpecifiedProperties)
            .WithAddedModifier(RespectXmlIgnoreAttribute)
            .WithAddedModifier(AllowOldStyleTypeDiscriminators);
    }

    private static JsonDocumentOptions BuildJsonDocumentOptions() =>
        new() { MaxDepth = MaxDepth };

    private static void CorrectLegacyConstructs(JsonNode a)
    {
            switch (a)
            {
                case JsonObject jo:
                    reorder(jo);
                    fixType(jo);
                    foreach (var (key, value) in jo.ToList())
                    {
                        if (value is null) continue;

                        CorrectLegacyConstructs(value);

                        if (isEmptyObjectOrArray(value))
                        {
                            jo.Remove(key);
                        }
                    }
                    break;
                case JsonArray ja:
                    for (int i = ja.Count - 1; i >= 0; i--)
                    {
                        var item = ja[i];
                        if (item is null) continue;

                        CorrectLegacyConstructs(item);

                        if (isEmptyObjectOrArray(item))
                        {
                            ja.RemoveAt(i);
                        }
                    }
                    break;
            }

            static void reorder(JsonObject o)
            {
                if (!o.TryGetPropertyValue("type", out var typeProp) || o.First().Value == typeProp) return;

                var children = o.ToList();
                o.Clear();

                o.Add("type", typeProp);
                foreach (var nonType in children.Where(o => o.Key != "type")) o.Add(nonType);
            }

            static void fixType(JsonObject o)
            {
                if (!o.TryGetPropertyValue("type", out var typeProp)) return;

                // If "type" is an object (not a discriminator string), remove it
                if (typeProp!.GetValueKind() == JsonValueKind.Object)
                {
                    o.Remove("type");
                    return;
                }

                // If "type" is an array (legacy ChoiceTypeSpecifier.type), convert to "choice"
                if (typeProp.GetValueKind() == JsonValueKind.Array)
                {
                    // Only convert if there's no "choice" property already
                    if (!o.ContainsKey("choice"))
                    {
                        o.Remove("type");
                        o.Add("choice", typeProp);
                    }
                    else
                    {
                        // If both exist, remove the legacy "type" property
                        o.Remove("type");
                    }
                }
            }

            static bool isEmptyObjectOrArray(JsonNode node) =>
                node is JsonObject { Count: 0 } or JsonArray { Count: 0 };
        }

    private static void HandleSpecifiedProperties(JsonTypeInfo ti)
    {
        var specifiedProps = ti.Properties.SelectMany(getSpecifiedProperty);

        foreach (var prop in specifiedProps)
        {
            var originalSetter = prop.ValueProp.Set;

            // On deserialization, if we need to set the property,
            // make sure we set the xxxSpecified property to true.
            prop.ValueProp.Set = (obj, value) =>
            {
                originalSetter?.Invoke(obj, value);
                prop.ValuePropSpecified.Set?.Invoke(obj, true);
            };

            // Only serialize the property if xxxSpecified is true.
            // Preserve the existing ShouldSerialize logic (e.g., from DoNotSerializeDefaultValues).
            var existingShouldSerialize = prop.ValueProp.ShouldSerialize;
            prop.ValueProp.ShouldSerialize = (obj, value) =>
            {
                var shouldSerialize = (bool?)prop.ValuePropSpecified.Get?.Invoke(obj) == true;
                if (EnableDebugAssertions && !shouldSerialize && !IsDefaultValue(value))
                    Debug.Fail($"Property '{prop.ValueProp.Name}' is set to '{value}', but " +
                               $"the '{prop.ValuePropSpecified.Name}' is false.");

                // If the specified flag is false, don't serialize
                if (!shouldSerialize) return false;

                // Otherwise, defer to the existing ShouldSerialize logic
                return existingShouldSerialize?.Invoke(obj, value) ?? true;
            };

            // The xxxSpecified prop should never be serialized itself.
            prop.ValuePropSpecified.ShouldSerialize = (_, _) => false;
        }

        IEnumerable<PropAndSpecified> getSpecifiedProperty(JsonPropertyInfo prop)
        {
            if (prop.Name.EndsWith("Specified") &&
                ti.Properties.FirstOrDefault(p => p.Name == prop.Name[..^9]) is { } valueProp)
            {
                yield return new PropAndSpecified(valueProp, prop);
            }
        }
    }

    private static void DoNotSerializeDefaultValues(JsonTypeInfo ti)
    {
        foreach (var prop in ti.Properties)
        {
            prop.ShouldSerialize = shouldSerialize;

            bool shouldSerialize(object parent, object? value)
            {
                if (value is null) return false;
                if (prop.PropertyType.IsEnum) return true;

                if (ti.Type == typeof(Interval)) return true;

                var defaultAttr = prop.AttributeProvider?
                    .GetCustomAttributes(typeof(DefaultValueAttribute), false)
                    .FirstOrDefault() as DefaultValueAttribute;

                var defaultValue = defaultAttr?.Value ?? GetDefaultValue(prop.PropertyType);

                return !Equals(value, defaultValue);
            }
        }
    }

    private static object? GetDefaultValue(Type type) =>
        type.IsValueType ? Activator.CreateInstance(type) : null;

    private static bool IsDefaultValue(object? o) =>
        o is null || o.Equals(GetDefaultValue(o.GetType()));

    private static void RespectXmlIgnoreAttribute(JsonTypeInfo ti)
    {
        // Properties marked with [XmlIgnore] should also be ignored in JSON serialization.
        // This allows us to avoid duplicating [JsonIgnore] attributes on computed properties.
        foreach (var prop in ti.Properties)
        {
            var hasXmlIgnore = prop.AttributeProvider?
                .GetCustomAttributes(typeof(XmlIgnoreAttribute), false)
                .Length > 0;

            if (hasXmlIgnore)
            {
                prop.ShouldSerialize = (_, _) => false;
            }
        }
    }

    private static void ModifyNarrative(JsonTypeInfo ti)
    {
        // Make sure Narrative.Text is serialized as "value" in the json, not as "Text"
        if (ti.Type != typeof(Narrative)) return;

        var valueProp = ti.Properties.FirstOrDefault(p => p.Name == "Text");

        if (valueProp is not null)
            valueProp.Name = "value";
    }

    private static void AllowOldStyleTypeDiscriminators(JsonTypeInfo ti)
    {
        bool isElmNodeOutsideInheritanceStructure =
            ti.PolymorphismOptions is null &&
            ti.Kind == JsonTypeInfoKind.Object &&
            ti.Type.GetCustomAttributes(typeof(XmlTypeAttribute), false).Length != 0;

        if (isElmNodeOutsideInheritanceStructure)
            addTypeProperty(ti, ti.Type.Name);

        static void addTypeProperty(JsonTypeInfo ti, string expected)
        {
            // Don't add a "type" property if one already exists (even if ignored)
            if (ti.Properties.Any(p => p.Name == "type"))
                return;

            // For types outside the inheritance structure, we need to handle the "type" property
            var typeProp = ti.CreateJsonPropertyInfo(typeof(string), "type");
            typeProp.ShouldSerialize = (_, _) => false;
            typeProp.Set = (_, value) =>
            {
                if ((string?)value != expected)
                    throw new JsonException($"type property should be '{expected}' but was '{value}'.");
            };
            ti.Properties.Add(typeProp);
        }
    }

    private record PropAndSpecified(JsonPropertyInfo ValueProp, JsonPropertyInfo ValuePropSpecified);
}
