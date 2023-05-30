using Hl7.Cql.Poco.Fhir.R4.Model;

namespace FhirApi
{
    public interface ILibraryHandler
    {
        IResult Evaluate(Parameters @in);
    }
}