using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Poco.Fhir.Serialization
{
    public abstract class ElementConverter<TElement> : JsonConverter<TElement>
    {
        protected ElementConverter(JsonTokenType[] tokenTypes, Type propertyType)
        {
            if (tokenTypes is null)
            {
                throw new ArgumentNullException(nameof(tokenTypes));
            }

            if (propertyType is null)
            {
                throw new ArgumentNullException(nameof(propertyType));
            }
            TokenTypes = tokenTypes;
            PropertyType = propertyType;
        }

        public JsonTokenType[] TokenTypes { get; }
        public Type PropertyType { get; }

        public override TElement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartObject)
            {
                var @default = JsonSerializer.Deserialize(ref reader, typeToConvert, options);
                return (TElement)@default!;
            }
            else
            {
                for (int i = 0; i < TokenTypes.Length; i++)
                {
                    if (TokenTypes[i] == reader.TokenType)
                    {
                        var instance = (TElement)Activator.CreateInstance(typeToConvert);
                        if (reader.TokenType == JsonTokenType.String)
                        {
                            var @string = Encoding.UTF8.GetString(reader.ValueSpan);
                            Assign(instance, @string);
                        }
                        else if (reader.TokenType == JsonTokenType.Number)
                        {
                            var value = JsonSerializer.Deserialize<decimal?>(reader.ValueSpan, options);
                            Assign(instance, value);
                        }
                        else if (reader.TokenType == JsonTokenType.True || reader.TokenType == JsonTokenType.False)
                        {
                            var value = JsonSerializer.Deserialize<bool?>(reader.ValueSpan, options);
                            Assign(instance, value);
                        }
                        return instance;
                    }
                }
                throw new JsonException($"{typeof(TElement).Name} does not allow a token type of {Enum.GetName(typeof(JsonTokenType), reader.TokenType)}.");
            }
        }

        protected abstract void Assign(TElement element, string value);
        protected abstract void Assign(TElement element, decimal? value);
        protected abstract void Assign(TElement element, bool? value);

    }
}
