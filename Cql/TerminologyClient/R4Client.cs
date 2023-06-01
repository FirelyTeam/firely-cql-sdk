using Microsoft.Extensions.Configuration;

using Hl7.Cql.Poco.Fhir.R4;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using Hl7.Cql.Poco.Fhir.R4.Model;

namespace Hl7.Cql.Poco.Fhir.TerminologyClient
{
    public class R4Client
    {
        public R4Client(IConfiguration configuration)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public IConfiguration Configuration { get; }

        public async System.Threading.Tasks.Task<Bundle> ExpandValueSetsAsync(params string[] valueSetIds)
        {
            const string urlKey = "TerminologyServer:Url";
            var baseUri = Configuration[urlKey] ?? throw new InvalidOperationException($"Configuration key {urlKey} is not set and is required.");
            if (baseUri.EndsWith('/'))
                baseUri = $"{baseUri}ValueSet/$expand";
            else
                baseUri = $"{baseUri}/ValueSet/$expand";
            var parameters = valueSetIds.Select(id =>
                new Parameters
                {
                    parameter = new[]
                    {
                        new Parameters.ParameterComponent
                        {
                            name = "valueSet"!,
                            resource = new ValueSet
                            {
                                id = id!
                            }
                        }
                    }
                });
            var requestBundle = new Bundle
            {
                type = "batch"!,
                entry = new R4EntryCollection()
            };
            foreach (var p in parameters)
                requestBundle.entry.Add(new Bundle.EntryComponent { resource = p });

            using var ms = new MemoryStream();
            var json = FhirJson.SerializeToString(requestBundle);
            using var client = new HttpClient();
            var jsonContent = JsonContent.Create(requestBundle, options: FhirJson.GetJsonSerializerOptions());
            var message = await client.PostAsync(baseUri, jsonContent);
            message.EnsureSuccessStatusCode();
            using var responseStream = message.Content.ReadAsStream();
            var resource = await FhirJson.DeserializeAsync<Resource>(responseStream);
            if (resource is Bundle bundle)
                return bundle;
            else
                throw new InvalidOperationException();
        }
    }
}