using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Hl7.Cql.Graph;
using Hl7.Cql.Fhir;
using Hl7.Fhir.Model;
using JetBrains.Annotations;
using ElmLibrary= Hl7.Cql.Elm.Library;
using FhirLibrary = Hl7.Fhir.Model.Library;
using System.Runtime.Loader;

namespace Hl7.Cql.Elm;

#pragma warning disable CS1591
internal static class LibraryExtensions
{
    public static IEnumerable<ElmLibrary> GetIncludedElmLibraries(this IEnumerable<ElmLibrary> libraries)
    {
        var packageGraph = libraries.GetIncludedLibraries();
        var elmLibraries = packageGraph.Nodes.Values
            .Select(node => node.Properties?[ElmLibrary.LibraryNodeProperty])
            .OfType<ElmLibrary>()
            .ToArray();
        return elmLibraries;
    }

    public static DirectedGraph GetIncludedLibraries(this IEnumerable<ElmLibrary> libraries)
    {
        var buildOrder = new DirectedGraph();
        foreach (var library in libraries)
        {
            var includes = GetIncludedLibraries(library, (name, version) =>
            {
                var dependency = libraries.SingleOrDefault(p =>
                    p.identifier?.id == name
                    && p.identifier?.version == version);
                if (dependency != null)
                    return dependency;
                else
                    throw new InvalidOperationException($"Cannot find library {name} version {version} referenced in {library.NameAndVersion}");
            });
            includes.MergeInto(buildOrder);
        }
        return buildOrder;
    }

    private static DirectedGraph GetIncludedLibraries(ElmLibrary library, Func<string, string, ElmLibrary> locateLibrary)
    {
        var graph = GetDependencySubgraph(library, locateLibrary);
        graph.AddStartNode();
        graph.AddEndNode();
        return graph;
    }

    internal static DirectedGraph GetIncludedLibraries(this ElmLibrary library, DirectoryInfo libraryPath)
    {
        var subgraph = GetDependencySubgraph(library, (name, version) =>
        {
            var stream = OpenLibrary(libraryPath, name, version);
            var dependentLibrary = ElmLibrary.LoadFromJson((Stream)stream) ??
                                   throw new InvalidOperationException($"Cannot load ELM for {name} version {version}");
            return dependentLibrary;
        });
        subgraph.AddStartNode();
        subgraph.AddEndNode();
        return subgraph;
    }

    private static Stream OpenLibrary(DirectoryInfo libraryPath, string name, string version)
    {
        var path = Path.Combine(libraryPath.FullName, $"{name}-{version}.json");
        if (!File.Exists(path))
        {
            var pathWithoutVersion = Path.Combine(libraryPath.FullName, $"{name}.json");
            if (File.Exists(pathWithoutVersion))
                path = pathWithoutVersion;
        }
        var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        return stream;
    }

    private static DirectedGraph GetDependencySubgraph(ElmLibrary library, Func<string, string, ElmLibrary> locateLibrary, bool includeLibraryProperty = true)
    {
        if (library is null)
        {
            throw new ArgumentNullException(nameof(library));
        }
        var thisGraph = new DirectedGraph();
        var properties = new Dictionary<string, object>();
        if (includeLibraryProperty)
            properties.Add(ElmLibrary.LibraryNodeProperty, library);

        var packageNode = new DirectedGraphNode
        {
            NodeId = $"{library.identifier!.id}-{library.identifier.version}",
            Label = library.identifier!.id,
            Properties = properties,
        };
        thisGraph.AddNode(packageNode);
        thisGraph.AddEdge((null, packageNode));

        if ((library.includes?.Length ?? 0) == 0)
        {
            thisGraph.AddEdge((packageNode, null));
            return thisGraph;
        }

        foreach (var include in library.includes ?? Enumerable.Empty<IncludeDef>())
        {
            var includedPackage = locateLibrary(include.path!, include.version!);
            var libGraph = GetDependencySubgraph(includedPackage, locateLibrary);
            libGraph.MergeInto(
                thisGraph,
                // Add starting nodes of 'libGraph' as forwarding nodes of 'packageNode'
                replaceMergeEdge: edge => edge.FromNodeId is DirectedGraphNode.StartId
                    ? (packageNode.NodeId, edge.ToNodeId)
                    : edge
                );
        }

        return thisGraph;
    }

    [UsedImplicitly]
    public static IEnumerable<FhirLibrary> AllLibraries(this DirectedGraph graph, string libraryProperty = "Library")
    {
        IEnumerable<FhirLibrary> GetLibraries()
        {
            foreach (var node in graph.Nodes)
            {
                if (node.Value.Properties != null)
                {
                    if (node.Value.Properties.TryGetValue(libraryProperty, out object? libObject)
                        && libObject is FhirLibrary library)
                    {
                        yield return library;
                    }
                }
            }
        }
        var libs = GetLibraries()
            .Distinct()
            .ToArray();
        return libs;
    }

    [UsedImplicitly]
    public static DirectedGraph GetDependencies(this FhirLibrary library, DirectoryInfo directory) => 
        library.GetDependencies(id =>
    {
        var file = new FileInfo(Path.Combine(directory.FullName, $"{id}.json"));
        using var fs = file.OpenRead();
        return fs.ParseFhir<FhirLibrary>();
    });

    [UsedImplicitly]
    public static DirectedGraph GetDependencies(
        this FhirLibrary library,
        Func<string, FhirLibrary> getLibrary,
        string libraryProperty = "ElmLibrary")
    {
        var graph = new DirectedGraph();
        graph.AddStartNode();
        Visit(null);
        return graph;
    
        void Visit(DirectedGraphNode? from)
        {
            if (!graph.Nodes.TryGetValue(library.Id, out var thisNode))
            {
                thisNode = new DirectedGraphNode
                {
                    NodeId = library.Id,
                    Properties = new Dictionary<string, object>
                        {
                            { libraryProperty, library }
                        }
                };
                graph.AddNode(thisNode);
                graph.AddEdge((from, thisNode));
            }
            var dependencies = library.RelatedArtifact
                .Where(ra => ra.Type == RelatedArtifact.RelatedArtifactType.DependsOn)
                .ToArray();
        
            if (dependencies.Length == 0
                && !graph.GetForwardNodeIds(thisNode.NodeId).Contains(DirectedGraphNode.EndId))
            {
                graph.AddEdge((thisNode, null));
            }
            else
            {
                foreach (var dependency in dependencies)
                {
                    var relatedArtifact = getLibrary(dependency.Resource)
                        ?? throw new InvalidOperationException($"Could not find related library {dependency.ElementId}");
                    Visit(thisNode);
                }
            }
        }
    }

    [UsedImplicitly]
    public static AssemblyLoadContext LoadAssemblies(
        this IEnumerable<FhirLibrary> libraries,
        AssemblyLoadContext asmContext)
    {
        foreach (var library in libraries)
        {
            var dll = library.Content.SingleOrDefault(att => att.ContentType == "application/octet-stream");
            if (dll != null)
            {
                using var ms = new MemoryStream(dll.Data);
                _ = asmContext.LoadFromStream(ms);
            }

        }
        return asmContext;
    }

    [UsedImplicitly]
    public static AssemblyLoadContext LoadAssembles(this IEnumerable<Binary> binaries,
        AssemblyLoadContext asmContext)
    {
        foreach (var binary in binaries)
        {
            if (binary.ContentType == "application/octet-stream")
            {
                using var ms = new MemoryStream(binary.Data);
                _ = asmContext.LoadFromStream(ms);
            }
        }
        return asmContext;
    }
}