using Hl7.Cql.Firely;
using Hl7.Cql.Primitives;
using Hl7.Fhir.Model;
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
            var context = FirelyCqlContext.ForBundle(bundle,
                MY2023,
                valueSets,
                new DateTimeOffset(2023, 12, 31, 23, 59, 59, default));

            var library = @in.Named("library");
            if (library != null
                && library.Value is Id libraryId
                && !string.IsNullOrWhiteSpace(libraryId.Value))
            {
                // TODO: load the measure?
            }

            var json = @out.ToJson();
            return Results
               .Content(json, "application/fhir+json", Encoding.UTF8);
        }
        private readonly IDictionary<string, object> MY2023 =
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
