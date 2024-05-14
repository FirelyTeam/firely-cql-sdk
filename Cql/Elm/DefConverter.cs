/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Elm
{
    internal class DefConverter<T> : JsonConverter<T[]> where T : class
    {
        public override T[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (JsonDocument.TryParseValue(ref reader, out var doc))
            {
                var root = doc.RootElement;
                if (root.TryGetProperty("def", out var defElement))
                {
                    var array = new T[defElement.GetArrayLength()];
                    int i = 0;
                    foreach (var ele in defElement.EnumerateArray())
                    {
                        var json = ele.GetRawText();
                        var t = JsonSerializer.Deserialize<T>(json, options)!;
                        array[i] = t;
                        i++;
                    }
                    return array;
                }
                else return null;
            }
            return null;
        }

        public override void Write(Utf8JsonWriter writer, T[] value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
