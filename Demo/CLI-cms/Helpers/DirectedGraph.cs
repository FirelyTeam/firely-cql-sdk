#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Json;

namespace Hl7.Cql.Graph
{
    internal class DirectedGraph
    {

        public DirectedGraphNode StartNode { get; set; } = new() { NodeId = DirectedGraphNode.StartId };
        public DirectedGraphNode EndNode { get; set; } = new() { NodeId = DirectedGraphNode.EndId };

        public IDictionary<string, DirectedGraphNode> Nodes { get; } = new Dictionary<string, DirectedGraphNode>();
        public IDictionary<string, DirectedGraphEdge> Edges { get; } = new Dictionary<string, DirectedGraphEdge>();

        public void Add(DirectedGraphNode node) => Nodes.Add(node.NodeId, node);
        public void Add(DirectedGraphEdge edge) => Edges.Add(edge.EdgeId, edge);
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
