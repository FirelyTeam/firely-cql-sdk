/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Elm.Serialization
{
    internal class DefArrayConverter<T> : JsonConverter<T[]> where T : class
    {
        public override T[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var isDef = reader.TokenType == JsonTokenType.StartObject && reader.Read() &&
                            reader.TokenType == JsonTokenType.PropertyName &&
                            reader.GetString() == "def" && reader.Read();
            if (!isDef)
                incorrect();

            var innerOptions = withoutMe(options);
            var result = JsonSerializer.Deserialize<T[]>(ref reader, innerOptions);

            // read the final end object
            if (!reader.Read() || reader.TokenType != JsonTokenType.EndObject)
                incorrect();

            return result;

            static void incorrect() => throw new JsonException("A definition must be JSON object with a single 'def' property.");
        }

        public override void Write(Utf8JsonWriter writer, T[] value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("def");

            var nestedOptions = withoutMe(options);
            JsonSerializer.Serialize(writer, value, nestedOptions);

            writer.WriteEndObject();
        }

        private JsonSerializerOptions withoutMe(JsonSerializerOptions options)
        {
            var innerOptions = new JsonSerializerOptions(options);
            if(options.Converters.SingleOrDefault(c => c is TopLevelDefinitionConverterFactory) is {} fac)
                innerOptions.Converters.Remove(fac);

            return innerOptions;
        }
    }
}