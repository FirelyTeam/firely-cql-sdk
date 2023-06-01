using Hl7.Cql.Poco.Fhir.R4.Model;

namespace FhirApi
{
    internal static class Fluent
    {
        public static Parameters.ParameterComponent? Named(this Parameters @in, string named,
            StringComparison comparison = StringComparison.OrdinalIgnoreCase) =>
            @in.parameter?.SingleOrDefault(pc => string.Equals(pc.name, named, comparison));

    }
}
