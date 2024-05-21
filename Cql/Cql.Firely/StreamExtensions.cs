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
using System.Text.Json.Serialization;

namespace Hl7.Cql.Fhir
{
    public static class StreamExtensions
    {
        private static readonly JsonSerializerOptions Options = BuildJsonSerializerOptions();

        private static JsonSerializerOptions BuildJsonSerializerOptions()
        {
            var o = new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector);
            o.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            return o;
        }

        public static T ParseFhir<T>(this Stream stream) =>
            JsonSerializer.Deserialize<T>(stream, Options) ?? throw new ArgumentException($"Unable to deserialize this stream as {typeof(T).Name}");
    }
}
