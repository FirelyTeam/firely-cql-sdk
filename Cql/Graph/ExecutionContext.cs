using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Graph
{
    public abstract class ExecutionContext
    {
        protected ExecutionContext(ExecutionLog log, Random random)
        {
            Log = log;
            Random = random;
        }

        public ExecutionLog Log { get; }

        public Random Random { get; }

        public IList<GraphException> Exceptions { get; } = new List<GraphException>();

    }
}
