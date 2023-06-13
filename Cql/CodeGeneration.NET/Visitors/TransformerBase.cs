/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using System;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class TransformerBase : ExpressionVisitor
    {

        protected override Expression VisitNew(NewExpression node)
        {
            if (node.Constructor == null)
                throw new ArgumentException($"NewExpression does not have a Constructor property");
            if (node.Arguments?.Count > 0)
            {
                var newArguments = new Expression[node.Arguments.Count];
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
            Expression? @object = node.Object;
            var newArguments = new Expression[node.Arguments.Count];
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
