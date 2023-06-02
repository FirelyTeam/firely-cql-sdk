using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoreTests
{
    public static class StreamExtensions
    {
        private static readonly JsonSerializerOptions Options =  new JsonSerializerOptions()
            .ForFhir(typeof(Resource).Assembly);
        public static T ParseFhir<T>(this Stream stream) => JsonSerializer.Deserialize<T>(stream, Options);
    }
}
