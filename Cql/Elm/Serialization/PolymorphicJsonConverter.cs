/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Elm.Serialization
{
    internal class PolymorphicJsonConverter<T> : JsonConverter<T>
    {
        public bool Strict { get; } = false;

        public PolymorphicJsonConverter(bool strict)
        {
            Strict = strict;
        }

        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.StartObject)
            {
                var instanceType = GetInstanceType(typeToConvert, reader);
                System.Diagnostics.Debug.Assert(instanceType != null);
                var t = CreateInstance(instanceType!, ref reader, options);
                return t;
            }
            else if (Strict)
            {
                throw new JsonException($"Invalid token {Encoding.UTF8.GetString(reader.ValueSpan)} at position {reader.TokenStartIndex}; not an object.");
            }
            else
            {
#if DEBUG_SERIALIZATION
                System.Diagnostics.Debug.WriteLine($"Skipping token {Encoding.UTF8.GetString(reader.ValueSpan)} at position {reader.TokenStartIndex}; not an object.");
#endif
                return default;
            }
        }

        private static T? CreateInstance(Type instanceType, ref Utf8JsonReader reader, JsonSerializerOptions options)
        {
            var t = (T)Activator.CreateInstance(instanceType)!;
            var properties = instanceType.GetProperties(
                BindingFlags.Public
                | BindingFlags.Instance
                | BindingFlags.GetProperty
                | BindingFlags.SetProperty)
                .ToDictionary(p => p.Name, StringComparer.OrdinalIgnoreCase);
            var valuePropertiesRead = properties
                .Values
                .Where(p => p.PropertyType.IsValueType)
                .ToDictionary(p => p.Name, p => false);
            if (reader.TokenType == JsonTokenType.StartObject)
            {
                reader.Read(); // start
                while (reader.TokenType != JsonTokenType.EndObject)
                {
                    if (reader.TokenType == JsonTokenType.PropertyName)
                    {
                        var propertyName = reader.GetString();
                        reader.Read(); // propertyName
                        if (!string.IsNullOrWhiteSpace(propertyName)
                            && properties.TryGetValue(propertyName, out var property))
                        {
                            object? value = null;
                            value = JsonSerializer.Deserialize(ref reader, property.PropertyType, options);
                            reader.Read();
                            valuePropertiesRead[propertyName] = true;
                            property.SetValue(t, value);
                        }
                        else if (reader.TokenType == JsonTokenType.StartObject
                            || reader.TokenType == JsonTokenType.StartArray)
                            reader.Skip(); // skip structure
                        else
                            reader.Read(); // skip value
                    }
                }
                foreach (var kvp in valuePropertiesRead)
                {
                    if (properties.TryGetValue($"{kvp.Key}specified", out var specifiedProperty))
                    {
                        specifiedProperty.SetValue(t, kvp.Value);
                    }
                }

                System.Diagnostics.Debug.Assert(reader.TokenType == JsonTokenType.EndObject);
                //reader.Read();
            }
            return t;
        }

        private static Type? GetInstanceType(Type typeToConvert, Utf8JsonReader reader)
        {
            Type? instanceType = typeToConvert;
            if (reader.TokenType == JsonTokenType.StartObject)
            {
                reader.Read(); // start
                while (reader.TokenType != JsonTokenType.EndObject)
                {
                    if (reader.TokenType == JsonTokenType.PropertyName)
                    {
                        var propertyName = reader.GetString();
                        reader.Read(); // propertyName
                        if (propertyName == "type")
                        {
                            var typeName = reader.GetString();
                            if (!string.IsNullOrWhiteSpace(typeName))
                                instanceType = typeToConvert.Assembly.GetType($"Hl7.Cql.Elm.{typeName}");
                            break;
                        }
                        if (reader.TokenType == JsonTokenType.StartObject
                            || reader.TokenType == JsonTokenType.StartArray)
                        {
                            reader.Skip(); // skip structure
                            reader.Read(); // read past closing of object/array
                        }
                        else reader.Read(); // skip value
                    }
                }
            }
            return instanceType;
        }


        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
