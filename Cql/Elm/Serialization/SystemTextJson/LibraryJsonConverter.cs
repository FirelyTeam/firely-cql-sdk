/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Elm.Serialization
{
    internal class LibraryJsonConverter : JsonConverter<Library>
    {
        public override Library? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var isLibrary = reader.TokenType == JsonTokenType.StartObject && reader.Read() &&
                            reader.TokenType == JsonTokenType.PropertyName &&
                            reader.GetString() == "library" && reader.Read();
            if (!isLibrary)
                incorrect();

            var nestedOptions = new JsonSerializerOptions(options);
            nestedOptions.Converters.Remove(this);

            var result = JsonSerializer.Deserialize<Library>(ref reader, nestedOptions);

            // read the final end object
            if (!reader.Read() || reader.TokenType != JsonTokenType.EndObject)
                incorrect();

            return result;

            static void incorrect() => throw new JsonException("Library should be a JSON object with a single 'library' property.");
        }

        public override void Write(Utf8JsonWriter writer, Library value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("library");

            var nestedOptions = new JsonSerializerOptions(options);
            nestedOptions.Converters.Remove(this);

            JsonSerializer.Serialize(writer, value, nestedOptions);

            writer.WriteEndObject();
        }
    }
}