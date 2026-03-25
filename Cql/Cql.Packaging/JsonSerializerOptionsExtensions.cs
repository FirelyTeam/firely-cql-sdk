using Hl7.Fhir.Serialization;
using Hl7.Fhir.Validation;

namespace Hl7.Cql.Packaging;

internal static class JsonSerializerOptionsExtensions
{
    private static readonly JsonSerializerOptions ForFhirCached =
        new JsonSerializerOptions().ForFhir(FhirModelInfo.ModelInspector);

    private static readonly JsonSerializerOptions ForFhirPrettyCached =
        ForFhirCached.Pretty();

    private static readonly JsonSerializerOptions ForFhirIgnoringInvalidLiteralsCached =
        new JsonSerializerOptions(ForFhirCached)
            .Ignoring([CodedValidationException.LITERAL_INVALID_CODE]);

    extension(JsonSerializerOptions)
    {
        public static JsonSerializerOptions ForFhir => ForFhirCached;

        public static JsonSerializerOptions ForFhirPretty => ForFhirPrettyCached;

        public static JsonSerializerOptions ForFhirIgnoringInvalidLiterals => ForFhirIgnoringInvalidLiteralsCached;
    }
}