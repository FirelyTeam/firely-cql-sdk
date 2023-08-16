/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class ExtractLocalVariablesTransformer : ExpressionVisitor
    {
        public ExtractLocalVariablesTransformer(VariableNameGenerator generator)
        {
            NameGenerator = generator;
        }
        private readonly List<BinaryExpression> Locals = new();

        public IEnumerable<BinaryExpression> LocalAssignments => Locals;

        public VariableNameGenerator NameGenerator { get; }

        private readonly MethodInfo PropertyOrDefaultMethod = typeof(ObjectExtensions)
            .GetMethod(nameof(ObjectExtensions.PropertyOrDefault))!;

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            if (node.Method.IsGenericMethod && node.Method.GetGenericMethodDefinition() == PropertyOrDefaultMethod)
                return node;
            if (node.Arguments.Count > 0)
            {
                var newArguments = new Expression[node.Arguments.Count];
                for (int i = 0; i < node.Arguments.Count; i++)
                {
                    if (node.Arguments[i].NodeType == ExpressionType.Constant
                        || node.Arguments[i].NodeType == ExpressionType.Parameter
                        || node.Arguments[i].NodeType == ExpressionType.MemberAccess)
                    {
                        newArguments[i] = node.Arguments[i];
                    }
                    else if (node.Arguments[i].NodeType == ExpressionType.Convert
                        && node.Arguments[i] is UnaryExpression convert
                        && convert.Operand.NodeType == ExpressionType.Constant)
                    {
                        newArguments[i] = node.Arguments[i];
                    }
                    else if (node.Arguments[i].NodeType == ExpressionType.Call)
                    {
                        var reservedNames = Locals
                            .Select(l => l.Left)
                            .Cast<ParameterExpression>()
                            .Select(pe => pe.Name);
                        var subTransformer = new ExtractLocalVariablesTransformer(NameGenerator);
                        var argument = subTransformer.Visit(node.Arguments[i]);
                        Locals.AddRange(subTransformer.LocalAssignments);

                        var vn = NameGenerator.Next();
                        var newLocal = Expression.Parameter(node.Arguments[i].Type, vn);
                        var localAssignment = Expression.Assign(newLocal, argument);
                        Locals.Add(localAssignment);
                        newArguments[i] = localAssignment.Left;

                    }
                    else if (node.Arguments[i].NodeType == ExpressionType.Lambda && node.Arguments[i] is LambdaExpression lambda)
                    {
                        var reservedNames = Locals
                            .Select(l => l.Left)
                            .Cast<ParameterExpression>()
                            .Concat(lambda.Parameters)
                            .Where(pe => pe.Name != null)
                            .Select(pe => pe.Name!)!;
                        var subTransformer = new BlockTransformer(NameGenerator, reservedNames, true);
                        var newBody = subTransformer.Visit(lambda.Body) ??
                            throw new InvalidOperationException("Block transformer returned null");
                        var vn = NameGenerator.Next();
                        var newLocal = Expression.Parameter(lambda.Type, vn);
                        var newLambda = Expression.Lambda(newBody, lambda.Parameters);
                        var localAssignment = Expression.Assign(newLocal, newLambda);
                        Locals.Add(localAssignment);
                        newArguments[i] = localAssignment.Left;
                    }
                    else
                    {
                        var vn = NameGenerator.Next();
                        var newLocal = Expression.Parameter(node.Arguments[i].Type, vn);
                        var newArgument = Visit(node.Arguments[i]);
                        var localAssignment = Expression.Assign(newLocal, newArgument);
                        Locals.Add(localAssignment);
                        newArguments[i] = localAssignment.Left;
                    }
                }
                var newMethodCall = Expression.Call(node.Object, node.Method, newArguments);
                return newMethodCall;
            }
            return base.VisitMethodCall(node);
        }

        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            var newMemberBindings = new MemberBinding[node.Bindings.Count];
            for (int i = 0; i < node.Bindings.Count; i++)
            {
                if (node.Bindings[i] is MemberAssignment binding)
                {
                    var vn = NameGenerator.Next();
                    var newLocal = Expression.Parameter(binding.Expression.Type, vn);
                    var visitedExpression = Visit(binding.Expression);
                    var localAssignment = Expression.Assign(newLocal, visitedExpression);
                    Locals.Add(localAssignment);
                    newMemberBindings[i] = Expression.Bind(binding.Member, newLocal);
                }
                else
                    newMemberBindings[i] = node.Bindings[i];
            }
            var newInit = Expression.MemberInit(node.NewExpression, newMemberBindings);
            return newInit;
        }


        protected override Expression VisitNewArray(NewArrayExpression node)
        {
            // replaces
            //    var x = new T[] { exprA, exprB, exprC }};
            // with
            //    var p = exprA;
            //    var q = exprB;
            //    var r = exprC;
            //    var x = new T[] { p,q,r };

            if (node.NodeType == ExpressionType.NewArrayInit)
            {
                var newLocalVariables = node.Expressions.Select(makeLocalAssignment);
                var elementType = node.Type.GetElementType()!;
                return Expression.NewArrayInit(elementType, newLocalVariables);
            }
            else
                return node;

            ParameterExpression makeLocalAssignment(Expression valueExpr)
            {
                var vn = NameGenerator.Next();
                var newLocal = Expression.Parameter(valueExpr.Type, vn);
                var visitedExpression = Visit(valueExpr);
                var assignment = Expression.Assign(newLocal, visitedExpression);
                Locals.Add(assignment);  // note: side-effect on Locals
                return newLocal;
            }
        }


        // Not currently used
        protected override Expression VisitConditional(ConditionalExpression node)
        {
            var newTest = Visit(node.Test);
            var newIfTrue = Visit(node.IfTrue);
            var newIfFalse = Visit(node.IfFalse);

            var newConditional = Expression.Condition(newTest, newIfTrue, newIfFalse);
            return newConditional;
        }

    }
}
