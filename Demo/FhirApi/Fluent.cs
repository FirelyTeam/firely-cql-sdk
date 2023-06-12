
using Hl7.Fhir.Model;

namespace FhirApi
{
    internal static class Fluent
    {
        public static Parameters.ParameterComponent? Named(this Parameters @in, string named,
            StringComparison comparison = StringComparison.OrdinalIgnoreCase) =>
            @in.Parameter?.SingleOrDefault(pc => string.Equals(pc.Name, named, comparison));

    }
}
