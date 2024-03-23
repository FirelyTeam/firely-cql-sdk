#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/* 
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using System;
using System.Linq.Expressions;
using Microsoft.Extensions.Logging;
using elm = Hl7.Cql.Elm;

namespace Hl7.Cql.Compiler
{
    internal partial class ExpressionBuilderContext
    {

        protected Expression? Combine(elm.Combine e)
        {
            ExpressionBuilderContext ctx = this;
            var source = ctx.TranslateExpression(e.source!);
            var operand = e.separator == null
                ? Expression.Constant(null, typeof(string))
                : ctx.TranslateExpression(e.separator);
            var call = ctx.OperatorBinding.Bind(CqlOperator.Combine, ctx.RuntimeContextParameter, source, operand);
            return call;
        }

        protected Expression Concatenate(elm.Concatenate e) =>
            NaryOperator(CqlOperator.Concatenate, e);

        protected Expression? EndsWith(elm.EndsWith e) =>
            BinaryOperator(CqlOperator.EndsWith, e);

        protected Expression Indexer(elm.Indexer e)
        {
            ExpressionBuilderContext ctx = this;
            var left = ctx.TranslateExpression(e!.operand![0]!);
            var right = ctx.TranslateExpression(e!.operand![1]!);
            if (left.Type == typeof(string))
            {
                return ctx.OperatorBinding.Bind(CqlOperator.CharAt, ctx.RuntimeContextParameter, left, right);
            }
            else if (IsOrImplementsIEnumerableOfT(left.Type))
            {
                return ctx.OperatorBinding.Bind(CqlOperator.ElementAt, ctx.RuntimeContextParameter, left, right);
            }
            else throw new NotImplementedException().WithContext(ctx);
        }

        protected Expression? LastPositionOf(elm.LastPositionOf e)
        {
            ExpressionBuilderContext ctx = this;
            var @string = ctx.TranslateExpression(e!.@string!);
            var pattern = ctx.TranslateExpression(e!.pattern!);
            return ctx.OperatorBinding.Bind(CqlOperator.LastPositionOf, ctx.RuntimeContextParameter, @string, pattern);
        }

        protected Expression? Length(elm.Length len)
        {
            ExpressionBuilderContext ctx = this;
            var operand = ctx.TranslateExpression(len.operand!);
            if (IsOrImplementsIEnumerableOfT(operand.Type))
            {
                return ctx.OperatorBinding.Bind(CqlOperator.ListLength, ctx.RuntimeContextParameter, operand);
            }
            else if (operand.Type == typeof(string))
            {
                return ctx.OperatorBinding.Bind(CqlOperator.StringLength, ctx.RuntimeContextParameter, operand);
            }
            else throw new NotImplementedException().WithContext(ctx);
        }

        protected Expression? Lower(elm.Lower e) =>
            UnaryOperator(CqlOperator.Lower, e);

        protected Expression? Matches(elm.Matches e) =>
            BinaryOperator(CqlOperator.Matches, e);

        protected Expression PositionOf(elm.PositionOf e)
        {
            ExpressionBuilderContext ctx = this;
            var @string = ctx.TranslateExpression(e!.@string!);
            var pattern = ctx.TranslateExpression(e!.pattern!);
            return ctx.OperatorBinding.Bind(CqlOperator.PositionOf, ctx.RuntimeContextParameter, pattern, @string);

        }

        protected Expression? ReplaceMatches(elm.ReplaceMatches e)
        {
            ExpressionBuilderContext ctx = this;
            var source = ctx.TranslateExpression(e.operand![0]!);
            var pattern = ctx.TranslateExpression(e.operand![1]!);
            var substitution = ctx.TranslateExpression(e.operand![2]!);
            return ctx.OperatorBinding.Bind(CqlOperator.ReplaceMatches, ctx.RuntimeContextParameter, source, pattern, substitution);
        }

        protected Expression Split(elm.Split e)
        {
            ExpressionBuilderContext ctx = this;
            var stringToSplit = ctx.TranslateExpression(e.stringToSplit!);
            var separator = ctx.TranslateExpression(e.separator!);
            return ctx.OperatorBinding.Bind(CqlOperator.Split, ctx.RuntimeContextParameter, stringToSplit, separator);
        }

        protected Expression? StartsWith(elm.StartsWith e) =>
            BinaryOperator(CqlOperator.StartsWith, e);

        protected Expression? Substring(elm.Substring e)
        {
            ExpressionBuilderContext ctx = this;
            var stringToSub = ctx.TranslateExpression(e!.stringToSub!);
            var startIndex = ctx.TranslateExpression(e!.startIndex!);
            var length = e.length == null
                ? Expression.Constant(null, typeof(int?))
                : ctx.TranslateExpression(e.length);
            return ctx.OperatorBinding.Bind(CqlOperator.Substring, ctx.RuntimeContextParameter, stringToSub, startIndex, length);
        }

        protected Expression? Upper(elm.Upper e) =>
            UnaryOperator(CqlOperator.Upper, e);
    }
}
