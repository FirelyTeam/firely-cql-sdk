using Hl7.Cql.Poco.Fhir.Serialization;
using System;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using Hl7.Cql.Poco.Fhir.R4.Model;
using Hl7.Cql.Poco.Fhir.R4.Serialization;
using NHl7.Cql.Poco.Fhir.Serialization;

namespace Hl7.Cql.Poco.Fhir.R4
{
    public static class FhirJson
    {
        public static JsonSerializerOptions GetJsonSerializerOptions(FhirOptions options = null)
        {
            var jsonOptions = new JsonSerializerOptions();
            return ConfigureJsonSerializerOptions(jsonOptions, options);
        }

        public static JsonSerializerOptions ConfigureJsonSerializerOptions(JsonSerializerOptions jsonOptions, 
            FhirOptions options = null)
        {
            var map = ResourceConverter<Resource>.ResourceTypeMap();
            jsonOptions.Converters.Add(new ResourceConverter<Resource>(map, strict: true));
            jsonOptions.Converters.Add(new R4EntryCollectionConverter());
            jsonOptions.AddR4Converters();
            if (options?.AllowSingleOrArray ?? false)
            {
                jsonOptions.Converters.Add(new ICollectionConverterFactory());
            }
            jsonOptions.IgnoreReadOnlyProperties = false;
            jsonOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            jsonOptions.WriteIndented = !options?.Minify ?? true;
            return jsonOptions;
        }

        private static Lazy<JsonSerializerOptions> DefaultOptions = new(() => GetJsonSerializerOptions(), true);
        public static T Deserialize<T>(Stream stream, FhirOptions options = null)
        {
            JsonSerializerOptions jsonOptions = null;
            if (options == null)
                jsonOptions = DefaultOptions.Value;
            else jsonOptions = GetJsonSerializerOptions(options);
            var obj = JsonSerializer.Deserialize<T>(stream, jsonOptions);
            return obj!;
        }
        public static T Deserialize<T>(string str, FhirOptions options = null)
        {
            JsonSerializerOptions jsonOptions = null;
            if (options == null)
                jsonOptions = DefaultOptions.Value;
            else jsonOptions = GetJsonSerializerOptions(options);
            var obj = JsonSerializer.Deserialize<T>(str, jsonOptions);
            return obj!;
        }
        public static async System.Threading.Tasks.Task<T> DeserializeAsync<T>(Stream stream, FhirOptions options = null)
        {

            JsonSerializerOptions jsonOptions = null;
            if (options == null)
                jsonOptions = DefaultOptions.Value;
            else jsonOptions = GetJsonSerializerOptions(options);
            var obj = await JsonSerializer.DeserializeAsync<T>(stream, jsonOptions);
            return obj!;
        }


        public static void Serialize<T>(T value, Stream stream, FhirOptions options = null)
        {
            JsonSerializerOptions jsonOptions = null;
            if (options == null)
                jsonOptions = DefaultOptions.Value;
            else jsonOptions = GetJsonSerializerOptions(options);
            JsonSerializer.Serialize<T>(stream, value, jsonOptions);
        }

        public static string SerializeToString<T>(T value, FhirOptions options = null)
        {
            using var ms = new MemoryStream();
            Serialize(value, ms, options);
            ms.Flush();
            var array = ms.ToArray();
            var json = Encoding.UTF8.GetString(array);
            return json;
        }

        public static T Deserialize<T>(Span<byte> span, FhirOptions options = null)
        {
            JsonSerializerOptions jsonOptions = null;
            if (options == null)
                jsonOptions = DefaultOptions.Value;
            else jsonOptions = GetJsonSerializerOptions(options);
            var obj = JsonSerializer.Deserialize<T>(span, jsonOptions);
            return obj!;
        }

    }
}
