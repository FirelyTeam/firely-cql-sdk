using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace Hl7.Cql.Elm
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
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                if (typeToConvert.IsArray)
                {
                    reader.Read(); // past the start array
                    var elements = new List<T>();
                    var elementType = typeToConvert.GetElementType()
                        ?? throw new JsonException($"Type to convert claims to be an array but has no element type");
                    while (reader.TokenType != JsonTokenType.EndArray)
                    {
                        var instance = (T)JsonSerializer.Deserialize(ref reader, elementType, options)!;
                        reader.Read();
                        elements.Add(instance);
                    }
                    return elements.ToArray();
                }
                else throw new JsonException($"Type to convert is not an array type");
            }
            else if (Strict)
            {
                throw new JsonException($"Invalid token {Encoding.UTF8.GetString(reader.ValueSpan)} at position {reader.TokenStartIndex}; not an object.");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"Skipping token {Encoding.UTF8.GetString(reader.ValueSpan)} at position {reader.TokenStartIndex}; not an object.");
                return null;
            }
        }

        public override void Write(Utf8JsonWriter writer, T[] value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
