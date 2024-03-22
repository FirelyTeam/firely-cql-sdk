using Hl7.Fhir.Model;

namespace Hl7.Cql.Packaging.PostProcessors;

internal abstract class FhirResourcePostProcessor
{
    public abstract void ProcessResource(Resource resource);
}