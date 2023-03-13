using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Graph
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
