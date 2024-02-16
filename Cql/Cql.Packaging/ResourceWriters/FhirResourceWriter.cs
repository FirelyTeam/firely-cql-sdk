using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packaging.ResourceWriters
{
    /// <summary>
    /// Writes resources as FHIR files
    /// </summary>
    public class FhirResourceWriter : ResourceWriter
    {
        private static readonly JsonSerializerOptions JsonSerializerOptions = new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector).Pretty();

        private readonly DirectoryInfo _outDirectory;
        private readonly ILogger<FhirResourceWriter> _logger;
        private readonly DateTime? _overrideDate;

        /// <summary>
        /// Instantiates a new resource writer
        /// </summary>
        /// <param name="outDirectory">the output directory</param>
        /// <param name="logger">logger</param>
        public FhirResourceWriter(DirectoryInfo outDirectory, ILogger<FhirResourceWriter> logger)
        {
            _outDirectory = outDirectory;
            _logger = logger;
        }

        /// <summary>
        /// Instantiates a new resource writer
        /// </summary>
        /// <param name="options">the resource writer options</param>
        /// <param name="logger">logger</param>
        public FhirResourceWriter(IOptions<FhirResourceWriterOptions> options, ILogger<FhirResourceWriter> logger) 
        {
            var opt = options.Value;
            _outDirectory = opt.OutDirectory ?? throw new InvalidOperationException("The FhirResourceWriter needs a valid value for OutDirectory.");
            _overrideDate = opt.OverrideDate;
            _logger = logger;
        }

        /// <summary>
        /// Writes the specified resources to the output directory in the FHIR format
        /// </summary>
        /// <param name="resources">the resources to write</param>
        public override void WriteResources(IEnumerable<Resource> resources)
        {
            if (_outDirectory is not { FullName: { } outDirectoryFullName }) 
                return;

            _logger.LogInformation("Writing FHIR resources to {directory}", outDirectoryFullName);

            foreach (var resource in resources)
            {
                if (resource is Library library
                    && _overrideDate is { } overrideDate)
                {
                    library.Date = overrideDate.ToString("u");
                    if (library.Meta is { } meta)
                    {
                        meta.LastUpdated = overrideDate;
                    }
                }

                var file = Path.GetFullPath(Path.Combine(outDirectoryFullName, $"{resource.Id}.json"));
                _logger.LogInformation("Writing {file}", file);
                using var fs = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.Read);
                JsonSerializer.Serialize(fs, resource, JsonSerializerOptions);
            }
        }
    }
}
