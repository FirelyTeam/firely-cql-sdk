#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Fhir;
using Hl7.Cql.Graph;
using Hl7.Fhir.Model;
using System.Runtime.Loader;

namespace Hl7.Cql.Packaging;

internal static class LibraryExtensions
{

    public static DirectedGraph GetDependencies(this Library library,
        Func<string, Library> getLibrary, string libraryProperty = "Library")
    {
        var graph = new DirectedGraph();
        graph.Add(graph.StartNode);
        Visit(graph, graph.StartNode, library, getLibrary, libraryProperty);
        return graph;

        void Visit(DirectedGraph graph,
            DirectedGraphNode from,
            Library library,
            Func<string, Library> getLibrary,
            string libraryProperty = "")
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
                graph.Add(thisNode);
                var edge = new DirectedGraphEdge(from, thisNode);
                from.ForwardEdges.Add(edge);
                graph.Add(edge);
            }
            var dependencies = library.RelatedArtifact
                .Where(ra => ra.Type == RelatedArtifact.RelatedArtifactType.DependsOn)
                .ToArray();

            if (dependencies.Length == 0
                && !thisNode.ForwardEdges.Select(fe => fe.ToId).Contains(graph.EndNode.NodeId))
            {
                var toEnd = new DirectedGraphEdge(thisNode, graph.EndNode);
                thisNode.ForwardEdges.Add(toEnd);
                graph.Add(toEnd);
            }
            else
            {
                foreach (var relatedArtifiact in dependencies)
                {
                    var relatedArtifact = getLibrary(relatedArtifiact.Resource)
                                          ?? throw new InvalidOperationException($"Could not find related library {relatedArtifiact.ElementId}");
                    Visit(graph, thisNode, relatedArtifact, getLibrary, libraryProperty);
                }
            }
        }
    }

    public static IEnumerable<Library> AllLibraries(this DirectedGraph graph, string libraryProperty = "Library")
    {
        IEnumerable<Library> GetLibraries()
        {
            foreach (var node in graph.Nodes)
            {
                if (node.Value.Properties != null)
                {
                    if (node.Value.Properties.TryGetValue(libraryProperty, out object? libObject)
                        && libObject is Library library)
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

    public static DirectedGraph GetDependencies(this Library library,
        DirectoryInfo directory) => library.GetDependencies(id =>
    {
        var file = new FileInfo(Path.Combine(directory.FullName, $"{id}.json"));
        using var fs = file.OpenRead();
        return fs.ParseFhir<Library>();
    });


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

    public static AssemblyLoadContext LoadAssembles(this IEnumerable<Binary> binaries,
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
}