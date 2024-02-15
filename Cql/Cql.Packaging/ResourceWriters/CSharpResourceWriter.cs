using Hl7.Fhir.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Packaging.ResourceWriters
{
    /// <summary>
    /// Writes resources as C# files
    /// </summary>
    public class CSharpResourceWriter : ResourceWriter
    {
        /// <summary>
        /// Instantiates a new resource writer
        /// </summary>
        /// <param name="outDirectory">the output directory</param>
        /// <param name="logger">logger</param>
        public CSharpResourceWriter([FromKeyedServices("CSharp")] DirectoryInfo outDirectory, ILogger<CSharpResourceWriter> logger) : base(outDirectory, logger)
        {
        }

        /// <summary>
        /// Writes the specified resources to the output directory in the C# format
        /// </summary>
        /// <param name="resources">the resources to write</param>
        public override void WriteResources(IEnumerable<Resource> resources)
        {
            if (OutDirectory != null)
            {
                Logger.LogInformation($"Writing C# source files to {OutDirectory.FullName}");
                // Write out the C# source code to the desired output location
                foreach (var resource in resources)
                {
                    if (resource is Binary binary)
                    {
                        if (binary.ContentType == "text/plain")
                        {
                            var bytes = binary.Data;
                            DirectoryInfo? sourceDir = null;
                            if (binary.Id.StartsWith("Tuple_"))
                            {
                                sourceDir = new(Path.Combine(OutDirectory.FullName, "Tuples"));
                            }
                            else
                            {
                                sourceDir = new(OutDirectory.FullName);
                            }
                            EnsureDirectory(sourceDir);
                            var filePath = Path.Combine(sourceDir.FullName, $"{binary.Id}.cs");
                            Logger.LogInformation($"Writing {filePath}");
                            File.WriteAllBytes(filePath, bytes);
                        }
                    }
                    else if (resource is Library library && library.Content != null)
                    {
                        var textPlain = library.Content
                            .SingleOrDefault(c => c.ContentType == "text/plain");
                        if (textPlain != null)
                        {
                            var bytes = textPlain.Data;
                            var sourceFilePath = Path.Combine(OutDirectory.FullName, $"{library.Id}.cs");
                            File.WriteAllBytes(sourceFilePath, bytes);
                        }
                    }
                }
            }
        }
    }
}
