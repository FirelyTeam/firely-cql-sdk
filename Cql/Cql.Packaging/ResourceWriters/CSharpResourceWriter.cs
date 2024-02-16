using Hl7.Fhir.Model;
using Microsoft.Extensions.DependencyInjection;
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
            _outDirectory = opt.OutDirectory ?? throw new InvalidOperationException("The CSharpResourceWriter needs a valid value for OutDirectory.");
            _logger = logger;
        }

        /// <summary>
        /// Writes the specified resources to the output directory in the C# format
        /// </summary>
        /// <param name="resources">the resources to write</param>
        public override void WriteResources(IEnumerable<Resource> resources)
        {
            if (_outDirectory is not { FullName: { } directoryFullName }) 
                return;

            _logger.LogInformation("Writing C# source files to '{directory}'", directoryFullName);
            
            // Write out the C# source code to the desired output location
            foreach (var resource in resources)
            {
                switch (resource)
                {
                    case Binary { ContentType: "text/plain" } binary:
                    {
                        var bytes = binary.Data;
                        DirectoryInfo sourceDir;
                        if (binary.Id.StartsWith("Tuple_"))
                        {
                            sourceDir = new(Path.Combine(directoryFullName, "Tuples"));
                        }
                        else
                        {
                            sourceDir = new(directoryFullName);
                        }
                        EnsureDirectory(sourceDir);
                        var filePath = Path.Combine(sourceDir.FullName, $"{binary.Id}.cs");
                        _logger.LogInformation("Writing '{file}'", filePath);
                        File.WriteAllBytes(filePath, bytes);
                        break;
                    }

                    case Library { Content: not null } library:
                    {
                        var textPlain = library.Content
                            .SingleOrDefault(c => c.ContentType == "text/plain");
                        if (textPlain != null)
                        {
                            var bytes = textPlain.Data;
                            var sourceFilePath = Path.Combine(directoryFullName, $"{library.Id}.cs");
                            File.WriteAllBytes(sourceFilePath, bytes);
                        }

                        break;
                    }
                }
            }
        }
    }
}
