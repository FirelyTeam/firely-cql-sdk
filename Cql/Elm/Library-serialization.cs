using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Hl7.Cql.Elm.Serialization;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

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
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
            UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,

        };

        options.Converters.Add(new TopLevelDefinitionConverterFactory());
        options.Converters.Add(new XmlQualifiedNameConverter());
        options.Converters.Add(new JsonStringEnumConverter());

        options.TypeInfoResolver = new PolymorphicTypeResolver();
        return options;
    }

    // private static JsonSerializerOptions GetDeserializerOptions()
    // {
    //     var options = new JsonSerializerOptions
    //     {
    //         MaxDepth = int.MaxValue,
    //         DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    //         UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,
    //     };
    //
    //     options.Converters.Add(new TopLevelDefinitionConverterFactory());
    //     options.Converters.Add(new XmlQualifiedNameConverter());
    //     options.Converters.Add(new JsonStringEnumConverter());
    //
    //     options.TypeInfoResolver = new PolymorphicTypeResolver();
    //     return options;
    // }


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
        visit(node!);

        var container = JsonSerializer.Deserialize<LibraryContainer>(node, options)!;
        return container.library;
    }

    static void reorder(JsonObject o)
    {
        if (o.TryGetPropertyValue("type", out var typeProp) && o.First().Value != typeProp)
        {
            var children = o.ToList();
            o.Clear();

            o.Add("type", typeProp);
            foreach (var nonType in children.Where(o => o.Key != "type")) o.Add(nonType);
        }
    }

    static void visit(JsonNode a)
    {
        switch(a)
        {
            case JsonObject jo:
                reorder(jo);
                foreach (var child in jo.Select(o => o.Value).Where(o => o != null)) visit(child!);
                break;
            case JsonArray ja:
                foreach(var element in ja.Where(o => o != null)) visit(element!);
                break;
            default:
                break;
        }
    }


    private static JsonSerializerOptions GetDeserializerOptions(bool strict, bool indented)
    {
        var options = new JsonSerializerOptions
        {
            MaxDepth = int.MaxValue,
            WriteIndented = indented
        };

        options.Converters.Add(new LibraryJsonConverter());
        options.Converters.Add(new TopLevelDefinitionConverterFactory());
        options.Converters.Add(new AbstractClassConverterFactory());
        //options.AddPolymorphicConverters(strict);
        options.Converters.Add(new XmlQualifiedNameConverter());
        options.Converters.Add(new JsonStringEnumConverter());

        //options.TypeInfoResolver = new PolymorphicTypeResolver();
        return options;
    }


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