using Hl7.Cql.Fhir;
using Hl7.Cql.Graph;
using Hl7.Fhir.Model;
using JetBrains.Annotations;
using System.Runtime.Loader;
using FhirLibrary = Hl7.Fhir.Model.Library;

namespace CLI_cms.Helpers;

internal static class LibraryExtensions
{
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
    public static IEnumerable<FhirLibrary> AllLibraries(this DirectedGraph graph, string libraryProperty = "Library")
    {
        IEnumerable<FhirLibrary> GetLibraries()
        {
            foreach (var node in graph.Nodes)
            {
                if (node.Value.Properties != null)
                {
                    if (node.Value.Properties.TryGetValue(libraryProperty, out object libObject)
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
    public static DirectedGraph GetDependencies(
        this FhirLibrary library,
        DirectoryInfo directory) =>
        library.GetDependencies(id =>
        {
            var file = new FileInfo(Path.Combine(directory.FullName, $"{id}.json"));
            using var fs = file.OpenRead();
            return fs.ParseFhir<FhirLibrary>();
        });

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
