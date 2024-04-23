global using ScoreKey = System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, string>>>;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Diagnostics;
using System.Reflection;
/*using Azure;
using Azure.Core.Pipeline;
using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;*/
//using Azure.Storage.Files.Shares;
//using ICSharpCode.SharpZipLib.Zip;
using System.Net.Http;
using System.Threading;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Fhir;

namespace Test.Deck
{
    public abstract class TestBase
    {
       protected static readonly IFhirSerializationEngine FirelySerializer =
            FhirSerializationEngineFactory.Ostrich(ModelInfo.ModelInspector);

        protected static readonly JsonSerializerOptions JsonSerializerOptions =
            new JsonSerializerOptions()
                .ForFhir(new FhirJsonPocoDeserializerSettings
                {
                    Validator = null
                });

        protected static Bundle LoadBundle(Stream bundleStream)
        {

            using var sr = new StreamReader(bundleStream);
            var json = sr.ReadToEnd();
            var bundle = FirelySerializer.DeserializeFromJson(json) as Bundle
                ?? throw new ArgumentException($"Provided stream is not a bundle resource");

            //var bundle = Serializer.DeserializeStream(bundleStream) as Hl7.Fhir.Model.Bundle;
            return bundle;
        }

        protected static IValueSetDictionary LoadValueSets(DirectoryInfo? directory = null)
        {
            directory ??= new DirectoryInfo(Path.Combine("Input", "ValueSets")); // @"Input\ValueSets");
            var valueSets = new List<ValueSet>();
            foreach (var file in directory.GetFiles("*.json"))
            {
                using var fs = file.OpenRead();
                var resource = JsonSerializer.Deserialize<Resource>(fs, JsonSerializerOptions);
                if (resource is Bundle bundle)
                    valueSets.AddRange(bundle.Entry.Select(e => e.Resource).OfType<ValueSet>());
                else if (resource is ValueSet valueSet)
                    valueSets.Add(valueSet);
            }
            var vsd = valueSets.ToValueSetDictionary(false);
            return vsd;
        }
 
    }
}
