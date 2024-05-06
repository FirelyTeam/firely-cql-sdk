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
    public readonly struct DirectedGraphNode
    {
        public const string StartId = "Start";
        public const string EndId = "End";

        public DirectedGraphNode()
        {
            NodeId = string.Empty;
        }

        private DirectedGraphNode(DirectedGraphNode source)
        {
            NodeId = source.NodeId;
            Label = source.Label;
            Properties = source.Properties?.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }

        public override string ToString() => NodeId;


        public DirectedGraphNode Clone() => new(this);

        public override int GetHashCode() =>
            HashCode.Combine(NodeId, Label, Properties);

        public string NodeId { get; init; }

        public string? Label { get; init; }

        [JsonIgnore]
        public bool IsStartNode => NodeId == StartId;

        [JsonIgnore]
        public bool IsEndNode => NodeId == EndId;

        public IDictionary<string, object>? Properties { get; init; }
    }
}
