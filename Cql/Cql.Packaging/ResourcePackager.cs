using Hl7.Cql.Compiler;
using Hl7.Cql.Packaging.ResourceWriters;
using Hl7.Fhir.Model;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Packaging
{
    /// <summary>
    /// Encapsulates packaging of resources and outputting them using the specified resource writers
    /// </summary>
    [UsedImplicitly]
    public class ResourcePackager
    {
        private readonly LibraryPackager _libraryPackager;
        private readonly ILoggerFactory _logFactory;
        private readonly ResourceWriter[] _resourceWriters;

        /// <summary>
        /// Instantiates a new Resource Packager
        /// </summary>
        /// <param name="logFactory">logger factory</param>
        /// <param name="resourceWriters">set of writers to output the resources using</param>
        public ResourcePackager(
            ILoggerFactory logFactory, 
            params ResourceWriter[] resourceWriters)
        {
            _libraryPackager = new LibraryPackagerFactory(logFactory).LibraryPackager;
            _logFactory = logFactory;
            _resourceWriters = resourceWriters;
        }

        /// <summary>
        /// Instantiates a new Resource Packager.
        /// </summary>
        /// <remarks>
        ///     With hosted services, IEnumerable resourceWriters required registering
        ///     multiple service implementations on the same service type.
        /// </remarks>
        /// <param name="libraryPackager">The library packager</param>
        /// <param name="logFactory">logger factory</param>
        /// <param name="resourceWriters">set of writers to output the resources using</param>
        internal ResourcePackager(
            LibraryPackager libraryPackager,
            ILoggerFactory logFactory,
            IEnumerable<ResourceWriter> resourceWriters) {
            _libraryPackager = libraryPackager;
            _logFactory = logFactory;
            _resourceWriters = resourceWriters as ResourceWriter[] ?? resourceWriters.ToArray();
        }

        /// <summary>
        /// Package the resources in the given ELM and CQL directories and output them using the writers provided in the constructor 
        /// </summary>
        /// <param name="elmDir">directory to find the ELM files</param>
        /// <param name="cqlDir">directory to find the CQL files</param>
        /// <param name="afterPackageMutator">optional mutator for the resources prior to writing</param>
        /// <param name="cacheSize"></param>
        public void Package(
            DirectoryInfo elmDir,
            DirectoryInfo cqlDir, 
            Action<IEnumerable<Resource>>? afterPackageMutator = null, 
            int? cacheSize = null) =>
            PackageCore(elmDir, cqlDir, afterPackageMutator, null);

        /// <summary>
        /// Package the resources in the given ELM and CQL directories and output them using the writers provided in the constructor 
        /// </summary>
        /// <param name="args">A</param>
        public void Package(ResourcePackageArgs args) =>
            PackageCore(args.ElmDir, args.CqlDir, args.AfterPackageMutator, args.ResourceCanonicalRootUrl);

        private void PackageCore(
            DirectoryInfo elmDir,
            DirectoryInfo cqlDir, 
            Action<IEnumerable<Resource>>? afterPackageMutator, 
            string? resourceCanonicalRootUrl)
        {
            if (_resourceWriters.Length == 0) 
                return; //Skip since no writers provided

            HashSet<Resource> resourcesWritten = new();
            LibraryPackager libraryPackager = new LibraryPackagerFactory(_logFactory).LibraryPackager;
            LibraryPackageCallbacks callbacks = new(
                buildUrlFromResource: resource => resource.CanonicalUri(resourceCanonicalRootUrl),
                onLibraryResourceCreated: library =>
                {
                    foreach (var resourceWriter in _resourceWriters)
                    {
                        afterPackageMutator?.Invoke(new [] {library});
                        resourceWriter.WriteResource(library);
                        resourcesWritten.Add(library);
                    }
                });

            LibrarySet librarySet = new(elmDir.FullName);
            librarySet.LoadLibraries(elmDir.GetFiles("*.json", SearchOption.AllDirectories));
            List<Resource> resources = libraryPackager.PackageResources(elmDir, cqlDir, librarySet, callbacks).ToList();
            
            var remainingResources = resources.Except(resourcesWritten).ToList();
            afterPackageMutator?.Invoke(remainingResources);
            if (remainingResources.Any())
            {
                foreach (var resourceWriter in _resourceWriters)
                {
                    resourceWriter.WriteResources(remainingResources);
                }
            }
        }
    }
}
