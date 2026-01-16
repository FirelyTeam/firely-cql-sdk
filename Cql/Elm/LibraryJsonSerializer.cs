/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm.Serialization;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Elm;

/// <summary>
/// Internal type responsible for JSON serialization and deserialization of Library objects.
/// This class contains specialized logic for handling ELM JSON format quirks and legacy constructs.
/// </summary>
internal static class LibraryJsonSerializer
{
    private const int MaxDepth = 4096; // int.MaxValue is not a good idea
    private static readonly JsonSerializerOptions _jsonSerializerOptions = BuildSerializerOptions(allowOldStyleTypeDiscriminators: false);
    private static readonly JsonSerializerOptions _jsonDeserializerOptions = BuildSerializerOptions(allowOldStyleTypeDiscriminators: true);
    private static readonly JsonDocumentOptions _jsonDocumentOptions = BuildJsonDocumentOptions();

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
        var json = JsonSerializer.Serialize(container, options);
        
        // Convert "__type" back to "type" for backward compatibility
        var node = JsonNode.Parse(json);
        if (node != null)
        {
            ConvertDoubleUnderscoreTypeToType(node);
            json = node.ToJsonString(new JsonSerializerOptions { WriteIndented = writeIndented });
        }
        
        return json;
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
        var json = JsonSerializer.Serialize(container, options);
        
