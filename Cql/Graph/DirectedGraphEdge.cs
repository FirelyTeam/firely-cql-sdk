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

namespace Hl7.Cql.Graph
{
    internal class DirectedGraphEdge
    {
        public DirectedGraphEdge() : this("", "")
        {
        }

        public DirectedGraphEdge(DirectedGraphNode from, DirectedGraphNode to) : this(
                from?.NodeId ?? throw new ArgumentNullException(nameof(from)),
                to?.NodeId ?? throw new ArgumentNullException(nameof(to))
                )
        { }

        public DirectedGraphEdge(string fromId, string toId)
        {
            FromId = DirectedGraphNode.StartId;
            ToId = DirectedGraphNode.EndId;
            FromId = fromId;
            ToId = toId;
            EdgeId = $"From {fromId} to {toId}";
        }

        public string EdgeId { get; private init; }

        public string FromId { get; private init; }

        public string ToId { get; private init; }

        public override string ToString() => $"[{EdgeId}] {FromId}-->{ToId}";

        public DirectedGraphEdge Clone(Func<string, string>? newId = null)
        {
            var id = newId != null ? newId(EdgeId) : EdgeId;
            var clone = new DirectedGraphEdge
            {
                EdgeId = id,
                FromId = FromId,
                ToId = ToId,
            };
            return clone;
        }
    }
}
