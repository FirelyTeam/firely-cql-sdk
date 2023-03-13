using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Ncqa.Graph
{
    public class DirectedGraphNode
    {
        public const string StartId = "Start";
        public const string EndId = "End";

        public string NodeId { get; set; } = string.Empty;

        public string? Label { get; set; }

        [JsonIgnore]
        public IList<DirectedGraphEdge> ForwardEdges { get; } = new List<DirectedGraphEdge>();

        public IEnumerable<string> ForwardEdgeIds { get => ForwardEdges.Select(edge => edge.EdgeId); }

        public IDictionary<string, object>? Properties { get; set; }

        public override string ToString() => NodeId;

        public T OptionalProperty<T>(string property, T defaultIfMissing)
        {
            if (Properties != null && Properties.TryGetValue(property, out var value))
            {
                if (value is T t)
                    return t;
            }
            return defaultIfMissing;
        }

        public DirectedGraphNode Clone(Func<string,string>? newId = null)
        {
            var id = newId != null ? newId(NodeId) : NodeId;
            var clonedNode = new DirectedGraphNode
            {
                NodeId = id,
                Label = Label,
            };
            if (Properties != null)
                clonedNode.Properties = Properties.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var edge in ForwardEdges)
                clonedNode.ForwardEdges.Add(edge.Clone(newId));
            return clonedNode;
        }


    }
}
