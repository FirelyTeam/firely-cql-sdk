using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hl7.Cql.Elm
{
    internal class XmlIncludeConverterFactory : JsonConverterFactory
    {

        public bool Strict { get; }
        private readonly object[] StrictParams;
        public XmlIncludeConverterFactory(bool strict)
        {
            Strict = strict;
            StrictParams = new object[] { strict };
        }

        public override bool CanConvert(Type typeToConvert)
        {
            if (typeToConvert.IsArray)
            {
                var elementType = typeToConvert.GetElementType()
                    ?? throw new JsonException($"Type to convert claims to be an array but has no element type");
                var attributes = elementType.GetCustomAttributes<XmlIncludeAttribute>(false);
                if (attributes.Any())
                    return true;
                return false;
            }
            else
            {
                var attributes = typeToConvert.GetCustomAttributes<XmlIncludeAttribute>(false);
                if (attributes.Any())
                    return true;
                return false;
            }
        }

        public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            if (typeToConvert.IsArray)
            {
                var elementType = typeToConvert.GetElementType() 
                    ?? throw new JsonException($"Type to convert claims to be an array but has no element type");
                var type = typeof(PolymorphicArrayJsonConverter<>).MakeGenericType(elementType);
                var instance = (JsonConverter)Activator.CreateInstance(type, StrictParams)!;
                return instance;
            }
            else
            {
                var type = typeof(PolymorphicJsonConverter<>).MakeGenericType(typeToConvert);
                var instance = (JsonConverter)Activator.CreateInstance(type, StrictParams)!;
                return instance;
            }
        }
    }
}
