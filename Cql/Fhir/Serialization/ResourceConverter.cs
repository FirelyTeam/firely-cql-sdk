using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.Serialization
{
    public class ResourceConverter<TResource> : JsonConverter<TResource>
        where TResource : class
    {
        public static IDictionary<string, Type> ResourceTypeMap()
        {
            var dictionary = new Dictionary<string, Type>();
            var type = typeof(TResource);
            var others = type.Assembly.GetTypes();
            foreach (var other in others)
            {
                var baseType = other.BaseType;
                while (baseType != null)
                {
                    if (baseType == type)
                    {
                        dictionary.Add(other.Name, other);
                        break;
                    }
                    baseType = baseType.BaseType;
                }
            }
            return dictionary;
        }

        public ResourceConverter(IDictionary<string, Type> resourceTypes, string typeProperty = "resourceType", bool strict = false)
        {
            if (resourceTypes is null)
            {
                throw new ArgumentNullException(nameof(resourceTypes));
            }

            if (string.IsNullOrWhiteSpace(typeProperty))
            {
                throw new ArgumentException($"'{nameof(typeProperty)}' cannot be null or whitespace.", nameof(typeProperty));
            }

            ResourceTypes = resourceTypes;
            TypeProperty = typeProperty;
            Strict = strict;
        }

        public IDictionary<string, Type> ResourceTypes { get; }
        public string TypeProperty { get; }
        public bool Strict { get; }

        public override TResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (JsonDocument.TryParseValue(ref reader, out var doc))
            {
                var rootElement = doc.RootElement;
                if (rootElement.TryGetProperty(TypeProperty, out var resouceTypeIdentifierProperty))
                {
                    var resourceTypeIdentifier = resouceTypeIdentifierProperty.GetString();
                    if (!string.IsNullOrWhiteSpace(resourceTypeIdentifier))
                    {
                        if (ResourceTypes.TryGetValue(resourceTypeIdentifier, out var type))
                        {
                            var json = rootElement.GetRawText();
                            var resourceSubtype = JsonSerializer.Deserialize(json, type, options) ??
                                throw new InvalidOperationException($"Unable to deserialize resource as type {type}");
                            var asResource = (TResource)resourceSubtype;
                            return asResource;
                        }
                        else if (Strict)
                        {
                            throw new JsonException($"Resource type {resourceTypeIdentifier} is not registerred.");
                        }
                    }
                    var resourceBaseType = JsonSerializer.Deserialize<TResource>(rootElement.GetRawText(), options) ??
                        throw new InvalidOperationException($"Unable to deserialize resource as type {typeof(TResource).Name}");
                    return resourceBaseType;
                }
                else if (Strict)
                {
                    throw new JsonException($"Resource is missing the {TypeProperty} property, which is required.");
                }
                else
                {
                    // can't pass options or this method will call itself.
                    var resourceBaseType = JsonSerializer.Deserialize<TResource>(rootElement.GetRawText()) ??
                        throw new InvalidOperationException($"Unable to deserialize resource as type {typeof(TResource).Name}");
                    return resourceBaseType;
                }
            }
            else throw new JsonException("Failed to parse resource object.");
        }



        public override void Write(Utf8JsonWriter writer, TResource value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}
