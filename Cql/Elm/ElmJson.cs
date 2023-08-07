using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hl7.Cql.Elm
{
    public class ElmJson
    {
        public static T Deserialize<T>(string json, JsonReaderOptions options = default)
        {
            var bytes = Encoding.UTF8.GetBytes(json);
            var reader = new Utf8JsonReader(bytes.AsSpan(), options);
            var t = Deserialize<T>(ref reader);
            return t;
        }
        public static T Deserialize<T>(Stream stream, JsonReaderOptions options = default)
        {
            MemoryStream ms;
            if (stream is MemoryStream _ms)
                ms = _ms;
            else
            {
                ms = new MemoryStream();
                stream.CopyTo(ms);
                ms.Flush();
            }
            var bytes = ms.GetBuffer();
            ms.Dispose();
            var reader = new Utf8JsonReader(bytes.AsSpan(), options);
            var t = Deserialize<T>(ref reader);
            return t;
        }

        public static T Deserialize<T>(ref Utf8JsonReader reader)
        {
            if (!reader.Read())
                throw new JsonException($"Cannot read JSON");

            var instanceType = typeof(T);
            if (typeof(T).GetCustomAttributes<XmlIncludeAttribute>(false).Any())
            {
                instanceType = GetInstanceType(typeof(T), reader);
            }
            var t = (T)CreateInstance(instanceType!, ref reader)!;
            return t;

        }
        private static object? CreateInstance(Type instanceType, ref Utf8JsonReader reader)
        {
            var t = Activator.CreateInstance(instanceType);
            var properties = instanceType.GetProperties(
                BindingFlags.Public
                | BindingFlags.Instance
                | BindingFlags.GetProperty
                | BindingFlags.SetProperty)
                .ToDictionary(p => p.Name, StringComparer.OrdinalIgnoreCase);
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
                            if (reader.TokenType == JsonTokenType.StartObject)
                            {
                            }
                            else if (reader.TokenType == JsonTokenType.StartArray)
                            {
                                reader.Read(); // start array
                                var arrayElementType = property.PropertyType.GetElementType();
                                while (reader.TokenType != JsonTokenType.EndArray)
                                {
                                }
                                reader.Read(); // end array
                            }
                            else
                            {
                                var value = reader.GetString();
                                if (value != null)
                                {
                                    var converted = System.Convert.ChangeType(value, property.PropertyType);
                                }
                                reader.Read();
                            }
                        }
                        else if (reader.TokenType == JsonTokenType.StartObject
                            || reader.TokenType == JsonTokenType.StartArray)
                            reader.Skip(); // skip structure
                        else reader.Read(); // skip value
                    }
                }
                System.Diagnostics.Debug.Assert(reader.TokenType == JsonTokenType.EndObject);
                reader.Read();
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
                            reader.Skip(); // skip structure
                        else reader.Read(); // skip value
                    }
                }
            }
            return instanceType;
        }
    }
}
