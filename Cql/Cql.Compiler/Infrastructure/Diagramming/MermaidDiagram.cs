using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Compiler.Infrastructure.Graphs;

namespace Hl7.Cql.Compiler.Infrastructure.Diagramming;

internal static class MermaidDiagram
{

    public static string BuildMermaidFlowChart<T>(
        this IEnumerable<T> allItems,
        Func<T, IEnumerable<T>> getNextItems,
        Func<T, string> formatItem,
        string direction = "LR") =>
        $$"""
          flowchart {{direction}}

          {{string.Join(Environment.NewLine,
              allItems
                  .Select(node => $"  {formatItem(node)}")
          )}}

          {{string.Join(Environment.NewLine,
              allItems.GetEdges(getNextItems)
                  .Select(edge => $"  {formatItem(edge.From)} --> {formatItem(edge.To)}")
          )}}
          """;
}
