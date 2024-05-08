using System;
using Newtonsoft.Json;
using JsonException = Newtonsoft.Json.JsonException;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Hl7.Cql.Elm.Serialization;

internal class NsDefArrayConverter : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        writer.WriteStartObject();
        writer.WritePropertyName("def");

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
        var isDef = reader.TokenType == JsonToken.StartObject && reader.Read() &&
                    reader.TokenType == JsonToken.PropertyName &&
                    (string?)reader.Value == "def" && reader.Read();
        if (!isDef)
            incorrect();

        try
        {
            Disabled = true;
            existingValue = serializer.Deserialize(reader, objectType);
        }
        finally
        {
            Disabled = false;
        }

        // read the final end object
        if (!reader.Read() || reader.TokenType != JsonToken.EndObject)
            incorrect();

        return existingValue;

        static void incorrect() => throw new JsonException("A definition must be JSON object with a single 'def' property.");
    }

    public override bool CanConvert(Type objectType)
    {
        if(Disabled) return false;

        return objectType == typeof(UsingDef[]) ||
               objectType == typeof(IncludeDef[]) ||
               objectType == typeof(ParameterDef[]) ||
               objectType == typeof(CodeSystemDef[]) ||
               objectType == typeof(ValueSetDef[]) ||
               objectType == typeof(CodeDef[]) ||
               objectType == typeof(ConceptDef[]) ||
               objectType == typeof(ContextDef[]) ||
               objectType == typeof(ExpressionDef[]);
    }

    [ThreadStatic]
    private static bool Disabled;
}