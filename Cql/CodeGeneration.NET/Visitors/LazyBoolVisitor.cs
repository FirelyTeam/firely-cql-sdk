/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class LazyBoolAssignmentVisitor : ExpressionVisitor
    {
        private static readonly ConstructorInfo LazyCtor = typeof(Lazy<bool?>).GetConstructor(new[] { typeof(Func<bool?>) })!;

        public List<ParameterExpression> NewParameters { get; } = new List<ParameterExpression>();

        private readonly LazyBoolAccessorVisitor LazyBoolAccessorVisitor;

        public LazyBoolAssignmentVisitor()
        {
            LazyBoolAccessorVisitor = new LazyBoolAccessorVisitor(NewParameters);
        }
        protected override Expression VisitBinary(BinaryExpression node)
        {
            if (node.NodeType == ExpressionType.Assign
                && node.Type == typeof(bool?)
                && node.Left is ParameterExpression variable)
            {
                var right = Visit(node.Right);
                right = LazyBoolAccessorVisitor.Visit(right);
                var lambda = Expression.Lambda(right);
                var newLazy = Expression.New(LazyCtor, lambda);
                var newParam = Expression.Parameter(typeof(Lazy<bool?>), variable.Name);
                NewParameters.Add(newParam);
                var newAssignment = Expression.Assign(newParam, newLazy);
                return newAssignment;
            }

            return base.VisitBinary(node);
        }
    }

    internal class LazyBoolAccessorVisitor : ExpressionVisitor
    {
        private static readonly PropertyInfo LazyValue = typeof(Lazy<bool?>).GetProperty(nameof(Lazy<bool?>.Value))!;

        public List<ParameterExpression> NewParameters { get; }

        public LazyBoolAccessorVisitor(List<ParameterExpression> newParameters)
        {
            NewParameters = newParameters;
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            if (node.NodeType == ExpressionType.Assign)
                return node;
            else return base.VisitBinary(node);
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            var newArgs = new Expression[node.Arguments.Count];
            int i = 0;
            foreach (var arg in node.Arguments)
            {
                if (arg is ParameterExpression parameterArg && parameterArg.Type == typeof(bool?))
                {
                    foreach (var p in NewParameters)
                    {
                        if (p.Name == parameterArg.Name)
                        {
                            var value = Expression.MakeMemberAccess(p, LazyValue);
                            newArgs[i] = value;
                        }
                    }
                }
                else newArgs[i] = Visit(arg);
                i++;

            }
            var newCall = Expression.Call(node.Object, node.Method, newArgs);
            return newCall;
        }

        //protected override Expression VisitLambda<T>(Expression<T> node)
        //{
        //    var newBody = Visit(node.Body);
        //    var newLambda = Expression.Lambda(newBody, node.Parameters);
        //    return newLambda;
        //}


    }

}
