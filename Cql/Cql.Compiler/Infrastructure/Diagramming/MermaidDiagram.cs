/*
 * Copyright (c) 2024, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
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
