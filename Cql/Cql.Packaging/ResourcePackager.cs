using Hl7.Cql.Compiler;
using Hl7.Cql.Elm;
using Hl7.Cql.Fhir;
using Hl7.Cql.Packaging.ResourceWriters;
using Hl7.Fhir.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Hl7.Cql.Packaging
{
    /// <summary>
    /// Encapsulates packaging of resources and outputting them using the specified resource writers
    /// </summary>
    public class ResourcePackager
    {
        private readonly ILoggerFactory logFactory;
        private readonly ResourceWriter[] resourceWriters;

        /// <summary>
        /// Instantiates a new Resource Packager
        /// </summary>
        /// <param name="logFactory">logger factory</param>
        /// <param name="resourceWriters">set of writers to output the resources using</param>
        public ResourcePackager(ILoggerFactory logFactory, IEnumerable<ResourceWriter> resourceWriters) {
            this.logFactory = logFactory;
            this.resourceWriters = resourceWriters.ToArray();
        }

        /// <summary>
        /// Package the resources in the given ELM and CQL directories and output them using the writers provided in the constructor 
        /// </summary>
        /// <param name="elmDir">directory to find the ELM files</param>
        /// <param name="cqlDir">directory to find the CQL files</param>
        /// <param name="afterPackageMutator">optional mutator for the resources prior to writing</param>
        /// <param name="cacheSize"></param>
        public void Package(DirectoryInfo elmDir, DirectoryInfo cqlDir, 
            Action<IEnumerable<Resource>>? afterPackageMutator = null, int? cacheSize = null) =>
            PackageCore(elmDir, cqlDir, afterPackageMutator, null);

        /// <summary>
        /// Package the resources in the given ELM and CQL directories and output them using the writers provided in the constructor 
        /// </summary>
        /// <param name="args">A</param>
        public void Package(PackageArgs args) =>
            PackageCore(args.ElmDir, args.CqlDir, args.AfterPackageMutator, args.ResourceCanonicalRootUrl);

        private void PackageCore(DirectoryInfo elmDir, DirectoryInfo cqlDir, 
            Action<IEnumerable<Resource>>? afterPackageMutator, 
            string? resourceCanonicalRootUrl)
        {
            if (resourceWriters.Length == 0) return; //Skip since no writers provided

            var packages = LibraryPackager.LoadLibraries(elmDir);
            var graph = packages.Values.GetIncludedLibraries();
            var typeResolver = new FhirTypeResolver(ModelInfo.ModelInspector);

            var packager = new LibraryPackager();
            var resources = packager.PackageResources(elmDir,
                cqlDir,
                graph,
                typeResolver,
                new CqlOperatorsBinding(typeResolver, FhirTypeConverter.Create(ModelInfo.ModelInspector)),
                new TypeManager(typeResolver),
                resource => CanonicalUri(resource, resourceCanonicalRootUrl),
                logFactory);

            afterPackageMutator?.Invoke(resources);

            foreach (var writer in resourceWriters)
            {
                writer.WriteResources(resources);
            }
        }

        private static string CanonicalUri(Resource resource, string? resourceCanonicalRootUrl)
        {
            if (string.IsNullOrWhiteSpace(resource.Id))
                throw new ArgumentException("Resource must have an id", nameof(resource));
            var path = $"{resourceCanonicalRootUrl ?? "#"}/{resource.TypeName}/{resource.Id}";
            return path;
        }

    }
}
