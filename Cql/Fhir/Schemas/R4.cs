using Ncqa.Fhir.Schemas.r4;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Ncqa.Fhir.Schemas
{
    public static class R4
    {
        private static readonly Lazy<r4.Schema> schema = new Lazy<r4.Schema>(() =>
        {
            using var stream = typeof(r4.Schema).Assembly.GetManifestResourceStream("r4");
            using var streamReader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(streamReader);
            var serializer = new JsonSerializer();
            serializer.PreserveReferencesHandling = PreserveReferencesHandling.None;
            serializer.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;
            var r4 = serializer.Deserialize<r4.Schema>(jsonReader) ??
                throw new InvalidOperationException("Can't deserialize JSON as a Schema");
            return r4;
        });
        private static readonly Lazy<Bundle> profilesOthers = new Lazy<Bundle>(() =>
        {
        
            using var stream = typeof(r4.Bundle).Assembly.GetManifestResourceStream("r4/profiles-others");
            using var streamReader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(streamReader);
            var serializer = new JsonSerializer();
            serializer.PreserveReferencesHandling = PreserveReferencesHandling.None;
            serializer.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;
            var bundle = serializer.Deserialize<r4.Bundle>(jsonReader)
                ?? throw new InvalidOperationException("Cannot deserialize as bundle");
            return bundle;
        });
        private static readonly Lazy<Bundle> profilesResources = new Lazy<Bundle>(() =>
        {

            using var stream = typeof(r4.Bundle).Assembly.GetManifestResourceStream("r4/profiles-resources");
            using var streamReader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(streamReader);
            var serializer = new JsonSerializer();
            serializer.PreserveReferencesHandling = PreserveReferencesHandling.None;
            serializer.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;
            var bundle = serializer.Deserialize<r4.Bundle>(jsonReader)
                ?? throw new InvalidOperationException("Cannot deserialize as bundle");
            return bundle;
        });
        private static readonly Lazy<Bundle> profileTypes = new Lazy<Bundle>(() =>
        {
            using var stream = typeof(r4.Bundle).Assembly.GetManifestResourceStream("r4/profiles-types");
            using var streamReader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(streamReader);
            var serializer = new JsonSerializer();
            serializer.PreserveReferencesHandling = PreserveReferencesHandling.None;
            serializer.MetadataPropertyHandling = MetadataPropertyHandling.Ignore;
            var bundle = serializer.Deserialize<r4.Bundle>(jsonReader)
                ?? throw new InvalidOperationException("Cannot deserialize as bundle");
            return bundle;
        });
        private static readonly Lazy<Bundle> profiles = new Lazy<Bundle>(() =>
        {
            var resources = profilesResources.Value;
            var types = profileTypes.Value;
            var others = profileTypes.Value;
            var entries = resources.Entry
                    .Concat(types.Entry)
                    .Concat(others.Entry)
                    .GroupBy(r => r.FullUrl)
                    .Select(g => g.First())
                    .ToArray();
            var all = new Bundle
            {
                Id = "profiles/all",
                Type = "Bundle",
                Entry = entries,
            };
            return all;
        });


        public static Schema Schema => schema.Value;
        public static Bundle Profiles => profiles.Value;
    }
}
