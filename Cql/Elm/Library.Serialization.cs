/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm.Serialization;
using Hl7.Cql.Abstractions.Exceptions;

namespace Hl7.Cql.Elm;


#pragma warning disable CS1591

// The property should be 'library', not 'Library', to match the JSON structure.
// ReSharper disable once InconsistentNaming
internal record LibraryContainer(Library library);

public partial class Library
{
    internal static bool EnableDebugAssertions = true;

    /// <summary>
    /// Loads a library from a JSON string.
    /// </summary>
    public static Library ParseFromJson(string json, bool validate = true)
    {
        var node = JsonNode.Parse(json) ??
                   throw new InvalidOperationException("JsonNode.Parse unexpectedly returned null.");

        return LoadFromJsonInternal(node, validate, null);
    }

    /// <summary>
    /// Loads a library from a directory containing ELM files.
    /// </summary>
    public static Library LoadFromJson(
        DirectoryInfo elmDirectory,
        string lib,
        string version,
        bool validate = true)
    {
        var elmFile = new FileInfo(Path.Combine(elmDirectory.FullName, $"{lib}-{version}.json"));
        if (elmFile.Exists)
            return LoadFromJson(elmFile, validate);

        var elmFile2 = new FileInfo(Path.Combine(elmDirectory.FullName, $"{lib}.json"));
        if (elmFile2.Exists)
            return LoadFromJson(elmFile2, validate);

        throw new FileNotFoundException($"File '{elmFile.FullName}' does not exist.", elmFile.FullName);
    }


    /// <summary>
    /// Loads a library from a JSON file.
    /// </summary>
    public static Library LoadFromJson(FileInfo file, bool validate = true)
    {
        if (!file.Exists)
            throw new FileNotFoundException($"File {file.FullName} does not exist.");

        using var stream = file.OpenRead();
        return LoadFromJson(stream, validate, originalFilePath: file.FullName);
    }

    /// <summary>
    /// Loads a library from a stream containing JSON.
    /// </summary>
    public static Library LoadFromJson(Stream stream, bool validate = true, string? originalFilePath = null)
    {
        var node = JsonNode.Parse(stream, documentOptions: _jsonDocumentOptions) ??
                   throw new InvalidOperationException("JsonNode.Parse unexpectedly returned null.");

        originalFilePath ??= stream switch
        {
            FileStream { Name: { } name } => name,
            _                             => null,
        };

        return LoadFromJsonInternal(node, validate, originalFilePath);
    }

    private static Library LoadFromJsonInternal(JsonNode node, bool validate, string? originalFilePath)
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

    private static void CorrectLegacyConstructs(JsonNode a, bool isRoot = true)
    {
        switch(a)
        {
            case JsonObject jo:
                reorder(jo, isRoot);
                fixType(jo, isRoot);
                foreach (var (key, value) in jo.ToList())
                {
                    if (value == null) continue;
                    
                    // The root container has a "library" property which is the actual Library object
                    // Don't convert "type" in the Library object itself (key == "library")
                    bool isLibraryObject = isRoot && key == "library";
                    CorrectLegacyConstructs(value, isRoot: isLibraryObject);

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
                    
                    CorrectLegacyConstructs(item, isRoot: false);

                    if (IsEmptyObjectOrArray(item))
                    {
                        ja.RemoveAt(i);
                    }
                }
                break;
        }

        static void reorder(JsonObject o, bool isLibraryOrKnownType)
        {
#if NET10_0_OR_GREATER
            // In .NET 10+, we need to convert "type" discriminators to "$type" for polymorphic types.
            // However, types outside the inheritance structure use "type" as a regular property.
            // These include: Library, VersionedIdentifier, and inner classes like Library$Usings
            // Skip conversion for these known types
            if (!isLibraryOrKnownType && 
                o.TryGetPropertyValue("type", out var typeProp) && 
                typeProp!.GetValueKind() == JsonValueKind.String)
            {
                var typeValue = typeProp.GetValue<string>();
                // Whitelist of types that use "type" as a property, not a discriminator
                // These are types with XmlTypeAttribute but NO XmlIncludeAttribute
                var nonPolymorphicTypes = new[]
                {
                    "Library", "VersionedIdentifier"
                };
                
                // Also skip inner classes like "Library$Usings"
                bool isKnownNonPolymorphic = nonPolymorphicTypes.Contains(typeValue) || 
                                              (typeValue?.Contains('$') ?? false);
                
                if (!isKnownNonPolymorphic && !string.IsNullOrEmpty(typeValue) && char.IsUpper(typeValue[0]))
                {
                    o.Remove("type");
                    o.Add("$type", typeProp);
                }
            }
            
            const string discriminatorName = "$type";
#else
            const string discriminatorName = "type";
#endif
            
            if (!o.TryGetPropertyValue(discriminatorName, out var discrim) || o.First().Value == discrim) return;

            var children = o.ToList();
            o.Clear();

            o.Add(discriminatorName, discrim);
            foreach (var nonType in children.Where(o => o.Key != discriminatorName)) o.Add(nonType);
        }

        static void fixType(JsonObject o, bool isLibraryOrKnownType)
        {
#if NET10_0_OR_GREATER
            const string discriminatorName = "$type";
            // Also handle legacy "type" property that might be an object (not a discriminator)
            if (o.TryGetPropertyValue("type", out var typePropLegacy) && typePropLegacy!.GetValueKind() == JsonValueKind.Object)
            {
                o.Remove("type");
                return;
            }
#else
            const string discriminatorName = "type";
#endif
            
            if (!o.TryGetPropertyValue(discriminatorName, out var typeProp)) return;

            if (typeProp!.GetValueKind() == JsonValueKind.Object)
                o.Remove(discriminatorName);
        }

        static bool IsEmptyObjectOrArray(JsonNode node) =>
            node is JsonObject { Count: 0 } or JsonArray { Count: 0 };

    }

