/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/cql-sdk/main/LICENSE
 */

using Hl7.Cql.Compiler;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Hl7.Cql.CodeGeneration.NET.Visitors
{
    internal class ExtractLetExpressionTransformer : ExpressionVisitor
    {
        protected override Expression VisitConditional(ConditionalExpression node)
        {
            // Skip this for now
            return node;
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            var newArguments = new List<Expression>();
            var newLets = new List<BinaryExpression>();

            bool simplified = false;

            foreach (var argument in node.Arguments)
            {
                if (argument.NodeType == ExpressionType.Constant
                    || argument.NodeType == ExpressionType.Parameter)
                {
                    newArguments.Add(argument); // Unchanged;
                }
                else if (argument is UnaryExpression { NodeType: ExpressionType.Convert } convert
                    && (convert.Operand.NodeType is ExpressionType.Constant or ExpressionType.Parameter))
                {
                    newArguments.Add(argument); // Unchanged;
                }
                else if (argument is UnaryExpression { NodeType: ExpressionType.TypeAs } typeas
                    && (typeas.Operand.NodeType is ExpressionType.Constant or ExpressionType.Parameter))
                {
                    newArguments.Add(argument); // Unchanged;
                }
                else
                {
                    // transform complex argument into assignment to variable + variable as argument
                    var newLetVariable = Expression.Parameter(argument.Type);
                    newArguments.Add(newLetVariable);

                    var visitedArgument = Visit(argument);

                    var assign = Expression.Assign(newLetVariable, visitedArgument);
                    newLets.Add(assign);
                    simplified = true;
                }
            }

            if (simplified)
            {
                // TODO: Maybe simplify node.Object too?
                var expression = node.Update(node.Object, newArguments);

                return new LetExpression(newLets, expression);
            }
            else
                return node;
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

                    //if (visitedExpression is LetExpression nested)
                    //{
                    //    newLets.AddRange(nested.LetStatements);
                    //    var assign = Expression.Assign(newLetVariable, nested.Expression);
                    //    newLets.Add(assign);
                    //}
                    //else
                    //{
                    var assign = Expression.Assign(newLetVariable, visitedExpression);
                    newLets.Add(assign);
                    //}
                }

                var expression = node.Update(newExpressions);
                return new LetExpression(newLets, expression);
            }
            else
                return node;
        }

        //private LetExpression flatten(LetExpression le)
        //{
        //    // Turn:
        //    //   let x = (let y = q; expr'(y))
        //    //   expr(x)
        //    // Into:
        //    //   let y = q
        //    //   let x = expr'(y)
        //    //   expr(x)

        //    var flattenedLetStatements = new List<BinaryExpression>();
        //    foreach (var letStatement in le.LetStatements)
        //    {
        //        if (letStatement.Right is LetExpression nestedLetStatement)
        //        {
        //            flattenedLetStatements.AddRange(nestedLetStatement.LetStatements);
        //            var updatedLetStatement = letStatement.Update(letStatement.Left, letStatement.Conversion, nestedLetStatement.Expression);
        //            flattenedLetStatements.Add(updatedLetStatement);
        //        }
        //    }

        //    return le.Update(flattenedLetStatements, le.Expression);
        //}
    }
}
