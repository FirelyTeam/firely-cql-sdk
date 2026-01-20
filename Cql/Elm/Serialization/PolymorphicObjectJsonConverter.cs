/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Serialization;

/// <summary>
/// Custom JSON converter for polymorphic objects that uses the "type" discriminator.
/// This converter is needed because System.Text.Json's built-in polymorphism support
/// conflicts with ELM types that have properties named "type".
/// </summary>
internal class PolymorphicObjectJsonConverter<T>(bool emitConcreteBaseTypeDiscriminator = false)
    : JsonConverter<T> where T : class
{
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException($"Expected StartObject, got {reader.TokenType}");

        // Read the entire object into a JsonDocument so we can inspect the "type" property
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;

        // Look for the "type" discriminator property
        if (!root.TryGetProperty("type", out var typeProperty))
        {
            // No "type" discriminator - deserialize as the concrete base type
            if (typeToConvert.IsAbstract)
            {
                throw new JsonException($"Cannot deserialize abstract type '{typeToConvert.Name}' without a 'type' discriminator property.");
            }

            // Deserialize using default contract resolver to bypass this converter
            return DeserializeWithDefaultContract(root.GetRawText(), typeToConvert, options);
        }

        var typeName = typeProperty.GetString();
        if (string.IsNullOrEmpty(typeName))
        {
            throw new JsonException($"Type discriminator is empty for base type '{typeToConvert.Name}'");
        }

        // Find the type by name using XmlIncludeAttribute
        var targetType = FindTypeByDiscriminator(typeToConvert, typeName);
        if (targetType is null)
        {
            throw new JsonException($"Unknown type discriminator '{typeName}' for base type {typeToConvert.Name}");
        }

        // Remove the "type" discriminator property before deserializing the derived type
        // because it's not a real property on the type and would cause unmapped member errors
        var jsonWithoutType = RemoveTypeProperty(root);

        // Use modified options with DefaultJsonTypeInfoResolver to avoid polymorphism conflicts
        // when deserializing nested types that might have "type" properties (like Search, Retrieve, etc.)
        var modifiedOptions = CreateModifiedOptionsForDerivedType(options);

        // Deserialize as the specific type
        return (T)JsonSerializer.Deserialize(jsonWithoutType, targetType, modifiedOptions)!;
    }

    /// <summary>
    /// Removes the "type" property from a JSON element and returns the modified JSON string.
    /// </summary>
    private static string RemoveTypeProperty(JsonElement element)
    {
        using var stream = new MemoryStream();
        using var writer = new Utf8JsonWriter(stream);

        writer.WriteStartObject();
        foreach (var property in element.EnumerateObject())
        {
            if (property.Name != "type")
            {
                property.WriteTo(writer);
            }
        }
        writer.WriteEndObject();
        writer.Flush();

        return Encoding.UTF8.GetString(stream.ToArray());
    }

    /// <summary>
    /// Creates modified options for deserializing derived types.
    /// </summary>
    private JsonSerializerOptions CreateModifiedOptionsForDerivedType(JsonSerializerOptions originalOptions)
    {
        var modifiedOptions = new JsonSerializerOptions
        {
            MaxDepth = originalOptions.MaxDepth,
            UnmappedMemberHandling = originalOptions.UnmappedMemberHandling,
            // Use modifiers-only resolver to avoid polymorphism conflicts while preserving
            // modifiers like HandleSpecifiedProperties
            TypeInfoResolver = emitConcreteBaseTypeDiscriminator
                ? LibraryJsonSerializer.BuildModifiersOnlyResolverWithOldStyleTypeDiscriminators()
                : LibraryJsonSerializer.BuildModifiersOnlyResolver()
        };

        // Copy all converters to handle nested abstract types
        foreach (var converter in originalOptions.Converters)
        {
            modifiedOptions.Converters.Add(converter);
        }

        return modifiedOptions;
    }

    /// <summary>
    /// Deserializes using the default type contract, bypassing custom converters to prevent recursion.
    /// </summary>
    private T? DeserializeWithDefaultContract(string json, Type typeToConvert, JsonSerializerOptions originalOptions)
    {
        // Create new options with modifiers-only resolver to avoid polymorphism conflicts
        var tempOptions = new JsonSerializerOptions
        {
            MaxDepth = originalOptions.MaxDepth,
            UnmappedMemberHandling = originalOptions.UnmappedMemberHandling,
            // Use modifiers-only resolver to avoid polymorphism conflicts while preserving
            // modifiers like HandleSpecifiedProperties
            TypeInfoResolver = emitConcreteBaseTypeDiscriminator
                ? LibraryJsonSerializer.BuildModifiersOnlyResolverWithOldStyleTypeDiscriminators()
                : LibraryJsonSerializer.BuildModifiersOnlyResolver()
        };

        // Copy all converters EXCEPT the one for T (the current type being deserialized)
        // This ensures nested abstract types (like Expression) still get their converters
        var thisConverterType = typeof(PolymorphicObjectJsonConverter<T>);
        foreach (var converter in originalOptions.Converters)
        {
            if (converter.GetType() != thisConverterType)
            {
                tempOptions.Converters.Add(converter);
            }
        }

        return (T?)JsonSerializer.Deserialize(json, typeToConvert, tempOptions);
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        if (value is null)
        {
            writer.WriteNullValue();
            return;
        }

        var actualType = value.GetType();
        var declaredType = typeof(T);

        // Determine if we need to emit the type discriminator
        bool needsDiscriminator = actualType != declaredType;
        if (!needsDiscriminator && declaredType.IsAbstract)
            needsDiscriminator = true;
        if (!needsDiscriminator && emitConcreteBaseTypeDiscriminator)
            needsDiscriminator = true;

        writer.WriteStartObject();

        // Write type discriminator if needed
        if (needsDiscriminator)
        {
            var discriminator = FindDiscriminatorForType(actualType);
            if (discriminator is null)
            {
                throw new JsonException($"No XmlElementTypeMappingAttribute found for type {actualType.Name}");
            }
            writer.WriteString("type", discriminator);
        }

        // Get the type info for the actual type using the modifiers-only resolver
        // This avoids infinite recursion while still applying serialization modifiers
        var modifiersOnlyOptions = CreateModifiersOnlyOptions(options);
        var typeInfo = modifiersOnlyOptions.GetTypeInfo(actualType);

        // Serialize each property individually, using original options for property values
        // This ensures nested polymorphic properties still get their converters applied
        foreach (var prop in typeInfo.Properties)
        {
            if (prop.Get == null) continue;

            var propValue = prop.Get(value);

            // Check if we should serialize this property (applies ShouldSerialize logic from modifiers)
            if (prop.ShouldSerialize != null && !prop.ShouldSerialize(value, propValue))
                continue;

            writer.WritePropertyName(prop.Name);

            // Use original options for serialization so nested polymorphic types get their converters
            JsonSerializer.Serialize(writer, propValue, prop.PropertyType, options);
        }

        writer.WriteEndObject();
    }

    /// <summary>
    /// Creates options with only modifiers, no converters, for getting type metadata.
    /// </summary>
    private static JsonSerializerOptions CreateModifiersOnlyOptions(JsonSerializerOptions originalOptions)
    {
        var modifiedOptions = new JsonSerializerOptions
        {
            MaxDepth = originalOptions.MaxDepth,
            UnmappedMemberHandling = originalOptions.UnmappedMemberHandling,
            TypeInfoResolver = LibraryJsonSerializer.BuildModifiersOnlyResolver()
        };
        return modifiedOptions;
    }

    private static Type? FindTypeByDiscriminator(Type baseType, string discriminator)
    {
        // Check the base type itself
        if (baseType.Name == discriminator)
            return baseType;

        // Recursively search through derived types using XmlIncludeAttribute
        return FindTypeByDiscriminatorRecursive(baseType, discriminator, new HashSet<Type>());
    }

    private static Type? FindTypeByDiscriminatorRecursive(Type currentType, string discriminator, HashSet<Type> visited)
    {
        // Prevent infinite recursion
        if (!visited.Add(currentType))
            return null;

        // Search through derived types using XmlIncludeAttribute
        var xmlIncludes = currentType.GetCustomAttributes(typeof(System.Xml.Serialization.XmlIncludeAttribute), false)
                                  .Cast<System.Xml.Serialization.XmlIncludeAttribute>();

        foreach (var xmlInclude in xmlIncludes)
        {
            var type = xmlInclude.Type;
            if (type is null) continue;

            if (type.Name == discriminator)
                return type;

            // Recursively search this type's includes
            var found = FindTypeByDiscriminatorRecursive(type, discriminator, visited);
            if (found is not null)
                return found;
        }

        return null;
    }

    private static string FindDiscriminatorForType(Type type)
    {
        // The discriminator is just the type name
        return type.Name;
    }
}
