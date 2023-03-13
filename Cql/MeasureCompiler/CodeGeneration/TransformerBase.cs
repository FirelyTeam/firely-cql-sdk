using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ncqa.Cql.MeasureCompiler.CodeGeneration
{
    public class TransformerBase: ExpressionVisitor
    {

        protected override System.Linq.Expressions.Expression VisitNew(NewExpression node)
        {
            if (node.Arguments?.Count > 0)
            {
                var newArguments = new System.Linq.Expressions.Expression[node.Arguments.Count];
                for (int i = 0; i < node.Arguments.Count; i++)
                {
                    var visited = Visit(node.Arguments[i]);
                    newArguments[i] = visited;
                }
                var newCall = Expression.New(node.Constructor, newArguments);
                return newCall;
            }
            return base.VisitNew(node);
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            System.Linq.Expressions.Expression @object = node.Object;
            var newArguments = new System.Linq.Expressions.Expression[node.Arguments.Count];
            for (int i = 0; i < node.Arguments.Count; i++)
            {
                var visited = Visit(node.Arguments[i]);
                newArguments[i] = visited;
            }
            if (@object != null)
            {
                var newObject = Visit(@object);
                var newCall = Expression.Call(newObject, node.Method, newArguments);
                return newCall;
            }
            else
            {
                var newCall = Expression.Call(node.Method, newArguments);
                return newCall;
            }
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            var newBody = Visit(node.Body);
            if (newBody is BlockExpression block && block.Variables?.Count == 0)
            {
            }
            var newLambda = Expression.Lambda(newBody, node.Parameters);
            return newLambda;
        }
    }
}
