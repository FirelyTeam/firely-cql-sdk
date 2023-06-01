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
