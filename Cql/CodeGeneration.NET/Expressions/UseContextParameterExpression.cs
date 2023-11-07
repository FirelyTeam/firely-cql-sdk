using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.CodeGeneration.NET.Expressions
{
    internal class UseContextParameterExpression: Expression
    {
        public UseContextParameterExpression(Type type, string contextParameterName, string lazyName)
        {
            Type = type;
            ContextParameterName = contextParameterName;
            LazyName = lazyName;
        }

        public string ContextParameterName { get; }
        public string LazyName { get; }

        public override ExpressionType NodeType => ExpressionType.Extension;

        public override Type Type { get; }
    }
}
