using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hl7.Cql.Elm
{
    internal static class JsonConverterExtensions
    {
        private delegate object? ReadDelegate(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);
        public static object? Read(this JsonConverter converter, ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var converterType = converter.GetType();
            var converterBaseType = converterType.BaseType;
            if (converterBaseType != null && converterBaseType.IsGenericType)
            {
                var gtd = converterBaseType.GetGenericTypeDefinition();
                if (typeof(JsonConverter<>).IsAssignableFrom(gtd))
                {
                    var readMethod = converterType.GetMethod(nameof(Read));
                    var @delegate = readMethod.CreateDelegate<ReadDelegate>(converter);
                    var result = @delegate(ref reader, typeToConvert, options);
                    return result;
                }
            }
            else if (converterBaseType == typeof(JsonConverterFactory))
            {
            }
            throw new NotSupportedException($"Type {converterType.FullName} is not supported.");
        }
    }
}
