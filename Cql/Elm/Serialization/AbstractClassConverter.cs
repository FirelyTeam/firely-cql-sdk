using System;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Xml.Serialization;

namespace Hl7.Cql.Elm.Serialization;

internal class AbstractClassConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        if(!typeToConvert.IsAbstract)
            return false;

        var xmlattrs = typeToConvert.GetCustomAttributes<XmlIncludeAttribute>(false);
        return xmlattrs.Any();
    }

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var converterType = typeof(AbstractClassConverter<>).MakeGenericType(typeToConvert);
        return (JsonConverter)Activator.CreateInstance(converterType)!;
    }
}

internal class AbstractClassConverter<T> : JsonConverter<T> where T : class
{
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var statedType = ScanReaderForInstanceType(ref reader);

        if(statedType is null)
            throw new JsonException("Could not find the 'type' property in the JSON object.");

        var concreteType = typeToConvert.Name == statedType ? typeToConvert : findSubtype(statedType);

        if(concreteType is null)
            throw new JsonException($"There is no {nameof(XmlIncludeAttribute)} on type {typeToConvert} for " +
                                    $" the specified type '{concreteType}'.");

        if (concreteType == typeToConvert)
        {
            return JsonSerializer.Deserialize<T>(ref reader, options);
        }
        else
            return (T?)JsonSerializer.Deserialize(ref reader, concreteType, options);

        Type? findSubtype(string name) =>
            typeToConvert.GetCustomAttributes<XmlIncludeAttribute>(false)
                .FirstOrDefault(a => a.Type?.Name == name)?.Type;
    }

    private static string? ScanReaderForInstanceType(ref Utf8JsonReader reader)
    {
        // Clone the reader so we can search ahead. Note, this only works
        // because we are in the context of a JsonConverter<T>.Read(), which means
        // the span of this object has been read completely and can be cloned.
        var scanner = reader;

        if (scanner.TokenType != JsonTokenType.StartObject)
            throw new JsonException("Expected an object.");

        while(scanner.Read() && scanner.TokenType == JsonTokenType.PropertyName)
        {
            if(scanner.GetString() == "type")
            {
                scanner.Read(); // move to the value
                return scanner.GetString() ?? throw new JsonException("Expected a string value for 'type'.");
            }

            // Else...
            scanner.Read(); // read to the value
            scanner.Skip(); // skip the value of the property
        }

        return null;
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        var nestedOptions = new JsonSerializerOptions(options);
        nestedOptions.TypeInfoResolver = new PolymorphicTypeResolver();
        JsonSerializer.Serialize(writer, value, value.GetType(), nestedOptions);
    }
}