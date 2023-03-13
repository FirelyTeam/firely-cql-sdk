using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4
{
    public class R4EntryCollection : EntryCollection<Bundle.EntryComponent>
    {
        public R4EntryCollection(): this(null, null)
        {
        }

        public R4EntryCollection(IEqualityComparer<string> idComparer = null,
            IEqualityComparer<string> urlComparer = null) : base((entry) => entry.resource)
        {
            IdComparer = idComparer ?? StringComparer.OrdinalIgnoreCase;
            UrlComparer = urlComparer ?? StringComparer.OrdinalIgnoreCase;
        }

        public IEqualityComparer<string> IdComparer { get; }
        public IEqualityComparer<string> UrlComparer { get; }

        public override TResource GetResourceById<TResource>(string id)
            where TResource: class
        {
            var ofType = GetResourcesByType<TResource>();
            var withId = ofType
                .Where(r => r is Resource resource && IdComparer.Equals(resource.id?.value!, id))
                .ToArray();
            if (withId.Length == 0)
                return null;
            else if (withId.Length > 1)
                throw new ArgumentException($"More than one resource of type {typeof(TResource)} has id {id}");
            else return withId[0];    
        }

        public override TResource GetResourceByUrl<TResource>(string url)
            where TResource : class
        {
            var ofType = GetResourcesByType<TResource>();
            var withId = ofType
                .Where(r => UrlComparer.Equals(GetUri(r)!, url))
                .ToArray();
            if (withId.Length == 0)
                return null;
            else if (withId.Length > 1)
                throw new ArgumentException($"More than one resource of type {typeof(TResource)} has url {url}");
            else return withId[0];
        }

        private string GetUri(object resource)
        {
            if (resource == null)
                return null;
            var property = resource.GetType().GetProperty("url", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            if (property != null && property.PropertyType == typeof(UriElement))
            {
                var ue = property.GetValue(resource) as UriElement;
                return ue?.value;
            }
            return null;
        }
    }

    public class R4EntryCollectionConverter : JsonConverter<IEntryCollection<Bundle.EntryComponent>>
    {
        public override IEntryCollection<Bundle.EntryComponent> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var collection = JsonSerializer.Deserialize<R4EntryCollection>(ref reader, options);
            return collection;
        }

        public override void Write(Utf8JsonWriter writer, IEntryCollection<Bundle.EntryComponent> value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize<IEnumerable<Bundle.EntryComponent>>(writer, value, options);
        }
    }
}
