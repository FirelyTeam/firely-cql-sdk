using Hl7.Cql.Graph;
using Hl7.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CodeGeneration.NET
{
    internal static class DefinitionDictionaryExtensions
    {
        internal static DirectedGraph SingleLibraryGraph<T>(this DefinitionDictionary<T> definitionDictionary)
            where T: class
        {
            var libs = definitionDictionary.Libraries.ToArray();
            if (libs.Length == 0)
                throw new ArgumentException($"No libraries are expressed in this {nameof(DefinitionDictionary<T>)}");
            if (libs.Length > 1)
                throw new ArgumentException($"More than 1 Library is expressed in this {nameof(DefinitionDictionary<T>)}");
            else
            {
                var single = libs[0];
                var graph = new DirectedGraph();
                graph.Add(graph.StartNode);
                graph.Add(graph.EndNode);
                var node = new DirectedGraphNode { NodeId = single };
                graph.Add(node);
                var startToNode = new DirectedGraphEdge
                {
                    EdgeId = $"{graph.StartNode.NodeId}->{single}",
                    FromId = graph.StartNode.NodeId,
                    ToId = single,
                };
                graph.Add(startToNode);
                var nodeToEnd = new DirectedGraphEdge
                {
                    EdgeId = $"{single}->{graph.EndNode.NodeId}",
                    FromId = single,
                    ToId = graph.EndNode.NodeId,
                };
                graph.Add(nodeToEnd);
                node.ForwardEdges.Add(nodeToEnd);
                return graph;
            }
        }
    }
}
