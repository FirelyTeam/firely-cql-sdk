using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Xml.Serialization;

namespace Hl7.Cql.Elm.Serialization;

internal class AbstractClassConverterFactory : JsonConverterFactory
{
    public static void SkipNext()
    {
        SkipOnce = true;
    }

    [ThreadStatic]
    private static bool SkipOnce;

    public override bool CanConvert(Type typeToConvert)
    {
        if (SkipOnce)
        {
            SkipOnce = false;
            return false;
        }

        if (typeToConvert == typeof(AliasedQuerySource)) return false;

        var xmlattrs = typeToConvert.GetCustomAttributes<XmlIncludeAttribute>(false);
        if (xmlattrs.Any()) return true;

        if (typeToConvert.BaseType is { } baseType && baseType != typeof(Element))
        {
            xmlattrs = baseType.GetCustomAttributes<XmlIncludeAttribute>(false)
                .Where(ca => ca.Type == typeToConvert);
            return xmlattrs.Any();
        }

        return false;
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

        if(statedType is null && typeToConvert.IsAbstract)
            throw new JsonException("Could not find the 'type' property in the JSON object.");

        var concreteType = typeToConvert.Name == statedType || statedType == null
            ? typeToConvert
            : findSubtype(statedType);

        if(concreteType is null)
            throw new JsonException($"There is no {nameof(XmlIncludeAttribute)} on type {typeToConvert} for " +
                                    $" the specified type '{concreteType}'.");

        AbstractClassConverterFactory.SkipNext();

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
        throw new NotImplementedException();
        // var nestedOptions = new JsonSerializerOptions(options);
        // nestedOptions.TypeInfoResolver = new PolymorphicTypeResolver();
        // JsonSerializer.Serialize(writer, value, value.GetType(), nestedOptions);
    }
}