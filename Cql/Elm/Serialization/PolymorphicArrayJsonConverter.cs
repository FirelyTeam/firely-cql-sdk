/*
 * Copyright (c) 2023, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Elm.Serialization;

internal class PolymorphicArrayJsonConverter<T>(bool allowOldStyleDefinitionTypeDiscriminators = false)
    : JsonConverter<T[]>
{
    public override T[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var atProp = reader.TokenType == JsonTokenType.StartObject &&
                     reader.Read() && reader.TokenType == JsonTokenType.PropertyName;
        if (!atProp)
            incorrect();

        // Ignore old-style type annotations, if allowed to
        if (allowOldStyleDefinitionTypeDiscriminators && reader.GetString() == "type")
        {
            if (!reader.Read() && reader.TokenType == JsonTokenType.String)
                incorrect();

            if (reader.GetString()?.StartsWith("Library$") != true)
                incorrect();

            reader.Read(); // next property
        }

        var isDef = reader.TokenType == JsonTokenType.PropertyName &&
                    reader.GetString() == "def" && reader.Read() &&
                    reader.TokenType == JsonTokenType.StartArray && reader.Read();

        if (!isDef)
            incorrect();

        List<T> elements = [];
        var elementType = typeToConvert.GetElementType()
                          ?? throw new InvalidOperationException("This converter only handles array types.");

        while (reader.TokenType != JsonTokenType.EndArray)
        {
            var instance = (T)JsonSerializer.Deserialize(ref reader, elementType, options)!;
            elements.Add(instance);

            if (!reader.Read())
                throw new JsonException($"Unexpected end of array at position {reader.TokenStartIndex}.");
        }

        if (!reader.Read() || reader.TokenType != JsonTokenType.EndObject)
            incorrect();

        return [.. elements];

        static void incorrect() => throw new JsonException("A definition must be JSON object with a single 'def' property.");
    }

    public override void Write(Utf8JsonWriter writer, T[] value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WritePropertyName("def");
        writer.WriteStartArray();

        foreach (var element in value)
            JsonSerializer.Serialize(writer, element, options);

        writer.WriteEndArray();
        writer.WriteEndObject();
    }
}