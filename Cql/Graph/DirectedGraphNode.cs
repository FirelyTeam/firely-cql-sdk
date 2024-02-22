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
using System.Linq;
using System.Text.Json.Serialization;

namespace Hl7.Cql.Graph
{
    internal class DirectedGraphNode
    {
        public const string StartId = "Start";
        public const string EndId = "End";

        public string NodeId { get; init; } = string.Empty;

        public string? Label { get; init; }

        [JsonIgnore]
        public IList<DirectedGraphEdge> ForwardEdges { get; } = new List<DirectedGraphEdge>();

        public IDictionary<string, object>? Properties { get; set; }

        public override string ToString() => NodeId;


        public DirectedGraphNode Clone(Func<string, string>? newId = null)
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

        public override int GetHashCode()
        {
            return HashCode.Combine(NodeId, Label, ForwardEdges, Properties);
        }
    }
}
