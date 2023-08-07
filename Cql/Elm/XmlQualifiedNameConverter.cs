using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
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
