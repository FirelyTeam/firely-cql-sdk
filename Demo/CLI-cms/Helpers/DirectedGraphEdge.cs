#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Graph
{
    internal class DirectedGraphEdge
    {
        public DirectedGraphEdge() { }

        public DirectedGraphEdge(DirectedGraphNode from, DirectedGraphNode to) : this(
                from?.NodeId ?? throw new ArgumentNullException(nameof(from)),
                to?.NodeId ?? throw new ArgumentNullException(nameof(to))
                )
        { }

        public DirectedGraphEdge(string fromId, string toId)
        {
            FromId = fromId;
            ToId = toId;
            EdgeId = $"From {fromId} to {toId}";
        }

        public string EdgeId { get; set; } = string.Empty;

        public IList<EdgeAction> Actions { get; } = new List<EdgeAction>();

        public string FromId { get; set; } = DirectedGraphNode.StartId;

        public string ToId { get; set; } = DirectedGraphNode.EndId;

        public override string ToString() => $"[{EdgeId}] {FromId}-->{ToId}";
        public IDictionary<string, object>? Properties { get; set; }

        public DirectedGraphEdge Clone(Func<string, string>? newId = null)
        {
            var id = newId != null ? newId(EdgeId) : EdgeId;
            var clone = new DirectedGraphEdge
            {
                EdgeId = id,
                FromId = FromId,
                ToId = ToId,
            };
            foreach (var action in Actions)
                clone.Actions.Add(action);
            return clone;
        }
    }
}
