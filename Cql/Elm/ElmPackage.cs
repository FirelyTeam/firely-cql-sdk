/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Elm.Expressions;
using Hl7.Cql.Graph;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Hl7.Cql.Elm
{
    [DebuggerDisplay("{NameAndVersion}")]
    public class ElmPackage
    {
        #region Statics

        public const string JsonMimeType = "application/elm+json";
        public const string PackageNodeProperty = "Package";

        private static readonly ElmExpressionConverter ExpressionConverter = new ElmExpressionConverter();
        public static (string?, string?) ReadNameAndVersion(FileInfo file) => ReadNameAndVersion(file.OpenRead());

        public static (string?, string?) ReadNameAndVersion(Stream stream)
        {
            using var reader = new JsonTextReader(new StreamReader(stream));
            reader.MaxDepth = 1028;
            var root = JObject.Load(reader);
            var lib = root["library"]!;
            var identifier = lib["identifier"];
            return (identifier?["id"]!.Value<string>()!, identifier?["version"]!.Value<string>()!);
        }

        /// <summary>
        /// Returns "<paramref name="name"/>-<paramref name="version"/>".
        /// </summary>
        /// <param name="name">The name of the library.</param>
        /// <param name="version">The version.</param>
        /// <returns>"<paramref name="name"/>-<paramref name="version"/>"</returns>
        public static string? NameAndVersionFor(string? name, string? version)
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;
            else if (string.IsNullOrWhiteSpace(version))
                return name;
            else
                return $"{name}-{version}";
        }

        public string NameAndVersion => $"{library?.identifier?.id}-{library?.identifier?.version}";

        /// <returns>(startLine, startColumn, endLine, endColumn)</returns>
        public static (int, int, int, int) ParseLocator(string locator)
        {
            var firstColon = locator.IndexOf(':');
            if (firstColon > -1)
            {
                var dash = locator.IndexOf('-', firstColon);
                if (dash > -1)
                {
                    var secondColon = locator.IndexOf(':', dash);
                    if (secondColon > -1)
                    {
                        var startLine = int.Parse(locator.Substring(0, firstColon));
                        var startCol = int.Parse(locator.Substring(firstColon + 1, dash - firstColon - 1));
                        var endline = int.Parse(locator.Substring(dash + 1, secondColon - dash - 1));
                        var endCol = int.Parse(locator.Substring(secondColon + 1));
                        return (startLine, startCol, endline, endCol);
                    }
                }
                else
                {
                    var startLine = int.Parse(locator.Substring(0, firstColon));
                    var startCol = int.Parse(locator.Substring(firstColon + 1));
                    return (startLine, startCol, startLine, startCol);
                }
            }
            throw new ArgumentException("Locator is not in the right format (dd:dd-dd:dd)", nameof(locator));
        }

        public static ElmPackage? LoadFrom(string path) => LoadFrom(new FileInfo(path));

        public static ElmPackage? LoadFrom(FileInfo file)
        {
            if (!file.Exists)
                throw new ArgumentException($"File {file.FullName} does not exist.");
            using var stream = file.OpenRead();
            return LoadFrom(stream);
        }

        public static ElmPackage? LoadFrom(Stream stream)
        {
            using var streamReader = new StreamReader(stream, Encoding.UTF8, true, 1024, true);
            return LoadFrom(streamReader);
        }

        public static ElmPackage? LoadFrom(TextReader streamReader)
        {
            var jsonTextReader = new JsonTextReader(streamReader);
            jsonTextReader.MaxDepth = 128;
            var serializer = new JsonSerializer();
            serializer.Converters.Add(ExpressionConverter);
            serializer.DateParseHandling = DateParseHandling.None;
            serializer.MaxDepth = 1024;
            var elmPackage = serializer.Deserialize<ElmPackage>(jsonTextReader);
            return elmPackage;
        }

        public static ElmPackage? DeserializeFrom(string json)
        {
            using TextReader reader = new StringReader(json);
            return LoadFrom(reader);

        }

        public static DirectedGraph GetIncludedLibraries(IEnumerable<ElmPackage> packages)
        {
            var buildOrder = new DirectedGraph();
            foreach (var package in packages)
            {
                var includes = ElmPackage.GetIncludedLibraries(package, (name, version) =>
                {
                    var dependency = packages.SingleOrDefault(p =>
                        p.library?.identifier?.id == name
                        && p.library?.identifier?.version == version);
                    if (dependency != null)
                        return dependency;
                    else
                        throw new InvalidOperationException($"Cannot find library {ElmPackage.NameAndVersionFor(name, version) ?? "<unknown>"} referenced in {package.NameAndVersion}");
                });
                Merge(includes, buildOrder);
            }
            return buildOrder;
        }

        public static DirectedGraph GetIncludedLibraries(FileInfo elmLocation, Func<string, string, ElmPackage>? locateLibrary = null)
        {
            if (locateLibrary == null)
            {
                locateLibrary = (name, version) =>
                {
                    var path = Path.Combine(elmLocation.Directory.FullName, $"{name}-{version}.json");
                    var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                    var package = LoadFrom(stream) ?? throw new InvalidOperationException($"Cannot load ELM from {path}");
                    return package;
                };
            }
            using var stream = elmLocation.OpenRead();
            var package = LoadFrom(stream) ?? throw new InvalidOperationException($"Cannot load ELM from {elmLocation}");
            var graph = GetDependencySubgraph(package, locateLibrary);
            var sanitized = SanitizeDependencyGraph(graph);
            return sanitized;
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

        public static DirectedGraph GetIncludedLibraries(FileInfo elmLocation, DirectoryInfo libraryPath) =>
            GetIncludedLibraries(elmLocation, (name, version) =>
            {
                var stream = OpenLibrary(libraryPath, name, version);
                var package = LoadFrom(stream) ?? throw new InvalidOperationException($"Cannot load ELM for {name} version {version}");
                return package;
            });



        public DirectedGraph GetIncludedLibraries(DirectoryInfo libraryPath) =>
            SanitizeDependencyGraph(GetDependencySubgraph((name, version) =>
            {
                var stream = OpenLibrary(libraryPath, name, version);
                var package = LoadFrom(stream) ?? throw new InvalidOperationException($"Cannot load ELM for {name} version {version}");
                return package;
            }));

        public static DirectedGraph GetIncludedLibraries(ElmPackage package, DirectoryInfo libraryPath) =>
            SanitizeDependencyGraph(GetDependencySubgraph(package, (name, version) =>
            {
                var stream = OpenLibrary(libraryPath, name, version);
                var package = LoadFrom(stream) ?? throw new InvalidOperationException($"Cannot load ELM for {name} version {version}");
                return package;
            }));

        public static DirectedGraph GetIncludedLibraries(ElmPackage package, Func<string, string, ElmPackage> locateLibrary) =>
            SanitizeDependencyGraph(GetDependencySubgraph(package, locateLibrary));

        public static DirectedGraph GetIncludedLibraries(string name, string? version, IEnumerable<ElmPackage> packages)
        {
            var packagesByNameAndVersionString = packages.ToDictionary(p => p.NameAndVersion);
            var nav = NameAndVersionFor(name, version);
            if (!string.IsNullOrWhiteSpace(nav) && packagesByNameAndVersionString.TryGetValue(nav!, out var package))
            {
                var includes = GetIncludedLibraries(package, (n, v) =>
                {
                    var _nav = NameAndVersionFor(n, v);
                    if (!string.IsNullOrWhiteSpace(_nav)
                        && packagesByNameAndVersionString.TryGetValue(_nav!, out var dependency))
                        return dependency;
                    throw new InvalidOperationException($"Package with name \"{name}\" and version \"{version}\" cannot be resolved.");
                });
                return includes;
            }
            else throw new ArgumentException($"Package with name \"{name}\" and version \"{version}\" cannot be resolved.", nameof(name));
        }


        private static DirectedGraph SanitizeDependencyGraph(DirectedGraph graph)
        {
            graph.Add(graph.StartNode);
            graph.Add(graph.EndNode);
            return graph;
        }
        private static DirectedGraph GetDependencySubgraph(ElmPackage package, Func<string, string, ElmPackage> locateLibrary)
        {
            if (package is null)
            {
                throw new ArgumentNullException(nameof(package));
            }
            var graph = package!.GetDependencySubgraph(locateLibrary);
            return graph;
        }


        #endregion

        public string? sourceLocation { get; set; }
        public Library? library { get; set; }

        private DirectedGraph GetDependencySubgraph(Func<string, string, ElmPackage> locateLibrary, bool includePackageProperty = true)
        {
            var thisGraph = new DirectedGraph();
            var properties = new Dictionary<string, object>();
            if (includePackageProperty)
                properties.Add(PackageNodeProperty, this);

            var packageNode = new DirectedGraphNode
            {
                NodeId = $"{library!.identifier!.id}-{library.identifier.version}",
                Label = library!.identifier!.id,
                Properties = properties,
            };
            thisGraph.Add(packageNode);
            var edgeFromStart = new DirectedGraphEdge(thisGraph.StartNode, packageNode);
            thisGraph.StartNode.ForwardEdges.Add(edgeFromStart);
            thisGraph.Add(edgeFromStart);

            if (library?.includes?.def?.Count() > 0)
            {
                foreach (var include in library?.includes?.def ?? Enumerable.Empty<IncludeExpression>())
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
    public static class DirectedGraphExtensions
    {
        public static IEnumerable<ElmPackage> Packages(this DirectedGraph graph)
        {
            foreach (var node in graph.Nodes)
            {
                if (node.Value.Properties != null
                    && node.Value.Properties.TryGetValue(ElmPackage.PackageNodeProperty, out object? packageObject)
                    && packageObject is ElmPackage package)
                {
                    yield return package;
                }
            }
        }
    }
}
