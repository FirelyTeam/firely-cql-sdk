using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Hl7.Cql.Elm.Serialization;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Text.Json.Serialization.Metadata;

namespace Hl7.Cql.Elm;

#pragma warning disable CS1591


internal record LibraryContainer(Library library);

public partial class Library
{
    private static JsonSerializerOptions GetSerializerOptions(bool indented)
    {
        var options = new JsonSerializerOptions
        {
            MaxDepth = int.MaxValue,
            WriteIndented = indented,
            UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,
        };

        options.Converters.Add(new TopLevelDefinitionConverterFactory());
        options.Converters.Add(new XmlQualifiedNameConverter());
        options.Converters.Add(new JsonStringEnumConverter());

        options.TypeInfoResolver = new PolymorphicTypeResolver()
                .WithAddedModifier(modifyNarrative)
                .WithAddedModifier(DoNotSerializeDefaultValues);
            ;
        return options;
    }

    private static void DoNotSerializeDefaultValues(JsonTypeInfo ti)
    {
        foreach (var prop in ti.Properties)
        {
            // if (prop.AttributeProvider?.GetCustomAttributes(typeof(DefaultValueAttribute), false).FirstOrDefault() is DefaultValueAttribute attr)
            //     prop.ShouldSerialize = (_, v) => v is not null && (prop.PropertyType.IsEnum || ti.Type == typeof(Interval) || !Equals(v, attr.Value));
            // else
            //     prop.ShouldSerialize = (_, v) =>  v is not null;
            //prop.ShouldSerialize = (_, v) =>  v is not null && (prop.PropertyType.IsEnum || !Equals(v,GetDefaultValue(prop.PropertyType)));
            // prop.ShouldSerialize = (_, v) => v is not null &&
            //                                 (prop.PropertyType.IsEnum ||
            //                                 (defaultAttr != null && !Equals(v, defaultAttr.Value)) ||
            //                                 (defaultAttr == null && !Equals(v,GetDefaultValue(prop.PropertyType)))
            //                                 );

            prop.ShouldSerialize = shouldSerialize;

            bool shouldSerialize(object parent, object? value)
            {
                if (value is null) return false;
                if (prop.PropertyType.IsEnum) return true;

                if (ti.Type == typeof(Interval)) return true;

                var defaultAttr = prop.AttributeProvider?
                    .GetCustomAttributes(typeof(DefaultValueAttribute), false)
                    .FirstOrDefault() as DefaultValueAttribute;

                var defaultValue = defaultAttr?.Value ?? getDefaultValue(prop.PropertyType);

                return !Equals(value, defaultValue);
            }

            static object? getDefaultValue(Type type) {
                return type.IsValueType ? Activator.CreateInstance(type) : null;
            }
        }
    }

    private static void modifyNarrative(JsonTypeInfo ti)
    {
        // Make sure Narrative.Text is serialized as "value" in the json, not as "Text"
        if (ti.Type != typeof(Narrative)) return;

        var valueProp = ti.Properties.FirstOrDefault(p => p.Name == "Text");

        if (valueProp != null)
            valueProp.Name = "value";
    }

    public string SerializeToJsonSTJ(bool writeIndented = true)
    {
        var options = GetSerializerOptions(writeIndented);

        var container = new LibraryContainer(this);
        return JsonSerializer.Serialize(container, options);
    }

    public static Library DeserializeFromJsonSTJ(string json)
    {
        var options = GetSerializerOptions(false);

        var node = JsonNode.Parse(json);
        Visit(node!);

        var container = JsonSerializer.Deserialize<LibraryContainer>(node, options)!;
        return container.library;
    }

    private static void Reorder(JsonObject o)
    {
        if (!o.TryGetPropertyValue("type", out var typeProp) || o.First().Value == typeProp) return;

        var children = o.ToList();
        o.Clear();

        o.Add("type", typeProp);
        foreach (var nonType in children.Where(o => o.Key != "type")) o.Add(nonType);
    }

    private static void Visit(JsonNode a)
    {
        switch(a)
        {
            case JsonObject jo:
                Reorder(jo);
                foreach (var child in jo.Select(o => o.Value).Where(o => o != null)) Visit(child!);
                break;
            case JsonArray ja:
                foreach(var element in ja.Where(o => o != null)) Visit(element!);
                break;
        }
    }

    internal static readonly JsonSerializerSettings JsonSerializerSettings = new()
    {
        Converters = new List<Newtonsoft.Json.JsonConverter>()
        {
            new NsLibraryConverter(),
            new NsSubclassConverter(),
            new NsDefArrayConverter(),
            new NsXmlQualifiedNameConverter(),
            new NsNarrativeConverter()
        },

        NullValueHandling = NullValueHandling.Ignore,
        DefaultValueHandling = DefaultValueHandling.Ignore,
        MissingMemberHandling = MissingMemberHandling.Error,
        ContractResolver = new NsTypeDiscriminatorContractResolver()
    };


    /// <summary>
    /// Loads a library from a JSON file.
    /// </summary>
    public static Library LoadFromJson(FileInfo file)
    {
        if (!file.Exists)
            throw new ArgumentException($"File {file.FullName} does not exist.");
        using var stream = file.OpenRead();
        return LoadFromJson(stream);
    }

    // public static Library LoadFromJson(Stream stream) =>
    //     JsonSerializer.Deserialize<Library>(stream, JsonSerializerOptions) ??
    //         throw new ArgumentException($"Stream does not represent a valid {nameof(Library)}");

    /// <summary>
    /// Loads a library from a stream containing JSON.
    /// </summary>
    public static Library LoadFromJson(Stream stream)
    {
        using var sr = new StreamReader(stream);
        return LoadFromJson(sr);
    }


    /// <summary>
    /// Loads a library from a JSON string.
    /// </summary>
    public static Library ParseFromJson(string json)
    {
        var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);

        using var sr = new StringReader(json);
        using var jr = new JsonTextReader(sr);
        return serializer.Deserialize<Library>(jr)!;
    }


    /// <summary>
    /// Loads a library from a stream containing JSON.
    /// </summary>
    public static Library LoadFromJson(TextReader reader)
    {
        var serializer = Newtonsoft.Json.JsonSerializer.Create(JsonSerializerSettings);
        using var jr = new JsonTextReader(reader);
        return serializer.Deserialize<Library>(jr)!;
    }


    public string SerializeToJson(bool writeIndented = true)
    {
        var settings = new JsonSerializerSettings(JsonSerializerSettings)
        {
            Formatting = writeIndented ? Formatting.Indented : Formatting.None
        };
        var serializer = Newtonsoft.Json.JsonSerializer.Create(settings);

        using var sw = new StringWriter();
        using var jw = new JsonTextWriter(sw);
        serializer.Serialize(jw, this);
        jw.Flush();

        return sw.ToString();
    }

    /// <summary>
    /// Writes this library in JSON format to <paramref name="stream"/>.
    /// </summary>
    /// <param name="stream">A writable stream.</param>
    /// <param name="writeIndented">If <see langword="true" />, formats the JSON with indenting.</param>
    public void WriteJson(Stream stream, bool writeIndented = true)
    {
        var settings = new JsonSerializerSettings(JsonSerializerSettings)
        {
            Formatting = writeIndented ? Formatting.Indented : Formatting.None
        };
        var serializer = Newtonsoft.Json.JsonSerializer.Create(settings);

        using var sw = new StreamWriter(stream);
        serializer.Serialize(sw, this);
        sw.Flush();
    }

}