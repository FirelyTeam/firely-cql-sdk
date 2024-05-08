using System;
using System.Xml;
using Newtonsoft.Json;

namespace Hl7.Cql.Elm.Serialization;

internal class NsXmlQualifiedNameConverter : JsonConverter<XmlQualifiedName>
{
    public override void WriteJson(JsonWriter writer, XmlQualifiedName? value, JsonSerializer serializer)
    {
        if (value == null)
            writer.WriteNull();
        else
            writer.WriteValue(value.Name);
    }

    public override XmlQualifiedName? ReadJson(JsonReader reader, Type objectType, XmlQualifiedName? existingValue, bool hasExistingValue,
        JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.String)
        {
            var value = (string?)reader.Value;
            return new XmlQualifiedName(value);
        }
        else throw new JsonException($"Expecting a string token when parsing a {nameof(XmlQualifiedName)}");
    }
}