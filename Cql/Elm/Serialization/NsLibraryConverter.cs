using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Hl7.Cql.Elm.Serialization;

internal class NsLibraryConverter : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        writer.WriteStartObject();
        writer.WritePropertyName("library");

        try
        {
            Disabled = true;
            serializer.Serialize(writer, value);
        }
        finally
        {
            Disabled = false;
        }

        writer.WriteEndObject();
    }

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        var isLibrary = reader.TokenType == JsonToken.StartObject && reader.Read() &&
                        reader.TokenType == JsonToken.PropertyName &&
                        (string?)reader.Value == "library" && reader.Read();
        if (!isLibrary)
            incorrect();

        Library result;

        try
        {
            Disabled = true;
            result = serializer.Deserialize<Library>(reader)!;
        }
        finally
        {
            Disabled = false;
        }

        // read the final end object
        if (!reader.Read() || reader.TokenType != JsonToken.EndObject)
            incorrect();

        return result;

        static void incorrect() => throw new JsonException("Library should be a JSON object with a single 'library' property.");
    }

    public override bool CanConvert(Type objectType)
    {
        if (Disabled) return false;

        return objectType == typeof(Library);
    }

    [ThreadStatic]
    private static bool Disabled;
}