    /// <summary>
    /// Serializes this library to a JSON string.
    /// </summary>
    public string SerializeToJson(bool writeIndented = true)
    {
        // I hope (and think) this will clone the original options,
        // including all cached metadata, otherwise serialization will be a
        // lot slower than it should be.
        var options = new JsonSerializerOptions(_jsonSerializerOptions)
        {
            WriteIndented = writeIndented
        };

        var container = new LibraryContainer(this);
        var json = JsonSerializer.Serialize(container, options);
        
#if NET10_0_OR_GREATER
        // In .NET 10, we use "$type" as the discriminator to avoid conflicts,
        // but for backward compatibility, convert it back to "type" in the output
        var node = JsonNode.Parse(json);
        if (node != null)
        {
            ConvertDollarTypeToType(node);
            json = node.ToJsonString(new JsonSerializerOptions { WriteIndented = writeIndented });
        }
#endif
        
        return json;
    }

#if NET10_0_OR_GREATER
    private static void ConvertDollarTypeToType(JsonNode node)
    {
        switch (node)
        {
            case JsonObject jo:
                if (jo.TryGetPropertyValue("$type", out var dollarType))
                {
                    jo.Remove("$type");
                    // Insert "type" at the beginning
                    var children = jo.ToList();
                    jo.Clear();
                    jo.Add("type", dollarType);
                    foreach (var child in children)
                        jo.Add(child);
                }
                foreach (var (_, value) in jo.ToList())
                {
                    if (value != null)
                        ConvertDollarTypeToType(value);
                }
                break;
            case JsonArray ja:
                foreach (var item in ja)
                {
                    if (item != null)
                        ConvertDollarTypeToType(item);
                }
                break;
        }
    }
#endif

    /// <summary>
    /// Writes this library in JSON format to <paramref name="stream"/>.
    /// </summary>
    /// <param name="stream">A writable stream.</param>
    /// <param name="writeIndented">If <see langword="true" />, formats the JSON with indenting.</param>
    public void WriteJson(Stream stream, bool writeIndented = true)
    {
        var options = new JsonSerializerOptions(_jsonSerializerOptions)
        {
            WriteIndented = writeIndented
        };

        var container = new LibraryContainer(this);
        
#if NET10_0_OR_GREATER
        // In .NET 10, we use "$type" as the discriminator to avoid conflicts,
        // but for backward compatibility, convert it back to "type" in the output
        var json = JsonSerializer.Serialize(container, options);
        var node = JsonNode.Parse(json);
        if (node != null)
        {
            ConvertDollarTypeToType(node);
            using var writer = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = writeIndented });
            node.WriteTo(writer);
        }
#else
        JsonSerializer.Serialize(stream, container, options);
#endif
    }


    private const int MaxDepth = 4096; // int.MaxValue is not a good idea
    private static JsonSerializerOptions _jsonSerializerOptions = BuildSerializerOptions(allowOldStyleTypeDiscriminators: false);
    private static JsonSerializerOptions _jsonDeserializerOptions = BuildSerializerOptions(allowOldStyleTypeDiscriminators: true);
    private static JsonDocumentOptions _jsonDocumentOptions = BuildJsonDocumentOptions();

    private static JsonDocumentOptions BuildJsonDocumentOptions()
    {
        var options = new JsonDocumentOptions()
        {
            MaxDepth = MaxDepth,
        };

        return options;
    }

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

        options.TypeInfoResolver = new PolymorphicTypeResolver(allowOldStyleTypeDiscriminators)
                                   .WithAddedModifier(ModifyNarrative)
                                   .WithAddedModifier(DoNotSerializeDefaultValues)
                                   .WithAddedModifier(HandleSpecifiedProperties);

        if(allowOldStyleTypeDiscriminators)
            options.TypeInfoResolver = options.TypeInfoResolver.WithAddedModifier(AllowOldStyleTypeDiscriminators);

        return options;
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
                if (EnableDebugAssertions && !shouldSerialize && !IsDefaultValue(value))
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
                yield return (valueProp, prop);
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
}
