using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Hl7.Cql.Elm.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Xml.Serialization;
using Hl7.Cql.Abstractions.Exceptions;
using InvalidOperationException = System.InvalidOperationException;
using PropAndSpecified=(System.Text.Json.Serialization.Metadata.JsonPropertyInfo valueProp, System.Text.Json.Serialization.Metadata.JsonPropertyInfo valuePropSpecified);

namespace Hl7.Cql.Elm;


#pragma warning disable CS1591

// The property should be 'library', not 'Library', to match the JSON structure.
// ReSharper disable once InconsistentNaming
internal record LibraryContainer(Library library);

public partial class Library
{
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

        return container.library;
    }

    private static void CorrectLegacyConstructs(JsonNode a)
    {
        switch(a)
        {
            case JsonObject jo:
                reorder(jo);
                fixType(jo);
                foreach (var child in jo.Select(o => o.Value).Where(o => o != null)) CorrectLegacyConstructs(child!);
                break;
            case JsonArray ja:
                foreach(var element in ja.Where(o => o != null)) CorrectLegacyConstructs(element!);
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

            if (typeProp!.GetValueKind() == JsonValueKind.Object)
                o.Remove("type");
        }

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
        return JsonSerializer.Serialize(container, options);
    }

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
        JsonSerializer.Serialize(stream, container, options);
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
                if (!shouldSerialize && !IsDefaultValue(value))
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
            var typeProp = ti.CreateJsonPropertyInfo(typeof(string), "type");
            typeProp.ShouldSerialize = (_, _) => false;
            typeProp.Set = (_, value) =>
                {
                    if( (string?)value != expected)
                        throw new JsonException("Library's type property should always be 'Library'.");
                };
            ti.Properties.Add(typeProp);
        }
    }

}