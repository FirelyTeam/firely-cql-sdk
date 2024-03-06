﻿using Hl7.Cql.Elm;
using Hl7.Cql.Graph;
using Hl7.Cql.Packaging.ResourceWriters;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using Library = Hl7.Cql.Elm.Library;

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
        public ResourcePackager(ILoggerFactory logFactory, params ResourceWriter[] resourceWriters)
        {
            this.logFactory = logFactory;
            this.resourceWriters = resourceWriters;
        }

        /// <summary>
        /// Instantiates a new Resource Packager.
        /// </summary>
        /// <remarks>
        ///     With hosted services, IEnumerable resourceWriters required registering
        ///     multiple service implementations on the same service type.
        /// </remarks>
        /// <param name="logFactory">logger factory</param>
        /// <param name="resourceWriters">set of writers to output the resources using</param>
        public ResourcePackager(ILoggerFactory logFactory, IEnumerable<ResourceWriter> resourceWriters) {
            this.logFactory = logFactory;
            this.resourceWriters = resourceWriters as ResourceWriter[] ?? resourceWriters.ToArray();
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
        public void Package(ResourcePackageArgs args) =>
            PackageCore(args.ElmDir, args.CqlDir, args.AfterPackageMutator, args.ResourceCanonicalRootUrl);

        private void PackageCore(DirectoryInfo elmDir, DirectoryInfo cqlDir, 
            Action<IEnumerable<Resource>>? afterPackageMutator, 
            string? resourceCanonicalRootUrl)
        {
            if (resourceWriters.Length == 0) return; //Skip since no writers provided

            LibraryPackager libraryPackager = new LibraryPackagerFactory(logFactory).LibraryPackager;

            LibraryPackageCallbacks callbacks = new(buildUrlFromResource: resource => resource.CanonicalUri(resourceCanonicalRootUrl));
            IDictionary<string, Library> librariesByNameAndVersion = LibraryLoader.LoadLibraries(elmDir);
            DirectedGraph directedGraph = librariesByNameAndVersion.Values.GetIncludedLibraries();
            IEnumerable<Resource> resources = libraryPackager.PackageResources(elmDir, cqlDir, directedGraph, callbacks);

            afterPackageMutator?.Invoke(resources);

            foreach (var resourceWriter in resourceWriters)
            {
                resourceWriter.WriteResources(resources);
            }
        }
    }
}
