
using Hl7.Fhir.Model;

namespace FhirApi
{
    public interface ILibraryHandler
    {
        IResult Evaluate(Parameters @in);
    }
}