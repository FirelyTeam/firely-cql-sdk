/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class ExtractLetExpressionTransformer : ExpressionVisitor
    {
        [return: NotNullIfNotNull("node")]
        public override Expression? Visit(Expression? node)
        {
            if (node is null) return null;

            return node switch
            {
                ConditionalExpression cond => VisitConditional(cond),
                UnaryExpression unary => VisitUnary(unary),
                MethodCallExpression methodCall => VisitMethodCall(methodCall),
                MemberInitExpression memberInit => VisitMemberInit(memberInit),
                NewArrayExpression newArray => VisitNewArray(newArray),
                ConstantExpression newConstant => VisitConstant(newConstant),
                ParameterExpression parameter => VisitParameter(parameter),
                _ => new LetExpression(Enumerable.Empty<BinaryExpression>(), base.Visit(node))
            };
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            // Skip this for now: extracting lets here is possible, but would also
            // leading to loss of performance, i.e. this would turn:
            //      if(something, expensiveA(x), expensiveB(x));
            // into:
            //      let p = expensiveA(x),
            //          q = expensiveB(x),
            //      in if(something, p, q)
            // causing expensiveA and expensiveB to be run both regardless of the test.
            return node;
        }


        protected override Expression VisitConstant(ConstantExpression node)
        {
            return node;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            return node;
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            if (node is UnaryExpression { NodeType: ExpressionType.Convert or ExpressionType.TypeAs } convert)
            {
                // Unless this is a simple cast from a constant or parameter,
                // we need to split the ((X)x) into { let y = x in (int)X };                
                if (node.Operand.NodeType is ExpressionType.Constant or ExpressionType.Parameter)
                    return convert;
                else
                {
                    var visitedOperand = Visit(node.Operand);
                    var newParam = Expression.Parameter(visitedOperand.Type);
                    var letStatement = Expression.Assign(newParam, visitedOperand);
                    var newConvert = convert.Update(newParam);
                    return new LetExpression(new[] { letStatement }, newConvert);
                }
            }
            else
                return new LetExpression(Enumerable.Empty<BinaryExpression>(), node);
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            var newArguments = new List<Expression>();
            var newLets = new List<BinaryExpression>();

            foreach (var argument in node.Arguments)
            {
                var visitedArgument = Visit(argument);

                if (visitedArgument != argument)
                {
                    // transform complex into assignment to variable + variable
                    var newLetVariable = Expression.Parameter(argument.Type);
                    newArguments.Add(newLetVariable);

                    var assign = Expression.Assign(newLetVariable, visitedArgument);
                    newLets.Add(assign);
                }
                else
                    newArguments.Add(argument);
            }

            // TODO: Maybe simplify node.Object too?
            var expression = node.Update(node.Object, newArguments);
            return new LetExpression(newLets, expression);
        }

        // Linq.Expressions needs an explicit conversion from a value type
        // type to object, but the C# compiler will insert that boxing,
        // so we can remove those casts. 
        internal static Expression StripBoxing(Expression node)
        {
            // (x as object) => x
            // ((object)x) => x
            if (node is UnaryExpression
                {
                    NodeType: ExpressionType.ConvertChecked or
                            ExpressionType.Convert or
                            ExpressionType.TypeAs
                } cast &&
                cast.Type == typeof(object) &&
                cast.Operand.Type.IsValueType)
            {
                return StripBoxing(cast.Operand);
            }
            else
            {
                return node;
            }
        }

        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            var newMemberBindings = new List<MemberBinding>();
            var newLets = new List<BinaryExpression>();

            foreach (var binding in node.Bindings)
            {
                if (binding is MemberAssignment memberAssignment)
                {
                    var newLetVariable = Expression.Parameter(memberAssignment.Expression.Type);
                    newMemberBindings.Add(Expression.Bind(memberAssignment.Member, newLetVariable));

                    var visitedExpression = Visit(memberAssignment.Expression);
                    var assign = Expression.Assign(newLetVariable, visitedExpression);
                    newLets.Add(assign);
                }
                else
                    newMemberBindings.Add(binding);
            }

            var expression = node.Update(node.NewExpression, newMemberBindings);

            return new LetExpression(newLets, expression);
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
                var newLets = new List<BinaryExpression>();
                var newExpressions = new List<Expression>();

                foreach (var valueExpr in node.Expressions)
                {
                    var newLetVariable = Expression.Parameter(valueExpr.Type);
                    newExpressions.Add(newLetVariable);

                    var visitedExpression = Visit(valueExpr);
                    var assign = Expression.Assign(newLetVariable, visitedExpression);
                    newLets.Add(assign);
                }

                var expression = node.Update(newExpressions);
                return new LetExpression(newLets, expression);
            }
            else
                return node;
        }
    }
}
