/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace Hl7.Cql.Elm
{
    internal class XmlQualifiedNameConverter : JsonConverter<XmlQualifiedName>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return base.CanConvert(typeToConvert);
        }

        public override XmlQualifiedName? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var value = reader.GetString();
                return new XmlQualifiedName(value);
            }
            else throw new JsonException($"{nameof(XmlQualifiedNameConverter)} was called to deserialize a non-string token");
        }

        public override void Write(Utf8JsonWriter writer, XmlQualifiedName value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Name);
        }
    }
}
