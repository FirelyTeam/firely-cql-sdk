using Hl7.Cql.CodeGeneration.NET.Expressions;
using Hl7.Cql.Compiler;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class UseContextParameterVisitor: ExpressionVisitor
    {
        public UseContextParameterVisitor(string contextName, 
            string contextParameterName,
            string lazyName)
        {
            ContextName = contextName;
            ContextParameterName = contextParameterName;
            LazyName = lazyName;
        }

        public string ContextName { get; }
        public string ContextParameterName { get; }
        public string LazyName { get; }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            if (node.Right is DefinitionCallExpression dce &&
                dce.DefinitionName == ContextName)
            {
                var be = Expression.MakeBinary(node.NodeType, node.Left,
                    new UseContextParameterExpression(dce.Type, ContextParameterName, LazyName));
                return be;
            }
            return base.VisitBinary(node);
        }
    }
}
