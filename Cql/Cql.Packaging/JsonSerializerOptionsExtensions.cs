using Hl7.Fhir.Serialization;

namespace Hl7.Cql.Packaging;

internal static class JsonSerializerOptionsExtensions
{
    private static readonly JsonSerializerOptions ForFhirCached =
        new JsonSerializerOptions().ForFhir(FhirModelInfo.ModelInspector);

    private static readonly JsonSerializerOptions ForFhirPrettyCached =
        ForFhirCached.Pretty();

    extension(JsonSerializerOptions)
    {
        public static JsonSerializerOptions ForFhir => ForFhirCached;

        public static JsonSerializerOptions ForFhirPretty => ForFhirPrettyCached;
    }
}