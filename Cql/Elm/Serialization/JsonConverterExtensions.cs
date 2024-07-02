/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Elm.Serialization
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
                    var readMethod = converterType.GetMethod(nameof(Read))!;
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
