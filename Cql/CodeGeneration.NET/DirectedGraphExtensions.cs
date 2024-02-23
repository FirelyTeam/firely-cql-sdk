using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Graph;

namespace Hl7.Cql.CodeGeneration.NET;

internal static class DirectedGraphExtensions
{
    public static IList<DirectedGraphNode> DetermineBuildOrder(this DirectedGraph minimalGraph)
    {
        var sorted = minimalGraph
            .TopologicalSort()
            .Where(n => n is {IsStartNode:false, IsEndNode:false})
            .ToList();
        return sorted;
    }
}