        // Convert "__type" back to "type" for backward compatibility
        var node = JsonNode.Parse(json);
        if (node != null)
        {
            ConvertDoubleUnderscoreTypeToType(node);
            using var writer = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = writeIndented });
            node.WriteTo(writer);
        }
    }

    private static void ConvertDoubleUnderscoreTypeToType(JsonNode node)
    {
        switch (node)
        {
            case JsonObject jo:
                if (jo.TryGetPropertyValue("__type", out var doubleUnderscoreType))
                {
                    jo.Remove("__type");
                    // Insert "type" at the beginning
                    var children = jo.ToList();
                    jo.Clear();
                    jo.Add("type", doubleUnderscoreType);
                    foreach (var child in children)
                        jo.Add(child);
                }
                foreach (var (_, value) in jo.ToList())
                {
                    if (value != null)
                        ConvertDoubleUnderscoreTypeToType(value);
                }
                break;
            case JsonArray ja:
                foreach (var item in ja)
                {
                    if (item != null)
                        ConvertDoubleUnderscoreTypeToType(item);
                }
                break;
        }
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

        options.Converters.Add(new TopLevelDefinitionConverterFactory(allowOldStyleTypeDiscriminators));
        options.Converters.Add(new XmlQualifiedNameConverter());
        options.Converters.Add(new JsonStringEnumConverter());

        var resolver = new PolymorphicTypeResolver(allowOldStyleTypeDiscriminators)
                      .WithAddedModifier(ModifyNarrative)
                      .WithAddedModifier(DoNotSerializeDefaultValues)
                      .WithAddedModifier(HandleSpecifiedProperties);

        if(allowOldStyleTypeDiscriminators)
            resolver = resolver.WithAddedModifier(AllowOldStyleTypeDiscriminators);

        options.TypeInfoResolver = resolver;

        return options;
    }

    private static JsonDocumentOptions BuildJsonDocumentOptions()
    {
        var options = new JsonDocumentOptions()
        {
            MaxDepth = MaxDepth,
        };

        return options;
    }

    private static void CorrectLegacyConstructs(JsonNode a)
    {
        switch(a)
        {
            case JsonObject jo:
                reorder(jo);
                fixType(jo);
                foreach (var (key, value) in jo.ToList())
                {
                    if (value == null) continue;
                    
                    CorrectLegacyConstructs(value);

                    if (IsEmptyObjectOrArray(value))
                    {
                        jo.Remove(key);
                    }
                }
                break;
            case JsonArray ja:
                for (int i = ja.Count - 1; i >= 0; i--)
                {
                    var item = ja[i];
                    if (item == null) continue;
                    
                    CorrectLegacyConstructs(item);

                    if (IsEmptyObjectOrArray(item))
                    {
                        ja.RemoveAt(i);
                    }
                }
                break;
        }

        static void reorder(JsonObject o)
        {
            // Convert "type" discriminators to "__type" for .NET 10 compatibility
            // We use "__type" to avoid conflicts with actual "type" properties in ELM types
            // Only convert if the value is a string (discriminator), not an object/array (data property)
            if (o.TryGetPropertyValue("type", out var typeProp))
            {
                if (typeProp!.GetValueKind() == JsonValueKind.String)
                {
                    // Check if this looks like a type discriminator (PascalCase type name)
                    var typeValue = typeProp.GetValue<string>();
                    if (!string.IsNullOrEmpty(typeValue) && char.IsUpper(typeValue[0]))
                    {
                        o.Remove("type");
                        o.Add("__type", typeProp);
                    }
                }
                // If "type" is an object or array, leave it alone - it's a data property, not a discriminator
            }

            if (!o.TryGetPropertyValue("__type", out var discrim)) return;
            
            // Ensure __type is first
            if (o.First().Value == discrim) return;

            var children = o.ToList();
            o.Clear();

            o.Add("__type", discrim);
            foreach (var nonType in children.Where(o => o.Key != "__type")) o.Add(nonType);
        }

        static void fixType(JsonObject o)
        {
            if (!o.TryGetPropertyValue("__type", out var typeProp)) return;

            if (typeProp!.GetValueKind() == JsonValueKind.Object)
                o.Remove("__type");
        }

        static bool IsEmptyObjectOrArray(JsonNode node) =>
            node is JsonObject { Count: 0 } or JsonArray { Count: 0 };

    }

    private static void HandleSpecifiedProperties(JsonTypeInfo ti)
    {
        IEnumerable<PropAndSpecified> specifiedProps = ti.Properties.SelectMany(getSpecifiedProperty);

        foreach(var prop in specifiedProps)
        {
            var originalSetter = prop.valueProp.Set;

            // On deserialization, if we need to set the property,
            // make sure we set the xxxSpecified property to true.
            prop.valueProp.Set = (obj, value) =>
            {
                originalSetter?.Invoke(obj, value);
                prop.valuePropSpecified.Set?.Invoke(obj, true);
            };

            // Only serialize the property if xxxSpecified is true.
            prop.valueProp.ShouldSerialize = (obj, value) =>
            {
                var shouldSerialize = (bool?)prop.valuePropSpecified.Get?.Invoke(obj) == true;
                if (Library.EnableDebugAssertions && !shouldSerialize && !IsDefaultValue(value))
                    Debug.Fail($"Property '{prop.valueProp.Name}' is set to '{value}', but " +
                               $"the '{prop.valuePropSpecified.Name}' is false.");

                return shouldSerialize;
            };

            // The xxxSpecified prop should never be serialized itself.
            prop.valuePropSpecified.ShouldSerialize = (_, _) => false;
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

    private static void ModifyNarrative(JsonTypeInfo ti)
    {
        // Make sure Narrative.Text is serialized as "value" in the json, not as "Text"
        if (ti.Type != typeof(Narrative)) return;

        var valueProp = ti.Properties.FirstOrDefault(p => p.Name == "Text");

        if (valueProp != null)
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
            // For types outside the inheritance structure, we need to handle the "type" property
            // In .NET 8, we use "type" as both discriminator and regular property
            // In .NET 10, polymorphic types use "$type" discriminator, but types outside inheritance
            // use "type" as a regular property, so we DON'T convert it in preprocessing
            var typeProp = ti.CreateJsonPropertyInfo(typeof(string), "type");
            typeProp.ShouldSerialize = (_, _) => false;
            typeProp.Set = (_, value) =>
                {
                    if( (string?)value != expected)
                        throw new JsonException($"type property should be '{expected}' but was '{value}'.");
                };
            ti.Properties.Add(typeProp);
        }
    }

    private record PropAndSpecified(JsonPropertyInfo valueProp, JsonPropertyInfo valuePropSpecified);
}
