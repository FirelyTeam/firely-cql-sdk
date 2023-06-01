using Hl7.Cql.Poco.Fhir.R4;
using Hl7.Cql.Poco.Fhir.R4.Model;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.Runtime.FhirR4;
using Hl7.Cql.ValueSetLoaders;
using Hl7.Cql.ValueSets;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Text;

namespace FhirApi
{
    public class SimpleLibraryHandler : ILibraryHandler
    {
        public IResult Evaluate(Parameters @in)
        {
            Parameters? parameters = null;
            var library = @in.parameter?.SingleOrDefault(p => p.name == "library");
            if (library != null
                && library.value is IdElement libraryId
                && !string.IsNullOrWhiteSpace(libraryId.value))
            {
                switch (libraryId.value.ToLowerInvariant())
                {
                    case "bcsehedismy2022-1.0.0":
                        parameters = RunBCSE(@in);
                        break;
                    default:
                        return Results.NotFound();
                }
            }
            else return Results.BadRequest();

            var json = FhirJson.SerializeToString(parameters);
            return Results
               .Content(json, "application/fhir+json", Encoding.UTF8);
        }

        private IDictionary<string, object> MY2023 =
            new Dictionary<string, object>
            {
                {
                    "Measurement Period",
                    new CqlInterval<CqlDateTime>(
                        new CqlDateTime(2023, 1, 1, 0, 0, 0, 0, 0, 0),
                        new CqlDateTime(2023, 12, 31, 0, 0, 0, 0, 0, 0),
                        true,
                        true)
                }
            };
        private Parameters? RunBCSE(Parameters @in)
        {
            Stream? dataStream = null;
            var subject = @in.parameter
                .SingleOrDefault(p => p.name == "subject");
            if (subject != null && subject.value is IdElement id)
            {
                dataStream = typeof(SimpleLibraryHandler)
                    .Assembly
                    .GetManifestResourceStream(id.value)
                    ?? throw new InvalidOperationException($"Subject {id.value} not found");
            }
            /// TODO: support data parameter if subject not specified
            if (dataStream == null)
            {
                throw new InvalidOperationException("No data provided.");
            }
            var @out = new Parameters
            {
                parameter = new List<Parameters.ParameterComponent>()
            };
            var bundle = FhirJson.Deserialize<Bundle>(dataStream);
            var valueSets = ValueSetProvider.ValueSets;
            var context = FhirCqlContext.Create(bundle,
                MY2023,
                valueSets,
                new DateTimeOffset(2023, 12, 31, 23, 59, 59, default));
            var bcse = new BCSEHEDISMY2022_1_0_0(context);
            @out.parameter.Add(new Parameters.ParameterComponent
            {
                name = "Numerator",
                value = new BooleanElement { value = bcse.Numerator() }
            });
            return @out;
        }
    }
}
