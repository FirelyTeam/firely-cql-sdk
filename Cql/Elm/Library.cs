/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using Hl7.Cql.Elm.Serialization;
using Hl7.Cql.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Elm
{
    public partial class Library
    {
        public const string JsonMimeType = "application/elm+json";
        public const string XmlMimeType = "application/elm+xml";
        public const string LibraryNodeProperty = "Library";

        public static readonly JsonSerializerOptions JsonSerializerOptions = GetSerializerOptions(false);
        public static readonly JsonSerializerOptions JsonSerializerOptionsStrict = GetSerializerOptions(true);

        public string? NameAndVersion
        {
            get
            {
                if (identifier == null)
                    return null;
                else if (string.IsNullOrWhiteSpace(identifier.version))
                    return identifier.id;
                else return $"{identifier.id}-{identifier.version}";
            }
        }

        private static JsonSerializerOptions GetSerializerOptions(bool strict)
        {
            var options = new JsonSerializerOptions()
            {
                MaxDepth = int.MaxValue
            }
            .AddLibraryConverters()
            .AddPolymorphicConverters(strict);
            options.Converters.Add(new XmlQualifiedNameConverter());
            options.Converters.Add(new JsonStringEnumConverter());
            return options;
        }

        public static Library LoadFromJson(FileInfo file)
        {
            if (!file.Exists)
                throw new ArgumentException($"File {file.FullName} does not exist.");
            using var stream = file.OpenRead();
            return LoadFromJson(stream);
        }
        public static Library LoadFromJson(Stream stream) =>
            JsonSerializer.Deserialize<Library>(stream, JsonSerializerOptions) ??
                throw new ArgumentException($"Stream does not represent a valid {nameof(Library)}");

        /// <summary>
        /// Writes this library in JSON format to <paramref name="stream"/>.
        /// </summary>
        /// <param name="stream">A writable stream.</param>
        /// <param name="writeIndented">If <see langword="true" />, formats the JSON with indenting.</param>
        public void WriteJson(Stream stream, bool writeIndented = true)
        {
            var options = GetSerializerOptions(false);
            if (writeIndented)
                options.WriteIndented = true;
            else
                options.WriteIndented = false;
            JsonSerializer.Serialize(stream, this, options);

        }

        internal static DirectedGraph GetIncludedLibraries(IEnumerable<Library> libraries)
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
                Merge(includes, buildOrder);
            }
            return buildOrder;
        }


        internal static DirectedGraph GetIncludedLibraries(Library library, Func<string, string, Library> locateLibrary) =>
            SanitizeDependencyGraph(GetDependencySubgraph(library, locateLibrary));

        internal static DirectedGraph GetIncludedLibraries(FileInfo elmLocation, DirectoryInfo libraryPath) =>
            GetIncludedLibraries(elmLocation, (name, version) =>
            {
                var stream = OpenLibrary(libraryPath, name, version);
                var library = LoadFromJson(stream) ?? throw new InvalidOperationException($"Cannot load ELM for {name} version {version}");
                return library;
            });

        internal static DirectedGraph GetIncludedLibraries(Library library, DirectoryInfo libraryPath) =>
            SanitizeDependencyGraph(GetDependencySubgraph(library, (name, version) =>
            {
                var stream = OpenLibrary(libraryPath, name, version);
                var dependentLibrary = LoadFromJson(stream) ?? throw new InvalidOperationException($"Cannot load ELM for {name} version {version}");
                return dependentLibrary;
            }));

        internal static DirectedGraph GetIncludedLibraries(FileInfo elmLocation, Func<string, string, Library>? locateLibrary = null)
        {
            if (locateLibrary == null)
            {
                locateLibrary = (name, version) =>
                {
                    if (elmLocation.Directory is null) throw new InvalidOperationException("Directory within library is null.");
                    var path = Path.Combine(elmLocation.Directory.FullName, $"{name}-{version}.json");
                    var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                    var library = LoadFromJson(stream) ?? throw new InvalidOperationException($"Cannot load ELM from {path}");
                    return library;
                };
            }
            using var stream = elmLocation.OpenRead();
            var library = LoadFromJson(stream) ?? throw new InvalidOperationException($"Cannot load ELM from {elmLocation}");
            var graph = GetDependencySubgraph(library, locateLibrary);
            var sanitized = SanitizeDependencyGraph(graph);
            return sanitized;
        }

        internal DirectedGraph GetIncludedLibraries(DirectoryInfo libraryPath) =>
            SanitizeDependencyGraph(GetDependencySubgraph((name, version) =>
            {
                var stream = OpenLibrary(libraryPath, name, version);
                var library = LoadFromJson(stream) ?? throw new InvalidOperationException($"Cannot load ELM for {name} version {version}");
                return library;
            }));

        internal static Stream OpenLibrary(DirectoryInfo libraryPath, string name, string version)
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

        private static DirectedGraph GetDependencySubgraph(Library library, Func<string, string, Library> locateLibrary)
        {
            if (library is null)
            {
                throw new ArgumentNullException(nameof(library));
            }
            var graph = library!.GetDependencySubgraph(locateLibrary);
            return graph;
        }

        private static DirectedGraph SanitizeDependencyGraph(DirectedGraph graph)
        {
            graph.Add(graph.StartNode);
            graph.Add(graph.EndNode);
            return graph;
        }

        private DirectedGraph GetDependencySubgraph(Func<string, string, Library> locateLibrary, bool includeLibraryProperty = true)
        {
            var thisGraph = new DirectedGraph();
            var properties = new Dictionary<string, object>();
            if (includeLibraryProperty)
                properties.Add(LibraryNodeProperty, this);

            var packageNode = new DirectedGraphNode
            {
                NodeId = $"{identifier!.id}-{identifier.version}",
                Label = identifier!.id,
                Properties = properties,
            };
            thisGraph.Add(packageNode);
            var edgeFromStart = new DirectedGraphEdge(thisGraph.StartNode, packageNode);
            thisGraph.StartNode.ForwardEdges.Add(edgeFromStart);
            thisGraph.Add(edgeFromStart);

            if (includes?.Length > 0)
            {
                foreach (var include in includes ?? Enumerable.Empty<IncludeDef>())
                {
                    var includedPackage = locateLibrary(include.path!, include.version!);
                    var libGraph = GetDependencySubgraph(includedPackage, locateLibrary);
                    // add all nodes & forward edges to graph.
                    foreach (var kvp in libGraph.Nodes)
                    {
                        if (thisGraph.Nodes.ContainsKey(kvp.Key) == false)
                        {
                            var clonedNode = kvp.Value.Clone();
                            thisGraph.Add(clonedNode);
                            foreach (var edge in kvp.Value.ForwardEdges)
                                thisGraph.Add(edge);
                        }
                    }
                    // add all forward edges from lib start node to package node
                    foreach (var forwardEdge in libGraph.StartNode.ForwardEdges)
                    {
                        var destinationNodeId = forwardEdge.ToId;
                        var newEdge = new DirectedGraphEdge(packageNode.NodeId, destinationNodeId);
                        packageNode.ForwardEdges.Add(newEdge);
                        thisGraph.Add(newEdge);
                    }
                }
            }
            else
            {
                var edgeToEnd = new DirectedGraphEdge(packageNode, thisGraph.EndNode);
                packageNode.ForwardEdges.Add(edgeToEnd);
                thisGraph.Add(edgeToEnd);
            }
            return thisGraph;
        }

        private static void Merge(DirectedGraph from, DirectedGraph into)
        {
            foreach (var sourceNode in from.Nodes)
            {
                if (!into.Nodes.ContainsKey(sourceNode.Key))
                    into.Add(sourceNode.Value);
            }
            foreach (var edge in from.Edges)
            {
                if (!into.Edges.ContainsKey(edge.Key))
                    into.Add(edge.Value);
            }
            var orphaned = true;
            foreach (var edge in into.Edges)
            {
                if (edge.Value.ToId == from.StartNode.NodeId)
                {
                    orphaned = false;
                    break;
                }
            }
            if (orphaned)
            {
                into.Add(new DirectedGraphEdge(into.StartNode.NodeId, from.StartNode.NodeId));
            }
        }

    }
}
