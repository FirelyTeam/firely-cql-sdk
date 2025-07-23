/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Fhir.Extensions;
using Hl7.Cql.Invocation.Toolkit;
using Hl7.Cql.Packaging;
using Hl7.Fhir.Model;
using FhirLibrary=Hl7.Fhir.Model.Library;

namespace CLI.Helpers;

internal static class LibraryExtensions
{

    public static IEnumerable<FhirLibrary> GetDependenciesAndSelf(this FhirLibrary library, DirectoryInfo directory)
    {
        var libraries = new HashSet<FhirLibrary>();
        library.LoadDependencies(directory, libraries);
        return libraries;
    }

    private static void LoadDependencies(this FhirLibrary library, DirectoryInfo directory, HashSet<FhirLibrary> libraries)
    {
        if (!libraries.Add(library))
        {
            return; // Library is already in the set
        }

        foreach (var relatedArtifact in library.RelatedArtifact ?? Enumerable.Empty<RelatedArtifact>())
        {
            if (!TryLoadArtifactAndDependencies(relatedArtifact))
                Debug.WriteLine($"Could not load artifact {relatedArtifact.Resource}");
        }

        bool TryLoadArtifactAndDependencies(RelatedArtifact relatedArtifact)
        {
            // Resource example: https://fire.ly/fhir/Library/FHIRHelpers|4.0.001
            // First split out the version part
            // Second split out the Name part after Library/

            var arr = relatedArtifact.Resource.Split('|', 2);
            string name = arr[0];
            const string LibrarySplit = "Library/";
            switch (name.LastIndexOf(LibrarySplit, StringComparison.Ordinal))
            {
                case -1:
                    return false;
                default:
                    name = name[(name.LastIndexOf(LibrarySplit, StringComparison.Ordinal) + LibrarySplit.Length)..];
                    break;
            }

            for (int i = arr.Length; i >= 1; i--)
            {
                var resourceFileName = i switch
                {
                    2 => ResourceFileName.Create("Library", name, arr[1]),
                    1 => ResourceFileName.Create("Library", name),
                    _ => throw new UnreachableException()
                };

                var relatedPath = new FileInfo(Path.Combine(directory.FullName, resourceFileName.FileName));
                if (relatedPath.Exists)
                {
                    using var fs = relatedPath.OpenRead();
                    var relatedLibrary = fs.DeserializeJsonToFhir<FhirLibrary>();
                    relatedLibrary.LoadDependencies(directory, libraries);
                    return true;
                }
            }

            return false;
        }
    }

    public static LibrarySetInvoker ToLibrarySetInvoker(
        this IEnumerable<FhirLibrary> libraries)
    {
        var assemblyBinaries =
            libraries
            .Select(library => library.Content.SingleOrDefault(att => att.ContentType == "application/octet-stream"))
            .OfType<Attachment>()
            .Select(dll => dll.Data)
            .Select(assemblyBytes => AssemblyBinary.Default with { AssemblyBytes = assemblyBytes})
            .ToArray();

        return new InvocationToolkit()
                         .AddAssemblyBinaries(assemblyBinaries)
                         .CreateLibrarySetInvoker();
    }
}
