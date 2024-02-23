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

namespace Hl7.Cql.Graph
{
    [DebuggerDisplay("DirectedGraph (Nodes:{Nodes.Count}, Edges:{Edges.Count})")]
    internal class DirectedGraph
    {
        public DirectedGraph()
        {
            _startNode = new DirectedGraphNode() { NodeId = DirectedGraphNode.StartId };
            _endNode = new DirectedGraphNode() { NodeId = DirectedGraphNode.EndId };
            _nodes = new ();
            _edges = new ();
        }


        private readonly DirectedGraphNode _startNode;

        private readonly DirectedGraphNode _endNode;

        private readonly Dictionary<string, DirectedGraphNode> _nodes;
        public IReadOnlyDictionary<string, DirectedGraphNode> Nodes => _nodes;

        private readonly HashSet<(string FromId, string ToId)> _edges;

        public IReadOnlyCollection<(string FromId, string ToId)> Edges => _edges;


        public void AddNode(DirectedGraphNode node) =>
            _nodes.Add(node.NodeId, node);

        public void AddEdge((DirectedGraphNode? FromNode, DirectedGraphNode? ToNode) edge) => 
            AddEdge((edge.FromNode?.NodeId, edge.ToNode?.NodeId));

        public void AddEdge((string? FromId, string? ToId) edge)
        {
            Debug.Assert(edge.FromId != edge.ToId, "Self referencing edge not allowed.");
            _edges.Add(new(edge.FromId ?? DirectedGraphNode.StartId, edge.ToId ?? DirectedGraphNode.EndId));
        }

        public IEnumerable<string> GetForwardNodeIds(string nodeId)
        {
            if (nodeId == DirectedGraphNode.EndId)
                return Enumerable.Empty<string>();

            var result = Edges
                .Where(e => e.FromId == nodeId)
                .Select(e => e.ToId)
                .ToList(); // TODO: Remove ToList()
            
            Debug.Assert(!result.Contains(nodeId), "Cyclic dependency");

            return result;
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


        public string GraphvizDiagram =>
            $$"""
            digraph G {
              
                graph [ splines="polyline" rankdir="LR" ];
                node [ shape="rectangle" ];
                edge [ color="#22 22 22, arrowtail=dot, arrowhead=open" ];

            {{
                string.Join(Environment.NewLine,
                    from node in Nodes.Values
                    select $"""
                            "{node.NodeId}";
                            """)
            }}
            
            {{
                string.Join(Environment.NewLine,
                    from edge in Edges
                    select $"""
                            "{edge.FromId}" -> "{edge.ToId}";
                            """)
            }}
            }
            """;

        public void AddEndNode()
        {
            AddNode(_endNode);
        }

        public void AddStartNode()
        {
            AddNode(_startNode);
        }

        public void MergeInto(DirectedGraph into)
        {
            foreach (var node in Nodes)
            {
                if (!into.Nodes.ContainsKey(node.Key))
                    into.AddNode(node.Value);
            }
            foreach (var edge in Edges)
            {
                if (!into.Edges.Contains(edge))
                    into.AddEdge(edge);
            }
        }
    }

}
