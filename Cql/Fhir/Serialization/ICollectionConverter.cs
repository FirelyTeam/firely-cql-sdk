using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.Serialization
{
    public class ICollectionConverter<TElement> : JsonConverter<ICollection<TElement>>
    {

        private Type CollectionType = typeof(List<>).MakeGenericType(typeof(TElement));

        public override ICollection<TElement> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.StartArray:
                    {
                        var list = Activator.CreateInstance(CollectionType) as ICollection<TElement>;
                        while (reader.Read())
                        {
                            if (reader.TokenType == JsonTokenType.EndArray)
                                break;
                            var element = JsonSerializer.Deserialize<TElement>(ref reader, options);
                            if (element != null)
                                list!.Add(element);
                        }
                        return list!;
                    }
                default:
                    {
                        var element = JsonSerializer.Deserialize<TElement>(ref reader, options);
                        var list = Activator.CreateInstance(CollectionType) as ICollection<TElement>;
                        if (element != null)
                            list!.Add(element);
                        return list!;
                    }
            }
        }

        public override void Write(Utf8JsonWriter writer, ICollection<TElement> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }

    public class ICollectionConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            if (typeToConvert.IsGenericType)
            {
                var gtd = typeToConvert.GetGenericTypeDefinition();
                if (gtd == typeof(ICollection<>))
                    return true;
            }
            return false;
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var elementType = typeToConvert.GetGenericArguments()[0];
            var converterType = typeof(ICollectionConverter<>).MakeGenericType(elementType);
            var converter = Activator.CreateInstance(converterType) as JsonConverter;
            return converter!;
        }
    }
}
