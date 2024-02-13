using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Hl7.Cql.Packaging.ResourceWriters
{
    /// <summary>
    /// Writes resources as FHIR files
    /// </summary>
    public class FhirResourceWriter : ResourceWriter
    {
        private readonly DateTime? _overrideDate;
        private static readonly JsonSerializerOptions options = new JsonSerializerOptions().ForFhir(ModelInfo.ModelInspector).Pretty();

        /// <summary>
        /// Instantiates a new resource writer
        /// </summary>
        /// <param name="outDirectory">the output directory</param>
        /// <param name="logger">logger</param>
        /// <param name="overrideDate">Override date for library</param>
        public FhirResourceWriter(
            DirectoryInfo outDirectory,
            ILogger logger,
            DateTime? overrideDate = null) : base(outDirectory, logger)
        {
            _overrideDate = overrideDate;
        }

        /// <summary>
        /// Writes the specified resources to the output directory in the FHIR format
        /// </summary>
        /// <param name="resources">the resources to write</param>
        public override void WriteResources(IEnumerable<Resource> resources)
        {
            if (OutDirectory != null)
            {
                Logger.LogInformation($"Writing FHIR resources to {OutDirectory.FullName}");

                foreach (var resource in resources)
                {
                    if (_overrideDate is {} date
                        && resource is Library library)
                    {
                        library.Date = date.ToString("u");
                        if (library.Meta is { } meta)
                        {
                            meta.LastUpdated = date;
                        }
                    }

                    var file = new FileInfo(Path.Combine(OutDirectory.FullName, $"{resource.Id}.json"));
                    Logger.LogInformation($"Writing {file.FullName}");
                    using var fs = new FileStream(file.FullName, FileMode.Create, FileAccess.Write, FileShare.Read);
                    JsonSerializer.Serialize(fs, resource, options);
                }
            }
        }
    }
}
