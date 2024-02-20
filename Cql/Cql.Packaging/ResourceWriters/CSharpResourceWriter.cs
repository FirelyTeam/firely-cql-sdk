using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Hl7.Cql.Packaging.ResourceWriters
{
    /// <summary>
    /// Writes resources as C# files
    /// </summary>
    public class CSharpResourceWriter : ResourceWriter
    {
        private readonly DirectoryInfo _outDirectory;
        private readonly ILogger<CSharpResourceWriter> _logger;

        /// <summary>
        /// Instantiates a new resource writer
        /// </summary>
        /// <param name="outDirectory">the output directory</param>
        /// <param name="logger">logger</param>
        public CSharpResourceWriter(DirectoryInfo outDirectory, ILogger<CSharpResourceWriter> logger)
        {
            _outDirectory = outDirectory;
            _logger = logger;
        }

        /// <summary>
        /// Instantiates a new resource writer
        /// </summary>
        /// <param name="options">the resource writer options</param>
        /// <param name="logger">logger</param>
        public CSharpResourceWriter(IOptions<CSharpResourceWriterOptions> options, ILogger<CSharpResourceWriter> logger)
        {
            var opt = options.Value;
            _outDirectory = opt.OutDirectory ?? throw new ArgumentException("OutDirectory is required.");
            _logger = logger;
        }

        /// <summary>
        /// Writes the specified resources to the output directory in the C# format
        /// </summary>
        /// <param name="resources">the resources to write</param>
        public override void WriteResources(IEnumerable<Resource> resources)
        {
            _logger.LogInformation("Writing C# source files to '{directory}'", _outDirectory);
            
            // Write out the C# source code to the desired output location
            foreach (var resource in resources)
            {
                WriteResource(resource);
            }
        }

        /// <inheritdoc />
        public override void WriteResource(Resource resource)
        {
            EnsureDirectory(_outDirectory);
            var directory = _outDirectory.FullName;
            switch (resource)
            {
                case Binary { ContentType: "text/plain" } binary:
                {
                    var bytes = binary.Data;
                    var sourceDirPath = binary.Id.StartsWith("Tuple_")
                        ? Path.Combine(directory, "Tuples"):
                        directory;
                    DirectoryInfo sourceDir = new(sourceDirPath);
                    EnsureDirectory(sourceDir);
                    var sourceFilePath = Path.Combine(sourceDir.FullName, $"{binary.Id}.cs");
                    _logger.LogInformation("Writing '{file}'", sourceFilePath);
                    File.WriteAllBytes(sourceFilePath, bytes);
                    break;
                }

                case Library { Content: not null } library:
                {
                    var textPlain = library.Content.SingleOrDefault(c => c.ContentType == "text/plain");
                    if (textPlain != null)
                    {
                        var bytes = textPlain.Data;
                        var sourceFilePath = Path.Combine(directory, $"{library.Id}.cs");
                        File.WriteAllBytes(sourceFilePath, bytes);
                    }
                    break;
                }
            }
        }
    }
}
