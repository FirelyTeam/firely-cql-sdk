using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hl7.Cql.Firely
{
    public static class StreamExtensions
    {
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions()
            .ForFhir(ModelInfo.ModelInspector);
        public static T ParseFhir<T>(this Stream stream) => JsonSerializer.Deserialize<T>(stream, Options)
            ?? throw new ArgumentException($"Unable to deserialize this stream as {typeof(T).Name}");
        public static ValueTask<T> ParseFhirAsync<T>(this Stream stream) =>
            JsonSerializer.DeserializeAsync<T>(stream, Options)!;
        public static void WriteFhir<T>(this Stream stream, T fhir) =>
            JsonSerializer.Serialize<T>(stream, fhir, Options);
        public static string ToJson<T>(this T fhir) =>
            JsonSerializer.Serialize<T>(fhir, Options);


    }
}
