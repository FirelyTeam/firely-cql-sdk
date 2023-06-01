using System.Collections.Generic;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class ParameterReplacer : ExpressionVisitor
    {
        public ParameterReplacer(IDictionary<string, ParameterExpression> replacements)
        {
            Replacements = replacements;
        }

        public IDictionary<string, ParameterExpression> Replacements { get; }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            if (node.Name != null && Replacements.TryGetValue(node.Name, out var replacement))
                return replacement;
            else
                return base.VisitParameter(node);
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            var replace = false;
            var newMethodObject = node.Object;
            // check object & arguments for opportunities to replace
            if (node.Object is ParameterExpression objectParameter && objectParameter.Name != null)
            {
                if (Replacements.TryGetValue(objectParameter.Name, out var newObject))
                {
                    newMethodObject = newObject;
                    replace = true;
                }
            }
            var newArguments = new Expression[node.Arguments.Count];
            for (int i = 0; i < newArguments.Length; i++)
            {
                var newArg = node.Arguments[i];
                if (newArg is ParameterExpression argParameter && argParameter.Name != null)
                {
                    if (argParameter.Name == "p")
                    {
                    }
                    if (Replacements.TryGetValue(argParameter.Name, out var newParameter))
                    {
                        // this shouldn't happen
                        if (argParameter.Type == newParameter.Type)
                        {
                            newArg = newParameter;
                            replace = true;
                        }
                        else
                        {
                            // this shouldn't happen - there is a bug in localvariablededuper
                        }
                    }
                }
                newArguments[i] = newArg;
            }

            if (replace)
            {
                var newCall = Expression.Call(newMethodObject, node.Method, newArguments);
                return newCall;
            }
            else
                return node;

        }

        protected override Expression VisitBlock(BlockExpression node)
        {
            var newExpressions = new List<Expression>();
            foreach (var expression in node.Expressions)
            {
                if (expression is BinaryExpression be
                    && be.Left is ParameterExpression parameter
                    && parameter.Name != null
                    && Replacements.Keys.Contains(parameter.Name))
                {
                    continue;
                }
                else
                {
                    newExpressions.Add(Visit(expression));
                }
            }
            var newBlock = Expression.Block(node.Variables, newExpressions.ToArray());
            return newBlock;
        }

        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            var newMemberBindings = new MemberBinding[node.Bindings.Count];
            for (int i = 0; i < node.Bindings.Count; i++)
            {
                if (node.Bindings[i] is MemberAssignment binding)
                {
                    if (binding.Expression is ParameterExpression)
                    {
                        var visited = Visit(binding.Expression);
                        newMemberBindings[i] = Expression.Bind(binding.Member, visited);
                    }
                    else
                    {
                        newMemberBindings[i] = node.Bindings[i];
                    }
                }
                else
                    newMemberBindings[i] = node.Bindings[i];
            }
            var newInit = Expression.MemberInit(node.NewExpression, newMemberBindings);
            return newInit;
        }

        //protected override Expression VisitLambda<T>(Expression<T> node)
        //{
        //    var newBody = Visit(node.Body);
        //    var newLambda = Expression.Lambda(newBody, node.Parameters);
        //    return newLambda;
        //}
    }
}
