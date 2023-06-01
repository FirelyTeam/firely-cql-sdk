using Hl7.Cql.Poco.Fhir.R4;
using Hl7.Cql.Poco.Fhir.R4.Model;
using Hl7.Cql.Primitives;
using Hl7.Cql.Runtime.FhirR4;
using System.Text;

namespace FhirApi
{
    public partial class ResourceLibraryHandler : ILibraryHandler
    {
        public ResourceLibraryHandler(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public IResult Evaluate(Parameters @in)
        {
            var location = new DirectoryInfo(Configuration["ResourceLocation"] ??
                throw new InvalidOperationException($"Missing configuration key ResourceLocation"));
            if (!location.Exists)
                throw new InvalidOperationException($"Path {location.FullName} does not exist.");

            Stream? dataStream = null;
            var subject = @in.Named("subject");
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

            var library = @in.Named("library");
            if (library != null
                && library.value is IdElement libraryId
                && !string.IsNullOrWhiteSpace(libraryId.value))
            {
            }

            var json = FhirJson.SerializeToString(@out);
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

    }

}
