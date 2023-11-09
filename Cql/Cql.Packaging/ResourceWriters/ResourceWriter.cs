using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Packaging.ResourceWriters
{
    /// <summary>
    /// Represents a generic writer of resources to a given directory
    /// </summary>
    public abstract class ResourceWriter
    {
        /// <summary>
        /// Instantiates a new resource writer for the given directory
        /// </summary>
        /// <param name="outDirectory">directory to write to</param>
        /// <param name="logger">logger</param>
        protected ResourceWriter(DirectoryInfo outDirectory, ILogger logger)
        {
            OutDirectory = outDirectory;
            Logger = logger;
        }

        /// <summary>
        /// Directory to write to
        /// </summary>
        protected DirectoryInfo OutDirectory { get; }

        /// <summary>
        /// Logger
        /// </summary>
        protected ILogger Logger { get; }

        /// <summary>
        /// Writes the given resources to the specified output directory
        /// </summary>
        /// <param name="resources">the resources to write</param>
        public abstract void WriteResources(IEnumerable<Resource> resources);

        /// <summary>
        /// Ensures that the specified directory exists, and if it doesn't it creates it
        /// </summary>
        /// <param name="directory">the directory</param>
        /// <param name="timeoutMs">optional override for how long to wait</param>
        /// <exception cref="InvalidOperationException"></exception>
        protected void EnsureDirectory(DirectoryInfo directory, int timeoutMs = 5000)
        {
            var now = DateTime.Now;
            var loop = true;
            var timeout = TimeSpan.FromMilliseconds(timeoutMs);
            while (!directory.Exists && loop)
            {
                directory.Create();
                directory.Refresh();
                if (DateTime.Now.Subtract(now) > timeout)
                    throw new InvalidOperationException($"Unable to create directory {directory.FullName} after {timeout}");
            }
        }
    }
}
