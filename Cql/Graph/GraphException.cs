/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System.Collections.Generic;

namespace Hl7.Cql.Graph
{
    public class GraphException
    {
        public IList<DirectedGraphEdge> Path { get; set; } = new List<DirectedGraphEdge>();
        public DirectedGraphEdge? ErrorEdge { get; set; }
        public EdgeAction? ErrorAction { get; set; }
        public string ExceptionMessage { get; set; } = "";
        public bool IsRandomSelectedEdge { get; set; }
    }
}
