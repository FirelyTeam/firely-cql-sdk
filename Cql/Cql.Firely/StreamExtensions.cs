#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System.Text.Json;

namespace Hl7.Cql.Fhir
{
    internal static class StreamExtensions
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
