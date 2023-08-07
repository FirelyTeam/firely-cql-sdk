/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Hl7.Cql.Graph
{
    public class DirectedGraph
    {

        public DirectedGraphNode StartNode { get; set; } = new DirectedGraphNode { NodeId = DirectedGraphNode.StartId };
        public DirectedGraphNode EndNode { get; set; } = new DirectedGraphNode { NodeId = DirectedGraphNode.EndId };

        public IDictionary<string, DirectedGraphNode> Nodes { get; } = new Dictionary<string, DirectedGraphNode>();
        public IDictionary<string, DirectedGraphEdge> Edges { get; } = new Dictionary<string, DirectedGraphEdge>();

        public IDictionary<string, object>? Properties { get; set; }

        public void Add(DirectedGraphNode node) => Nodes.Add(node.NodeId, node);
        public void Add(DirectedGraphEdge edge) => Edges.Add(edge.EdgeId, edge);
        public void AddEdge(DirectedGraphNode from, DirectedGraphNode to)
        {
            var edge = new DirectedGraphEdge(from, to);
            if (Edges.ContainsKey(edge.EdgeId))
                throw new ArgumentException($"Edge {edge.EdgeId} already exists");
            Add(edge);
            from.ForwardEdges.Add(edge);
        }

        public DirectedGraphNode Attach(string newNodeId, DirectedGraphNode from, string? edgeId = null)
        {
            if (Nodes.ContainsKey(newNodeId))
                throw new ArgumentException($"Node {newNodeId} already exists in this graph.");
            edgeId ??= $"{from.NodeId}->{newNodeId}";
            if (Edges.ContainsKey(edgeId))
                throw new ArgumentException($"Edge {edgeId} already exists in this graph.");
            var node = new DirectedGraphNode
            {
                NodeId = newNodeId,
            };
            Add(node);
            var edge = new DirectedGraphEdge
            {
                EdgeId = edgeId,
                FromId = from.NodeId,
                ToId = newNodeId,
            };
            Add(edge);
            from.ForwardEdges.Add(edge);
            return node;
        }

        public DirectedGraphNode Attach(string newNodeId, params DirectedGraphNode[] from)
        {
            if (Nodes.ContainsKey(newNodeId))
                throw new ArgumentException($"Node {newNodeId} already exists in this graph.");
            var node = new DirectedGraphNode
            {
                NodeId = newNodeId,
            };
            Add(node);
            foreach (var fromNode in from)
            {
                var edgeId = $"{fromNode.NodeId}->{newNodeId}";
                if (Edges.ContainsKey(edgeId))
                    throw new ArgumentException($"Edge {edgeId} already exists in this graph.");
                var edge = new DirectedGraphEdge
                {
                    EdgeId = edgeId,
                    FromId = fromNode.NodeId,
                    ToId = newNodeId,
                };
                Add(edge);
                fromNode.ForwardEdges.Add(edge);
            }
            return node;
        }


        public DirectedGraphEdge Add(DirectedGraph subGraph, string fromNodeId, string? edgeId = null)
        {
            if (subGraph is null)
            {
                throw new ArgumentNullException(nameof(subGraph));
            }

            if (fromNodeId is null)
            {
                throw new ArgumentNullException(nameof(fromNodeId));
            }
            if (!Nodes.TryGetValue(fromNodeId, out var fromNode))
                throw new ArgumentException($"The node with id {fromNodeId} does not exist in this graph.", nameof(fromNodeId));

            foreach (var node in subGraph.Nodes.Values)
            {
                if (!Nodes.ContainsKey(node.NodeId))
                    Add(node);
                else
                {
                    foreach (var fwdEdge in node.ForwardEdges)
                    {
                        if (!Nodes[node.NodeId].ForwardEdgeIds.Contains(fwdEdge.EdgeId))
                        {
                            Nodes[node.NodeId].ForwardEdges.Add(fwdEdge);
                        }
                    }
                }
            }

            foreach (var edge in subGraph.Edges.Values)
                if (!Edges.ContainsKey(edge.EdgeId))
                    Add(edge);

            var newEdge = new DirectedGraphEdge
            {
                FromId = fromNode!.NodeId,
                ToId = subGraph.StartNode.NodeId,
                EdgeId = edgeId ?? $"From {fromNode!.NodeId} to {subGraph.StartNode.NodeId}"
            };
            Edges.Add(newEdge.EdgeId, newEdge);
            fromNode.ForwardEdges.Add(newEdge);
            return newEdge;
        }

        public void AddAndReparentSubgraph(DirectedGraph subGraph, string fromNodeId)
        {
            if (subGraph is null)
            {
                throw new ArgumentNullException(nameof(subGraph));
            }

            if (fromNodeId is null)
            {
                throw new ArgumentNullException(nameof(fromNodeId));
            }

            if (!Nodes.TryGetValue(fromNodeId, out var fromNode))
                throw new ArgumentException($"The node with id {fromNodeId} does not exist in this graph.", nameof(fromNodeId));

            foreach (var node in subGraph.Nodes.Values)
            {
                if (node.NodeId == subGraph.StartNode.NodeId)
                {
                    continue;
                }

                if (!Nodes.ContainsKey(node.NodeId))
                    Add(node);
            }
            foreach (var edge in subGraph.Edges.Values)
            {
                if (edge.FromId == subGraph.StartNode.NodeId)
                {
                    var newEdge = new DirectedGraphEdge
                    {
                        FromId = fromNodeId,
                        ToId = edge.ToId,
                        EdgeId = $"From {fromNodeId} to {edge.ToId}"
                    };
                    Edges.Add(newEdge.EdgeId, newEdge);
                    fromNode.ForwardEdges.Add(newEdge);

                }
                else if (!Edges.ContainsKey(edge.EdgeId))
                    Add(edge);
            }

        }

        public IEnumerable<IList<DirectedGraphEdge>> GetAllPaths(DirectedGraphNode? node = null)
        {
            var danglingLeafNodeIds = Nodes.Values
                .Where(node => node.NodeId != DirectedGraphNode.EndId && node.ForwardEdges.Count == 0)
                .Select(node => node.NodeId)
                .ToList();
            if (danglingLeafNodeIds.Count > 0)
                throw new InvalidOperationException($"Dangling leaf nodes detected.  Node IDs: {string.Join(", ", danglingLeafNodeIds)}");
            foreach (var path in DepthFirst(node ?? StartNode, new DirectedGraphEdge[0], new List<DirectedGraphEdge>(), new List<DirectedGraphEdge>()))
                yield return path;
        }

        public IEnumerable<(DirectedGraphEdge Edge, DirectedGraphNode Node)> GetNodesConnectedTo(DirectedGraphNode node)
        {
            foreach (var edge in node.ForwardEdges)
            {
                if (edge.ToId == EndNode?.NodeId)
                    yield return (edge, EndNode);
                else if (edge.ToId == StartNode?.NodeId)
                    yield return (edge, StartNode);
                else if (Nodes.TryGetValue(edge.ToId, out var to))
                    yield return (edge, to);
                else throw new ArgumentException($"Edge {edge.EdgeId} points to node {edge.ToId} which does not exist in this graph.", nameof(node));
            }
        }

        public IList<DirectedGraphNode> NodesBreadthFirst()
        {
            var order = new List<DirectedGraphNode>(Nodes.Count);
            var queue = new List<DirectedGraphNode>(Nodes.Count);
            var visited = new List<string>(Nodes.Count);
            queue.Add(StartNode);
            while (queue.Count > 0)
            {
                var node = queue[0];
                queue.RemoveAt(0);
                visited.Add(node.NodeId);
                if (!order.Contains(node) && node != StartNode && node != EndNode)
                    order.Add(node);
                foreach (var edge in node.ForwardEdges)
                {
                    var to = Nodes[edge.ToId];
                    if (!visited.Contains(to.NodeId))
                        queue.Add(to);
                }
            }
            return order;
        }

        public IList<DirectedGraphNode> TopologicalSort()
        {
            var sorted = Sort(Nodes.Values,
                node => GetNodesConnectedTo(node).Select(tuple => tuple.Node));
            if (sorted.Count > 0 && sorted[0].NodeId == EndNode.NodeId)
                sorted.RemoveAt(0);
            return sorted;

            void Visit<T>(T item, Func<T, IEnumerable<T>> getDependencies,
                          List<T> sorted, Dictionary<T, bool> visited)
            {
                bool inProcess;
                var alreadyVisited = visited.TryGetValue(item, out inProcess);

                if (alreadyVisited)
                {
                    if (inProcess)
                    {
                        throw new ArgumentException("Cyclic dependency found.");
                    }
                }
                else
                {
                    visited[item] = true;

                    var dependencies = getDependencies(item);
                    if (dependencies != null)
                    {
                        foreach (var dependency in dependencies)
                        {
                            Visit(dependency, getDependencies, sorted, visited);
                        }
                    }

                    visited[item] = false;
                    sorted.Add(item);
                }
            }
            IList<T> Sort<T>(IEnumerable<T> source, Func<T, IEnumerable<T>> getDependencies)
            {
                var sorted = new List<T>();
                var visited = new Dictionary<T, bool>();

                foreach (var item in source)
                {
                    Visit(item, getDependencies, sorted, visited);
                }
                return sorted;
            }
        }

        public void ValidateGraph(out bool hasCycle)
        {
            var cycles = new List<DirectedGraphEdge>();
            DepthFirst(StartNode, new DirectedGraphEdge[0], new List<DirectedGraphEdge>(), cycles).ToList();
            hasCycle = cycles.Any();
        }

        public bool HasCycle()
        {
            ValidateGraph(out bool hasCycle);
            return hasCycle;
        }

        public virtual ExecutedPath<TContext> Run<TContext>(TContext context, IList<DirectedGraphEdge> edges)
            where TContext : ExecutionContext
        {
            var executedPath = new ExecutedPath<TContext>(context);
            DirectedGraphEdge? edge = null;
            var enumerator = edges.GetEnumerator();
            while (enumerator.MoveNext())
            {
                edge = enumerator.Current;
                context.Log.WriteLine($"Node {edge.FromId} to {edge.ToId}");
                foreach (var action in edge.Actions.OfType<EdgeAction<TContext>>())
                {
                    try
                    {
                        action.Execute(executedPath);
                    }
                    catch (Exception ex)
                    {
                        var error = new GraphException
                        {
                            Path = edges,
                            ErrorEdge = edge,
                            ErrorAction = action,
                            ExceptionMessage = ex.Message,
                            IsRandomSelectedEdge = false
                        };
                        context.Exceptions.Add(error);
                        throw;
                    }
                }
            }
            // If this path was a partial - meaning all subsequent edges were already hit by other paths -
            // then just randomly select paths until an end event occurs.
            while (edge!.ToId != DirectedGraphNode.EndId)
            {
                var to = Nodes[edge!.ToId];
                if (to.ForwardEdges?.Count > 0)
                {
                    var nextEdgeIndex = executedPath.Context.Random.Next(0, to.ForwardEdges?.Count ?? 0);
                    edge = to.ForwardEdges![nextEdgeIndex];
                    context.Log.WriteLine($"Node {edge.FromId} to {edge.ToId}");
                    foreach (var action in edge.Actions.OfType<EdgeAction<TContext>>())
                        try
                        {
                            action.Execute(executedPath);
                        }
                        catch (Exception ex)
                        {
                            var error = new GraphException
                            {
                                Path = edges,
                                ErrorEdge = edge,
                                ErrorAction = action,
                                ExceptionMessage = ex.Message,
                                IsRandomSelectedEdge = true
                            };
                            context.Exceptions.Add(error);
                            throw;
                        }
                }
            }
            return executedPath;
        }

        public void SerializeToJson(Stream jsonStream)
        {
            if (jsonStream is null)
            {
                throw new ArgumentNullException(nameof(jsonStream));
            }
            if (!jsonStream.CanWrite)
                throw new InvalidOperationException("Stream can't write.");

            JsonSerializer.Serialize(jsonStream, this, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            jsonStream.Flush();
        }

        public DirectedGraph Clone()
        {
            var clone = new DirectedGraph();
            foreach (var kvp in Nodes)
            {
                var newNode = kvp.Value.Clone();
                clone.Add(newNode);
                foreach (var edge in newNode.ForwardEdges)
                    clone.Add(edge);
            }
            clone.StartNode = clone.Nodes[StartNode.NodeId];
            clone.EndNode = clone.Nodes[EndNode.NodeId];
            return clone;
        }

        /// <summary>
        /// Creates a reversed graph whose edge directions are all changed.
        /// </summary>
        public DirectedGraph Reverse()
        {
            var reversed = new DirectedGraph();
            foreach (var kvp in Nodes)
            {
                var newNode = new DirectedGraphNode
                {
                    NodeId = kvp.Value.NodeId
                };
                reversed.Add(newNode);
            }
            foreach (var kvp in Edges)
            {
                var from = kvp.Value.ToId;
                if (from == EndNode.NodeId)
                    from = StartNode.NodeId;
                var to = kvp.Value.FromId;
                if (to == StartNode.NodeId)
                    to = EndNode.NodeId;

                var newEdge = new DirectedGraphEdge
                {
                    FromId = from,
                    ToId = to,
                    EdgeId = $"[Reversed] {kvp.Value.EdgeId}"
                };
                reversed.Add(newEdge);
            }
            foreach (var group in reversed.Edges.Values.GroupBy(e => e.FromId))
            {
                DirectedGraphNode? fromNode = null;
                if (group.Key == StartNode.NodeId)
                    fromNode = StartNode;
                else
                    fromNode = reversed.Nodes[group.Key];
                foreach (var edge in group)
                    fromNode.ForwardEdges.Add(edge);
            }
            return reversed;
        }

        private IEnumerable<IList<DirectedGraphEdge>> DepthFirst(DirectedGraphNode start, IList<DirectedGraphEdge> pathSoFar, List<DirectedGraphEdge> visited, List<DirectedGraphEdge> cycles, bool failOnCycle = false)
        {
            if (start.NodeId == DirectedGraphNode.EndId || start.ForwardEdges?.Count == 0)
                yield return pathSoFar;
            else
            {
                var unvisitedEdges = (start.ForwardEdges ?? Enumerable.Empty<DirectedGraphEdge>())
                    .Where(forwardEdge => visited.Contains(forwardEdge) == false)
                    .ToList();
                if (unvisitedEdges.Any())
                {
                    var nodesVisited = pathSoFar
                        .Select(x => x.FromId)
                        .Union(pathSoFar
                        .Select(x => x.ToId))
                        .ToHashSet();
                    foreach (var edge in unvisitedEdges)
                    {
                        visited.Add(edge);
                        if (edge.ToId != start.NodeId &&
                            !pathSoFar.Contains(edge) &&
                            !nodesVisited.Contains(edge.ToId))
                        {
                            var newPath = new List<DirectedGraphEdge>(pathSoFar);
                            newPath.Add(edge);
                            if (Nodes.TryGetValue(edge.ToId, out var to))
                                foreach (var path in DepthFirst(to, newPath, visited, cycles, failOnCycle))
                                    yield return path;
                            else
                            {
                                yield return newPath;
                            }
                        }
                        else
                        {
                            cycles.Add(edge);
                            if (failOnCycle)
                                throw new InvalidDataException($"Cycle Detected for node: {edge.ToId}");
                        }
                    }
                }
                else
                {
                    yield return pathSoFar;
                }
            }
        }


    }

}
