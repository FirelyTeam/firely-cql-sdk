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
    internal class ResourcePackager
    {
        private readonly LibraryPackager _libraryPackager;

        /// <summary>
        /// Instantiates a new Resource Packager.
        /// </summary>
        /// <remarks>
        ///     With hosted services, IEnumerable resourceWriters required registering
        ///     multiple service implementations on the same service type.
        /// </remarks>
        /// <param name="libraryPackager">The library packager</param>
        public ResourcePackager(
            LibraryPackager libraryPackager) {
            _libraryPackager = libraryPackager;
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
            Action<Resource>? afterPackageMutator = null, 
            int? cacheSize = null) =>
            PackageCore(elmDir, cqlDir, null, afterPackageMutator);

        /// <summary>
        /// Package the resources in the given ELM and CQL directories and output them using the writers provided in the constructor 
        /// </summary>
        /// <param name="args">A</param>
        public void Package(ResourcePackageArgs args) =>
            PackageCore(args.ElmDir, args.CqlDir, args.ResourceCanonicalRootUrl, args.AfterPackageMutator);

        private void PackageCore(
            DirectoryInfo elmDir,
            DirectoryInfo cqlDir,
            string? resourceCanonicalRootUrl,
            Action<Resource>? afterPackageMutator)
        {
            LibrarySet librarySet = new(elmDir.FullName);
            librarySet.LoadLibraries(elmDir.GetFiles("*.json", SearchOption.AllDirectories));
            _libraryPackager.PackageResources(elmDir, cqlDir, librarySet,
                new(
                    afterPackageMutator: afterPackageMutator,
                    buildUrlFromResource: resource => resource.CanonicalUri(resourceCanonicalRootUrl)));
        }
    }
}
