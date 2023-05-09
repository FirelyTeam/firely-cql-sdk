using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ncqa.Cql.CodeGeneration.NET.Visitors
{
    internal class ParameterFinder : ExpressionVisitor
    {
        public IList<string> Names { get; } = new List<string>();


        protected override Expression VisitParameter(ParameterExpression node)
        {
            if (node.Name != null && !Names.Contains(node.Name))
                Names.Add(node.Name);
            return base.VisitParameter(node);
        }
    }
}
