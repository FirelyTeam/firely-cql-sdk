/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Elm.Serialization
{
    internal class PolymorphicArrayJsonConverter<T> : JsonConverter<T[]>
    {
        public bool Strict { get; } = false;

        public PolymorphicArrayJsonConverter(bool strict)
        {
            Strict = strict;
        }

        public override T[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var isDef = reader.TokenType == JsonTokenType.StartObject && reader.Read() &&
                        reader.TokenType == JsonTokenType.PropertyName &&
                        reader.GetString() == "def" && reader.Read() &&
                        reader.TokenType == JsonTokenType.StartArray && reader.Read();

            if (!isDef)
            {
                if (Strict)
                    throw new JsonException($"Invalid token {Encoding.UTF8.GetString(reader.ValueSpan)} at position {reader.TokenStartIndex}; not an object.");
                else
                {
#if DEBUG_SERIALIZATION
                System.Diagnostics.Debug.WriteLine($"Skipping token {Encoding.UTF8.GetString(reader.ValueSpan)} at position {reader.TokenStartIndex}; not an object.");
#endif
                    return null;
                }
            }

            var elements = new List<T>();
            var elementType = typeToConvert.GetElementType()
                              ?? throw new InvalidOperationException("This converter only handles array types.");

            while(reader.TokenType != JsonTokenType.EndArray)
            {
                var instance = (T)JsonSerializer.Deserialize(ref reader, elementType, options)!;
                elements.Add(instance);

                if(!reader.Read())
                    throw new JsonException($"Unexpected end of array at position {reader.TokenStartIndex}.");
            }

            if (!reader.Read() || reader.TokenType != JsonTokenType.EndObject)
                throw new JsonException($"Unexpected end of object at position {reader.TokenStartIndex}.");;

            return elements.ToArray();
        }

        public override void Write(Utf8JsonWriter writer, T[] value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("def");
            writer.WriteStartArray();

            foreach(var element in value)
                JsonSerializer.Serialize(writer, element, options);

            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}