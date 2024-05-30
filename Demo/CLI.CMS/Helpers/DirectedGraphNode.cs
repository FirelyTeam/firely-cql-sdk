/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Text.Json.Serialization;

namespace Hl7.Cql.Graph
{
    internal class DirectedGraphNode
    {
        public const string StartId = "Start";
        public const string EndId = "End";

        public string NodeId { get; set; } = string.Empty;

        [JsonIgnore]
        public IList<DirectedGraphEdge> ForwardEdges { get; } = new List<DirectedGraphEdge>();

        public IDictionary<string, object>? Properties { get; set; }

        public override string ToString() => NodeId;
    }
}
