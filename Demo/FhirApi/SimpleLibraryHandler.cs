using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime;
using Hl7.Cql.ValueSetLoaders;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Text;
using Hl7.Cql.Firely;

namespace FhirApi
{
    public class SimpleLibraryHandler : ILibraryHandler
    {
        public IResult Evaluate(Parameters @in)
        {
            Parameters? parameters = null;
            var library = @in.Parameter?.SingleOrDefault(p => p.Name == "library");
            if (library != null
                && library.Value is Id libraryId
                && !string.IsNullOrWhiteSpace(libraryId.Value))
            {
                switch (libraryId.Value.ToLowerInvariant())
                {
                    case "bcsehedismy2022-1.0.0":
                        parameters = RunBCSE(@in);
                        break;
                    default:
                        return Results.NotFound();
                }
            }
            else return Results.BadRequest();

            var json = parameters.ToJson();
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
            var subject = @in.Parameter
                .SingleOrDefault(p => p.Name == "subject");
            if (subject != null && subject.Value is Id id)
            {
                dataStream = typeof(SimpleLibraryHandler)
                    .Assembly
                    .GetManifestResourceStream(id.Value)
                    ?? throw new InvalidOperationException($"Subject {id.Value} not found");
            }
            /// TODO: support data parameter if subject not specified
            if (dataStream == null)
            {
                throw new InvalidOperationException("No data provided.");
            }
            var @out = new Parameters
            {
                Parameter = new List<Parameters.ParameterComponent>()
            };
            var bundle = dataStream.ParseFhir<Bundle>();
            var valueSets = ValueSetProvider.ValueSets;
            var context = FirelyCqlContext.Create(bundle,
                MY2023,
                valueSets,
                new DateTimeOffset(2023, 12, 31, 23, 59, 59, default));
            var bcse = new BCSEHEDISMY2022_1_0_0(context);
            @out.Parameter.Add(new Parameters.ParameterComponent
            {
                Name = "Numerator",
                Value = new FhirBoolean(bcse.Numerator())
            });
            return @out;
        }
    }
}
