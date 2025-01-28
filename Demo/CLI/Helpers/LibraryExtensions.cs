/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.Invocation;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Packaging;
using Library = Hl7.Fhir.Model.Library;

namespace CLI.Helpers;

internal static class LibraryExtensions
{

    public static IEnumerable<Library> GetDependenciesAndSelf(this Library library, DirectoryInfo directory)
    {
        var libraries = new HashSet<Library>();
        library.LoadDependencies(directory, libraries);
        return libraries;
    }

    private static void LoadDependencies(this Library library, DirectoryInfo directory, HashSet<Library> libraries)
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

            for (int i = 2; i >= 1; i--)
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
                    var relatedLibrary = fs.ParseFhir<Library>();
                    relatedLibrary.LoadDependencies(directory, libraries);
                    return true;
                }
            }

            return false;
        }
    }

    public static LibrarySetInvoker CreateRuntimeScope(
        this IEnumerable<Library> libraries)
    {
        var assemblyDatas =
            libraries
            .Select(library => library.Content.SingleOrDefault(att => att.ContentType == "application/octet-stream"))
            .OfType<Attachment>()
            .Select(dll => dll.Data)
            .Select(assemblyBytes => AssemblyData.Default with { AssemblyBytes = assemblyBytes})
            .ToArray();

        return new FluentLibrarySetInvokerBuilder()
                         .AddAssemblies(assemblyDatas)
                         .CreateLibrarySetInvoker();
    }

    private static Dictionary<string, List<string>> GetValueSets(Type libraryType)
    {
        var valueSets = new Dictionary<string, List<string>>();
        CollectValueSets(libraryType, valueSets);
        return valueSets;
    }

    private static void CollectValueSets(Type libraryType, Dictionary<string, List<string>> valueSets)
    {
        var libAttribute = libraryType.GetCustomAttribute<CqlLibraryAttribute>();
        if (libAttribute is null) return;

        var id = $"{libAttribute.Identifier}-{libAttribute.Version}";
        if (!valueSets.TryGetValue(id, out var forLib))
        {
            forLib = new List<string>();
            valueSets[id] = forLib;
        }

        var methodInfos = libraryType.GetMethods();

        var valueSetAttributes = methodInfos
                                 .Select(m => m.GetCustomAttribute<CqlValueSetAttribute>())
                                 .Where(attr => attr is not null)
                                 .Select(attr => attr!.Id);

        forLib.AddRange(valueSetAttributes);
        if (forLib.Count == 0)
        {
            valueSets.Remove(id);
        }

        var nestedLibraryTypes = libraryType.GetProperties()
            .Select(p => p.PropertyType)
            .Distinct(); // Avoid processing the same type multiple times

        foreach (var nestedType in nestedLibraryTypes)
        {
            CollectValueSets(nestedType, valueSets);
        }
    }

    private static Dictionary<string, List<string>> MissingValueSets(Type libraryType, IValueSetDictionary loadedValueSets, Dictionary<string, List<string>> libraryValueSets)
    {
        return libraryValueSets
            .Where(lib => lib.Value.Any(vs => !loadedValueSets.TryGetCodesInValueSet(vs, out _)))
            .ToDictionary(
                lib => lib.Key,
                lib => lib.Value.Where(vs => !loadedValueSets.TryGetCodesInValueSet(vs, out _)).ToList()
     );
    }

    public static Dictionary<string, List<string>> MissingValueSets(this Type libraryType, IValueSetDictionary loadedValueSets)
    {
        var libraryValueSets = GetValueSets(libraryType);
        return MissingValueSets(libraryType, loadedValueSets, libraryValueSets);
    }

}
