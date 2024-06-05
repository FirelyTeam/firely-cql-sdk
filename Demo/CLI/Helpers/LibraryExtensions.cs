/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
using CommandLine;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Fhir;
using Hl7.Cql.Graph;
using Hl7.Cql.ValueSets;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Loader;

namespace CLI.Helpers;

internal static class LibraryExtensions
{

    public static IEnumerable<Library> GetDependenciesAndSelf(this Library library, DirectoryInfo directory)
    {
        var libraries = new HashSet<Library>();
        CollectDependencies(library, directory, libraries);
        return libraries;
    }

    private static void CollectDependencies(Library library, DirectoryInfo directory, HashSet<Library> libraries)
    {
        if (!libraries.Add(library))
        {
            return; // Library is already in the set
        }

        foreach (var relatedArtifact in library.RelatedArtifact ?? Enumerable.Empty<RelatedArtifact>())
        {
            var relatedPath = new FileInfo(Path.Combine(directory.FullName, $"{relatedArtifact.Resource}.json"));
            using var fs = relatedPath.OpenRead();
            var relatedLibrary = fs.ParseFhir<Library>();
            CollectDependencies(relatedLibrary, directory, libraries);
        }
    }


    public static AssemblyLoadContext LoadAssemblies(this IEnumerable<Library> libraries,
        AssemblyLoadContext asmContext)
    {
        foreach (var library in libraries)
        {
            var dll = library.Content.SingleOrDefault(att => att.ContentType == "application/octet-stream");
            if (dll != null)
            {
                using var ms = new MemoryStream(dll.Data);
                var assembly = asmContext.LoadFromStream(ms);
            }

        }
        return asmContext;
    }

    public static AssemblyLoadContext LoadAssemblies(this IEnumerable<Binary> binaries,
        AssemblyLoadContext asmContext)
    {
        foreach (var binary in binaries)
        {
            if (binary.ContentType == "application/octet-stream")
            {
                using var ms = new MemoryStream(binary.Data);
                var assembly = asmContext.LoadFromStream(ms);
            }
        }
        return asmContext;
    }

    public static Dictionary<string, List<string>> GetValueSets(Type libraryType)
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

        var valueSetAttributes = libraryType.GetMethods()
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
