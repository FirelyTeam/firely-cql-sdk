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
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Hl7.Cql.Graph
{
    [DebuggerDisplay("DirectedGraph (Nodes:{Nodes.Count}, Edges:{Edges.Count})")]
    internal class DirectedGraph
    {

        public DirectedGraphNode StartNode { get; } = new DirectedGraphNode { NodeId = DirectedGraphNode.StartId };
        public DirectedGraphNode EndNode { get; } = new DirectedGraphNode { NodeId = DirectedGraphNode.EndId };

        public IDictionary<string, DirectedGraphNode> Nodes { get; } = new Dictionary<string, DirectedGraphNode>();
        public IDictionary<string, DirectedGraphEdge> Edges { get; } = new Dictionary<string, DirectedGraphEdge>();


        public void Add(DirectedGraphNode node) => Nodes.Add(node.NodeId, node);
        public void Add(DirectedGraphEdge edge) => Edges.Add(edge.EdgeId, edge);

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
        
        public IList<DirectedGraphNode> TopologicalSort()
        {
            var sorted = Sort(Nodes.Values,
                node => GetNodesConnectedTo(node).Select(tuple => tuple.Node));
            if (sorted.Count > 0 && sorted[0].NodeId == EndNode.NodeId)
                sorted.RemoveAt(0);
            return sorted;

            void Visit<T>(T item, Func<T, IEnumerable<T>> getDependencies,
                          List<T> sorted, Dictionary<T, bool> visited) where T : notnull
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
                    from edge in Edges.Values
                    select $"""
                            "{edge.FromId}" -> "{edge.ToId}";
                            """)
            }}
            }
            """;
    }

}
