#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace Hl7.Cql.Graph
{
    [DebuggerDisplay("DirectedGraph (Nodes:{Nodes.Count}, Edges:{GetEdgesCount()})")]
    internal class DirectedGraph
    {
        public DirectedGraph()
        {
            _startNode = new DirectedGraphNode() { NodeId = DirectedGraphNode.StartId };
            _endNode = new DirectedGraphNode() { NodeId = DirectedGraphNode.EndId };
            _nodesByNodeId = new ();
            _forwardNodesByNodeId = new();
        }


        private readonly DirectedGraphNode _startNode;
        private readonly DirectedGraphNode _endNode;
        private readonly Dictionary<string, DirectedGraphNode> _nodesByNodeId;
        private readonly Dictionary<string, HashSet<DirectedGraphNode>> _forwardNodesByNodeId;

        public IReadOnlyDictionary<string, DirectedGraphNode> Nodes => _nodesByNodeId;

        public void AddNode(DirectedGraphNode node) =>
            _nodesByNodeId.Add(node.NodeId, node);

        private void AddEdgeImpl(string? fromNodeId, DirectedGraphNode? toNode)
        {
            fromNodeId ??= DirectedGraphNode.StartId;
            ref var forwardNodes = ref CollectionsMarshal.GetValueRefOrAddDefault(_forwardNodesByNodeId, fromNodeId, out bool exists);
            if (!exists)
                forwardNodes = new();

            forwardNodes!.Add(toNode ?? _endNode);
        }

        public void AddEdge((DirectedGraphNode? FromNode, DirectedGraphNode? ToNode) edge)
        {
            AddEdgeImpl(edge.FromNode?.NodeId, edge.ToNode);
        }

        public IEnumerable<string> GetForwardNodeIds(string nodeId)
        {
            if (nodeId == DirectedGraphNode.EndId)
                return [];

            // If node doesn't belong to this graph, just return empty
            if (!_forwardNodesByNodeId.TryGetValue(nodeId, out var forwardNodes))
                return [];

            return forwardNodes.Select(forwardNode => forwardNode.NodeId);
        }

        private IEnumerable<DirectedGraphNode> GetNodesConnectedTo(DirectedGraphNode node)
        {
            foreach (var nodeId in GetForwardNodeIds(node.NodeId))
            {
                switch (nodeId)
                {
                    case DirectedGraphNode.EndId:
                        yield return _endNode;
                        break;

                    case DirectedGraphNode.StartId:
                        yield return _startNode;
                        break;

                    default:
                    {
                        if (!Nodes.TryGetValue(nodeId, out var to))
                            throw new InvalidOperationException($"The node id {nodeId} does not exist in this graph.");

                        yield return to;
                        break;
                    }
                }
            }
        }

        public IList<DirectedGraphNode> TopologicalSort()
        {
            var sorted = Sort(Nodes.Values, node => GetNodesConnectedTo(node));
            if (sorted.Count > 0 && sorted[0].IsEndNode)
                sorted.RemoveAt(0);
            return sorted;

            void Visit<T>(T item,
                Func<T, IEnumerable<T>> getDependencies,
                ICollection<T> sorted,
                IDictionary<T, bool> visited) where T : notnull
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

            IList<T> Sort<T>(IEnumerable<T> source, Func<T, IEnumerable<T>> getDependencies) where T : notnull
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

        public void AddStartNode()
        {
            AddNode(_startNode);
        }

        #region Debugging

        private int GetEdgesCount() => _forwardNodesByNodeId.Sum(kvp => kvp.Value.Count);

#if DEBUG
        public string GraphvizDiagramUri =>
            new UriBuilder("https://edotor.net/?engine=dot")
            {
                Fragment = Uri.EscapeDataString(GraphvizDiagram)
            }.Uri.ToString();

        public string GraphvizDiagram
        {
            get
            {
                var ordinalByNodeId =
                    TopologicalSort()
                        .Select((node, ordinal) => (node, ordinal))
                        .ToDictionary(t => t.node.NodeId, t => t.ordinal);

                string GetNodeText(string nodeId)
                {
                    int ordinal = ordinalByNodeId!.GetValueOrDefault(nodeId, -1);
                    return $"""
                            "{nodeId} {(ordinal < 0 ? "(?)" : $"({ordinal})")}"
                            """;
                }


                return $$"""
                         digraph G {

                             graph [ splines="polyline" rankdir="LR" ];
                             node [ shape="rectangle" ];
                             edge [ color="#22 22 22, arrowtail=dot, arrowhead=open" ];

                         {{string.Join(Environment.NewLine,
                             from nodeId in ordinalByNodeId.Keys
                             select GetNodeText(nodeId))}}

                         {{string.Join(Environment.NewLine,
                             from forwardNodeByNodeId in _forwardNodesByNodeId
                             from forwardNode in forwardNodeByNodeId.Value
                             select $"""
                                     {GetNodeText(forwardNodeByNodeId.Key)} -> {GetNodeText(forwardNode.NodeId)};
                                     """)}}
                         }
                         """;
            }
        }
#endif

        #endregion
    }

}
